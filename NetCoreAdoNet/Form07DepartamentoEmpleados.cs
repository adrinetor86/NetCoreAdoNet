using NetCoreAdoNet.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreAdoNet
{
    public partial class Form07DepartamentoEmpleados : Form
    {
        RepositoryDepartamentoEmpleados repo;
        public Form07DepartamentoEmpleados()
        {
            InitializeComponent();
            this.repo = new RepositoryDepartamentoEmpleados();
            this.loadDepartamentos();
        }

        private async void loadDepartamentos()
        {
            List<string> departamentos = await this.repo.GetDepartamentosAsync();

            this.lstDepartamentos.Items.Clear();

            foreach (string dept in departamentos)
            {
                this.lstDepartamentos.Items.Add(dept);
            }
        }
        private async void loadEmpleados(string dept_nombre)
        {
            List<string> empleados = await this.repo.GetEmpleadosAsync(dept_nombre);

            this.lstEmpleados.Items.Clear();

            foreach (string emp in empleados)
            {
                this.lstEmpleados.Items.Add(emp);
            }
        }
        //EN ESTOS METODOS DELEGADOS(CLICK BOTON,MOUSE ETC) SIEMPRE ES VOID
        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            string empleado =this.lstEmpleados.SelectedItem.ToString();
         
            await this.repo.DeleteEmpleadoAsync(empleado);
            this.loadEmpleados(this.lstDepartamentos.SelectedItem.ToString());
        }

        private  void lstDepartamentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.lstDepartamentos.SelectedIndex != -1)
            {
                string dept = this.lstDepartamentos.SelectedItem.ToString();
                this.loadEmpleados(dept);
            }
         
        }
    }
}
