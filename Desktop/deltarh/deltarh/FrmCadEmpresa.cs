﻿using System;
using System.Windows.Forms;
using delta_modelo;
using delta_controle;
using System.Web.UI.WebControls;

namespace deltarh
{
    public partial class FrmCadEmpresa : Form
    {
        public FrmCadEmpresa()
        {
            InitializeComponent();
        }

        public void limparCadastro()
        {
            txtCnpj.Text = "";
            txtRazaoSocial.Text = "";
            txtFantasia.Text = "";
            txtSituacao.Text = "";
            txtLogradouro.Text = "";
            txtNumero.Text = "";
            txtComplemento.Text = "";
            txtBairro.Text = "";
            txtCep.Text = "";
            txtUf.Text = "";
            txtCidade.Text = "";
            txtTelefone1.Text = "";
            txtTelefone2.Text = "";
            txtEmail.Text = "";
            txtMissao.Text = "";
            txtPolitica.Text = "";
            txtSenha.Text = "";
            txtNome.Text = "";
            txtCpf.Text = "";
            txtCodId.Text = "";
            txtStatus.Text = "";

            txtCnpj.Focus();
        }

        public void consultaCnpj()
        {
            string cnpj = txtCnpj.Text;

            ConsultaBanco consulta = new ConsultaBanco();

            mdlEmpresa empresa = null;

            try
            {
                empresa = consulta.ConsultarEmpresa(cnpj);
                txtMissao.Text = empresa.missao.descricao;
                txtPolitica.Text = empresa.politica.descricao;

                txtCodId.Text = Convert.ToString(empresa.id);
                txtRazaoSocial.Text = empresa.razao;
                txtCnpj.Text = empresa.cnpj;
                txtNome.Text = empresa.responsavel; ;
                txtCpf.Text = empresa.cpf;
                txtStatus.Text = empresa.status;
                txtLogradouro.Text = empresa.logradouro;
                txtNumero.Text = empresa.numero;
                txtComplemento.Text = empresa.complemento;
                txtBairro.Text = empresa.bairro;
                txtCep.Text = empresa.cep;
                txtCidade.Text = empresa.cidade;
                txtUf.Text = empresa.uf;
                txtTelefone1.Text = empresa.fone1;
                txtTelefone2.Text = empresa.fone2;
                txtEmail.Text = empresa.email;
                txtSenha.Text = empresa.senha;

                txtUsuario.Text = txtCnpj.Text;

                ListarSetores();
            }
            catch (Exception ex)
            {
                empresa = null;
            }
        }

        public void editar()
        {
            gboxEndereco.Enabled = true;
            gboxContato.Enabled = true;
            gboxJornada.Enabled = true;
            gboxDesconto.Enabled = true;
            gboxCadastro.Enabled = true;
            gboxEdita.Enabled = true;
            txtFantasia.Enabled = true;
            btnSalvar.Visible = true;
            btnLimpar.Visible = true;
            btnCancelar.Visible = true;
            btnBuscar.Visible = true;
            btnOk.Visible = false;
            btnEditar.Visible = false;
            btnConsultaCnpj.Visible = false;
        }

        private void btnEditarEnd_Click(object sender, EventArgs e)
        {
            FrmEndereco end = new FrmEndereco();
            end.ShowDialog();

        }

        private void btnEditarDp_Click(object sender, EventArgs e)
        {
            FrmCadDp dp = new FrmCadDp();
            dp.ShowDialog();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DialogResult resposta = MessageBox.Show("Deseja Importar Todos os Dados da Base da Receita Federal?", "ATENÇÃO!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resposta == DialogResult.Yes)
            {
                ObterCnpj();
            }
        }

        public void ObterCnpj()
        {
            var cnpj = Empresa.ObterCnpj(txtCnpj.Text);

            if (cnpj != null && cnpj.status != "ERROR")
            {
                txtRazaoSocial.Text = cnpj.nome;
                txtFantasia.Text = cnpj.fantasia;
                txtSituacao.Text = cnpj.situacao;
                txtLogradouro.Text = cnpj.logradouro;
                txtNumero.Text = cnpj.numero;
                txtComplemento.Text = cnpj.complemento;
                txtBairro.Text = cnpj.bairro;
                txtCep.Text = cnpj.cep;
                txtUf.Text = cnpj.uf;
                txtCidade.Text = cnpj.municipio;
                txtTelefone1.Text = cnpj.telefone;
                txtEmail.Text = cnpj.email;

                txtUsuario.Text = txtCnpj.Text;
            }
            else
            {

                MessageBox.Show("CNPJ Não Encontrado na Base da Receita Federal!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCadastro();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmEditaSetor edita = new FrmEditaSetor();
            edita.txtId.Text = txtEditaSetor.Text;
            edita.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            editar();
        }

        public void btnConsultaCnpj_Click(object sender, EventArgs e)
        {
            consultaCnpj();
        }


        private void btnSalvar_Click(object sender, EventArgs e)
        {

            mdlMissao missao = new mdlMissao();
            mdlPolitica politica = new mdlPolitica();
            mdlEmpresa empresa = new mdlEmpresa();
            mdlSetor setor = new mdlSetor();
            string nomeSetor = "Geral";

            try
            {
                missao.descricao = txtMissao.Text;
                politica.descricao = txtPolitica.Text;

                empresa.razao = txtRazaoSocial.Text;
                empresa.cnpj = txtCnpj.Text;
                empresa.responsavel = txtNome.Text; ;
                empresa.cpf = txtCpf.Text;
                empresa.logradouro = txtLogradouro.Text;
                empresa.numero = txtNumero.Text;
                empresa.complemento = txtComplemento.Text;
                empresa.bairro = txtBairro.Text;
                empresa.cep = txtCep.Text;
                empresa.cidade = txtCidade.Text;
                empresa.uf = txtUf.Text;
                empresa.fone1 = txtTelefone1.Text;
                empresa.fone2 = txtTelefone2.Text;
                empresa.email = txtEmail.Text;
                empresa.senha = txtSenha.Text;

                setor.nome = nomeSetor;

                if(txtStatus.Text == "")
                {
                    empresa.status = "PENDENTE";
                }
                else
                {
                    empresa.status = txtStatus.Text;
                }

                Conexao conecta = new Conexao();

                conecta.CadastrarEmpresa(missao, politica, empresa, setor);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Cadastrar.", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            DialogResult resposta = MessageBox.Show("Cadastro Realizado com Sucesso! Cadastrar Nova Empresa?", "PARABÉNS!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (resposta == DialogResult.Yes)
            {
                limparCadastro();
            }
            else
            {
                Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            mdlSetor setor = new mdlSetor();
            
            try
            {
                setor.nome = txtSetor.Text;
                setor.idEmpresa = Convert.ToInt32(txtCodId.Text);

                CadSetor conecta = new CadSetor();

                conecta.CadastrarSetor(setor);

                MessageBox.Show("Setor Cadastrado com Sucesso!", "OK!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                txtSetor.Text = "";
                txtSetor.Focus();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro ao Cadastrar.", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void FrmCadEmpresa_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bD_DELTADataSet2.tbl_setor'. Você pode movê-la ou removê-la conforme necessário.
            this.tbl_setorTableAdapter.Fill(this.bD_DELTADataSet2.tbl_setor);

        }

        private void setorToolStripButton_Click(object sender, EventArgs e)
        {


        }

        public void ListarSetores()
        {

            try
            {
                this.tbl_setorTableAdapter.Setor(this.bD_DELTADataSet2.tbl_setor, ((int)(System.Convert.ChangeType(txtCodId.Text, typeof(int)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
    }
}
