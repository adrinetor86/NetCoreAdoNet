using Microsoft.Data.SqlClient;
using NetCoreAdoNet.Models;
using NetCoreAdoNet.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

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
//	SELECT @suma= SUM(SALARIO), @media = AVG(SALARIO),
//    @personas = COUNT(EMP_NO) FROM EMP 
//	WHERE DEPT_NO = @iddept
//GO
#endregion
namespace NetCoreAdoNet
{
    public partial class Form13ParametrosSalida : Form
    {
        RepositoryParametersOut repo;

        public Form13ParametrosSalida()
        {
            InitializeComponent();
            this.repo = new RepositoryParametersOut();
            this.LoadEmpleados();
        }

        private async Task LoadEmpleados()
        {
            List<string> departamentos = await this.repo.GetDepartamentosAsync();
            this.cbDepartamentos.Items.Clear();
            foreach (string nombre in departamentos)
            {
                this.cbDepartamentos.Items.Add(nombre);
            }
        }
        private async void btnMostrar_Click(object sender, EventArgs e)
        {
            string nombre = this.cbDepartamentos.SelectedItem.ToString();
            EmpleadosParametersOut model = await this.repo.GetEmpleadosModelAsync(nombre);
            this.lstEmpleados.Items.Clear();
            foreach(string ape in model.Apellidos)
            {
                this.lstEmpleados.Items.Add(ape);
            }
            this.txtSuma.Text = model.SumaSalarial.ToString();
            this.txtMedia.Text = model.MediaSalarial.ToString();
            this.txtPersonas.Text = model.Personas.ToString();
        }
    }
}
