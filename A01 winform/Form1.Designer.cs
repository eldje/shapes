namespace A01_winform
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddProp2 = new System.Windows.Forms.Button();
            this.btnAddProp1 = new System.Windows.Forms.Button();
            this.btnAddName = new System.Windows.Forms.Button();
            this.txtbProp2 = new System.Windows.Forms.TextBox();
            this.txtbProp1 = new System.Windows.Forms.TextBox();
            this.txtbName = new System.Windows.Forms.TextBox();
            this.lblProp2 = new System.Windows.Forms.Label();
            this.lblProp1 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.cmbSelectShape = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDeleteRedShape = new System.Windows.Forms.Button();
            this.btnDeleteOrangeShape = new System.Windows.Forms.Button();
            this.btnDeleteGreenShape = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblLargestTotalArea = new System.Windows.Forms.Label();
            this.lblLargestShapeArea = new System.Windows.Forms.Label();
            this.lblLargestRedArea = new System.Windows.Forms.Label();
            this.lblLargestOrangeArea = new System.Windows.Forms.Label();
            this.lblLargestGreenArea = new System.Windows.Forms.Label();
            this.lblLargestShape = new System.Windows.Forms.Label();
            this.lblLargestRedShape = new System.Windows.Forms.Label();
            this.lblLargestOrangehape = new System.Windows.Forms.Label();
            this.lblLargestGreenShape = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lstGreen = new System.Windows.Forms.ListBox();
            this.lstOrange = new System.Windows.Forms.ListBox();
            this.lstRed = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddProp2);
            this.groupBox1.Controls.Add(this.btnAddProp1);
            this.groupBox1.Controls.Add(this.btnAddName);
            this.groupBox1.Controls.Add(this.txtbProp2);
            this.groupBox1.Controls.Add(this.txtbProp1);
            this.groupBox1.Controls.Add(this.txtbName);
            this.groupBox1.Controls.Add(this.lblProp2);
            this.groupBox1.Controls.Add(this.lblProp1);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.cmbSelectShape);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1209, 151);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input";
            // 
            // btnAddProp2
            // 
            this.btnAddProp2.Location = new System.Drawing.Point(898, 92);
            this.btnAddProp2.Name = "btnAddProp2";
            this.btnAddProp2.Size = new System.Drawing.Size(119, 23);
            this.btnAddProp2.TabIndex = 10;
            this.btnAddProp2.Text = "Add";
            this.btnAddProp2.UseVisualStyleBackColor = true;
            this.btnAddProp2.Visible = false;
            this.btnAddProp2.Click += new System.EventHandler(this.btnAddProp2_Click);
            // 
            // btnAddProp1
            // 
            this.btnAddProp1.Location = new System.Drawing.Point(898, 65);
            this.btnAddProp1.Name = "btnAddProp1";
            this.btnAddProp1.Size = new System.Drawing.Size(119, 23);
            this.btnAddProp1.TabIndex = 9;
            this.btnAddProp1.Text = "Add";
            this.btnAddProp1.UseVisualStyleBackColor = true;
            this.btnAddProp1.Visible = false;
            this.btnAddProp1.Click += new System.EventHandler(this.btnAddProp1_Click);
            // 
            // btnAddName
            // 
            this.btnAddName.Location = new System.Drawing.Point(898, 37);
            this.btnAddName.Name = "btnAddName";
            this.btnAddName.Size = new System.Drawing.Size(119, 23);
            this.btnAddName.TabIndex = 8;
            this.btnAddName.Text = "Add";
            this.btnAddName.UseVisualStyleBackColor = true;
            this.btnAddName.Visible = false;
            this.btnAddName.Click += new System.EventHandler(this.btnAddName_Click);
            // 
            // txtbProp2
            // 
            this.txtbProp2.Location = new System.Drawing.Point(567, 94);
            this.txtbProp2.Name = "txtbProp2";
            this.txtbProp2.Size = new System.Drawing.Size(305, 20);
            this.txtbProp2.TabIndex = 7;
            this.txtbProp2.Visible = false;
            // 
            // txtbProp1
            // 
            this.txtbProp1.Location = new System.Drawing.Point(567, 67);
            this.txtbProp1.Name = "txtbProp1";
            this.txtbProp1.Size = new System.Drawing.Size(305, 20);
            this.txtbProp1.TabIndex = 6;
            this.txtbProp1.Visible = false;
            // 
            // txtbName
            // 
            this.txtbName.Location = new System.Drawing.Point(567, 39);
            this.txtbName.Name = "txtbName";
            this.txtbName.Size = new System.Drawing.Size(305, 20);
            this.txtbName.TabIndex = 5;
            this.txtbName.Visible = false;
            // 
            // lblProp2
            // 
            this.lblProp2.AutoSize = true;
            this.lblProp2.Location = new System.Drawing.Point(495, 97);
            this.lblProp2.Name = "lblProp2";
            this.lblProp2.Size = new System.Drawing.Size(35, 13);
            this.lblProp2.TabIndex = 4;
            this.lblProp2.Text = "Width";
            this.lblProp2.Visible = false;
            // 
            // lblProp1
            // 
            this.lblProp1.AutoSize = true;
            this.lblProp1.Location = new System.Drawing.Point(495, 70);
            this.lblProp1.Name = "lblProp1";
            this.lblProp1.Size = new System.Drawing.Size(38, 13);
            this.lblProp1.TabIndex = 3;
            this.lblProp1.Text = "Height";
            this.lblProp1.Visible = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(495, 42);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name";
            this.lblName.Visible = false;
            // 
            // cmbSelectShape
            // 
            this.cmbSelectShape.FormattingEnabled = true;
            this.cmbSelectShape.Items.AddRange(new object[] {
            "Circle",
            "Rectangle",
            "Square",
            "Triangle"});
            this.cmbSelectShape.Location = new System.Drawing.Point(40, 42);
            this.cmbSelectShape.Name = "cmbSelectShape";
            this.cmbSelectShape.Size = new System.Drawing.Size(375, 21);
            this.cmbSelectShape.TabIndex = 1;
            this.cmbSelectShape.Text = "Select ....";
            this.cmbSelectShape.SelectedIndexChanged += new System.EventHandler(this.cmbSelectShape_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select a shape";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstRed);
            this.groupBox2.Controls.Add(this.lstOrange);
            this.groupBox2.Controls.Add(this.lstGreen);
            this.groupBox2.Controls.Add(this.btnDeleteRedShape);
            this.groupBox2.Controls.Add(this.btnDeleteOrangeShape);
            this.groupBox2.Controls.Add(this.btnDeleteGreenShape);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(12, 191);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1209, 263);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Listboxes";
            // 
            // btnDeleteRedShape
            // 
            this.btnDeleteRedShape.Location = new System.Drawing.Point(799, 220);
            this.btnDeleteRedShape.Name = "btnDeleteRedShape";
            this.btnDeleteRedShape.Size = new System.Drawing.Size(151, 23);
            this.btnDeleteRedShape.TabIndex = 8;
            this.btnDeleteRedShape.Text = "Delete from list";
            this.btnDeleteRedShape.UseVisualStyleBackColor = true;
            this.btnDeleteRedShape.Click += new System.EventHandler(this.btnDeleteRedShape_Click);
            // 
            // btnDeleteOrangeShape
            // 
            this.btnDeleteOrangeShape.Location = new System.Drawing.Point(421, 220);
            this.btnDeleteOrangeShape.Name = "btnDeleteOrangeShape";
            this.btnDeleteOrangeShape.Size = new System.Drawing.Size(151, 23);
            this.btnDeleteOrangeShape.TabIndex = 7;
            this.btnDeleteOrangeShape.Text = "Delete from list";
            this.btnDeleteOrangeShape.UseVisualStyleBackColor = true;
            this.btnDeleteOrangeShape.Click += new System.EventHandler(this.btnDeleteOrangeShape_Click);
            // 
            // btnDeleteGreenShape
            // 
            this.btnDeleteGreenShape.Location = new System.Drawing.Point(43, 221);
            this.btnDeleteGreenShape.Name = "btnDeleteGreenShape";
            this.btnDeleteGreenShape.Size = new System.Drawing.Size(151, 23);
            this.btnDeleteGreenShape.TabIndex = 6;
            this.btnDeleteGreenShape.Text = "Delete from list";
            this.btnDeleteGreenShape.UseVisualStyleBackColor = true;
            this.btnDeleteGreenShape.Click += new System.EventHandler(this.btnDeleteGreenShape_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(796, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Red shapes";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(418, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Orange shapes";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Green shapes";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblLargestTotalArea);
            this.groupBox3.Controls.Add(this.lblLargestShapeArea);
            this.groupBox3.Controls.Add(this.lblLargestRedArea);
            this.groupBox3.Controls.Add(this.lblLargestOrangeArea);
            this.groupBox3.Controls.Add(this.lblLargestGreenArea);
            this.groupBox3.Controls.Add(this.lblLargestShape);
            this.groupBox3.Controls.Add(this.lblLargestRedShape);
            this.groupBox3.Controls.Add(this.lblLargestOrangehape);
            this.groupBox3.Controls.Add(this.lblLargestGreenShape);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(13, 460);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1208, 124);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Output";
            // 
            // lblLargestTotalArea
            // 
            this.lblLargestTotalArea.AutoSize = true;
            this.lblLargestTotalArea.Location = new System.Drawing.Point(381, 79);
            this.lblLargestTotalArea.Name = "lblLargestTotalArea";
            this.lblLargestTotalArea.Size = new System.Drawing.Size(33, 13);
            this.lblLargestTotalArea.TabIndex = 14;
            this.lblLargestTotalArea.Text = "\'Area\'";
            // 
            // lblLargestShapeArea
            // 
            this.lblLargestShapeArea.AutoSize = true;
            this.lblLargestShapeArea.Location = new System.Drawing.Point(381, 66);
            this.lblLargestShapeArea.Name = "lblLargestShapeArea";
            this.lblLargestShapeArea.Size = new System.Drawing.Size(33, 13);
            this.lblLargestShapeArea.TabIndex = 13;
            this.lblLargestShapeArea.Text = "\'Area\'";
            // 
            // lblLargestRedArea
            // 
            this.lblLargestRedArea.AutoSize = true;
            this.lblLargestRedArea.Location = new System.Drawing.Point(381, 53);
            this.lblLargestRedArea.Name = "lblLargestRedArea";
            this.lblLargestRedArea.Size = new System.Drawing.Size(33, 13);
            this.lblLargestRedArea.TabIndex = 12;
            this.lblLargestRedArea.Text = "\'Area\'";
            // 
            // lblLargestOrangeArea
            // 
            this.lblLargestOrangeArea.AutoSize = true;
            this.lblLargestOrangeArea.Location = new System.Drawing.Point(381, 40);
            this.lblLargestOrangeArea.Name = "lblLargestOrangeArea";
            this.lblLargestOrangeArea.Size = new System.Drawing.Size(33, 13);
            this.lblLargestOrangeArea.TabIndex = 11;
            this.lblLargestOrangeArea.Text = "\'Area\'";
            // 
            // lblLargestGreenArea
            // 
            this.lblLargestGreenArea.AutoSize = true;
            this.lblLargestGreenArea.Location = new System.Drawing.Point(381, 27);
            this.lblLargestGreenArea.Name = "lblLargestGreenArea";
            this.lblLargestGreenArea.Size = new System.Drawing.Size(33, 13);
            this.lblLargestGreenArea.TabIndex = 10;
            this.lblLargestGreenArea.Text = "\'Area\'";
            // 
            // lblLargestShape
            // 
            this.lblLargestShape.AutoSize = true;
            this.lblLargestShape.Location = new System.Drawing.Point(253, 66);
            this.lblLargestShape.Name = "lblLargestShape";
            this.lblLargestShape.Size = new System.Drawing.Size(39, 13);
            this.lblLargestShape.TabIndex = 8;
            this.lblLargestShape.Text = "\'Name\'";
            // 
            // lblLargestRedShape
            // 
            this.lblLargestRedShape.AutoSize = true;
            this.lblLargestRedShape.Location = new System.Drawing.Point(253, 53);
            this.lblLargestRedShape.Name = "lblLargestRedShape";
            this.lblLargestRedShape.Size = new System.Drawing.Size(39, 13);
            this.lblLargestRedShape.TabIndex = 7;
            this.lblLargestRedShape.Text = "\'Name\'";
            // 
            // lblLargestOrangehape
            // 
            this.lblLargestOrangehape.AutoSize = true;
            this.lblLargestOrangehape.Location = new System.Drawing.Point(253, 40);
            this.lblLargestOrangehape.Name = "lblLargestOrangehape";
            this.lblLargestOrangehape.Size = new System.Drawing.Size(39, 13);
            this.lblLargestOrangehape.TabIndex = 6;
            this.lblLargestOrangehape.Text = "\'Name\'";
            // 
            // lblLargestGreenShape
            // 
            this.lblLargestGreenShape.AutoSize = true;
            this.lblLargestGreenShape.Location = new System.Drawing.Point(253, 26);
            this.lblLargestGreenShape.Name = "lblLargestGreenShape";
            this.lblLargestGreenShape.Size = new System.Drawing.Size(39, 13);
            this.lblLargestGreenShape.TabIndex = 5;
            this.lblLargestGreenShape.Text = "\'Name\'";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(48, 79);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "The total area";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(48, 66);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "The largest shape ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(48, 53);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(117, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "The largest \'red\' shape ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(48, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(135, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "The largest \'orange\' shape ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(48, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "The largest \'green\' shape ";
            // 
            // lstGreen
            // 
            this.lstGreen.FormattingEnabled = true;
            this.lstGreen.Location = new System.Drawing.Point(43, 34);
            this.lstGreen.Name = "lstGreen";
            this.lstGreen.Size = new System.Drawing.Size(352, 173);
            this.lstGreen.TabIndex = 9;
            // 
            // lstOrange
            // 
            this.lstOrange.FormattingEnabled = true;
            this.lstOrange.Location = new System.Drawing.Point(421, 34);
            this.lstOrange.Name = "lstOrange";
            this.lstOrange.Size = new System.Drawing.Size(355, 173);
            this.lstOrange.TabIndex = 10;
            // 
            // lstRed
            // 
            this.lstRed.FormattingEnabled = true;
            this.lstRed.Location = new System.Drawing.Point(799, 34);
            this.lstRed.Name = "lstRed";
            this.lstRed.Size = new System.Drawing.Size(317, 173);
            this.lstRed.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 600);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            //((System.ComponentModel.ISupportInitialize)(this.shapesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddProp2;
        private System.Windows.Forms.Button btnAddProp1;
        private System.Windows.Forms.Button btnAddName;
        private System.Windows.Forms.TextBox txtbProp2;
        private System.Windows.Forms.TextBox txtbProp1;
        private System.Windows.Forms.TextBox txtbName;
        private System.Windows.Forms.Label lblProp2;
        private System.Windows.Forms.Label lblProp1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ComboBox cmbSelectShape;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDeleteRedShape;
        private System.Windows.Forms.Button btnDeleteOrangeShape;
        private System.Windows.Forms.Button btnDeleteGreenShape;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblLargestTotalArea;
        private System.Windows.Forms.Label lblLargestShapeArea;
        private System.Windows.Forms.Label lblLargestRedArea;
        private System.Windows.Forms.Label lblLargestOrangeArea;
        private System.Windows.Forms.Label lblLargestGreenArea;
        private System.Windows.Forms.Label lblLargestShape;
        private System.Windows.Forms.Label lblLargestRedShape;
        private System.Windows.Forms.Label lblLargestOrangehape;
        private System.Windows.Forms.Label lblLargestGreenShape;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox lstRed;
        private System.Windows.Forms.ListBox lstOrange;
        private System.Windows.Forms.ListBox lstGreen;
    }
}

