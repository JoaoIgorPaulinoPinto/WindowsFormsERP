// ... seus usings mantidos ...

using Projeto0307.Models;
using Projeto0307.View;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;

namespace Projeto0307
{
    public partial class CadCliente : Form
    {
        string idEditing;
        private static List<Endereco> enderecosCadastrados = new List<Endereco>();

        public CadCliente()
        {
            InitializeComponent();
            btn_editar.Hide();
            btn_cancelar.Hide();
            btn_excluir.Hide();

            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;

            AtualizaLista(); // agora popula corretamente

            DataGridViewEnderecos.CellContentClick += DataGridViewEnderecos_CellContentClick;
        }

        public static bool GuardarEndereco(Endereco endereco)
        {
            enderecosCadastrados.Add(endereco);
            return true;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                idEditing = row.Cells["ID"].Value?.ToString();

                txtb_nome.Text = row.Cells["Nome"].Value?.ToString();
                mtxtb_cpf.Text = row.Cells["CPF"].Value?.ToString();
                cb_sexo.Text = row.Cells["Sexo"].Value?.ToString();
                mtxtb_datanascimento.Text = row.Cells["DataNascimento"].Value?.ToString();
                mtxtb_celular.Text = row.Cells["Celular"].Value?.ToString();
                mtxtb_telefoneRes.Text = row.Cells["TelefoneResidencial"].Value?.ToString();
                mtxtb_telefoneCom.Text = row.Cells["TelefoneComercial"].Value?.ToString();
                txtb_email.Text = row.Cells["Email"].Value?.ToString();
                mtxtb_alternativo.Text = row.Cells["Alternativo"].Value?.ToString();
                cb_status.Text = row.Cells["Status"].Value?.ToString();

                // listar todos os endereços
                if (int.TryParse(idEditing, out int clienteId))
                {
                    enderecosCadastrados = ClienteAPI.ListarEnderecosPorCliente(clienteId);
                    DataGridViewEnderecos.DataSource = null;
                    DataGridViewEnderecos.DataSource = enderecosCadastrados;
                }

                btn_editar.Show();
                btn_cancelar.Show();
                btn_excluir.Show();
            }
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            if (enderecosCadastrados.Count == 0)
            {
                MessageBox.Show("Adicione pelo menos um endereço antes de editar.");
                return;
            }

            Cliente cliente = new Cliente(
                txtb_nome.Text,
                mtxtb_datanascimento.Text,
                mtxtb_cpf.Text,
                enderecosCadastrados,
                mtxtb_celular.Text,
                mtxtb_telefoneRes.Text,
                mtxtb_telefoneCom.Text,
                txtb_email.Text,
                cb_status.Text,
                cb_sexo.Text,
                mtxtb_alternativo.Text
            );

            if (ClienteAPI.AtualizarCliente(int.Parse(idEditing), cliente))
            {
                MessageBox.Show("Cliente atualizado com sucesso!");
                AtualizaLista();
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            idEditing = null;
            btn_cancelar.Hide();
            btn_editar.Hide();
            btn_excluir.Hide();

            txtb_nome.Clear();
            mtxtb_cpf.Clear();
            cb_sexo.SelectedItem = null;
            mtxtb_datanascimento.Clear();
            mtxtb_celular.Clear();
            mtxtb_telefoneRes.Clear();
            mtxtb_telefoneCom.Clear();
            txtb_email.Clear();
            mtxtb_alternativo.Clear();
            cb_status.SelectedItem = null;

            enderecosCadastrados.Clear();
            DataGridViewEnderecos.DataSource = null;
        }

        async void AtualizaLista()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ClienteAPI.ListarClientes();

            if (checkedListBox1.Items.Count == 0)
            {
                foreach (DataGridViewColumn col in dataGridView1.Columns)
                {
                    checkedListBox1.Items.Add(col.HeaderText, true);
                }
            }

            await AtualizaFiltros();
        }

        private void btn_cadastrar_Click_1(object sender, EventArgs e)
        {
            if (enderecosCadastrados.Count == 0)
            {
                MessageBox.Show("Adicione pelo menos um endereço antes de cadastrar.");
                return;
            }

            Cliente cliente = new Cliente(
                txtb_nome.Text,
                mtxtb_datanascimento.Text,
                mtxtb_cpf.Text,
                enderecosCadastrados,
                mtxtb_celular.Text,
                mtxtb_telefoneRes.Text,
                mtxtb_telefoneCom.Text,
                txtb_email.Text,
                cb_status.Text,
                cb_sexo.Text,
                mtxtb_alternativo.Text
            );

            if (ClienteAPI.CadastrarCliente(cliente))
            {
                MessageBox.Show("Cliente cadastrado com sucesso!");
                AtualizaLista();
            }
        }

        private async void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            await AtualizaFiltros();
        }

        private async Task AtualizaFiltros()
        {
            await Task.Delay(100);

            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                string columnName = checkedListBox1.Items[i].ToString();

                foreach (DataGridViewColumn col in dataGridView1.Columns)
                {
                    if (col.HeaderText == columnName)
                    {
                        col.Visible = checkedListBox1.GetItemChecked(i);
                    }
                }
            }
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(idEditing))
            {
                ClienteAPI.ExcluirCliente(int.Parse(idEditing));
                MessageBox.Show("Cliente excluído com sucesso!");
            }

            AtualizaLista();
            btn_editar.Hide();
            btn_cancelar.Hide();
            btn_excluir.Hide();
        }

        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            AtualizaLista();
        }

        private void button3_Click(object sender, EventArgs e)
        {   
            var formEndereco = new CadEndereco(null);
            formEndereco.ShowDialog();

            // se um novo endereço foi adicionado, recarrega
            DataGridViewEnderecos.DataSource = null;
            DataGridViewEnderecos.DataSource = enderecosCadastrados;
        }

        private void DataGridViewEnderecos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // abrir tela de editar endereço clicado
            if (e.RowIndex >= 0 && e.RowIndex < DataGridViewEnderecos.Rows.Count)
            {
                var enderecoSelecionado = enderecosCadastrados[e.RowIndex];
                var formEndereco = new CadEndereco(enderecoSelecionado); // você deve adaptar o CadEndereco para receber e editar
                formEndereco.ShowDialog();
            }
        }

        private void CadCliente_Load(object sender, EventArgs e)
        {
            // opcional
        }
    }
}
