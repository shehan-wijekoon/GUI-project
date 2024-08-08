namespace GUIproject
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            Btncalculate = new Button();
            label3 = new Label();
            Btnemp = new Button();
            button1 = new Button();
            label4 = new Label();
            Panelview = new Panel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(163, 7);
            label1.Name = "label1";
            label1.Size = new Size(338, 30);
            label1.TabIndex = 0;
            label1.Text = "Employee Management System";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 70);
            label2.Name = "label2";
            label2.Size = new Size(92, 15);
            label2.TabIndex = 0;
            label2.Text = "Employee salary";
            // 
            // Btncalculate
            // 
            Btncalculate.Location = new Point(10, 98);
            Btncalculate.Margin = new Padding(3, 2, 3, 2);
            Btncalculate.Name = "Btncalculate";
            Btncalculate.Size = new Size(147, 42);
            Btncalculate.TabIndex = 0;
            Btncalculate.Text = "CALCULATE";
            Btncalculate.UseVisualStyleBackColor = true;
            Btncalculate.Click += Btncalculate_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 174);
            label3.Name = "label3";
            label3.Size = new Size(86, 15);
            label3.TabIndex = 0;
            label3.Text = "New Employee";
            // 
            // Btnemp
            // 
            Btnemp.Location = new Point(10, 200);
            Btnemp.Margin = new Padding(3, 2, 3, 2);
            Btnemp.Name = "Btnemp";
            Btnemp.Size = new Size(147, 42);
            Btnemp.TabIndex = 2;
            Btnemp.Text = "ADD";
            Btnemp.UseVisualStyleBackColor = true;
            Btnemp.Click += Btnemp_Click;
            // 
            // button1
            // 
            button1.Location = new Point(10, 302);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(147, 42);
            button1.TabIndex = 4;
            button1.Text = "VIEW";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 276);
            label4.Name = "label4";
            label4.Size = new Size(96, 15);
            label4.TabIndex = 3;
            label4.Text = "Employee details";
            // 
            // Panelview
            // 
            Panelview.BackColor = SystemColors.ActiveBorder;
            Panelview.Location = new Point(163, 59);
            Panelview.Margin = new Padding(3, 2, 3, 2);
            Panelview.Name = "Panelview";
            Panelview.Size = new Size(598, 346);
            Panelview.TabIndex = 1;
            Panelview.Paint += Panelview_Paint;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(772, 415);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(Btnemp);
            Controls.Add(label3);
            Controls.Add(Btncalculate);
            Controls.Add(label2);
            Controls.Add(Panelview);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Home";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button Btncalculate;
        private Label label3;
        private Button Btnemp;
        private Button button1;
        private Label label4;
        private Panel Panelview;
    }
}
