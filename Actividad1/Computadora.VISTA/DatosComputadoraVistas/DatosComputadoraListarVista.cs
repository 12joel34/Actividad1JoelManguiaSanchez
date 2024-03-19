using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Computadora.BSS;
namespace Computadora.VISTA.DatosComputadoraVistas
{
    public partial class DatosComputadoraListarVista : Form
    {
        public DatosComputadoraListarVista()
        {
            InitializeComponent();
        }
        DatosComputadoraBss bss=new DatosComputadoraBss();  

        private void DatosComputadoraListarVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarComputadoraBss();
        }
    }
}
