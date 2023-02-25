namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.chkFisicPerson = new System.Windows.Forms.CheckBox();
            this.chkJuridicPerson = new System.Windows.Forms.CheckBox();
            this.lblNameFisic = new System.Windows.Forms.Label();
            this.lblCpfFisic = new System.Windows.Forms.Label();
            this.txtNameFisic = new System.Windows.Forms.TextBox();
            this.txtCpfFisic = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.grpFisic = new System.Windows.Forms.GroupBox();
            this.grpJuridic = new System.Windows.Forms.GroupBox();
            this.txtCpfJuridic = new System.Windows.Forms.TextBox();
            this.txtNameJuridic = new System.Windows.Forms.TextBox();
            this.lblCpfJuridic = new System.Windows.Forms.Label();
            this.lblNameJuridic = new System.Windows.Forms.Label();
            this.grpFisic.SuspendLayout();
            this.grpJuridic.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkFisicPerson
            // 
            this.chkFisicPerson.AutoSize = true;
            this.chkFisicPerson.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFisicPerson.Location = new System.Drawing.Point(83, 127);
            this.chkFisicPerson.Name = "chkFisicPerson";
            this.chkFisicPerson.Size = new System.Drawing.Size(165, 28);
            this.chkFisicPerson.TabIndex = 0;
            this.chkFisicPerson.Text = "Pessoa Física";
            this.chkFisicPerson.UseVisualStyleBackColor = true;
            this.chkFisicPerson.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // chkJuridicPerson
            // 
            this.chkJuridicPerson.AutoSize = true;
            this.chkJuridicPerson.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkJuridicPerson.Location = new System.Drawing.Point(83, 179);
            this.chkJuridicPerson.Name = "chkJuridicPerson";
            this.chkJuridicPerson.Size = new System.Drawing.Size(181, 28);
            this.chkJuridicPerson.TabIndex = 1;
            this.chkJuridicPerson.Text = "Pessoa Jurídica";
            this.chkJuridicPerson.UseVisualStyleBackColor = true;
            this.chkJuridicPerson.CheckedChanged += new System.EventHandler(this.chkJuridicPerson_CheckedChanged);
            // 
            // lblNameFisic
            // 
            this.lblNameFisic.AutoSize = true;
            this.lblNameFisic.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameFisic.ForeColor = System.Drawing.Color.Black;
            this.lblNameFisic.Location = new System.Drawing.Point(14, 36);
            this.lblNameFisic.Name = "lblNameFisic";
            this.lblNameFisic.Size = new System.Drawing.Size(68, 25);
            this.lblNameFisic.TabIndex = 2;
            this.lblNameFisic.Text = "Nome: ";
            this.lblNameFisic.Click += new System.EventHandler(this.lblNameFisic_Click);
            // 
            // lblCpfFisic
            // 
            this.lblCpfFisic.AutoSize = true;
            this.lblCpfFisic.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpfFisic.ForeColor = System.Drawing.Color.Black;
            this.lblCpfFisic.Location = new System.Drawing.Point(14, 72);
            this.lblCpfFisic.Name = "lblCpfFisic";
            this.lblCpfFisic.Size = new System.Drawing.Size(56, 25);
            this.lblCpfFisic.TabIndex = 4;
            this.lblCpfFisic.Text = "CPF: ";
            // 
            // txtNameFisic
            // 
            this.txtNameFisic.Location = new System.Drawing.Point(88, 42);
            this.txtNameFisic.Name = "txtNameFisic";
            this.txtNameFisic.Size = new System.Drawing.Size(132, 22);
            this.txtNameFisic.TabIndex = 6;
            // 
            // txtCpfFisic
            // 
            this.txtCpfFisic.Location = new System.Drawing.Point(88, 77);
            this.txtCpfFisic.Name = "txtCpfFisic";
            this.txtCpfFisic.Size = new System.Drawing.Size(132, 22);
            this.txtCpfFisic.TabIndex = 7;
            this.txtCpfFisic.TextChanged += new System.EventHandler(this.txtCpfFisic_TextChanged);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.ForestGreen;
            this.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmit.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(118, 227);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(92, 25);
            this.btnSubmit.TabIndex = 12;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.button1_Click);
            // 
            // grpFisic
            // 
            this.grpFisic.Controls.Add(this.txtCpfFisic);
            this.grpFisic.Controls.Add(this.txtNameFisic);
            this.grpFisic.Controls.Add(this.lblCpfFisic);
            this.grpFisic.Controls.Add(this.lblNameFisic);
            this.grpFisic.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpFisic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.grpFisic.Location = new System.Drawing.Point(389, 48);
            this.grpFisic.Name = "grpFisic";
            this.grpFisic.Size = new System.Drawing.Size(243, 107);
            this.grpFisic.TabIndex = 13;
            this.grpFisic.TabStop = false;
            this.grpFisic.Text = "Pessoa Física";
            this.grpFisic.Visible = false;
            // 
            // grpJuridic
            // 
            this.grpJuridic.Controls.Add(this.txtCpfJuridic);
            this.grpJuridic.Controls.Add(this.txtNameJuridic);
            this.grpJuridic.Controls.Add(this.lblCpfJuridic);
            this.grpJuridic.Controls.Add(this.lblNameJuridic);
            this.grpJuridic.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpJuridic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.grpJuridic.Location = new System.Drawing.Point(389, 200);
            this.grpJuridic.Name = "grpJuridic";
            this.grpJuridic.Size = new System.Drawing.Size(243, 107);
            this.grpJuridic.TabIndex = 14;
            this.grpJuridic.TabStop = false;
            this.grpJuridic.Text = "Pessoa Jurídica";
            this.grpJuridic.Visible = false;
            // 
            // txtCpfJuridic
            // 
            this.txtCpfJuridic.Location = new System.Drawing.Point(88, 77);
            this.txtCpfJuridic.Name = "txtCpfJuridic";
            this.txtCpfJuridic.Size = new System.Drawing.Size(132, 22);
            this.txtCpfJuridic.TabIndex = 7;
            // 
            // txtNameJuridic
            // 
            this.txtNameJuridic.Location = new System.Drawing.Point(88, 42);
            this.txtNameJuridic.Name = "txtNameJuridic";
            this.txtNameJuridic.Size = new System.Drawing.Size(132, 22);
            this.txtNameJuridic.TabIndex = 6;
            // 
            // lblCpfJuridic
            // 
            this.lblCpfJuridic.AutoSize = true;
            this.lblCpfJuridic.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpfJuridic.ForeColor = System.Drawing.Color.Black;
            this.lblCpfJuridic.Location = new System.Drawing.Point(14, 72);
            this.lblCpfJuridic.Name = "lblCpfJuridic";
            this.lblCpfJuridic.Size = new System.Drawing.Size(56, 25);
            this.lblCpfJuridic.TabIndex = 4;
            this.lblCpfJuridic.Text = "CPF: ";
            // 
            // lblNameJuridic
            // 
            this.lblNameJuridic.AutoSize = true;
            this.lblNameJuridic.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameJuridic.ForeColor = System.Drawing.Color.Black;
            this.lblNameJuridic.Location = new System.Drawing.Point(14, 36);
            this.lblNameJuridic.Name = "lblNameJuridic";
            this.lblNameJuridic.Size = new System.Drawing.Size(68, 25);
            this.lblNameJuridic.TabIndex = 2;
            this.lblNameJuridic.Text = "Nome: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 377);
            this.Controls.Add(this.grpJuridic);
            this.Controls.Add(this.grpFisic);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.chkJuridicPerson);
            this.Controls.Add(this.chkFisicPerson);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Propriedades do CheckBox";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpFisic.ResumeLayout(false);
            this.grpFisic.PerformLayout();
            this.grpJuridic.ResumeLayout(false);
            this.grpJuridic.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkFisicPerson;
        private System.Windows.Forms.CheckBox chkJuridicPerson;
        private System.Windows.Forms.Label lblNameFisic;
        private System.Windows.Forms.Label lblCpfFisic;
        private System.Windows.Forms.TextBox txtNameFisic;
        private System.Windows.Forms.TextBox txtCpfFisic;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.GroupBox grpFisic;
        private System.Windows.Forms.GroupBox grpJuridic;
        private System.Windows.Forms.TextBox txtCpfJuridic;
        private System.Windows.Forms.TextBox txtNameJuridic;
        private System.Windows.Forms.Label lblCpfJuridic;
        private System.Windows.Forms.Label lblNameJuridic;
    }
}

