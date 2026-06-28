namespace HelloWindows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double peso = double.Parse(txtPeso.Text);
            double altura = double.Parse(txtAltura.Text);
            double imc = peso / (altura * altura);
            lblResultado.Text = $"Seu IMC é:{imc:F2}";
            if (imc < 18.5)
            {
                lblResultado.Text =  "Abaixo do peso";
            }
            else if (imc >= 18.5 && imc < 24.9)
            {
                lblResultado.Text = "Peso normal";
            }
            else if (imc >= 25 && imc < 29.9)
            {
                lblResultado.Text = "Sobrepeso";
            }
            else if (imc >= 30 && imc < 34.9)
            {
                lblResultado.Text = "Obesidade grau I";
            }
            else if (imc >= 35 && imc < 39.9)
            {
                lblResultado.Text = "Obesidade grau II";
            }
            else if (imc >= 40)
            {
                lblResultado.Text = "Obesidade grau III";
            }

        }
    }
}
