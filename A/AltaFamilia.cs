using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A
{
    public partial class AltaFamilia : Form
    {
        Familia flia = new Familia();
       // string nombre = "";

        string origen = "";
        public AltaFamilia(string pOrigen, string pIdFamilia)
        {
            if (pOrigen == "m")
            {
                origen = pIdFamilia;
                flia.obtenerFamilia(pIdFamilia);
                
            }
            InitializeComponent();
        }

        private void AltaFamilia_Load(object sender, EventArgs e)
        {
            TxtNombre.Text = flia.nombre;
            TxtApellido.Text = flia.apellido;
            TxtParentesco.Text = flia.parentesco;
            TxtOcupacion.Text = flia.ocupacion;
        }

        private void btCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(TxtNombre.ToString());
            flia.nombre = TxtNombre.Text;
            flia.apellido = TxtApellido.Text;
            flia.parentesco = TxtParentesco.Text;
            flia.ocupacion = TxtOcupacion.Text;
            flia.agregarFamilia(flia);

            if (origen == "")
            {
                flia.agregarFamilia(flia);
            }
            else
            {
                flia.actualizarFamilia(flia, origen);
            }

            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
