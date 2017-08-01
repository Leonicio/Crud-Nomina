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
using System.Data.SqlClient;



namespace Crub_NOMINAS
{
    public partial class FormEmpleado : Form

    {
        SQLiteConnection conex;

        public FormEmpleado()
        {
            InitializeComponent();
        }

        private void lblcalcularEdad_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {
                conex = new SQLiteConnection(@"Data Source=C:\Users\leoni\Desktop\Nomina.s3db;version=3;");
                conex.Open();
                

            }

            catch (SQLiteException ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
             string comando = "INSERT INTO Empleados (num_empleado, nombre, apellido, cedula, Sexo, fecha_nac, fecha_ingreso, id_cargo, salario) VALUES('" + txtID.Text + "','" + txtnombre.Text + "','" + txtapellido.Text + "','" + txtcedula.Text + "','" + txtsexo.Text + "' , '" + txtfecha_nacimiento.Text + "', '" + txtfecha_ingreso.Text +"', " + txt_idcargo.Text + "," + txtSalario.Text + ")";
             SQLiteCommand insertar = new SQLiteCommand(comando, conex);
             insertar.ExecuteNonQuery();

            MessageBox.Show("Se Guardaron los Datos Correctamente");
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardarNuevo_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            txtnombre.Clear();
            txtapellido.Clear();
            txtcedula.Clear();
            txtfecha_ingreso.Clear();
            txtfecha_nacimiento.Clear();
            txt_idcargo.Clear();
            txtSalario.Clear();
            txtsexo.Clear();
            txtcalcular_entig.Clear();
            txtcalcular_edad.Clear();

            txtID.Focus();
        }

        private void btnSalirForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
