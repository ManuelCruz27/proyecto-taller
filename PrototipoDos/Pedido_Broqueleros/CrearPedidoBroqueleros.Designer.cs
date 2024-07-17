namespace PrototipoDos.Pedido_Broqueleros
{
    partial class CrearPedidoBroqueleros
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
            label3 = new Label();
            label4 = new Label();
            txtBuscarEmpleado = new TextBox();
            btnBuscar = new Button();
            groupBox1 = new GroupBox();
            cmbProducto = new ComboBox();
            label5 = new Label();
            cmbKilataje = new ComboBox();
            label7 = new Label();
            button2 = new Button();
            textBox4 = new TextBox();
            label6 = new Label();
            txtNombre = new TextBox();
            txtEmpleadoID = new TextBox();
            label8 = new Label();
            groupBox2 = new GroupBox();
            txtGramosDeSoldadura = new TextBox();
            txtParesDeTuerca = new TextBox();
            txtGramosDeTuerca = new TextBox();
            txtCientoDeTuerca = new TextBox();
            txtParesDePernos = new TextBox();
            txtGramosDePernos = new TextBox();
            txtCientoDePernos = new TextBox();
            txtParesDeCasquilla = new TextBox();
            txtGramosDeCasquilla = new TextBox();
            txtCientoCasquilla = new TextBox();
            label18 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            GridVerPedidos = new DataGridView();
            pedidoDetalleIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            pedidoIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            empleadoIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productoIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            kilateIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            empleadoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            kilateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            statusPedidoDetalleIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
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
            pedidosBroquelerosSalidumBindingSource = new BindingSource(components);
            button1 = new Button();
            button3 = new Button();
            txtPedidoNuevo = new TextBox();
            toolTip1 = new ToolTip(components);
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GridVerPedidos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pedidosBroquelerosSalidumBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(735, 10);
            label1.Name = "label1";
            label1.Size = new Size(573, 48);
            label1.TabIndex = 0;
            label1.Text = "Registro y creacion de pedidos ";
            toolTip1.SetToolTip(label1, "En esta ventana vamos a poder crear los trabajos que los empleados se van a llevar para trabajar desde su casa ");
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 91);
            label2.Name = "label2";
            label2.Size = new Size(270, 45);
            label2.TabIndex = 1;
            label2.Text = "Buscar Empleado:";
            toolTip1.SetToolTip(label2, "Puedes buscar al empleado por su numero de empleado y por su nombre ");
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(32, 40);
            label3.Name = "label3";
            label3.Size = new Size(172, 38);
            label3.TabIndex = 2;
            label3.Text = "EmpleadoID:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(377, 40);
            label4.Name = "label4";
            label4.Size = new Size(145, 38);
            label4.TabIndex = 3;
            label4.Text = "Empleado:";
            // 
            // txtBuscarEmpleado
            // 
            txtBuscarEmpleado.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscarEmpleado.Location = new Point(288, 93);
            txtBuscarEmpleado.Name = "txtBuscarEmpleado";
            txtBuscarEmpleado.Size = new Size(582, 45);
            txtBuscarEmpleado.TabIndex = 4;
            // 
            // btnBuscar
            // 
            btnBuscar.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscar.Location = new Point(892, 93);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(150, 50);
            btnBuscar.TabIndex = 5;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cmbProducto);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(cmbKilataje);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(txtEmpleadoID);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(12, 157);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1049, 250);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            // 
            // cmbProducto
            // 
            cmbProducto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbProducto.FormattingEnabled = true;
            cmbProducto.Location = new Point(765, 166);
            cmbProducto.Name = "cmbProducto";
            cmbProducto.Size = new Size(265, 40);
            cmbProducto.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(612, 164);
            label5.Name = "label5";
            label5.Size = new Size(147, 38);
            label5.TabIndex = 12;
            label5.Text = "Productos:";
            // 
            // cmbKilataje
            // 
            cmbKilataje.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbKilataje.FormattingEnabled = true;
            cmbKilataje.Location = new Point(335, 166);
            cmbKilataje.Name = "cmbKilataje";
            cmbKilataje.Size = new Size(271, 40);
            cmbKilataje.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(21, 164);
            label7.Name = "label7";
            label7.Size = new Size(308, 38);
            label7.TabIndex = 10;
            label7.Text = "Kilataje o tipo de metal:";
            // 
            // button2
            // 
            button2.Location = new Point(386, 105);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 9;
            button2.Text = "Buscar";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(230, 105);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(150, 31);
            textBox4.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(32, 102);
            label6.Name = "label6";
            label6.Size = new Size(192, 32);
            label6.TabIndex = 7;
            label6.Text = "Buscar producto:";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombre.Location = new Point(538, 42);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(492, 39);
            txtNombre.TabIndex = 5;
            // 
            // txtEmpleadoID
            // 
            txtEmpleadoID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmpleadoID.Location = new Point(210, 42);
            txtEmpleadoID.Name = "txtEmpleadoID";
            txtEmpleadoID.Size = new Size(150, 39);
            txtEmpleadoID.TabIndex = 4;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(1099, 197);
            label8.Name = "label8";
            label8.Size = new Size(223, 38);
            label8.TabIndex = 7;
            label8.Text = "Folio del pedido:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtGramosDeSoldadura);
            groupBox2.Controls.Add(txtParesDeTuerca);
            groupBox2.Controls.Add(txtGramosDeTuerca);
            groupBox2.Controls.Add(txtCientoDeTuerca);
            groupBox2.Controls.Add(txtParesDePernos);
            groupBox2.Controls.Add(txtGramosDePernos);
            groupBox2.Controls.Add(txtCientoDePernos);
            groupBox2.Controls.Add(txtParesDeCasquilla);
            groupBox2.Controls.Add(txtGramosDeCasquilla);
            groupBox2.Controls.Add(txtCientoCasquilla);
            groupBox2.Controls.Add(label18);
            groupBox2.Controls.Add(label15);
            groupBox2.Controls.Add(label16);
            groupBox2.Controls.Add(label17);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(label14);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label9);
            groupBox2.Location = new Point(20, 423);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1966, 273);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            // 
            // txtGramosDeSoldadura
            // 
            txtGramosDeSoldadura.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtGramosDeSoldadura.Location = new Point(1760, 64);
            txtGramosDeSoldadura.Name = "txtGramosDeSoldadura";
            txtGramosDeSoldadura.Size = new Size(200, 39);
            txtGramosDeSoldadura.TabIndex = 19;
            // 
            // txtParesDeTuerca
            // 
            txtParesDeTuerca.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtParesDeTuerca.Location = new Point(1268, 170);
            txtParesDeTuerca.Name = "txtParesDeTuerca";
            txtParesDeTuerca.Size = new Size(200, 39);
            txtParesDeTuerca.TabIndex = 18;
            // 
            // txtGramosDeTuerca
            // 
            txtGramosDeTuerca.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtGramosDeTuerca.Location = new Point(1268, 115);
            txtGramosDeTuerca.Name = "txtGramosDeTuerca";
            txtGramosDeTuerca.Size = new Size(200, 39);
            txtGramosDeTuerca.TabIndex = 17;
            // 
            // txtCientoDeTuerca
            // 
            txtCientoDeTuerca.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCientoDeTuerca.Location = new Point(1268, 55);
            txtCientoDeTuerca.Name = "txtCientoDeTuerca";
            txtCientoDeTuerca.Size = new Size(200, 39);
            txtCientoDeTuerca.TabIndex = 16;
            // 
            // txtParesDePernos
            // 
            txtParesDePernos.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtParesDePernos.Location = new Point(779, 170);
            txtParesDePernos.Name = "txtParesDePernos";
            txtParesDePernos.Size = new Size(200, 39);
            txtParesDePernos.TabIndex = 15;
            // 
            // txtGramosDePernos
            // 
            txtGramosDePernos.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtGramosDePernos.Location = new Point(779, 115);
            txtGramosDePernos.Name = "txtGramosDePernos";
            txtGramosDePernos.Size = new Size(200, 39);
            txtGramosDePernos.TabIndex = 14;
            txtGramosDePernos.TextChanged += txtGramosDePernos_TextChanged;
            // 
            // txtCientoDePernos
            // 
            txtCientoDePernos.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCientoDePernos.Location = new Point(779, 55);
            txtCientoDePernos.Name = "txtCientoDePernos";
            txtCientoDePernos.Size = new Size(200, 39);
            txtCientoDePernos.TabIndex = 13;
            // 
            // txtParesDeCasquilla
            // 
            txtParesDeCasquilla.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtParesDeCasquilla.Location = new Point(308, 170);
            txtParesDeCasquilla.Name = "txtParesDeCasquilla";
            txtParesDeCasquilla.Size = new Size(200, 39);
            txtParesDeCasquilla.TabIndex = 12;
            // 
            // txtGramosDeCasquilla
            // 
            txtGramosDeCasquilla.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtGramosDeCasquilla.Location = new Point(308, 115);
            txtGramosDeCasquilla.Name = "txtGramosDeCasquilla";
            txtGramosDeCasquilla.Size = new Size(200, 39);
            txtGramosDeCasquilla.TabIndex = 11;
            // 
            // txtCientoCasquilla
            // 
            txtCientoCasquilla.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCientoCasquilla.Location = new Point(308, 55);
            txtCientoCasquilla.Name = "txtCientoCasquilla";
            txtCientoCasquilla.Size = new Size(200, 39);
            txtCientoCasquilla.TabIndex = 10;
            txtCientoCasquilla.TextChanged += txtCientoCasquilla_TextChanged;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label18.Location = new Point(1489, 62);
            label18.Name = "label18";
            label18.Size = new Size(286, 38);
            label18.TabIndex = 9;
            label18.Text = "Gramos de soldadura:";
            label18.Click += label18_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.Location = new Point(1027, 168);
            label15.Name = "label15";
            label15.Size = new Size(213, 38);
            label15.TabIndex = 8;
            label15.Text = "Pares de tuerca:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label16.Location = new Point(1027, 113);
            label16.Name = "label16";
            label16.Size = new Size(250, 38);
            label16.TabIndex = 7;
            label16.Text = "Gramos de tuerca: ";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label17.Location = new Point(1027, 53);
            label17.Name = "label17";
            label17.Size = new Size(235, 38);
            label17.TabIndex = 6;
            label17.Text = "Ciento de tuerca: ";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(530, 168);
            label12.Name = "label12";
            label12.Size = new Size(221, 38);
            label12.TabIndex = 5;
            label12.Text = "Pares de pernos:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(530, 113);
            label13.Name = "label13";
            label13.Size = new Size(258, 38);
            label13.TabIndex = 4;
            label13.Text = "Gramos de pernos: ";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.Location = new Point(530, 53);
            label14.Name = "label14";
            label14.Size = new Size(243, 38);
            label14.TabIndex = 3;
            label14.Text = "Ciento de pernos: ";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(38, 168);
            label11.Name = "label11";
            label11.Size = new Size(242, 38);
            label11.TabIndex = 2;
            label11.Text = "Pares de casquilla:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(38, 113);
            label10.Name = "label10";
            label10.Size = new Size(279, 38);
            label10.TabIndex = 1;
            label10.Text = "Gramos de casquilla: ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(38, 53);
            label9.Name = "label9";
            label9.Size = new Size(264, 38);
            label9.TabIndex = 0;
            label9.Text = "Ciento de casquilla: ";
            // 
            // GridVerPedidos
            // 
            GridVerPedidos.AutoGenerateColumns = false;
            GridVerPedidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridVerPedidos.Columns.AddRange(new DataGridViewColumn[] { pedidoDetalleIdDataGridViewTextBoxColumn, pedidoIdDataGridViewTextBoxColumn, empleadoIdDataGridViewTextBoxColumn, productoIdDataGridViewTextBoxColumn, kilateIdDataGridViewTextBoxColumn, empleadoDataGridViewTextBoxColumn, productoDataGridViewTextBoxColumn, kilateDataGridViewTextBoxColumn, statusPedidoDetalleIdDataGridViewTextBoxColumn, cientoCasquillaDataGridViewTextBoxColumn, cientoPernosDataGridViewTextBoxColumn, cientoTuercaDataGridViewTextBoxColumn, paresCasquillaDataGridViewTextBoxColumn, paresPernosDataGridViewTextBoxColumn, paresTuercaDataGridViewTextBoxColumn, gramosCasquillaDataGridViewTextBoxColumn, gramosPernosDataGridViewTextBoxColumn, gramosTuercaDataGridViewTextBoxColumn, gramosSoldaduraDataGridViewTextBoxColumn, paresEstimadosDataGridViewTextBoxColumn, gramosTotalDataGridViewTextBoxColumn, fechaSalidaDataGridViewTextBoxColumn });
            GridVerPedidos.DataSource = pedidosBroquelerosSalidumBindingSource;
            GridVerPedidos.Location = new Point(31, 729);
            GridVerPedidos.Name = "GridVerPedidos";
            GridVerPedidos.RowHeadersWidth = 62;
            GridVerPedidos.Size = new Size(1949, 280);
            GridVerPedidos.TabIndex = 9;
            GridVerPedidos.CellContentClick += dataGridView1_CellContentClick;
            // 
            // pedidoDetalleIdDataGridViewTextBoxColumn
            // 
            pedidoDetalleIdDataGridViewTextBoxColumn.DataPropertyName = "PedidoDetalleId";
            pedidoDetalleIdDataGridViewTextBoxColumn.HeaderText = "PedidoDetalleId";
            pedidoDetalleIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            pedidoDetalleIdDataGridViewTextBoxColumn.Name = "pedidoDetalleIdDataGridViewTextBoxColumn";
            pedidoDetalleIdDataGridViewTextBoxColumn.Width = 150;
            // 
            // pedidoIdDataGridViewTextBoxColumn
            // 
            pedidoIdDataGridViewTextBoxColumn.DataPropertyName = "PedidoId";
            pedidoIdDataGridViewTextBoxColumn.HeaderText = "PedidoId";
            pedidoIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            pedidoIdDataGridViewTextBoxColumn.Name = "pedidoIdDataGridViewTextBoxColumn";
            pedidoIdDataGridViewTextBoxColumn.Width = 150;
            // 
            // empleadoIdDataGridViewTextBoxColumn
            // 
            empleadoIdDataGridViewTextBoxColumn.DataPropertyName = "EmpleadoId";
            empleadoIdDataGridViewTextBoxColumn.HeaderText = "EmpleadoId";
            empleadoIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            empleadoIdDataGridViewTextBoxColumn.Name = "empleadoIdDataGridViewTextBoxColumn";
            empleadoIdDataGridViewTextBoxColumn.Width = 150;
            // 
            // productoIdDataGridViewTextBoxColumn
            // 
            productoIdDataGridViewTextBoxColumn.DataPropertyName = "ProductoId";
            productoIdDataGridViewTextBoxColumn.HeaderText = "ProductoId";
            productoIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            productoIdDataGridViewTextBoxColumn.Name = "productoIdDataGridViewTextBoxColumn";
            productoIdDataGridViewTextBoxColumn.Width = 150;
            // 
            // kilateIdDataGridViewTextBoxColumn
            // 
            kilateIdDataGridViewTextBoxColumn.DataPropertyName = "KilateId";
            kilateIdDataGridViewTextBoxColumn.HeaderText = "KilateId";
            kilateIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            kilateIdDataGridViewTextBoxColumn.Name = "kilateIdDataGridViewTextBoxColumn";
            kilateIdDataGridViewTextBoxColumn.Width = 150;
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
            // statusPedidoDetalleIdDataGridViewTextBoxColumn
            // 
            statusPedidoDetalleIdDataGridViewTextBoxColumn.DataPropertyName = "StatusPedidoDetalleId";
            statusPedidoDetalleIdDataGridViewTextBoxColumn.HeaderText = "StatusPedidoDetalleId";
            statusPedidoDetalleIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            statusPedidoDetalleIdDataGridViewTextBoxColumn.Name = "statusPedidoDetalleIdDataGridViewTextBoxColumn";
            statusPedidoDetalleIdDataGridViewTextBoxColumn.Width = 150;
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
            // pedidosBroquelerosSalidumBindingSource
            // 
            pedidosBroquelerosSalidumBindingSource.DataSource = typeof(Models.PedidosBroquelerosSalidum);
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Green;
            button1.Location = new Point(1580, 352);
            button1.Name = "button1";
            button1.Size = new Size(160, 50);
            button1.TabIndex = 10;
            button1.Text = "Crear";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.FromArgb(192, 0, 0);
            button3.Location = new Point(1769, 356);
            button3.Name = "button3";
            button3.Size = new Size(160, 50);
            button3.TabIndex = 11;
            button3.Text = "Calcelar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // txtPedidoNuevo
            // 
            txtPedidoNuevo.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPedidoNuevo.Location = new Point(1328, 197);
            txtPedidoNuevo.Name = "txtPedidoNuevo";
            txtPedidoNuevo.Size = new Size(241, 45);
            txtPedidoNuevo.TabIndex = 12;
            txtPedidoNuevo.Text = "0";
            // 
            // CrearPedidoBroqueleros
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1998, 1024);
            Controls.Add(txtPedidoNuevo);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(GridVerPedidos);
            Controls.Add(groupBox2);
            Controls.Add(label8);
            Controls.Add(groupBox1);
            Controls.Add(btnBuscar);
            Controls.Add(txtBuscarEmpleado);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CrearPedidoBroqueleros";
            Text = "CrearPedidoBroqueleros";
            Load += CrearPedidoBroqueleros_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)GridVerPedidos).EndInit();
            ((System.ComponentModel.ISupportInitialize)pedidosBroquelerosSalidumBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtBuscarEmpleado;
        private Button btnBuscar;
        private GroupBox groupBox1;
        private Label label6;
        private TextBox txtNombre;
        private TextBox txtEmpleadoID;
        private ComboBox cmbKilataje;
        private Label label7;
        private Button button2;
        private TextBox textBox4;
        private Label label8;
        private ComboBox cmbProducto;
        private Label label5;
        private GroupBox groupBox2;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label18;
        private Label label15;
        private Label label16;
        private Label label17;
        private TextBox txtGramosDeSoldadura;
        private TextBox txtParesDeTuerca;
        private TextBox txtGramosDeTuerca;
        private TextBox txtCientoDeTuerca;
        private TextBox txtParesDePernos;
        private TextBox txtGramosDePernos;
        private TextBox txtCientoDePernos;
        private TextBox txtParesDeCasquilla;
        private TextBox txtGramosDeCasquilla;
        private TextBox txtCientoCasquilla;
        private DataGridView GridVerPedidos;
        private BindingSource pedidosBroquelerosSalidumBindingSource;
        private Button button1;
        private Button button3;
        private TextBox txtPedidoNuevo;
        private ToolTip toolTip1;
        private DataGridViewTextBoxColumn pedidoDetalleIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn pedidoIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn empleadoIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productoIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn kilateIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn empleadoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn kilateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn statusPedidoDetalleIdDataGridViewTextBoxColumn;
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
    }
}