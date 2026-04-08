namespace kalkulator_bmi
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
            progressbar = new ProgressBar();
            wzrostlbl = new Label();
            wagalbl = new Label();
            obliczanie = new Label();
            wzrosttxt = new TextBox();
            wagatxt = new TextBox();
            obliczbtn = new Button();
            progbmi = new Label();
            SuspendLayout();
            // 
            // progressbar
            // 
            progressbar.BackColor = SystemColors.MenuText;
            progressbar.Location = new Point(266, 288);
            progressbar.Name = "progressbar";
            progressbar.Size = new Size(224, 23);
            progressbar.TabIndex = 0;
            // 
            // wzrostlbl
            // 
            wzrostlbl.AutoSize = true;
            wzrostlbl.Location = new Point(295, 159);
            wzrostlbl.Name = "wzrostlbl";
            wzrostlbl.Size = new Size(43, 15);
            wzrostlbl.TabIndex = 1;
            wzrostlbl.Text = "Wzrost";
            // 
            // wagalbl
            // 
            wagalbl.AutoSize = true;
            wagalbl.Location = new Point(421, 159);
            wagalbl.Name = "wagalbl";
            wagalbl.Size = new Size(37, 15);
            wagalbl.TabIndex = 2;
            wagalbl.Text = "Waga";
            // 
            // obliczanie
            // 
            obliczanie.AutoSize = true;
            obliczanie.Location = new Point(337, 260);
            obliczanie.Name = "obliczanie";
            obliczanie.Size = new Size(71, 15);
            obliczanie.TabIndex = 3;
            obliczanie.Text = "Obliczanie...";
            // 
            // wzrosttxt
            // 
            wzrosttxt.Location = new Point(266, 187);
            wzrosttxt.Name = "wzrosttxt";
            wzrosttxt.Size = new Size(100, 23);
            wzrosttxt.TabIndex = 4;
            // 
            // wagatxt
            // 
            wagatxt.Location = new Point(390, 187);
            wagatxt.Name = "wagatxt";
            wagatxt.Size = new Size(100, 23);
            wagatxt.TabIndex = 5;
            // 
            // obliczbtn
            // 
            obliczbtn.Location = new Point(266, 225);
            obliczbtn.Name = "obliczbtn";
            obliczbtn.Size = new Size(224, 23);
            obliczbtn.TabIndex = 6;
            obliczbtn.Text = "Oblicz";
            obliczbtn.UseVisualStyleBackColor = true;
            obliczbtn.Click += obliczbtn_Click;
            // 
            // progbmi
            // 
            progbmi.AutoSize = true;
            progbmi.Location = new Point(352, 329);
            progbmi.Name = "progbmi";
            progbmi.Size = new Size(56, 15);
            progbmi.TabIndex = 7;
            progbmi.Text = "Próg BMI";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(progbmi);
            Controls.Add(obliczbtn);
            Controls.Add(wagatxt);
            Controls.Add(wzrosttxt);
            Controls.Add(obliczanie);
            Controls.Add(wagalbl);
            Controls.Add(wzrostlbl);
            Controls.Add(progressbar);
            Name = "Form1";
            Text = "Kalkulator BMI";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar progressbar;
        private Label wzrostlbl;
        private Label wagalbl;
        private Label obliczanie;
        private TextBox wzrosttxt;
        private TextBox wagatxt;
        private Button obliczbtn;
        private Label progbmi;
    }
}
