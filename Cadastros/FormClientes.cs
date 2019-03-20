using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastros
{
	public partial class FormClientes : Form
	{
		public FormClientes()
		{
			InitializeComponent();
		}

		private void btnSalvarCliente_Click(object sender, EventArgs e)
		{
			string nome, cidade, telefone;
			nome = txtNomeCliente.Text;
			cidade = comboCidade.Items[comboCidade.SelectedIndex].ToString();
			telefone = mtbTelefoneCliente.Text;
			SalvarCliente(nome, telefone, cidade);
			LimparCliente();
		}

		private void SalvarCliente(string nome, string telefone, string cidade)
		{
			StreamWriter arquivo;
			string caminho = "C:\\Users\\aluno\\Desktop\\Sistema1\\Clientes.txt";
			arquivo = File.AppendText(caminho);
			arquivo.WriteLine();
			arquivo.WriteLine("------ Cadastro de Clientes ------");
			arquivo.WriteLine("");
			arquivo.WriteLine("Nome: " + nome);
			arquivo.WriteLine("");
			arquivo.WriteLine("Telefone: " + telefone);
			arquivo.WriteLine("");
			arquivo.WriteLine("Cidade: " + cidade);
			arquivo.WriteLine("");
			arquivo.WriteLine("__________________________________");
			arquivo.WriteLine();
			arquivo.Close();
			MessageBox.Show("Cliente salvo com sucesso!!!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void LimparCliente()
		{
			txtNomeCliente.Clear();
			mtbTelefoneCliente.Clear();
			comboCidade.SelectedIndex = -1;
		}
	}
}
