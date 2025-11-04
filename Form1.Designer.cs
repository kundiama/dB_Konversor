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
            cmbUnidadeEntrada = new ComboBox();
            cmbUnidadeSaida = new ComboBox();
            SuspendLayout();
            // 
            // btnConverter
            // 
            btnConverter.BackColor = SystemColors.Highlight;
            btnConverter.ForeColor = SystemColors.HighlightText;
            btnConverter.Location = new Point(12, 167);
            btnConverter.Name = "btnConverter";
            btnConverter.Size = new Size(107, 29);
            btnConverter.TabIndex = 0;
            btnConverter.Text = "CONVERTER";
            btnConverter.UseVisualStyleBackColor = false;
            btnConverter.Click += button1_Click;
            // 
            // lbResultado
            // 
            lbResultado.AutoSize = true;
            lbResultado.ForeColor = Color.LawnGreen;
            lbResultado.Location = new Point(125, 135);
            lbResultado.Name = "lbResultado";
            lbResultado.Size = new Size(59, 15);
            lbResultado.TabIndex = 1;
            lbResultado.Text = "Resultado";
            // 
            // txtValorAConverter
            // 
            txtValorAConverter.BackColor = Color.Gainsboro;
            txtValorAConverter.Location = new Point(12, 45);
            txtValorAConverter.Name = "txtValorAConverter";
            txtValorAConverter.Size = new Size(295, 23);
            txtValorAConverter.TabIndex = 2;
            // 
            // cmbUnidadeEntrada
            // 
            cmbUnidadeEntrada.BackColor = Color.FromArgb(192, 255, 192);
            cmbUnidadeEntrada.FormattingEnabled = true;
            cmbUnidadeEntrada.Items.AddRange(new object[] { "watts", "miliwatts", "dB", "dBm" });
            cmbUnidadeEntrada.Location = new Point(12, 87);
            cmbUnidadeEntrada.Name = "cmbUnidadeEntrada";
            cmbUnidadeEntrada.Size = new Size(121, 23);
            cmbUnidadeEntrada.TabIndex = 3;
            // 
            // cmbUnidadeSaida
            // 
            cmbUnidadeSaida.BackColor = Color.FromArgb(255, 128, 128);
            cmbUnidadeSaida.FormattingEnabled = true;
            cmbUnidadeSaida.Items.AddRange(new object[] { "watts", "miliwatts", "dB", "dBm" });
            cmbUnidadeSaida.Location = new Point(186, 87);
            cmbUnidadeSaida.Name = "cmbUnidadeSaida";
            cmbUnidadeSaida.Size = new Size(121, 23);
            cmbUnidadeSaida.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(319, 213);
            Controls.Add(cmbUnidadeSaida);
            Controls.Add(cmbUnidadeEntrada);
            Controls.Add(txtValorAConverter);
            Controls.Add(lbResultado);
            Controls.Add(btnConverter);
            Name = "Form1";
            Text = "dB Konversor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConverter;
        private Label lbResultado;
        private TextBox txtValorAConverter;
        private ComboBox cmbUnidadeEntrada;
        private ComboBox cmbUnidadeSaida;
    }
}
