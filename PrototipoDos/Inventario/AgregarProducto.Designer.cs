namespace PrototipoDos.Inventario
{
    partial class AgregarProducto
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtCodigo = new TextBox();
            txtNombreProducto = new TextBox();
            txtModeloONumero = new TextBox();
            label7 = new Label();
            txtPrecioPorPar = new TextBox();
            cmbTipoDeMetal = new ComboBox();
            btnAgregar = new Button();
            btnCancelar = new Button();
            cmbKilataje = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(182, 26);
            label1.Name = "label1";
            label1.Size = new Size(304, 45);
            label1.TabIndex = 0;
            label1.Text = "Agregar Producto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 174);
            label2.Name = "label2";
            label2.Size = new Size(338, 45);
            label2.TabIndex = 1;
            label2.Text = "Nombre del producto:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(32, 235);
            label3.Name = "label3";
            label3.Size = new Size(286, 45);
            label3.TabIndex = 2;
            label3.Text = "Modelo ó numero:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(59, 402);
            label4.Name = "label4";
            label4.Size = new Size(259, 45);
            label4.TabIndex = 3;
            label4.Text = "Tipo de material:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 119);
            label5.Name = "label5";
            label5.Size = new Size(306, 45);
            label5.TabIndex = 4;
            label5.Text = "Codigo relacionado:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(90, 312);
            label6.Name = "label6";
            label6.Size = new Size(228, 45);
            label6.TabIndex = 5;
            label6.Text = "Precio por par:";
            // 
            // txtCodigo
            // 
            txtCodigo.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCodigo.Location = new Point(356, 121);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(240, 45);
            txtCodigo.TabIndex = 6;
            txtCodigo.TextChanged += textBox1_TextChanged;
            // 
            // txtNombreProducto
            // 
            txtNombreProducto.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombreProducto.Location = new Point(356, 176);
            txtNombreProducto.Name = "txtNombreProducto";
            txtNombreProducto.Size = new Size(240, 45);
            txtNombreProducto.TabIndex = 7;
            txtNombreProducto.TextChanged += txtNombreProcu_TextChanged;
            // 
            // txtModeloONumero
            // 
            txtModeloONumero.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtModeloONumero.Location = new Point(356, 237);
            txtModeloONumero.Name = "txtModeloONumero";
            txtModeloONumero.Size = new Size(240, 45);
            txtModeloONumero.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(182, 499);
            label7.Name = "label7";
            label7.Size = new Size(130, 45);
            label7.TabIndex = 13;
            label7.Text = "Kilataje:";
            // 
            // txtPrecioPorPar
            // 
            txtPrecioPorPar.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPrecioPorPar.Location = new Point(356, 314);
            txtPrecioPorPar.Name = "txtPrecioPorPar";
            txtPrecioPorPar.Size = new Size(240, 45);
            txtPrecioPorPar.TabIndex = 14;
            // 
            // cmbTipoDeMetal
            // 
            cmbTipoDeMetal.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbTipoDeMetal.FormattingEnabled = true;
            cmbTipoDeMetal.Location = new Point(356, 404);
            cmbTipoDeMetal.Name = "cmbTipoDeMetal";
            cmbTipoDeMetal.Size = new Size(240, 46);
            cmbTipoDeMetal.TabIndex = 15;
            cmbTipoDeMetal.SelectedIndexChanged += cmbTipoDeMetal_SelectedIndexChanged;
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.ForeColor = Color.Green;
            btnAgregar.Location = new Point(319, 609);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(160, 55);
            btnAgregar.TabIndex = 17;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click_1;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = Color.Maroon;
            btnCancelar.Location = new Point(485, 609);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(175, 55);
            btnCancelar.TabIndex = 18;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // cmbKilataje
            // 
            cmbKilataje.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbKilataje.FormattingEnabled = true;
            cmbKilataje.Location = new Point(356, 498);
            cmbKilataje.Name = "cmbKilataje";
            cmbKilataje.Size = new Size(240, 46);
            cmbKilataje.TabIndex = 19;
            // 
            // AgregarProducto
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(693, 719);
            Controls.Add(cmbKilataje);
            Controls.Add(btnCancelar);
            Controls.Add(btnAgregar);
            Controls.Add(cmbTipoDeMetal);
            Controls.Add(txtPrecioPorPar);
            Controls.Add(label7);
            Controls.Add(txtModeloONumero);
            Controls.Add(txtNombreProducto);
            Controls.Add(txtCodigo);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AgregarProducto";
            Text = "AgregarProducto";
            Load += AgregarProducto_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtCodigo;
        private TextBox txtNombreProducto;
        private TextBox txtModeloONumero;
        private Label label7;
        private TextBox txtPrecioPorPar;
        private ComboBox cmbTipoDeMetal;
        private Button btnAgregar;
        private Button btnCancelar;
        private ComboBox cmbKilataje;
    }
}