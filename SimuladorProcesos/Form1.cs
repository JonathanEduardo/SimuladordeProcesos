using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace SimuladorProcesos
{
    public partial class Fomr : Form
    {
        public Fomr()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wnsg, int wparam, int lparam);

        private void BtnSlide_Click(object sender, EventArgs e)
        {
            if(PanelMenu.Width == 250)
            {
                PanelMenu.Width = 63;
            }
            else
            {
                PanelMenu.Width = 250;
            }
        }

        private void BtnCierra_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMaximiza_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximiza.Visible = false;
            btnRestaura.Visible = true;
        }

        private void BtnRestaura_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnMaximiza.Visible = true;
            btnRestaura.Visible = false;
        }

        private void BtnMinimiza_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            
        }

        private void PanelTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
