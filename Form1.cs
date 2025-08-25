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
           
            //converter watts para dBm
            MessageBox.Show($"{valor_entrada/1000}");
            //double valor_saida = 10 * Math.Log10(valor_entrada / 0.001);

            //lbResultado.Text = valor_saida.ToString();
            lbResultado.Text = ConverterUnidades(valor_entrada).ToString();
            //MessageBox.Show($"{valor_saida}");
        }

        //Função que executa as conversões
        //private double ConverterUnidades(double valor, string unidadeEntrada, string unidadeSaida)
         private double ConverterUnidades(double valor_entrada) { 

            //Switch para verificar qual conversão executar
            
            //converter watts para miliwatts
            double valor_saida = 10 * Math.Log10(valor_entrada / 0.001);

            //converter watts para dB
            //double valor_saida = 10 * Math.Log10(valor_entrada / 0.006);

            //converter watts para dBm

            //converter watts para dBu

            //converter watts para dBv
            return valor_saida;
         }

        /*
          private double ConverterUnidades(double valor)
         {
             Converter de watts para unidade de saída
             valorSaida = 10 * Math.Log10(valor/1000);

             return valorSaida;

       }  */
    }
}