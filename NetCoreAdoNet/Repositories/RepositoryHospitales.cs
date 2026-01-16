using Microsoft.Data.SqlClient;
using NetCoreAdoNet.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace NetCoreAdoNet.Repositories
{
   
    public class RepositoryHospitales
    {
        private SqlConnection cn;
        private SqlCommand com;
        private SqlDataReader reader;

        public RepositoryHospitales()
        {
            string connectionString = @"Data Source=LOCALHOST\DEVELOPER;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Encrypt=True;Trust Server Certificate=True";
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
        }

        public async Task<List<Hospital>> GetHospitalesAsync()
        {
            string sql = "SELECT * FROM HOSPITAL";
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;

            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();
    
            List<Hospital> hospitales = new List<Hospital>();
            hospitales.Clear();
            while (await reader.ReadAsync())
            {
                Hospital hosp = new Hospital();
                hosp.Hospital_Cod = int.Parse(this.reader["HOSPITAL_COD"].ToString());
                hosp.Nombre= this.reader["NOMBRE"].ToString();
                hosp.Direccion = this.reader["DIRECCION"].ToString();
                hosp.Telefono = this.reader["TELEFONO"].ToString();
                hosp.Num_Camas = int.Parse(this.reader["NUM_CAMA"].ToString());

                hospitales.Add(hosp);

            }
            await this.reader.CloseAsync();
            await this.cn.CloseAsync();
            
            return hospitales;
        }

        public async Task InsertHospitalesAsync(int idHosp,string nombre,string direccion,string telefono,int numCamas)
        {
            string sql = "INSERT INTO HOSPITAL VALUES(@id,@nombre,@dir,@tel,@camas)";

            this.com.Parameters.AddWithValue("@id",idHosp);
            this.com.Parameters.AddWithValue("@nombre",nombre);
            this.com.Parameters.AddWithValue("@dir",direccion);
            this.com.Parameters.AddWithValue("@tel",telefono);
            this.com.Parameters.AddWithValue("@camas",numCamas);
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;

            await this.cn.OpenAsync();
            await this.com.ExecuteNonQueryAsync();

            await this.cn.CloseAsync();
            this.com.Parameters.Clear();
            
        }


        public async Task UpdateHospitalAsync(int idHosp, string nombre, string direccion, string telefono, int numCamas)
        {
            string sql = "UPDATE HOSPITAL SET HOSPITAL_COD=@id, NOMBRE=@nombre," +
                "DIRECCION=@dir, TELEFONO=@tel, NUM_CAMA=@camas " +
                "WHERE HOSPITAL_COD=@id";
            this.com.Parameters.AddWithValue("@id", idHosp);
            this.com.Parameters.AddWithValue("@nombre", nombre);
            this.com.Parameters.AddWithValue("@dir", direccion);
            this.com.Parameters.AddWithValue("@tel", telefono);
            this.com.Parameters.AddWithValue("@camas", numCamas);

            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;

            await this.cn.OpenAsync();
            await this.com.ExecuteNonQueryAsync();
            await this.cn.CloseAsync();
            this.com.Parameters.Clear();
        }
    }

   
}
