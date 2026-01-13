using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreAdoNet
{
    public partial class Form02BuscadorEmpleado : Form
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;

        public Form02BuscadorEmpleado()
        {
            InitializeComponent();
            string connectionString = @"Data Source=LOCALHOST\DEVELOPER;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Trust Server Certificate=True";
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //VAMOS A CONCATENAR, POR LO QUE NUESTRO SALARIO SERA UN STRING 
            string salario = this.txtEmpleado.Text;
            //CONSULTA SQL
            string sql = "select * from EMP where SALARIO >= " +salario;
            //CONFIGURAMOS EL COMANDO
            //CONNECTION
            this.com.Connection = this.cn;
            //TIPO DE CONSULTA
            this.com.CommandType = CommandType.Text;
            //LA CONSULTA
            this.com.CommandText = sql;
            //ENTRAR Y SALIR
            //ABRIMOS CONEXION
            this.cn.Open();
            //EJECUTAMOS LA CONSULTA
            this.reader = this.com.ExecuteReader();

            this.lstEmpleados.Items.Clear();

            while (this.reader.Read())
            {
                string apellido = this.reader["APELLIDO"].ToString();
                string sal = this.reader["SALARIO"].ToString();
                this.lstEmpleados.Items.Add(apellido + " - " + sal);
            }
            //SALIMOS, LIBERAMOS LOS RECURSOS
            this.reader.Close();
            this.cn.Close();
        }
    }
}
