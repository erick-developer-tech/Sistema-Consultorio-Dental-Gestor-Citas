using Presentacion.Citas;
using Presentacion.Pacientes;
using Presentacion.Servicios;
using Presentacion.Usuarios;

namespace Presentacion
{
    public partial class MenuNavegacion : Form
    {
        public MenuNavegacion(string nombre, string apellidos, string rol)
        {
            InitializeComponent();
            if (rol.Equals("Administrador")) 
            {
                usuariosToolStripMenuItem.Enabled = true;
                pacientesToolStripMenuItem.Enabled = true;
                citasToolStripMenuItem.Enabled = true;
                recetasToolStripMenuItem.Enabled = true;
            }
            else if (rol.Equals("Dentista"))
            {
                usuariosToolStripMenuItem.Enabled = false;
                pacientesToolStripMenuItem.Enabled = true;
                citasToolStripMenuItem.Enabled = true;
                recetasToolStripMenuItem.Enabled = false;
            }
            else if (rol.Equals("Asistente"))
            {
                usuariosToolStripMenuItem.Enabled = false;
                pacientesToolStripMenuItem.Enabled = true;
                citasToolStripMenuItem.Enabled = true;
                recetasToolStripMenuItem.Enabled = false;
            }
        }

        private void serviciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null) 
            {
                this.ActiveMdiChild.Close();
            }
            FrmServicio frm = new FrmServicio();
            frm.MdiParent = this;
            frm.Show(); 
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }
            FrmUsuarios frm = new FrmUsuarios();
            frm.MdiParent = this;
            frm.Show();
        }

        private void pacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }
            FrmPaciente frm = new FrmPaciente();
            frm.MdiParent = this;
            frm.Show();
        }

        private void citasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }
            FrmCitas frm = new FrmCitas();
            frm.MdiParent = this;
            frm.Show();
        }

        private void recetasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Login login = new Login();
            login.Show();
        }
    }
}
