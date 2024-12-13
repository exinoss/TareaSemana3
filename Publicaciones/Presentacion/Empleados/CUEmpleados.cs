using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Publicaciones.MenuPrincipal.Empleados
{
    public partial class CUEmpleados : UserControl
    {
        public CUEmpleados()
        {
            InitializeComponent();
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            frmEmpleados frmEmpleado = new frmEmpleados();
            frmEmpleado.ShowDialog();
        }
    }
}
