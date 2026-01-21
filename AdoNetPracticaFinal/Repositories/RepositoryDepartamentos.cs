using AdoNetPracticaFinal.Helpers;
using AdoNetPracticaFinal.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Metrics;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;


#region Procedimientos
//CREATE PROCEDURE SP_GET_EMPLEADOS_DEPARTAMENTO(@nombre nvarchar(50))
//as
//	select  emp.EMP_NO, emp.APELLIDO, emp.OFICIO, emp.SALARIO from emp
//	inner join dept
//	on emp.DEPT_NO= dept.DEPT_NO
//	where dept.DNOMBRE=@nombre
//go
//alter procedure SP_GET_EMPLEADO_DEPARTAMENTO(@emp nvarchar(60))
//as
//	select  emp.EMP_NO, emp.APELLIDO, emp.OFICIO, emp.SALARIO, dept.* from emp 
//	inner join dept 
//	on dept.DEPT_NO= emp.DEPT_NO
//	where emp.APELLIDO=@emp
//go

//alter procedure SP_UPDATE_EMPLEADO(@apellidoOld nvarchar(50), @apellido nvarchar(50), @oficio nvarchar(50), @salario int)
//AS
//update emp set APELLIDO=@apellido, OFICIO = @oficio, SALARIO = @salario
//where APELLIDO=@apellidoOld
//GO
//CREATE PROCEDURE SP_GET_DEPARTAMENTO_INFO(@nombre nvarchar(50))
//as
//select distinct * from dept where DNOMBRE=@nombre
//go

#endregion
namespace AdoNetPracticaFinal.Repositories
{
    public class RepositoryDepartamentos
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;

        IConfigurationRoot configuration =
                   HelperConnection.GetConfiguration();

        public RepositoryDepartamentos()
        {

            string connectionString = configuration.GetConnectionString("SqlLocalTajamar");

            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;

        }

        public async Task<List<Departamento>> GetDepartamentosAsync()
        {
            string sql = "SELECT * FROM DEPT";
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;

            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();

            List<Departamento> departamentos = new List<Departamento>();

            while (await this.reader.ReadAsync())
            {
                Departamento dept = new Departamento();
               
                dept.IdDepartamento = int.Parse(this.reader["DEPT_NO"].ToString());
                dept.Nombre = this.reader["DNOMBRE"].ToString();
                dept.Localidad = this.reader["LOC"].ToString();
                departamentos.Add(dept);

            }

            await this.reader.CloseAsync();
            await this.cn.CloseAsync();
            return departamentos;
        }

        public async Task<List<Empleado>> GetEmpleadosDepartamentoAsync(string nombre)
        {
            string sql = "SP_GET_EMPLEADOS_DEPARTAMENTO";
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = sql;
            this.com.Parameters.AddWithValue("@nombre", nombre);
            await this.cn.OpenAsync();
            
            
            this.reader = await this.com.ExecuteReaderAsync();
            List<Empleado> empleados = new List<Empleado>();
            while (await this.reader.ReadAsync())
            {

                Empleado emp = new Empleado();
                emp.IdEmpleado = int.Parse(this.reader["EMP_NO"].ToString());
                emp.Apellido = this.reader["APELLIDO"].ToString();
                emp.Oficio = this.reader["OFICIO"].ToString();
                emp.Salario = int.Parse(this.reader["SALARIO"].ToString());

                empleados.Add(emp);

            }
            this.com.Parameters.Clear();
            await this.reader.CloseAsync();
            await this.cn.CloseAsync();
            return empleados;

        }

        public async Task<Empleado> GetDatosEmpleadoByIdAsync(string nombre)
        {
            string sql = "SP_GET_EMPLEADO_DEPARTAMENTO";
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = sql;
            this.com.Parameters.AddWithValue("@emp", nombre);
            await this.cn.OpenAsync();


            this.reader = await this.com.ExecuteReaderAsync();

            Empleado empleado = new Empleado();
            while (await this.reader.ReadAsync())
            {
                
                empleado.IdEmpleado = int.Parse(this.reader["EMP_NO"].ToString());
                empleado.Apellido = this.reader["APELLIDO"].ToString();
                empleado.Oficio = this.reader["OFICIO"].ToString();
                empleado.Salario = int.Parse(this.reader["SALARIO"].ToString());

            }

            this.com.Parameters.Clear();
            await this.reader.CloseAsync();
            await this.cn.CloseAsync();
            return empleado;
        }
        public async Task<Departamento> GetDatosDepartamentoByNameAsync(string nombre)
        {
            string sql = "SP_GET_DEPARTAMENTO_INFO";
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = sql;
            this.com.Parameters.AddWithValue("@nombre", nombre);
            await this.cn.OpenAsync();

            this.reader = await this.com.ExecuteReaderAsync();

            Departamento departamento = new Departamento();
            while (await this.reader.ReadAsync())
            {

                departamento.IdDepartamento = int.Parse(this.reader["DEPT_NO"].ToString());
                departamento.Nombre = this.reader["DNOMBRE"].ToString();
                departamento.Localidad = this.reader["LOC"].ToString();
               
            }

            this.com.Parameters.Clear();
            await this.reader.CloseAsync();
            await this.cn.CloseAsync();
            return departamento;
        }

        public async Task<int> UpdateEmpleadoAsync(string empSeleccionado,string nombreEmpleado,string oficio,int salario)
        {
           string sql = "SP_UPDATE_EMPLEADO";
            this.com.CommandText = sql;
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.Parameters.AddWithValue("@apellidoOld", empSeleccionado);
            this.com.Parameters.AddWithValue("@apellido", nombreEmpleado);
            this.com.Parameters.AddWithValue("@oficio", oficio);
            this.com.Parameters.AddWithValue("@salario", salario);

            await this.cn.OpenAsync();

            int registros = await this.com.ExecuteNonQueryAsync();
            this.com.Parameters.Clear();
            await this.reader.CloseAsync();
            await this.cn.CloseAsync();
            return registros;
        }

        public async Task<int> InsertDepartamentosAsync(int idDept,string nombreDept, string localidad)
        {
            string sql = "INSERT INTO DEPT VALUES(@idDept,@nombre,@localidad)";
            this.com.CommandText = sql;
            this.com.CommandType = CommandType.Text;
            this.com.Parameters.AddWithValue("@idDept", idDept);
            this.com.Parameters.AddWithValue("@nombre", nombreDept);
            this.com.Parameters.AddWithValue("@localidad", localidad);
  
            await this.cn.OpenAsync();

            int registros = await this.com.ExecuteNonQueryAsync();
            this.com.Parameters.Clear();
            await this.reader.CloseAsync();
            await this.cn.CloseAsync();
            return registros;
        }
       
    }

    
}
