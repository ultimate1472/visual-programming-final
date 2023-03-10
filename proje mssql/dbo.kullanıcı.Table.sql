USE [ödev]
GO
/****** Object:  Table [dbo].[kullanıcı]    Script Date: 3.01.2023 15:48:56 ******/
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
