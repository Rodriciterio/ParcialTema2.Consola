namespace ParcialTema2.Windows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double Base, Altura;
        double Area, Volumen, Arista;

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (ValidarDatos() && ValidarDatos2())
            {
                var Base=double.Parse(txtBase.Text);
                var Altura = double.Parse(txtAltura.Text);
                DataGridViewRow r = ConstruirFila();
                SetearFila(r, Base, Altura);
                AgregarFila(r);
            }
        }

        private void AgregarFila(DataGridViewRow r)
        {
            dgvDatos.Rows.Add(r);
        }

        private void SetearFila(DataGridViewRow r, double @base, double altura)
        {
            Area = CalcularArea(Base, Altura);
            Volumen = CalcularVolumen(Base, Altura);
            Arista = CalcularArista(Base, Altura);
            r.Cells[colAltura.Index].Value = Altura;
            r.Cells[colBase.Index].Value = Base;
            r.Cells[ColArea].Value = Area;
            r.Cells[colVolumen].Value = Volumen;
            r.Cells[colArista].Value = Arista;

        }

        private double CalcularArista(double @base, double altura)
        {
            return Math.Round(Math.Sqrt(Math.Pow(Altura, 2) + (Math.Pow(Base, 2) / 2)));
        }

        private double CalcularVolumen(double @base, double altura)
        {
            return Math.Round((Math.Pow(Base, 2) * Altura) / 3);
        }

        private double CalcularArea(double @base, double altura)
        {
            return Math.Round(Base * (Base + Math.Sqrt(4 * Math.Pow(Altura, 2) + Math.Pow(Altura, 2))));
        }

        private DataGridViewRow ConstruirFila()
        {
            DataGridViewRow r = new DataGridViewRow();
            r.CreateCells(dgvDatos);
            return r;
        }

        private bool ValidarDatos2()
        {
            bool EsValido2 = true;
            if (!double.TryParse(txtBase.Text, out double Base))
            {
                EsValido2 = false;
                errorProvider2.SetError(txtBase, "Base mal ingresada");
            }
            else if (!(Base>=0))
            {
                errorProvider2.SetError(txtBase, "Base debe ser mayor a 0");
            }
            return EsValido2;
        }

        private bool ValidarDatos()
        {
            bool EsValido = true;
            if (!double.TryParse(txtAltura.Text, out double Altura))
            {
                EsValido = false;
                errorProvider1.SetError(txtAltura, "Altura mal ingresada");
            }
            else if (!(Altura>=0))
            {
                EsValido = false;
                errorProvider1.SetError(txtAltura, "Altura debe ser mayor a 0");
            }
            return EsValido;
        }
    }
}