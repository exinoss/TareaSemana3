using Publicaciones.MenuPrincipal;
using Publicaciones.MenuPrincipal.Autor;
using Publicaciones.MenuPrincipal.Empleados;
using Publicaciones.MenuPrincipal.Titulo;
using Publicaciones.MenuPrincipal.Ventas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Publicaciones
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        

        private void btnTitulos_Click(object sender, EventArgs e)
        {
            CUTitulos Titulos = new CUTitulos();
            pndPrincipal.Controls.Clear();
            Titulos.Dock = DockStyle.Fill;
            pndPrincipal.Controls.Add(Titulos);
        }

        private void btnAutores_Click(object sender, EventArgs e)
        {
            CUAutores autores = new CUAutores();
            pndPrincipal.Controls.Clear();
            autores.Dock = DockStyle.Fill;
            pndPrincipal.Controls.Add(autores);
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            CUEmpleados empleados = new CUEmpleados();
            pndPrincipal.Controls.Clear();
            empleados.Dock = DockStyle.Fill;
            pndPrincipal.Controls.Add(empleados);

        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            CUVentas Titulos = new CUVentas();
            pndPrincipal.Controls.Clear();
            Titulos.Dock = DockStyle.Fill;
            pndPrincipal.Controls.Add(Titulos);
        }

    }
}
