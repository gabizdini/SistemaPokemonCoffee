namespace SistemaCadastro
{
    partial class FrmCriarConta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCriarConta));
            this.label1 = new System.Windows.Forms.Label();
            this.lblnome = new System.Windows.Forms.Label();
            this.txtSenhaCriar = new System.Windows.Forms.TextBox();
            this.txtUserCriar = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.BtnCriarConta = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmailCriar = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gold;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(51, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 21);
            this.label1.TabIndex = 24;
            this.label1.Text = "Senha:";
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.BackColor = System.Drawing.Color.Gold;
            this.lblnome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblnome.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnome.ForeColor = System.Drawing.Color.Blue;
            this.lblnome.Location = new System.Drawing.Point(19, 192);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(99, 21);
            this.lblnome.TabIndex = 23;
            this.lblnome.Text = "Username:";
            // 
            // txtSenhaCriar
            // 
            this.txtSenhaCriar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtSenhaCriar.Location = new System.Drawing.Point(129, 222);
            this.txtSenhaCriar.Name = "txtSenhaCriar";
            this.txtSenhaCriar.Size = new System.Drawing.Size(144, 29);
            this.txtSenhaCriar.TabIndex = 20;
            // 
            // txtUserCriar
            // 
            this.txtUserCriar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtUserCriar.Location = new System.Drawing.Point(129, 187);
            this.txtUserCriar.Name = "txtUserCriar";
            this.txtUserCriar.Size = new System.Drawing.Size(144, 29);
            this.txtUserCriar.TabIndex = 19;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.Location = new System.Drawing.Point(129, 39);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(134, 130);
            this.pictureBox4.TabIndex = 26;
            this.pictureBox4.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(285, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(48, 48);
            this.button2.TabIndex = 23;
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // BtnCriarConta
            // 
            this.BtnCriarConta.BackColor = System.Drawing.Color.Transparent;
            this.BtnCriarConta.FlatAppearance.BorderSize = 0;
            this.BtnCriarConta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCriarConta.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCriarConta.ForeColor = System.Drawing.Color.White;
            this.BtnCriarConta.Image = ((System.Drawing.Image)(resources.GetObject("BtnCriarConta.Image")));
            this.BtnCriarConta.Location = new System.Drawing.Point(129, 330);
            this.BtnCriarConta.Name = "BtnCriarConta";
            this.BtnCriarConta.Size = new System.Drawing.Size(123, 49);
            this.BtnCriarConta.TabIndex = 22;
            this.BtnCriarConta.Text = "&Criar";
            this.BtnCriarConta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCriarConta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCriarConta.UseVisualStyleBackColor = false;
            this.BtnCriarConta.Click += new System.EventHandler(this.BtnCriarConta_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Gold;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(51, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 21);
            this.label2.TabIndex = 28;
            this.label2.Text = "E-mail";
            // 
            // txtEmailCriar
            // 
            this.txtEmailCriar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtEmailCriar.Location = new System.Drawing.Point(129, 262);
            this.txtEmailCriar.Name = "txtEmailCriar";
            this.txtEmailCriar.Size = new System.Drawing.Size(144, 29);
            this.txtEmailCriar.TabIndex = 21;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.Location = new System.Drawing.Point(279, 209);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(64, 64);
            this.pictureBox3.TabIndex = 29;
            this.pictureBox3.TabStop = false;
            // 
            // FrmCriarConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(345, 391);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.txtEmailCriar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnCriarConta);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblnome);
            this.Controls.Add(this.txtSenhaCriar);
            this.Controls.Add(this.txtUserCriar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCriarConta";
            this.Text = "FrmCriarConta";
            this.Load += new System.EventHandler(this.FrmCriarConta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.TextBox txtSenhaCriar;
        private System.Windows.Forms.TextBox txtUserCriar;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BtnCriarConta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmailCriar;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}