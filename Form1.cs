namespace dB_konversor_v1._0
{
    public partial class Form1 : Form
    {
        double valor_saida;

        public Form1()
        {
            InitializeComponent();
            cmbUnidadeEntrada.SelectedIndex = 0;
            cmbUnidadeSaida.SelectedIndex = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double valor_entrada = double.Parse(txtValorAConverter.Text);

            string unidadeEntrada = cmbUnidadeEntrada.SelectedItem.ToString();
            string unidadeSaida = cmbUnidadeSaida.SelectedItem.ToString();

            ConverterUnidades(valor_entrada, unidadeEntrada, unidadeSaida);

            //lbResultado.Text = valor_saida.ToString();
            //lbResultado.Text = ConverterUnidades(valor_entrada, unidadeEntrada, unidadeSaida).ToString();
            // MessageBox.Show($"{unidadeEntrada}");
            // MessageBox.Show($"{unidadeSaida}");
        }

        //Função que executa as conversões
        //private double ConverterUnidades(double valor, string unidadeEntrada, string unidadeSaida)
        private void ConverterUnidades(double valor_entrada, string unidadeEntrada, string unidadeSaida) {

            //Switch para verificar qual conversão executar
            switch (unidadeEntrada) {
                case "watts": resultadoFinalWatts(valor_entrada, unidadeSaida); break;

                case "miliwatts": resultadoFinalMiliWatts(valor_entrada, unidadeSaida); break;

                case "dB": Console.WriteLine("Em desenvolvimento"); break;

                case "dBm": Console.WriteLine("Em desenvolvimento"); break;

                case "dBu": Console.WriteLine("Em desenvolvimento"); break;

                case "dBv": Console.WriteLine("Em desenvolvimento"); break;
            }
        }

        private void resultadoFinalWatts(double valor_entrada, string unidadeSaida) {
            //Switch para verificar qual conversão executar   
            switch (unidadeSaida)
            {
                case "miliwatts":
                                              
                    valor_saida = valor_entrada*1000;
                    lbResultado.Text = valor_saida.ToString();
                    break;

                case "dB":
                    valor_saida = 10 * Math.Log10(valor_entrada / 0.006);                 
                    lbResultado.Text = valor_saida.ToString();
                    break;
                    
                case "dBm":
                    valor_saida = 10 * Math.Log10(valor_entrada / 0.001);
                    lbResultado.Text = valor_saida.ToString();
                    break;

                case "dBw":
                    
                    lbResultado.Text = "Em implementação";
                    break;

                case "dBu":
                    lbResultado.Text = "Em implementação";
                    break;
            }
            
        }

        private void resultadoFinalMiliWatts(double valor_entrada, string unidadeSaida)
        {
            //Switch para verificar qual conversão executar   
            switch (unidadeSaida)
            {
                case "watts":

                    valor_saida = valor_entrada / 1000;
                    lbResultado.Text = valor_saida.ToString();
                    break;

                case "dB":
                    lbResultado.Text = "Em implementação";
                    break;

                case "dBm":
                    valor_saida = 10 * Math.Log10(valor_entrada);
                    lbResultado.Text = valor_saida.ToString();
                    break;

                case "dBw":

                    lbResultado.Text = "Em implementação";
                    break;

                case "dBu":
                    lbResultado.Text = "Em implementação";
                    break;
            }

        }
    }
    
}