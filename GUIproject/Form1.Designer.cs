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
            Panelview = new Panel();
            label2 = new Label();
            Btncalculate = new Button();
            label3 = new Label();
            Btnemp = new Button();
            button1 = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(186, 9);
            label1.Name = "label1";
            label1.Size = new Size(430, 38);
            label1.TabIndex = 0;
            label1.Text = "Employee Management System";
            // 
            // Panelview
            // 
            Panelview.BackColor = SystemColors.ActiveBorder;
            Panelview.Location = new Point(186, 79);
            Panelview.Name = "Panelview";
            Panelview.Size = new Size(684, 462);
            Panelview.TabIndex = 1;
            Panelview.Paint += Panelview_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 93);
            label2.Name = "label2";
            label2.Size = new Size(117, 20);
            label2.TabIndex = 0;
            label2.Text = "Employee salary";
            // 
            // Btncalculate
            // 
            Btncalculate.Location = new Point(12, 131);
            Btncalculate.Name = "Btncalculate";
            Btncalculate.Size = new Size(168, 56);
            Btncalculate.TabIndex = 0;
            Btncalculate.Text = "CALCULATE";
            Btncalculate.UseVisualStyleBackColor = true;
            Btncalculate.Click += Btncalculate_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 232);
            label3.Name = "label3";
            label3.Size = new Size(109, 20);
            label3.TabIndex = 0;
            label3.Text = "New Employee";
            // 
            // Btnemp
            // 
            Btnemp.Location = new Point(12, 266);
            Btnemp.Name = "Btnemp";
            Btnemp.Size = new Size(168, 56);
            Btnemp.TabIndex = 2;
            Btnemp.Text = "ADD";
            Btnemp.UseVisualStyleBackColor = true;
            Btnemp.Click += Btnemp_Click;
            // 
            // button1
            // 
            button1.Location = new Point(12, 402);
            button1.Name = "button1";
            button1.Size = new Size(168, 56);
            button1.TabIndex = 4;
            button1.Text = "VIEW";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 368);
            label4.Name = "label4";
            label4.Size = new Size(123, 20);
            label4.TabIndex = 3;
            label4.Text = "Employee details";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 553);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(Btnemp);
            Controls.Add(label3);
            Controls.Add(Btncalculate);
            Controls.Add(label2);
            Controls.Add(Panelview);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Home";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel Panelview;
        private Label label2;
        private Button Btncalculate;
        private Label label3;
        private Button Btnemp;
        private Button button1;
        private Label label4;
    }
}
