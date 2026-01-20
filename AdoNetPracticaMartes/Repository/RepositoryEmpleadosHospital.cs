using AdoNetPracticaMartes.Helpers;
using AdoNetPracticaMartes.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics.Metrics;
using System.Text;

#region PROCEDIMIENTOS
//create procedure SP_GET_PLANTILLA_DOCTORES
//(@nombre nvarchar(50))
//AS
//select Plantilla.APELLIDO, Plantilla.Funcion, SALARIO from PLANTILLA
//INNER JOIN HOSPITAL
//ON HOSPITAL.HOSPITAL_COD = PLANTILLA.HOSPITAL_COD
//WHERE HOSPITAL.NOMBRE = @nombre

//UNION

//select DOCTOR.APELLIDO, DOCTOR.ESPECIALIDAD, SALARIO from DOCTOR
//INNER JOIN HOSPITAL
//ON HOSPITAL.HOSPITAL_COD = DOCTOR.HOSPITAL_COD
//WHERE HOSPITAL.NOMBRE = @nombre

//GO

//CREATE procedure SP_SALARIO_EMPLEADOS
//(@nombre nvarchar(50))
//AS
//SELECT isnull(SUM(SALARIO),0)AS SUMA, isnull(AVG(SALARIO), 0) AS MEDIA, Count(*) AS PERSONAS FROM
//(select Plantilla.APELLIDO, Plantilla.Funcion, SALARIO from PLANTILLA
//INNER JOIN HOSPITAL
//ON HOSPITAL.HOSPITAL_COD = PLANTILLA.HOSPITAL_COD
//WHERE HOSPITAL.NOMBRE = @nombre

//UNION ALL

//select DOCTOR.APELLIDO, DOCTOR.ESPECIALIDAD, SALARIO from DOCTOR
//INNER JOIN HOSPITAL
//ON HOSPITAL.HOSPITAL_COD = DOCTOR.HOSPITAL_COD
//WHERE HOSPITAL.NOMBRE = @nombre
//)
//QUERY
//GO
#endregion
namespace AdoNetPracticaMartes.Repository
{
   
    public class RepositoryEmpleadosHospital
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;

        IConfigurationRoot configuration =
                   HelperConnection.GetConfiguration();

        public RepositoryEmpleadosHospital()
        {
            string connectionString = configuration.GetConnectionString("SqlLocalTajamar");

            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;

        }
        public async Task<List<Hospital>> GetHospitalesAsync()
        {
            string sql = "SP_GET_ALL_HOSPITALES";
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = sql;

            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();

            List<Hospital> hospitales = new List<Hospital>();
            while (await this.reader.ReadAsync())
            {
                Hospital hosp = new Hospital();

                hosp.HospitalCod = int.Parse(this.reader["HOSPITAL_COD"].ToString());
                hosp.Nombre = this.reader["NOMBRE"].ToString();
      
                hospitales.Add(hosp);
            }

            await this.reader.CloseAsync();
            await this.cn.CloseAsync();

            return hospitales;
        }

        public async Task<List<Empleado>> GetEmpleadosHospitalAsync(string nombreHospital)
        {
            string sql = "SP_GET_PLANTILLA_DOCTORES";

            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = sql;

            this.com.Parameters.AddWithValue("@nombre", nombreHospital);

            await this.cn.OpenAsync();

            this.reader = await this.com.ExecuteReaderAsync();

            List<Empleado> empleados = new List<Empleado>();
            while (await this.reader.ReadAsync())
            {

                Empleado emp = new Empleado();

                emp.Apellido = this.reader["APELLIDO"].ToString();
                emp.Funcion = this.reader["FUNCION"].ToString();
                emp.Salario = int.Parse(this.reader["SALARIO"].ToString());


                empleados.Add(emp);
            }
            this.com.Parameters.Clear();
            await this.reader.CloseAsync();
            await this.cn.CloseAsync();
          
            return empleados;
        }


        public async Task<Salario> GetMediasSalariosAsync(string nombreHospital)
        {
            string sql = "SP_SALARIO_EMPLEADOS";

            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = sql;

            this.com.Parameters.AddWithValue("@nombre", nombreHospital);

            await this.cn.OpenAsync();

            this.reader = await this.com.ExecuteReaderAsync();

            Salario sal = new Salario();
            while (await this.reader.ReadAsync())
            {
              
                sal.Suma = int.Parse(this.reader["SUMA"].ToString());
                sal.Media = int.Parse(this.reader["MEDIA"].ToString());
                sal.Personas = int.Parse(this.reader["PERSONAS"].ToString());
               
            }
            this.com.Parameters.Clear();
            await this.reader.CloseAsync();
            await this.cn.CloseAsync();
            return sal;
        }


    }


}
