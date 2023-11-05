USE [BD_DELTA]

-- Create the MissaoVisaoValores table
CREATE TABLE [dbo].[tbl_missaovisaovalores](
    [id_missaovisaovalores] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
    [descricao] [varchar](256) NOT NULL
);

-- Create the PoliticaDisciplinar table
CREATE TABLE [dbo].[tbl_politicadisciplinar](
    [id_politicadisciplinar] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
    [descricao] [varchar](256) NOT NULL
);

-- Create the Empresa table with time columns converted to decimal columns
CREATE TABLE [dbo].[tbl_empresa](
    [id_empresa] [int] PRIMARY KEY IDENTITY(1,1) NOT NULL,
    [senha] [varchar](200) NOT NULL,
    [razao_social] [varchar](90) NOT NULL,
    [cnpj] [varchar](20) UNIQUE NOT NULL,
    [nome_responsavel] [varchar](50) NOT NULL,
    [cpf_responsavel] [varchar](15) NOT NULL,
    [logradouro] [varchar](128) NOT NULL,
    [numero] [varchar](10) NOT NULL,
    [complemento] [varchar](100) NULL,
    [bairro] [varchar](80) NOT NULL,
    [cep] [varchar](15) NOT NULL,
    [cidade] [varchar](60) NOT NULL,
    [uf] [varchar](10) NOT NULL,
    [telefone] [varchar](20) NOT NULL,
    [telefone2] [varchar](20) NOT NULL,
    [email] [varchar](50) NOT NULL,
    [status] [varchar](20) NOT NULL,
    [vt] [decimal](5, 2) NULL,
    [vr] [decimal](5, 2) NULL,
    [ass_medica] [decimal](5, 2) NULL,
    [odonto] [decimal](5, 2) NULL,
    [gympass] [decimal](5, 2) NULL,
    [id_missaovisaovalores] [int] NOT NULL,
    [id_politicadisciplinar] [int] NOT NULL,
);

-- Create the NormaRegra table
CREATE TABLE [dbo].[tbl_normaregra](
    [id_normaregra] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
    [tipo] [varchar](20) NULL,
    [descricao] [varchar](200) NULL,
    [id_empresa] [int] NOT NULL
);

-- Create the Setor table
CREATE TABLE [dbo].[tbl_setor](
    [id_setor] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
    [nome_setor] [varchar](25) NOT NULL,
    [id_empresa] [int] NOT NULL
);

-- Create the Colaborador table with time columns converted to decimal columns
CREATE TABLE [dbo].[tbl_colaborador](
    [id_colaborador] [int] PRIMARY KEY IDENTITY(1,1) NOT NULL,
    [nome] [varchar](50) NOT NULL,
    [data_nascimento] [date] NOT NULL,
    [cpf] [varchar](15) UNIQUE NOT NULL,
    [tipo_contrato] [varchar](20) NOT NULL,
    [salario_bruto] [decimal](8, 2) NOT NULL,
    [senha] [varchar](200) NOT NULL,
    [carga_horaria] [int] NOT NULL,
    [logradouro] [varchar](128) NOT NULL,
    [numero] [varchar](10) NOT NULL,
    [complemento] [varchar](100) NULL,
    [bairro] [varchar](80) NOT NULL,
    [cep] [varchar](15) NOT NULL,
    [cidade] [varchar](60) NOT NULL,
    [uf] [varchar](10) NOT NULL,
    [telefone] [varchar](15) NOT NULL,
    [telefone2] [varchar](15) NOT NULL,
    [email] [varchar](50) NOT NULL,
    [id_setor] [int] NOT NULL,
    [cargo] [varchar](50) NOT NULL,
    [status] [varchar](10) NOT NULL,
    [id_empresa] [int] NOT NULL,
    [horas_banco] [decimal](8, 2) NOT NULL, -- New column to store time as decimal (in minutes)
);

-- Create the FolhadePgt table with time columns converted to decimal columns
CREATE TABLE [dbo].[tbl_folhadepagamento](
    [id_folhadepagamento] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
    [doc_folhadepagamento] VARBINARY(MAX),
    [valor_folhafinal] [decimal](12, 2) NOT NULL,
    [valor_desc_total] [decimal](12, 2) NOT NULL,
    [horas_trab] [decimal](8, 2) NOT NULL, -- New column to store time as decimal (in minutes)
    [salario_liq] [decimal](12, 2) NOT NULL,
    [periodo_inicio] [date] NOT NULL,
    [periodo_fim] [date] NOT NULL,
    [status_folha] [varchar](15) NOT NULL,
    [id_empresa] [int] NOT NULL,
    [mes_referencia] [varchar](20) NOT NULL
);

-- Create the FolhaInd table with time columns converted to decimal columns
CREATE TABLE [dbo].[tbl_folhaindividual](
    [id_folhaindividual] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
    [periodo_inicio] [date] NOT NULL,
    [periodo_fim] [date] NOT NULL,
    [valor_folhafinal] [decimal](12, 2) NOT NULL,
    [valor_desc_total] [decimal](12, 2) NOT NULL,
    [horas_trab] [decimal](8, 2) NOT NULL, -- New column to store time as decimal (in minutes)
    [salario_liq] [decimal](12, 2) NOT NULL,
    [id_folhadepagamento] [int] NOT NULL,
    [id_colaborador] [int] NOT NULL,
    [mes_referencia] [varchar](20) NOT NULL,
    [status] [varchar](20) NOT NULL,
    [horas_extras] [decimal](8, 2) NOT NULL, -- New column to store time as decimal (in minutes)
    [valor_venc_total] [decimal](12, 2) NOT NULL,
    [valor_horas_extras] [decimal](12, 2) NOT NULL,
    [horas_atraso] [decimal](8, 2),
    [valor_desc_atrasos] [decimal](12, 2) NOT NULL
);

-- Create the Holerite table
CREATE TABLE [dbo].[tbl_holerite](
    [id_holerite] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
    [nome_empresa] [varchar](70) NOT NULL,
    [cnpj_empresa] [varchar](20) NOT NULL,
    [periodo_inicio] [date] NOT NULL,
    [periodo_fim] [date] NOT NULL,
    [id_folhadepagamento] [int] NOT NULL,
    [id_colaborador] [int] NOT NULL,
    [nome_colaborador] [varchar](70) NOT NULL,
    [cargo_colaborador] [varchar](50) NOT NULL,
    [horas_trab] [decimal](8, 2) NOT NULL, -- New column to store time as decimal (in minutes)
    [porcentagem_vt] [decimal](5, 2),
    [porcentagem_vr] [decimal](5, 2),
    [porcentagem_assis_odonto] [decimal](5, 2),
    [porcentagem_assis_medica] [decimal](5, 2),
    [porcentagem_adiantamento] [decimal](5, 2),
    [horas_extras] [decimal](8, 2) NOT NULL, -- New column to store time as decimal (in minutes)
    [salario_base] [decimal](12, 2) NOT NULL,
    [total_vencimentos] [decimal](12, 2) NOT NULL,
    [total_descontos] [decimal](12, 2) NOT NULL,
    [salario_liq] [decimal](12, 2) NOT NULL,
    [mes_ano_ref] [varchar](25) NOT NULL,
    [valor_horas_extras] [decimal](12, 2) NOT NULL,
    [horas_atraso] [decimal](8, 2),
    [valor_desc_atrasos] [decimal](12, 2) NOT NULL
);


/****** Object:  Table [dbo].[tbl_PontoEletronico]    Script Date: 31/08/2023 21:30:24 ******/
CREATE TABLE [dbo].[tbl_pontoeletronico](
	[id_pontoeletronico] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[data] [datetime] NOT NULL,
	[entrada] [time](0),
	[saida_almoco] [time](0),
	[retorno_almoco] [time](0),
	[saida] [time](0),
	[tipo_justificativa] [varchar](20),
	[descricao] [varchar](200),
	[documento] VARBINARY(MAX),
	[id_colaborador] [int] NOT NULL,
	CONSTRAINT FK_pontoeletronico_colaborador FOREIGN KEY (id_colaborador) 
	REFERENCES tbl_colaborador(id_colaborador));

/****** Object:  Table [dbo].[tbl_UsuarioRH]    Script Date: 31/08/2023 21:30:24 ******/
/*CREATE TABLE [dbo].[tbl_usuariodesktop](
	[id_acesso] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[nome] [varchar](40) NOT NULL,
	[senha] [varchar](16) NOT NULL,
	[tipo_acesso] [varchar](10) NOT NULL);
*/
