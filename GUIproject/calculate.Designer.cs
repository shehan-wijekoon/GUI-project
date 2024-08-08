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
            label1.Location = new Point(234, 9);
            label1.Name = "label1";
            label1.Size = new Size(125, 20);
            label1.TabIndex = 0;
            label1.Text = "Salary calculation";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 61);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(373, 61);
            label3.Name = "label3";
            label3.Size = new Size(24, 20);
            label3.TabIndex = 2;
            label3.Text = "ID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 111);
            label4.Name = "label4";
            label4.Size = new Size(89, 20);
            label4.TabIndex = 3;
            label4.Text = "Department";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(373, 111);
            label5.Name = "label5";
            label5.Size = new Size(101, 20);
            label5.TabIndex = 4;
            label5.Text = "Hours worked";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 166);
            label6.Name = "label6";
            label6.Size = new Size(70, 20);
            label6.TabIndex = 5;
            label6.Text = "OT Hours";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(373, 166);
            label7.Name = "label7";
            label7.Size = new Size(63, 20);
            label7.TabIndex = 6;
            label7.Text = "Bonuses";
            // 
            // button1
            // 
            button1.Location = new Point(12, 311);
            button1.Name = "button1";
            button1.Size = new Size(152, 40);
            button1.TabIndex = 7;
            button1.Text = "Calculate";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(24, 272);
            label8.Name = "label8";
            label8.Size = new Size(114, 20);
            label8.TabIndex = 8;
            label8.Text = "Calculate Salary";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(397, 286);
            label9.Name = "label9";
            label9.Size = new Size(84, 20);
            label9.TabIndex = 9;
            label9.Text = "Final Salary";
            // 
            // Txtname
            // 
            Txtname.Location = new Point(67, 58);
            Txtname.Name = "Txtname";
            Txtname.Size = new Size(125, 27);
            Txtname.TabIndex = 10;
            Txtname.TextChanged += textBox1_TextChanged;
            // 
            // Txtid
            // 
            Txtid.Location = new Point(397, 58);
            Txtid.Name = "Txtid";
            Txtid.Size = new Size(125, 27);
            Txtid.TabIndex = 11;
            // 
            // Txthours
            // 
            Txthours.Location = new Point(480, 108);
            Txthours.Name = "Txthours";
            Txthours.Size = new Size(125, 27);
            Txthours.TabIndex = 13;
            // 
            // Txtbonus
            // 
            Txtbonus.Location = new Point(442, 163);
            Txtbonus.Name = "Txtbonus";
            Txtbonus.Size = new Size(125, 27);
            Txtbonus.TabIndex = 14;
            // 
            // TxtOt
            // 
            TxtOt.Location = new Point(88, 166);
            TxtOt.Name = "TxtOt";
            TxtOt.Size = new Size(125, 27);
            TxtOt.TabIndex = 15;
            // 
            // Txtfinal
            // 
            Txtfinal.Location = new Point(299, 318);
            Txtfinal.Name = "Txtfinal";
            Txtfinal.Size = new Size(306, 27);
            Txtfinal.TabIndex = 16;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(260, 321);
            label10.Name = "label10";
            label10.Size = new Size(24, 20);
            label10.TabIndex = 17;
            label10.Text = "Rs";
            // 
            // Cmbdepartment
            // 
            Cmbdepartment.FormattingEnabled = true;
            Cmbdepartment.Items.AddRange(new object[] { "Software Development", "Management", "IT support and Consulton", "QA Team", "UI/UX" });
            Cmbdepartment.Location = new Point(107, 108);
            Cmbdepartment.Name = "Cmbdepartment";
            Cmbdepartment.Size = new Size(151, 28);
            Cmbdepartment.TabIndex = 18;
            Cmbdepartment.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // calculate
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(692, 453);
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