USE [ödev]
GO
/****** Object:  Table [dbo].[cesit]    Script Date: 3.01.2023 15:44:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[cesit](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[cesit] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[cesitid]    Script Date: 3.01.2023 15:44:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[cesitid](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[cesitid] [int] NULL,
	[marka] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[kullanıcı]    Script Date: 3.01.2023 15:44:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[kullanıcı](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[isimsoyisim] [varchar](50) NULL,
	[telno ] [varchar](50) NULL,
	[adres] [varchar](50) NULL,
	[email] [varchar](50) NULL,
	[kullanıcıadi] [varchar](50) NULL,
	[sifre] [varchar](50) NULL,
	[görev] [varchar](50) NULL,
	[resim] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[sepet]    Script Date: 3.01.2023 15:44:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sepet](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[kullanıcıid] [varchar](50) NULL,
	[adı soyadı] [varchar](50) NULL,
	[çeşitid] [varchar](50) NULL,
	[çeşit] [varchar](50) NULL,
	[tür ] [varchar](50) NULL,
	[fiyat] [money] NULL,
	[vergi] [money] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ürünler]    Script Date: 3.01.2023 15:44:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ürünler](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[çeşit] [varchar](50) NULL,
	[marka] [varchar](50) NULL,
	[fiyat] [money] NULL,
	[VERGİ] [money] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[cesitid]  WITH CHECK ADD  CONSTRAINT [FK_cesitid_Table] FOREIGN KEY([cesitid])
REFERENCES [dbo].[cesit] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[cesitid] CHECK CONSTRAINT [FK_cesitid_Table]
GO
