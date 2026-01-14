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
    public partial class Form06UpdateSalas : Form
    {

        RepositorySalas repo;
        public Form06UpdateSalas()
        {
            InitializeComponent();
            this.repo = new RepositorySalas();
            this.loadSalas();
        }

       //AQUI NO SE PONE TASK
        private async void loadSalas()
        {
            List<string> salas = await this.repo.GetNombreSalasAsync();
            this.lstSalas.Items.Clear();

            foreach (string nombre in salas)
            {
                this.lstSalas.Items.Add(nombre);
            }
        }
        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            string oldName = this.lstSalas.SelectedItem.ToString();
            string newName = this.txtNombre.Text;
            int registros = await this.repo.UpdateSalaAsync(newName, oldName);
            MessageBox.Show("Modificados: "+ registros);
            this.loadSalas();
        }
    }
}
