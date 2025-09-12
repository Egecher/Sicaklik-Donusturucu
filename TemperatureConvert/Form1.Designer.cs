namespace TemperatureConvert
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
            btnConvert = new Button();
            rbtnFtoC = new RadioButton();
            rbtnCtoF = new RadioButton();
            label1 = new Label();
            lblResult = new Label();
            label3 = new Label();
            txtTemperature = new TextBox();
            SuspendLayout();
            // 
            // btnConvert
            // 
            btnConvert.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnConvert.Location = new Point(467, 230);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(114, 40);
            btnConvert.TabIndex = 0;
            btnConvert.Text = "Dönüştür";
            btnConvert.UseVisualStyleBackColor = true;
            btnConvert.Click += btnConvert_Click;
            // 
            // rbtnFtoC
            // 
            rbtnFtoC.AutoSize = true;
            rbtnFtoC.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            rbtnFtoC.Location = new Point(181, 216);
            rbtnFtoC.Name = "rbtnFtoC";
            rbtnFtoC.Size = new Size(210, 27);
            rbtnFtoC.TabIndex = 1;
            rbtnFtoC.TabStop = true;
            rbtnFtoC.Text = "Fahrenheit'ten Celsius'a";
            rbtnFtoC.UseVisualStyleBackColor = true;
            // 
            // rbtnCtoF
            // 
            rbtnCtoF.AutoSize = true;
            rbtnCtoF.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            rbtnCtoF.Location = new Point(181, 246);
            rbtnCtoF.Name = "rbtnCtoF";
            rbtnCtoF.Size = new Size(210, 27);
            rbtnCtoF.TabIndex = 2;
            rbtnCtoF.TabStop = true;
            rbtnCtoF.Text = "Celsius'tan Fahrenheit'e";
            rbtnCtoF.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(181, 70);
            label1.Name = "label1";
            label1.Size = new Size(109, 23);
            label1.TabIndex = 3;
            label1.Text = "Sıcaklık Girin:";
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblResult.Location = new Point(467, 70);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(61, 23);
            lblResult.TabIndex = 4;
            lblResult.Text = "Sonuç:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Variable Text Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(236, 9);
            label3.Name = "label3";
            label3.Size = new Size(281, 37);
            label3.TabIndex = 5;
            label3.Text = "Sıcaklık Dönüştürücü";
            // 
            // txtTemperature
            // 
            txtTemperature.Location = new Point(296, 66);
            txtTemperature.Name = "txtTemperature";
            txtTemperature.Size = new Size(125, 27);
            txtTemperature.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtTemperature);
            Controls.Add(label3);
            Controls.Add(lblResult);
            Controls.Add(label1);
            Controls.Add(rbtnCtoF);
            Controls.Add(rbtnFtoC);
            Controls.Add(btnConvert);
            Name = "Form1";
            Text = "Sıcaklık Dönüştürücü";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConvert;
        private RadioButton rbtnFtoC;
        private RadioButton rbtnCtoF;
        private Label label1;
        private Label lblResult;
        private Label label3;
        private TextBox txtTemperature;
    }
}
