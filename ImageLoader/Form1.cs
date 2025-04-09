using System;
using System.Drawing;
using System.Drawing.Imaging;
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

                    int R = Math.Max(pixel.R - brilho, 0);  // Diminuir brilho
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

                    // Multiplicar as cores pelo valor constante para aumentar o contraste
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

                    // Dividir as cores pelo valor constante para diminuir o contraste
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

            // Abrir o SaveFileDialog
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PNG Image|*.png|JPEG Image|*.jpg|Bitmap Image|*.bmp";
            saveFileDialog.Title = "Salvar Imagem";

            // Mostrar o dialog para o usuário escolher o local e nome do arquivo
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Salvar a imagem no formato escolhido
                    // Salvar como PNG, JPEG ou BMP, dependendo da escolha do usuário
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

                    // Calcular o valor de cinza com base na fórmula
                    int cinza = (int)(0.299 * pixel.R + 0.587 * pixel.G + 0.114 * pixel.B);

                    // Definir o novo valor do pixel como um tom de cinza
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
                    // Inverter a posição do pixel
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
                    // Inverter a posição do pixel verticalmente
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

            // Verificar se as imagens têm o mesmo tamanho
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

                    // Calcular a diferença de cada componente de cor (R, G, B)
                    int R = Math.Abs(color1.R - color2.R);
                    int G = Math.Abs(color1.G - color2.G);
                    int B = Math.Abs(color1.B - color2.B);

                    // Definir o novo valor do pixel com a diferença de cores
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

        private void somarImagens_Click(object sender, EventArgs e)
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

                    // Somar as cores diretamente (invertendo a operação de subtração)
                    int R = Math.Min(color1.R + color2.R, 255);
                    int G = Math.Min(color1.G + color2.G, 255);
                    int B = Math.Min(color1.B + color2.B, 255);

                    imgResult.SetPixel(x, y, Color.FromArgb(R, G, B));
                }
            }

            pictureBox3.Image = imgResult;
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

                    // Subtrair as cores
                    int R = Math.Max(color1.R - color2.R, 0);
                    int G = Math.Max(color1.G - color2.G, 0);
                    int B = Math.Max(color1.B - color2.B, 0);

                    imgResult.SetPixel(x, y, Color.FromArgb(R, G, B));
                }
            }

            pictureBox3.Image = imgResult;
        }
    }
}
