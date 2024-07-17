namespace PrototipoDos
{
    partial class VerEmpleados
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerEmpleados));
            label1 = new Label();
            GridEmpleados = new DataGridView();
            DarBaja = new DataGridViewLinkColumn();
            empleadoIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nombreDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            apellidoPaternoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            apellidoMaternoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            numeroCelularDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            correoEletronicoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            sexoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            statusIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            gestionPersonalEmpleadoBindingSource = new BindingSource(components);
            label2 = new Label();
            txtBuscar = new TextBox();
            btnBuscar = new Button();
            btnAgregar = new Button();
            btnRefrescar = new Button();
            toolTip1 = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)GridEmpleados).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gestionPersonalEmpleadoBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(611, 37);
            label1.Name = "label1";
            label1.Size = new Size(566, 45);
            label1.TabIndex = 0;
            label1.Text = "Ver información de los empleados ";
            toolTip1.SetToolTip(label1, resources.GetString("label1.ToolTip"));
            label1.Click += label1_Click;
            // 
            // GridEmpleados
            // 
            GridEmpleados.AutoGenerateColumns = false;
            GridEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridEmpleados.Columns.AddRange(new DataGridViewColumn[] { DarBaja, empleadoIdDataGridViewTextBoxColumn, nombreDataGridViewTextBoxColumn, apellidoPaternoDataGridViewTextBoxColumn, apellidoMaternoDataGridViewTextBoxColumn, numeroCelularDataGridViewTextBoxColumn, correoEletronicoDataGridViewTextBoxColumn, sexoDataGridViewTextBoxColumn, statusIdDataGridViewTextBoxColumn });
            GridEmpleados.DataSource = gestionPersonalEmpleadoBindingSource;
            GridEmpleados.Location = new Point(26, 244);
            GridEmpleados.Name = "GridEmpleados";
            GridEmpleados.RowHeadersWidth = 62;
            GridEmpleados.Size = new Size(1689, 390);
            GridEmpleados.TabIndex = 1;
            toolTip1.SetToolTip(GridEmpleados, "Para eliminar aun empleado es en DarBaja.");
            GridEmpleados.CellContentClick += GridEmpleados_CellContentClick_1;
            // 
            // DarBaja
            // 
            DarBaja.HeaderText = "DarBaja";
            DarBaja.MinimumWidth = 8;
            DarBaja.Name = "DarBaja";
            DarBaja.Text = "DarBaja";
            DarBaja.UseColumnTextForLinkValue = true;
            DarBaja.Width = 150;
            // 
            // empleadoIdDataGridViewTextBoxColumn
            // 
            empleadoIdDataGridViewTextBoxColumn.DataPropertyName = "EmpleadoId";
            empleadoIdDataGridViewTextBoxColumn.HeaderText = "EmpleadoId";
            empleadoIdDataGridViewTextBoxColumn.MinimumWidth = 20;
            empleadoIdDataGridViewTextBoxColumn.Name = "empleadoIdDataGridViewTextBoxColumn";
            empleadoIdDataGridViewTextBoxColumn.Width = 150;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            nombreDataGridViewTextBoxColumn.MinimumWidth = 8;
            nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            nombreDataGridViewTextBoxColumn.Width = 150;
            // 
            // apellidoPaternoDataGridViewTextBoxColumn
            // 
            apellidoPaternoDataGridViewTextBoxColumn.DataPropertyName = "ApellidoPaterno";
            apellidoPaternoDataGridViewTextBoxColumn.HeaderText = "ApellidoPaterno";
            apellidoPaternoDataGridViewTextBoxColumn.MinimumWidth = 8;
            apellidoPaternoDataGridViewTextBoxColumn.Name = "apellidoPaternoDataGridViewTextBoxColumn";
            apellidoPaternoDataGridViewTextBoxColumn.Width = 150;
            // 
            // apellidoMaternoDataGridViewTextBoxColumn
            // 
            apellidoMaternoDataGridViewTextBoxColumn.DataPropertyName = "ApellidoMaterno";
            apellidoMaternoDataGridViewTextBoxColumn.HeaderText = "ApellidoMaterno";
            apellidoMaternoDataGridViewTextBoxColumn.MinimumWidth = 8;
            apellidoMaternoDataGridViewTextBoxColumn.Name = "apellidoMaternoDataGridViewTextBoxColumn";
            apellidoMaternoDataGridViewTextBoxColumn.Width = 150;
            // 
            // numeroCelularDataGridViewTextBoxColumn
            // 
            numeroCelularDataGridViewTextBoxColumn.DataPropertyName = "NumeroCelular";
            numeroCelularDataGridViewTextBoxColumn.HeaderText = "NumeroCelular";
            numeroCelularDataGridViewTextBoxColumn.MinimumWidth = 8;
            numeroCelularDataGridViewTextBoxColumn.Name = "numeroCelularDataGridViewTextBoxColumn";
            numeroCelularDataGridViewTextBoxColumn.Width = 150;
            // 
            // correoEletronicoDataGridViewTextBoxColumn
            // 
            correoEletronicoDataGridViewTextBoxColumn.DataPropertyName = "CorreoEletronico";
            correoEletronicoDataGridViewTextBoxColumn.HeaderText = "CorreoEletronico";
            correoEletronicoDataGridViewTextBoxColumn.MinimumWidth = 8;
            correoEletronicoDataGridViewTextBoxColumn.Name = "correoEletronicoDataGridViewTextBoxColumn";
            correoEletronicoDataGridViewTextBoxColumn.Width = 150;
            // 
            // sexoDataGridViewTextBoxColumn
            // 
            sexoDataGridViewTextBoxColumn.DataPropertyName = "Sexo";
            sexoDataGridViewTextBoxColumn.HeaderText = "Sexo";
            sexoDataGridViewTextBoxColumn.MinimumWidth = 8;
            sexoDataGridViewTextBoxColumn.Name = "sexoDataGridViewTextBoxColumn";
            sexoDataGridViewTextBoxColumn.Width = 150;
            // 
            // statusIdDataGridViewTextBoxColumn
            // 
            statusIdDataGridViewTextBoxColumn.DataPropertyName = "StatusId";
            statusIdDataGridViewTextBoxColumn.HeaderText = "StatusId";
            statusIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            statusIdDataGridViewTextBoxColumn.Name = "statusIdDataGridViewTextBoxColumn";
            statusIdDataGridViewTextBoxColumn.Width = 150;
            // 
            // gestionPersonalEmpleadoBindingSource
            // 
            gestionPersonalEmpleadoBindingSource.DataSource = typeof(Models.GestionPersonalEmpleado);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(45, 156);
            label2.Name = "label2";
            label2.Size = new Size(243, 38);
            label2.TabIndex = 2;
            label2.Text = "Buscar empleado: ";
            toolTip1.SetToolTip(label2, "Se puede buscar por número de empleado o apellido ó nombre completo  ");
            // 
            // txtBuscar
            // 
            txtBuscar.Font = new Font("Segoe UI", 14F);
            txtBuscar.Location = new Point(278, 153);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(499, 45);
            txtBuscar.TabIndex = 3;
            toolTip1.SetToolTip(txtBuscar, "Se puede buscar por número de empleado o apellido ó nombre completo  ");
            // 
            // btnBuscar
            // 
            btnBuscar.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscar.ForeColor = Color.Chocolate;
            btnBuscar.Location = new Point(793, 153);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(164, 45);
            btnBuscar.TabIndex = 4;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.ForeColor = Color.DarkGreen;
            btnAgregar.Location = new Point(1042, 127);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(226, 97);
            btnAgregar.TabIndex = 5;
            btnAgregar.Text = "Agregar un nuevo empleado";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnRefrescar
            // 
            btnRefrescar.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefrescar.ForeColor = Color.Navy;
            btnRefrescar.Location = new Point(1528, 171);
            btnRefrescar.Name = "btnRefrescar";
            btnRefrescar.Size = new Size(187, 67);
            btnRefrescar.TabIndex = 6;
            btnRefrescar.Text = "Refrescar";
            btnRefrescar.UseVisualStyleBackColor = true;
            btnRefrescar.Click += button1_Click;
            // 
            // VerEmpleados
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1758, 667);
            Controls.Add(btnRefrescar);
            Controls.Add(btnAgregar);
            Controls.Add(btnBuscar);
            Controls.Add(txtBuscar);
            Controls.Add(label2);
            Controls.Add(GridEmpleados);
            Controls.Add(label1);
            Name = "VerEmpleados";
            Text = "VerEmpleados";
            Load += VerEmpleados_Load;
            ((System.ComponentModel.ISupportInitialize)GridEmpleados).EndInit();
            ((System.ComponentModel.ISupportInitialize)gestionPersonalEmpleadoBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView GridEmpleados;
        private BindingSource gestionPersonalEmpleadoBindingSource;
        private Label label2;
        private TextBox txtBuscar;
        private Button btnBuscar;
        private Button btnAgregar;
        private DataGridViewLinkColumn DarBaja;
        private DataGridViewTextBoxColumn empleadoIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn apellidoPaternoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn apellidoMaternoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn numeroCelularDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn correoEletronicoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sexoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn statusIdDataGridViewTextBoxColumn;
        private Button btnRefrescar;
        private ToolTip toolTip1;
    }
}