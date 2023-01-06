namespace A_MELHOR_TRUFA.Fomularios
{
    partial class frmLogin
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
            this.pnlPai = new System.Windows.Forms.Panel();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.btnAcessar = new System.Windows.Forms.Button();
            this.ckLembrarMe = new System.Windows.Forms.CheckBox();
            this.pnlPai.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPai
            // 
            this.pnlPai.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlPai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(85)))), ((int)(((byte)(11)))));
            this.pnlPai.Controls.Add(this.ckLembrarMe);
            this.pnlPai.Controls.Add(this.btnAcessar);
            this.pnlPai.Controls.Add(this.lblSenha);
            this.pnlPai.Controls.Add(this.lblUsuario);
            this.pnlPai.Controls.Add(this.txtSenha);
            this.pnlPai.Controls.Add(this.txtUsuario);
            this.pnlPai.Font = new System.Drawing.Font("Segoe UI Semibold", 9.25F);
            this.pnlPai.Location = new System.Drawing.Point(142, 60);
            this.pnlPai.MaximumSize = new System.Drawing.Size(626, 442);
            this.pnlPai.Name = "pnlPai";
            this.pnlPai.Size = new System.Drawing.Size(517, 330);
            this.pnlPai.TabIndex = 0;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUsuario.Location = new System.Drawing.Point(166, 133);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(208, 24);
            this.txtUsuario.TabIndex = 0;
            // 
            // txtSenha
            // 
            this.txtSenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSenha.Location = new System.Drawing.Point(166, 196);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(208, 24);
            this.txtSenha.TabIndex = 1;
            this.txtSenha.UseSystemPasswordChar = true;
            // 
            // lblUsuario
            // 
            this.lblUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(163, 108);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(54, 17);
            this.lblUsuario.TabIndex = 2;
            this.lblUsuario.Text = "Usuário";
            // 
            // lblSenha
            // 
            this.lblSenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(163, 171);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(45, 17);
            this.lblSenha.TabIndex = 3;
            this.lblSenha.Text = "Senha";
            // 
            // btnAcessar
            // 
            this.btnAcessar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAcessar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAcessar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnAcessar.Location = new System.Drawing.Point(284, 236);
            this.btnAcessar.Name = "btnAcessar";
            this.btnAcessar.Size = new System.Drawing.Size(90, 30);
            this.btnAcessar.TabIndex = 4;
            this.btnAcessar.Text = "Acessar";
            this.btnAcessar.UseVisualStyleBackColor = true;
            // 
            // ckLembrarMe
            // 
            this.ckLembrarMe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ckLembrarMe.AutoSize = true;
            this.ckLembrarMe.Location = new System.Drawing.Point(166, 243);
            this.ckLembrarMe.Name = "ckLembrarMe";
            this.ckLembrarMe.Size = new System.Drawing.Size(100, 21);
            this.ckLembrarMe.TabIndex = 5;
            this.ckLembrarMe.Text = "Lembrar-me";
            this.ckLembrarMe.UseVisualStyleBackColor = true;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(141)))), ((int)(((byte)(92)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlPai);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F);
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "A melhor trufa | Login";
            this.pnlPai.ResumeLayout(false);
            this.pnlPai.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlPai;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Button btnAcessar;
        private System.Windows.Forms.CheckBox ckLembrarMe;
    }
}