using System.Windows.Forms;

namespace ParcialTema2.winodows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double Arista, Area, Volumen;
        double Base, Altura;
        private void btnOk_Click(object sender, EventArgs e)
        {
            if (ValidarDatos() && ValidarDatos2())
            {
                var Base = double.Parse(txtBase.Text);
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

        private void SetearFila(DataGridViewRow r, double Base, double Altura)
        {
            Arista = CalcularArista(Base, Altura);
            Area = CalcularArea(Base, Altura);
            Volumen = CalcularVolumen(Base, Altura);
            r.Cells[ColAltura.Index].Value = Altura;
            r.Cells[ColBase.Index].Value = Base;
            r.Cells[ColArista.Index].Value = Arista;
            r.Cells[ColArea.Index].Value = Area;
            r.Cells[ColVolumen.Index].Value = Volumen;
        }

        private double CalcularArista(double Base, double altura)
        {
            return Math.Round(Math.Sqrt(Math.Pow(Altura, 2) + (Math.Pow(Base, 2) / 2)));
        }

        private double CalcularVolumen(double Base, double Altura)
        {

            return Math.Round((Math.Pow(Base, 2) * Altura) / 3);
        }

        private double CalcularArea(double Altura, double Base)
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
                errorProvider2.SetError(txtBase, "Base mal ingresado");
            }
            else if (!(Base > 0))
            {
                EsValido2 = false;
                errorProvider2.SetError(txtBase, "La base debe ser mayor a 0 (Cero)");
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
            else if (!(Altura > 0))
            {
                EsValido = false;
                errorProvider1.SetError(txtAltura, "La altura debe ser mayor a 0 (Cero)");
            }
            return EsValido;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtAltura.Clear();
            txtBase.Clear();
            txtBase.Focus();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Desea salir del formulario?", "Pregunta",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question,
               MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}