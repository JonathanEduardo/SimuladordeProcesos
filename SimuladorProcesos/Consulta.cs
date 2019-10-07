using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace SimuladorProcesos
{
    public partial class Consulta : Form
    {
        private ConnectionBD connection;
        DataTable dt;

        public Consulta()
        {
            InitializeComponent();
            connection = new ConnectionBD();
            cBTable.SelectedIndex = -1;
        }

        private void BtnCierra_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAgregaInformacion_Click(object sender, EventArgs e)
        {
           /* DataTable dt2 = new DataTable();
            DataRow[] dr = dt.Select("[SAE-AISI] = " + tBSelecc.Text);
            dt.Clear();
            foreach (DataRow row in dr)
                dt2.Rows.Add(row);
            dataGridView1.DataSource = dt2;*/
        }

        private void cBTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            dt = new DataTable();
            if(cBTable.SelectedIndex > -1)
            {
                switch(cBTable.SelectedIndex)
                {
                    case 0:
                        dt = connection.getTable14();
                    break;
                    case 1:
                        dt = connection.getTable15();
                    break;
                    case 2:
                        dt = connection.getTable16();
                    break;
                    case 3:
                        dt = connection.getTable17();
                    break;
                    case 4:
                        dt = connection.getTable18();
                    break;
                }
            }
            this.dataGridView1.DataSource = dt;
        }

        private void TBSelecc_KeyDown(object sender, KeyEventArgs e)
        {
            dt = new DataTable();
            if (cBTable.SelectedIndex > -1)
            {
                switch (cBTable.SelectedIndex)
                {
                    case 0:
                        dt = connection.getTable14();
                        break;
                    case 1:
                        dt = connection.getTable15();
                        break;
                    case 2:
                        dt = connection.getTable16();
                        break;
                    case 3:
                        dt = connection.getTable17();
                        break;
                    case 4:
                        dt = connection.getTable18();
                        break;
                }
            }
            this.dataGridView1.DataSource = dt;
        }

        private void TBSelecc_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
