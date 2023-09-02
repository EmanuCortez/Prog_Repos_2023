namespace Veterinaria_2023
{
    partial class FrmParteMedico
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cboTipo = new ComboBox();
            lblTipo = new Label();
            txtCodigoD = new TextBox();
            lblCodigo = new Label();
            dgbMascotas = new DataGridView();
            codigoDueño = new DataGridViewTextBoxColumn();
            descripcionMascota = new DataGridViewTextBoxColumn();
            fechaAtencion = new DataGridViewTextBoxColumn();
            Accion = new DataGridViewButtonColumn();
            rbdFemenino = new RadioButton();
            rbdMasculino = new RadioButton();
            txtNombreM = new TextBox();
            lblNombreM = new Label();
            lblMascota = new Label();
            txtNombrD = new TextBox();
            lblNombreD = new Label();
            lblSexo = new Label();
            lblDuenio = new Label();
            lblCarpeta = new Label();
            lstMascotas = new ListBox();
            dtpDescripcion = new DateTimePicker();
            txtDescripcion = new TextBox();
            label1 = new Label();
            btnAgregarD = new Button();
            btnEliminarM = new Button();
            btnAgregarM = new Button();
            btnEditar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgbMascotas).BeginInit();
            SuspendLayout();
            // 
            // cboTipo
            // 
            cboTipo.FormattingEnabled = true;
            cboTipo.Location = new Point(556, 133);
            cboTipo.Name = "cboTipo";
            cboTipo.Size = new Size(121, 23);
            cboTipo.TabIndex = 29;
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(500, 136);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(30, 15);
            lblTipo.TabIndex = 28;
            lblTipo.Text = "Tipo";
            // 
            // txtCodigoD
            // 
            txtCodigoD.Location = new Point(117, 91);
            txtCodigoD.Name = "txtCodigoD";
            txtCodigoD.Size = new Size(187, 23);
            txtCodigoD.TabIndex = 27;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(60, 94);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(46, 15);
            lblCodigo.TabIndex = 26;
            lblCodigo.Text = "Código";
            // 
            // dgbMascotas
            // 
            dgbMascotas.AllowUserToAddRows = false;
            dgbMascotas.AllowUserToDeleteRows = false;
            dgbMascotas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgbMascotas.Columns.AddRange(new DataGridViewColumn[] { codigoDueño, descripcionMascota, fechaAtencion, Accion });
            dgbMascotas.Location = new Point(17, 284);
            dgbMascotas.Name = "dgbMascotas";
            dgbMascotas.ReadOnly = true;
            dgbMascotas.RowTemplate.Height = 25;
            dgbMascotas.Size = new Size(767, 125);
            dgbMascotas.TabIndex = 25;
            // 
            // codigoDueño
            // 
            codigoDueño.HeaderText = "Codigo";
            codigoDueño.Name = "codigoDueño";
            codigoDueño.ReadOnly = true;
            codigoDueño.Visible = false;
            // 
            // descripcionMascota
            // 
            descripcionMascota.HeaderText = "Descripción/Observaciones";
            descripcionMascota.Name = "descripcionMascota";
            descripcionMascota.ReadOnly = true;
            descripcionMascota.Width = 504;
            // 
            // fechaAtencion
            // 
            fechaAtencion.HeaderText = "Fecha";
            fechaAtencion.Name = "fechaAtencion";
            fechaAtencion.ReadOnly = true;
            fechaAtencion.Width = 120;
            // 
            // Accion
            // 
            Accion.HeaderText = "Accion";
            Accion.Name = "Accion";
            Accion.ReadOnly = true;
            // 
            // rbdFemenino
            // 
            rbdFemenino.AutoSize = true;
            rbdFemenino.Location = new Point(555, 203);
            rbdFemenino.Name = "rbdFemenino";
            rbdFemenino.Size = new Size(78, 19);
            rbdFemenino.TabIndex = 24;
            rbdFemenino.TabStop = true;
            rbdFemenino.Text = "Femenino";
            rbdFemenino.UseVisualStyleBackColor = true;
            // 
            // rbdMasculino
            // 
            rbdMasculino.AutoSize = true;
            rbdMasculino.Location = new Point(555, 178);
            rbdMasculino.Name = "rbdMasculino";
            rbdMasculino.Size = new Size(80, 19);
            rbdMasculino.TabIndex = 23;
            rbdMasculino.TabStop = true;
            rbdMasculino.Text = "Masculino";
            rbdMasculino.UseVisualStyleBackColor = true;
            // 
            // txtNombreM
            // 
            txtNombreM.Location = new Point(556, 91);
            txtNombreM.Name = "txtNombreM";
            txtNombreM.Size = new Size(187, 23);
            txtNombreM.TabIndex = 22;
            // 
            // lblNombreM
            // 
            lblNombreM.AutoSize = true;
            lblNombreM.Location = new Point(499, 94);
            lblNombreM.Name = "lblNombreM";
            lblNombreM.Size = new Size(51, 15);
            lblNombreM.TabIndex = 21;
            lblNombreM.Text = "Nombre";
            // 
            // lblMascota
            // 
            lblMascota.AutoSize = true;
            lblMascota.BackColor = SystemColors.ActiveBorder;
            lblMascota.FlatStyle = FlatStyle.Flat;
            lblMascota.Location = new Point(478, 67);
            lblMascota.Name = "lblMascota";
            lblMascota.Size = new Size(52, 15);
            lblMascota.TabIndex = 20;
            lblMascota.Text = "Mascota";
            // 
            // txtNombrD
            // 
            txtNombrD.Location = new Point(117, 136);
            txtNombrD.Name = "txtNombrD";
            txtNombrD.Size = new Size(187, 23);
            txtNombrD.TabIndex = 19;
            // 
            // lblNombreD
            // 
            lblNombreD.AutoSize = true;
            lblNombreD.Location = new Point(60, 139);
            lblNombreD.Name = "lblNombreD";
            lblNombreD.Size = new Size(51, 15);
            lblNombreD.TabIndex = 18;
            lblNombreD.Text = "Nombre";
            // 
            // lblSexo
            // 
            lblSexo.AutoSize = true;
            lblSexo.Location = new Point(500, 178);
            lblSexo.Name = "lblSexo";
            lblSexo.Size = new Size(32, 15);
            lblSexo.TabIndex = 17;
            lblSexo.Text = "Sexo";
            // 
            // lblDuenio
            // 
            lblDuenio.AutoSize = true;
            lblDuenio.BackColor = SystemColors.ActiveBorder;
            lblDuenio.FlatStyle = FlatStyle.Flat;
            lblDuenio.Location = new Point(42, 67);
            lblDuenio.Name = "lblDuenio";
            lblDuenio.Size = new Size(42, 15);
            lblDuenio.TabIndex = 16;
            lblDuenio.Text = "Dueño";
            // 
            // lblCarpeta
            // 
            lblCarpeta.AutoSize = true;
            lblCarpeta.Location = new Point(117, 11);
            lblCarpeta.Name = "lblCarpeta";
            lblCarpeta.Size = new Size(65, 15);
            lblCarpeta.TabIndex = 15;
            lblCarpeta.Text = "Carpeta Nº";
            // 
            // lstMascotas
            // 
            lstMascotas.FormattingEnabled = true;
            lstMascotas.ItemHeight = 15;
            lstMascotas.Location = new Point(831, 11);
            lstMascotas.Name = "lstMascotas";
            lstMascotas.Size = new Size(223, 349);
            lstMascotas.TabIndex = 30;
            lstMascotas.SelectedIndexChanged += lstMascotas_SelectedIndexChanged;
            // 
            // dtpDescripcion
            // 
            dtpDescripcion.Location = new Point(555, 255);
            dtpDescripcion.Name = "dtpDescripcion";
            dtpDescripcion.Size = new Size(227, 23);
            dtpDescripcion.TabIndex = 31;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(17, 255);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(532, 23);
            txtDescripcion.TabIndex = 32;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 237);
            label1.Name = "label1";
            label1.Size = new Size(113, 15);
            label1.TabIndex = 33;
            label1.Text = "Ingresar descripción";
            // 
            // btnAgregarD
            // 
            btnAgregarD.Location = new Point(635, 415);
            btnAgregarD.Name = "btnAgregarD";
            btnAgregarD.Size = new Size(149, 23);
            btnAgregarD.TabIndex = 34;
            btnAgregarD.Text = "Agregar descripcion";
            btnAgregarD.UseVisualStyleBackColor = true;
            btnAgregarD.Click += btnAgregarD_Click;
            // 
            // btnEliminarM
            // 
            btnEliminarM.Location = new Point(993, 366);
            btnEliminarM.Name = "btnEliminarM";
            btnEliminarM.Size = new Size(61, 23);
            btnEliminarM.TabIndex = 35;
            btnEliminarM.Text = "Eliminar";
            btnEliminarM.UseVisualStyleBackColor = true;
            // 
            // btnAgregarM
            // 
            btnAgregarM.Location = new Point(859, 366);
            btnAgregarM.Name = "btnAgregarM";
            btnAgregarM.Size = new Size(61, 23);
            btnAgregarM.TabIndex = 36;
            btnAgregarM.Text = "Agregar";
            btnAgregarM.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(926, 366);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(61, 23);
            btnEditar.TabIndex = 37;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // FrmParteMedico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1076, 450);
            Controls.Add(btnEditar);
            Controls.Add(btnAgregarM);
            Controls.Add(btnEliminarM);
            Controls.Add(btnAgregarD);
            Controls.Add(label1);
            Controls.Add(txtDescripcion);
            Controls.Add(dtpDescripcion);
            Controls.Add(lstMascotas);
            Controls.Add(cboTipo);
            Controls.Add(lblTipo);
            Controls.Add(txtCodigoD);
            Controls.Add(lblCodigo);
            Controls.Add(dgbMascotas);
            Controls.Add(rbdFemenino);
            Controls.Add(rbdMasculino);
            Controls.Add(txtNombreM);
            Controls.Add(lblNombreM);
            Controls.Add(lblMascota);
            Controls.Add(txtNombrD);
            Controls.Add(lblNombreD);
            Controls.Add(lblSexo);
            Controls.Add(lblDuenio);
            Controls.Add(lblCarpeta);
            Name = "FrmParteMedico";
            Text = "FrmParteMedico";
            Load += FrmParteMedico_Load;
            ((System.ComponentModel.ISupportInitialize)dgbMascotas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboTipo;
        private Label lblTipo;
        private TextBox txtCodigoD;
        private Label lblCodigo;
        private DataGridView dgbMascotas;
        private RadioButton rbdFemenino;
        private RadioButton rbdMasculino;
        private TextBox txtNombreM;
        private Label lblNombreM;
        private Label lblMascota;
        private TextBox txtNombrD;
        private Label lblNombreD;
        private Label lblSexo;
        private Label lblDuenio;
        private Label lblCarpeta;
        private ListBox lstMascotas;
        private DateTimePicker dtpDescripcion;
        private TextBox txtDescripcion;
        private Label label1;
        private Button btnAgregarD;
        private Button btnEliminarM;
        private Button btnAgregarM;
        private DataGridViewTextBoxColumn codigoDueño;
        private DataGridViewTextBoxColumn descripcionMascota;
        private DataGridViewTextBoxColumn fechaAtencion;
        private DataGridViewButtonColumn Accion;
        private Button btnEditar;
    }
}