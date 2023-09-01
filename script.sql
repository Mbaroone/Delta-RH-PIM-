USE [master]
GO
/****** Object:  Database [DB_RH]    Script Date: 31/08/2023 21:30:24 ******/
CREATE DATABASE [DB_RH]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DB_RH', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\DB_RH.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'DB_RH_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\DB_RH_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [DB_RH] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DB_RH].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DB_RH] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DB_RH] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DB_RH] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DB_RH] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DB_RH] SET ARITHABORT OFF 
GO
ALTER DATABASE [DB_RH] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [DB_RH] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DB_RH] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DB_RH] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DB_RH] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DB_RH] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DB_RH] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DB_RH] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DB_RH] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DB_RH] SET  DISABLE_BROKER 
GO
ALTER DATABASE [DB_RH] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DB_RH] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DB_RH] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DB_RH] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DB_RH] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DB_RH] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DB_RH] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DB_RH] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [DB_RH] SET  MULTI_USER 
GO
ALTER DATABASE [DB_RH] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DB_RH] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DB_RH] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DB_RH] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [DB_RH] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [DB_RH] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [DB_RH] SET QUERY_STORE = ON
GO
ALTER DATABASE [DB_RH] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [DB_RH]
GO
/****** Object:  Table [dbo].[tbl_colaborador]    Script Date: 31/08/2023 21:30:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_colaborador](
	[id_colaborador] [int] IDENTITY(1,1) NOT NULL,
	[re] [varchar](10) NOT NULL,
	[nome] [varchar](30) NOT NULL,
	[dataNascimento] [date] NOT NULL,
	[cpf] [varchar](1) NOT NULL,
	[telefone] [varchar](1) NOT NULL,
	[salario_bruto] [decimal](7, 2) NOT NULL,
	[senha] [varchar](1) NOT NULL,
	[cod_setor] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_colaborador] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_Contato]    Script Date: 31/08/2023 21:30:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Contato](
	[id_contato] [int] IDENTITY(1,1) NOT NULL,
	[tipo_contato] [varchar](20) NOT NULL,
	[contato] [varchar](30) NOT NULL,
	[id_colaborador] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_contato] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_empresa]    Script Date: 31/08/2023 21:30:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_empresa](
	[id_empresa] [int] IDENTITY(1,1) NOT NULL,
	[id_endereco] [int] NOT NULL,
	[id_colaborador] [int] NOT NULL,
	[login_empresa] [varchar](20) NOT NULL,
	[senha] [varchar](20) NOT NULL,
	[cod_cliente] [varchar](10) NOT NULL,
	[razao_social] [varchar](40) NOT NULL,
	[cnpj] [varchar](20) NOT NULL,
	[telefone] [varchar](20) NOT NULL,
	[id_MiViVa] [int] NOT NULL,
	[id_PoliticaDisciplinar] [int] NOT NULL,
	[id_folhadepgt] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_empresa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_endereco]    Script Date: 31/08/2023 21:30:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_endereco](
	[id_endereco] [int] IDENTITY(1,1) NOT NULL,
	[lougradouro] [varchar](15) NOT NULL,
	[numero] [varchar](10) NOT NULL,
	[complemento] [varchar](15) NULL,
	[bairro] [varchar](15) NOT NULL,
	[cep] [varchar](9) NOT NULL,
	[cidade] [varchar](30) NOT NULL,
	[uf] [varchar](2) NOT NULL,
	[pais] [varchar](20) NOT NULL,
	[id_colaborador] [int] NOT NULL,
 CONSTRAINT [PK_tbl_endereco] PRIMARY KEY CLUSTERED 
(
	[id_endereco] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_FolhadePgt]    Script Date: 31/08/2023 21:30:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_FolhadePgt](
	[id_folhadepgt] [int] IDENTITY(1,1) NOT NULL,
	[valor_folhafinal] [decimal](10, 2) NOT NULL,
	[valor_desc_total] [decimal](10, 2) NOT NULL,
	[horas_trab] [decimal](5, 2) NOT NULL,
	[salario_liq] [decimal](10, 2) NOT NULL,
	[periodo_inicio] [date] NOT NULL,
	[periodo_fim] [date] NOT NULL,
	[id_folhaind] [int] NOT NULL,
	[id_holerite] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_folhadepgt] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_FolhaInd]    Script Date: 31/08/2023 21:30:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_FolhaInd](
	[id_folhaind] [int] IDENTITY(1,1) NOT NULL,
	[periodo_inicio] [date] NOT NULL,
	[periodo_final] [date] NOT NULL,
	[valor_folhafinal] [decimal](10, 2) NOT NULL,
	[valor_desc_total] [decimal](10, 2) NOT NULL,
	[horas_trab] [decimal](5, 2) NOT NULL,
	[salario_liq] [decimal](10, 2) NOT NULL,
	[id_colaborador] [int] NOT NULL,
	[id_folhapgt] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_folhaind] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_Holerite]    Script Date: 31/08/2023 21:30:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Holerite](
	[id_holerite] [int] IDENTITY(1,1) NOT NULL,
	[horas_trab] [decimal](5, 2) NOT NULL,
	[valor_desc_total] [decimal](10, 2) NOT NULL,
	[salario_liq] [decimal](10, 2) NOT NULL,
	[docUrl] [varchar](30) NOT NULL,
	[id_folhadepgt] [int] NOT NULL,
	[id_colaborador] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_holerite] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_justificativa]    Script Date: 31/08/2023 21:30:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_justificativa](
	[id_justificativa] [int] IDENTITY(1,1) NOT NULL,
	[tipoJustificativa] [varchar](20) NOT NULL,
	[descricao] [varchar](200) NOT NULL,
	[dataJustificativa] [date] NOT NULL,
	[urlDoc] [varchar](30) NOT NULL,
	[id_pontoeletronico] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_justificativa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_MissaoVisaoValores]    Script Date: 31/08/2023 21:30:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_MissaoVisaoValores](
	[id_MiViVa] [int] IDENTITY(1,1) NOT NULL,
	[descricao] [varchar](200) NULL,
	[visao_futuro] [varchar](200) NULL,
	[produtividade] [varchar](100) NULL,
	[sustentabilidade] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_MiViVa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_NormaRegra]    Script Date: 31/08/2023 21:30:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_NormaRegra](
	[id_normaregra] [int] IDENTITY(1,1) NOT NULL,
	[tipo] [varchar](20) NULL,
	[descricao] [varchar](200) NULL,
	[id_empresa] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_normaregra] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_PoliticaDisciplinar]    Script Date: 31/08/2023 21:30:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_PoliticaDisciplinar](
	[id_PoliticaDiscilplinar] [int] IDENTITY(1,1) NOT NULL,
	[descricao] [varchar](200) NULL,
	[advertencia] [varchar](50) NULL,
	[dispensa] [varchar](50) NULL,
	[suspensao] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_PoliticaDiscilplinar] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_PontoEletronico]    Script Date: 31/08/2023 21:30:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_PontoEletronico](
	[id_pontoeletronico] [int] IDENTITY(1,1) NOT NULL,
	[dia] [date] NOT NULL,
	[entrada] [datetime] NOT NULL,
	[saida_almoco] [datetime] NOT NULL,
	[retorno_almoco] [datetime] NOT NULL,
	[saida] [datetime] NOT NULL,
	[id_colaborador] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_pontoeletronico] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_setor]    Script Date: 31/08/2023 21:30:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_setor](
	[cod_setor] [int] IDENTITY(1,1) NOT NULL,
	[nome_setor] [varchar](25) NOT NULL,
	[id_empresa] [int] NOT NULL,
 CONSTRAINT [PK_tbl_setor] PRIMARY KEY CLUSTERED 
(
	[cod_setor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_UsuarioRH]    Script Date: 31/08/2023 21:30:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_UsuarioRH](
	[id_acesso] [int] IDENTITY(1,1) NOT NULL,
	[nome] [varchar](40) NOT NULL,
	[senha] [varchar](16) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_acesso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[tbl_colaborador]  WITH CHECK ADD  CONSTRAINT [FK_colab_setor] FOREIGN KEY([cod_setor])
REFERENCES [dbo].[tbl_setor] ([cod_setor])
GO
ALTER TABLE [dbo].[tbl_colaborador] CHECK CONSTRAINT [FK_colab_setor]
GO
ALTER TABLE [dbo].[tbl_Contato]  WITH CHECK ADD  CONSTRAINT [FK_cont_colab] FOREIGN KEY([id_colaborador])
REFERENCES [dbo].[tbl_colaborador] ([id_colaborador])
GO
ALTER TABLE [dbo].[tbl_Contato] CHECK CONSTRAINT [FK_cont_colab]
GO
ALTER TABLE [dbo].[tbl_empresa]  WITH CHECK ADD FOREIGN KEY([id_colaborador])
REFERENCES [dbo].[tbl_colaborador] ([id_colaborador])
GO
ALTER TABLE [dbo].[tbl_empresa]  WITH CHECK ADD FOREIGN KEY([id_endereco])
REFERENCES [dbo].[tbl_endereco] ([id_endereco])
GO
ALTER TABLE [dbo].[tbl_empresa]  WITH CHECK ADD  CONSTRAINT [id_folhadepgt] FOREIGN KEY([id_folhadepgt])
REFERENCES [dbo].[tbl_FolhadePgt] ([id_folhadepgt])
GO
ALTER TABLE [dbo].[tbl_empresa] CHECK CONSTRAINT [id_folhadepgt]
GO
ALTER TABLE [dbo].[tbl_empresa]  WITH CHECK ADD  CONSTRAINT [id_MiViVa] FOREIGN KEY([id_MiViVa])
REFERENCES [dbo].[tbl_MissaoVisaoValores] ([id_MiViVa])
GO
ALTER TABLE [dbo].[tbl_empresa] CHECK CONSTRAINT [id_MiViVa]
GO
ALTER TABLE [dbo].[tbl_empresa]  WITH CHECK ADD  CONSTRAINT [id_PoliticaDisciplinar] FOREIGN KEY([id_PoliticaDisciplinar])
REFERENCES [dbo].[tbl_PoliticaDisciplinar] ([id_PoliticaDiscilplinar])
GO
ALTER TABLE [dbo].[tbl_empresa] CHECK CONSTRAINT [id_PoliticaDisciplinar]
GO
ALTER TABLE [dbo].[tbl_endereco]  WITH CHECK ADD  CONSTRAINT [FK_end_colab] FOREIGN KEY([id_colaborador])
REFERENCES [dbo].[tbl_colaborador] ([id_colaborador])
GO
ALTER TABLE [dbo].[tbl_endereco] CHECK CONSTRAINT [FK_end_colab]
GO
ALTER TABLE [dbo].[tbl_FolhadePgt]  WITH CHECK ADD  CONSTRAINT [id_folhaind] FOREIGN KEY([id_folhaind])
REFERENCES [dbo].[tbl_FolhaInd] ([id_folhaind])
GO
ALTER TABLE [dbo].[tbl_FolhadePgt] CHECK CONSTRAINT [id_folhaind]
GO
ALTER TABLE [dbo].[tbl_FolhadePgt]  WITH CHECK ADD  CONSTRAINT [PKid_holerite] FOREIGN KEY([id_holerite])
REFERENCES [dbo].[tbl_Holerite] ([id_holerite])
GO
ALTER TABLE [dbo].[tbl_FolhadePgt] CHECK CONSTRAINT [PKid_holerite]
GO
ALTER TABLE [dbo].[tbl_FolhaInd]  WITH CHECK ADD  CONSTRAINT [FK_find_colab] FOREIGN KEY([id_colaborador])
REFERENCES [dbo].[tbl_colaborador] ([id_colaborador])
GO
ALTER TABLE [dbo].[tbl_FolhaInd] CHECK CONSTRAINT [FK_find_colab]
GO
ALTER TABLE [dbo].[tbl_FolhaInd]  WITH CHECK ADD  CONSTRAINT [FK_finf_fpgt] FOREIGN KEY([id_folhapgt])
REFERENCES [dbo].[tbl_FolhadePgt] ([id_folhadepgt])
GO
ALTER TABLE [dbo].[tbl_FolhaInd] CHECK CONSTRAINT [FK_finf_fpgt]
GO
ALTER TABLE [dbo].[tbl_Holerite]  WITH CHECK ADD  CONSTRAINT [FK_hol_colab] FOREIGN KEY([id_colaborador])
REFERENCES [dbo].[tbl_colaborador] ([id_colaborador])
GO
ALTER TABLE [dbo].[tbl_Holerite] CHECK CONSTRAINT [FK_hol_colab]
GO
ALTER TABLE [dbo].[tbl_Holerite]  WITH CHECK ADD  CONSTRAINT [FK_hol_fpgt] FOREIGN KEY([id_folhadepgt])
REFERENCES [dbo].[tbl_FolhadePgt] ([id_folhadepgt])
GO
ALTER TABLE [dbo].[tbl_Holerite] CHECK CONSTRAINT [FK_hol_fpgt]
GO
ALTER TABLE [dbo].[tbl_justificativa]  WITH CHECK ADD  CONSTRAINT [FK_pont_just] FOREIGN KEY([id_pontoeletronico])
REFERENCES [dbo].[tbl_PontoEletronico] ([id_pontoeletronico])
GO
ALTER TABLE [dbo].[tbl_justificativa] CHECK CONSTRAINT [FK_pont_just]
GO
ALTER TABLE [dbo].[tbl_NormaRegra]  WITH CHECK ADD  CONSTRAINT [FK_Norma_empresa] FOREIGN KEY([id_empresa])
REFERENCES [dbo].[tbl_empresa] ([id_empresa])
GO
ALTER TABLE [dbo].[tbl_NormaRegra] CHECK CONSTRAINT [FK_Norma_empresa]
GO
ALTER TABLE [dbo].[tbl_PontoEletronico]  WITH CHECK ADD  CONSTRAINT [FK_ponto_colab] FOREIGN KEY([id_colaborador])
REFERENCES [dbo].[tbl_colaborador] ([id_colaborador])
GO
ALTER TABLE [dbo].[tbl_PontoEletronico] CHECK CONSTRAINT [FK_ponto_colab]
GO
ALTER TABLE [dbo].[tbl_setor]  WITH CHECK ADD  CONSTRAINT [FK_empresa_setor] FOREIGN KEY([id_empresa])
REFERENCES [dbo].[tbl_empresa] ([id_empresa])
GO
ALTER TABLE [dbo].[tbl_setor] CHECK CONSTRAINT [FK_empresa_setor]
GO
USE [master]
GO
ALTER DATABASE [DB_RH] SET  READ_WRITE 
GO
