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

namespace Crub_NOMINAS
{
    public partial class Form1 : Form
    {
        SQLiteConnection conex;
        public Form1()
        {
            InitializeComponent();
        }

        private void btncrear_Click(object sender, EventArgs e)
        {
            FormEmpleado f = new FormEmpleado();
            f.Show();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            try
            {
                conex = new SQLiteConnection("Data Source=C:\\sistemas\\Nomina.db;version=3;");
                conex.Open();
               
            }

            catch (SQLiteException ex)
            {
                
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
           
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
