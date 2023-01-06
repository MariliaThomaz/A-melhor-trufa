namespace A_MELHOR_TRUFA.Fomularios.Dashboard
{
    partial class frmDashboard
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
            this.pnlFerramentas = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnlFerramentas
            // 
            this.pnlFerramentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(85)))), ((int)(((byte)(11)))));
            this.pnlFerramentas.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlFerramentas.Location = new System.Drawing.Point(0, 0);
            this.pnlFerramentas.Name = "pnlFerramentas";
            this.pnlFerramentas.Size = new System.Drawing.Size(176, 450);
            this.pnlFerramentas.TabIndex = 0;
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlFerramentas);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "frmDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "A melhor trufa";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFerramentas;
    }
}