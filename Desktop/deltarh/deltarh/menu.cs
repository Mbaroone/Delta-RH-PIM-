﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CpfLibrary;
using delta_controle;
using delta_modelo;
using DLL_CLASS_CNPJ;

namespace deltarh
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        public void ListarEmpresa()
        {
            ConsultaBanco consulta = new ConsultaBanco();

            List<mdlEmpresa> empresas = new List<mdlEmpresa>();

            try
            {
                empresas = consulta.ListarEmpresas();

                cboxRazao.DataSource = empresas;
                this.cboxRazao.DisplayMember = "razao";
                this.cboxRazao.ValueMember = "id";

            }
            catch (Exception ex)
            {
                throw;
            }
        }

        /*public void BuscarSetor()
        {
            if (cBoxEmpresa.SelectedValue is int)
            {
                int idEmpresa = Convert.ToInt32(cBoxEmpresa.SelectedValue);


                ConsultaBanco consulta = new ConsultaBanco();

                List<mdlSetor> setores = new List<mdlSetor>();

                try
                {
                    setores = consulta.ConsultarSetor(idEmpresa);

                }
                catch (Exception ex)
                {
                    throw;
                }

                BuscarColabs(setores);
            }
        }*/

        public void BuscarColabs(List<mdlSetor> setores)
        {
            ConsultaBanco consulta = new ConsultaBanco();

            List<mdlColaborador> colabs = new List<mdlColaborador>();
            foreach (mdlSetor setor in setores)
            {
                try
                {
                    int id_setor = setor.id;
                    List<mdlColaborador> colaboradores = consulta.ListarColaborador(id_setor);
                    colabs.AddRange(colaboradores);

                }
                catch (Exception ex)
                {
                    throw;
                }
            }
        }
        public void ConsultarEmpresas()
        {
            string cnpj = txtCnpj.Text;

            ConsultaBanco consulta = new ConsultaBanco();

            mdlEmpresa empresa = null;

            try
            {
                empresa = consulta.ConsultarEmpresa(cnpj);

                if (empresa == null)
                {
                    var resposta = MessageBox.Show("Empresa não cadastrada. Deseja cadastrá-la?", "ATENÇÃO!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (resposta == DialogResult.Yes)
                    {
                        FrmCadEmpresa cadastro = new FrmCadEmpresa();
                        cadastro.txtCnpj.Text = cnpj;
                        cadastro.ObterCnpj();
                        cadastro.editar();
                        cadastro.btnSalvar.Visible = false;
                        cadastro.btnCadastrar.Visible = true;
                        cnpj = "";
                        cadastro.ShowDialog();
                    }
                }
                else
                {
                    FrmCadEmpresa cadastro = new FrmCadEmpresa();
                    cadastro.txtCnpj.Text = cnpj;
                    cadastro.consultaCnpj();
                    cadastro.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                empresa = null;
            }
        }

        private void btnCnpj_Click(object sender, EventArgs e)
        {
            ConsultarEmpresas();
        }

        private void txtCnpj_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                ConsultarEmpresas();
            }
        }

        private void ConsultarColaborador()
        {
            string cpf = txtCpf.Text;

            ConsultaBanco consulta = new ConsultaBanco();

            mdlColaborador colab = null;

            colab = consulta.ConsultarColab(cpf);

            if (colab == null)
            {
                var resposta = MessageBox.Show("Colaborador não cadastrado. Deseja cadastrá-lo?", "ATENÇÃO!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resposta == DialogResult.Yes)
                {
                    FrmCadColadorador cadastro = new FrmCadColadorador();
                    cadastro.mskCpf.Text = cpf;
                    cadastro.ShowDialog();
                }
            }
            else
            {
                FrmColadorador busca = new FrmColadorador();
                busca.mskCpf.Text = cpf;
                busca.BuscarColab();
                busca.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ConsultarColaborador();
        }

        private void txtCpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                ConsultarColaborador();
            }
        }
        private void FrmMenu_Load(object sender, EventArgs e)
        {
            ListarEmpresa();
            BuscarStatus();
        }

        public void BuscarStatus()
        {
            StringConexao conecta = new StringConexao();
            string consulta = conecta.stringSql;

            using (SqlConnection conexaodb = new SqlConnection(consulta))
            {
                conexaodb.Open();

                var sqlQuery = "SELECT cnpj, razao_social, status FROM tbl_empresa WHERE status = 'Pendente'";

                SqlCommand cmd = new SqlCommand(sqlQuery, conexaodb);

                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;

                DataTable dt = new DataTable();

                da.Fill(dt);

                gridPendentes.DataSource = dt;
                gridPendentes.Columns[0].Width = 105;
                gridPendentes.Columns[1].Width = 260;
                gridPendentes.Columns[2].Width = 105;
            }
        }

            private void btnAtualiza_Click(object sender, EventArgs e)
            {
                BuscarStatus();
            }

            private void button1_Click(object sender, EventArgs e)
            {
                FrmAprovaStatus status = new FrmAprovaStatus();
                status.txtCnpj.Text = txtCnpjStatus.Text;
                status.MostrarEmpresa();
                status.ShowDialog();
            }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            BuscarPonto();
        }

        public void BuscarPonto()
        {
            StringConexao conecta = new StringConexao();
            string consulta = conecta.stringSql;

            using (SqlConnection conexaodb = new SqlConnection(consulta))
            {
              //  int idcolab = Convert.ToInt32(cBoxColaborador.SelectedValue);
                conexaodb.Open();

                var sqlQuery = "SELECT id_colaborador, data, entrada, saida_almoco, retorno_almoco, saida FROM tbl_pontoeletronico WHERE id_colaborador = @idcolab";

                SqlCommand cmd = new SqlCommand(sqlQuery, conexaodb);

                //cmd.Parameters.AddWithValue("@idcolab", idcolab);

                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;

                DataTable dt = new DataTable();

                da.Fill(dt);

                gridPendentes.DataSource = dt;
                gridPendentes.Columns[0].Width = 40;
                gridPendentes.Columns[1].Width = 70;
                gridPendentes.Columns[2].Width = 70;
                gridPendentes.Columns[3].Width = 70;
                gridPendentes.Columns[4].Width = 70;
                gridPendentes.Columns[5].Width = 70;
            }
        }

        private void cBoxColaborador_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void btnJustificar_Click(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void btnProcessar_Click(object sender, EventArgs e)
        {
            int id_empresa = Convert.ToInt32(cboxRazao.SelectedValue);
            string mes = cboxMes.Text;
            string ano = cboxAno.Text;

            string mes_referencia = mes + "/" + ano;
            DateTime[] dias = GetFirstAndLastDayOfMonth(mes, ano);

           
            ConsultaBanco consulta = new ConsultaBanco();
            mdlFolhaDePagamento folha_existente = consulta.BuscarFolha(id_empresa, mes_referencia);

            if (folha_existente != null)
            {
                var resposta = MessageBox.Show("Folha do mês " + mes_referencia + " ja cadastrada. Abrir consulta?", "ATENÇÃO!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resposta == DialogResult.Yes)
                {
                    FrmProcessamento processa = new FrmProcessamento(folha_existente);
                    processa.ShowDialog();
                }
            }
            else
            {
                var resposta = MessageBox.Show("Folha do mês " + mes_referencia + " ainda não cadastrada. Deseja cadastrar?", "ATENÇÃO!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resposta == DialogResult.Yes)
                {
                    mdlFolhaDePagamento folha = new mdlFolhaDePagamento();
                    folha.id_empresa = id_empresa;
                    folha.mes_referencia = mes + "/" + ano;
                    folha.periodo_inicio = dias[0];
                    folha.periodo_fim = dias[1];
                    folha.salario_liquido = 0.0M;
                    folha.valor_final = 0.0M;
                    folha.valor_desconto = 0.0M;
                    folha.horas_trabalhadas = TimeSpan.Zero;
                    folha.relatorio = null;
                    folha.status_folha = "Rascunho";

                    FrmProcessamento processa = new FrmProcessamento(folha);
                    processa.ShowDialog();
                }
            }
            
        }

        private DateTime[] GetFirstAndLastDayOfMonth(string month, string year)
        {
            CultureInfo cultureInfo = new CultureInfo("pt-BR");

            string formattedMonth = cultureInfo.DateTimeFormat.GetMonthName(Array.IndexOf(cultureInfo.DateTimeFormat.AbbreviatedMonthNames, month.ToLower()) + 1);
            DateTime firstDayOfMonth = DateTime.ParseExact($"01-{formattedMonth}-{year}", "dd-MMMMM-yyyy", cultureInfo);
            int lastDay = DateTime.DaysInMonth(int.Parse(year), firstDayOfMonth.Month);
            DateTime lastDayOfMonth = DateTime.ParseExact($"{lastDay}-{formattedMonth}-{year}", "dd-MMMMM-yyyy", cultureInfo);

            return new DateTime[] { firstDayOfMonth, lastDayOfMonth };
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }
    }
}
