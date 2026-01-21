using AdoNetPracticaFinal.Models;
using AdoNetPracticaFinal.Repositories;
using Microsoft.Win32;
using System;
using System.Reflection;

namespace AdoNetPracticaFinal
{
    public partial class Form1 : Form
    {

        RepositoryDepartamentos repo;
        public Form1()
        {
            InitializeComponent();
            this.repo = new RepositoryDepartamentos();
            this.LoadDepartamentosAsync();
        }

        private async Task LoadDepartamentosAsync()
        {
            List<Departamento> departamentos = new List<Departamento>();
            departamentos = await this.repo.GetDepartamentosAsync();
            this.cbDepartamentos.Items.Clear();
            foreach (Departamento dept in departamentos)
            {
                this.cbDepartamentos.Items.Add(dept.Nombre);

            }
        }
        private async void btnInsertar_Click(object sender, EventArgs e)
        {
            int idDept = int.Parse(this.txtId.Text);
            string nombreDept = this.txtNombre.Text;
            string localidad = this.txtLocalidad.Text;
        
         int registros=  await this.repo.InsertDepartamentosAsync(idDept,nombreDept,localidad);
            MessageBox.Show(registros + "modificados");

            await this.LoadDepartamentosAsync();
        }

        private async void cbDepartamentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nombreDepartamento = this.cbDepartamentos.SelectedItem.ToString();

            List<Empleado> empleados = new List<Empleado>();
            empleados = await this.repo.GetEmpleadosDepartamentoAsync(nombreDepartamento);

            Departamento departamento = new Departamento();
            departamento = await this.repo.GetDatosDepartamentoByNameAsync(nombreDepartamento);
            
            this.lstEmpleados.Items.Clear();

         //   this.lstEmpleados.DataSource = null; // Limpiamos el origen previo
            foreach (Empleado emp in empleados)
            {
                int idEmp = emp.IdEmpleado;
                string apellido = emp.Apellido;
                this.lstEmpleados.Items.Add(emp.Apellido);
            }
            this.txtId.Text = departamento.IdDepartamento.ToString();
            this.txtNombre.Text = departamento.Nombre;
            this.txtLocalidad.Text = departamento.Localidad;

        }

        private async void lstEmpleados_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = this.lstEmpleados.SelectedIndex;
            if (index != -1)
            {
                string nombreEmpleado = this.lstEmpleados.SelectedItem.ToString();
                Empleado empleado = await this.repo.GetDatosEmpleadoByIdAsync(nombreEmpleado);

                this.txtApellido.Text = empleado.Apellido;
                this.txtOficio.Text = empleado.Oficio;
                this.txtSalario.Text = empleado.Salario.ToString();

            }

        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            string apellidoOld = this.lstEmpleados.SelectedItem.ToString();
            string apellidoEmp = this.txtApellido.Text;
            string oficio = this.txtOficio.Text;
            int salario = int.Parse(this.txtSalario.Text);


           int registros= await this.repo.UpdateEmpleadoAsync(apellidoOld, apellidoEmp, oficio, salario);
            MessageBox.Show(registros +"modificados");
           
        }
    }
}
