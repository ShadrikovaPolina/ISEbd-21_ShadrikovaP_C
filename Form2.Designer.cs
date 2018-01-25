namespace laba2
{
    partial class Form2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelDop = new System.Windows.Forms.Label();
            this.labelBase = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelAll = new System.Windows.Forms.Label();
            this.labelCroc = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AllowDrop = true;
            this.panel1.Controls.Add(this.labelDop);
            this.panel1.Controls.Add(this.labelBase);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(14, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(233, 360);
            this.panel1.TabIndex = 0;
            this.panel1.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel1_DragDrop);
            this.panel1.DragEnter += new System.Windows.Forms.DragEventHandler(this.panel1_DragEnter);
            // 
            // labelDop
            // 
            this.labelDop.AllowDrop = true;
            this.labelDop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDop.Location = new System.Drawing.Point(25, 293);
            this.labelDop.Name = "labelDop";
            this.labelDop.Size = new System.Drawing.Size(121, 43);
            this.labelDop.TabIndex = 2;
            this.labelDop.Text = "Дополнительный цвет";
            this.labelDop.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelDop_DragDrop);
            this.labelDop.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelDop_DragEnter);
            // 
            // labelBase
            // 
            this.labelBase.AllowDrop = true;
            this.labelBase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBase.Location = new System.Drawing.Point(25, 234);
            this.labelBase.Name = "labelBase";
            this.labelBase.Size = new System.Drawing.Size(121, 43);
            this.labelBase.TabIndex = 1;
            this.labelBase.Text = "Основной цвет";
            this.labelBase.Click += new System.EventHandler(this.labelBase_Click);
            this.labelBase.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelBase_DragDrop);
            this.labelBase.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelBase_DragEnter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(21, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(194, 175);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelAll);
            this.groupBox1.Controls.Add(this.labelCroc);
            this.groupBox1.Location = new System.Drawing.Point(270, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(192, 174);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Тип";
            // 
            // labelAll
            // 
            this.labelAll.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelAll.Location = new System.Drawing.Point(35, 83);
            this.labelAll.Name = "labelAll";
            this.labelAll.Size = new System.Drawing.Size(83, 44);
            this.labelAll.TabIndex = 1;
            this.labelAll.Text = "Alligator";
            this.labelAll.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelAll_MouseDown);
            // 
            // labelCroc
            // 
            this.labelCroc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelCroc.Location = new System.Drawing.Point(35, 32);
            this.labelCroc.Name = "labelCroc";
            this.labelCroc.Size = new System.Drawing.Size(83, 44);
            this.labelCroc.TabIndex = 0;
            this.labelCroc.Text = "Crocodile";
            this.labelCroc.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelCroc_MouseDown);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel9);
            this.groupBox2.Controls.Add(this.panel8);
            this.groupBox2.Controls.Add(this.panel7);
            this.groupBox2.Controls.Add(this.panel6);
            this.groupBox2.Controls.Add(this.panel5);
            this.groupBox2.Controls.Add(this.panel4);
            this.groupBox2.Controls.Add(this.panel3);
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Location = new System.Drawing.Point(505, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(204, 339);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Цвета";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel9.Location = new System.Drawing.Point(114, 247);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(48, 48);
            this.panel9.TabIndex = 7;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel8.Location = new System.Drawing.Point(22, 247);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(48, 48);
            this.panel8.TabIndex = 6;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Yellow;
            this.panel7.Location = new System.Drawing.Point(114, 180);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(48, 48);
            this.panel7.TabIndex = 5;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Red;
            this.panel6.Location = new System.Drawing.Point(22, 180);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(48, 48);
            this.panel6.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel5.Location = new System.Drawing.Point(114, 115);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(48, 48);
            this.panel5.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel4.Location = new System.Drawing.Point(22, 115);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(48, 48);
            this.panel4.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(114, 47);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(48, 48);
            this.panel3.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.AllowDrop = true;
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(22, 47);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(48, 48);
            this.panel2.TabIndex = 0;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(305, 220);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 3;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(307, 265);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 411);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelDop;
        private System.Windows.Forms.Label labelBase;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelAll;
        private System.Windows.Forms.Label labelCroc;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonCancel;
    }
}