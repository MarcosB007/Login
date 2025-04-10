namespace Login.Ventanas
{
    partial class RegistrarClienteView
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
            tlBase = new TableLayoutPanel();
            label1 = new Label();
            lbNombre = new Label();
            lbApellido = new Label();
            lbDNI = new Label();
            lbCorreo = new Label();
            lbContraseña = new Label();
            textBoxNombre = new TextBox();
            textBoxApellido = new TextBox();
            textBoxDNI = new TextBox();
            textBoxCorreo = new TextBox();
            textBoxContraseña = new TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnAgregarUsuario = new Button();
            btnSalir = new Button();
            tlBase.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tlBase
            // 
            tlBase.BackColor = SystemColors.ActiveBorder;
            tlBase.ColumnCount = 2;
            tlBase.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.57754F));
            tlBase.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 83.42246F));
            tlBase.Controls.Add(label1, 0, 0);
            tlBase.Controls.Add(lbNombre, 0, 1);
            tlBase.Controls.Add(lbApellido, 0, 2);
            tlBase.Controls.Add(lbDNI, 0, 3);
            tlBase.Controls.Add(lbCorreo, 0, 4);
            tlBase.Controls.Add(lbContraseña, 0, 5);
            tlBase.Controls.Add(textBoxNombre, 1, 1);
            tlBase.Controls.Add(textBoxApellido, 1, 2);
            tlBase.Controls.Add(textBoxDNI, 1, 3);
            tlBase.Controls.Add(textBoxCorreo, 1, 4);
            tlBase.Controls.Add(textBoxContraseña, 1, 5);
            tlBase.Controls.Add(tableLayoutPanel1, 1, 7);
            tlBase.Dock = DockStyle.Fill;
            tlBase.Location = new Point(0, 0);
            tlBase.Name = "tlBase";
            tlBase.RowCount = 9;
            tlBase.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tlBase.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tlBase.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tlBase.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tlBase.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tlBase.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tlBase.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tlBase.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tlBase.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlBase.Size = new Size(561, 292);
            tlBase.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveBorder;
            tlBase.SetColumnSpan(label1, 2);
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(555, 50);
            label1.TabIndex = 0;
            label1.Text = "Registro de Usuarios";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbNombre
            // 
            lbNombre.AutoSize = true;
            lbNombre.Dock = DockStyle.Fill;
            lbNombre.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbNombre.Location = new Point(3, 50);
            lbNombre.Name = "lbNombre";
            lbNombre.Size = new Size(87, 30);
            lbNombre.TabIndex = 1;
            lbNombre.Text = "Nombre";
            lbNombre.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbApellido
            // 
            lbApellido.AutoSize = true;
            lbApellido.Dock = DockStyle.Fill;
            lbApellido.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbApellido.Location = new Point(3, 80);
            lbApellido.Name = "lbApellido";
            lbApellido.Size = new Size(87, 30);
            lbApellido.TabIndex = 2;
            lbApellido.Text = "Apellido";
            lbApellido.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbDNI
            // 
            lbDNI.AutoSize = true;
            lbDNI.Dock = DockStyle.Fill;
            lbDNI.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbDNI.Location = new Point(3, 110);
            lbDNI.Name = "lbDNI";
            lbDNI.Size = new Size(87, 30);
            lbDNI.TabIndex = 3;
            lbDNI.Text = "DNI";
            lbDNI.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbCorreo
            // 
            lbCorreo.AutoSize = true;
            lbCorreo.Dock = DockStyle.Fill;
            lbCorreo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbCorreo.Location = new Point(3, 140);
            lbCorreo.Name = "lbCorreo";
            lbCorreo.Size = new Size(87, 30);
            lbCorreo.TabIndex = 4;
            lbCorreo.Text = "Correo";
            lbCorreo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbContraseña
            // 
            lbContraseña.AutoSize = true;
            lbContraseña.Dock = DockStyle.Fill;
            lbContraseña.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbContraseña.Location = new Point(3, 170);
            lbContraseña.Name = "lbContraseña";
            lbContraseña.Size = new Size(87, 30);
            lbContraseña.TabIndex = 5;
            lbContraseña.Text = "Contraseña";
            lbContraseña.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBoxNombre
            // 
            textBoxNombre.Dock = DockStyle.Fill;
            textBoxNombre.Location = new Point(96, 53);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(462, 25);
            textBoxNombre.TabIndex = 6;
            // 
            // textBoxApellido
            // 
            textBoxApellido.Dock = DockStyle.Fill;
            textBoxApellido.Location = new Point(96, 83);
            textBoxApellido.Name = "textBoxApellido";
            textBoxApellido.Size = new Size(462, 25);
            textBoxApellido.TabIndex = 7;
            // 
            // textBoxDNI
            // 
            textBoxDNI.Dock = DockStyle.Fill;
            textBoxDNI.Location = new Point(96, 113);
            textBoxDNI.Name = "textBoxDNI";
            textBoxDNI.Size = new Size(462, 25);
            textBoxDNI.TabIndex = 8;
            // 
            // textBoxCorreo
            // 
            textBoxCorreo.Dock = DockStyle.Fill;
            textBoxCorreo.Location = new Point(96, 143);
            textBoxCorreo.Name = "textBoxCorreo";
            textBoxCorreo.Size = new Size(462, 25);
            textBoxCorreo.TabIndex = 9;
            // 
            // textBoxContraseña
            // 
            textBoxContraseña.Dock = DockStyle.Fill;
            textBoxContraseña.Location = new Point(96, 173);
            textBoxContraseña.Name = "textBoxContraseña";
            textBoxContraseña.Size = new Size(462, 25);
            textBoxContraseña.TabIndex = 10;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(btnAgregarUsuario, 1, 0);
            tableLayoutPanel1.Controls.Add(btnSalir, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(96, 233);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(462, 44);
            tableLayoutPanel1.TabIndex = 11;
            // 
            // btnAgregarUsuario
            // 
            btnAgregarUsuario.BackColor = Color.LimeGreen;
            btnAgregarUsuario.Dock = DockStyle.Fill;
            btnAgregarUsuario.Location = new Point(234, 3);
            btnAgregarUsuario.Name = "btnAgregarUsuario";
            btnAgregarUsuario.Size = new Size(225, 38);
            btnAgregarUsuario.TabIndex = 0;
            btnAgregarUsuario.Text = "Aceptar";
            btnAgregarUsuario.UseVisualStyleBackColor = false;
            btnAgregarUsuario.Click += btnAgregarUsuario_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.Red;
            btnSalir.Dock = DockStyle.Fill;
            btnSalir.Location = new Point(3, 3);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(225, 38);
            btnSalir.TabIndex = 1;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            // 
            // RegistrarClienteView
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(561, 292);
            Controls.Add(tlBase);
            Name = "RegistrarClienteView";
            Text = "RegistrarClienteView";
            tlBase.ResumeLayout(false);
            tlBase.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlBase;
        private Label label1;
        private Label lbNombre;
        private Label lbApellido;
        private Label lbDNI;
        private Label lbCorreo;
        private Label lbContraseña;
        private TextBox textBoxNombre;
        private TextBox textBoxApellido;
        private TextBox textBoxDNI;
        private TextBox textBoxCorreo;
        private TextBox textBoxContraseña;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnAgregarUsuario;
        private Button btnSalir;
    }
}