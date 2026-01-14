using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace NetCoreAdoNet.Repositories
{
    public class RepositoryDepartamentoEmpleados
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;
        string connectionString = @"Data Source=LOCALHOST\DEVELOPER;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Encrypt=True;Trust Server Certificate=True";

        public RepositoryDepartamentoEmpleados()
        {
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
        }

        public async Task<List<string>> GetDepartamentosAsync()
        {
            string sql = "SELECT DNOMBRE FROM DEPT";
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;

            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();

            List<string> departamentos = new List<string>();
            while(await this.reader.ReadAsync())
            {
                string dept = this.reader["DNOMBRE"].ToString();
                departamentos.Add(dept);
            }
            await this.reader.CloseAsync();
            await this.cn.CloseAsync();

            return departamentos;
        }

        public async Task<List<string>> GetEmpleadosAsync(string departamento)
        {
            string sql = "SELECT EMP.APELLIDO FROM EMP INNER JOIN DEPT " +
                "ON EMP.DEPT_NO = DEPT.DEPT_NO " +
                "WHERE DEPT.DNOMBRE = @dept";

            SqlParameter pamDep = new SqlParameter("@dept", departamento);
            this.com.Parameters.Add(pamDep);
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;

            await this.cn.OpenAsync();


            this.reader = await this.com.ExecuteReaderAsync();
            List<string> empleados = new List<string>();

            while (await this.reader.ReadAsync())
            {
                string emp = this.reader["APELLIDO"].ToString();
                empleados.Add(emp);
            }
            await this.reader.CloseAsync();
            await this.cn.CloseAsync();
            this.com.Parameters.Clear();
            return empleados;
        }


        public async Task DeleteEmpleadoAsync(string apellido)
        {
            string sql = "DELETE FROM EMP WHERE APELLIDO=@apellido";

            SqlParameter pamEmp = new SqlParameter("@apellido", apellido);
            this.com.Parameters.Add(pamEmp);
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;

            await this.cn.OpenAsync();
            await this.com.ExecuteNonQueryAsync();

            await this.cn.CloseAsync();
            this.com.Parameters.Clear();
        }

    }
}
