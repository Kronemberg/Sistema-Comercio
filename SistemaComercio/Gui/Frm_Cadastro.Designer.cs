namespace SistemaComercio
{
    partial class Frm_Cadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Cadastro));
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.LblEmailAdd = new System.Windows.Forms.Label();
            this.LblSenhaAdd = new System.Windows.Forms.Label();
            this.TxtUsuarioCad = new System.Windows.Forms.TextBox();
            this.TxtSenhaCad = new System.Windows.Forms.TextBox();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.BtnCancelarCad = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(116, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Faça aqui seu cadastro:";
            // 
            // LblEmailAdd
            // 
            this.LblEmailAdd.AutoSize = true;
            this.LblEmailAdd.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmailAdd.Location = new System.Drawing.Point(20, 59);
            this.LblEmailAdd.Name = "LblEmailAdd";
            this.LblEmailAdd.Size = new System.Drawing.Size(53, 14);
            this.LblEmailAdd.TabIndex = 14;
            this.LblEmailAdd.Text = "Usuário:";
            // 
            // LblSenhaAdd
            // 
            this.LblSenhaAdd.AutoSize = true;
            this.LblSenhaAdd.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSenhaAdd.Location = new System.Drawing.Point(29, 88);
            this.LblSenhaAdd.Name = "LblSenhaAdd";
            this.LblSenhaAdd.Size = new System.Drawing.Size(44, 14);
            this.LblSenhaAdd.TabIndex = 15;
            this.LblSenhaAdd.Text = "Senha:";
            // 
            // TxtUsuarioCad
            // 
            this.TxtUsuarioCad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtUsuarioCad.Location = new System.Drawing.Point(79, 56);
            this.TxtUsuarioCad.Name = "TxtUsuarioCad";
            this.TxtUsuarioCad.Size = new System.Drawing.Size(231, 20);
            this.TxtUsuarioCad.TabIndex = 26;
            // 
            // TxtSenhaCad
            // 
            this.TxtSenhaCad.Location = new System.Drawing.Point(79, 82);
            this.TxtSenhaCad.Name = "TxtSenhaCad";
            this.TxtSenhaCad.Size = new System.Drawing.Size(231, 20);
            this.TxtSenhaCad.TabIndex = 27;
            this.TxtSenhaCad.UseSystemPasswordChar = true;
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.BackColor = System.Drawing.SystemColors.Control;
            this.BtnSalvar.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalvar.Location = new System.Drawing.Point(54, 119);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(105, 23);
            this.BtnSalvar.TabIndex = 28;
            this.BtnSalvar.Text = "Salvar";
            this.BtnSalvar.UseVisualStyleBackColor = false;
            this.BtnSalvar.Click += new System.EventHandler(this.ClickSalvar);
            // 
            // BtnCancelarCad
            // 
            this.BtnCancelarCad.BackColor = System.Drawing.SystemColors.Control;
            this.BtnCancelarCad.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelarCad.Location = new System.Drawing.Point(181, 119);
            this.BtnCancelarCad.Name = "BtnCancelarCad";
            this.BtnCancelarCad.Size = new System.Drawing.Size(106, 23);
            this.BtnCancelarCad.TabIndex = 29;
            this.BtnCancelarCad.Text = "Cancelar";
            this.BtnCancelarCad.UseVisualStyleBackColor = false;
            this.BtnCancelarCad.Click += new System.EventHandler(this.ClickCancelar);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::SistemaComercio.Properties.Resources.ImgNovoUsuario;
            this.pictureBox1.Location = new System.Drawing.Point(328, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(92, 105);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Frm_Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(444, 165);
            this.Controls.Add(this.BtnCancelarCad);
            this.Controls.Add(this.BtnSalvar);
            this.Controls.Add(this.TxtSenhaCad);
            this.Controls.Add(this.TxtUsuarioCad);
            this.Controls.Add(this.LblSenhaAdd);
            this.Controls.Add(this.LblEmailAdd);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_Cadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Adm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LblEmailAdd;
        private System.Windows.Forms.Label LblSenhaAdd;
        private System.Windows.Forms.TextBox TxtUsuarioCad;
        private System.Windows.Forms.TextBox TxtSenhaCad;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.Button BtnCancelarCad;
    }
}