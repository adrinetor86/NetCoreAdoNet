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
    public partial class Form10UpdateEmpleadosOficio : Form
    {
        RepositoryUpdateEmpleados repo;
        public Form10UpdateEmpleadosOficio()
        {
            InitializeComponent();
            this.repo = new RepositoryUpdateEmpleados();
            this.LoadOficios();
        }

        private async Task LoadOficios()
        {
            List<string> oficios = await this.repo.GetOficiosAsync();
            this.lstOficios.Items.Clear();
            foreach (string ofi in oficios)
            {
                this.lstOficios.Items.Add(ofi);
            }

        }
        private async void lstOficios_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = this.lstOficios.SelectedIndex;
            if(index != -1)
            {
                string oficio = this.lstOficios.SelectedItem.ToString();
                List<string> apellidos = await this.repo.GetEmpleadosByOficioAsync(oficio);
                this.lstEmpleados.Items.Clear();

                foreach (string ape in apellidos)
                {
                    this.lstEmpleados.Items.Add(ape);
                }
                 
                this.lblSumaSalarial.Text= "SUMA SALARIAL: "+ await this.repo.GetSumaSalarioByOficioAsync(oficio);
                this.lblMedia.Text= "MEDIA SALARIAL: " + await this.repo.GetMediaSalarioByOficioAsync(oficio);
                this.lblMax.Text= "MAXIMO SALARIO: " + await this.repo.GetMaxSalarioByOficioAsync(oficio);
            }
        }

        private async void btnIncremento_Click(object sender, EventArgs e)
        {
            int incremento = int.Parse(this.txtSubida.Text);
            string oficio = this.lstOficios.SelectedItem.ToString();
            int registros = await this.repo.UpdateSalarioEmpleadosAsync(oficio,incremento);
            
            MessageBox.Show("Nº registros: " + registros);
        }
    }
}
