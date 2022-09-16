USE [MindBox]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 30.08.2022 1:38:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CategoryProduct]    Script Date: 30.08.2022 1:38:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CategoryProduct](
	[ProductId] [int] NOT NULL,
	[CategoryId] [int] NULL,
	[Id] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_CategoryProduct] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 30.08.2022 1:38:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Category] ON 

INSERT [dbo].[Category] ([Id], [Name]) VALUES (1, N'���������1')
INSERT [dbo].[Category] ([Id], [Name]) VALUES (2, N'���������2')
INSERT [dbo].[Category] ([Id], [Name]) VALUES (3, N'���������3')
INSERT [dbo].[Category] ([Id], [Name]) VALUES (4, N'���������4')
SET IDENTITY_INSERT [dbo].[Category] OFF
GO
SET IDENTITY_INSERT [dbo].[CategoryProduct] ON 

INSERT [dbo].[CategoryProduct] ([ProductId], [CategoryId], [Id]) VALUES (1, 1, 1)
INSERT [dbo].[CategoryProduct] ([ProductId], [CategoryId], [Id]) VALUES (1, 2, 2)
INSERT [dbo].[CategoryProduct] ([ProductId], [CategoryId], [Id]) VALUES (2, 2, 3)
INSERT [dbo].[CategoryProduct] ([ProductId], [CategoryId], [Id]) VALUES (3, 3, 4)
INSERT [dbo].[CategoryProduct] ([ProductId], [CategoryId], [Id]) VALUES (4, 4, 5)
INSERT [dbo].[CategoryProduct] ([ProductId], [CategoryId], [Id]) VALUES (5, NULL, 6)
SET IDENTITY_INSERT [dbo].[CategoryProduct] OFF
GO
SET IDENTITY_INSERT [dbo].[Product] ON 

INSERT [dbo].[Product] ([Id], [Name]) VALUES (1, N'�������1')
INSERT [dbo].[Product] ([Id], [Name]) VALUES (2, N'�������2')
INSERT [dbo].[Product] ([Id], [Name]) VALUES (3, N'�������3')
INSERT [dbo].[Product] ([Id], [Name]) VALUES (4, N'�������4')
INSERT [dbo].[Product] ([Id], [Name]) VALUES (5, N'�������5')
SET IDENTITY_INSERT [dbo].[Product] OFF
GO
ALTER TABLE [dbo].[CategoryProduct]  WITH CHECK ADD  CONSTRAINT [FK_CategoryProduct_Category] FOREIGN KEY([CategoryId])
REFERENCES [dbo].[Category] ([Id])
GO
ALTER TABLE [dbo].[CategoryProduct] CHECK CONSTRAINT [FK_CategoryProduct_Category]
GO
ALTER TABLE [dbo].[CategoryProduct]  WITH CHECK ADD  CONSTRAINT [FK_CategoryProduct_Product] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Product] ([Id])
GO
ALTER TABLE [dbo].[CategoryProduct] CHECK CONSTRAINT [FK_CategoryProduct_Product]
GO
