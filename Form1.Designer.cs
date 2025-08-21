namespace dB_konversor_v1._0
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
            btnConverter = new Button();
            lbResultado = new Label();
            txtValorAConverter = new TextBox();
            SuspendLayout();
            // 
            // btnConverter
            // 
            btnConverter.Location = new Point(12, 129);
            btnConverter.Name = "btnConverter";
            btnConverter.Size = new Size(95, 23);
            btnConverter.TabIndex = 0;
            btnConverter.Text = "CONVERTER";
            btnConverter.UseVisualStyleBackColor = true;
            btnConverter.Click += button1_Click;
            // 
            // lbResultado
            // 
            lbResultado.AutoSize = true;
            lbResultado.Location = new Point(126, 96);
            lbResultado.Name = "lbResultado";
            lbResultado.Size = new Size(59, 15);
            lbResultado.TabIndex = 1;
            lbResultado.Text = "Resultado";
            // 
            // txtValorAConverter
            // 
            txtValorAConverter.Location = new Point(12, 45);
            txtValorAConverter.Name = "txtValorAConverter";
            txtValorAConverter.Size = new Size(288, 23);
            txtValorAConverter.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(319, 170);
            Controls.Add(txtValorAConverter);
            Controls.Add(lbResultado);
            Controls.Add(btnConverter);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConverter;
        private Label lbResultado;
        private TextBox txtValorAConverter;
    }
}
