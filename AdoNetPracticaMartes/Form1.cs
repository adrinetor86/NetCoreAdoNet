using AdoNetPracticaMartes.Models;
using AdoNetPracticaMartes.Repository;

namespace AdoNetPracticaMartes
{
    public partial class Form1 : Form
    {
        RepositoryEmpleadosHospital repo;
        public Form1()
        {
            InitializeComponent();
            this.repo = new RepositoryEmpleadosHospital();
            this.LoadHospitalesAsync();
        }

        public async Task LoadHospitalesAsync()
        {
            List<Hospital> hospitales = new List<Hospital>();
            hospitales = await this.repo.GetHospitalesAsync();
            this.cbHospital.Items.Clear();
            foreach (Hospital hosp in hospitales)
            {
                this.cbHospital.Items.Add(hosp.Nombre);
            }
        }

        private async void cbHospital_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nombreHospital = this.cbHospital.SelectedItem.ToString();

            List<Empleado> empleados = new List<Empleado>();

            empleados =await this.repo.GetEmpleadosHospitalAsync(nombreHospital);

            this.lstEmpleados.Items.Clear();

            foreach (Empleado emp in empleados)
            {
                this.lstEmpleados.Items.Add(emp.Apellido +" - "+emp.Funcion +" - "+emp.Salario);
           
            }
            await this.GetSalariosAsync();

        }
        public async Task GetSalariosAsync()
        {
            string nombreHospital = this.cbHospital.SelectedItem.ToString();
            Salario salarios = new Salario();

            salarios = await this.repo.GetMediasSalariosAsync(nombreHospital);
           

            this.textBox1.Text = salarios.Suma.ToString();
            this.textBox2.Text = salarios.Media.ToString();
            this.textBox3.Text = salarios.Personas.ToString();
        } 
    }
}
