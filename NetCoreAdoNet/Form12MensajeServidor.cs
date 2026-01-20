using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

#region PROCEDIMIENTOS ALMACENADOS
//create procedure SP_ALL_DEPARTAMENTOS
//AS
//	SELECT * FROM DEPT
//GO

//create procedure SP_INSERT_DEPARTAMENTO(@numero int, @nombre as NVARCHAR(50) , @localidad as NVARCHAR(50))
//as
//	INSERT INTO DEPT VALUES(@numero, @nombre, @localidad)
//go
//alter procedure SP_INSERT_DEPARTAMENTO
//(@numero int, @nombre nvarchar(50), @localidad as NVARCHAR(50))
//as
//if(UPPER(@localidad)='TERUEL')
//begin
//	PRINT 'TERUEL NO EXISTE'
	
//	END
//	ELSE
//	BEGIN
//	INSERT INTO DEPT VALUES(@numero, @nombre, @localidad)
//	END
//go

#endregion

namespace NetCoreAdoNet
{
    public partial class Form12MensajeServidor : Form
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;
        public Form12MensajeServidor()
        {
            InitializeComponent();

            string connectionString = @"Data Source=LOCALHOST\DEVELOPER;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Encrypt=True;Trust Server Certificate=True";
            //string connectionString = @"Data Source=sqlpaco3430.database.windows.net;Initial Catalog=AZURETAJAMAR;Persist Security Info=True;User ID=adminsql;Password=Admin123;Trust Server Certificate=True";
            this.cn = new SqlConnection(connectionString);
            this.cn.InfoMessage += Cn_InfoMessage;
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
            this.LoadDepartamentosAsync();
        }

        private async void Cn_InfoMessage(object sender, SqlInfoMessageEventArgs e)
        {
            this.lblServidor.Text = e.Message;
        }

        private async Task LoadDepartamentosAsync()
        {
            string sql = "SP_ALL_DEPARTAMENTOS";

            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();
            this.lstDepartamentos.Items.Clear();

            while (await this.reader.ReadAsync())
            {
                string nombre = this.reader["DNOMBRE"].ToString();
                this.lstDepartamentos.Items.Add(nombre);
            }
            await this.reader.CloseAsync();
            await this.cn.CloseAsync();
        }

        private async Task InsertDepartamentoAsync()
        {
            string sql = "SP_INSERT_DEPARTAMENTO";
            this.lblServidor.Text = "";
            int id = int.Parse(this.txtId.Text);
            string nombre = this.txtNombre.Text;
            string localidad = this.txtLocalidad.Text;

            this.com.Parameters.AddWithValue("@numero", id);
            this.com.Parameters.AddWithValue("@nombre", nombre);
            this.com.Parameters.AddWithValue("@localidad", localidad);
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            //int registros = await this.com.ExecuteNonQueryAsync();
            int registros = this.com.ExecuteNonQuery();
            await this.cn.CloseAsync();
            this.com.Parameters.Clear();
            MessageBox.Show("Registros Modificados: " + registros);
            await this.LoadDepartamentosAsync();

        }
        
        private async void btnNuevo_Click(object sender, EventArgs e)
        {
            
            await this.InsertDepartamentoAsync();

        }
    }
}
