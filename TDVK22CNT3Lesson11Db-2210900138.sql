USE [TDVK22CNT3Lesson11Db]
GO
/****** Object:  Table [dbo].[TDVCategory]    Script Date: 7/4/2024 10:16:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TDVCategory](
	[TDVId] [int] NOT NULL,
	[TDVCateName] [nvarchar](50) NULL,
	[TDVStatus] [bit] NULL,
 CONSTRAINT [PK_TDVCategory] PRIMARY KEY CLUSTERED 
(
	[TDVId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TDVProduct]    Script Date: 7/4/2024 10:16:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TDVProduct](
	[TDVId2210900138] [nvarchar](50) NOT NULL,
	[TDVProName] [nvarchar](50) NULL,
	[TDVQty] [int] NULL,
	[TDVPrice] [float] NULL,
	[TDVCateId] [int] NULL,
	[TDVActive] [bit] NULL,
 CONSTRAINT [PK_TDVProduct] PRIMARY KEY CLUSTERED 
(
	[TDVId2210900138] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[TDVCategory] ([TDVId], [TDVCateName], [TDVStatus]) VALUES (1, N'2210900138', 1)
INSERT [dbo].[TDVCategory] ([TDVId], [TDVCateName], [TDVStatus]) VALUES (2, N'Android', 0)
GO
INSERT [dbo].[TDVProduct] ([TDVId2210900138], [TDVProName], [TDVQty], [TDVPrice], [TDVCateId], [TDVActive]) VALUES (N'2210900138', N'Tran Duy Vu', 10, 9999, 1, 1)
INSERT [dbo].[TDVProduct] ([TDVId2210900138], [TDVProName], [TDVQty], [TDVPrice], [TDVCateId], [TDVActive]) VALUES (N'P001', N'Samsung Galaxy S11', 1, 1000, 1, 1)
GO
