namespace quiz
{
    partial class frmhome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmhome));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.imgTrueFalse = new System.Windows.Forms.ImageList(this.components);
            this.photostimer = new System.Windows.Forms.Timer(this.components);
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lbltimer = new System.Windows.Forms.Label();
            this.imglist = new System.Windows.Forms.ImageList(this.components);
            this.sideimg = new System.Windows.Forms.ImageList(this.components);
            this.answerbtnpic = new System.Windows.Forms.ImageList(this.components);
            this.lblcert = new System.Windows.Forms.Label();
            this.lblcounttrue = new System.Windows.Forms.Label();
            this.lblerr = new System.Windows.Forms.Label();
            this.lblcountfalse = new System.Windows.Forms.Label();
            this.resultpanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.sidepanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnstart = new System.Windows.Forms.Button();
            this.questionpic1 = new System.Windows.Forms.PictureBox();
            this.questionpic2 = new System.Windows.Forms.PictureBox();
            this.btnresult = new System.Windows.Forms.Button();
            this.btnfalse3 = new System.Windows.Forms.Button();
            this.btnfalse2 = new System.Windows.Forms.Button();
            this.btnfalse1 = new System.Windows.Forms.Button();
            this.btntrue1 = new System.Windows.Forms.Button();
            this.btntrue2 = new System.Windows.Forms.Button();
            this.btntrue3 = new System.Windows.Forms.Button();
            this.btninfo = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.resultpanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionpic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionpic2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Beige;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(540, 317);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(451, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "1 - A frase \"Penso logo existo\" é do Descartes?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Beige;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(540, 405);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(537, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "2 - Atualmente a tabela periódica possui 113 elementos?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Beige;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(540, 510);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(528, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "3 - A luz do Sol demora 8 minutos para chegar a Terra?";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Beige;
            this.panel1.Controls.Add(this.btntrue1);
            this.panel1.Controls.Add(this.btntrue2);
            this.panel1.Controls.Add(this.btntrue3);
            this.panel1.Location = new System.Drawing.Point(471, 279);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(639, 353);
            this.panel1.TabIndex = 16;
            // 
            // imgTrueFalse
            // 
            this.imgTrueFalse.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgTrueFalse.ImageStream")));
            this.imgTrueFalse.TransparentColor = System.Drawing.Color.Transparent;
            this.imgTrueFalse.Images.SetKeyName(0, "check-mark.png");
            this.imgTrueFalse.Images.SetKeyName(1, "cancel.png");
            // 
            // photostimer
            // 
            this.photostimer.Enabled = true;
            this.photostimer.Interval = 2000;
            this.photostimer.Tick += new System.EventHandler(this.photostimer_Tick);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // lbltimer
            // 
            this.lbltimer.AutoSize = true;
            this.lbltimer.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltimer.Location = new System.Drawing.Point(1428, 130);
            this.lbltimer.Name = "lbltimer";
            this.lbltimer.Size = new System.Drawing.Size(53, 35);
            this.lbltimer.TabIndex = 20;
            this.lbltimer.Text = "00";
            // 
            // imglist
            // 
            this.imglist.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglist.ImageStream")));
            this.imglist.TransparentColor = System.Drawing.Color.Transparent;
            this.imglist.Images.SetKeyName(0, "start-button.png");
            this.imglist.Images.SetKeyName(1, "question.png");
            // 
            // sideimg
            // 
            this.sideimg.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("sideimg.ImageStream")));
            this.sideimg.TransparentColor = System.Drawing.Color.Transparent;
            this.sideimg.Images.SetKeyName(0, "exit.png");
            this.sideimg.Images.SetKeyName(1, "info.png");
            // 
            // answerbtnpic
            // 
            this.answerbtnpic.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("answerbtnpic.ImageStream")));
            this.answerbtnpic.TransparentColor = System.Drawing.Color.Transparent;
            this.answerbtnpic.Images.SetKeyName(0, "question.png");
            // 
            // lblcert
            // 
            this.lblcert.AutoSize = true;
            this.lblcert.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcert.ForeColor = System.Drawing.Color.Green;
            this.lblcert.Location = new System.Drawing.Point(540, 34);
            this.lblcert.Name = "lblcert";
            this.lblcert.Size = new System.Drawing.Size(69, 24);
            this.lblcert.TabIndex = 11;
            this.lblcert.Text = "Certas";
            this.lblcert.Visible = false;
            // 
            // lblcounttrue
            // 
            this.lblcounttrue.AutoSize = true;
            this.lblcounttrue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblcounttrue.Location = new System.Drawing.Point(618, 34);
            this.lblcounttrue.Name = "lblcounttrue";
            this.lblcounttrue.Size = new System.Drawing.Size(20, 24);
            this.lblcounttrue.TabIndex = 14;
            this.lblcounttrue.Text = "0";
            this.lblcounttrue.Visible = false;
            // 
            // lblerr
            // 
            this.lblerr.AutoSize = true;
            this.lblerr.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblerr.ForeColor = System.Drawing.Color.Red;
            this.lblerr.Location = new System.Drawing.Point(892, 34);
            this.lblerr.Name = "lblerr";
            this.lblerr.Size = new System.Drawing.Size(82, 24);
            this.lblerr.TabIndex = 12;
            this.lblerr.Text = "Erradas";
            this.lblerr.Visible = false;
            // 
            // lblcountfalse
            // 
            this.lblcountfalse.AutoSize = true;
            this.lblcountfalse.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblcountfalse.Location = new System.Drawing.Point(980, 34);
            this.lblcountfalse.Name = "lblcountfalse";
            this.lblcountfalse.Size = new System.Drawing.Size(20, 24);
            this.lblcountfalse.TabIndex = 15;
            this.lblcountfalse.Text = "0";
            this.lblcountfalse.Visible = false;
            // 
            // resultpanel
            // 
            this.resultpanel.BackColor = System.Drawing.Color.Beige;
            this.resultpanel.Controls.Add(this.lblcountfalse);
            this.resultpanel.Controls.Add(this.lblerr);
            this.resultpanel.Controls.Add(this.lblcounttrue);
            this.resultpanel.Controls.Add(this.lblcert);
            this.resultpanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.resultpanel.Location = new System.Drawing.Point(0, 820);
            this.resultpanel.Name = "resultpanel";
            this.resultpanel.Size = new System.Drawing.Size(1532, 100);
            this.resultpanel.TabIndex = 17;
            this.resultpanel.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.btninfo);
            this.panel2.Controls.Add(this.sidepanel);
            this.panel2.Controls.Add(this.btnexit);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1532, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(88, 920);
            this.panel2.TabIndex = 24;
            // 
            // sidepanel
            // 
            this.sidepanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.sidepanel.Location = new System.Drawing.Point(83, 12);
            this.sidepanel.Name = "sidepanel";
            this.sidepanel.Size = new System.Drawing.Size(5, 66);
            this.sidepanel.TabIndex = 25;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::quiz.Properties.Resources.timer;
            this.pictureBox1.Location = new System.Drawing.Point(1382, 123);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // btnstart
            // 
            this.btnstart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnstart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnstart.ImageIndex = 0;
            this.btnstart.ImageList = this.imglist;
            this.btnstart.Location = new System.Drawing.Point(702, 130);
            this.btnstart.Name = "btnstart";
            this.btnstart.Size = new System.Drawing.Size(154, 84);
            this.btnstart.TabIndex = 22;
            this.btnstart.UseVisualStyleBackColor = false;
            this.btnstart.Click += new System.EventHandler(this.btnstart_Click);
            // 
            // questionpic1
            // 
            this.questionpic1.Image = global::quiz.Properties.Resources._867cfbfe782227d2c8311abe53f72cd5_desenho_de_ponto_de_interrogacao_3d;
            this.questionpic1.Location = new System.Drawing.Point(1116, 279);
            this.questionpic1.Name = "questionpic1";
            this.questionpic1.Size = new System.Drawing.Size(365, 406);
            this.questionpic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.questionpic1.TabIndex = 18;
            this.questionpic1.TabStop = false;
            this.questionpic1.Visible = false;
            // 
            // questionpic2
            // 
            this.questionpic2.Image = global::quiz.Properties.Resources._867cfbfe782227d2c8311abe53f72cd5_desenho_de_ponto_de_interrogacao_3d;
            this.questionpic2.Location = new System.Drawing.Point(100, 279);
            this.questionpic2.Name = "questionpic2";
            this.questionpic2.Size = new System.Drawing.Size(365, 406);
            this.questionpic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.questionpic2.TabIndex = 19;
            this.questionpic2.TabStop = false;
            this.questionpic2.Visible = false;
            // 
            // btnresult
            // 
            this.btnresult.Enabled = false;
            this.btnresult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnresult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnresult.ImageKey = "question.png";
            this.btnresult.ImageList = this.answerbtnpic;
            this.btnresult.Location = new System.Drawing.Point(716, 685);
            this.btnresult.Name = "btnresult";
            this.btnresult.Size = new System.Drawing.Size(140, 81);
            this.btnresult.TabIndex = 7;
            this.btnresult.UseVisualStyleBackColor = true;
            this.btnresult.Visible = false;
            this.btnresult.Click += new System.EventHandler(this.btnresult_Click);
            // 
            // btnfalse3
            // 
            this.btnfalse3.BackColor = System.Drawing.Color.Beige;
            this.btnfalse3.Enabled = false;
            this.btnfalse3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnfalse3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfalse3.ImageKey = "cancel.png";
            this.btnfalse3.ImageList = this.imgTrueFalse;
            this.btnfalse3.Location = new System.Drawing.Point(826, 553);
            this.btnfalse3.Name = "btnfalse3";
            this.btnfalse3.Size = new System.Drawing.Size(100, 39);
            this.btnfalse3.TabIndex = 6;
            this.btnfalse3.UseVisualStyleBackColor = false;
            this.btnfalse3.Click += new System.EventHandler(this.btnfalse3_Click);
            // 
            // btnfalse2
            // 
            this.btnfalse2.BackColor = System.Drawing.Color.Beige;
            this.btnfalse2.Enabled = false;
            this.btnfalse2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnfalse2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfalse2.ImageKey = "cancel.png";
            this.btnfalse2.ImageList = this.imgTrueFalse;
            this.btnfalse2.Location = new System.Drawing.Point(828, 448);
            this.btnfalse2.Name = "btnfalse2";
            this.btnfalse2.Size = new System.Drawing.Size(100, 39);
            this.btnfalse2.TabIndex = 4;
            this.btnfalse2.UseVisualStyleBackColor = false;
            this.btnfalse2.Click += new System.EventHandler(this.btnfalse2_Click);
            // 
            // btnfalse1
            // 
            this.btnfalse1.BackColor = System.Drawing.Color.Beige;
            this.btnfalse1.Enabled = false;
            this.btnfalse1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnfalse1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfalse1.ImageKey = "cancel.png";
            this.btnfalse1.ImageList = this.imgTrueFalse;
            this.btnfalse1.Location = new System.Drawing.Point(828, 355);
            this.btnfalse1.Name = "btnfalse1";
            this.btnfalse1.Size = new System.Drawing.Size(98, 39);
            this.btnfalse1.TabIndex = 1;
            this.btnfalse1.UseVisualStyleBackColor = false;
            this.btnfalse1.Click += new System.EventHandler(this.btnfalse1_Click);
            // 
            // btntrue1
            // 
            this.btntrue1.BackColor = System.Drawing.Color.Beige;
            this.btntrue1.Enabled = false;
            this.btntrue1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntrue1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntrue1.ImageKey = "check-mark.png";
            this.btntrue1.ImageList = this.imgTrueFalse;
            this.btntrue1.Location = new System.Drawing.Point(151, 76);
            this.btntrue1.Name = "btntrue1";
            this.btntrue1.Size = new System.Drawing.Size(98, 39);
            this.btntrue1.TabIndex = 2;
            this.btntrue1.UseVisualStyleBackColor = false;
            this.btntrue1.Click += new System.EventHandler(this.btntrue1_Click);
            // 
            // btntrue2
            // 
            this.btntrue2.BackColor = System.Drawing.Color.Beige;
            this.btntrue2.Enabled = false;
            this.btntrue2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntrue2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntrue2.ImageKey = "check-mark.png";
            this.btntrue2.ImageList = this.imgTrueFalse;
            this.btntrue2.Location = new System.Drawing.Point(151, 169);
            this.btntrue2.Name = "btntrue2";
            this.btntrue2.Size = new System.Drawing.Size(98, 39);
            this.btntrue2.TabIndex = 3;
            this.btntrue2.UseVisualStyleBackColor = false;
            this.btntrue2.Click += new System.EventHandler(this.btntrue2_Click);
            // 
            // btntrue3
            // 
            this.btntrue3.BackColor = System.Drawing.Color.Beige;
            this.btntrue3.Enabled = false;
            this.btntrue3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntrue3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntrue3.ImageKey = "check-mark.png";
            this.btntrue3.ImageList = this.imgTrueFalse;
            this.btntrue3.Location = new System.Drawing.Point(151, 274);
            this.btntrue3.Name = "btntrue3";
            this.btntrue3.Size = new System.Drawing.Size(98, 39);
            this.btntrue3.TabIndex = 5;
            this.btntrue3.UseVisualStyleBackColor = false;
            this.btntrue3.Click += new System.EventHandler(this.btntrue3_Click);
            // 
            // btninfo
            // 
            this.btninfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btninfo.ImageKey = "info.png";
            this.btninfo.ImageList = this.sideimg;
            this.btninfo.Location = new System.Drawing.Point(11, 99);
            this.btninfo.Name = "btninfo";
            this.btninfo.Size = new System.Drawing.Size(66, 66);
            this.btninfo.TabIndex = 26;
            this.btninfo.UseVisualStyleBackColor = true;
            this.btninfo.Click += new System.EventHandler(this.btninfo_Click);
            this.btninfo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btninfo_MouseMove);
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnexit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnexit.ImageKey = "exit.png";
            this.btnexit.ImageList = this.sideimg;
            this.btnexit.Location = new System.Drawing.Point(11, 12);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(66, 66);
            this.btnexit.TabIndex = 13;
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            this.btnexit.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnexit_MouseMove);
            // 
            // frmhome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1620, 920);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnstart);
            this.Controls.Add(this.lbltimer);
            this.Controls.Add(this.questionpic1);
            this.Controls.Add(this.questionpic2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnresult);
            this.Controls.Add(this.btnfalse3);
            this.Controls.Add(this.btnfalse2);
            this.Controls.Add(this.btnfalse1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.resultpanel);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmhome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quiz";
            this.panel1.ResumeLayout(false);
            this.resultpanel.ResumeLayout(false);
            this.resultpanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionpic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionpic2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnfalse1;
        private System.Windows.Forms.Button btntrue1;
        private System.Windows.Forms.Button btntrue2;
        private System.Windows.Forms.Button btnfalse2;
        private System.Windows.Forms.Button btntrue3;
        private System.Windows.Forms.Button btnfalse3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer photostimer;
        private System.Windows.Forms.PictureBox questionpic1;
        private System.Windows.Forms.PictureBox questionpic2;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lbltimer;
        private System.Windows.Forms.Button btnstart;
        private System.Windows.Forms.ImageList imglist;
        private System.Windows.Forms.ImageList sideimg;
        private System.Windows.Forms.ImageList imgTrueFalse;
        private System.Windows.Forms.ImageList answerbtnpic;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnresult;
        private System.Windows.Forms.Label lblcert;
        private System.Windows.Forms.Label lblcounttrue;
        private System.Windows.Forms.Label lblerr;
        private System.Windows.Forms.Label lblcountfalse;
        private System.Windows.Forms.Panel resultpanel;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel sidepanel;
        private System.Windows.Forms.Button btninfo;
    }
}

