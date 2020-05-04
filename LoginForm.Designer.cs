namespace Login
{
    partial class LoginForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this._btnIngresar = new System.Windows.Forms.Button();
            this._btnCrearCuenta = new System.Windows.Forms.Button();
            this._pass = new System.Windows.Forms.TextBox();
            this._usuario = new System.Windows.Forms.TextBox();
            this._labelUsuario = new System.Windows.Forms.Label();
            this._labelPass = new System.Windows.Forms.Label();
            this._labelTitulo = new System.Windows.Forms.Label();
            this._labelLinkRecuperar = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // _btnIngresar
            // 
            this._btnIngresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this._btnIngresar.Location = new System.Drawing.Point(246, 207);
            this._btnIngresar.Name = "_btnIngresar";
            this._btnIngresar.Size = new System.Drawing.Size(82, 35);
            this._btnIngresar.TabIndex = 0;
            this._btnIngresar.Text = "Ingresar";
            this._btnIngresar.UseVisualStyleBackColor = true;
            this._btnIngresar.Click += new System.EventHandler(this._btnIngresar_Click);
            // 
            // _btnCrearCuenta
            // 
            this._btnCrearCuenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this._btnCrearCuenta.Location = new System.Drawing.Point(401, 207);
            this._btnCrearCuenta.Name = "_btnCrearCuenta";
            this._btnCrearCuenta.Size = new System.Drawing.Size(92, 35);
            this._btnCrearCuenta.TabIndex = 1;
            this._btnCrearCuenta.Text = "Crear cuenta";
            this._btnCrearCuenta.UseVisualStyleBackColor = true;
            this._btnCrearCuenta.Click += new System.EventHandler(this._btnCrearCuenta_Click);
            // 
            // _pass
            // 
            this._pass.Location = new System.Drawing.Point(332, 127);
            this._pass.Name = "_pass";
            this._pass.PasswordChar = '?';
            this._pass.Size = new System.Drawing.Size(161, 20);
            this._pass.TabIndex = 2;
            // 
            // _usuario
            // 
            this._usuario.Location = new System.Drawing.Point(332, 88);
            this._usuario.Name = "_usuario";
            this._usuario.Size = new System.Drawing.Size(161, 20);
            this._usuario.TabIndex = 3;
            // 
            // _labelUsuario
            // 
            this._labelUsuario.AutoSize = true;
            this._labelUsuario.Location = new System.Drawing.Point(243, 95);
            this._labelUsuario.Name = "_labelUsuario";
            this._labelUsuario.Size = new System.Drawing.Size(43, 13);
            this._labelUsuario.TabIndex = 4;
            this._labelUsuario.Text = "Usuario";
            // 
            // _labelPass
            // 
            this._labelPass.AutoSize = true;
            this._labelPass.Location = new System.Drawing.Point(243, 134);
            this._labelPass.Name = "_labelPass";
            this._labelPass.Size = new System.Drawing.Size(61, 13);
            this._labelPass.TabIndex = 5;
            this._labelPass.Text = "Contraseña";
            // 
            // _labelTitulo
            // 
            this._labelTitulo.AutoSize = true;
            this._labelTitulo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this._labelTitulo.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._labelTitulo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this._labelTitulo.Location = new System.Drawing.Point(196, 29);
            this._labelTitulo.Name = "_labelTitulo";
            this._labelTitulo.Size = new System.Drawing.Size(394, 33);
            this._labelTitulo.TabIndex = 6;
            this._labelTitulo.Text = "Sistema altamente seguro de login";
            // 
            // _labelLinkRecuperar
            // 
            this._labelLinkRecuperar.AutoSize = true;
            this._labelLinkRecuperar.Location = new System.Drawing.Point(243, 172);
            this._labelLinkRecuperar.Name = "_labelLinkRecuperar";
            this._labelLinkRecuperar.Size = new System.Drawing.Size(267, 13);
            this._labelLinkRecuperar.TabIndex = 7;
            this._labelLinkRecuperar.TabStop = true;
            this._labelLinkRecuperar.Text = "¿Olvido su contraseña? haz click aqui para recuperarla";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._labelLinkRecuperar);
            this.Controls.Add(this._labelTitulo);
            this.Controls.Add(this._labelPass);
            this.Controls.Add(this._labelUsuario);
            this.Controls.Add(this._usuario);
            this.Controls.Add(this._pass);
            this.Controls.Add(this._btnCrearCuenta);
            this.Controls.Add(this._btnIngresar);
            this.Name = "LoginForm";
            this.Text = "Log in";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _btnIngresar;
        private System.Windows.Forms.Button _btnCrearCuenta;
        private System.Windows.Forms.TextBox _pass;
        private System.Windows.Forms.TextBox _usuario;
        private System.Windows.Forms.Label _labelUsuario;
        private System.Windows.Forms.Label _labelPass;
        private System.Windows.Forms.Label _labelTitulo;
        private System.Windows.Forms.LinkLabel _labelLinkRecuperar;
    }
}

