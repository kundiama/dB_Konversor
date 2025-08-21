namespace dB_konversor_v1._0
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double valor_entrada = double.Parse(txtValorAConverter.Text);
            
            //converter watts para dB
            //double valor_saida = 10 * Math.Log10(valor_entrada / 0.006);

            //converter watts para dBm
            MessageBox.Show($"{valor_entrada/1000}");
            double valor_saida = 10 * Math.Log10(valor_entrada / 0.001);

            lbResultado.Text = valor_saida.ToString();

            //MessageBox.Show($"{valor_saida}");
        }

        //private double ConvertUnits(double valor, string from, string to) { 
        /*   private double ConvertUnits(double valor)
          {
              Converter de watts para unidade de saída
              valorSaida = 10 * Math.Log10(valor/1000);

              return valorSaida;
            
    }  */
    }
}