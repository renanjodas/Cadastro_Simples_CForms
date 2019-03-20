namespace Cadastros
{
	partial class FormClientes
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
			this.lblNomeCliente = new System.Windows.Forms.Label();
			this.lblTelefoneCliente = new System.Windows.Forms.Label();
			this.lblCidadeCliente = new System.Windows.Forms.Label();
			this.txtNomeCliente = new System.Windows.Forms.TextBox();
			this.comboCidade = new System.Windows.Forms.ComboBox();
			this.mtbTelefoneCliente = new System.Windows.Forms.MaskedTextBox();
			this.btnSalvarCliente = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblNomeCliente
			// 
			this.lblNomeCliente.AutoSize = true;
			this.lblNomeCliente.Location = new System.Drawing.Point(33, 27);
			this.lblNomeCliente.Name = "lblNomeCliente";
			this.lblNomeCliente.Size = new System.Drawing.Size(38, 13);
			this.lblNomeCliente.TabIndex = 0;
			this.lblNomeCliente.Text = "Nome:";
			// 
			// lblTelefoneCliente
			// 
			this.lblTelefoneCliente.AutoSize = true;
			this.lblTelefoneCliente.Location = new System.Drawing.Point(33, 62);
			this.lblTelefoneCliente.Name = "lblTelefoneCliente";
			this.lblTelefoneCliente.Size = new System.Drawing.Size(52, 13);
			this.lblTelefoneCliente.TabIndex = 1;
			this.lblTelefoneCliente.Text = "Telefone:";
			// 
			// lblCidadeCliente
			// 
			this.lblCidadeCliente.AutoSize = true;
			this.lblCidadeCliente.Location = new System.Drawing.Point(33, 99);
			this.lblCidadeCliente.Name = "lblCidadeCliente";
			this.lblCidadeCliente.Size = new System.Drawing.Size(43, 13);
			this.lblCidadeCliente.TabIndex = 2;
			this.lblCidadeCliente.Text = "Cidade:";
			// 
			// txtNomeCliente
			// 
			this.txtNomeCliente.Location = new System.Drawing.Point(91, 24);
			this.txtNomeCliente.Name = "txtNomeCliente";
			this.txtNomeCliente.Size = new System.Drawing.Size(121, 20);
			this.txtNomeCliente.TabIndex = 3;
			// 
			// comboCidade
			// 
			this.comboCidade.FormattingEnabled = true;
			this.comboCidade.Items.AddRange(new object[] {
            "Americana",
            "Piracicaba",
            "Nova Odessa ",
            "Sumaré",
            "Campinas"});
			this.comboCidade.Location = new System.Drawing.Point(91, 91);
			this.comboCidade.Name = "comboCidade";
			this.comboCidade.Size = new System.Drawing.Size(121, 21);
			this.comboCidade.TabIndex = 5;
			// 
			// mtbTelefoneCliente
			// 
			this.mtbTelefoneCliente.Location = new System.Drawing.Point(91, 59);
			this.mtbTelefoneCliente.Mask = "(99) 99999-9999";
			this.mtbTelefoneCliente.Name = "mtbTelefoneCliente";
			this.mtbTelefoneCliente.Size = new System.Drawing.Size(121, 20);
			this.mtbTelefoneCliente.TabIndex = 4;
			// 
			// btnSalvarCliente
			// 
			this.btnSalvarCliente.Location = new System.Drawing.Point(36, 133);
			this.btnSalvarCliente.Name = "btnSalvarCliente";
			this.btnSalvarCliente.Size = new System.Drawing.Size(180, 32);
			this.btnSalvarCliente.TabIndex = 6;
			this.btnSalvarCliente.Text = "Salvar";
			this.btnSalvarCliente.UseVisualStyleBackColor = true;
			this.btnSalvarCliente.Click += new System.EventHandler(this.btnSalvarCliente_Click);
			// 
			// FormClientes
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(257, 200);
			this.Controls.Add(this.btnSalvarCliente);
			this.Controls.Add(this.comboCidade);
			this.Controls.Add(this.txtNomeCliente);
			this.Controls.Add(this.mtbTelefoneCliente);
			this.Controls.Add(this.lblCidadeCliente);
			this.Controls.Add(this.lblTelefoneCliente);
			this.Controls.Add(this.lblNomeCliente);
			this.Name = "FormClientes";
			this.Text = "Cadastro de Clientes";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblNomeCliente;
		private System.Windows.Forms.Label lblTelefoneCliente;
		private System.Windows.Forms.Label lblCidadeCliente;
		private System.Windows.Forms.MaskedTextBox mtbTelefoneCliente;
		private System.Windows.Forms.TextBox txtNomeCliente;
		private System.Windows.Forms.ComboBox comboCidade;
		private System.Windows.Forms.Button btnSalvarCliente;
	}
}