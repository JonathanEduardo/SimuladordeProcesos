using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;
using System.Data;

namespace SimuladorProcesos
{
    public class ConnectionBD
    {
        public static string dbName { get; set; }
        public string pathBD { get; set; }
        public SQLiteConnection connection { get; set; }
        public SQLiteDataAdapter adapter { get; set; }


        public ConnectionBD()
        {
            dbName = "SimuladorBD.db";
            pathBD = Application.StartupPath + "/" + dbName;
            connection = new SQLiteConnection("data source=" + pathBD);

            try
            {
                MessageBox.Show("Conexion Establecida");
                connection.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("Conexión Fallida");
            }
        }

        public DataTable getTable14()
        {
            DataTable dt = new DataTable();

            adapter = new SQLiteDataAdapter("SELECT * FROM [Table1.4]", connection);
            adapter.Fill(dt);

            return (dt);
        }

        public DataTable getTable15()
        {
            DataTable dt = new DataTable();

            adapter = new SQLiteDataAdapter("SELECT * FROM [Table1.5]", connection);
            adapter.Fill(dt);

            return (dt);
        }

        public DataTable getTable16()
        {
            DataTable dt = new DataTable();

            adapter = new SQLiteDataAdapter("SELECT * FROM [Table1.6]", connection);
            adapter.Fill(dt);

            return (dt);
        }

        public DataTable getTable17()
        {
            DataTable dt = new DataTable();

            adapter = new SQLiteDataAdapter("SELECT * FROM [Table1.7] ", connection);
            adapter.Fill(dt);

            return (dt);
        }

        public DataTable getTable18()
        {
            DataTable dt = new DataTable();

            adapter = new SQLiteDataAdapter("SELECT * FROM [Table1.8]", connection);
            adapter.Fill(dt);

            return (dt);
        }

        public DataTable getCodigo(string Tabla, string Dato)
        {
            DataTable dt = new DataTable();

            adapter = new SQLiteDataAdapter("SELECT * FROM [" + Tabla + "] WHERE " , connection);
            adapter.Fill(dt);

            return (dt);
        }
    }
}
