using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Collections;

namespace GestaoProfessor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection connection = Connect();
            OleDbCommand command = null;

            try
            {
                connection.Open();

                string sqlInsert = "insert into Funcionario(CODIGO, NOME, DIASTRABALHADOS, SALARIODIARIO) values (?,?,?,?)";

                command = new OleDbCommand(sqlInsert, connection);

                command.Parameters.Add(new OleDbParameter("CODIGO", int.Parse(txtCode.Text)));
                command.Parameters.Add(new OleDbParameter("NOME", txtName.Text));
                command.Parameters.Add(new OleDbParameter("DIASTRABALHADOS", txtDiaTrabal.Text));
                command.Parameters.Add(new OleDbParameter("SALARIODIARIO", txtSalDia.Text));

                command.ExecuteNonQuery();
                clean();

                MessageBox.Show("CADASTRO FEITO COM SUCESSO!", "CADASTRO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no Cadastro: " + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        private static OleDbConnection Connect()
        {
            OleDbConnection connection = null;

            try
            {
                string path = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\bdAulas\Funcionario.accdb";

                connection = new OleDbConnection(path);
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro na conexão: " + e.Message, "Conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
            return connection;
        }

        public void clean()
        {
            txtCode.Clear();
            txtName.Clear();
            txtDiaTrabal.Clear();
            txtSalDia.Clear();
        }

        private static ArrayList recoverEmployee()
        {
            OleDbConnection connection = Connect();
            OleDbCommand command = null;
            OleDbDataReader reader = null;

            ArrayList empployee = new ArrayList();

            try
            {
                connection.Open();

                string read = "select* From Funcionario";

                command = new OleDbCommand(read, connection);

                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    empployee.Add(new ObjectosFuncionarios(reader.GetInt32(0),
                        reader.GetString(1), reader.GetInt32(2), reader.GetInt64(3)));
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro na solicitação de dados: " + e.Message, "DADOS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
            return empployee;
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            ArrayList employee = recoverEmployee();

            lstVTabela.Items.Clear();

            foreach ( ObjectosFuncionarios funcionarios in employee)
            {
                ListViewItem lstVItem = new ListViewItem();

                this.lstVItem.Text = funcionarios.GetCodigo() + "";
                lstVItem.SubItems.Add(funcionarios.GetNome());
                lstVItem.Text = funcionarios.GetDiasTraba() + "";
                lstVItem.Text = funcionarios.GetSalarioDia() + "";
                lstVItem.Text = funcionarios.GetSalarioDia() * 31 + "";

                lstVTabela.Items.Add(lstVItem);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OleDbConnection connection = null;

            try
            {
                string path = @"Provider = Microsoft.ACE.OleDb.12.0; Data Source = C:\bdAulas\Funcionario.accdb";

                connection = new OleDbConnection(path);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro na conexão: " + ex.Message, "Conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
