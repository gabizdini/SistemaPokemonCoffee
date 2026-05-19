namespace SistemaCadastro
{
    partial class FrmDelCategoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDelCategoria));
            this.BtnDelCategoria = new System.Windows.Forms.Button();
            this.cbDelCategoria = new System.Windows.Forms.ComboBox();
            this.lblcategoria = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnFecharDelCategoria = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnDelCategoria
            // 
            this.BtnDelCategoria.BackColor = System.Drawing.Color.Transparent;
            this.BtnDelCategoria.FlatAppearance.BorderSize = 0;
            this.BtnDelCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnDelCategoria.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelCategoria.ForeColor = System.Drawing.Color.White;
            this.BtnDelCategoria.Image = ((System.Drawing.Image)(resources.GetObject("BtnDelCategoria.Image")));
            this.BtnDelCategoria.Location = new System.Drawing.Point(381, 236);
            this.BtnDelCategoria.Name = "BtnDelCategoria";
            this.BtnDelCategoria.Size = new System.Drawing.Size(158, 49);
            this.BtnDelCategoria.TabIndex = 22;
            this.BtnDelCategoria.Text = "&Confirmar";
            this.BtnDelCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDelCategoria.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnDelCategoria.UseVisualStyleBackColor = false;
            this.BtnDelCategoria.Click += new System.EventHandler(this.BtnDelCategoria_Click);
            // 
            // cbDelCategoria
            // 
            this.cbDelCategoria.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbDelCategoria.BackColor = System.Drawing.Color.White;
            this.cbDelCategoria.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbDelCategoria.FormattingEnabled = true;
            this.cbDelCategoria.Location = new System.Drawing.Point(332, 144);
            this.cbDelCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.cbDelCategoria.Name = "cbDelCategoria";
            this.cbDelCategoria.Size = new System.Drawing.Size(385, 29);
            this.cbDelCategoria.TabIndex = 23;
            this.cbDelCategoria.SelectedIndexChanged += new System.EventHandler(this.cbDelCategoria_SelectedIndexChanged);
            // 
            // lblcategoria
            // 
            this.lblcategoria.AutoSize = true;
            this.lblcategoria.BackColor = System.Drawing.Color.Gold;
            this.lblcategoria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblcategoria.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblcategoria.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcategoria.ForeColor = System.Drawing.Color.Blue;
            this.lblcategoria.Location = new System.Drawing.Point(196, 149);
            this.lblcategoria.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblcategoria.Name = "lblcategoria";
            this.lblcategoria.Size = new System.Drawing.Size(101, 21);
            this.lblcategoria.TabIndex = 24;
            this.lblcategoria.Text = "Categoria:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Firebrick;
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(155, 322);
            this.panel1.TabIndex = 25;
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
            // btnFecharDelCategoria
            // 
            this.btnFecharDelCategoria.BackColor = System.Drawing.Color.Transparent;
            this.btnFecharDelCategoria.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFecharDelCategoria.BackgroundImage")));
            this.btnFecharDelCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFecharDelCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFecharDelCategoria.Location = new System.Drawing.Point(705, 12);
            this.btnFecharDelCategoria.Name = "btnFecharDelCategoria";
            this.btnFecharDelCategoria.Size = new System.Drawing.Size(48, 48);
            this.btnFecharDelCategoria.TabIndex = 26;
            this.btnFecharDelCategoria.UseVisualStyleBackColor = false;
            this.btnFecharDelCategoria.Click += new System.EventHandler(this.btnFecharDelCategoria_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Gold;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(332, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(253, 31);
            this.label2.TabIndex = 27;
            this.label2.Text = "Deletar Categoria";
            // 
            // FrmDelCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(765, 322);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnFecharDelCategoria);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cbDelCategoria);
            this.Controls.Add(this.lblcategoria);
            this.Controls.Add(this.BtnDelCategoria);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDelCategoria";
            this.Text = "FrmDelCategoria";
            this.Load += new System.EventHandler(this.FrmDelCategoria_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnDelCategoria;
        private System.Windows.Forms.ComboBox cbDelCategoria;
        private System.Windows.Forms.Label lblcategoria;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnFecharDelCategoria;
        private System.Windows.Forms.Label label2;
    }
}