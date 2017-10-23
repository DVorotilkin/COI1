using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Laba1_COI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //--
        #region Переменные

        int width, height;//Размеры изображения

        //------Для оригинального изображения
        Bitmap OriginalImage;
        byte[, ,] OriginalImageByte;

        //------Для изменённого изображения
        Bitmap AlteredImage;
        byte[, ,] AlteredImageByte;

        //-----Для сохранения оригинального изображения при добавлении шума
        Bitmap BackupImage;
        byte[, ,] BackupImageByte;

        //------Для масштабирования и среза
        int firstFlag, secondFlag, coofContrastScaling;

        int sigma, scale;//Сигама для фильтра и размер апертуры фильтра
        int k;//Количество соседей для фильтра

        bool FormsSuccessfullFlag = false;//Нажал ли пользователь "Применить" в дочерней форме
        bool IsNoiseImageByte = false;//Зашумлено ли изображение
        bool IsNoiseImage;//Отображено зашумлённое изображение или нет

        #endregion

        //--
        #region Работа меню программы

        //----Файл
        #region Меню "Файл"

        private void загрузитьИзображениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    IsNoiseImageByte = false;
                    OriginalImage = (Bitmap)Bitmap.FromFile(openFileDialog1.FileName);
                    EnabledMeny(true);
                    width = OriginalImage.Width;
                    height = OriginalImage.Height;
                    DownConsole.Text = "Изображение успешно загружено.";
                    OriginalImageByte = toBytes(OriginalImage);
                    pictureBox1.Image = OriginalImage;
                    pictureBox2.Image = null;
                    label1.Text = "Количество пикселей: " + (height * width).ToString();
                }
                catch (Exception openE)
                {
                    DownConsole.Text = "Невозможно загрузить изображение: " + openE.Message;
                }
            }
        }
        //------Пункт меню  загрузки изображений

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //------Пункт меню выхода из программы

        #endregion

        //----Процедуры
        #region Меню "Процедуры"

        private void контрастноеМаштабированиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ContrastScalingDialog CSD = new ContrastScalingDialog();
            CSD.Owner = this;
            CSD.ShowDialog();
            if (FormsSuccessfullFlag)
            {
                AlteredImageByte = ContrastScaling(OriginalImageByte);
                DownConsole.Text = "К изображению успешно применена процедура контрастного масштабирования.";
                AlteredImage = toBitmap(AlteredImageByte);
                pictureBox2.Image = AlteredImage;
            }
            FormsSuccessfullFlag = false;
        }
        //------Пункт меню контрастное линейное масштабирование
    
        private void инвертированноеКонтрастноеМасштабированиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlteredImageByte = InvertedContrastScaling(OriginalImageByte);
            AlteredImage = toBitmap(AlteredImageByte);
            DownConsole.Text = "К изображению успешно применена процедура инвертированного контрастного масштабирования.";
            pictureBox2.Image = AlteredImage;
        }
        //------Пункт меню инвертированное контрастное масштабирование
       
        private void яркостнойСрезToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BrightCut BC = new BrightCut();
            BC.Owner = this;
            BC.ShowDialog();
            if (FormsSuccessfullFlag)
            {
                AlteredImageByte = BrightCut(OriginalImageByte);
                DownConsole.Text = "К изображению успешно применена процедура яркостного среза.";
                AlteredImage = toBitmap(AlteredImageByte);
                pictureBox2.Image = AlteredImage;
            }
            FormsSuccessfullFlag = false;
        }
        //------Пункт меню яркостной срез

        #endregion

        //----Гистограмма
        #region Меню "Гистограмма"

        private void равномернаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Histogramm H = new Histogramm(1);
            H.Owner = this;
            H.Show();
        }
        //------Пункт меню Равномерная

        private void экспоненциальнаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Histogramm H = new Histogramm(2);
            H.Owner = this;
            H.Show();
        }
        //------Пункт меню экспоненциальная

        private void законРаспределенияРелеяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Histogramm H = new Histogramm(3);
            H.Owner = this;
            H.Show();
        }
        //------Пункт меню закон распределения Релея

        private void степени23ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Histogramm H = new Histogramm(4);
            H.Owner = this;
            H.Show();
        }
        //------Пункт меня степени 2/3

        private void гиперболическаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Histogramm H = new Histogramm(5);
            H.Owner = this;
            H.Show();
        }
        //------Пункт меню гиперболическая

        #endregion
        #endregion

        //--
        #region Методы обработки изобрадений

        //----Контрастное линейное масштабирование
        #region Контрастное линейное масштабирование

        private byte[, ,] ContrastScaling(byte[, ,] byteMass)
        {
            byte[, ,] res = new byte[3, height, width];
            double tang = Math.Tan(coofContrastScaling * Math.PI / 180);
            for (int y = 0; y < height; y++)
                for (int x = 0; x < width; x++)
                {
                    res[0, y, x] = CompationParametersCS(byteMass[0, y, x], tang);
                    res[1, y, x] = CompationParametersCS(byteMass[1, y, x], tang);
                    res[2, y, x] = CompationParametersCS(byteMass[2, y, x], tang);
                }
            return res;
        }
        //------Метод формирования массива изменённого изображения метода

        private byte CompationParametersCS(byte pixel, double tan)
        {
            double value = pixel * tan;
            if (value < firstFlag)
                return 0;
            else if (value > secondFlag)
                return 255;
            else
                return Convert.ToByte(value);
        }
        //------Метод возращающий значение канала пикселя преобразованного методом

        public void setContrastScalingPar(int coof, int first, int second)
        {
            this.coofContrastScaling = coof;
            this.firstFlag = first;
            this.secondFlag = second;
        }
        //------Метод передающий из дочерней формы параметры метода

        #endregion

        //----Инверсия
        private byte[, ,] InvertedContrastScaling(byte[, ,] byteMass)
        {
            byte[, ,] res = new byte[3, height, width];
            for (int y = 0; y < height; y++)
                for (int x = 0; x < width; x++)
                {
                    res[0, y, x] = (byte)(255 - byteMass[0, y, x]);
                    res[1, y, x] = (byte)(255 - byteMass[1, y, x]);
                    res[2, y, x] = (byte)(255 - byteMass[2, y, x]);
                }
            return res;
        }

        //----Яркостной срез
        #region Яркостной срез

        private byte[, ,] BrightCut(byte[, ,] byteMass)
        {
            byte[, ,] res = new byte[3, height, width];
            for (int y = 0; y < height; y++)
                for (int x = 0; x < width; x++)
                {
                    res[0, y, x] = CompationParametersBC(byteMass[0, y, x]);
                    res[1, y, x] = CompationParametersBC(byteMass[1, y, x]);
                    res[2, y, x] = CompationParametersBC(byteMass[2, y, x]);
                }
            return res;
        }
        //------Метод формирующий изменённое изображение метода

        private byte CompationParametersBC(byte pixel)
        {
            if (pixel >= firstFlag && pixel <= secondFlag)
                return pixel;
            else
                return 0;
        }
        //------Метод возвращающий значение канала пикселя обработанного методом

        public void setBrightCut(int firstFlag, int secondFlag)
        {
            this.firstFlag = firstFlag;
            this.secondFlag = secondFlag;
        }
        //------Метод передающий из дочерней формы параметры метода 

        #endregion
        #endregion

        //--
        #region Специальные и служебные методы

        //----Методы get
        #region Методы get

        public int getHeight()
        {
            return height;
        }
        //------Метод возвращающий высоту изображения

        public int getWidth()
        {
            return width;
        }
        //------Метод возвращающий ширину изображения

        public byte[, ,] getOriginalImageByte()
        {
            return OriginalImageByte;
        }
        //------Метод возращающий массив байтов оригинального изображения

        public byte[, ,] getAlteredImageByte()
        {
            return AlteredImageByte;
        }
        //------Метод возвращающий массив байтов изменённого изображения

        public byte[, ,] getBackupImageByte()
        {
            return BackupImageByte;
        }
        //------Метод возвращающий массив байтов изображения в Бэкапе

        public Bitmap getOriginalImage()
        {
            return OriginalImage;
        }
        //------Метод возарщающий орагинальне изображение

        public bool getIsNoisedImageByte()
        {
            return IsNoiseImageByte;
        }
        //------Метод возращающий логическое значение является ли изображение зашумлённым

        #endregion

        //----Методы set
        #region Методы set

        public void setPictureBox2(byte[, ,] byteMass)
        {
            pictureBox2.Image = toBitmap(byteMass);
        }
        //------Метод заменющий пикчерБокс2 на приходящий массив байт

        public void setAlteredImageByte(byte[,,] byteMass)
        {
            AlteredImageByte = (byte[,,])byteMass.Clone();
        }
        //------Метод заменющий массив изменённого изображения на приходящий массив байт

        #endregion

        //----Методы изменения bool переменных
        #region Методы изменения bool переменных

        private void EnabledMeny(bool flag)
        {
            процедурыToolStripMenuItem.Enabled =
            алгоритмыToolStripMenuItem.Enabled = flag;
        }
        //------Метод определяет активны ли меню обработки изображения

        public void isSeccessfullyForm(bool flag)
        {
            FormsSuccessfullFlag = flag;
        }
        //------Метод определяет, нажал ли пользователь кнопку "Применить" в дочерней форме

        #endregion

        //----Методы конвертации данны
        #region Методы конвертации данны

        public byte[, ,] toBytes(Bitmap bmp)
        {
            byte[, ,] res = new byte[3, height, width];
            for (int y = 0; y < height; ++y)
                for (int x = 0; x < width; ++x)
                {
                    Color color = bmp.GetPixel(x, y);
                    res[0, y, x] = color.R;
                    res[1, y, x] = color.G;
                    res[2, y, x] = color.B;
                }
            return res;
        }
        //------Метод конвертирует изображение в массив байт

        public Bitmap toBitmap(byte[, ,] byteMass)
        {
            Bitmap res = new Bitmap(width, height);
            for (int y = 0; y < height; ++y)
                for (int x = 0; x < width; ++x)
                {
                    Color color = Color.FromArgb(byteMass[0, y, x],
                        byteMass[1, y, x],
                        byteMass[2, y, x]);
                    res.SetPixel(x, y, color);
                }
            return res;
        }
        //------Метод конвертирует массив байт в изображение

        public byte toByte(int pixel)
        {
            if (pixel <= 0)
                return 0;
            else if (pixel > 255)
                return 255;
            else
                return (byte)pixel;
        }
        //------Метод ковертирует значение типа int в значение типа byte

        #endregion

        //----Служебные методы
        #region Служебные методы

        public void ApplyNoise(byte[, ,] noiseImage)
        {
            BackupImageByte = OriginalImageByte;
            OriginalImageByte = noiseImage;
            pictureBox2.Image = null;
        }
        //------Метод применяет к изображению шум

        public int MultMatrix(int[,] firstMatrix, byte[,,] byteMass, int y, int x, int chennal, int scale)
        {
            int sum = 0;
            int shift = (scale - 1) / 2;
            for (int i = -shift; i < shift+1; i++)
                for (int j = -shift; j < shift+1; j++)
                {
                    sum += firstMatrix[i+shift, j+shift] * byteMass[chennal,y+i,x+j];
                }
            return sum;
        }
        //------Метод применения маски к участку изображения

        private int[,] RotateMatrix(int[,] Matrix)
        {
            int[,] NewMatrix = new int[3, 3];
            for (int i = 0; i <= 2; i++)
                for (int j = 0; j <= 2; j++)
                {
                    if (i == 0 && (j >= 0 && j < 2))
                        NewMatrix[i, j + 1] = Matrix[i, j];
                    else if (j == 2 && (i >= 0 && i < 2))
                        NewMatrix[i + 1, j] = Matrix[i, j];
                    else if (i == 2 && (j > 0 && j <= 2))
                        NewMatrix[i, j - 1] = Matrix[i, j];
                    else if (j == 0 && (i > 0 && i <= 2))
                        NewMatrix[i - 1, j] = Matrix[i, j];
                    else
                        NewMatrix[i, j] = Matrix[i, j];
                }
            return NewMatrix;
        }
        //------Метода поворачивает входящую матрицу на 45 градусов

        #endregion

        #endregion
               
    }
}