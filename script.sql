USE [master]
GO
/****** Object:  Database [Controle de estoque]    Script Date: 21/11/2021 21:29:29 ******/
CREATE DATABASE [Controle de estoque]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Controle de estoque', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Controle de estoque.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Controle de estoque_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Controle de estoque_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Controle de estoque] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Controle de estoque].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Controle de estoque] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Controle de estoque] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Controle de estoque] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Controle de estoque] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Controle de estoque] SET ARITHABORT OFF 
GO
ALTER DATABASE [Controle de estoque] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Controle de estoque] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Controle de estoque] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Controle de estoque] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Controle de estoque] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Controle de estoque] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Controle de estoque] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Controle de estoque] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Controle de estoque] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Controle de estoque] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Controle de estoque] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Controle de estoque] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Controle de estoque] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Controle de estoque] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Controle de estoque] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Controle de estoque] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Controle de estoque] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Controle de estoque] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Controle de estoque] SET  MULTI_USER 
GO
ALTER DATABASE [Controle de estoque] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Controle de estoque] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Controle de estoque] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Controle de estoque] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Controle de estoque] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Controle de estoque] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Controle de estoque] SET QUERY_STORE = OFF
GO
USE [Controle de estoque]
GO
/****** Object:  Table [dbo].[Estoque]    Script Date: 21/11/2021 21:29:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Estoque](
	[idEstoque] [int] IDENTITY(1,1) NOT NULL,
	[dataValEstoque] [date] NOT NULL,
	[numeroLote] [varchar](50) NOT NULL,
	[qtdEstoque] [int] NOT NULL,
	[idProduto] [int] NOT NULL,
	[idFornecedor] [int] NOT NULL,
 CONSTRAINT [PK_Estoque] PRIMARY KEY CLUSTERED 
(
	[idEstoque] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Produto]    Script Date: 21/11/2021 21:29:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Produto](
	[idProduto] [int] IDENTITY(1,1) NOT NULL,
	[nomeProduto] [varchar](50) NULL,
	[descProduto] [varchar](50) NULL,
	[precoProduto] [decimal](9, 2) NULL,
	[idSetor] [int] NOT NULL,
	[fotoProduto] [varchar](50) NULL,
 CONSTRAINT [PK_Produto] PRIMARY KEY CLUSTERED 
(
	[idProduto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[EstoqueQuantidadePorProduto]    Script Date: 21/11/2021 21:29:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[EstoqueQuantidadePorProduto]
as

	select SUM(e.qtdEstoque) as "quantidadePorProduto", p.nomeProduto
	from Estoque e inner join Produto p on e.idProduto = p.idProduto
	group by p.nomeProduto


	
	
GO
/****** Object:  View [dbo].[ProdutoENumLote]    Script Date: 21/11/2021 21:29:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[ProdutoENumLote]
as

	select p.idProduto, p.nomeProduto, e.numeroLote
	from Estoque e inner join Produto p on e.idProduto = p.idProduto


	
	
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 21/11/2021 21:29:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cliente](
	[idCliente] [int] IDENTITY(1,1) NOT NULL,
	[nomeCliente] [varchar](50) NULL,
	[cpfCliente] [varchar](50) NULL,
	[enderecoCliente] [varchar](50) NULL,
	[telefoneCliente] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Cliente] PRIMARY KEY CLUSTERED 
(
	[idCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Fornecedor]    Script Date: 21/11/2021 21:29:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Fornecedor](
	[idFornecedor] [int] IDENTITY(1,1) NOT NULL,
	[nomeFornecedor] [varchar](50) NULL,
	[cnpjFornecedor] [varchar](50) NULL,
	[telefoneFornecedor] [varchar](50) NULL,
 CONSTRAINT [PK_Fornecedor] PRIMARY KEY CLUSTERED 
(
	[idFornecedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Funcionario]    Script Date: 21/11/2021 21:29:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Funcionario](
	[idFuncionario] [int] IDENTITY(1,1) NOT NULL,
	[cpfFuncionario] [varchar](50) NULL,
	[nomeFuncionario] [varchar](50) NULL,
	[dataNascFuncionario] [varchar](50) NULL,
	[enderecoFuncionario] [varchar](50) NULL,
	[telefoneFuncionario] [varchar](50) NULL,
	[cargoFuncionario] [varchar](50) NULL,
 CONSTRAINT [PK_Funcionario] PRIMARY KEY CLUSTERED 
(
	[idFuncionario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Itens_Pedidos]    Script Date: 21/11/2021 21:29:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Itens_Pedidos](
	[idItensPedidos] [int] IDENTITY(1,1) NOT NULL,
	[idPedido] [int] NULL,
	[idEstoque] [int] NULL,
	[quantidadeItensPedido] [int] NULL,
	[precoItensPedido] [decimal](9, 2) NULL,
 CONSTRAINT [PK_Itens_Pedidos] PRIMARY KEY CLUSTERED 
(
	[idItensPedidos] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pagamento]    Script Date: 21/11/2021 21:29:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pagamento](
	[idPagamento] [int] IDENTITY(1,1) NOT NULL,
	[idPedido] [int] NOT NULL,
	[formaPagamento] [varchar](50) NOT NULL,
	[quantidadeParcela] [int] NOT NULL,
	[precoTotal] [decimal](9, 2) NOT NULL,
 CONSTRAINT [PK_Pagamento] PRIMARY KEY CLUSTERED 
(
	[idPagamento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Parcela]    Script Date: 21/11/2021 21:29:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Parcela](
	[idParcela] [int] IDENTITY(1,1) NOT NULL,
	[idPagamento] [int] NULL,
	[numeroParcela] [int] NULL,
	[precoParcela] [decimal](9, 2) NULL,
 CONSTRAINT [PK_Parcela] PRIMARY KEY CLUSTERED 
(
	[idParcela] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pedidos]    Script Date: 21/11/2021 21:29:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pedidos](
	[idPedido] [int] IDENTITY(1,1) NOT NULL,
	[dataPedido] [date] NULL,
	[preco] [decimal](9, 2) NULL,
	[idFuncionario] [int] NULL,
	[idCliente] [int] NULL,
 CONSTRAINT [PK_Pedidos] PRIMARY KEY CLUSTERED 
(
	[idPedido] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Setor]    Script Date: 21/11/2021 21:29:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Setor](
	[idSetor] [int] IDENTITY(1,1) NOT NULL,
	[nomeSetor] [varchar](50) NULL,
 CONSTRAINT [PK_Setor] PRIMARY KEY CLUSTERED 
(
	[idSetor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Estoque]  WITH CHECK ADD  CONSTRAINT [FK_Estoque_Fornecedor] FOREIGN KEY([idFornecedor])
REFERENCES [dbo].[Fornecedor] ([idFornecedor])
GO
ALTER TABLE [dbo].[Estoque] CHECK CONSTRAINT [FK_Estoque_Fornecedor]
GO
ALTER TABLE [dbo].[Estoque]  WITH CHECK ADD  CONSTRAINT [FK_Estoque_Produto] FOREIGN KEY([idProduto])
REFERENCES [dbo].[Produto] ([idProduto])
GO
ALTER TABLE [dbo].[Estoque] CHECK CONSTRAINT [FK_Estoque_Produto]
GO
ALTER TABLE [dbo].[Itens_Pedidos]  WITH CHECK ADD  CONSTRAINT [FK_Itens_Pedidos_Itens_Estoque] FOREIGN KEY([idEstoque])
REFERENCES [dbo].[Estoque] ([idEstoque])
GO
ALTER TABLE [dbo].[Itens_Pedidos] CHECK CONSTRAINT [FK_Itens_Pedidos_Itens_Estoque]
GO
ALTER TABLE [dbo].[Itens_Pedidos]  WITH CHECK ADD  CONSTRAINT [FK_Itens_Pedidos_TablePedido] FOREIGN KEY([idPedido])
REFERENCES [dbo].[Pedidos] ([idPedido])
GO
ALTER TABLE [dbo].[Itens_Pedidos] CHECK CONSTRAINT [FK_Itens_Pedidos_TablePedido]
GO
ALTER TABLE [dbo].[Pagamento]  WITH CHECK ADD  CONSTRAINT [FK_Pagamento_Pedido] FOREIGN KEY([idPedido])
REFERENCES [dbo].[Pedidos] ([idPedido])
GO
ALTER TABLE [dbo].[Pagamento] CHECK CONSTRAINT [FK_Pagamento_Pedido]
GO
ALTER TABLE [dbo].[Parcela]  WITH CHECK ADD  CONSTRAINT [FK_Parcela_Pagamento] FOREIGN KEY([idPagamento])
REFERENCES [dbo].[Pagamento] ([idPagamento])
GO
ALTER TABLE [dbo].[Parcela] CHECK CONSTRAINT [FK_Parcela_Pagamento]
GO
ALTER TABLE [dbo].[Pedidos]  WITH CHECK ADD  CONSTRAINT [FK_Pedidos_Cliente] FOREIGN KEY([idCliente])
REFERENCES [dbo].[Cliente] ([idCliente])
GO
ALTER TABLE [dbo].[Pedidos] CHECK CONSTRAINT [FK_Pedidos_Cliente]
GO
ALTER TABLE [dbo].[Pedidos]  WITH CHECK ADD  CONSTRAINT [FK_Pedidos_Funcionario] FOREIGN KEY([idFuncionario])
REFERENCES [dbo].[Funcionario] ([idFuncionario])
GO
ALTER TABLE [dbo].[Pedidos] CHECK CONSTRAINT [FK_Pedidos_Funcionario]
GO
ALTER TABLE [dbo].[Produto]  WITH CHECK ADD  CONSTRAINT [FK_Produto_Setor] FOREIGN KEY([idSetor])
REFERENCES [dbo].[Setor] ([idSetor])
GO
ALTER TABLE [dbo].[Produto] CHECK CONSTRAINT [FK_Produto_Setor]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'idFornecedor(estoque) - idFornecedor(fornecedor)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Estoque', @level2type=N'CONSTRAINT',@level2name=N'FK_Estoque_Fornecedor'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'idProduto de estoque se relaciona com o id produto de produto
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Estoque', @level2type=N'CONSTRAINT',@level2name=N'FK_Estoque_Produto'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'idCliente(Pedido) - idCliente(Cliente)
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Pedidos', @level2type=N'CONSTRAINT',@level2name=N'FK_Pedidos_Cliente'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'idFuncionario(Pedido)-idFuncionario(Funcionario)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Pedidos', @level2type=N'CONSTRAINT',@level2name=N'FK_Pedidos_Funcionario'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Relaciona o idSetor de produto com o idSetor do Setor' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Produto', @level2type=N'CONSTRAINT',@level2name=N'FK_Produto_Setor'
GO
USE [master]
GO
ALTER DATABASE [Controle de estoque] SET  READ_WRITE 
GO
