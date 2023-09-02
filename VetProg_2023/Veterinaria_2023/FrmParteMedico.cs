using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Veterinaria_2023.Entidades.AccesoDatos;
using Veterinaria_2023.Entidades;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Veterinaria_2023
{
    public partial class FrmParteMedico : Form
    {
        CarpetaMedica nuevo;
        List<Mascota> listaMascotas;
        private ProductServices service;

        public FrmParteMedico()
        {
            InitializeComponent();

            listaMascotas = new List<Mascota>();
            service = new ProductServices();
            nuevo = new CarpetaMedica();
        }

        private void FrmParteMedico_Load(object sender, EventArgs e)
        {
            CargarCombo(cboTipo, "Tipos");
            CargarLista(lstMascotas, "Mascotas");
            Habilitar(true);

            lblCarpeta.Text = lblCarpeta.Text + " " + service.getCarpeta();
        }

        private void CargarLista(ListBox lista, string v)
        {
            listaMascotas.Clear();
            //traer  datos de BD
            lista.Items.Clear();
            listaMascotas = service.getAll();
            //lista.DataSource= listaProductos;     

            lista.Items.AddRange(listaMascotas.ToArray());
            /*for (int i = 0; i < listaProductos.Count; i++)
            {
                lista.Items.Add(listaProductos[i]);
            }*/
        }

        private void CargarCombo(ComboBox combo, string v)
        {
            // DataTable tabla = oBD.ConsultarBD("SELECT * FROM " + nombreTabla + " ORDER BY 2");
            DataTable tabla = service.getTipos();//oBD.ConsultarTabla(nombreTabla);
            combo.DataSource = tabla;
            combo.ValueMember = tabla.Columns[0].ColumnName;    //"idMarca"
            combo.DisplayMember = tabla.Columns[1].ColumnName;  //"nombreMarca"
            combo.DropDownStyle = ComboBoxStyle.DropDownList;   //no permite edición, solo selección
        }


        private void Habilitar(bool x)
        {
            txtNombrD.Enabled = !x;
            txtNombreM.Enabled = !x;
            cboTipo.Enabled = !x;
            txtCodigoD.Enabled = !x;
            btnAgregarD.Enabled = !x;
            btnAgregarM.Enabled = !x;
            btnEliminarM.Enabled = !x;
            rbdFemenino.Enabled = !x;
            rbdMasculino.Enabled = !x;
        }

        private void lstMascotas_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostrarCampos(lstMascotas.SelectedIndex);
        }

        private void MostrarCampos(int i)
        {
            txtCodigoD.Text = listaMascotas[i].Duenio.Codigo.ToString();
            txtNombrD.Text = listaMascotas[i].Duenio.Nombre.ToString();

            txtNombreM.Text = listaMascotas[i].Nombre.ToString();
            cboTipo.SelectedValue = listaMascotas[i].Tipo.ToString();

            if (listaMascotas[i].Sexo == "M")
            {
                rbdMasculino.Checked = true;
            }
            else
            {
                rbdFemenino.Checked = true;
            }
        }

        private void btnAgregarD_Click(object sender, EventArgs e)
        {
            if (lstMascotas.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar la mascota a la cual desea agregar una descripcion", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtDescripcion.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtDescripcion.Text))
            {
                MessageBox.Show("Debe ingresar una descripcion", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtDescripcion.Focus();
                return;
            }

            if (dtpDescripcion.Value < DateTime.MinValue)
            {
                MessageBox.Show("Debe seleccionar una fecha coherente", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtDescripcion.Focus();
                return;
            }

            DataRowView item = (DataRowView)lstMascotas.SelectedItem;

            int id = Convert.ToInt32(item.Row.ItemArray[0]);
            string descripcion = item.Row.ItemArray[1].ToString();
            DateTime dt = Convert.ToDateTime(item.Row[2].ToString());

            Mascota m = (Mascota)lstMascotas.SelectedItem;

            Atencion atencion = new Atencion(m, descripcion);

            nuevo.AgregarAtencion(atencion);
            dgbMascotas.Rows.Add(atencion.Descripcion, dtpDescripcion, "Quitar");
        }
    }
}
