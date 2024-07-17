namespace PrototipoDos.Empleados
{
    partial class AgregarEmpleado
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            txtNumero = new TextBox();
            label15 = new Label();
            txtCorreoEletronico = new TextBox();
            cmbSexo = new ComboBox();
            txtApellidoMaterno = new TextBox();
            txtApellidoPaterno = new TextBox();
            txtNombre = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox3 = new GroupBox();
            btnCancelar = new Button();
            btnBorrar = new Button();
            btnAgregar = new Button();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(357, 27);
            label1.Name = "label1";
            label1.Size = new Size(354, 54);
            label1.TabIndex = 0;
            label1.Text = "Alta del personal";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtNumero);
            groupBox1.Controls.Add(label15);
            groupBox1.Controls.Add(txtCorreoEletronico);
            groupBox1.Controls.Add(cmbSexo);
            groupBox1.Controls.Add(txtApellidoMaterno);
            groupBox1.Controls.Add(txtApellidoPaterno);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 95);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(719, 400);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informacion del empleado";
            // 
            // txtNumero
            // 
            txtNumero.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNumero.Location = new Point(283, 337);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(395, 39);
            txtNumero.TabIndex = 11;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.Location = new Point(23, 335);
            label15.Name = "label15";
            label15.Size = new Size(254, 38);
            label15.TabIndex = 10;
            label15.Text = "Numero de celular:";
            // 
            // txtCorreoEletronico
            // 
            txtCorreoEletronico.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCorreoEletronico.Location = new Point(279, 266);
            txtCorreoEletronico.Name = "txtCorreoEletronico";
            txtCorreoEletronico.Size = new Size(399, 39);
            txtCorreoEletronico.TabIndex = 9;
            // 
            // cmbSexo
            // 
            cmbSexo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbSexo.FormattingEnabled = true;
            cmbSexo.Location = new Point(108, 211);
            cmbSexo.Name = "cmbSexo";
            cmbSexo.Size = new Size(275, 40);
            cmbSexo.TabIndex = 8;
            // 
            // txtApellidoMaterno
            // 
            txtApellidoMaterno.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtApellidoMaterno.Location = new Point(279, 156);
            txtApellidoMaterno.Name = "txtApellidoMaterno";
            txtApellidoMaterno.Size = new Size(399, 39);
            txtApellidoMaterno.TabIndex = 7;
            // 
            // txtApellidoPaterno
            // 
            txtApellidoPaterno.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtApellidoPaterno.Location = new Point(279, 103);
            txtApellidoPaterno.Name = "txtApellidoPaterno";
            txtApellidoPaterno.Size = new Size(399, 39);
            txtApellidoPaterno.TabIndex = 6;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombre.Location = new Point(154, 56);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(524, 39);
            txtNombre.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(23, 264);
            label6.Name = "label6";
            label6.Size = new Size(260, 38);
            label6.TabIndex = 4;
            label6.Text = "Correo electrónico: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(23, 209);
            label5.Name = "label5";
            label5.Size = new Size(82, 38);
            label5.TabIndex = 3;
            label5.Text = "Sexo:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(23, 154);
            label4.Name = "label4";
            label4.Size = new Size(237, 38);
            label4.TabIndex = 2;
            label4.Text = "Apellido materno:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(23, 101);
            label3.Name = "label3";
            label3.Size = new Size(237, 38);
            label3.TabIndex = 1;
            label3.Text = "Apellido paterno: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(23, 54);
            label2.Name = "label2";
            label2.Size = new Size(125, 38);
            label2.TabIndex = 0;
            label2.Text = "Nombre:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnCancelar);
            groupBox3.Controls.Add(btnBorrar);
            groupBox3.Controls.Add(btnAgregar);
            groupBox3.Location = new Point(737, 95);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(277, 400);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Operaciones";
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = Color.FromArgb(192, 0, 0);
            btnCancelar.Location = new Point(70, 207);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(150, 50);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBorrar.ForeColor = Color.FromArgb(255, 128, 0);
            btnBorrar.Location = new Point(70, 146);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(150, 50);
            btnBorrar.TabIndex = 1;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click_1;
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.ForeColor = Color.Green;
            btnAgregar.Location = new Point(70, 74);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(150, 50);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // AgregarEmpleado
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1026, 536);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "AgregarEmpleado";
            Text = "AgregarEmpleado";
            Load += AgregarEmpleado_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private Label label6;
        private Label label5;
        private Label label4;
        private GroupBox groupBox3;
        private TextBox txtCorreoEletronico;
        private ComboBox cmbSexo;
        private TextBox txtApellidoMaterno;
        private TextBox txtApellidoPaterno;
        private TextBox txtNombre;
        private TextBox txtNumero;
        private Label label15;
        private Button btnCancelar;
        private Button btnBorrar;
        private Button btnAgregar;
    }
}