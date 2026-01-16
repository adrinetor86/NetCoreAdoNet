using NetCoreAdoNet.Models;
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
    public partial class Form09CrudHospital : Form
    {
        RepositoryHospitales repo;
        public Form09CrudHospital()
        {
            InitializeComponent();
            this.repo = new RepositoryHospitales();
            this.LoadHospitales();
        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        public async Task LoadHospitales()
        {
            List<Hospital> hospitales = new List<Hospital>();
            hospitales = await this.repo.GetHospitalesAsync();
            this.lstHospitales.Items.Clear();
            foreach (Hospital hosp in hospitales)
            {
                this.lstHospitales.Items.Add(
                 hosp.Hospital_Cod + " - " +
                 hosp.Nombre + " - " +
                 hosp.Direccion + " - " +
                 hosp.Telefono + " - " +
                 hosp.Num_Camas

                 );
            }

        }

        private async void btnInsertar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(this.txtId.Text);
            string nombre = this.txtNombre.Text;
            string direccion = this.txtDir.Text;
            string telefono = this.txtTel.Text;
            int camas = int.Parse(this.txtCamas.Text);

            await this.repo.InsertHospitalesAsync(id, nombre, direccion, telefono, camas);
            await this.LoadHospitales();
        }

        private async void btnEdit_Click(object sender, EventArgs e)
        {
            int id = int.Parse(this.txtId.Text);
            string nombre = this.txtNombre.Text;
            string direccion = this.txtDir.Text;
            string telefono = this.txtTel.Text;
            int camas = int.Parse(this.txtCamas.Text);
            await this.repo.UpdateHospitalAsync(id, nombre, direccion, telefono, camas);
            await this.LoadHospitales();
        }

        private async void lstHospitales_SelectedIndexChanged(object sender, EventArgs e)
        {
             //this.lstHospitales.SelectedIndex.Text;
            //Hospital hosp = new Hospital();
           //hosp = this.lstHospitales.SelectedIndex.ToString();
          //this.repo.UpdateHospitalAsync();
        }
    }
}
