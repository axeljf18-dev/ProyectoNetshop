namespace ProyectoNetshop
{
    public partial class principal : Form
    {
        public principal()
        {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void principal_Load(object sender, EventArgs e)
        {

        }

        private void AbrirFormularioEnPanel(object formulario)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = formulario as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }

        // Reemplaza la línea en btnUsuarios_Click:
        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new formularios.usuarios());
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new formularios.Reportes());
        }

        private void btnVentas_Click_1(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new formularios.ventas());
        }
    }
}
