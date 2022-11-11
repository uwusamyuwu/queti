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
        public AltaFamilia()
        {
            InitializeComponent();
        }

        private void AltaFamilia_Load(object sender, EventArgs e)
        {

        }

        private void btCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(TxtNombre.ToString());
            flia.nombre = TxtNombre.ToString();
            flia.apellido = TxtApellido.ToString();
            flia.parentesco = TxtParentesco.ToString();
            flia.ocupacion = TxtOcupacion.ToString();
            flia.agregarFamilia(flia);


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
