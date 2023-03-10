USE [ödev]
GO
/****** Object:  Table [dbo].[cesitid]    Script Date: 3.01.2023 15:48:56 ******/
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
ALTER TABLE [dbo].[cesitid]  WITH CHECK ADD  CONSTRAINT [FK_cesitid_Table] FOREIGN KEY([cesitid])
REFERENCES [dbo].[cesit] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[cesitid] CHECK CONSTRAINT [FK_cesitid_Table]
GO
