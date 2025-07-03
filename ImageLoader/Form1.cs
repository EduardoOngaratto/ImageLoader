using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ImageLoader
{
    public partial class Form1 : Form
    {
        private Bitmap img1, img2, imgResult;

        public Form1()
        {
            InitializeComponent();
        }

        private void btImg1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                img1 = new Bitmap(openFileDialog.FileName);
                pictureBox1.Image = img1;
            }
        }

        private void btImg2_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                img2 = new Bitmap(openFileDialog.FileName);
                pictureBox2.Image = img2;
            }
        }

        private void AumentarBrilhoButton_Click(object sender, EventArgs e)
        {

            if (img1 == null)
            {
                MessageBox.Show("Carregue uma imagem primeiro.");
                return;
            }

            if (!int.TryParse(QuantidadeBrilho.Text, out int brilho))
            {
                MessageBox.Show("Insira um valor numérico válido para o brilho.");
                return;
            }

            if (brilho > 250)
            {
                MessageBox.Show("O valor limite foi ultrapassado!");
                return;
            }

            int width = img1.Width;
            int height = img1.Height;
            imgResult = new Bitmap(width, height);

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color pixel = img1.GetPixel(x, y);

                    int R = Math.Min(pixel.R + brilho, 255);
                    int G = Math.Min(pixel.G + brilho, 255);
                    int B = Math.Min(pixel.B + brilho, 255);

                    imgResult.SetPixel(x, y, Color.FromArgb(R, G, B));
                }
            }

            pictureBox3.Image = imgResult;
        }
        private void DiminuirBrilho_Click(object sender, EventArgs e)
        {
            if (img1 == null)
            {
                MessageBox.Show("Carregue uma imagem primeiro.");
                return;
            }
           
            if (!int.TryParse(QuantidadeBrilho.Text, out int brilho))
            {
                MessageBox.Show("Insira um valor numérico válido para o brilho.");
                return;
            }

            if(brilho > 250)
            {
                MessageBox.Show("O valor limite foi ultrapassado!");
                return;
            }

            int width = img1.Width;
            int height = img1.Height;
            imgResult = new Bitmap(width, height);

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color pixel = img1.GetPixel(x, y);

                    int R = Math.Max(pixel.R - brilho, 0);  
                    int G = Math.Max(pixel.G - brilho, 0);
                    int B = Math.Max(pixel.B - brilho, 0);

                    imgResult.SetPixel(x, y, Color.FromArgb(R, G, B));
                }
            }

            pictureBox3.Image = imgResult;
        }

        private void aumentarContraste_Click(object sender, EventArgs e)
        {
            if (img1 == null)
            {
                MessageBox.Show("Carregue uma imagem primeiro.");
                return;
            }

            if (!float.TryParse(quantidadeContraste.Text, out float contraste))
            {
                MessageBox.Show("Insira um valor numérico válido para o contraste.");
                return;
            }

            int width = img1.Width;
            int height = img1.Height;
            imgResult = new Bitmap(width, height);

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color pixel = img1.GetPixel(x, y);

                    int R = Math.Min(Math.Max((int)(pixel.R * contraste), 0), 255);
                    int G = Math.Min(Math.Max((int)(pixel.G * contraste), 0), 255);
                    int B = Math.Min(Math.Max((int)(pixel.B * contraste), 0), 255);

                    imgResult.SetPixel(x, y, Color.FromArgb(R, G, B));
                }
            }

            pictureBox3.Image = imgResult;
        }
        private void DiminuirContraste_Click(object sender, EventArgs e)
        {
            if (img1 == null)
            {
                MessageBox.Show("Carregue uma imagem primeiro.");
                return;
            }

            if (!float.TryParse(quantidadeContraste.Text, out float contraste))
            {
                MessageBox.Show("Insira um valor numérico válido para o contraste.");
                return;
            }

            int width = img1.Width;
            int height = img1.Height;
            imgResult = new Bitmap(width, height);

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color pixel = img1.GetPixel(x, y);

                   
                    int R = Math.Min(Math.Max((int)(pixel.R / contraste), 0), 255);
                    int G = Math.Min(Math.Max((int)(pixel.G / contraste), 0), 255);
                    int B = Math.Min(Math.Max((int)(pixel.B / contraste), 0), 255);

                    imgResult.SetPixel(x, y, Color.FromArgb(R, G, B));
                }
            }

            pictureBox3.Image = imgResult;
        }
        private void salvar_Click(object sender, EventArgs e)
        {
            if (imgResult == null)
            {
                MessageBox.Show("Não há imagem resultante para salvar.");
                return;
            }

           
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PNG Image|*.png|JPEG Image|*.jpg|Bitmap Image|*.bmp";
            saveFileDialog.Title = "Salvar Imagem";

            
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    
                    string extension = saveFileDialog.FileName.Substring(saveFileDialog.FileName.LastIndexOf('.')).ToLower();

                    if (extension == ".png")
                    {
                        imgResult.Save(saveFileDialog.FileName, ImageFormat.Png);
                    }
                    else if (extension == ".jpg" || extension == ".jpeg")
                    {
                        imgResult.Save(saveFileDialog.FileName, ImageFormat.Jpeg);
                    }
                    else if (extension == ".bmp")
                    {
                        imgResult.Save(saveFileDialog.FileName, ImageFormat.Bmp);
                    }

                    MessageBox.Show("Imagem salva com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao salvar a imagem: " + ex.Message);
                }
            }
        }

        private bool EhImagemBinaria(Bitmap imagem)
        {
            for (int y = 0; y < imagem.Height; y++)
            {
                for (int x = 0; x < imagem.Width; x++)
                {
                    Color pixel = imagem.GetPixel(x, y);
                    if (!((pixel.R == 0 || pixel.R == 255) &&
                          (pixel.G == 0 || pixel.G == 255) &&
                          (pixel.B == 0 || pixel.B == 255)))
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private void escalaCinza_Click(object sender, EventArgs e)
        {
            if (img1 == null)
            {
                MessageBox.Show("Carregue uma imagem primeiro.");
                return;
            }

            int width = img1.Width;
            int height = img1.Height;
            imgResult = new Bitmap(width, height);

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color pixel = img1.GetPixel(x, y);

                   
                    int cinza = (int)(0.299 * pixel.R + 0.587 * pixel.G + 0.114 * pixel.B);

                  
                    imgResult.SetPixel(x, y, Color.FromArgb(cinza, cinza, cinza));
                }
            }

            pictureBox3.Image = imgResult;
        }

        private void InverterDireita_Click(object sender, EventArgs e)
        {
            if (img1 == null)
            {
                MessageBox.Show("Carregue uma imagem primeiro.");
                return;
            }

            int width = img1.Width;
            int height = img1.Height;
            imgResult = new Bitmap(width, height);

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                
                    Color pixel = img1.GetPixel(width - x - 1, y);
                    imgResult.SetPixel(x, y, pixel);
                }
            }

            pictureBox3.Image = imgResult;
        }

        private void inverterEsquerda_Click(object sender, EventArgs e)
        {
            if (img1 == null)
            {
                MessageBox.Show("Carregue uma imagem primeiro.");
                return;
            }

            int width = img1.Width;
            int height = img1.Height;
            imgResult = new Bitmap(width, height);

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    
                    Color pixel = img1.GetPixel(x, height - y - 1);
                    imgResult.SetPixel(x, y, pixel);
                }
            }

            pictureBox3.Image = imgResult;
        }

        private void diferencaImagem_Click(object sender, EventArgs e)
        {
            if (img1 == null || img2 == null)
            {
                MessageBox.Show("Carregue ambas as imagens primeiro.");
                return;
            }

           
            if (img1.Width != img2.Width || img1.Height != img2.Height)
            {
                MessageBox.Show("As imagens precisam ter o mesmo tamanho.");
                return;
            }

            int width = img1.Width;
            int height = img1.Height;
            imgResult = new Bitmap(width, height);

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color color1 = img1.GetPixel(x, y);
                    Color color2 = img2.GetPixel(x, y);

                   
                    int R = Math.Abs(color1.R - color2.R);
                    int G = Math.Abs(color1.G - color2.G);
                    int B = Math.Abs(color1.B - color2.B);

                    
                    imgResult.SetPixel(x, y, Color.FromArgb(R, G, B));
                }
            }

            pictureBox3.Image = imgResult;
        }

        private void combinacaoLinear_Click(object sender, EventArgs e)
        {
                if (img1 == null || img2 == null)
                {
                    MessageBox.Show("Carregue ambas as imagens primeiro.");
                    return;
                }

                if (!float.TryParse(NumcombinaLinear.Text, out float c) || c < 0 || c > 1)
                {
                    MessageBox.Show("Insira um valor entre 0 e 1 para o fator de combinação.");
                    return;
                }

                int width = Math.Min(img1.Width, img2.Width);
                int height = Math.Min(img1.Height, img2.Height);
                imgResult = new Bitmap(width, height);

                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        Color p = img1.GetPixel(x, y);
                        Color q = img2.GetPixel(x, y);

                        int R = (int)(c * p.R + (1 - c) * q.R);
                        int G = (int)(c * p.G + (1 - c) * q.G);
                        int B = (int)(c * p.B + (1 - c) * q.B);

                        imgResult.SetPixel(x, y, Color.FromArgb(R, G, B));
                    }
                }

                pictureBox3.Image = imgResult;
        }

        private void mediaclick_Click(object sender, EventArgs e)
        {
            if (img1 == null || img2 == null)
            {
                MessageBox.Show("Carregue ambas as imagens primeiro.");
                return;
            }

            int width = Math.Min(img1.Width, img2.Width);
            int height = Math.Min(img1.Height, img2.Height);
            imgResult = new Bitmap(width, height);

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color p = img1.GetPixel(x, y);
                    Color q = img2.GetPixel(x, y);

                    int R = (p.R + q.R) / 2;
                    int G = (p.G + q.G) / 2;
                    int B = (p.B + q.B) / 2;

                    imgResult.SetPixel(x, y, Color.FromArgb(R, G, B));
                }
            }

            pictureBox3.Image = imgResult;
        }

        private void andButton_Click(object sender, EventArgs e)
        {
            if (img1 == null || img2 == null)
            {
                MessageBox.Show("Carregue ambas as imagens primeiro.");
                return;
            }

            if (!EhImagemBinaria(img1) || (img2 != null && !EhImagemBinaria(img2)))
            {
                MessageBox.Show("As imagens devem ser binárias (apenas preto e branco).");
                return;
            }

            int width = Math.Min(img1.Width, img2.Width);
            int height = Math.Min(img1.Height, img2.Height);
            imgResult = new Bitmap(width, height);

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color c1 = img1.GetPixel(x, y);
                    Color c2 = img2.GetPixel(x, y);

                    int R = c1.R & c2.R;
                    int G = c1.G & c2.G;
                    int B = c1.B & c2.B;

                    imgResult.SetPixel(x, y, Color.FromArgb(R, G, B));
                }
            }

            pictureBox3.Image = imgResult;
        }

        private void orButton_Click(object sender, EventArgs e)
        {
            if (img1 == null || img2 == null)
            {
                MessageBox.Show("Carregue ambas as imagens primeiro.");
                return;
            }

            if (!EhImagemBinaria(img1) || (img2 != null && !EhImagemBinaria(img2)))
            {
                MessageBox.Show("As imagens devem ser binárias (apenas preto e branco).");
                return;
            }

            int width = Math.Min(img1.Width, img2.Width);
            int height = Math.Min(img1.Height, img2.Height);
            imgResult = new Bitmap(width, height);

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color c1 = img1.GetPixel(x, y);
                    Color c2 = img2.GetPixel(x, y);

                    int R = c1.R | c2.R;
                    int G = c1.G | c2.G;
                    int B = c1.B | c2.B;

                    imgResult.SetPixel(x, y, Color.FromArgb(R, G, B));
                }
            }

            pictureBox3.Image = imgResult;
        }

        private void xorButton_Click(object sender, EventArgs e)
        {
            if (img1 == null || img2 == null)
            {
                MessageBox.Show("Carregue ambas as imagens primeiro.");
                return;
            }

            if (!EhImagemBinaria(img1) || (img2 != null && !EhImagemBinaria(img2)))
            {
                MessageBox.Show("As imagens devem ser binárias (apenas preto e branco).");
                return;
            }

            int width = Math.Min(img1.Width, img2.Width);
            int height = Math.Min(img1.Height, img2.Height);
            imgResult = new Bitmap(width, height);

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color c1 = img1.GetPixel(x, y);
                    Color c2 = img2.GetPixel(x, y);

                    int R = c1.R ^ c2.R;
                    int G = c1.G ^ c2.G;
                    int B = c1.B ^ c2.B;

                    imgResult.SetPixel(x, y, Color.FromArgb(R, G, B));
                }
            }

            pictureBox3.Image = imgResult;
        }

        private void notButton_Click(object sender, EventArgs e)
        {
            if (img1 == null)
            {
                MessageBox.Show("Carregue uma imagem primeiro.");
                return;
            }

            if (!EhImagemBinaria(img1) || (img2 != null && !EhImagemBinaria(img2)))
            {
                MessageBox.Show("As imagens devem ser binárias (apenas preto e branco).");
                return;
            }

            int width = img1.Width;
            int height = img1.Height;
            imgResult = new Bitmap(width, height);

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color c = img1.GetPixel(x, y);

                    int R = 255 - c.R;
                    int G = 255 - c.G;
                    int B = 255 - c.B;

                    imgResult.SetPixel(x, y, Color.FromArgb(R, G, B));
                }
            }

            pictureBox3.Image = imgResult;
        }

        private Bitmap OtsuThreshold(Bitmap img)
        {
            int width = img.Width;
            int height = img.Height;
            int[] histogram = new int[256];
            float totalPixels = width * height;

       
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color pixel = img.GetPixel(x, y);
                    int gray = (int)(0.299 * pixel.R + 0.587 * pixel.G + 0.114 * pixel.B);
                    histogram[gray]++;
                }
            }

          
            float[] probability = new float[256];
            for (int i = 0; i < 256; i++)
            {
                probability[i] = histogram[i] / totalPixels;
            }

            float globalMean = 0;
            for (int i = 0; i < 256; i++)
            {
                globalMean += i * probability[i];
            }

    
            float maxVariance = 0;
            int threshold = 0;
            float weightBackground = 0;
            float sumBackground = 0;

            for (int t = 0; t < 256; t++)
            {
                weightBackground += probability[t];
                if (weightBackground == 0)
                    continue;

                float weightForeground = 1 - weightBackground;
                if (weightForeground == 0)
                    break;

                sumBackground += t * probability[t];
                float meanBackground = sumBackground / weightBackground;
                float meanForeground = (globalMean - sumBackground) / weightForeground;

                float varianceBetween = weightBackground * weightForeground * (meanBackground - meanForeground) * (meanBackground - meanForeground);

                if (varianceBetween > maxVariance)
                {
                    maxVariance = varianceBetween;
                    threshold = t;
                }
            }

       
            Bitmap result = new Bitmap(width, height);
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color pixel = img.GetPixel(x, y);
                    int gray = (int)(0.299 * pixel.R + 0.587 * pixel.G + 0.114 * pixel.B);
                    int binaryColor = gray >= threshold ? 255 : 0;
                    result.SetPixel(x, y, Color.FromArgb(binaryColor, binaryColor, binaryColor));
                }
            }

            return result;
        }

        private void limiarButton_Click(object sender, EventArgs e)
        {
            if (img1 == null)
            {
                MessageBox.Show("Carregue uma imagem primeiro.");
                return;
            }

            imgResult = OtsuThreshold(img1); 
            pictureBox3.Image = imgResult;
        }

        private Bitmap EqualizeHistogram(Bitmap img, out int[] hist, out int[] histEqualized)
        {
            int width = img.Width;
            int height = img.Height;
            int totalPixels = width * height;

            hist = new int[256];
            for (int i = 0; i < width; i++)
                for (int j = 0; j < height; j++)
                    hist[img.GetPixel(i, j).R]++;

            int[] cdf = new int[256];
            cdf[0] = hist[0];
            for (int i = 1; i < 256; i++)
                cdf[i] = cdf[i - 1] + hist[i];

            byte[] equalizedMap = new byte[256];
            for (int i = 0; i < 256; i++)
                equalizedMap[i] = (byte)((cdf[i] - cdf[0]) * 255 / (totalPixels - 1));

            Bitmap result = new Bitmap(width, height);
            histEqualized = new int[256];

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    int originalGray = img.GetPixel(i, j).R;
                    int newGray = equalizedMap[originalGray];
                    result.SetPixel(i, j, Color.FromArgb(newGray, newGray, newGray));
                    histEqualized[newGray]++;
                }
            }

            return result;
        }

        private void PlotHistogram(int[] hist, System.Windows.Forms.DataVisualization.Charting.Chart chart, string title)
        {
            chart.Series.Clear();
            chart.Titles.Clear();
            chart.Titles.Add(title);

            var series = chart.Series.Add("Intensidade");
            series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            series.Points.Clear();

            for (int i = 0; i < hist.Length; i++)
            {
                series.Points.AddXY(i, hist[i]);
            }
        }

        private Bitmap ToGrayscale(Bitmap original)
        {
            int width = original.Width;
            int height = original.Height;
            Bitmap grayImage = new Bitmap(width, height);

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color pixel = original.GetPixel(x, y);
                   
                    int gray = (int)(0.299 * pixel.R + 0.587 * pixel.G + 0.114 * pixel.B);
                    gray = gray < 0 ? 0 : (gray > 255 ? 255 : gray);
                    Color grayColor = Color.FromArgb(gray, gray, gray);
                    grayImage.SetPixel(x, y, grayColor);
                }
            }

            return grayImage;
        }

        private void btnEqualize_Click(object sender, EventArgs e)
        {
            if (img1 == null)
            {
                MessageBox.Show("Carregue uma imagem primeiro.");
                return;
            }

            Bitmap grayImage = ToGrayscale(img1);
            int[] histBefore;
            Bitmap equalized = EqualizeHistogram(grayImage, out histBefore, out int[] histAfter);

            pictureBox1.Image = grayImage;
            pictureBox2.Image = equalized;

            PlotHistogram(histBefore, chartOriginal, "Histograma Original");
            PlotHistogram(histAfter, chartEqualized, "Histograma Equalizado");
        }

        private void MEAN_Click(object sender, EventArgs e)
        {
            if (img1 == null)
            {
                MessageBox.Show("Carregue a imagem primeiro.");
                return;
            }

            int width = img1.Width;
            int height = img1.Height;
            imgResult = new Bitmap(width, height);

           
            for (int y = 1; y < height - 1; y++)
            {
                for (int x = 1; x < width - 1; x++)
                {
                    int somaR = 0;
                    int somaG = 0;
                    int somaB = 0;

               
                    for (int j = -1; j <= 1; j++)
                    {
                        for (int i = -1; i <= 1; i++)
                        {
                            Color vizinho = img1.GetPixel(x + i, y + j);
                            somaR += vizinho.R;
                            somaG += vizinho.G;
                            somaB += vizinho.B;
                        }
                    }

                
                    int meanR = somaR / 9;
                    int meanG = somaG / 9;
                    int meanB = somaB / 9;

             
                    imgResult.SetPixel(x, y, Color.FromArgb(meanR, meanG, meanB));
                }
            }

            pictureBox3.Image = imgResult;
        }

        private void MIN_Click(object sender, EventArgs e)
        {
            if (img1 == null)
            {
                MessageBox.Show("Carregue a imagem primeiro.");
                return;
            }

            int width = img1.Width;
            int height = img1.Height;
            imgResult = new Bitmap(width, height);

            for (int y = 1; y < height - 1; y++)
            {
                for (int x = 1; x < width - 1; x++)
                {
                    int minR = 255;
                    int minG = 255;
                    int minB = 255;

                
                    for (int j = -1; j <= 1; j++)
                    {
                        for (int i = -1; i <= 1; i++)
                        {
                            Color vizinho = img1.GetPixel(x + i, y + j);

                            if (vizinho.R < minR) minR = vizinho.R;
                            if (vizinho.G < minG) minG = vizinho.G;
                            if (vizinho.B < minB) minB = vizinho.B;
                        }
                    }

                    imgResult.SetPixel(x, y, Color.FromArgb(minR, minG, minB));
                }
            }

            pictureBox3.Image = imgResult;
        }

        private void MAX_Click(object sender, EventArgs e)
        {
            if (img1 == null)
            {
                MessageBox.Show("Carregue a imagem primeiro.");
                return;
            }

            int width = img1.Width;
            int height = img1.Height;
            imgResult = new Bitmap(width, height);

            for (int y = 1; y < height - 1; y++)
            {
                for (int x = 1; x < width - 1; x++)
                {
                    int maxR = 0;
                    int maxG = 0;
                    int maxB = 0;

                    // Percorre vizinhança 3x3
                    for (int j = -1; j <= 1; j++)
                    {
                        for (int i = -1; i <= 1; i++)
                        {
                            Color vizinho = img1.GetPixel(x + i, y + j);

                            if (vizinho.R > maxR) maxR = vizinho.R;
                            if (vizinho.G > maxG) maxG = vizinho.G;
                            if (vizinho.B > maxB) maxB = vizinho.B;
                        }
                    }

                    imgResult.SetPixel(x, y, Color.FromArgb(maxR, maxG, maxB));
                }
            }

            pictureBox3.Image = imgResult;
        }

        private void retiraSalPimenta_Click(object sender, EventArgs e)
        {
            if (img1 == null)
            {
                MessageBox.Show("Carregue a imagem primeiro.");
                return;
            }

            int width = img1.Width;
            int height = img1.Height;
            imgResult = new Bitmap(width, height);

            for (int y = 1; y < height - 1; y++)
            {
                for (int x = 1; x < width - 1; x++)
                {
                 
                    List<int> vizinhosR = new List<int>();
                    List<int> vizinhosG = new List<int>();
                    List<int> vizinhosB = new List<int>();

                    for (int j = -1; j <= 1; j++)
                    {
                        for (int i = -1; i <= 1; i++)
                        {
                            Color vizinho = img1.GetPixel(x + i, y + j);
                            vizinhosR.Add(vizinho.R);
                            vizinhosG.Add(vizinho.G);
                            vizinhosB.Add(vizinho.B);
                        }
                    }

                    vizinhosR.Sort();
                    vizinhosG.Sort();
                    vizinhosB.Sort();

                    int medianR = vizinhosR[4];
                    int medianG = vizinhosG[4];
                    int medianB = vizinhosB[4];

                    imgResult.SetPixel(x, y, Color.FromArgb(medianR, medianG, medianB));
                }
            }

            pictureBox3.Image = imgResult;
        }

        private void ORDEM_Click(object sender, EventArgs e)
        {
            if (img1 == null)
            {
                MessageBox.Show("Carregue a imagem primeiro.");
                return;
            }

    
            int ordem = 4;  

            int width = img1.Width;
            int height = img1.Height;
            imgResult = new Bitmap(width, height);

            for (int y = 1; y < height - 1; y++)
            {
                for (int x = 1; x < width - 1; x++)
                {
                  
                    List<int> vizinhosR = new List<int>();
                    List<int> vizinhosG = new List<int>();
                    List<int> vizinhosB = new List<int>();

                    for (int j = -1; j <= 1; j++)
                    {
                        for (int i = -1; i <= 1; i++)
                        {
                            Color vizinho = img1.GetPixel(x + i, y + j);
                            vizinhosR.Add(vizinho.R);
                            vizinhosG.Add(vizinho.G);
                            vizinhosB.Add(vizinho.B);
                        }
                    }

                
                    vizinhosR.Sort();
                    vizinhosG.Sort();
                    vizinhosB.Sort();

                    ordem = Math.Max(0, Math.Min(ordem, 8)); 
                    int rankR = vizinhosR[ordem];
                    int rankG = vizinhosG[ordem];
                    int rankB = vizinhosB[ordem];

                    imgResult.SetPixel(x, y, Color.FromArgb(rankR, rankG, rankB));
                }
            }

            pictureBox3.Image = imgResult;
        }

        private void suavizaçãoGalziana_Click(object sender, EventArgs e)
        {
            if (img1 == null)
            {
                MessageBox.Show("Carregue a imagem primeiro.");
                return;
            }

            int width = img1.Width;
            int height = img1.Height;
            imgResult = new Bitmap(width, height);

            for (int y = 1; y < height - 1; y++)
            {
                for (int x = 1; x < width - 1; x++)
                {
                   
                    Color centro = img1.GetPixel(x, y);
                    int centerR = centro.R;
                    int centerG = centro.G;
                    int centerB = centro.B;

                 
                    int minR = 255, minG = 255, minB = 255;
                    int maxR = 0, maxG = 0, maxB = 0;

                    for (int j = -1; j <= 1; j++)
                    {
                        for (int i = -1; i <= 1; i++)
                        {
                            if (i == 0 && j == 0) continue; 

                            Color vizinho = img1.GetPixel(x + i, y + j);

                       
                            if (vizinho.R < minR) minR = vizinho.R;
                            if (vizinho.G < minG) minG = vizinho.G;
                            if (vizinho.B < minB) minB = vizinho.B;

                         
                            if (vizinho.R > maxR) maxR = vizinho.R;
                            if (vizinho.G > maxG) maxG = vizinho.G;
                            if (vizinho.B > maxB) maxB = vizinho.B;
                        }
                    }

               
                    int novoR = centerR;
                    int novoG = centerG;
                    int novoB = centerB;

                    if (centerR < minR) novoR = minR;
                    else if (centerR > maxR) novoR = maxR;

                    if (centerG < minG) novoG = minG;
                    else if (centerG > maxG) novoG = maxG;

                    if (centerB < minB) novoB = minB;
                    else if (centerB > maxB) novoB = maxB;

                    imgResult.SetPixel(x, y, Color.FromArgb(novoR, novoG, novoB));
                }
            }

            pictureBox3.Image = imgResult;
        }

        private void gaussiano_Click(object sender, EventArgs e)
        {
            if (img1 == null)
            {
                MessageBox.Show("Carregue a imagem primeiro.");
                return;
            }

            int width = img1.Width;
            int height = img1.Height;
            imgResult = new Bitmap(width, height);

            
            int[,] kernel = new int[3, 3]
            {
        { 1, 2, 1 },
        { 2, 4, 2 },
        { 1, 2, 1 }
            };
            int kernelSum = 16; 

            for (int y = 1; y < height - 1; y++)
            {
                for (int x = 1; x < width - 1; x++)
                {
                    int somaR = 0;
                    int somaG = 0;
                    int somaB = 0;

                    for (int j = -1; j <= 1; j++)
                    {
                        for (int i = -1; i <= 1; i++)
                        {
                            Color vizinho = img1.GetPixel(x + i, y + j);

                            int peso = kernel[j + 1, i + 1];
                            somaR += vizinho.R * peso;
                            somaG += vizinho.G * peso;
                            somaB += vizinho.B * peso;
                        }
                    }

                    int novoR = Math.Min(255, Math.Max(0, somaR / kernelSum));
                    int novoG = Math.Min(255, Math.Max(0, somaG / kernelSum));
                    int novoB = Math.Min(255, Math.Max(0, somaB / kernelSum));

                    imgResult.SetPixel(x, y, Color.FromArgb(novoR, novoG, novoB));
                }
            }

            pictureBox3.Image = imgResult;
        }

        private void dtcPrimeriaBorda_Click(object sender, EventArgs e)
        {
            if (img1 == null)
            {
                MessageBox.Show("Carregue a imagem primeiro.");
                return;
            }

            int width = img1.Width;
            int height = img1.Height;
            imgResult = new Bitmap(width, height);

           
            int[,] Gx = new int[3, 3]
            {
        { -1, 0, 1 },
        { -1, 0, 1 },
        { -1, 0, 1 }
            };

            int[,] Gy = new int[3, 3]
            {
        { -1, -1, -1 },
        {  0,  0,  0 },
        {  1,  1,  1 }
            };

            for (int y = 1; y < height - 1; y++)
            {
                for (int x = 1; x < width - 1; x++)
                {
                    int sumX = 0;
                    int sumY = 0;

                    for (int j = -1; j <= 1; j++)
                    {
                        for (int i = -1; i <= 1; i++)
                        {
                            Color pixel = img1.GetPixel(x + i, y + j);
                        
                            int gray = (pixel.R + pixel.G + pixel.B) / 3;

                            sumX += gray * Gx[j + 1, i + 1];
                            sumY += gray * Gy[j + 1, i + 1];
                        }
                    }

               
                    int grad = Math.Abs(sumX) + Math.Abs(sumY);
                    grad = Math.Min(255, Math.Max(0, grad));

                    imgResult.SetPixel(x, y, Color.FromArgb(grad, grad, grad));
                }
            }

            pictureBox3.Image = imgResult;
        }

        private void Sobel_Click(object sender, EventArgs e)
        {
            if (img1 == null)
            {
                MessageBox.Show("Carregue a imagem primeiro.");
                return;
            }

            int width = img1.Width;
            int height = img1.Height;
            imgResult = new Bitmap(width, height);

         
            int[,] Gx = new int[3, 3]
            {
        { -1, 0, 1 },
        { -2, 0, 2 },
        { -1, 0, 1 }
            };

            int[,] Gy = new int[3, 3]
            {
        { -1, -2, -1 },
        {  0,  0,  0 },
        {  1,  2,  1 }
            };

            for (int y = 1; y < height - 1; y++)
            {
                for (int x = 1; x < width - 1; x++)
                {
                    int sumX = 0;
                    int sumY = 0;

                    for (int j = -1; j <= 1; j++)
                    {
                        for (int i = -1; i <= 1; i++)
                        {
                            Color pixel = img1.GetPixel(x + i, y + j);
                            int gray = (pixel.R + pixel.G + pixel.B) / 3;

                            sumX += gray * Gx[j + 1, i + 1];
                            sumY += gray * Gy[j + 1, i + 1];
                        }
                    }

                    int grad = Math.Abs(sumX) + Math.Abs(sumY);
                    grad = Math.Min(255, Math.Max(0, grad));

                    imgResult.SetPixel(x, y, Color.FromArgb(grad, grad, grad));
                }
            }

            pictureBox3.Image = imgResult;
        }

        private void Laplaciano_Click(object sender, EventArgs e)
        {
            if (img1 == null)
            {
                MessageBox.Show("Carregue a imagem primeiro.");
                return;
            }

            int width = img1.Width;
            int height = img1.Height;
            imgResult = new Bitmap(width, height);

            int[,] kernel = new int[3, 3]
            {
        { -1, -1, -1 },
        { -1,  8, -1 },
        { -1, -1, -1 }
            };

            for (int y = 1; y < height - 1; y++)
            {
                for (int x = 1; x < width - 1; x++)
                {
                    int sum = 0;

                    for (int j = -1; j <= 1; j++)
                    {
                        for (int i = -1; i <= 1; i++)
                        {
                            Color pixel = img1.GetPixel(x + i, y + j);
                           
                            int gray = (pixel.R + pixel.G + pixel.B) / 3;

                            sum += gray * kernel[j + 1, i + 1];
                        }
                    }

               
                    int valor = Math.Abs(sum);
                    valor = Math.Min(255, Math.Max(0, valor));

                    imgResult.SetPixel(x, y, Color.FromArgb(valor, valor, valor));
                }
            }

            pictureBox3.Image = imgResult;
        }

       
        private Bitmap Binarizar(Bitmap img)
        {
            int width = img.Width;
            int height = img.Height;
            Bitmap bin = new Bitmap(width, height);

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color c = img.GetPixel(x, y);
                    int gray = (c.R + c.G + c.B) / 3;
                    Color binColor = (gray > 128) ? Color.White : Color.Black;
                    bin.SetPixel(x, y, binColor);
                }
            }
            return bin;
        }

        private bool EhBranco(Color c)
        {
            return c.R > 128; 
        }

        private Bitmap Dilatar(Bitmap img)
        {
            int width = img.Width;
            int height = img.Height;
            Bitmap result = new Bitmap(width, height);

            for (int y = 1; y < height - 1; y++)
            {
                for (int x = 1; x < width - 1; x++)
                {
                    bool dilatar = false;

                    for (int j = -1; j <= 1 && !dilatar; j++)
                    {
                        for (int i = -1; i <= 1; i++)
                        {
                            if (EhBranco(img.GetPixel(x + i, y + j)))
                            {
                                dilatar = true;
                                break;
                            }
                        }
                    }

                    result.SetPixel(x, y, dilatar ? Color.White : Color.Black);
                }
            }

            return result;
        }

        private Bitmap Erodir(Bitmap img)
        {
            int width = img.Width;
            int height = img.Height;
            Bitmap result = new Bitmap(width, height);

            for (int y = 1; y < height - 1; y++)
            {
                for (int x = 1; x < width - 1; x++)
                {
                    bool erodir = true;

                    for (int j = -1; j <= 1 && erodir; j++)
                    {
                        for (int i = -1; i <= 1; i++)
                        {
                            if (!EhBranco(img.GetPixel(x + i, y + j)))
                            {
                                erodir = false;
                                break;
                            }
                        }
                    }

                    result.SetPixel(x, y, erodir ? Color.White : Color.Black);
                }
            }

            return result;
        }


        private Bitmap Abrir(Bitmap img)
        {
            Bitmap erodida = Erodir(img);
            Bitmap aberta = Dilatar(erodida);
            return aberta;
        }

        private Bitmap Fechar(Bitmap img)
        {
            Bitmap dilatada = Dilatar(img);
            Bitmap fechada = Erodir(dilatada);
            return fechada;
        }

        private Bitmap Contorno(Bitmap img)
        {
            Bitmap erodida = Erodir(img);
            int width = img.Width;
            int height = img.Height;
            Bitmap contorno = new Bitmap(width, height);

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color original = img.GetPixel(x, y);
                    Color erode = erodida.GetPixel(x, y);

                   
                    bool isContorno = EhBranco(original) && !EhBranco(erode);
                    contorno.SetPixel(x, y, isContorno ? Color.White : Color.Black);
                }
            }

            return contorno;
        }

        private void dilata_Click(object sender, EventArgs e)
        {
            if (img1 == null)
            {
                MessageBox.Show("Carregue a imagem primeiro.");
                return;
            }

            Bitmap bin = Binarizar(img1);
            imgResult = Dilatar(bin);
            pictureBox3.Image = imgResult;
        }

        private void erosao_Click(object sender, EventArgs e)
        {
            if (img1 == null)
            {
                MessageBox.Show("Carregue a imagem primeiro.");
                return;
            }

            Bitmap bin = Binarizar(img1);
            imgResult = Erodir(bin);
            pictureBox3.Image = imgResult;
        }

        private void abertura_Click(object sender, EventArgs e)
        {
            if (img1 == null)
            {
                MessageBox.Show("Carregue a imagem primeiro.");
                return;
            }

            Bitmap bin = Binarizar(img1);
            imgResult = Abrir(bin);
            pictureBox3.Image = imgResult;
        }

        private void fechamento_Click(object sender, EventArgs e)
        {
            if (img1 == null)
            {
                MessageBox.Show("Carregue a imagem primeiro.");
                return;
            }

            Bitmap bin = Binarizar(img1);
            imgResult = Fechar(bin);
            pictureBox3.Image = imgResult;
        }

        private void contorn_Click(object sender, EventArgs e)
        {
            if (img1 == null)
            {
                MessageBox.Show("Carregue a imagem primeiro.");
                return;
            }

            Bitmap bin = Binarizar(img1);
            imgResult = Contorno(bin);
            pictureBox3.Image = imgResult;
        }

        private void Fractais_Click(object sender, EventArgs e)
        {
            int width = 400;
            int height = 400;
            Bitmap bmp = new Bitmap(width, height);

            double xmin = -2.5;
            double xmax = 1;
            double ymin = -1;
            double ymax = 1;

            int maxIter = 1000;

            for (int py = 0; py < height; py++)
            {
                double y0 = ymin + (py * (ymax - ymin) / height);

                for (int px = 0; px < width; px++)
                {
                    double x0 = xmin + (px * (xmax - xmin) / width);

                    double x = 0.0;
                    double y = 0.0;
                    int iteration = 0;

                    while (x * x + y * y <= 4 && iteration < maxIter)
                    {
                        double xtemp = x * x - y * y + x0;
                        y = 2 * x * y + y0;
                        x = xtemp;
                        iteration++;
                    }

                    int colorValue = iteration == maxIter ? 0 : 255 * iteration / maxIter;
                    Color color = Color.FromArgb(colorValue % 256, (colorValue * 5) % 256, (colorValue * 10) % 256);
                    bmp.SetPixel(px, py, color);
                }
            }

            pictureBox3.Image = bmp;
        }

        private void oleo_Click(object sender, EventArgs e)
        {
            if (img1 == null)
            {
                MessageBox.Show("Carregue a imagem primeiro.");
                return;
            }

            int radius = 3;  
            int width = img1.Width;
            int height = img1.Height;
            Bitmap bmp = new Bitmap(width, height);

            for (int y = radius; y < height - radius; y++)
            {
                for (int x = radius; x < width - radius; x++)
                {
                    Dictionary<int, List<Color>> intensityBuckets = new Dictionary<int, List<Color>>();

                    for (int j = -radius; j <= radius; j++)
                    {
                        for (int i = -radius; i <= radius; i++)
                        {
                            Color c = img1.GetPixel(x + i, y + j);
                            int intensity = (c.R + c.G + c.B) / 3;
                            if (!intensityBuckets.ContainsKey(intensity))
                                intensityBuckets[intensity] = new List<Color>();

                            intensityBuckets[intensity].Add(c);
                        }
                    }

                  
                    int maxCount = 0;
                    int dominantIntensity = 0;
                    foreach (var kvp in intensityBuckets)
                    {
                        if (kvp.Value.Count > maxCount)
                        {
                            maxCount = kvp.Value.Count;
                            dominantIntensity = kvp.Key;
                        }
                    }

                    
                    var colors = intensityBuckets[dominantIntensity];
                    int r = (int)colors.Average(c => c.R);
                    int g = (int)colors.Average(c => c.G);
                    int b = (int)colors.Average(c => c.B);

                    bmp.SetPixel(x, y, Color.FromArgb(r, g, b));
                }
            }

            pictureBox3.Image = bmp;
        }

        private void Cartoon_Click(object sender, EventArgs e)
        {
            if (img1 == null)
            {
                MessageBox.Show("Carregue a imagem primeiro.");
                return;
            }

            Bitmap bmp = new Bitmap(img1.Width, img1.Height);

            int[,] Gx = new int[3, 3]
            {
        { -1, 0, 1 },
        { -2, 0, 2 },
        { -1, 0, 1 }
            };

            int[,] Gy = new int[3, 3]
            {
        { -1, -2, -1 },
        {  0,  0,  0 },
        {  1,  2,  1 }
            };

            int width = img1.Width;
            int height = img1.Height;

            // Detecta bordas
            bool[,] edgeMap = new bool[width, height];

            for (int y = 1; y < height - 1; y++)
            {
                for (int x = 1; x < width - 1; x++)
                {
                    int sumX = 0;
                    int sumY = 0;

                    for (int j = -1; j <= 1; j++)
                    {
                        for (int i = -1; i <= 1; i++)
                        {
                            Color c = img1.GetPixel(x + i, y + j);
                            int gray = (c.R + c.G + c.B) / 3;

                            sumX += gray * Gx[j + 1, i + 1];
                            sumY += gray * Gy[j + 1, i + 1];
                        }
                    }

                    int grad = Math.Abs(sumX) + Math.Abs(sumY);
                    edgeMap[x, y] = grad > 100; 
                }
            }

            
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color c = img1.GetPixel(x, y);
                    Color quantized = Color.FromArgb(
                        (c.R / 64) * 64,
                        (c.G / 64) * 64,
                        (c.B / 64) * 64
                    );

                    if (edgeMap[x, y])
                        bmp.SetPixel(x, y, Color.Black);
                    else
                        bmp.SetPixel(x, y, quantized);
                }
            }

            pictureBox3.Image = bmp;
        }

        private void SubtrairImagem_Click(object sender, EventArgs e)
        {
            if (img1 == null || img2 == null)
            {
                MessageBox.Show("Carregue ambas as imagens primeiro.");
                return;
            }

            int width = Math.Min(img1.Width, img2.Width);
            int height = Math.Min(img1.Height, img2.Height);
            imgResult = new Bitmap(width, height);

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color color1 = img1.GetPixel(x, y);
                    Color color2 = img2.GetPixel(x, y);
                  
                    int R = Math.Max(color1.R - color2.R, 0);
                    int G = Math.Max(color1.G - color2.G, 0);
                    int B = Math.Max(color1.B - color2.B, 0);

                    imgResult.SetPixel(x, y, Color.FromArgb(R, G, B));
                }
            }

            pictureBox3.Image = imgResult;
        }

        private void geraImagem_Click(object sender, EventArgs e)
        {
            int width = pictureBoxImagem.Width;
            int height = pictureBoxImagem.Height;
            Bitmap bmp = new Bitmap(width, height);
            Random rnd = new Random();

            
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.White);
            }

            int numBlocos = rnd.Next(10, 30); 

            for (int n = 0; n < numBlocos; n++)
            {
               
                int blockW = rnd.Next(20, 100);
                int blockH = rnd.Next(20, 100);

                int x = rnd.Next(0, Math.Max(1, width - blockW));
                int y = rnd.Next(0, Math.Max(1, height - blockH));

        
                Color cor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));

                using (Graphics g = Graphics.FromImage(bmp))
                using (SolidBrush brush = new SolidBrush(cor))
                {
                    g.FillRectangle(brush, x, y, blockW, blockH);
                }
            }

            pictureBoxImagem.Image = bmp;
        }

        private void somarImagens_Click_1(object sender, EventArgs e)
        {
            if (img1 == null || img2 == null)
            {
                MessageBox.Show("Carregue ambas as imagens primeiro.");
                return;
            }

            int width = Math.Min(img1.Width, img2.Width);
            int height = Math.Min(img1.Height, img2.Height);
            imgResult = new Bitmap(width, height);

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color color1 = img1.GetPixel(x, y);
                    Color color2 = img2.GetPixel(x, y);

           
                    int R = Math.Min(color1.R + color2.R, 255);
                    int G = Math.Min(color1.G + color2.G, 255);
                    int B = Math.Min(color1.B + color2.B, 255);

                    imgResult.SetPixel(x, y, Color.FromArgb(R, G, B));
                }
            }

            pictureBox3.Image = imgResult;
        }

        
    }
}
