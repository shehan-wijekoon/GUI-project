namespace GUIproject
{
    partial class calculate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(calculate));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            button1 = new Button();
            label8 = new Label();
            label9 = new Label();
            Txtname = new TextBox();
            Txtid = new TextBox();
            Txthours = new TextBox();
            Txtbonus = new TextBox();
            TxtOt = new TextBox();
            Txtfinal = new TextBox();
            label10 = new Label();
            Cmbdepartment = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Microsoft Sans Serif", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(326, 15);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(218, 29);
            label1.TabIndex = 0;
            label1.Text = "Salary calculation";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(14, 77);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(71, 25);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(466, 77);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(38, 25);
            label3.TabIndex = 2;
            label3.Text = "ID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(14, 138);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(134, 25);
            label4.TabIndex = 3;
            label4.Text = "Department";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.FlatStyle = FlatStyle.Flat;
            label5.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(466, 138);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(155, 25);
            label5.TabIndex = 4;
            label5.Text = "Hours worked";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.FlatStyle = FlatStyle.Flat;
            label6.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(14, 207);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(113, 25);
            label6.TabIndex = 5;
            label6.Text = "OT Hours";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.FlatStyle = FlatStyle.Flat;
            label7.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(466, 207);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(95, 25);
            label7.TabIndex = 6;
            label7.Text = "Bonuses";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GradientActiveCaption;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.ImageAlign = ContentAlignment.TopCenter;
            button1.Location = new Point(84, 378);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(200, 72);
            button1.TabIndex = 7;
            button1.Text = "Calculate";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.FlatStyle = FlatStyle.Flat;
            label8.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(97, 336);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(175, 25);
            label8.TabIndex = 8;
            label8.Text = "Calculate Salary";
            label8.Click += label8_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.FlatStyle = FlatStyle.Flat;
            label9.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(496, 357);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(131, 25);
            label9.TabIndex = 9;
            label9.Text = "Final Salary";
            // 
            // Txtname
            // 
            Txtname.Location = new Point(160, 67);
            Txtname.Margin = new Padding(4, 3, 4, 3);
            Txtname.Name = "Txtname";
            Txtname.Size = new Size(188, 31);
            Txtname.TabIndex = 10;
            Txtname.TextChanged += textBox1_TextChanged;
            // 
            // Txtid
            // 
            Txtid.Location = new Point(639, 67);
            Txtid.Margin = new Padding(4, 3, 4, 3);
            Txtid.Name = "Txtid";
            Txtid.Size = new Size(155, 31);
            Txtid.TabIndex = 11;
            Txtid.TextChanged += Txtid_TextChanged;
            // 
            // Txthours
            // 
            Txthours.Location = new Point(639, 138);
            Txthours.Margin = new Padding(4, 3, 4, 3);
            Txthours.Name = "Txthours";
            Txthours.Size = new Size(155, 31);
            Txthours.TabIndex = 13;
            // 
            // Txtbonus
            // 
            Txtbonus.Location = new Point(639, 197);
            Txtbonus.Margin = new Padding(4, 3, 4, 3);
            Txtbonus.Name = "Txtbonus";
            Txtbonus.Size = new Size(155, 31);
            Txtbonus.TabIndex = 14;
            // 
            // TxtOt
            // 
            TxtOt.Location = new Point(160, 205);
            TxtOt.Margin = new Padding(4, 3, 4, 3);
            TxtOt.Name = "TxtOt";
            TxtOt.Size = new Size(188, 31);
            TxtOt.TabIndex = 15;
            // 
            // Txtfinal
            // 
            Txtfinal.Location = new Point(374, 397);
            Txtfinal.Margin = new Padding(4, 3, 4, 3);
            Txtfinal.Name = "Txtfinal";
            Txtfinal.Size = new Size(381, 31);
            Txtfinal.TabIndex = 16;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.FlatStyle = FlatStyle.Flat;
            label10.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(326, 402);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(38, 25);
            label10.TabIndex = 17;
            label10.Text = "Rs";
            // 
            // Cmbdepartment
            // 
            Cmbdepartment.FormattingEnabled = true;
            Cmbdepartment.Items.AddRange(new object[] { "Software Development", "Management", "IT support and Consulton", "QA Team", "UI/UX" });
            Cmbdepartment.Location = new Point(160, 137);
            Cmbdepartment.Margin = new Padding(4, 3, 4, 3);
            Cmbdepartment.Name = "Cmbdepartment";
            Cmbdepartment.Size = new Size(188, 33);
            Cmbdepartment.TabIndex = 18;
            Cmbdepartment.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // calculate
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(907, 553);
            Controls.Add(Cmbdepartment);
            Controls.Add(label10);
            Controls.Add(Txtfinal);
            Controls.Add(TxtOt);
            Controls.Add(Txtbonus);
            Controls.Add(Txthours);
            Controls.Add(Txtid);
            Controls.Add(Txtname);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "calculate";
            Text = "calculate";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button button1;
        private Label label8;
        private Label label9;
        private TextBox Txtname;
        private TextBox Txtid;
        private TextBox Txthours;
        private TextBox Txtbonus;
        private TextBox TxtOt;
        private TextBox Txtfinal;
        private Label label10;
        private ComboBox Cmbdepartment;
    }
}