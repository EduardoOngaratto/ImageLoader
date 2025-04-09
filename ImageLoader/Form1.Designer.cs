namespace ImageLoader
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.carregarImagem1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.carregarImagem2 = new System.Windows.Forms.Button();
            this.AumentarBrilhoButton = new System.Windows.Forms.Button();
            this.QuantidadeBrilho = new System.Windows.Forms.TextBox();
            this.SubtrairImagem = new System.Windows.Forms.Button();
            this.DiminuirBrilho = new System.Windows.Forms.Button();
            this.somarImagens = new System.Windows.Forms.Button();
            this.diferencaImagem = new System.Windows.Forms.Button();
            this.inverterEsquerda = new System.Windows.Forms.Button();
            this.escalaCinza = new System.Windows.Forms.Button();
            this.quantidadeContraste = new System.Windows.Forms.TextBox();
            this.InverterDireita = new System.Windows.Forms.Button();
            this.DiminuirContraste = new System.Windows.Forms.Button();
            this.aumentarContraste = new System.Windows.Forms.Button();
            this.salvar = new System.Windows.Forms.Button();
            this.combinacaoLinear = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.NumcombinaLinear = new System.Windows.Forms.TextBox();
            this.mediaclick = new System.Windows.Forms.Button();
            this.andButton = new System.Windows.Forms.Button();
            this.orButton = new System.Windows.Forms.Button();
            this.xorButton = new System.Windows.Forms.Button();
            this.notButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // carregarImagem1
            // 
            this.carregarImagem1.Location = new System.Drawing.Point(39, 210);
            this.carregarImagem1.Margin = new System.Windows.Forms.Padding(4);
            this.carregarImagem1.Name = "carregarImagem1";
            this.carregarImagem1.Size = new System.Drawing.Size(217, 46);
            this.carregarImagem1.TabIndex = 0;
            this.carregarImagem1.Text = "Carregar Imagem 1";
            this.carregarImagem1.UseVisualStyleBackColor = true;
            this.carregarImagem1.Click += new System.EventHandler(this.btImg1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(13, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(269, 198);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(305, 4);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(269, 198);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Location = new System.Drawing.Point(1013, 4);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(269, 198);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // carregarImagem2
            // 
            this.carregarImagem2.Location = new System.Drawing.Point(336, 210);
            this.carregarImagem2.Margin = new System.Windows.Forms.Padding(4);
            this.carregarImagem2.Name = "carregarImagem2";
            this.carregarImagem2.Size = new System.Drawing.Size(217, 46);
            this.carregarImagem2.TabIndex = 4;
            this.carregarImagem2.Text = "Carregar Imagem 2";
            this.carregarImagem2.UseVisualStyleBackColor = true;
            this.carregarImagem2.Click += new System.EventHandler(this.btImg2_Click_1);
            // 
            // AumentarBrilhoButton
            // 
            this.AumentarBrilhoButton.Location = new System.Drawing.Point(450, 348);
            this.AumentarBrilhoButton.Margin = new System.Windows.Forms.Padding(4);
            this.AumentarBrilhoButton.Name = "AumentarBrilhoButton";
            this.AumentarBrilhoButton.Size = new System.Drawing.Size(160, 25);
            this.AumentarBrilhoButton.TabIndex = 6;
            this.AumentarBrilhoButton.Text = "Aumentar brilho";
            this.AumentarBrilhoButton.UseVisualStyleBackColor = true;
            this.AumentarBrilhoButton.Click += new System.EventHandler(this.AumentarBrilhoButton_Click);
            // 
            // QuantidadeBrilho
            // 
            this.QuantidadeBrilho.Location = new System.Drawing.Point(450, 319);
            this.QuantidadeBrilho.Name = "QuantidadeBrilho";
            this.QuantidadeBrilho.Size = new System.Drawing.Size(160, 22);
            this.QuantidadeBrilho.TabIndex = 7;
            // 
            // SubtrairImagem
            // 
            this.SubtrairImagem.Location = new System.Drawing.Point(600, 37);
            this.SubtrairImagem.Margin = new System.Windows.Forms.Padding(4);
            this.SubtrairImagem.Name = "SubtrairImagem";
            this.SubtrairImagem.Size = new System.Drawing.Size(160, 25);
            this.SubtrairImagem.TabIndex = 9;
            this.SubtrairImagem.Text = "Subtrair Imagem";
            this.SubtrairImagem.UseVisualStyleBackColor = true;
            this.SubtrairImagem.Click += new System.EventHandler(this.SubtrairImagem_Click);
            // 
            // DiminuirBrilho
            // 
            this.DiminuirBrilho.Location = new System.Drawing.Point(450, 381);
            this.DiminuirBrilho.Margin = new System.Windows.Forms.Padding(4);
            this.DiminuirBrilho.Name = "DiminuirBrilho";
            this.DiminuirBrilho.Size = new System.Drawing.Size(160, 25);
            this.DiminuirBrilho.TabIndex = 8;
            this.DiminuirBrilho.Text = "Diminuir brilho";
            this.DiminuirBrilho.UseVisualStyleBackColor = true;
            this.DiminuirBrilho.Click += new System.EventHandler(this.DiminuirBrilho_Click);
            // 
            // somarImagens
            // 
            this.somarImagens.Location = new System.Drawing.Point(600, 4);
            this.somarImagens.Margin = new System.Windows.Forms.Padding(4);
            this.somarImagens.Name = "somarImagens";
            this.somarImagens.Size = new System.Drawing.Size(160, 25);
            this.somarImagens.TabIndex = 5;
            this.somarImagens.Text = "Somar Imagem";
            this.somarImagens.UseVisualStyleBackColor = true;
            this.somarImagens.Click += new System.EventHandler(this.somarImagens_Click);
            // 
            // diferencaImagem
            // 
            this.diferencaImagem.Location = new System.Drawing.Point(600, 103);
            this.diferencaImagem.Margin = new System.Windows.Forms.Padding(4);
            this.diferencaImagem.Name = "diferencaImagem";
            this.diferencaImagem.Size = new System.Drawing.Size(160, 25);
            this.diferencaImagem.TabIndex = 16;
            this.diferencaImagem.Text = "Diferença entre img";
            this.diferencaImagem.UseVisualStyleBackColor = true;
            this.diferencaImagem.Click += new System.EventHandler(this.diferencaImagem_Click);
            // 
            // inverterEsquerda
            // 
            this.inverterEsquerda.Location = new System.Drawing.Point(600, 169);
            this.inverterEsquerda.Margin = new System.Windows.Forms.Padding(4);
            this.inverterEsquerda.Name = "inverterEsquerda";
            this.inverterEsquerda.Size = new System.Drawing.Size(160, 25);
            this.inverterEsquerda.TabIndex = 15;
            this.inverterEsquerda.Text = "Inverter para Baixo";
            this.inverterEsquerda.UseVisualStyleBackColor = true;
            this.inverterEsquerda.Click += new System.EventHandler(this.inverterEsquerda_Click);
            // 
            // escalaCinza
            // 
            this.escalaCinza.Location = new System.Drawing.Point(600, 70);
            this.escalaCinza.Margin = new System.Windows.Forms.Padding(4);
            this.escalaCinza.Name = "escalaCinza";
            this.escalaCinza.Size = new System.Drawing.Size(160, 25);
            this.escalaCinza.TabIndex = 13;
            this.escalaCinza.Text = "EscalaCinza";
            this.escalaCinza.UseVisualStyleBackColor = true;
            this.escalaCinza.Click += new System.EventHandler(this.escalaCinza_Click);
            // 
            // quantidadeContraste
            // 
            this.quantidadeContraste.Location = new System.Drawing.Point(28, 319);
            this.quantidadeContraste.Name = "quantidadeContraste";
            this.quantidadeContraste.Size = new System.Drawing.Size(160, 22);
            this.quantidadeContraste.TabIndex = 12;
            // 
            // InverterDireita
            // 
            this.InverterDireita.Location = new System.Drawing.Point(600, 136);
            this.InverterDireita.Margin = new System.Windows.Forms.Padding(4);
            this.InverterDireita.Name = "InverterDireita";
            this.InverterDireita.Size = new System.Drawing.Size(160, 25);
            this.InverterDireita.TabIndex = 14;
            this.InverterDireita.Text = "Inverter para Direita";
            this.InverterDireita.UseVisualStyleBackColor = true;
            this.InverterDireita.Click += new System.EventHandler(this.InverterDireita_Click);
            // 
            // DiminuirContraste
            // 
            this.DiminuirContraste.Location = new System.Drawing.Point(28, 381);
            this.DiminuirContraste.Margin = new System.Windows.Forms.Padding(4);
            this.DiminuirContraste.Name = "DiminuirContraste";
            this.DiminuirContraste.Size = new System.Drawing.Size(160, 25);
            this.DiminuirContraste.TabIndex = 11;
            this.DiminuirContraste.Text = "Diminuir Contraste";
            this.DiminuirContraste.UseVisualStyleBackColor = true;
            this.DiminuirContraste.Click += new System.EventHandler(this.DiminuirContraste_Click);
            // 
            // aumentarContraste
            // 
            this.aumentarContraste.Location = new System.Drawing.Point(28, 348);
            this.aumentarContraste.Margin = new System.Windows.Forms.Padding(4);
            this.aumentarContraste.Name = "aumentarContraste";
            this.aumentarContraste.Size = new System.Drawing.Size(160, 25);
            this.aumentarContraste.TabIndex = 10;
            this.aumentarContraste.Text = "Aumentar Contraste";
            this.aumentarContraste.UseVisualStyleBackColor = true;
            this.aumentarContraste.Click += new System.EventHandler(this.aumentarContraste_Click);
            // 
            // salvar
            // 
            this.salvar.BackColor = System.Drawing.Color.Chartreuse;
            this.salvar.Location = new System.Drawing.Point(1074, 210);
            this.salvar.Margin = new System.Windows.Forms.Padding(4);
            this.salvar.Name = "salvar";
            this.salvar.Size = new System.Drawing.Size(160, 25);
            this.salvar.TabIndex = 13;
            this.salvar.Text = "Salvar Imagem";
            this.salvar.UseVisualStyleBackColor = false;
            this.salvar.Click += new System.EventHandler(this.salvar_Click);
            // 
            // combinacaoLinear
            // 
            this.combinacaoLinear.Location = new System.Drawing.Point(239, 348);
            this.combinacaoLinear.Margin = new System.Windows.Forms.Padding(4);
            this.combinacaoLinear.Name = "combinacaoLinear";
            this.combinacaoLinear.Size = new System.Drawing.Size(160, 25);
            this.combinacaoLinear.TabIndex = 17;
            this.combinacaoLinear.Text = "Combinação Linear";
            this.combinacaoLinear.UseVisualStyleBackColor = true;
            this.combinacaoLinear.Click += new System.EventHandler(this.combinacaoLinear_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // NumcombinaLinear
            // 
            this.NumcombinaLinear.Location = new System.Drawing.Point(239, 319);
            this.NumcombinaLinear.Name = "NumcombinaLinear";
            this.NumcombinaLinear.Size = new System.Drawing.Size(160, 22);
            this.NumcombinaLinear.TabIndex = 20;
            // 
            // mediaclick
            // 
            this.mediaclick.Location = new System.Drawing.Point(768, 4);
            this.mediaclick.Margin = new System.Windows.Forms.Padding(4);
            this.mediaclick.Name = "mediaclick";
            this.mediaclick.Size = new System.Drawing.Size(160, 25);
            this.mediaclick.TabIndex = 22;
            this.mediaclick.Text = "Média Linear";
            this.mediaclick.UseVisualStyleBackColor = true;
            this.mediaclick.Click += new System.EventHandler(this.mediaclick_Click);
            // 
            // andButton
            // 
            this.andButton.Location = new System.Drawing.Point(28, 475);
            this.andButton.Margin = new System.Windows.Forms.Padding(4);
            this.andButton.Name = "andButton";
            this.andButton.Size = new System.Drawing.Size(160, 25);
            this.andButton.TabIndex = 23;
            this.andButton.Text = "AND";
            this.andButton.UseVisualStyleBackColor = true;
            this.andButton.Click += new System.EventHandler(this.andButton_Click);
            // 
            // orButton
            // 
            this.orButton.Location = new System.Drawing.Point(28, 508);
            this.orButton.Margin = new System.Windows.Forms.Padding(4);
            this.orButton.Name = "orButton";
            this.orButton.Size = new System.Drawing.Size(160, 25);
            this.orButton.TabIndex = 24;
            this.orButton.Text = "OR";
            this.orButton.UseVisualStyleBackColor = true;
            this.orButton.Click += new System.EventHandler(this.orButton_Click);
            // 
            // xorButton
            // 
            this.xorButton.Location = new System.Drawing.Point(28, 541);
            this.xorButton.Margin = new System.Windows.Forms.Padding(4);
            this.xorButton.Name = "xorButton";
            this.xorButton.Size = new System.Drawing.Size(160, 25);
            this.xorButton.TabIndex = 25;
            this.xorButton.Text = "XOR";
            this.xorButton.UseVisualStyleBackColor = true;
            this.xorButton.Click += new System.EventHandler(this.xorButton_Click);
            // 
            // notButton
            // 
            this.notButton.Location = new System.Drawing.Point(28, 574);
            this.notButton.Margin = new System.Windows.Forms.Padding(4);
            this.notButton.Name = "notButton";
            this.notButton.Size = new System.Drawing.Size(160, 25);
            this.notButton.TabIndex = 26;
            this.notButton.Text = "NOT";
            this.notButton.UseVisualStyleBackColor = true;
            this.notButton.Click += new System.EventHandler(this.notButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1546, 863);
            this.Controls.Add(this.notButton);
            this.Controls.Add(this.xorButton);
            this.Controls.Add(this.orButton);
            this.Controls.Add(this.andButton);
            this.Controls.Add(this.diferencaImagem);
            this.Controls.Add(this.inverterEsquerda);
            this.Controls.Add(this.mediaclick);
            this.Controls.Add(this.InverterDireita);
            this.Controls.Add(this.escalaCinza);
            this.Controls.Add(this.NumcombinaLinear);
            this.Controls.Add(this.quantidadeContraste);
            this.Controls.Add(this.DiminuirContraste);
            this.Controls.Add(this.combinacaoLinear);
            this.Controls.Add(this.aumentarContraste);
            this.Controls.Add(this.salvar);
            this.Controls.Add(this.carregarImagem2);
            this.Controls.Add(this.AumentarBrilhoButton);
            this.Controls.Add(this.DiminuirBrilho);
            this.Controls.Add(this.somarImagens);
            this.Controls.Add(this.SubtrairImagem);
            this.Controls.Add(this.QuantidadeBrilho);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.carregarImagem1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button carregarImagem1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button carregarImagem2;
        private System.Windows.Forms.Button AumentarBrilhoButton;
        private System.Windows.Forms.TextBox QuantidadeBrilho;
        private System.Windows.Forms.Button SubtrairImagem;
        private System.Windows.Forms.Button DiminuirBrilho;
        private System.Windows.Forms.Button somarImagens;
        private System.Windows.Forms.TextBox quantidadeContraste;
        private System.Windows.Forms.Button DiminuirContraste;
        private System.Windows.Forms.Button aumentarContraste;
        private System.Windows.Forms.Button salvar;
        private System.Windows.Forms.Button escalaCinza;
        private System.Windows.Forms.Button inverterEsquerda;
        private System.Windows.Forms.Button InverterDireita;
        private System.Windows.Forms.Button diferencaImagem;
        private System.Windows.Forms.Button combinacaoLinear;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox NumcombinaLinear;
        private System.Windows.Forms.Button mediaclick;
        private System.Windows.Forms.Button andButton;
        private System.Windows.Forms.Button orButton;
        private System.Windows.Forms.Button xorButton;
        private System.Windows.Forms.Button notButton;
    }
}

