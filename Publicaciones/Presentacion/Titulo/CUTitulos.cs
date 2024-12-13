using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Publicaciones.MenuPrincipal.Titulo
{
    public partial class CUTitulos : UserControl
    {
        public CUTitulos()
        {
            InitializeComponent();
        }

        private void btnTitulo_Click(object sender, EventArgs e)
        {
            frmTitulos frm = new frmTitulos();
            frm.ShowDialog();
        }

        private void btnEditorial_Click(object sender, EventArgs e)
        {
            frmEditoriales frm = new frmEditoriales();
            frm.ShowDialog();
        }

        private void btnDatosEditorial_Click(object sender, EventArgs e)
        {
            frmInfoEditorial frmInfoEditorial = new frmInfoEditorial();
            frmInfoEditorial.ShowDialog();
        }
    }
}
