using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projeto0307.Models;

namespace Projeto0307.View
{
    enum actionType
    {
        cadastro,
        edicao,
    }
    public partial class CadEndereco: Form
    {
        actionType acao;
        Endereco current;
        int id; 
        public CadEndereco(Endereco enderecoSelecionado)
        {
            current = enderecoSelecionado;
            InitializeComponent();

            if (enderecoSelecionado != null)
            {
                mtxtb_cep.Text = enderecoSelecionado.CEP;
                cb_uf.Text = enderecoSelecionado.UF;
                txtb_cidade.Text = enderecoSelecionado.Cidade;
                txtb_bairro.Text = enderecoSelecionado.Bairro;
                mtxtb_numero.Text = enderecoSelecionado.Numero;
                txtb_logradouro.Text = enderecoSelecionado.Logradouro;
                txtb_complemento.Text = enderecoSelecionado.Complemento;

                acao = actionType.edicao;
            }
            else
            {
                acao = actionType.cadastro;
                return;
            }

            btn_cadastrar.Enabled = false;
            btn_excluir.Enabled = false;
            btn_salvar.Enabled = false;
            if (acao == actionType.cadastro)
            {
                btn_cadastrar.Enabled = true;
            }
            else if (acao == actionType.edicao)
            {
                btn_excluir.Enabled = true;
                btn_salvar.Enabled = true;
            }
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {

            Endereco endereco = new Endereco(
                id = -1,
                mtxtb_cep.Text, 
                cb_uf.Text,
                txtb_cidade.Text,
                txtb_bairro.Text, 
                mtxtb_numero.Text,
                txtb_logradouro.Text,
                txtb_complemento.Text
            );
            if (CadCliente.GuardarEndereco(endereco))
            {
                MessageBox.Show("Endereço guardado com sucesso");
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                return;
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {

        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            ClienteAPI.AtualizarEndereco(current, current.Id);
            Console.Write(current.Id);
        }
    }
}
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    zzzzz