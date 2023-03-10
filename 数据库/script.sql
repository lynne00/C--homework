USE [c_dazuoye]
GO
/****** Object:  Table [dbo].[class]    Script Date: 2022/12/18 5:06:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[class](
	[claid] [bigint] IDENTITY(1,1) NOT NULL,
	[claname] [varchar](30) NULL,
	[teacher] [varchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[claid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[manager]    Script Date: 2022/12/18 5:06:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[manager](
	[manid] [bigint] IDENTITY(1,1) NOT NULL,
	[manname] [varchar](30) NOT NULL,
	[role] [varchar](30) NULL,
	[manpasswd] [varchar](30) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[manid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[sc]    Script Date: 2022/12/18 5:06:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sc](
	[scid] [bigint] IDENTITY(1,1) NOT NULL,
	[stuxuehao] [varchar](30) NULL,
	[claid] [bigint] NULL,
PRIMARY KEY CLUSTERED 
(
	[scid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[student]    Script Date: 2022/12/18 5:06:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[student](
	[stuid] [bigint] IDENTITY(1,1) NOT NULL,
	[stuname] [varchar](30) NULL,
	[stuxuehao] [varchar](30) NOT NULL,
	[stupasswd] [varchar](30) NOT NULL,
	[stugrade] [varchar](30) NULL,
	[stumajor] [varchar](30) NULL,
	[stusex] [varchar](2) NULL,
	[stuborn] [varchar](30) NULL,
	[role] [varchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[stuid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[class] ON 

INSERT [dbo].[class] ([claid], [claname], [teacher]) VALUES (1, N'c++课程设计', N'张三')
INSERT [dbo].[class] ([claid], [claname], [teacher]) VALUES (2, N'计算机导论', N'李四')
SET IDENTITY_INSERT [dbo].[class] OFF
SET IDENTITY_INSERT [dbo].[manager] ON 

INSERT [dbo].[manager] ([manid], [manname], [role], [manpasswd]) VALUES (1, N'lin', N'管理员', N'123')
INSERT [dbo].[manager] ([manid], [manname], [role], [manpasswd]) VALUES (2, N'admin', N'管理员', N'123')
INSERT [dbo].[manager] ([manid], [manname], [role], [manpasswd]) VALUES (3, N'1', N'管理员', N'1')
SET IDENTITY_INSERT [dbo].[manager] OFF
SET IDENTITY_INSERT [dbo].[sc] ON 

INSERT [dbo].[sc] ([scid], [stuxuehao], [claid]) VALUES (1, N'1', 1)
INSERT [dbo].[sc] ([scid], [stuxuehao], [claid]) VALUES (2, N'1', 2)
SET IDENTITY_INSERT [dbo].[sc] OFF
SET IDENTITY_INSERT [dbo].[student] ON 

INSERT [dbo].[student] ([stuid], [stuname], [stuxuehao], [stupasswd], [stugrade], [stumajor], [stusex], [stuborn], [role]) VALUES (2, N'lynne', N'1', N'123', N'2020', N'计算机科学与技术', N'男', N'2002-02-13', N'学生')
INSERT [dbo].[student] ([stuid], [stuname], [stuxuehao], [stupasswd], [stugrade], [stumajor], [stusex], [stuborn], [role]) VALUES (7, N'ww', N'ww', N'ww', N'2021', N'电子信息工程', N'女', N'2022-12-17', N'学生')
SET IDENTITY_INSERT [dbo].[student] OFF
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ__manager__7E43C8896AE2BA9B]    Script Date: 2022/12/18 5:06:25 ******/
ALTER TABLE [dbo].[manager] ADD UNIQUE NONCLUSTERED 
(
	[manname] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ__student___A79C5E5E71A787EC]    Script Date: 2022/12/18 5:06:25 ******/
ALTER TABLE [dbo].[student] ADD UNIQUE NONCLUSTERED 
(
	[stuxuehao] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[manager] ADD  DEFAULT ('管理员') FOR [role]
GO
ALTER TABLE [dbo].[student] ADD  DEFAULT ('男') FOR [stusex]
GO
ALTER TABLE [dbo].[student] ADD  DEFAULT ('学生') FOR [role]
GO
ALTER TABLE [dbo].[sc]  WITH CHECK ADD  CONSTRAINT [scc_id] FOREIGN KEY([claid])
REFERENCES [dbo].[class] ([claid])
GO
ALTER TABLE [dbo].[sc] CHECK CONSTRAINT [scc_id]
GO
ALTER TABLE [dbo].[sc]  WITH CHECK ADD  CONSTRAINT [ssc_id] FOREIGN KEY([stuxuehao])
REFERENCES [dbo].[student] ([stuxuehao])
GO
ALTER TABLE [dbo].[sc] CHECK CONSTRAINT [ssc_id]
GO
