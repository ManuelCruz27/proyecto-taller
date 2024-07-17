namespace PrototipoDos.Inventario
{
    partial class AgregarMetales
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
            cmbTipoMatal = new ComboBox();
            txtTipoMetal = new TextBox();
            label4 = new Label();
            txtKilataje = new TextBox();
            label5 = new Label();
            txtGramos = new TextBox();
            btnAgregar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(234, 32);
            label1.Name = "label1";
            label1.Size = new Size(283, 45);
            label1.TabIndex = 0;
            label1.Text = "Agregar Metales";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(37, 107);
            label2.Name = "label2";
            label2.Size = new Size(224, 45);
            label2.TabIndex = 1;
            label2.Text = "Tipo de metal:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(37, 184);
            label3.Name = "label3";
            label3.Size = new Size(587, 32);
            label3.TabIndex = 2;
            label3.Text = "Encaso de ser otro metal escriba el nombre del metal:";
            label3.Click += label3_Click;
            // 
            // cmbTipoMatal
            // 
            cmbTipoMatal.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbTipoMatal.FormattingEnabled = true;
            cmbTipoMatal.Location = new Point(267, 109);
            cmbTipoMatal.Name = "cmbTipoMatal";
            cmbTipoMatal.Size = new Size(232, 46);
            cmbTipoMatal.TabIndex = 4;
            // 
            // txtTipoMetal
            // 
            txtTipoMetal.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTipoMetal.Location = new Point(630, 176);
            txtTipoMetal.Name = "txtTipoMetal";
            txtTipoMetal.Size = new Size(282, 45);
            txtTipoMetal.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(37, 247);
            label4.Name = "label4";
            label4.Size = new Size(379, 45);
            label4.TabIndex = 6;
            label4.Text = "kilataje ó nivel de pureza:";
            // 
            // txtKilataje
            // 
            txtKilataje.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtKilataje.Location = new Point(431, 249);
            txtKilataje.Name = "txtKilataje";
            txtKilataje.Size = new Size(200, 45);
            txtKilataje.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(37, 318);
            label5.Name = "label5";
            label5.Size = new Size(137, 45);
            label5.TabIndex = 8;
            label5.Text = "Gramos:";
            // 
            // txtGramos
            // 
            txtGramos.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtGramos.Location = new Point(200, 320);
            txtGramos.Name = "txtGramos";
            txtGramos.Size = new Size(197, 45);
            txtGramos.TabIndex = 9;
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.ForeColor = Color.Green;
            btnAgregar.Location = new Point(548, 428);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(160, 55);
            btnAgregar.TabIndex = 10;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // AgregarMetales
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(942, 513);
            Controls.Add(btnAgregar);
            Controls.Add(txtGramos);
            Controls.Add(label5);
            Controls.Add(txtKilataje);
            Controls.Add(label4);
            Controls.Add(txtTipoMetal);
            Controls.Add(cmbTipoMatal);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AgregarMetales";
            Text = "AgregarMetales";
            Load += AgregarMetales_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cmbTipoMatal;
        private TextBox txtTipoMetal;
        private Label label4;
        private TextBox txtKilataje;
        private Label label5;
        private TextBox txtGramos;
        private Button btnAgregar;
    }
}