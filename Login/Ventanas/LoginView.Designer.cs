namespace Login
{
    partial class LoginView
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
            tableLayoutPanel1 = new TableLayoutPanel();
            lbUsuario = new Label();
            tbUsuario = new TextBox();
            lbPassword = new Label();
            tbPassword = new TextBox();
            btnIngresar = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.4647884F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 52.1126747F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.Controls.Add(lbUsuario, 1, 1);
            tableLayoutPanel1.Controls.Add(tbUsuario, 2, 1);
            tableLayoutPanel1.Controls.Add(lbPassword, 1, 2);
            tableLayoutPanel1.Controls.Add(tbPassword, 2, 2);
            tableLayoutPanel1.Controls.Add(btnIngresar, 2, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 22.2222214F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 22.2222214F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 22.2222214F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.Size = new Size(284, 141);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // lbUsuario
            // 
            lbUsuario.AutoSize = true;
            lbUsuario.Dock = DockStyle.Fill;
            lbUsuario.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbUsuario.Location = new Point(31, 23);
            lbUsuario.Name = "lbUsuario";
            lbUsuario.Size = new Size(72, 31);
            lbUsuario.TabIndex = 0;
            lbUsuario.Text = "Usser";
            lbUsuario.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tbUsuario
            // 
            tbUsuario.Dock = DockStyle.Fill;
            tbUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbUsuario.Location = new Point(109, 26);
            tbUsuario.Name = "tbUsuario";
            tbUsuario.Size = new Size(142, 29);
            tbUsuario.TabIndex = 1;
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Dock = DockStyle.Fill;
            lbPassword.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbPassword.Location = new Point(31, 54);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(72, 31);
            lbPassword.TabIndex = 2;
            lbPassword.Text = "Password";
            lbPassword.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tbPassword
            // 
            tbPassword.Dock = DockStyle.Fill;
            tbPassword.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbPassword.Location = new Point(109, 57);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(142, 29);
            tbPassword.TabIndex = 3;
            // 
            // btnIngresar
            // 
            btnIngresar.Dock = DockStyle.Fill;
            btnIngresar.Location = new Point(109, 88);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(142, 25);
            btnIngresar.TabIndex = 4;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btn_Conectar;
            // 
            // LoginView
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 141);
            Controls.Add(tableLayoutPanel1);
            Name = "LoginView";
            Text = "Form1";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label lbUsuario;
        private TextBox tbUsuario;
        private Label lbPassword;
        private TextBox tbPassword;
        private Button btnIngresar;
    }
}
