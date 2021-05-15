
namespace Calculator
{
    partial class Calculator
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
            this.zerobtn = new System.Windows.Forms.Button();
            this.zerozerobtn = new System.Windows.Forms.Button();
            this.dotbtn = new System.Windows.Forms.Button();
            this.plusbtn = new System.Windows.Forms.Button();
            this.equaltobtn = new System.Windows.Forms.Button();
            this.minusbtn = new System.Windows.Forms.Button();
            this.threebtn = new System.Windows.Forms.Button();
            this.twobtn = new System.Windows.Forms.Button();
            this.onebtn = new System.Windows.Forms.Button();
            this.Cbtn = new System.Windows.Forms.Button();
            this.timesbtn = new System.Windows.Forms.Button();
            this.sixbtn = new System.Windows.Forms.Button();
            this.fivebtn = new System.Windows.Forms.Button();
            this.fourbtn = new System.Windows.Forms.Button();
            this.CEbtn = new System.Windows.Forms.Button();
            this.dividebtn = new System.Windows.Forms.Button();
            this.ninebtn = new System.Windows.Forms.Button();
            this.eightbtn = new System.Windows.Forms.Button();
            this.sevenbtn = new System.Windows.Forms.Button();
            this.delbtn = new System.Windows.Forms.Button();
            this.Mbtn = new System.Windows.Forms.Button();
            this.Mminusbtn = new System.Windows.Forms.Button();
            this.Mplusbtn = new System.Windows.Forms.Button();
            this.Sqrtbtn = new System.Windows.Forms.Button();
            this.textboxdisplay = new System.Windows.Forms.TextBox();
            this.labeldatashow = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // zerobtn
            // 
            this.zerobtn.BackColor = System.Drawing.Color.SteelBlue;
            this.zerobtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.zerobtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zerobtn.ForeColor = System.Drawing.Color.Black;
            this.zerobtn.Location = new System.Drawing.Point(13, 304);
            this.zerobtn.Name = "zerobtn";
            this.zerobtn.Size = new System.Drawing.Size(55, 45);
            this.zerobtn.TabIndex = 20;
            this.zerobtn.Text = "0";
            this.zerobtn.UseVisualStyleBackColor = false;
            this.zerobtn.UseWaitCursor = true;
            this.zerobtn.Click += new System.EventHandler(this.num_click);
            // 
            // zerozerobtn
            // 
            this.zerozerobtn.BackColor = System.Drawing.Color.SteelBlue;
            this.zerozerobtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.zerozerobtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zerozerobtn.ForeColor = System.Drawing.Color.Black;
            this.zerozerobtn.Location = new System.Drawing.Point(74, 304);
            this.zerozerobtn.Name = "zerozerobtn";
            this.zerozerobtn.Size = new System.Drawing.Size(55, 45);
            this.zerozerobtn.TabIndex = 21;
            this.zerozerobtn.Text = "00";
            this.zerozerobtn.UseVisualStyleBackColor = false;
            this.zerozerobtn.UseWaitCursor = true;
            this.zerozerobtn.Click += new System.EventHandler(this.num_click);
            // 
            // dotbtn
            // 
            this.dotbtn.BackColor = System.Drawing.Color.SteelBlue;
            this.dotbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.dotbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dotbtn.ForeColor = System.Drawing.Color.Black;
            this.dotbtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.dotbtn.Location = new System.Drawing.Point(135, 304);
            this.dotbtn.Name = "dotbtn";
            this.dotbtn.Size = new System.Drawing.Size(55, 45);
            this.dotbtn.TabIndex = 22;
            this.dotbtn.Text = ".";
            this.dotbtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.dotbtn.UseVisualStyleBackColor = false;
            this.dotbtn.UseWaitCursor = true;
            this.dotbtn.Click += new System.EventHandler(this.num_click);
            // 
            // plusbtn
            // 
            this.plusbtn.BackColor = System.Drawing.Color.SteelBlue;
            this.plusbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.plusbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusbtn.ForeColor = System.Drawing.Color.Black;
            this.plusbtn.Location = new System.Drawing.Point(196, 304);
            this.plusbtn.Name = "plusbtn";
            this.plusbtn.Size = new System.Drawing.Size(55, 45);
            this.plusbtn.TabIndex = 23;
            this.plusbtn.Text = "+";
            this.plusbtn.UseVisualStyleBackColor = false;
            this.plusbtn.UseWaitCursor = true;
            this.plusbtn.Click += new System.EventHandler(this.operatorClick);
            // 
            // equaltobtn
            // 
            this.equaltobtn.BackColor = System.Drawing.Color.SteelBlue;
            this.equaltobtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.equaltobtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equaltobtn.ForeColor = System.Drawing.Color.Black;
            this.equaltobtn.Location = new System.Drawing.Point(257, 253);
            this.equaltobtn.Name = "equaltobtn";
            this.equaltobtn.Size = new System.Drawing.Size(55, 96);
            this.equaltobtn.TabIndex = 24;
            this.equaltobtn.Text = "=";
            this.equaltobtn.UseVisualStyleBackColor = false;
            this.equaltobtn.UseWaitCursor = true;
            this.equaltobtn.Click += new System.EventHandler(this.equal);
            // 
            // minusbtn
            // 
            this.minusbtn.BackColor = System.Drawing.Color.SteelBlue;
            this.minusbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.minusbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusbtn.ForeColor = System.Drawing.Color.Black;
            this.minusbtn.Location = new System.Drawing.Point(196, 253);
            this.minusbtn.Name = "minusbtn";
            this.minusbtn.Size = new System.Drawing.Size(55, 45);
            this.minusbtn.TabIndex = 28;
            this.minusbtn.Text = "-";
            this.minusbtn.UseVisualStyleBackColor = false;
            this.minusbtn.UseWaitCursor = true;
            this.minusbtn.Click += new System.EventHandler(this.operatorClick);
            // 
            // threebtn
            // 
            this.threebtn.BackColor = System.Drawing.Color.SteelBlue;
            this.threebtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.threebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.threebtn.ForeColor = System.Drawing.Color.Black;
            this.threebtn.Location = new System.Drawing.Point(135, 253);
            this.threebtn.Name = "threebtn";
            this.threebtn.Size = new System.Drawing.Size(55, 45);
            this.threebtn.TabIndex = 27;
            this.threebtn.Text = "3";
            this.threebtn.UseVisualStyleBackColor = false;
            this.threebtn.UseWaitCursor = true;
            this.threebtn.Click += new System.EventHandler(this.num_click);
            // 
            // twobtn
            // 
            this.twobtn.BackColor = System.Drawing.Color.SteelBlue;
            this.twobtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.twobtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.twobtn.ForeColor = System.Drawing.Color.Black;
            this.twobtn.Location = new System.Drawing.Point(74, 253);
            this.twobtn.Name = "twobtn";
            this.twobtn.Size = new System.Drawing.Size(55, 45);
            this.twobtn.TabIndex = 26;
            this.twobtn.Text = "2";
            this.twobtn.UseVisualStyleBackColor = false;
            this.twobtn.UseWaitCursor = true;
            this.twobtn.Click += new System.EventHandler(this.num_click);
            // 
            // onebtn
            // 
            this.onebtn.BackColor = System.Drawing.Color.SteelBlue;
            this.onebtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.onebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.onebtn.ForeColor = System.Drawing.Color.Black;
            this.onebtn.Location = new System.Drawing.Point(13, 253);
            this.onebtn.Name = "onebtn";
            this.onebtn.Size = new System.Drawing.Size(55, 45);
            this.onebtn.TabIndex = 25;
            this.onebtn.Text = "1";
            this.onebtn.UseVisualStyleBackColor = false;
            this.onebtn.UseWaitCursor = true;
            this.onebtn.Click += new System.EventHandler(this.num_click);
            // 
            // Cbtn
            // 
            this.Cbtn.BackColor = System.Drawing.Color.SteelBlue;
            this.Cbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Cbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbtn.ForeColor = System.Drawing.Color.Black;
            this.Cbtn.Location = new System.Drawing.Point(257, 202);
            this.Cbtn.Name = "Cbtn";
            this.Cbtn.Size = new System.Drawing.Size(55, 45);
            this.Cbtn.TabIndex = 34;
            this.Cbtn.Text = "AC";
            this.Cbtn.UseVisualStyleBackColor = false;
            this.Cbtn.UseWaitCursor = true;
            this.Cbtn.Click += new System.EventHandler(this.AC);
            // 
            // timesbtn
            // 
            this.timesbtn.BackColor = System.Drawing.Color.SteelBlue;
            this.timesbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.timesbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timesbtn.ForeColor = System.Drawing.Color.Black;
            this.timesbtn.Location = new System.Drawing.Point(196, 202);
            this.timesbtn.Name = "timesbtn";
            this.timesbtn.Size = new System.Drawing.Size(55, 45);
            this.timesbtn.TabIndex = 33;
            this.timesbtn.Text = "x";
            this.timesbtn.UseVisualStyleBackColor = false;
            this.timesbtn.UseWaitCursor = true;
            this.timesbtn.Click += new System.EventHandler(this.operatorClick);
            // 
            // sixbtn
            // 
            this.sixbtn.BackColor = System.Drawing.Color.SteelBlue;
            this.sixbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sixbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sixbtn.ForeColor = System.Drawing.Color.Black;
            this.sixbtn.Location = new System.Drawing.Point(135, 202);
            this.sixbtn.Name = "sixbtn";
            this.sixbtn.Size = new System.Drawing.Size(55, 45);
            this.sixbtn.TabIndex = 32;
            this.sixbtn.Text = "6";
            this.sixbtn.UseVisualStyleBackColor = false;
            this.sixbtn.UseWaitCursor = true;
            this.sixbtn.Click += new System.EventHandler(this.num_click);
            // 
            // fivebtn
            // 
            this.fivebtn.BackColor = System.Drawing.Color.SteelBlue;
            this.fivebtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.fivebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fivebtn.ForeColor = System.Drawing.Color.Black;
            this.fivebtn.Location = new System.Drawing.Point(74, 202);
            this.fivebtn.Name = "fivebtn";
            this.fivebtn.Size = new System.Drawing.Size(55, 45);
            this.fivebtn.TabIndex = 31;
            this.fivebtn.Text = "5";
            this.fivebtn.UseVisualStyleBackColor = false;
            this.fivebtn.UseWaitCursor = true;
            this.fivebtn.Click += new System.EventHandler(this.num_click);
            // 
            // fourbtn
            // 
            this.fourbtn.BackColor = System.Drawing.Color.SteelBlue;
            this.fourbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.fourbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fourbtn.ForeColor = System.Drawing.Color.Black;
            this.fourbtn.Location = new System.Drawing.Point(13, 202);
            this.fourbtn.Name = "fourbtn";
            this.fourbtn.Size = new System.Drawing.Size(55, 45);
            this.fourbtn.TabIndex = 30;
            this.fourbtn.Text = "4";
            this.fourbtn.UseVisualStyleBackColor = false;
            this.fourbtn.UseWaitCursor = true;
            this.fourbtn.Click += new System.EventHandler(this.num_click);
            // 
            // CEbtn
            // 
            this.CEbtn.BackColor = System.Drawing.Color.SteelBlue;
            this.CEbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CEbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CEbtn.ForeColor = System.Drawing.Color.Black;
            this.CEbtn.Location = new System.Drawing.Point(257, 151);
            this.CEbtn.Name = "CEbtn";
            this.CEbtn.Size = new System.Drawing.Size(55, 45);
            this.CEbtn.TabIndex = 39;
            this.CEbtn.Text = "CE";
            this.CEbtn.UseVisualStyleBackColor = false;
            this.CEbtn.UseWaitCursor = true;
            this.CEbtn.Click += new System.EventHandler(this.CE);
            // 
            // dividebtn
            // 
            this.dividebtn.BackColor = System.Drawing.Color.SteelBlue;
            this.dividebtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.dividebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dividebtn.ForeColor = System.Drawing.Color.Black;
            this.dividebtn.Location = new System.Drawing.Point(196, 151);
            this.dividebtn.Name = "dividebtn";
            this.dividebtn.Size = new System.Drawing.Size(55, 45);
            this.dividebtn.TabIndex = 38;
            this.dividebtn.Text = "/";
            this.dividebtn.UseVisualStyleBackColor = false;
            this.dividebtn.UseWaitCursor = true;
            this.dividebtn.Click += new System.EventHandler(this.operatorClick);
            // 
            // ninebtn
            // 
            this.ninebtn.BackColor = System.Drawing.Color.SteelBlue;
            this.ninebtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ninebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ninebtn.ForeColor = System.Drawing.Color.Black;
            this.ninebtn.Location = new System.Drawing.Point(135, 151);
            this.ninebtn.Name = "ninebtn";
            this.ninebtn.Size = new System.Drawing.Size(55, 45);
            this.ninebtn.TabIndex = 37;
            this.ninebtn.Text = "9";
            this.ninebtn.UseVisualStyleBackColor = false;
            this.ninebtn.UseWaitCursor = true;
            this.ninebtn.Click += new System.EventHandler(this.num_click);
            // 
            // eightbtn
            // 
            this.eightbtn.BackColor = System.Drawing.Color.SteelBlue;
            this.eightbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.eightbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eightbtn.ForeColor = System.Drawing.Color.Black;
            this.eightbtn.Location = new System.Drawing.Point(74, 151);
            this.eightbtn.Name = "eightbtn";
            this.eightbtn.Size = new System.Drawing.Size(55, 45);
            this.eightbtn.TabIndex = 36;
            this.eightbtn.Text = "8";
            this.eightbtn.UseVisualStyleBackColor = false;
            this.eightbtn.UseWaitCursor = true;
            this.eightbtn.Click += new System.EventHandler(this.num_click);
            // 
            // sevenbtn
            // 
            this.sevenbtn.BackColor = System.Drawing.Color.SteelBlue;
            this.sevenbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sevenbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sevenbtn.ForeColor = System.Drawing.Color.Black;
            this.sevenbtn.Location = new System.Drawing.Point(13, 151);
            this.sevenbtn.Name = "sevenbtn";
            this.sevenbtn.Size = new System.Drawing.Size(55, 45);
            this.sevenbtn.TabIndex = 35;
            this.sevenbtn.Text = "7";
            this.sevenbtn.UseVisualStyleBackColor = false;
            this.sevenbtn.UseWaitCursor = true;
            this.sevenbtn.Click += new System.EventHandler(this.num_click);
            // 
            // delbtn
            // 
            this.delbtn.BackColor = System.Drawing.Color.SteelBlue;
            this.delbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.delbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delbtn.ForeColor = System.Drawing.Color.Black;
            this.delbtn.Location = new System.Drawing.Point(257, 100);
            this.delbtn.Name = "delbtn";
            this.delbtn.Size = new System.Drawing.Size(55, 45);
            this.delbtn.TabIndex = 44;
            this.delbtn.Text = "←";
            this.delbtn.UseVisualStyleBackColor = false;
            this.delbtn.UseWaitCursor = true;
            this.delbtn.Click += new System.EventHandler(this.Delete);
            // 
            // Mbtn
            // 
            this.Mbtn.BackColor = System.Drawing.Color.SteelBlue;
            this.Mbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Mbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mbtn.ForeColor = System.Drawing.Color.Black;
            this.Mbtn.Location = new System.Drawing.Point(196, 100);
            this.Mbtn.Name = "Mbtn";
            this.Mbtn.Size = new System.Drawing.Size(55, 45);
            this.Mbtn.TabIndex = 43;
            this.Mbtn.Text = "M";
            this.Mbtn.UseVisualStyleBackColor = false;
            this.Mbtn.UseWaitCursor = true;
            this.Mbtn.Click += new System.EventHandler(this.M);
            // 
            // Mminusbtn
            // 
            this.Mminusbtn.BackColor = System.Drawing.Color.SteelBlue;
            this.Mminusbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Mminusbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mminusbtn.ForeColor = System.Drawing.Color.Black;
            this.Mminusbtn.Location = new System.Drawing.Point(135, 100);
            this.Mminusbtn.Name = "Mminusbtn";
            this.Mminusbtn.Size = new System.Drawing.Size(55, 45);
            this.Mminusbtn.TabIndex = 42;
            this.Mminusbtn.Text = "M-";
            this.Mminusbtn.UseVisualStyleBackColor = false;
            this.Mminusbtn.UseWaitCursor = true;
            // 
            // Mplusbtn
            // 
            this.Mplusbtn.BackColor = System.Drawing.Color.SteelBlue;
            this.Mplusbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Mplusbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mplusbtn.ForeColor = System.Drawing.Color.Black;
            this.Mplusbtn.Location = new System.Drawing.Point(74, 100);
            this.Mplusbtn.Name = "Mplusbtn";
            this.Mplusbtn.Size = new System.Drawing.Size(55, 45);
            this.Mplusbtn.TabIndex = 41;
            this.Mplusbtn.Text = "M+";
            this.Mplusbtn.UseVisualStyleBackColor = false;
            this.Mplusbtn.UseWaitCursor = true;
            // 
            // Sqrtbtn
            // 
            this.Sqrtbtn.BackColor = System.Drawing.Color.SteelBlue;
            this.Sqrtbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Sqrtbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sqrtbtn.ForeColor = System.Drawing.Color.Black;
            this.Sqrtbtn.Location = new System.Drawing.Point(13, 100);
            this.Sqrtbtn.Name = "Sqrtbtn";
            this.Sqrtbtn.Size = new System.Drawing.Size(55, 45);
            this.Sqrtbtn.TabIndex = 40;
            this.Sqrtbtn.Text = "√";
            this.Sqrtbtn.UseVisualStyleBackColor = false;
            this.Sqrtbtn.UseWaitCursor = true;
            this.Sqrtbtn.Click += new System.EventHandler(this.operatorClick);
            // 
            // textboxdisplay
            // 
            this.textboxdisplay.Font = new System.Drawing.Font("DigifaceWide", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxdisplay.Location = new System.Drawing.Point(13, 44);
            this.textboxdisplay.Name = "textboxdisplay";
            this.textboxdisplay.Size = new System.Drawing.Size(301, 50);
            this.textboxdisplay.TabIndex = 45;
            this.textboxdisplay.Text = "0";
            this.textboxdisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textboxdisplay.UseWaitCursor = true;
            // 
            // labeldatashow
            // 
            this.labeldatashow.AutoSize = true;
            this.labeldatashow.BackColor = System.Drawing.Color.Transparent;
            this.labeldatashow.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldatashow.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.labeldatashow.Location = new System.Drawing.Point(12, 9);
            this.labeldatashow.Name = "labeldatashow";
            this.labeldatashow.Size = new System.Drawing.Size(0, 27);
            this.labeldatashow.TabIndex = 46;
            this.labeldatashow.UseWaitCursor = true;
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(325, 361);
            this.Controls.Add(this.labeldatashow);
            this.Controls.Add(this.textboxdisplay);
            this.Controls.Add(this.delbtn);
            this.Controls.Add(this.Mbtn);
            this.Controls.Add(this.Mminusbtn);
            this.Controls.Add(this.Mplusbtn);
            this.Controls.Add(this.Sqrtbtn);
            this.Controls.Add(this.CEbtn);
            this.Controls.Add(this.dividebtn);
            this.Controls.Add(this.ninebtn);
            this.Controls.Add(this.eightbtn);
            this.Controls.Add(this.sevenbtn);
            this.Controls.Add(this.Cbtn);
            this.Controls.Add(this.timesbtn);
            this.Controls.Add(this.sixbtn);
            this.Controls.Add(this.fivebtn);
            this.Controls.Add(this.fourbtn);
            this.Controls.Add(this.minusbtn);
            this.Controls.Add(this.threebtn);
            this.Controls.Add(this.twobtn);
            this.Controls.Add(this.onebtn);
            this.Controls.Add(this.equaltobtn);
            this.Controls.Add(this.plusbtn);
            this.Controls.Add(this.dotbtn);
            this.Controls.Add(this.zerozerobtn);
            this.Controls.Add(this.zerobtn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "Calculator";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.UseWaitCursor = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button zerobtn;
        private System.Windows.Forms.Button zerozerobtn;
        private System.Windows.Forms.Button dotbtn;
        private System.Windows.Forms.Button plusbtn;
        private System.Windows.Forms.Button equaltobtn;
        private System.Windows.Forms.Button minusbtn;
        private System.Windows.Forms.Button threebtn;
        private System.Windows.Forms.Button twobtn;
        private System.Windows.Forms.Button onebtn;
        private System.Windows.Forms.Button Cbtn;
        private System.Windows.Forms.Button timesbtn;
        private System.Windows.Forms.Button sixbtn;
        private System.Windows.Forms.Button fivebtn;
        private System.Windows.Forms.Button fourbtn;
        private System.Windows.Forms.Button CEbtn;
        private System.Windows.Forms.Button dividebtn;
        private System.Windows.Forms.Button ninebtn;
        private System.Windows.Forms.Button eightbtn;
        private System.Windows.Forms.Button sevenbtn;
        private System.Windows.Forms.Button delbtn;
        private System.Windows.Forms.Button Mbtn;
        private System.Windows.Forms.Button Mminusbtn;
        private System.Windows.Forms.Button Mplusbtn;
        private System.Windows.Forms.Button Sqrtbtn;
        private System.Windows.Forms.TextBox textboxdisplay;
        private System.Windows.Forms.Label labeldatashow;
    }
}

