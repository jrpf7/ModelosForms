
namespace OrdemDeProducao.Forms
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.pbxUsuario = new System.Windows.Forms.PictureBox();
            this.pbxSenha = new System.Windows.Forms.PictureBox();
            this.pnlSenha = new System.Windows.Forms.Panel();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblVersao = new System.Windows.Forms.Label();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.pnlUsuario = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSenha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUsuario.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUsuario.ForeColor = System.Drawing.Color.White;
            this.txtUsuario.Location = new System.Drawing.Point(79, 149);
            this.txtUsuario.MaxLength = 30;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(200, 20);
            this.txtUsuario.TabIndex = 0;
            this.txtUsuario.Text = "USUÁRIO";
            this.txtUsuario.Enter += new System.EventHandler(this.txtUsuario_Enter);
            this.txtUsuario.Leave += new System.EventHandler(this.txtUsuario_Leave);
            // 
            // pbxUsuario
            // 
            this.pbxUsuario.Image = ((System.Drawing.Image)(resources.GetObject("pbxUsuario.Image")));
            this.pbxUsuario.Location = new System.Drawing.Point(42, 136);
            this.pbxUsuario.Name = "pbxUsuario";
            this.pbxUsuario.Size = new System.Drawing.Size(34, 34);
            this.pbxUsuario.TabIndex = 2;
            this.pbxUsuario.TabStop = false;
            // 
            // pbxSenha
            // 
            this.pbxSenha.Image = ((System.Drawing.Image)(resources.GetObject("pbxSenha.Image")));
            this.pbxSenha.Location = new System.Drawing.Point(42, 189);
            this.pbxSenha.Name = "pbxSenha";
            this.pbxSenha.Size = new System.Drawing.Size(34, 34);
            this.pbxSenha.TabIndex = 5;
            this.pbxSenha.TabStop = false;
            // 
            // pnlSenha
            // 
            this.pnlSenha.BackColor = System.Drawing.Color.White;
            this.pnlSenha.Location = new System.Drawing.Point(42, 225);
            this.pnlSenha.Name = "pnlSenha";
            this.pnlSenha.Size = new System.Drawing.Size(237, 1);
            this.pnlSenha.TabIndex = 4;
            // 
            // txtSenha
            // 
            this.txtSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSenha.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSenha.ForeColor = System.Drawing.Color.White;
            this.txtSenha.Location = new System.Drawing.Point(79, 205);
            this.txtSenha.MaxLength = 50;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(200, 20);
            this.txtSenha.TabIndex = 3;
            this.txtSenha.Text = "SENHA";
            this.txtSenha.Enter += new System.EventHandler(this.txtSenha_Enter);
            this.txtSenha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSenha_KeyPress);
            this.txtSenha.Leave += new System.EventHandler(this.txtSenha_Leave);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(42, 263);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(237, 29);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "Entrar";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblVersao
            // 
            this.lblVersao.AutoSize = true;
            this.lblVersao.ForeColor = System.Drawing.Color.White;
            this.lblVersao.Location = new System.Drawing.Point(110, 391);
            this.lblVersao.Name = "lblVersao";
            this.lblVersao.Size = new System.Drawing.Size(110, 15);
            this.lblVersao.TabIndex = 7;
            this.lblVersao.Text = "Versão do Sistema -";
            // 
            // pbxLogo
            // 
            this.pbxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbxLogo.Image")));
            this.pbxLogo.Location = new System.Drawing.Point(128, 32);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(69, 68);
            this.pbxLogo.TabIndex = 8;
            this.pbxLogo.TabStop = false;
            // 
            // pnlUsuario
            // 
            this.pnlUsuario.BackColor = System.Drawing.Color.White;
            this.pnlUsuario.Location = new System.Drawing.Point(42, 169);
            this.pnlUsuario.Name = "pnlUsuario";
            this.pnlUsuario.Size = new System.Drawing.Size(237, 1);
            this.pnlUsuario.TabIndex = 5;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.FlatAppearance.BorderSize = 2;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSair.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnSair.Location = new System.Drawing.Point(42, 313);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(237, 29);
            this.btnSair.TabIndex = 9;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(322, 415);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.pnlUsuario);
            this.Controls.Add(this.pbxLogo);
            this.Controls.Add(this.lblVersao);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.pbxSenha);
            this.Controls.Add(this.pnlSenha);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.pbxUsuario);
            this.Controls.Add(this.txtUsuario);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pbxUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSenha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.PictureBox pbxUsuario;
        private System.Windows.Forms.PictureBox pbxSenha;
        private System.Windows.Forms.Panel pnlSenha;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblVersao;
        private System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.Panel pnlUsuario;
        private System.Windows.Forms.Button btnSair;
    }
}