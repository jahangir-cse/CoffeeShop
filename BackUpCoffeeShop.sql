USE [CoffeShop]
GO
/****** Object:  Table [dbo].[Items]    Script Date: 2019-10-05 10:53:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Items](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](30) NULL,
	[Price] [float] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Items] ON 

INSERT [dbo].[Items] ([Id], [Name], [Price]) VALUES (5, N'Cold', 100)
INSERT [dbo].[Items] ([Id], [Name], [Price]) VALUES (6, N'Black', 120)
INSERT [dbo].[Items] ([Id], [Name], [Price]) VALUES (7, N'Black', 200)
SET IDENTITY_INSERT [dbo].[Items] OFF
