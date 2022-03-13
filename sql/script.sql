USE [MySchool]
GO
/****** Object:  Table [dbo].[user_info]    Script Date: 2022/3/13 17:55:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[user_info](
	[userid] [uniqueidentifier] NOT NULL,
	[userno] [nvarchar](50) NULL,
	[password] [nvarchar](50) NULL,
	[businessunitid] [uniqueidentifier] NULL,
	[businessunit] [nvarchar](50) NULL,
	[name] [nvarchar](50) NULL,
	[sex] [nchar](10) NULL,
	[position] [nvarchar](50) NULL,
	[positonid] [uniqueidentifier] NULL,
	[studentclass] [nvarchar](50) NULL,
	[statecode] [nvarchar](50) NULL,
	[education] [nvarchar](50) NULL,
	[collage] [nvarchar](1000) NULL,
	[family] [nvarchar](50) NULL,
	[native_place] [nvarchar](50) NULL,
	[political] [nvarchar](50) NULL,
	[idcard] [nvarchar](100) NULL,
	[birthday] [date] NULL,
	[entry_day] [date] NULL,
	[address] [varchar](200) NULL,
	[phone] [nvarchar](100) NULL,
	[wechat] [nvarchar](100) NULL,
	[role] [nvarchar](50) NULL,
	[createon] [datetime] NULL,
	[modifiedon] [datetime] NULL,
	[remark] [varchar](500) NULL
) ON [PRIMARY]
GO
