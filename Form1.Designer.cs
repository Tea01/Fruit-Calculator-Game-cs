namespace ndpProje
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnStart = new System.Windows.Forms.Button();
            this.lblTimer = new System.Windows.Forms.Label();
            this.countdownTimer = new System.Windows.Forms.Timer(this.components);
            this.lblTopic = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.picBoxMeyve = new System.Windows.Forms.PictureBox();
            this.picBoxNarenciye = new System.Windows.Forms.PictureBox();
            this.picBoxKati = new System.Windows.Forms.PictureBox();
            this.btnNarenciye = new System.Windows.Forms.Button();
            this.btnKati = new System.Windows.Forms.Button();
            this.lblMeyve = new System.Windows.Forms.Label();
            this.lblSivi = new System.Windows.Forms.Label();
            this.lblPure = new System.Windows.Forms.Label();
            this.lblVitA = new System.Windows.Forms.Label();
            this.lblVitC = new System.Windows.Forms.Label();
            this.listBoxMeyve = new System.Windows.Forms.ListBox();
            this.listBoxSivi = new System.Windows.Forms.ListBox();
            this.listBoxPure = new System.Windows.Forms.ListBox();
            this.listBoxVitA = new System.Windows.Forms.ListBox();
            this.listBoxVitC = new System.Windows.Forms.ListBox();
            this.lblToplam = new System.Windows.Forms.Label();
            this.ToplamSivi = new System.Windows.Forms.ListBox();
            this.ToplamPure = new System.Windows.Forms.ListBox();
            this.ToplamVitA = new System.Windows.Forms.ListBox();
            this.ToplamVitC = new System.Windows.Forms.ListBox();
            this.listBoxGram = new System.Windows.Forms.ListBox();
            this.lblGram = new System.Windows.Forms.Label();
            this.btnYeniOyun = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMeyve)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxNarenciye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxKati)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Green;
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.Font = new System.Drawing.Font("Juice ITC", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnStart.Location = new System.Drawing.Point(1212, 387);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(133, 54);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Basla";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblTimer
            // 
            this.lblTimer.BackColor = System.Drawing.Color.MintCream;
            this.lblTimer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTimer.Font = new System.Drawing.Font("Harrington", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTimer.Location = new System.Drawing.Point(852, 535);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(231, 62);
            this.lblTimer.TabIndex = 1;
            this.lblTimer.Text = "01:00";
            this.lblTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // countdownTimer
            // 
            this.countdownTimer.Interval = 1000;
            this.countdownTimer.Tick += new System.EventHandler(this.countdownTimer_Tick);
            // 
            // lblTopic
            // 
            this.lblTopic.BackColor = System.Drawing.Color.Transparent;
            this.lblTopic.Font = new System.Drawing.Font("Jokerman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopic.Location = new System.Drawing.Point(843, 26);
            this.lblTopic.Name = "lblTopic";
            this.lblTopic.Size = new System.Drawing.Size(497, 297);
            this.lblTopic.TabIndex = 2;
            this.lblTopic.Text = "Sağlık Uygulamasına\r\nHoş Geldiniz!";
            this.lblTopic.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl1
            // 
            this.lbl1.BackColor = System.Drawing.Color.ForestGreen;
            this.lbl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl1.Font = new System.Drawing.Font("Ink Free", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl1.Location = new System.Drawing.Point(852, 484);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(231, 52);
            this.lbl1.TabIndex = 3;
            this.lbl1.Text = "Süre";
            this.lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Black;
            this.btnExit.Font = new System.Drawing.Font("Curlz MT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExit.Location = new System.Drawing.Point(1267, 666);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(136, 52);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Çıkış";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // picBoxMeyve
            // 
            this.picBoxMeyve.BackColor = System.Drawing.Color.Firebrick;
            this.picBoxMeyve.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBoxMeyve.Location = new System.Drawing.Point(12, 12);
            this.picBoxMeyve.Name = "picBoxMeyve";
            this.picBoxMeyve.Size = new System.Drawing.Size(479, 398);
            this.picBoxMeyve.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxMeyve.TabIndex = 6;
            this.picBoxMeyve.TabStop = false;
            // 
            // picBoxNarenciye
            // 
            this.picBoxNarenciye.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBoxNarenciye.Image = ((System.Drawing.Image)(resources.GetObject("picBoxNarenciye.Image")));
            this.picBoxNarenciye.Location = new System.Drawing.Point(33, 416);
            this.picBoxNarenciye.Name = "picBoxNarenciye";
            this.picBoxNarenciye.Size = new System.Drawing.Size(185, 229);
            this.picBoxNarenciye.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxNarenciye.TabIndex = 7;
            this.picBoxNarenciye.TabStop = false;
            // 
            // picBoxKati
            // 
            this.picBoxKati.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBoxKati.Image = ((System.Drawing.Image)(resources.GetObject("picBoxKati.Image")));
            this.picBoxKati.InitialImage = null;
            this.picBoxKati.Location = new System.Drawing.Point(288, 416);
            this.picBoxKati.Name = "picBoxKati";
            this.picBoxKati.Size = new System.Drawing.Size(168, 229);
            this.picBoxKati.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxKati.TabIndex = 8;
            this.picBoxKati.TabStop = false;
            // 
            // btnNarenciye
            // 
            this.btnNarenciye.BackColor = System.Drawing.Color.DarkGreen;
            this.btnNarenciye.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNarenciye.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNarenciye.Font = new System.Drawing.Font("Juice ITC", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNarenciye.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNarenciye.Location = new System.Drawing.Point(31, 663);
            this.btnNarenciye.Name = "btnNarenciye";
            this.btnNarenciye.Size = new System.Drawing.Size(194, 48);
            this.btnNarenciye.TabIndex = 10;
            this.btnNarenciye.Text = "Narenciye Sıkacağı";
            this.btnNarenciye.UseVisualStyleBackColor = false;
            this.btnNarenciye.Click += new System.EventHandler(this.btnNarenciye_Click);
            // 
            // btnKati
            // 
            this.btnKati.BackColor = System.Drawing.Color.DarkGreen;
            this.btnKati.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKati.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKati.Font = new System.Drawing.Font("Juice ITC", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKati.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnKati.Location = new System.Drawing.Point(288, 661);
            this.btnKati.Name = "btnKati";
            this.btnKati.Size = new System.Drawing.Size(168, 48);
            this.btnKati.TabIndex = 11;
            this.btnKati.Text = "Katı Sıkacağı";
            this.btnKati.UseVisualStyleBackColor = false;
            this.btnKati.Click += new System.EventHandler(this.btnKati_Click);
            // 
            // lblMeyve
            // 
            this.lblMeyve.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.lblMeyve.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMeyve.Font = new System.Drawing.Font("Juice ITC", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeyve.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblMeyve.Location = new System.Drawing.Point(560, 88);
            this.lblMeyve.Name = "lblMeyve";
            this.lblMeyve.Size = new System.Drawing.Size(134, 49);
            this.lblMeyve.TabIndex = 13;
            this.lblMeyve.Text = "Meyve";
            this.lblMeyve.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSivi
            // 
            this.lblSivi.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.lblSivi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSivi.Font = new System.Drawing.Font("Juice ITC", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSivi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSivi.Location = new System.Drawing.Point(785, 86);
            this.lblSivi.Name = "lblSivi";
            this.lblSivi.Size = new System.Drawing.Size(129, 50);
            this.lblSivi.TabIndex = 14;
            this.lblSivi.Text = "Sıvı";
            this.lblSivi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPure
            // 
            this.lblPure.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.lblPure.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPure.Font = new System.Drawing.Font("Juice ITC", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPure.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPure.Location = new System.Drawing.Point(921, 87);
            this.lblPure.Name = "lblPure";
            this.lblPure.Size = new System.Drawing.Size(129, 50);
            this.lblPure.TabIndex = 15;
            this.lblPure.Text = "Püre";
            this.lblPure.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblVitA
            // 
            this.lblVitA.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.lblVitA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblVitA.Font = new System.Drawing.Font("Juice ITC", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVitA.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblVitA.Location = new System.Drawing.Point(1059, 86);
            this.lblVitA.Name = "lblVitA";
            this.lblVitA.Size = new System.Drawing.Size(143, 51);
            this.lblVitA.TabIndex = 16;
            this.lblVitA.Text = "Vitamin A(iu)";
            this.lblVitA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblVitC
            // 
            this.lblVitC.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.lblVitC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblVitC.Font = new System.Drawing.Font("Juice ITC", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVitC.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblVitC.Location = new System.Drawing.Point(1212, 86);
            this.lblVitC.Name = "lblVitC";
            this.lblVitC.Size = new System.Drawing.Size(153, 50);
            this.lblVitC.TabIndex = 17;
            this.lblVitC.Text = "Vitamin C(mg)";
            this.lblVitC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listBoxMeyve
            // 
            this.listBoxMeyve.BackColor = System.Drawing.Color.Snow;
            this.listBoxMeyve.FormattingEnabled = true;
            this.listBoxMeyve.ItemHeight = 16;
            this.listBoxMeyve.Location = new System.Drawing.Point(560, 155);
            this.listBoxMeyve.Name = "listBoxMeyve";
            this.listBoxMeyve.Size = new System.Drawing.Size(134, 196);
            this.listBoxMeyve.TabIndex = 18;
            // 
            // listBoxSivi
            // 
            this.listBoxSivi.BackColor = System.Drawing.Color.Snow;
            this.listBoxSivi.FormattingEnabled = true;
            this.listBoxSivi.ItemHeight = 16;
            this.listBoxSivi.Location = new System.Drawing.Point(785, 154);
            this.listBoxSivi.Name = "listBoxSivi";
            this.listBoxSivi.Size = new System.Drawing.Size(129, 196);
            this.listBoxSivi.TabIndex = 19;
            // 
            // listBoxPure
            // 
            this.listBoxPure.BackColor = System.Drawing.Color.Snow;
            this.listBoxPure.FormattingEnabled = true;
            this.listBoxPure.ItemHeight = 16;
            this.listBoxPure.Location = new System.Drawing.Point(921, 154);
            this.listBoxPure.Name = "listBoxPure";
            this.listBoxPure.Size = new System.Drawing.Size(129, 196);
            this.listBoxPure.TabIndex = 20;
            // 
            // listBoxVitA
            // 
            this.listBoxVitA.BackColor = System.Drawing.Color.Snow;
            this.listBoxVitA.FormattingEnabled = true;
            this.listBoxVitA.ItemHeight = 16;
            this.listBoxVitA.Location = new System.Drawing.Point(1059, 154);
            this.listBoxVitA.Name = "listBoxVitA";
            this.listBoxVitA.Size = new System.Drawing.Size(143, 196);
            this.listBoxVitA.TabIndex = 21;
            // 
            // listBoxVitC
            // 
            this.listBoxVitC.BackColor = System.Drawing.Color.Snow;
            this.listBoxVitC.FormattingEnabled = true;
            this.listBoxVitC.ItemHeight = 16;
            this.listBoxVitC.Location = new System.Drawing.Point(1212, 154);
            this.listBoxVitC.Name = "listBoxVitC";
            this.listBoxVitC.Size = new System.Drawing.Size(153, 196);
            this.listBoxVitC.TabIndex = 22;
            // 
            // lblToplam
            // 
            this.lblToplam.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.lblToplam.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblToplam.Font = new System.Drawing.Font("Juice ITC", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToplam.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblToplam.Location = new System.Drawing.Point(602, 358);
            this.lblToplam.Name = "lblToplam";
            this.lblToplam.Size = new System.Drawing.Size(154, 50);
            this.lblToplam.TabIndex = 23;
            this.lblToplam.Text = "Toplam";
            this.lblToplam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ToplamSivi
            // 
            this.ToplamSivi.BackColor = System.Drawing.Color.Snow;
            this.ToplamSivi.FormattingEnabled = true;
            this.ToplamSivi.ItemHeight = 16;
            this.ToplamSivi.Location = new System.Drawing.Point(785, 356);
            this.ToplamSivi.Name = "ToplamSivi";
            this.ToplamSivi.Size = new System.Drawing.Size(128, 52);
            this.ToplamSivi.TabIndex = 24;
            // 
            // ToplamPure
            // 
            this.ToplamPure.BackColor = System.Drawing.Color.Snow;
            this.ToplamPure.FormattingEnabled = true;
            this.ToplamPure.ItemHeight = 16;
            this.ToplamPure.Location = new System.Drawing.Point(925, 356);
            this.ToplamPure.Name = "ToplamPure";
            this.ToplamPure.Size = new System.Drawing.Size(124, 52);
            this.ToplamPure.TabIndex = 25;
            // 
            // ToplamVitA
            // 
            this.ToplamVitA.BackColor = System.Drawing.Color.Snow;
            this.ToplamVitA.FormattingEnabled = true;
            this.ToplamVitA.ItemHeight = 16;
            this.ToplamVitA.Location = new System.Drawing.Point(1059, 356);
            this.ToplamVitA.Name = "ToplamVitA";
            this.ToplamVitA.Size = new System.Drawing.Size(143, 52);
            this.ToplamVitA.TabIndex = 26;
            // 
            // ToplamVitC
            // 
            this.ToplamVitC.BackColor = System.Drawing.Color.Snow;
            this.ToplamVitC.FormattingEnabled = true;
            this.ToplamVitC.ItemHeight = 16;
            this.ToplamVitC.Location = new System.Drawing.Point(1212, 356);
            this.ToplamVitC.Name = "ToplamVitC";
            this.ToplamVitC.Size = new System.Drawing.Size(153, 52);
            this.ToplamVitC.TabIndex = 27;
            // 
            // listBoxGram
            // 
            this.listBoxGram.BackColor = System.Drawing.Color.Snow;
            this.listBoxGram.FormattingEnabled = true;
            this.listBoxGram.ItemHeight = 16;
            this.listBoxGram.Location = new System.Drawing.Point(700, 155);
            this.listBoxGram.Name = "listBoxGram";
            this.listBoxGram.Size = new System.Drawing.Size(79, 196);
            this.listBoxGram.TabIndex = 29;
            // 
            // lblGram
            // 
            this.lblGram.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.lblGram.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblGram.Font = new System.Drawing.Font("Juice ITC", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGram.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblGram.Location = new System.Drawing.Point(697, 88);
            this.lblGram.Name = "lblGram";
            this.lblGram.Size = new System.Drawing.Size(83, 49);
            this.lblGram.TabIndex = 28;
            this.lblGram.Text = "Gram";
            this.lblGram.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnYeniOyun
            // 
            this.btnYeniOyun.BackColor = System.Drawing.Color.Coral;
            this.btnYeniOyun.Font = new System.Drawing.Font("Curlz MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYeniOyun.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnYeniOyun.Location = new System.Drawing.Point(1070, 666);
            this.btnYeniOyun.Name = "btnYeniOyun";
            this.btnYeniOyun.Size = new System.Drawing.Size(173, 52);
            this.btnYeniOyun.TabIndex = 30;
            this.btnYeniOyun.Text = "Yeni oyun";
            this.btnYeniOyun.UseVisualStyleBackColor = false;
            this.btnYeniOyun.Click += new System.EventHandler(this.btnYeniOyun_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Crimson;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1415, 730);
            this.Controls.Add(this.btnYeniOyun);
            this.Controls.Add(this.listBoxGram);
            this.Controls.Add(this.lblGram);
            this.Controls.Add(this.ToplamVitC);
            this.Controls.Add(this.ToplamVitA);
            this.Controls.Add(this.ToplamPure);
            this.Controls.Add(this.ToplamSivi);
            this.Controls.Add(this.lblToplam);
            this.Controls.Add(this.listBoxVitC);
            this.Controls.Add(this.listBoxVitA);
            this.Controls.Add(this.listBoxPure);
            this.Controls.Add(this.listBoxSivi);
            this.Controls.Add(this.listBoxMeyve);
            this.Controls.Add(this.lblVitC);
            this.Controls.Add(this.lblVitA);
            this.Controls.Add(this.lblPure);
            this.Controls.Add(this.lblSivi);
            this.Controls.Add(this.lblMeyve);
            this.Controls.Add(this.btnKati);
            this.Controls.Add(this.picBoxKati);
            this.Controls.Add(this.picBoxNarenciye);
            this.Controls.Add(this.lblTopic);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnNarenciye);
            this.Controls.Add(this.picBoxMeyve);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Meyve Ninja";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMeyve)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxNarenciye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxKati)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Timer countdownTimer;
        private System.Windows.Forms.Label lblTopic;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox picBoxMeyve;
        private System.Windows.Forms.PictureBox picBoxNarenciye;
        private System.Windows.Forms.PictureBox picBoxKati;
        private System.Windows.Forms.Button btnNarenciye;
        private System.Windows.Forms.Button btnKati;
        private System.Windows.Forms.Label lblMeyve;
        private System.Windows.Forms.Label lblSivi;
        private System.Windows.Forms.Label lblPure;
        private System.Windows.Forms.Label lblVitA;
        private System.Windows.Forms.Label lblVitC;
        private System.Windows.Forms.ListBox listBoxMeyve;
        private System.Windows.Forms.ListBox listBoxSivi;
        private System.Windows.Forms.ListBox listBoxPure;
        private System.Windows.Forms.ListBox listBoxVitA;
        private System.Windows.Forms.ListBox listBoxVitC;
        private System.Windows.Forms.Label lblToplam;
        private System.Windows.Forms.ListBox ToplamSivi;
        private System.Windows.Forms.ListBox ToplamPure;
        private System.Windows.Forms.ListBox ToplamVitA;
        private System.Windows.Forms.ListBox ToplamVitC;
        private System.Windows.Forms.ListBox listBoxGram;
        private System.Windows.Forms.Label lblGram;
        private System.Windows.Forms.Button btnYeniOyun;
    }
}

