using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Negocio
{
    public partial class Vista : Form
    {
        public Vista()
        {
            InitializeComponent();
        }

        private void Vista_Load(object sender, EventArgs e)
        {
    
        }

        public void acciones(int rg)
        {
            if (rg == 0)
            {

                MessageBox.Show("el correo electronico esta incorrecto");
            }


            if (rg == 1)
            {

                MessageBox.Show("la contraseña esta incorrecta");
            }


            if (rg == 2)
            {



                MessageBox.Show("la contraseña esta incorrecta");

            }
            if (rg == 3)
            {



                MessageBox.Show("la contraseña esta incorrecta");

            }
            if (rg == 4)
            {



                MessageBox.Show("la contraseña esta incorrecta");

            }
            if (rg == 5)
            {



                MessageBox.Show("la contraseña esta deshabilidad");

            }
        }
    }
}
