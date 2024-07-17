namespace PrototipoDos.Pedido_Broqueleros
{
    partial class FinalizarPedidos
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
            label1 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            btnBuscarPedidoDetalle = new Button();
            txtProducto = new TextBox();
            label3 = new Label();
            txtKilataje = new TextBox();
            label4 = new Label();
            txtPedidoDetalle = new TextBox();
            label5 = new Label();
            txtPedidoID = new TextBox();
            label6 = new Label();
            txtEmpleado = new TextBox();
            label7 = new Label();
            txtEmpleadoID = new TextBox();
            label8 = new Label();
            txtBuscar = new TextBox();
            btnBuscar = new Button();
            toolTip1 = new ToolTip(components);
            invPedidosBroqueleroBindingSource = new BindingSource(components);
            pedidosBroquelerosSalidumBindingSource = new BindingSource(components);
            groupBox4 = new GroupBox();
            GridVerPedidosDetalles = new DataGridView();
            pedidoIdDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            pedidoDetalleIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            empleadoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            kilateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cientoCasquillaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cientoPernosDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cientoTuercaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            paresCasquillaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            paresPernosDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            paresTuercaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            gramosCasquillaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            gramosPernosDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            gramosTuercaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            gramosSoldaduraDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            paresEstimadosDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            gramosTotalDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fechaSalidaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            statusPedidoDetalleIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            groupBox3 = new GroupBox();
            GridVerPedidos = new DataGridView();
            pedidoIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            statusIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fechaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            empleadoIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            groupBox2 = new GroupBox();
            txtPagoPorTrabajo = new TextBox();
            txtMerma = new TextBox();
            txtPesoMalo = new TextBox();
            txtSobranteDeTuerca = new TextBox();
            txtPesoFinal = new TextBox();
            txtTotalPares = new TextBox();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            btnFinalizar = new Button();
            btnCancelar = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)invPedidosBroqueleroBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pedidosBroquelerosSalidumBindingSource).BeginInit();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GridVerPedidosDetalles).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GridVerPedidos).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(842, 22);
            label1.Name = "label1";
            label1.Size = new Size(288, 45);
            label1.TabIndex = 0;
            label1.Text = "Finalizar Pedidos";
            toolTip1.SetToolTip(label1, "Esta ventana es para finalizar todos los trabajos de los empleados y calcular el pago por cada trabajo individual mente, como también la merma.");
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(25, 99);
            label2.Name = "label2";
            label2.Size = new Size(198, 38);
            label2.TabIndex = 1;
            label2.Text = "Buscar pedido:";
            toolTip1.SetToolTip(label2, "Puedes buscar por numero de empleado o por el nombre.");
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnBuscarPedidoDetalle);
            groupBox1.Controls.Add(txtProducto);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtKilataje);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtPedidoDetalle);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtPedidoID);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtEmpleado);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtEmpleadoID);
            groupBox1.Controls.Add(label8);
            groupBox1.Location = new Point(25, 169);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1017, 289);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Detalle del pedido";
            toolTip1.SetToolTip(groupBox1, "En este apartado puedes ver cuál es el trabajo ha finalizar. \r\nEn el campo de PedidoDetalle puedes seleccionar con más precisión que trabajo a entregar \r\n");
            // 
            // btnBuscarPedidoDetalle
            // 
            btnBuscarPedidoDetalle.BackColor = SystemColors.ActiveCaption;
            btnBuscarPedidoDetalle.ForeColor = SystemColors.ActiveCaptionText;
            btnBuscarPedidoDetalle.Location = new Point(905, 144);
            btnBuscarPedidoDetalle.Name = "btnBuscarPedidoDetalle";
            btnBuscarPedidoDetalle.Size = new Size(67, 36);
            btnBuscarPedidoDetalle.TabIndex = 26;
            btnBuscarPedidoDetalle.UseVisualStyleBackColor = false;
            btnBuscarPedidoDetalle.Click += btnBuscarPedidoDetalle_Click;
            // 
            // txtProducto
            // 
            txtProducto.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtProducto.Location = new Point(645, 213);
            txtProducto.Name = "txtProducto";
            txtProducto.Size = new Size(241, 45);
            txtProducto.TabIndex = 25;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(25, 49);
            label3.Name = "label3";
            label3.Size = new Size(209, 45);
            label3.TabIndex = 14;
            label3.Text = "EmpleadoID: ";
            // 
            // txtKilataje
            // 
            txtKilataje.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtKilataje.Location = new Point(221, 213);
            txtKilataje.Name = "txtKilataje";
            txtKilataje.Size = new Size(241, 45);
            txtKilataje.TabIndex = 24;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(414, 49);
            label4.Name = "label4";
            label4.Size = new Size(145, 45);
            label4.TabIndex = 15;
            label4.Text = "Nombre:";
            // 
            // txtPedidoDetalle
            // 
            txtPedidoDetalle.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPedidoDetalle.Location = new Point(645, 139);
            txtPedidoDetalle.Name = "txtPedidoDetalle";
            txtPedidoDetalle.Size = new Size(241, 45);
            txtPedidoDetalle.TabIndex = 23;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16F);
            label5.Location = new Point(45, 137);
            label5.Name = "label5";
            label5.Size = new Size(157, 45);
            label5.TabIndex = 16;
            label5.Text = "PedidoID:";
            // 
            // txtPedidoID
            // 
            txtPedidoID.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPedidoID.Location = new Point(221, 135);
            txtPedidoID.Name = "txtPedidoID";
            txtPedidoID.Size = new Size(195, 45);
            txtPedidoID.TabIndex = 22;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16F);
            label6.Location = new Point(414, 137);
            label6.Name = "label6";
            label6.Size = new Size(225, 45);
            label6.TabIndex = 17;
            label6.Text = "PedidoDetalle:";
            // 
            // txtEmpleado
            // 
            txtEmpleado.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmpleado.Location = new Point(565, 51);
            txtEmpleado.Name = "txtEmpleado";
            txtEmpleado.Size = new Size(431, 45);
            txtEmpleado.TabIndex = 21;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 16F);
            label7.Location = new Point(63, 213);
            label7.Name = "label7";
            label7.Size = new Size(130, 45);
            label7.TabIndex = 18;
            label7.Text = "Kilataje:";
            // 
            // txtEmpleadoID
            // 
            txtEmpleadoID.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmpleadoID.Location = new Point(240, 51);
            txtEmpleadoID.Name = "txtEmpleadoID";
            txtEmpleadoID.Size = new Size(176, 45);
            txtEmpleadoID.TabIndex = 20;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 16F);
            label8.Location = new Point(482, 213);
            label8.Name = "label8";
            label8.Size = new Size(157, 45);
            label8.TabIndex = 19;
            label8.Text = "Producto:";
            // 
            // txtBuscar
            // 
            txtBuscar.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscar.Location = new Point(229, 99);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(578, 45);
            txtBuscar.TabIndex = 6;
            // 
            // btnBuscar
            // 
            btnBuscar.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscar.ForeColor = Color.DarkOrange;
            btnBuscar.Location = new Point(847, 96);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(150, 50);
            btnBuscar.TabIndex = 7;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // invPedidosBroqueleroBindingSource
            // 
            invPedidosBroqueleroBindingSource.DataSource = typeof(Models.InvPedidosBroquelero);
            // 
            // pedidosBroquelerosSalidumBindingSource
            // 
            pedidosBroquelerosSalidumBindingSource.DataSource = typeof(Models.PedidosBroquelerosSalidum);
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(GridVerPedidosDetalles);
            groupBox4.Location = new Point(1029, 515);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(952, 338);
            groupBox4.TabIndex = 13;
            groupBox4.TabStop = false;
            groupBox4.Text = "Pedido Detalle";
            // 
            // GridVerPedidosDetalles
            // 
            GridVerPedidosDetalles.AutoGenerateColumns = false;
            GridVerPedidosDetalles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridVerPedidosDetalles.Columns.AddRange(new DataGridViewColumn[] { pedidoIdDataGridViewTextBoxColumn1, pedidoDetalleIdDataGridViewTextBoxColumn, empleadoDataGridViewTextBoxColumn, productoDataGridViewTextBoxColumn, kilateDataGridViewTextBoxColumn, cientoCasquillaDataGridViewTextBoxColumn, cientoPernosDataGridViewTextBoxColumn, cientoTuercaDataGridViewTextBoxColumn, paresCasquillaDataGridViewTextBoxColumn, paresPernosDataGridViewTextBoxColumn, paresTuercaDataGridViewTextBoxColumn, gramosCasquillaDataGridViewTextBoxColumn, gramosPernosDataGridViewTextBoxColumn, gramosTuercaDataGridViewTextBoxColumn, gramosSoldaduraDataGridViewTextBoxColumn, paresEstimadosDataGridViewTextBoxColumn, gramosTotalDataGridViewTextBoxColumn, fechaSalidaDataGridViewTextBoxColumn, statusPedidoDetalleIdDataGridViewTextBoxColumn });
            GridVerPedidosDetalles.DataSource = pedidosBroquelerosSalidumBindingSource;
            GridVerPedidosDetalles.Location = new Point(36, 43);
            GridVerPedidosDetalles.Name = "GridVerPedidosDetalles";
            GridVerPedidosDetalles.RowHeadersWidth = 62;
            GridVerPedidosDetalles.Size = new Size(910, 267);
            GridVerPedidosDetalles.TabIndex = 0;
            // 
            // pedidoIdDataGridViewTextBoxColumn1
            // 
            pedidoIdDataGridViewTextBoxColumn1.DataPropertyName = "PedidoId";
            pedidoIdDataGridViewTextBoxColumn1.HeaderText = "PedidoId";
            pedidoIdDataGridViewTextBoxColumn1.MinimumWidth = 8;
            pedidoIdDataGridViewTextBoxColumn1.Name = "pedidoIdDataGridViewTextBoxColumn1";
            pedidoIdDataGridViewTextBoxColumn1.Width = 150;
            // 
            // pedidoDetalleIdDataGridViewTextBoxColumn
            // 
            pedidoDetalleIdDataGridViewTextBoxColumn.DataPropertyName = "PedidoDetalleId";
            pedidoDetalleIdDataGridViewTextBoxColumn.HeaderText = "PedidoDetalleId";
            pedidoDetalleIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            pedidoDetalleIdDataGridViewTextBoxColumn.Name = "pedidoDetalleIdDataGridViewTextBoxColumn";
            pedidoDetalleIdDataGridViewTextBoxColumn.Width = 150;
            // 
            // empleadoDataGridViewTextBoxColumn
            // 
            empleadoDataGridViewTextBoxColumn.DataPropertyName = "Empleado";
            empleadoDataGridViewTextBoxColumn.HeaderText = "Empleado";
            empleadoDataGridViewTextBoxColumn.MinimumWidth = 8;
            empleadoDataGridViewTextBoxColumn.Name = "empleadoDataGridViewTextBoxColumn";
            empleadoDataGridViewTextBoxColumn.Width = 150;
            // 
            // productoDataGridViewTextBoxColumn
            // 
            productoDataGridViewTextBoxColumn.DataPropertyName = "Producto";
            productoDataGridViewTextBoxColumn.HeaderText = "Producto";
            productoDataGridViewTextBoxColumn.MinimumWidth = 8;
            productoDataGridViewTextBoxColumn.Name = "productoDataGridViewTextBoxColumn";
            productoDataGridViewTextBoxColumn.Width = 150;
            // 
            // kilateDataGridViewTextBoxColumn
            // 
            kilateDataGridViewTextBoxColumn.DataPropertyName = "Kilate";
            kilateDataGridViewTextBoxColumn.HeaderText = "Kilate";
            kilateDataGridViewTextBoxColumn.MinimumWidth = 8;
            kilateDataGridViewTextBoxColumn.Name = "kilateDataGridViewTextBoxColumn";
            kilateDataGridViewTextBoxColumn.Width = 150;
            // 
            // cientoCasquillaDataGridViewTextBoxColumn
            // 
            cientoCasquillaDataGridViewTextBoxColumn.DataPropertyName = "CientoCasquilla";
            cientoCasquillaDataGridViewTextBoxColumn.HeaderText = "CientoCasquilla";
            cientoCasquillaDataGridViewTextBoxColumn.MinimumWidth = 8;
            cientoCasquillaDataGridViewTextBoxColumn.Name = "cientoCasquillaDataGridViewTextBoxColumn";
            cientoCasquillaDataGridViewTextBoxColumn.Width = 150;
            // 
            // cientoPernosDataGridViewTextBoxColumn
            // 
            cientoPernosDataGridViewTextBoxColumn.DataPropertyName = "CientoPernos";
            cientoPernosDataGridViewTextBoxColumn.HeaderText = "CientoPernos";
            cientoPernosDataGridViewTextBoxColumn.MinimumWidth = 8;
            cientoPernosDataGridViewTextBoxColumn.Name = "cientoPernosDataGridViewTextBoxColumn";
            cientoPernosDataGridViewTextBoxColumn.Width = 150;
            // 
            // cientoTuercaDataGridViewTextBoxColumn
            // 
            cientoTuercaDataGridViewTextBoxColumn.DataPropertyName = "CientoTuerca";
            cientoTuercaDataGridViewTextBoxColumn.HeaderText = "CientoTuerca";
            cientoTuercaDataGridViewTextBoxColumn.MinimumWidth = 8;
            cientoTuercaDataGridViewTextBoxColumn.Name = "cientoTuercaDataGridViewTextBoxColumn";
            cientoTuercaDataGridViewTextBoxColumn.Width = 150;
            // 
            // paresCasquillaDataGridViewTextBoxColumn
            // 
            paresCasquillaDataGridViewTextBoxColumn.DataPropertyName = "ParesCasquilla";
            paresCasquillaDataGridViewTextBoxColumn.HeaderText = "ParesCasquilla";
            paresCasquillaDataGridViewTextBoxColumn.MinimumWidth = 8;
            paresCasquillaDataGridViewTextBoxColumn.Name = "paresCasquillaDataGridViewTextBoxColumn";
            paresCasquillaDataGridViewTextBoxColumn.Width = 150;
            // 
            // paresPernosDataGridViewTextBoxColumn
            // 
            paresPernosDataGridViewTextBoxColumn.DataPropertyName = "ParesPernos";
            paresPernosDataGridViewTextBoxColumn.HeaderText = "ParesPernos";
            paresPernosDataGridViewTextBoxColumn.MinimumWidth = 8;
            paresPernosDataGridViewTextBoxColumn.Name = "paresPernosDataGridViewTextBoxColumn";
            paresPernosDataGridViewTextBoxColumn.Width = 150;
            // 
            // paresTuercaDataGridViewTextBoxColumn
            // 
            paresTuercaDataGridViewTextBoxColumn.DataPropertyName = "ParesTuerca";
            paresTuercaDataGridViewTextBoxColumn.HeaderText = "ParesTuerca";
            paresTuercaDataGridViewTextBoxColumn.MinimumWidth = 8;
            paresTuercaDataGridViewTextBoxColumn.Name = "paresTuercaDataGridViewTextBoxColumn";
            paresTuercaDataGridViewTextBoxColumn.Width = 150;
            // 
            // gramosCasquillaDataGridViewTextBoxColumn
            // 
            gramosCasquillaDataGridViewTextBoxColumn.DataPropertyName = "GramosCasquilla";
            gramosCasquillaDataGridViewTextBoxColumn.HeaderText = "GramosCasquilla";
            gramosCasquillaDataGridViewTextBoxColumn.MinimumWidth = 8;
            gramosCasquillaDataGridViewTextBoxColumn.Name = "gramosCasquillaDataGridViewTextBoxColumn";
            gramosCasquillaDataGridViewTextBoxColumn.Width = 150;
            // 
            // gramosPernosDataGridViewTextBoxColumn
            // 
            gramosPernosDataGridViewTextBoxColumn.DataPropertyName = "GramosPernos";
            gramosPernosDataGridViewTextBoxColumn.HeaderText = "GramosPernos";
            gramosPernosDataGridViewTextBoxColumn.MinimumWidth = 8;
            gramosPernosDataGridViewTextBoxColumn.Name = "gramosPernosDataGridViewTextBoxColumn";
            gramosPernosDataGridViewTextBoxColumn.Width = 150;
            // 
            // gramosTuercaDataGridViewTextBoxColumn
            // 
            gramosTuercaDataGridViewTextBoxColumn.DataPropertyName = "GramosTuerca";
            gramosTuercaDataGridViewTextBoxColumn.HeaderText = "GramosTuerca";
            gramosTuercaDataGridViewTextBoxColumn.MinimumWidth = 8;
            gramosTuercaDataGridViewTextBoxColumn.Name = "gramosTuercaDataGridViewTextBoxColumn";
            gramosTuercaDataGridViewTextBoxColumn.Width = 150;
            // 
            // gramosSoldaduraDataGridViewTextBoxColumn
            // 
            gramosSoldaduraDataGridViewTextBoxColumn.DataPropertyName = "GramosSoldadura";
            gramosSoldaduraDataGridViewTextBoxColumn.HeaderText = "GramosSoldadura";
            gramosSoldaduraDataGridViewTextBoxColumn.MinimumWidth = 8;
            gramosSoldaduraDataGridViewTextBoxColumn.Name = "gramosSoldaduraDataGridViewTextBoxColumn";
            gramosSoldaduraDataGridViewTextBoxColumn.Width = 150;
            // 
            // paresEstimadosDataGridViewTextBoxColumn
            // 
            paresEstimadosDataGridViewTextBoxColumn.DataPropertyName = "ParesEstimados";
            paresEstimadosDataGridViewTextBoxColumn.HeaderText = "ParesEstimados";
            paresEstimadosDataGridViewTextBoxColumn.MinimumWidth = 8;
            paresEstimadosDataGridViewTextBoxColumn.Name = "paresEstimadosDataGridViewTextBoxColumn";
            paresEstimadosDataGridViewTextBoxColumn.Width = 150;
            // 
            // gramosTotalDataGridViewTextBoxColumn
            // 
            gramosTotalDataGridViewTextBoxColumn.DataPropertyName = "GramosTotal";
            gramosTotalDataGridViewTextBoxColumn.HeaderText = "GramosTotal";
            gramosTotalDataGridViewTextBoxColumn.MinimumWidth = 8;
            gramosTotalDataGridViewTextBoxColumn.Name = "gramosTotalDataGridViewTextBoxColumn";
            gramosTotalDataGridViewTextBoxColumn.Width = 150;
            // 
            // fechaSalidaDataGridViewTextBoxColumn
            // 
            fechaSalidaDataGridViewTextBoxColumn.DataPropertyName = "FechaSalida";
            fechaSalidaDataGridViewTextBoxColumn.HeaderText = "FechaSalida";
            fechaSalidaDataGridViewTextBoxColumn.MinimumWidth = 8;
            fechaSalidaDataGridViewTextBoxColumn.Name = "fechaSalidaDataGridViewTextBoxColumn";
            fechaSalidaDataGridViewTextBoxColumn.Width = 150;
            // 
            // statusPedidoDetalleIdDataGridViewTextBoxColumn
            // 
            statusPedidoDetalleIdDataGridViewTextBoxColumn.DataPropertyName = "StatusPedidoDetalleId";
            statusPedidoDetalleIdDataGridViewTextBoxColumn.HeaderText = "StatusPedidoDetalleId";
            statusPedidoDetalleIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            statusPedidoDetalleIdDataGridViewTextBoxColumn.Name = "statusPedidoDetalleIdDataGridViewTextBoxColumn";
            statusPedidoDetalleIdDataGridViewTextBoxColumn.Width = 150;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(GridVerPedidos);
            groupBox3.Location = new Point(1043, 169);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(938, 307);
            groupBox3.TabIndex = 12;
            groupBox3.TabStop = false;
            groupBox3.Text = "Pedidos activos";
            // 
            // GridVerPedidos
            // 
            GridVerPedidos.AutoGenerateColumns = false;
            GridVerPedidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridVerPedidos.Columns.AddRange(new DataGridViewColumn[] { pedidoIdDataGridViewTextBoxColumn, statusIdDataGridViewTextBoxColumn, fechaDataGridViewTextBoxColumn, empleadoIdDataGridViewTextBoxColumn });
            GridVerPedidos.DataSource = invPedidosBroqueleroBindingSource;
            GridVerPedidos.Location = new Point(102, 39);
            GridVerPedidos.Name = "GridVerPedidos";
            GridVerPedidos.RowHeadersWidth = 62;
            GridVerPedidos.Size = new Size(815, 238);
            GridVerPedidos.TabIndex = 0;
            // 
            // pedidoIdDataGridViewTextBoxColumn
            // 
            pedidoIdDataGridViewTextBoxColumn.DataPropertyName = "PedidoId";
            pedidoIdDataGridViewTextBoxColumn.HeaderText = "PedidoId";
            pedidoIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            pedidoIdDataGridViewTextBoxColumn.Name = "pedidoIdDataGridViewTextBoxColumn";
            pedidoIdDataGridViewTextBoxColumn.Width = 150;
            // 
            // statusIdDataGridViewTextBoxColumn
            // 
            statusIdDataGridViewTextBoxColumn.DataPropertyName = "StatusId";
            statusIdDataGridViewTextBoxColumn.HeaderText = "StatusId";
            statusIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            statusIdDataGridViewTextBoxColumn.Name = "statusIdDataGridViewTextBoxColumn";
            statusIdDataGridViewTextBoxColumn.Width = 150;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            fechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha";
            fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            fechaDataGridViewTextBoxColumn.MinimumWidth = 8;
            fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            fechaDataGridViewTextBoxColumn.Width = 150;
            // 
            // empleadoIdDataGridViewTextBoxColumn
            // 
            empleadoIdDataGridViewTextBoxColumn.DataPropertyName = "EmpleadoId";
            empleadoIdDataGridViewTextBoxColumn.HeaderText = "EmpleadoId";
            empleadoIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            empleadoIdDataGridViewTextBoxColumn.Name = "empleadoIdDataGridViewTextBoxColumn";
            empleadoIdDataGridViewTextBoxColumn.Width = 150;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtPagoPorTrabajo);
            groupBox2.Controls.Add(txtMerma);
            groupBox2.Controls.Add(txtPesoMalo);
            groupBox2.Controls.Add(txtSobranteDeTuerca);
            groupBox2.Controls.Add(txtPesoFinal);
            groupBox2.Controls.Add(txtTotalPares);
            groupBox2.Controls.Add(label14);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label9);
            groupBox2.Location = new Point(18, 470);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(974, 316);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            // 
            // txtPagoPorTrabajo
            // 
            txtPagoPorTrabajo.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPagoPorTrabajo.Location = new Point(699, 210);
            txtPagoPorTrabajo.Name = "txtPagoPorTrabajo";
            txtPagoPorTrabajo.Size = new Size(150, 45);
            txtPagoPorTrabajo.TabIndex = 11;
            // 
            // txtMerma
            // 
            txtMerma.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMerma.Location = new Point(172, 208);
            txtMerma.Name = "txtMerma";
            txtMerma.Size = new Size(150, 45);
            txtMerma.TabIndex = 10;
            // 
            // txtPesoMalo
            // 
            txtPesoMalo.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPesoMalo.Location = new Point(699, 127);
            txtPesoMalo.Name = "txtPesoMalo";
            txtPesoMalo.Size = new Size(150, 45);
            txtPesoMalo.TabIndex = 9;
            // 
            // txtSobranteDeTuerca
            // 
            txtSobranteDeTuerca.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSobranteDeTuerca.Location = new Point(328, 127);
            txtSobranteDeTuerca.Name = "txtSobranteDeTuerca";
            txtSobranteDeTuerca.Size = new Size(150, 45);
            txtSobranteDeTuerca.TabIndex = 8;
            // 
            // txtPesoFinal
            // 
            txtPesoFinal.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPesoFinal.Location = new Point(608, 45);
            txtPesoFinal.Name = "txtPesoFinal";
            txtPesoFinal.Size = new Size(150, 45);
            txtPesoFinal.TabIndex = 7;
            // 
            // txtTotalPares
            // 
            txtTotalPares.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTotalPares.Location = new Point(257, 45);
            txtTotalPares.Name = "txtTotalPares";
            txtTotalPares.Size = new Size(150, 45);
            txtTotalPares.TabIndex = 6;
            txtTotalPares.TextChanged += textBox1_TextChanged;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.Location = new Point(416, 208);
            label14.Name = "label14";
            label14.Size = new Size(265, 45);
            label14.TabIndex = 5;
            label14.Text = "Pago por trabajo:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(27, 206);
            label13.Name = "label13";
            label13.Size = new Size(128, 45);
            label13.TabIndex = 4;
            label13.Text = "Merma:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(496, 125);
            label12.Name = "label12";
            label12.Size = new Size(175, 45);
            label12.TabIndex = 3;
            label12.Text = "Peso Malo:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(25, 125);
            label11.Name = "label11";
            label11.Size = new Size(297, 45);
            label11.TabIndex = 2;
            label11.Text = "Sobrante de tuerca:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 16F);
            label10.Location = new Point(439, 43);
            label10.Name = "label10";
            label10.RightToLeft = RightToLeft.No;
            label10.Size = new Size(163, 45);
            label10.TabIndex = 1;
            label10.Text = "Peso final:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 16F);
            label9.Location = new Point(25, 43);
            label9.Name = "label9";
            label9.Size = new Size(226, 45);
            label9.TabIndex = 0;
            label9.Text = "Total de pares:";
            // 
            // btnFinalizar
            // 
            btnFinalizar.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFinalizar.ForeColor = Color.Green;
            btnFinalizar.Location = new Point(1538, 115);
            btnFinalizar.Name = "btnFinalizar";
            btnFinalizar.Size = new Size(190, 50);
            btnFinalizar.TabIndex = 14;
            btnFinalizar.Text = "Finalizar";
            btnFinalizar.UseVisualStyleBackColor = true;
            btnFinalizar.Click += btnFinalizar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = Color.DarkRed;
            btnCancelar.Location = new Point(1755, 115);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(172, 48);
            btnCancelar.TabIndex = 15;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FinalizarPedidos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1998, 1024);
            Controls.Add(btnCancelar);
            Controls.Add(btnFinalizar);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(btnBuscar);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtBuscar);
            Name = "FinalizarPedidos";
            Text = "FinalizarPedidos";
            Load += FinalizarPedidos_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)invPedidosBroqueleroBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)pedidosBroquelerosSalidumBindingSource).EndInit();
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)GridVerPedidosDetalles).EndInit();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)GridVerPedidos).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private TextBox txtBuscar;
        private TextBox txtProducto;
        private Label label3;
        private TextBox txtKilataje;
        private Label label4;
        private TextBox txtPedidoDetalle;
        private Label label5;
        private TextBox txtPedidoID;
        private Label label6;
        private TextBox txtEmpleado;
        private Label label7;
        private TextBox txtEmpleadoID;
        private Label label8;
        private Button btnBuscar;
        private ToolTip toolTip1;
        private BindingSource invPedidosBroqueleroBindingSource;
        private BindingSource pedidosBroquelerosSalidumBindingSource;
        private Button btnBuscarPedidoDetalle;
        private GroupBox groupBox4;
        private DataGridView GridVerPedidosDetalles;
        private GroupBox groupBox3;
        private DataGridView GridVerPedidos;
        private DataGridViewTextBoxColumn pedidoIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn statusIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn empleadoIdDataGridViewTextBoxColumn;
        private GroupBox groupBox2;
        private TextBox txtPagoPorTrabajo;
        private TextBox txtMerma;
        private TextBox txtPesoMalo;
        private TextBox txtSobranteDeTuerca;
        private TextBox txtPesoFinal;
        private TextBox txtTotalPares;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private DataGridViewTextBoxColumn pedidoIdDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn pedidoDetalleIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn empleadoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn kilateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cientoCasquillaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cientoPernosDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cientoTuercaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn paresCasquillaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn paresPernosDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn paresTuercaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn gramosCasquillaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn gramosPernosDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn gramosTuercaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn gramosSoldaduraDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn paresEstimadosDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn gramosTotalDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaSalidaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn statusPedidoDetalleIdDataGridViewTextBoxColumn;
        private Button btnFinalizar;
        private Button btnCancelar;
    }
}