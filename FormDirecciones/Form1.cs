using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FormDirecciones.SRDireccion;

namespace FormDirecciones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        SRDireccion.DireccIpSoapClient dip = new DireccIpSoapClient();
        private void btnDiagnostico_Click(object sender, EventArgs e)
        {
            if (txtIp1.Text != string.Empty && txtIp2.Text != string.Empty && txtIp3.Text != string.Empty && txtIp1.Text != string.Empty)
            {
                try
                {
                    MessageBox.Show(dip.DiagnosticoIp(int.Parse(txtIp1.Text)), "El Diagnostico de la Direccion Ip es:", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (FormatException ex)
                {

                    MessageBox.Show(string.Format("Debes introducir un numero valido en las cajas de texto. \n {o}", ex.Message));
                }
            }
        }
    }
}
