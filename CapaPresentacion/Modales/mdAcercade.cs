using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsignacionServicios.Modales
{
    public partial class mdAcercade : Form
    {
        public mdAcercade()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            redirect(linkLabel1.Text);
        }
        public void redirect(string url)
        {
            var processStartInfo = new ProcessStartInfo
            {
                UseShellExecute = true,
                FileName = url
            };
            Process.Start(processStartInfo);
        }
    }
}
