using Negocio;
using WinFormApi.Models;

namespace ClienteServicios
{
    public partial class AbmAlumnos : Form
    {
        private Task<IEnumerable<Alumno>>? l;
        public AbmAlumnos()
        {
            InitializeComponent();

        }
        public IEnumerable<Alumno> getTabla()
        {
            l = AlumnoNegocio.GetAll();
            return l.Result;
        }
        public async void cargarTabla()
        {

            Task<IEnumerable<Alumno>> task = new Task<IEnumerable<Alumno>>(getTabla);
            task.Start();
            dataGridView1.DataSource = await task;
        }

        private void AbmAlumnos_Load(object sender, EventArgs e)
        {
            cargarTabla();
        }

        private async void btnEnviar_Click(object sender, EventArgs e)
        {
            Alumno a = new Alumno();
            a.DNI = txtDNI.Text;
            a.ApellidoNombre = txtApellidoNombre.Text;
            a.Email = txtEmail.Text;
            a.FechaNacimiento = dtpFechaNacimiento.Value;
            a.NotaPromedio = Convert.ToDecimal(txtNotaPromedio.Text);
            await AlumnoNegocio.Add(a);
        }
    }
}