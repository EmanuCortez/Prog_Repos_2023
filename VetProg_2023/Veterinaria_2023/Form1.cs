namespace Veterinaria_2023
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void carpetasM�dicasToolStripMenuItem_Click(object sender, EventArgs e)
        {
             FrmParteMedico Nuevo = new FrmParteMedico();
             Nuevo.ShowDialog();
        }
    }
}