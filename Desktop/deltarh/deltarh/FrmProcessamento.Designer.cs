﻿namespace deltarh
{
    partial class FrmProcessamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProcessamento));
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridFolhasIndividuais = new System.Windows.Forms.DataGridView();
            this.btnVisualizar = new System.Windows.Forms.Button();
            this.btnProcessaFolha = new System.Windows.Forms.Button();
            this.txtInicio = new System.Windows.Forms.TextBox();
            this.txtTermino = new System.Windows.Forms.TextBox();
            this.txtValorBruto = new System.Windows.Forms.TextBox();
            this.txtDescontos = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtValorLiquido = new System.Windows.Forms.TextBox();
            this.txtHorasTotais = new System.Windows.Forms.TextBox();
            this.txtEmpresa = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMesReferencia = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSolicitarAprovacao = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.btnRecalcular = new System.Windows.Forms.Button();
            this.txtCNPJ = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFolhasIndividuais)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(197, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 23);
            this.label6.TabIndex = 8;
            this.label6.Text = "Empresa";
            // 
            // dataGridFolhasIndividuais
            // 
            this.dataGridFolhasIndividuais.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridFolhasIndividuais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridFolhasIndividuais.Location = new System.Drawing.Point(12, 129);
            this.dataGridFolhasIndividuais.Name = "dataGridFolhasIndividuais";
            this.dataGridFolhasIndividuais.Size = new System.Drawing.Size(1267, 392);
            this.dataGridFolhasIndividuais.TabIndex = 11;
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisualizar.Location = new System.Drawing.Point(498, 527);
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.Size = new System.Drawing.Size(136, 35);
            this.btnVisualizar.TabIndex = 3;
            this.btnVisualizar.Text = "Visualizar";
            this.btnVisualizar.UseVisualStyleBackColor = true;
            this.btnVisualizar.Click += new System.EventHandler(this.btnVisualizar_Click);
            // 
            // btnProcessaFolha
            // 
            this.btnProcessaFolha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcessaFolha.Location = new System.Drawing.Point(1083, 73);
            this.btnProcessaFolha.Name = "btnProcessaFolha";
            this.btnProcessaFolha.Size = new System.Drawing.Size(136, 35);
            this.btnProcessaFolha.TabIndex = 2;
            this.btnProcessaFolha.Text = "Processar Folha";
            this.btnProcessaFolha.UseVisualStyleBackColor = true;
            this.btnProcessaFolha.Click += new System.EventHandler(this.btnProcessaFolha_Click);
            // 
            // txtInicio
            // 
            this.txtInicio.Enabled = false;
            this.txtInicio.Location = new System.Drawing.Point(9, 19);
            this.txtInicio.Name = "txtInicio";
            this.txtInicio.Size = new System.Drawing.Size(100, 20);
            this.txtInicio.TabIndex = 15;
            // 
            // txtTermino
            // 
            this.txtTermino.Enabled = false;
            this.txtTermino.Location = new System.Drawing.Point(157, 19);
            this.txtTermino.Name = "txtTermino";
            this.txtTermino.Size = new System.Drawing.Size(100, 20);
            this.txtTermino.TabIndex = 16;
            // 
            // txtValorBruto
            // 
            this.txtValorBruto.Enabled = false;
            this.txtValorBruto.Location = new System.Drawing.Point(490, 23);
            this.txtValorBruto.Name = "txtValorBruto";
            this.txtValorBruto.Size = new System.Drawing.Size(100, 20);
            this.txtValorBruto.TabIndex = 17;
            // 
            // txtDescontos
            // 
            this.txtDescontos.Enabled = false;
            this.txtDescontos.Location = new System.Drawing.Point(701, 23);
            this.txtDescontos.Name = "txtDescontos";
            this.txtDescontos.Size = new System.Drawing.Size(100, 20);
            this.txtDescontos.TabIndex = 18;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtTermino);
            this.groupBox1.Controls.Add(this.txtInicio);
            this.groupBox1.Location = new System.Drawing.Point(341, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(263, 56);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Período";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(124, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 16);
            this.label8.TabIndex = 26;
            this.label8.Text = "À";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtValorLiquido);
            this.groupBox2.Controls.Add(this.txtHorasTotais);
            this.groupBox2.Controls.Add(this.txtValorBruto);
            this.groupBox2.Controls.Add(this.txtDescontos);
            this.groupBox2.Location = new System.Drawing.Point(12, 568);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1267, 55);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(188, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 15);
            this.label5.TabIndex = 24;
            this.label5.Text = "Total de Horas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(823, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 15);
            this.label4.TabIndex = 23;
            this.label4.Text = "Valor Líquido R$";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(612, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 15);
            this.label2.TabIndex = 22;
            this.label2.Text = "Descontos R$";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(398, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 15);
            this.label1.TabIndex = 21;
            this.label1.Text = "Valor Bruto R$";
            // 
            // txtValorLiquido
            // 
            this.txtValorLiquido.Enabled = false;
            this.txtValorLiquido.Location = new System.Drawing.Point(925, 23);
            this.txtValorLiquido.Name = "txtValorLiquido";
            this.txtValorLiquido.Size = new System.Drawing.Size(100, 20);
            this.txtValorLiquido.TabIndex = 19;
            // 
            // txtHorasTotais
            // 
            this.txtHorasTotais.Enabled = false;
            this.txtHorasTotais.Location = new System.Drawing.Point(281, 23);
            this.txtHorasTotais.Name = "txtHorasTotais";
            this.txtHorasTotais.Size = new System.Drawing.Size(105, 20);
            this.txtHorasTotais.TabIndex = 20;
            // 
            // txtEmpresa
            // 
            this.txtEmpresa.Enabled = false;
            this.txtEmpresa.Location = new System.Drawing.Point(275, 30);
            this.txtEmpresa.Name = "txtEmpresa";
            this.txtEmpresa.Size = new System.Drawing.Size(411, 20);
            this.txtEmpresa.TabIndex = 20;
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(104, 30);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(63, 22);
            this.txtId.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(69, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 16);
            this.label7.TabIndex = 25;
            this.label7.Text = "ID";
            // 
            // txtMesReferencia
            // 
            this.txtMesReferencia.Enabled = false;
            this.txtMesReferencia.Location = new System.Drawing.Point(183, 83);
            this.txtMesReferencia.Name = "txtMesReferencia";
            this.txtMesReferencia.Size = new System.Drawing.Size(135, 20);
            this.txtMesReferencia.TabIndex = 27;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(625, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 23);
            this.label9.TabIndex = 28;
            this.label9.Text = "Status Folha";
            // 
            // btnSolicitarAprovacao
            // 
            this.btnSolicitarAprovacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSolicitarAprovacao.Location = new System.Drawing.Point(927, 73);
            this.btnSolicitarAprovacao.Name = "btnSolicitarAprovacao";
            this.btnSolicitarAprovacao.Size = new System.Drawing.Size(136, 35);
            this.btnSolicitarAprovacao.TabIndex = 1;
            this.btnSolicitarAprovacao.Text = "Solicitar Aprovação";
            this.btnSolicitarAprovacao.UseVisualStyleBackColor = true;
            this.btnSolicitarAprovacao.Click += new System.EventHandler(this.button1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(66, 84);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 16);
            this.label10.TabIndex = 30;
            this.label10.Text = "Mês Referência";
            // 
            // txtStatus
            // 
            this.txtStatus.Enabled = false;
            this.txtStatus.Location = new System.Drawing.Point(723, 81);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(179, 20);
            this.txtStatus.TabIndex = 31;
            // 
            // btnRecalcular
            // 
            this.btnRecalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecalcular.Location = new System.Drawing.Point(655, 527);
            this.btnRecalcular.Name = "btnRecalcular";
            this.btnRecalcular.Size = new System.Drawing.Size(136, 35);
            this.btnRecalcular.TabIndex = 32;
            this.btnRecalcular.Text = "Recalcular";
            this.btnRecalcular.UseVisualStyleBackColor = true;
            this.btnRecalcular.Click += new System.EventHandler(this.btnRecalcular_Click);
            // 
            // txtCNPJ
            // 
            this.txtCNPJ.Location = new System.Drawing.Point(808, 32);
            this.txtCNPJ.Name = "txtCNPJ";
            this.txtCNPJ.ReadOnly = true;
            this.txtCNPJ.Size = new System.Drawing.Size(411, 20);
            this.txtCNPJ.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(730, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 23);
            this.label3.TabIndex = 33;
            this.label3.Text = "CNPJ";
            // 
            // FrmProcessamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1291, 632);
            this.Controls.Add(this.txtCNPJ);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnRecalcular);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnSolicitarAprovacao);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtMesReferencia);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtEmpresa);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnProcessaFolha);
            this.Controls.Add(this.btnVisualizar);
            this.Controls.Add(this.dataGridFolhasIndividuais);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmProcessamento";
            this.Text = "Folha de Pagamento";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFolhasIndividuais)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridFolhasIndividuais;
        private System.Windows.Forms.Button btnVisualizar;
        private System.Windows.Forms.Button btnProcessaFolha;
        private System.Windows.Forms.TextBox txtValorBruto;
        private System.Windows.Forms.TextBox txtDescontos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtValorLiquido;
        private System.Windows.Forms.TextBox txtHorasTotais;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox txtEmpresa;
        public System.Windows.Forms.TextBox txtId;
        public System.Windows.Forms.TextBox txtMesReferencia;
        public System.Windows.Forms.TextBox txtInicio;
        public System.Windows.Forms.TextBox txtTermino;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSolicitarAprovacao;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Button btnRecalcular;
        public System.Windows.Forms.TextBox txtCNPJ;
        private System.Windows.Forms.Label label3;
    }
}