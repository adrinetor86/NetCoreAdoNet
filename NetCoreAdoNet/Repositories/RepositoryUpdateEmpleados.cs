using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Security.Cryptography;
using System.Text;

namespace NetCoreAdoNet.Repositories
{
    public class RepositoryUpdateEmpleados
    {
        private SqlConnection cn;
        private SqlCommand com;
        private SqlDataReader reader;


        public RepositoryUpdateEmpleados()
        {
            string connectionString = @"Data Source=LOCALHOST\DEVELOPER;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Encrypt=True;Trust Server Certificate=True";
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
        }

        public async Task<List<string>> GetOficiosAsync()
        {
            string sql = "SELECT DISTINCT OFICIO FROM EMP";
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;

            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();

            List<string> oficiosList = new List<string>();
            while (await this.reader.ReadAsync())
            {
                string oficio = this.reader["OFICIO"].ToString();
                oficiosList.Add(oficio);
            }
            await this.reader.CloseAsync();
            await this.cn.CloseAsync();
            return oficiosList;
        }

        public async Task<List<string>> GetEmpleadosByOficioAsync(string oficio)
        {
            string sql = "SELECT APELLIDO FROM EMP WHERE OFICIO=@oficio";
            this.com.Parameters.AddWithValue("@oficio",oficio);
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();

            this.reader = await this.com.ExecuteReaderAsync();
            List<string> apellidos = new List<string>();

            while (await this.reader.ReadAsync())
            {
                string ape = this.reader["APELLIDO"].ToString();
                apellidos.Add(ape);
            }
            await this.reader.CloseAsync();
            this.com.Parameters.Clear();
            await this.cn.CloseAsync();
            return apellidos;
        }


        public async Task<int> UpdateSalarioEmpleadosAsync(string oficio,int incremento)
        {
            string sql = "UPDATE EMP SET SALARIO=SALARIO +  @incremento " +
                "WHERE  OFICIO=@oficio";
            this.com.Parameters.AddWithValue("@oficio",oficio);
            this.com.Parameters.AddWithValue("@incremento",incremento);
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();

            int registros = await this.com.ExecuteNonQueryAsync();
            await this.cn.CloseAsync();
            this.com.Parameters.Clear();
            return registros;
        }

        public async Task<string> GetMediaSalarioByOficioAsync(string oficio)
        {
            string sql = "SELECT AVG(SALARIO) FROM EMP WHERE OFICIO=@oficio";
            this.com.Parameters.AddWithValue("@oficio", oficio);
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();

            string media="";
            while (await this.reader.ReadAsync())
            {
              media = this.reader[0].ToString();
                
            }
            await this.reader.CloseAsync();
            this.com.Parameters.Clear();
            await this.cn.CloseAsync();
            return media;
        }
        public async Task<string> GetSumaSalarioByOficioAsync(string oficio)
        {
            string sql = "SELECT SUM(SALARIO) FROM EMP WHERE OFICIO=@oficio";
            this.com.Parameters.AddWithValue("@oficio", oficio);
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();

            string media = "";
            while (await this.reader.ReadAsync())
            {
                media = this.reader[0].ToString();

            }
            await this.reader.CloseAsync();
            this.com.Parameters.Clear();
            await this.cn.CloseAsync();
            return media;
        }
        public async Task<string> GetMaxSalarioByOficioAsync(string oficio)
        {
            string sql = "SELECT MAX(SALARIO) FROM EMP WHERE OFICIO=@oficio";
            this.com.Parameters.AddWithValue("@oficio", oficio);
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();

            string media = "";
            while (await this.reader.ReadAsync())
            {
                media = this.reader[0].ToString();

            }
            await this.reader.CloseAsync();
            this.com.Parameters.Clear();
            await this.cn.CloseAsync();
            return media;
        }
    }

  
}
