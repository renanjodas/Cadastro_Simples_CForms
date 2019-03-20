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
	public partial class FormFuncionarios : Form
	{
		public FormFuncionarios()
		{
			InitializeComponent();
		}

		private void btnSalvarFuncionario_Click(object sender, EventArgs e)
		{
			string nome, estadoCivil;
			nome = txtNomeFuncionario.Text;
			if (rbnCasado.Checked == true)
			{
				estadoCivil = "Casado (a)";
			}else if (rbnSolteiro.Checked == true)
			{
				estadoCivil = "Solteiro (a)";
			}
			else
			{
				MessageBox.Show("Escolha um estado civil");
				return;
			}
			SalvarFuncionario(nome, estadoCivil);
			LimparFuncionario();
		}	

		private void SalvarFuncionario(string nome, string estadoCivil)
		{
			StreamWriter arquivo;
			string caminho = "C:\\Users\\aluno\\Desktop\\Sistema1\\Funcionarios.txt";
			arquivo = File.AppendText(caminho);
			arquivo.WriteLine();
			arquivo.WriteLine("------ Cadastro de Funcionários ------");
			arquivo.WriteLine("");
			arquivo.WriteLine("Nome: " + nome);
			arquivo.WriteLine("");
			arquivo.WriteLine("Estado Civil: " + estadoCivil);
			arquivo.WriteLine("");
			arquivo.WriteLine("______________________________________");
			arquivo.WriteLine();
			arquivo.Close();
			MessageBox.Show("Funcionário salvo com Sucesso!!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void LimparFuncionario()
		{
			txtNomeFuncionario.Clear();
			rbnCasado.Checked = false;
			rbnSolteiro.Checked = false;
		}
	}
}
