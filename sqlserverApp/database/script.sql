USE [DapperTest1]
GO
/****** Object:  Table [dbo].[Test1]    Script Date: 1/11/2024 1:23:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Test1](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[DateOnly] [date] NULL,
	[TimeOnly] [time](7) NULL,
 CONSTRAINT [PK_Test1] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Test1] ON 

INSERT [dbo].[Test1] ([Id], [DateOnly], [TimeOnly]) VALUES (1, CAST(N'1970-05-29' AS Date), CAST(N'18:30:22.5128171' AS Time))
INSERT [dbo].[Test1] ([Id], [DateOnly], [TimeOnly]) VALUES (2, CAST(N'1960-10-02' AS Date), CAST(N'09:41:59.6481882' AS Time))
INSERT [dbo].[Test1] ([Id], [DateOnly], [TimeOnly]) VALUES (3, CAST(N'1985-09-10' AS Date), CAST(N'03:59:02.2851182' AS Time))
INSERT [dbo].[Test1] ([Id], [DateOnly], [TimeOnly]) VALUES (4, CAST(N'2007-01-05' AS Date), CAST(N'23:38:28.0653452' AS Time))
INSERT [dbo].[Test1] ([Id], [DateOnly], [TimeOnly]) VALUES (5, CAST(N'1999-01-10' AS Date), CAST(N'02:36:58.0003388' AS Time))
INSERT [dbo].[Test1] ([Id], [DateOnly], [TimeOnly]) VALUES (6, CAST(N'1983-04-18' AS Date), CAST(N'07:21:37.1872497' AS Time))
INSERT [dbo].[Test1] ([Id], [DateOnly], [TimeOnly]) VALUES (7, CAST(N'1977-10-14' AS Date), CAST(N'19:15:04.9358467' AS Time))
INSERT [dbo].[Test1] ([Id], [DateOnly], [TimeOnly]) VALUES (8, CAST(N'2019-01-26' AS Date), CAST(N'10:41:35.2330604' AS Time))
INSERT [dbo].[Test1] ([Id], [DateOnly], [TimeOnly]) VALUES (9, CAST(N'1960-02-03' AS Date), CAST(N'05:23:58.5445029' AS Time))
INSERT [dbo].[Test1] ([Id], [DateOnly], [TimeOnly]) VALUES (10, CAST(N'1997-12-21' AS Date), CAST(N'00:16:08.2548169' AS Time))
SET IDENTITY_INSERT [dbo].[Test1] OFF
GO
USE [master]
GO
ALTER DATABASE [DapperTest1] SET  READ_WRITE 
GO
