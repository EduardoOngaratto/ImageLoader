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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea37 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend37 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series37 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea38 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend38 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series38 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.limiarButton = new System.Windows.Forms.Button();
            this.chartOriginal = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartEqualized = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnEqualize = new System.Windows.Forms.Button();
            this.MEAN = new System.Windows.Forms.Button();
            this.MIN = new System.Windows.Forms.Button();
            this.MAX = new System.Windows.Forms.Button();
            this.retiraSalPimenta = new System.Windows.Forms.Button();
            this.ORDEM = new System.Windows.Forms.Button();
            this.suavizaçãoGalziana = new System.Windows.Forms.Button();
            this.gaussiano = new System.Windows.Forms.Button();
            this.dtcPrimeriaBorda = new System.Windows.Forms.Button();
            this.Sobel = new System.Windows.Forms.Button();
            this.Laplaciano = new System.Windows.Forms.Button();
            this.dilata = new System.Windows.Forms.Button();
            this.erosao = new System.Windows.Forms.Button();
            this.abertura = new System.Windows.Forms.Button();
            this.fechamento = new System.Windows.Forms.Button();
            this.contorn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Fractais = new System.Windows.Forms.Button();
            this.oleo = new System.Windows.Forms.Button();
            this.Cartoon = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBoxImagem = new System.Windows.Forms.PictureBox();
            this.geraImagem = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartOriginal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartEqualized)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagem)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
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
            this.pictureBox3.Location = new System.Drawing.Point(1001, 4);
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
            this.AumentarBrilhoButton.Location = new System.Drawing.Point(15, 67);
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
            this.QuantidadeBrilho.Location = new System.Drawing.Point(15, 38);
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
            this.DiminuirBrilho.Location = new System.Drawing.Point(15, 100);
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
            this.somarImagens.Click += new System.EventHandler(this.somarImagens_Click_1);
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
            this.escalaCinza.Text = "Escala Cinza";
            this.escalaCinza.UseVisualStyleBackColor = true;
            this.escalaCinza.Click += new System.EventHandler(this.escalaCinza_Click);
            // 
            // quantidadeContraste
            // 
            this.quantidadeContraste.Location = new System.Drawing.Point(347, 38);
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
            this.DiminuirContraste.Location = new System.Drawing.Point(347, 100);
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
            this.aumentarContraste.Location = new System.Drawing.Point(347, 67);
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
            this.salvar.Location = new System.Drawing.Point(1063, 210);
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
            this.combinacaoLinear.Location = new System.Drawing.Point(181, 67);
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
            this.NumcombinaLinear.Location = new System.Drawing.Point(181, 38);
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
            this.andButton.Location = new System.Drawing.Point(14, 28);
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
            this.orButton.Location = new System.Drawing.Point(14, 61);
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
            this.xorButton.Location = new System.Drawing.Point(14, 94);
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
            this.notButton.Location = new System.Drawing.Point(14, 127);
            this.notButton.Margin = new System.Windows.Forms.Padding(4);
            this.notButton.Name = "notButton";
            this.notButton.Size = new System.Drawing.Size(160, 25);
            this.notButton.TabIndex = 26;
            this.notButton.Text = "NOT";
            this.notButton.UseVisualStyleBackColor = true;
            this.notButton.Click += new System.EventHandler(this.notButton_Click);
            // 
            // limiarButton
            // 
            this.limiarButton.Location = new System.Drawing.Point(768, 37);
            this.limiarButton.Margin = new System.Windows.Forms.Padding(4);
            this.limiarButton.Name = "limiarButton";
            this.limiarButton.Size = new System.Drawing.Size(160, 25);
            this.limiarButton.TabIndex = 27;
            this.limiarButton.Text = "Limiarização";
            this.limiarButton.UseVisualStyleBackColor = true;
            this.limiarButton.Click += new System.EventHandler(this.limiarButton_Click);
            // 
            // chartOriginal
            // 
            chartArea37.Name = "ChartArea1";
            this.chartOriginal.ChartAreas.Add(chartArea37);
            legend37.Name = "Legend1";
            this.chartOriginal.Legends.Add(legend37);
            this.chartOriginal.Location = new System.Drawing.Point(533, 549);
            this.chartOriginal.Name = "chartOriginal";
            series37.ChartArea = "ChartArea1";
            series37.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series37.Legend = "Legend1";
            series37.Name = "Series1";
            this.chartOriginal.Series.Add(series37);
            this.chartOriginal.Size = new System.Drawing.Size(495, 302);
            this.chartOriginal.TabIndex = 28;
            this.chartOriginal.Text = "chartOriginal";
            // 
            // chartEqualized
            // 
            chartArea38.Name = "ChartArea1";
            this.chartEqualized.ChartAreas.Add(chartArea38);
            legend38.Name = "Legend1";
            this.chartEqualized.Legends.Add(legend38);
            this.chartEqualized.Location = new System.Drawing.Point(1034, 549);
            this.chartEqualized.Name = "chartEqualized";
            series38.ChartArea = "ChartArea1";
            series38.Legend = "Legend1";
            series38.Name = "Series1";
            this.chartEqualized.Series.Add(series38);
            this.chartEqualized.Size = new System.Drawing.Size(500, 302);
            this.chartEqualized.TabIndex = 29;
            this.chartEqualized.Text = "chartEqualized";
            // 
            // btnEqualize
            // 
            this.btnEqualize.Location = new System.Drawing.Point(949, 858);
            this.btnEqualize.Margin = new System.Windows.Forms.Padding(4);
            this.btnEqualize.Name = "btnEqualize";
            this.btnEqualize.Size = new System.Drawing.Size(196, 25);
            this.btnEqualize.TabIndex = 30;
            this.btnEqualize.Text = "Equalização de Histograma";
            this.btnEqualize.UseVisualStyleBackColor = true;
            this.btnEqualize.Click += new System.EventHandler(this.btnEqualize_Click);
            // 
            // MEAN
            // 
            this.MEAN.Location = new System.Drawing.Point(26, 146);
            this.MEAN.Margin = new System.Windows.Forms.Padding(4);
            this.MEAN.Name = "MEAN";
            this.MEAN.Size = new System.Drawing.Size(160, 25);
            this.MEAN.TabIndex = 31;
            this.MEAN.Text = "MEAN";
            this.MEAN.UseVisualStyleBackColor = true;
            this.MEAN.Click += new System.EventHandler(this.MEAN_Click);
            // 
            // MIN
            // 
            this.MIN.Location = new System.Drawing.Point(26, 179);
            this.MIN.Margin = new System.Windows.Forms.Padding(4);
            this.MIN.Name = "MIN";
            this.MIN.Size = new System.Drawing.Size(160, 25);
            this.MIN.TabIndex = 32;
            this.MIN.Text = "MIN";
            this.MIN.UseVisualStyleBackColor = true;
            this.MIN.Click += new System.EventHandler(this.MIN_Click);
            // 
            // MAX
            // 
            this.MAX.Location = new System.Drawing.Point(26, 212);
            this.MAX.Margin = new System.Windows.Forms.Padding(4);
            this.MAX.Name = "MAX";
            this.MAX.Size = new System.Drawing.Size(160, 25);
            this.MAX.TabIndex = 33;
            this.MAX.Text = "MAX";
            this.MAX.UseVisualStyleBackColor = true;
            this.MAX.Click += new System.EventHandler(this.MAX_Click);
            // 
            // retiraSalPimenta
            // 
            this.retiraSalPimenta.Location = new System.Drawing.Point(26, 113);
            this.retiraSalPimenta.Margin = new System.Windows.Forms.Padding(4);
            this.retiraSalPimenta.Name = "retiraSalPimenta";
            this.retiraSalPimenta.Size = new System.Drawing.Size(160, 25);
            this.retiraSalPimenta.TabIndex = 34;
            this.retiraSalPimenta.Text = "Mediana";
            this.retiraSalPimenta.UseVisualStyleBackColor = true;
            this.retiraSalPimenta.Click += new System.EventHandler(this.retiraSalPimenta_Click);
            // 
            // ORDEM
            // 
            this.ORDEM.Location = new System.Drawing.Point(26, 80);
            this.ORDEM.Margin = new System.Windows.Forms.Padding(4);
            this.ORDEM.Name = "ORDEM";
            this.ORDEM.Size = new System.Drawing.Size(160, 25);
            this.ORDEM.TabIndex = 35;
            this.ORDEM.Text = "ORDEM";
            this.ORDEM.UseVisualStyleBackColor = true;
            this.ORDEM.Click += new System.EventHandler(this.ORDEM_Click);
            // 
            // suavizaçãoGalziana
            // 
            this.suavizaçãoGalziana.Location = new System.Drawing.Point(26, 47);
            this.suavizaçãoGalziana.Margin = new System.Windows.Forms.Padding(4);
            this.suavizaçãoGalziana.Name = "suavizaçãoGalziana";
            this.suavizaçãoGalziana.Size = new System.Drawing.Size(160, 25);
            this.suavizaçãoGalziana.TabIndex = 36;
            this.suavizaçãoGalziana.Text = "Suavização Galziana";
            this.suavizaçãoGalziana.UseVisualStyleBackColor = true;
            this.suavizaçãoGalziana.Click += new System.EventHandler(this.suavizaçãoGalziana_Click);
            // 
            // gaussiano
            // 
            this.gaussiano.Location = new System.Drawing.Point(26, 14);
            this.gaussiano.Margin = new System.Windows.Forms.Padding(4);
            this.gaussiano.Name = "gaussiano";
            this.gaussiano.Size = new System.Drawing.Size(160, 25);
            this.gaussiano.TabIndex = 37;
            this.gaussiano.Text = "Filtro Gausiano";
            this.gaussiano.UseVisualStyleBackColor = true;
            this.gaussiano.Click += new System.EventHandler(this.gaussiano_Click);
            // 
            // dtcPrimeriaBorda
            // 
            this.dtcPrimeriaBorda.Location = new System.Drawing.Point(14, 28);
            this.dtcPrimeriaBorda.Margin = new System.Windows.Forms.Padding(4);
            this.dtcPrimeriaBorda.Name = "dtcPrimeriaBorda";
            this.dtcPrimeriaBorda.Size = new System.Drawing.Size(182, 25);
            this.dtcPrimeriaBorda.TabIndex = 38;
            this.dtcPrimeriaBorda.Text = "Prewitt";
            this.dtcPrimeriaBorda.UseVisualStyleBackColor = true;
            this.dtcPrimeriaBorda.Click += new System.EventHandler(this.dtcPrimeriaBorda_Click);
            // 
            // Sobel
            // 
            this.Sobel.Location = new System.Drawing.Point(14, 61);
            this.Sobel.Margin = new System.Windows.Forms.Padding(4);
            this.Sobel.Name = "Sobel";
            this.Sobel.Size = new System.Drawing.Size(182, 25);
            this.Sobel.TabIndex = 39;
            this.Sobel.Text = "Sobel";
            this.Sobel.UseVisualStyleBackColor = true;
            this.Sobel.Click += new System.EventHandler(this.Sobel_Click);
            // 
            // Laplaciano
            // 
            this.Laplaciano.Location = new System.Drawing.Point(14, 94);
            this.Laplaciano.Margin = new System.Windows.Forms.Padding(4);
            this.Laplaciano.Name = "Laplaciano";
            this.Laplaciano.Size = new System.Drawing.Size(182, 25);
            this.Laplaciano.TabIndex = 40;
            this.Laplaciano.Text = "Laplaciano";
            this.Laplaciano.UseVisualStyleBackColor = true;
            this.Laplaciano.Click += new System.EventHandler(this.Laplaciano_Click);
            // 
            // dilata
            // 
            this.dilata.Location = new System.Drawing.Point(23, 18);
            this.dilata.Margin = new System.Windows.Forms.Padding(4);
            this.dilata.Name = "dilata";
            this.dilata.Size = new System.Drawing.Size(160, 25);
            this.dilata.TabIndex = 42;
            this.dilata.Text = "Dilatar";
            this.dilata.UseVisualStyleBackColor = true;
            this.dilata.Click += new System.EventHandler(this.dilata_Click);
            // 
            // erosao
            // 
            this.erosao.Location = new System.Drawing.Point(23, 51);
            this.erosao.Margin = new System.Windows.Forms.Padding(4);
            this.erosao.Name = "erosao";
            this.erosao.Size = new System.Drawing.Size(160, 25);
            this.erosao.TabIndex = 43;
            this.erosao.Text = "Erosão";
            this.erosao.UseVisualStyleBackColor = true;
            this.erosao.Click += new System.EventHandler(this.erosao_Click);
            // 
            // abertura
            // 
            this.abertura.Location = new System.Drawing.Point(23, 84);
            this.abertura.Margin = new System.Windows.Forms.Padding(4);
            this.abertura.Name = "abertura";
            this.abertura.Size = new System.Drawing.Size(160, 25);
            this.abertura.TabIndex = 44;
            this.abertura.Text = "Abertura";
            this.abertura.UseVisualStyleBackColor = true;
            this.abertura.Click += new System.EventHandler(this.abertura_Click);
            // 
            // fechamento
            // 
            this.fechamento.Location = new System.Drawing.Point(23, 117);
            this.fechamento.Margin = new System.Windows.Forms.Padding(4);
            this.fechamento.Name = "fechamento";
            this.fechamento.Size = new System.Drawing.Size(160, 25);
            this.fechamento.TabIndex = 45;
            this.fechamento.Text = "Fechamento";
            this.fechamento.UseVisualStyleBackColor = true;
            this.fechamento.Click += new System.EventHandler(this.fechamento_Click);
            // 
            // contorn
            // 
            this.contorn.Location = new System.Drawing.Point(23, 150);
            this.contorn.Margin = new System.Windows.Forms.Padding(4);
            this.contorn.Name = "contorn";
            this.contorn.Size = new System.Drawing.Size(160, 25);
            this.contorn.TabIndex = 46;
            this.contorn.Text = "Contorno";
            this.contorn.UseVisualStyleBackColor = true;
            this.contorn.Click += new System.EventHandler(this.contorn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.dilata);
            this.panel1.Controls.Add(this.erosao);
            this.panel1.Controls.Add(this.abertura);
            this.panel1.Controls.Add(this.contorn);
            this.panel1.Controls.Add(this.fechamento);
            this.panel1.Location = new System.Drawing.Point(13, 549);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(197, 193);
            this.panel1.TabIndex = 48;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(36, 531);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(160, 22);
            this.textBox1.TabIndex = 49;
            this.textBox1.Text = "Operações Morfológicas";
            // 
            // Fractais
            // 
            this.Fractais.Location = new System.Drawing.Point(1332, 349);
            this.Fractais.Margin = new System.Windows.Forms.Padding(4);
            this.Fractais.Name = "Fractais";
            this.Fractais.Size = new System.Drawing.Size(160, 25);
            this.Fractais.TabIndex = 50;
            this.Fractais.Text = "Fractais";
            this.Fractais.UseVisualStyleBackColor = true;
            this.Fractais.Click += new System.EventHandler(this.Fractais_Click);
            // 
            // oleo
            // 
            this.oleo.Location = new System.Drawing.Point(1332, 382);
            this.oleo.Margin = new System.Windows.Forms.Padding(4);
            this.oleo.Name = "oleo";
            this.oleo.Size = new System.Drawing.Size(160, 25);
            this.oleo.TabIndex = 51;
            this.oleo.Text = "Pintura óleo";
            this.oleo.UseVisualStyleBackColor = true;
            this.oleo.Click += new System.EventHandler(this.oleo_Click);
            // 
            // Cartoon
            // 
            this.Cartoon.Location = new System.Drawing.Point(1332, 415);
            this.Cartoon.Margin = new System.Windows.Forms.Padding(4);
            this.Cartoon.Name = "Cartoon";
            this.Cartoon.Size = new System.Drawing.Size(160, 25);
            this.Cartoon.TabIndex = 52;
            this.Cartoon.Text = "Cartoon";
            this.Cartoon.UseVisualStyleBackColor = true;
            this.Cartoon.Click += new System.EventHandler(this.Cartoon_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.MEAN);
            this.panel2.Controls.Add(this.MIN);
            this.panel2.Controls.Add(this.MAX);
            this.panel2.Controls.Add(this.retiraSalPimenta);
            this.panel2.Controls.Add(this.ORDEM);
            this.panel2.Controls.Add(this.suavizaçãoGalziana);
            this.panel2.Controls.Add(this.gaussiano);
            this.panel2.Location = new System.Drawing.Point(240, 549);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(211, 255);
            this.panel2.TabIndex = 49;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.andButton);
            this.panel3.Controls.Add(this.orButton);
            this.panel3.Controls.Add(this.xorButton);
            this.panel3.Controls.Add(this.notButton);
            this.panel3.Location = new System.Drawing.Point(1126, 320);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(188, 193);
            this.panel3.TabIndex = 50;
            // 
            // pictureBoxImagem
            // 
            this.pictureBoxImagem.Location = new System.Drawing.Point(1277, 4);
            this.pictureBoxImagem.Name = "pictureBoxImagem";
            this.pictureBoxImagem.Size = new System.Drawing.Size(269, 198);
            this.pictureBoxImagem.TabIndex = 53;
            this.pictureBoxImagem.TabStop = false;
            // 
            // geraImagem
            // 
            this.geraImagem.Location = new System.Drawing.Point(1332, 210);
            this.geraImagem.Margin = new System.Windows.Forms.Padding(4);
            this.geraImagem.Name = "geraImagem";
            this.geraImagem.Size = new System.Drawing.Size(178, 25);
            this.geraImagem.TabIndex = 54;
            this.geraImagem.Text = "Gerar Imagem";
            this.geraImagem.UseVisualStyleBackColor = true;
            this.geraImagem.Click += new System.EventHandler(this.geraImagem_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(281, 531);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(127, 22);
            this.textBox2.TabIndex = 55;
            this.textBox2.Text = "Filtros Passa-Baixa";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(926, 301);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(117, 22);
            this.textBox3.TabIndex = 56;
            this.textBox3.Text = "Filtros Passa-Alta";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.dtcPrimeriaBorda);
            this.panel4.Controls.Add(this.Sobel);
            this.panel4.Controls.Add(this.Laplaciano);
            this.panel4.Location = new System.Drawing.Point(878, 320);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(216, 193);
            this.panel4.TabIndex = 51;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.NumcombinaLinear);
            this.panel5.Controls.Add(this.QuantidadeBrilho);
            this.panel5.Controls.Add(this.DiminuirBrilho);
            this.panel5.Controls.Add(this.AumentarBrilhoButton);
            this.panel5.Controls.Add(this.aumentarContraste);
            this.panel5.Controls.Add(this.combinacaoLinear);
            this.panel5.Controls.Add(this.DiminuirContraste);
            this.panel5.Controls.Add(this.quantidadeContraste);
            this.panel5.Location = new System.Drawing.Point(29, 290);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(545, 193);
            this.panel5.TabIndex = 52;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1546, 912);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.geraImagem);
            this.Controls.Add(this.pictureBoxImagem);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Cartoon);
            this.Controls.Add(this.oleo);
            this.Controls.Add(this.Fractais);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnEqualize);
            this.Controls.Add(this.chartEqualized);
            this.Controls.Add(this.chartOriginal);
            this.Controls.Add(this.limiarButton);
            this.Controls.Add(this.diferencaImagem);
            this.Controls.Add(this.inverterEsquerda);
            this.Controls.Add(this.mediaclick);
            this.Controls.Add(this.InverterDireita);
            this.Controls.Add(this.escalaCinza);
            this.Controls.Add(this.salvar);
            this.Controls.Add(this.carregarImagem2);
            this.Controls.Add(this.somarImagens);
            this.Controls.Add(this.SubtrairImagem);
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
            ((System.ComponentModel.ISupportInitialize)(this.chartOriginal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartEqualized)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagem)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
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
        private System.Windows.Forms.Button limiarButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartOriginal;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartEqualized;
        private System.Windows.Forms.Button btnEqualize;
        private System.Windows.Forms.Button MEAN;
        private System.Windows.Forms.Button MIN;
        private System.Windows.Forms.Button MAX;
        private System.Windows.Forms.Button retiraSalPimenta;
        private System.Windows.Forms.Button ORDEM;
        private System.Windows.Forms.Button suavizaçãoGalziana;
        private System.Windows.Forms.Button gaussiano;
        private System.Windows.Forms.Button dtcPrimeriaBorda;
        private System.Windows.Forms.Button Sobel;
        private System.Windows.Forms.Button Laplaciano;
        private System.Windows.Forms.Button dilata;
        private System.Windows.Forms.Button erosao;
        private System.Windows.Forms.Button abertura;
        private System.Windows.Forms.Button fechamento;
        private System.Windows.Forms.Button contorn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Fractais;
        private System.Windows.Forms.Button oleo;
        private System.Windows.Forms.Button Cartoon;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBoxImagem;
        private System.Windows.Forms.Button geraImagem;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
    }
}

