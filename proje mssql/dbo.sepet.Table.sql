USE [ödev]
GO
/****** Object:  Table [dbo].[sepet]    Script Date: 3.01.2023 15:48:56 ******/
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
