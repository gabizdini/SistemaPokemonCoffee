namespace SistemaCadastro
{
    partial class FrmAddCategoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddCategoria));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.txtInsereCategoria = new System.Windows.Forms.TextBox();
            this.BtnAddCategoria = new System.Windows.Forms.Button();
            this.btnFecharAddCategoria = new System.Windows.Forms.Button();
            this.lblnome = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Firebrick;
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(155, 322);
            this.panel1.TabIndex = 3;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.Location = new System.Drawing.Point(10, 96);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(134, 130);
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // txtInsereCategoria
            // 
            this.txtInsereCategoria.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtInsereCategoria.Location = new System.Drawing.Point(332, 144);
            this.txtInsereCategoria.Name = "txtInsereCategoria";
            this.txtInsereCategoria.Size = new System.Drawing.Size(385, 29);
            this.txtInsereCategoria.TabIndex = 18;
            // 
            // BtnAddCategoria
            // 
            this.BtnAddCategoria.BackColor = System.Drawing.Color.Transparent;
            this.BtnAddCategoria.FlatAppearance.BorderSize = 0;
            this.BtnAddCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAddCategoria.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddCategoria.ForeColor = System.Drawing.Color.White;
            this.BtnAddCategoria.Image = ((System.Drawing.Image)(resources.GetObject("BtnAddCategoria.Image")));
            this.BtnAddCategoria.Location = new System.Drawing.Point(381, 236);
            this.BtnAddCategoria.Name = "BtnAddCategoria";
            this.BtnAddCategoria.Size = new System.Drawing.Size(158, 49);
            this.BtnAddCategoria.TabIndex = 21;
            this.BtnAddCategoria.Text = "&Confirmar";
            this.BtnAddCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAddCategoria.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAddCategoria.UseVisualStyleBackColor = false;
            this.BtnAddCategoria.Click += new System.EventHandler(this.BtnInsereCategoria_Click);
            // 
            // btnFecharAddCategoria
            // 
            this.btnFecharAddCategoria.BackColor = System.Drawing.Color.Transparent;
            this.btnFecharAddCategoria.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFecharAddCategoria.BackgroundImage")));
            this.btnFecharAddCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFecharAddCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFecharAddCategoria.Location = new System.Drawing.Point(705, 12);
            this.btnFecharAddCategoria.Name = "btnFecharAddCategoria";
            this.btnFecharAddCategoria.Size = new System.Drawing.Size(48, 48);
            this.btnFecharAddCategoria.TabIndex = 23;
            this.btnFecharAddCategoria.UseVisualStyleBackColor = false;
            this.btnFecharAddCategoria.Click += new System.EventHandler(this.btnFecharAddCategoria_Click);
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.BackColor = System.Drawing.Color.Gold;
            this.lblnome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblnome.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnome.ForeColor = System.Drawing.Color.Blue;
            this.lblnome.Location = new System.Drawing.Point(176, 149);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(146, 21);
            this.lblnome.TabIndex = 24;
            this.lblnome.Text = "Nova categoria:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Gold;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(313, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(278, 31);
            this.label2.TabIndex = 25;
            this.label2.Text = "Adicionar Categoria";
            // 
            // FrmAddCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(765, 322);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblnome);
            this.Controls.Add(this.btnFecharAddCategoria);
            this.Controls.Add(this.BtnAddCategoria);
            this.Controls.Add(this.txtInsereCategoria);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAddCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAddCategoria";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtInsereCategoria;
        private System.Windows.Forms.Button BtnAddCategoria;
        private System.Windows.Forms.Button btnFecharAddCategoria;
        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}