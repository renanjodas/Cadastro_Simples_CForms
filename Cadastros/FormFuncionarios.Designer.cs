namespace Cadastros
{
	partial class FormFuncionarios
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
			this.lblNomeFuncionario = new System.Windows.Forms.Label();
			this.txtNomeFuncionario = new System.Windows.Forms.TextBox();
			this.gbxEstadoCivil = new System.Windows.Forms.GroupBox();
			this.rbnSolteiro = new System.Windows.Forms.RadioButton();
			this.rbnCasado = new System.Windows.Forms.RadioButton();
			this.btnSalvarFuncionario = new System.Windows.Forms.Button();
			this.gbxEstadoCivil.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblNomeFuncionario
			// 
			this.lblNomeFuncionario.AutoSize = true;
			this.lblNomeFuncionario.Location = new System.Drawing.Point(44, 40);
			this.lblNomeFuncionario.Name = "lblNomeFuncionario";
			this.lblNomeFuncionario.Size = new System.Drawing.Size(38, 13);
			this.lblNomeFuncionario.TabIndex = 0;
			this.lblNomeFuncionario.Text = "Nome:";
			// 
			// txtNomeFuncionario
			// 
			this.txtNomeFuncionario.Location = new System.Drawing.Point(88, 40);
			this.txtNomeFuncionario.Name = "txtNomeFuncionario";
			this.txtNomeFuncionario.Size = new System.Drawing.Size(140, 20);
			this.txtNomeFuncionario.TabIndex = 1;
			// 
			// gbxEstadoCivil
			// 
			this.gbxEstadoCivil.Controls.Add(this.rbnCasado);
			this.gbxEstadoCivil.Controls.Add(this.rbnSolteiro);
			this.gbxEstadoCivil.Location = new System.Drawing.Point(47, 91);
			this.gbxEstadoCivil.Name = "gbxEstadoCivil";
			this.gbxEstadoCivil.Size = new System.Drawing.Size(181, 64);
			this.gbxEstadoCivil.TabIndex = 2;
			this.gbxEstadoCivil.TabStop = false;
			this.gbxEstadoCivil.Text = "Estado Civil";
			// 
			// rbnSolteiro
			// 
			this.rbnSolteiro.AutoSize = true;
			this.rbnSolteiro.Location = new System.Drawing.Point(7, 31);
			this.rbnSolteiro.Name = "rbnSolteiro";
			this.rbnSolteiro.Size = new System.Drawing.Size(75, 17);
			this.rbnSolteiro.TabIndex = 0;
			this.rbnSolteiro.TabStop = true;
			this.rbnSolteiro.Text = "Solteiro (a)";
			this.rbnSolteiro.UseVisualStyleBackColor = true;
			// 
			// rbnCasado
			// 
			this.rbnCasado.AutoSize = true;
			this.rbnCasado.Location = new System.Drawing.Point(99, 31);
			this.rbnCasado.Name = "rbnCasado";
			this.rbnCasado.Size = new System.Drawing.Size(76, 17);
			this.rbnCasado.TabIndex = 1;
			this.rbnCasado.TabStop = true;
			this.rbnCasado.Text = "Casado (a)";
			this.rbnCasado.UseVisualStyleBackColor = true;
			// 
			// btnSalvarFuncionario
			// 
			this.btnSalvarFuncionario.Location = new System.Drawing.Point(47, 172);
			this.btnSalvarFuncionario.Name = "btnSalvarFuncionario";
			this.btnSalvarFuncionario.Size = new System.Drawing.Size(181, 42);
			this.btnSalvarFuncionario.TabIndex = 3;
			this.btnSalvarFuncionario.Text = "Salvar";
			this.btnSalvarFuncionario.UseVisualStyleBackColor = true;
			this.btnSalvarFuncionario.Click += new System.EventHandler(this.btnSalvarFuncionario_Click);
			// 
			// FormFuncionarios
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(270, 259);
			this.Controls.Add(this.btnSalvarFuncionario);
			this.Controls.Add(this.gbxEstadoCivil);
			this.Controls.Add(this.txtNomeFuncionario);
			this.Controls.Add(this.lblNomeFuncionario);
			this.Name = "FormFuncionarios";
			this.Text = "Cadastro Funcionários";
			this.gbxEstadoCivil.ResumeLayout(false);
			this.gbxEstadoCivil.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblNomeFuncionario;
		private System.Windows.Forms.TextBox txtNomeFuncionario;
		private System.Windows.Forms.GroupBox gbxEstadoCivil;
		private System.Windows.Forms.RadioButton rbnCasado;
		private System.Windows.Forms.RadioButton rbnSolteiro;
		private System.Windows.Forms.Button btnSalvarFuncionario;
	}
}