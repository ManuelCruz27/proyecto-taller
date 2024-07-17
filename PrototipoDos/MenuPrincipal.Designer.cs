namespace PrototipoDos
{
    partial class MenuPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            administradoreBindingSource = new BindingSource(components);
            menuStrip1 = new MenuStrip();
            empleadosToolStripMenuItem = new ToolStripMenuItem();
            verEmpleadosToolStripMenuItem = new ToolStripMenuItem();
            direcionDelEmpleadoToolStripMenuItem = new ToolStripMenuItem();
            actualizarEmpleadosToolStripMenuItem = new ToolStripMenuItem();
            inventarioToolStripMenuItem = new ToolStripMenuItem();
            agregarProductoToolStripMenuItem = new ToolStripMenuItem();
            agregarToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            metalesToolStripMenuItem = new ToolStripMenuItem();
            agregarMetalToolStripMenuItem = new ToolStripMenuItem();
            broquelerosToolStripMenuItem = new ToolStripMenuItem();
            salidasToolStripMenuItem = new ToolStripMenuItem();
            entradasToolStripMenuItem = new ToolStripMenuItem();
            verTrabajosToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)administradoreBindingSource).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // administradoreBindingSource
            // 
            administradoreBindingSource.DataSource = typeof(Models.Administradore);
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { empleadosToolStripMenuItem, inventarioToolStripMenuItem, broquelerosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 46);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // empleadosToolStripMenuItem
            // 
            empleadosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { verEmpleadosToolStripMenuItem, direcionDelEmpleadoToolStripMenuItem, actualizarEmpleadosToolStripMenuItem });
            empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            empleadosToolStripMenuItem.Size = new Size(184, 42);
            empleadosToolStripMenuItem.Text = "Empleados";
            // 
            // verEmpleadosToolStripMenuItem
            // 
            verEmpleadosToolStripMenuItem.Name = "verEmpleadosToolStripMenuItem";
            verEmpleadosToolStripMenuItem.Size = new Size(547, 46);
            verEmpleadosToolStripMenuItem.Text = "Información de los empleados";
            verEmpleadosToolStripMenuItem.Click += verEmpleadosToolStripMenuItem_Click;
            // 
            // direcionDelEmpleadoToolStripMenuItem
            // 
            direcionDelEmpleadoToolStripMenuItem.Name = "direcionDelEmpleadoToolStripMenuItem";
            direcionDelEmpleadoToolStripMenuItem.Size = new Size(547, 46);
            direcionDelEmpleadoToolStripMenuItem.Text = "Direcion del los empleado";
            // 
            // actualizarEmpleadosToolStripMenuItem
            // 
            actualizarEmpleadosToolStripMenuItem.Name = "actualizarEmpleadosToolStripMenuItem";
            actualizarEmpleadosToolStripMenuItem.Size = new Size(547, 46);
            actualizarEmpleadosToolStripMenuItem.Text = "Actualizar empleados";
            actualizarEmpleadosToolStripMenuItem.Click += actualizarEmpleadosToolStripMenuItem_Click;
            // 
            // inventarioToolStripMenuItem
            // 
            inventarioToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { agregarProductoToolStripMenuItem, toolStripSeparator1, metalesToolStripMenuItem });
            inventarioToolStripMenuItem.Name = "inventarioToolStripMenuItem";
            inventarioToolStripMenuItem.Size = new Size(178, 42);
            inventarioToolStripMenuItem.Text = "Inventario";
            // 
            // agregarProductoToolStripMenuItem
            // 
            agregarProductoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { agregarToolStripMenuItem });
            agregarProductoToolStripMenuItem.Name = "agregarProductoToolStripMenuItem";
            agregarProductoToolStripMenuItem.Size = new Size(266, 46);
            agregarProductoToolStripMenuItem.Text = "Productos";
            agregarProductoToolStripMenuItem.Click += agregarProductoToolStripMenuItem_Click;
            // 
            // agregarToolStripMenuItem
            // 
            agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            agregarToolStripMenuItem.Size = new Size(373, 46);
            agregarToolStripMenuItem.Text = "Agregar producto";
            agregarToolStripMenuItem.Click += agregarToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(263, 6);
            // 
            // metalesToolStripMenuItem
            // 
            metalesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { agregarMetalToolStripMenuItem });
            metalesToolStripMenuItem.Name = "metalesToolStripMenuItem";
            metalesToolStripMenuItem.Size = new Size(266, 46);
            metalesToolStripMenuItem.Text = "Metales";
            // 
            // agregarMetalToolStripMenuItem
            // 
            agregarMetalToolStripMenuItem.Name = "agregarMetalToolStripMenuItem";
            agregarMetalToolStripMenuItem.Size = new Size(326, 46);
            agregarMetalToolStripMenuItem.Text = "Agregar Metal";
            agregarMetalToolStripMenuItem.Click += agregarMetalToolStripMenuItem_Click;
            // 
            // broquelerosToolStripMenuItem
            // 
            broquelerosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { salidasToolStripMenuItem, entradasToolStripMenuItem, verTrabajosToolStripMenuItem });
            broquelerosToolStripMenuItem.Name = "broquelerosToolStripMenuItem";
            broquelerosToolStripMenuItem.Size = new Size(203, 42);
            broquelerosToolStripMenuItem.Text = "Broqueleros";
            // 
            // salidasToolStripMenuItem
            // 
            salidasToolStripMenuItem.Name = "salidasToolStripMenuItem";
            salidasToolStripMenuItem.Size = new Size(303, 46);
            salidasToolStripMenuItem.Text = "Crear pedido";
            salidasToolStripMenuItem.Click += salidasToolStripMenuItem_Click;
            // 
            // entradasToolStripMenuItem
            // 
            entradasToolStripMenuItem.Name = "entradasToolStripMenuItem";
            entradasToolStripMenuItem.Size = new Size(347, 46);
            entradasToolStripMenuItem.Text = "Finalizar pedido";
            entradasToolStripMenuItem.Click += entradasToolStripMenuItem_Click;
            // 
            // verTrabajosToolStripMenuItem
            // 
            verTrabajosToolStripMenuItem.Name = "verTrabajosToolStripMenuItem";
            verTrabajosToolStripMenuItem.Size = new Size(347, 46);
            verTrabajosToolStripMenuItem.Text = "Ver pedido";
            verTrabajosToolStripMenuItem.Click += verTrabajosToolStripMenuItem_Click;
            // 
            // panel1
            // 
            panel1.Location = new Point(18, 48);
            panel1.Name = "panel1";
            panel1.Size = new Size(770, 390);
            panel1.TabIndex = 3;
            panel1.Paint += panel1_Paint;
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MenuPrincipal";
            Text = "Menu de navegación";
            Load += Form1_Load;
            Resize += MenuPrincipal_Resize;
            ((System.ComponentModel.ISupportInitialize)administradoreBindingSource).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private BindingSource administradoreBindingSource;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem empleadosToolStripMenuItem;
        private ToolStripMenuItem verEmpleadosToolStripMenuItem;
        private Panel panel1;
        private ToolStripMenuItem direcionDelEmpleadoToolStripMenuItem;
        private ToolStripMenuItem actualizarEmpleadosToolStripMenuItem;
        private ToolStripMenuItem inventarioToolStripMenuItem;
        private ToolStripMenuItem agregarProductoToolStripMenuItem;
        private ToolStripMenuItem agregarToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem metalesToolStripMenuItem;
        private ToolStripMenuItem agregarMetalToolStripMenuItem;
        private ToolStripMenuItem broquelerosToolStripMenuItem;
        private ToolStripMenuItem salidasToolStripMenuItem;
        private ToolStripMenuItem entradasToolStripMenuItem;
        private ToolStripMenuItem verTrabajosToolStripMenuItem;
    }
}
