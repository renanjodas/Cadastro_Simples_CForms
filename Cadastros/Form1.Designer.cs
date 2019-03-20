namespace Cadastros
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
			this.btnSair = new System.Windows.Forms.Button();
			this.btnClientes = new System.Windows.Forms.Button();
			this.btnFuncionarios = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnSair
			// 
			this.btnSair.Image = global::Cadastros.Properties.Resources.iconfinder_shutdown_71140;
			this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSair.Location = new System.Drawing.Point(199, 185);
			this.btnSair.Name = "btnSair";
			this.btnSair.Size = new System.Drawing.Size(142, 73);
			this.btnSair.TabIndex = 2;
			this.btnSair.Text = "Sair";
			this.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnSair.UseVisualStyleBackColor = true;
			this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
			// 
			// btnClientes
			// 
			this.btnClientes.Image = global::Cadastros.Properties.Resources.iconfinder_1_avatar_2754574__2_;
			this.btnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnClientes.Location = new System.Drawing.Point(199, 46);
			this.btnClientes.Name = "btnClientes";
			this.btnClientes.Size = new System.Drawing.Size(142, 73);
			this.btnClientes.TabIndex = 1;
			this.btnClientes.Text = "Clientes";
			this.btnClientes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnClientes.UseVisualStyleBackColor = true;
			this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
			// 
			// btnFuncionarios
			// 
			this.btnFuncionarios.Image = global::Cadastros.Properties.Resources.iconfinder_11_avatar_2754576;
			this.btnFuncionarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnFuncionarios.Location = new System.Drawing.Point(36, 46);
			this.btnFuncionarios.Name = "btnFuncionarios";
			this.btnFuncionarios.Size = new System.Drawing.Size(142, 73);
			this.btnFuncionarios.TabIndex = 0;
			this.btnFuncionarios.Text = "Funcionários";
			this.btnFuncionarios.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnFuncionarios.UseVisualStyleBackColor = true;
			this.btnFuncionarios.Click += new System.EventHandler(this.btnFuncionarios_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(373, 324);
			this.Controls.Add(this.btnSair);
			this.Controls.Add(this.btnClientes);
			this.Controls.Add(this.btnFuncionarios);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnFuncionarios;
		private System.Windows.Forms.Button btnClientes;
		private System.Windows.Forms.Button btnSair;
	}
}

