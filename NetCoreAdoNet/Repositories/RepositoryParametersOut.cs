using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using NetCoreAdoNet.Helpers;
using NetCoreAdoNet.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

#region PROCEDIMIENTOS ALMACENADOS
//create procedure SP_ALL_DEPARTAMENTOS
//AS
//	SELECT * FROM DEPT
//GO
//create procedure SP_EMPLEADOS_DEPARTAMENTOS_OUT
//(@nombre nvarchar(50),
//@suma int OUT,
//@media int OUT,
//@personas int OUT)
//AS
//	declare @iddept int
//	select @iddept = DEPT_NO FROM DEPT
//	WHERE DNOMBRE=@nombre
//	--LA CONSULTA DEL PROCEDIMIENTO
//	SELECT * FROM EMP WHERE DEPT_NO=@iddept
//	--RELLENAMOS LAS VARIABLES D SALIDA
//	SELECT @suma= isnull(SUM(SALARIO),0), @media = isnull(AVG(SALARIO),0),
//    @personas = COUNT(EMP_NO) FROM EMP 
//	WHERE DEPT_NO = @iddept
//GO
#endregion


namespace NetCoreAdoNet.Repositories
{
    public class RepositoryParametersOut
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;
        
    public RepositoryParametersOut()
        {
            IConfigurationRoot configuration =
                HelperConfiguration.GetConfiguration();

            string connectionString = configuration.GetConnectionString("SqlLocalTajamar");
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
        }

    public async Task<List<string>> GetDepartamentosAsync()
        {
            string sql = "SP_ALL_DEPARTAMENTOS";
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();

            this.reader = await this.com.ExecuteReaderAsync();
            List<string> departamentos = new List<string>();
            while (await this.reader.ReadAsync())
            {
                string nombre = this.reader["DNOMBRE"].ToString();

               departamentos.Add(nombre);
            }
            await this.reader.CloseAsync();
            await this.cn.CloseAsync();
            return departamentos;
        }

       
        public async Task<EmpleadosParametersOut> 
            GetEmpleadosModelAsync(string nombreDepartamento)
        {
            string sql = "SP_EMPLEADOS_DEPARTAMENTOS_OUT";
            //TENEMOS UN PARAMETRO DE ENTRADA, POR DEFECTO, TODOS
            //SON DE ENTRADA.
            this.com.Parameters.AddWithValue("@nombre", nombreDepartamento);
            //LOS PARAMETROS DE SALIDA DEBEMOS CREARLOS DE FORMA EXPLICITA
            //EN ESTE EJEMPLO NO HEMOS PUESTO VALORES POR DEFECTO
            SqlParameter pamSuma = new SqlParameter();
            SqlParameter pamMedia = new SqlParameter();
            SqlParameter pamPersonas = new SqlParameter();

            pamSuma.ParameterName = "@suma";
            pamMedia.ParameterName = "@media";
            pamPersonas.ParameterName = "@personas";

            pamSuma.Value = 0;
            pamMedia.Value = 0;
            pamPersonas.Value = 0;

            pamSuma.Direction = ParameterDirection.Output;
            pamMedia.Direction = ParameterDirection.Output;
            pamPersonas.Direction = ParameterDirection.Output;

            this.com.Parameters.Add(pamSuma);
            this.com.Parameters.Add(pamMedia);
            this.com.Parameters.Add(pamPersonas);

            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();

            EmpleadosParametersOut model = new EmpleadosParametersOut();
            model.Apellidos = new List<string>();

            while (await this.reader.ReadAsync())
            {
                string apellido = this.reader["APELLIDO"].ToString();
                model.Apellidos.Add(apellido);
            }

            //LIBERAMOS LOS RECURSOS DE LA CONEXION Y DEMAS
            await this.reader.CloseAsync();
            model.SumaSalarial = int.Parse(pamSuma.Value.ToString());
            model.MediaSalarial = int.Parse(pamMedia.Value.ToString());
            model.Personas = int.Parse(pamPersonas.Value.ToString());

            await this.cn.CloseAsync();

            //LIBERAMOS LOS RECURSOS
            this.com.Parameters.Clear();
            return model;

        }


    }
}
