﻿namespace LAB2___UnicornCommandBridge
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSkapaStudent = new System.Windows.Forms.Button();
            this.btnSkapaKurs = new System.Windows.Forms.Button();
            this.btnSkapaUppgift = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSattaBetyg = new System.Windows.Forms.Button();
            this.btnRedigeraBetyg = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnRedigeraUppgift = new System.Windows.Forms.Button();
            this.btnRedigeraKurs = new System.Windows.Forms.Button();
            this.btnRedigeraStudent = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Välkommen till din Unicorn command bridge.";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSkapaUppgift);
            this.groupBox1.Controls.Add(this.btnSkapaKurs);
            this.groupBox1.Controls.Add(this.btnSkapaStudent);
            this.groupBox1.Location = new System.Drawing.Point(15, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 112);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lägg till:";
            // 
            // btnSkapaStudent
            // 
            this.btnSkapaStudent.Location = new System.Drawing.Point(7, 20);
            this.btnSkapaStudent.Name = "btnSkapaStudent";
            this.btnSkapaStudent.Size = new System.Drawing.Size(187, 23);
            this.btnSkapaStudent.TabIndex = 0;
            this.btnSkapaStudent.Text = "Student/Lärare";
            this.btnSkapaStudent.UseVisualStyleBackColor = true;
            this.btnSkapaStudent.Click += new System.EventHandler(this.btnSkapaStudent_Click);
            // 
            // btnSkapaKurs
            // 
            this.btnSkapaKurs.Location = new System.Drawing.Point(7, 49);
            this.btnSkapaKurs.Name = "btnSkapaKurs";
            this.btnSkapaKurs.Size = new System.Drawing.Size(187, 23);
            this.btnSkapaKurs.TabIndex = 2;
            this.btnSkapaKurs.Text = "Kurs";
            this.btnSkapaKurs.UseVisualStyleBackColor = true;
            this.btnSkapaKurs.Click += new System.EventHandler(this.btnSkapaKurs_Click);
            // 
            // btnSkapaUppgift
            // 
            this.btnSkapaUppgift.Location = new System.Drawing.Point(6, 78);
            this.btnSkapaUppgift.Name = "btnSkapaUppgift";
            this.btnSkapaUppgift.Size = new System.Drawing.Size(187, 23);
            this.btnSkapaUppgift.TabIndex = 3;
            this.btnSkapaUppgift.Text = "Uppgift";
            this.btnSkapaUppgift.UseVisualStyleBackColor = true;
            this.btnSkapaUppgift.Click += new System.EventHandler(this.btnSkapaUppgift_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRedigeraBetyg);
            this.groupBox2.Controls.Add(this.btnSattaBetyg);
            this.groupBox2.Location = new System.Drawing.Point(15, 269);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 83);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Betyg";
            // 
            // btnSattaBetyg
            // 
            this.btnSattaBetyg.Location = new System.Drawing.Point(7, 20);
            this.btnSattaBetyg.Name = "btnSattaBetyg";
            this.btnSattaBetyg.Size = new System.Drawing.Size(186, 23);
            this.btnSattaBetyg.TabIndex = 0;
            this.btnSattaBetyg.Text = "Sätta betyg";
            this.btnSattaBetyg.UseVisualStyleBackColor = true;
            this.btnSattaBetyg.Click += new System.EventHandler(this.btnSattaBetyg_Click);
            // 
            // btnRedigeraBetyg
            // 
            this.btnRedigeraBetyg.Location = new System.Drawing.Point(6, 49);
            this.btnRedigeraBetyg.Name = "btnRedigeraBetyg";
            this.btnRedigeraBetyg.Size = new System.Drawing.Size(186, 23);
            this.btnRedigeraBetyg.TabIndex = 1;
            this.btnRedigeraBetyg.Text = "Redigera betyg";
            this.btnRedigeraBetyg.UseVisualStyleBackColor = true;
            this.btnRedigeraBetyg.Click += new System.EventHandler(this.btnRedigeraBetyg_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnRedigeraUppgift);
            this.groupBox3.Controls.Add(this.btnRedigeraKurs);
            this.groupBox3.Controls.Add(this.btnRedigeraStudent);
            this.groupBox3.Location = new System.Drawing.Point(15, 151);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 112);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Redigera:";
            // 
            // btnRedigeraUppgift
            // 
            this.btnRedigeraUppgift.Location = new System.Drawing.Point(6, 78);
            this.btnRedigeraUppgift.Name = "btnRedigeraUppgift";
            this.btnRedigeraUppgift.Size = new System.Drawing.Size(187, 23);
            this.btnRedigeraUppgift.TabIndex = 3;
            this.btnRedigeraUppgift.Text = "Uppgift";
            this.btnRedigeraUppgift.UseVisualStyleBackColor = true;
            this.btnRedigeraUppgift.Click += new System.EventHandler(this.btnRedigeraUppgift_Click);
            // 
            // btnRedigeraKurs
            // 
            this.btnRedigeraKurs.Location = new System.Drawing.Point(7, 49);
            this.btnRedigeraKurs.Name = "btnRedigeraKurs";
            this.btnRedigeraKurs.Size = new System.Drawing.Size(187, 23);
            this.btnRedigeraKurs.TabIndex = 2;
            this.btnRedigeraKurs.Text = "Kurs";
            this.btnRedigeraKurs.UseVisualStyleBackColor = true;
            this.btnRedigeraKurs.Click += new System.EventHandler(this.btnRedigeraKurs_Click);
            // 
            // btnRedigeraStudent
            // 
            this.btnRedigeraStudent.Location = new System.Drawing.Point(7, 20);
            this.btnRedigeraStudent.Name = "btnRedigeraStudent";
            this.btnRedigeraStudent.Size = new System.Drawing.Size(187, 23);
            this.btnRedigeraStudent.TabIndex = 0;
            this.btnRedigeraStudent.Text = "Student/Lärare";
            this.btnRedigeraStudent.UseVisualStyleBackColor = true;
            this.btnRedigeraStudent.Click += new System.EventHandler(this.btnRedigeraStudent_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(231, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 369);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Unicorn command bridge";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSkapaUppgift;
        private System.Windows.Forms.Button btnSkapaKurs;
        private System.Windows.Forms.Button btnSkapaStudent;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnRedigeraBetyg;
        private System.Windows.Forms.Button btnSattaBetyg;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnRedigeraUppgift;
        private System.Windows.Forms.Button btnRedigeraKurs;
        private System.Windows.Forms.Button btnRedigeraStudent;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

