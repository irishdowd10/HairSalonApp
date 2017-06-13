USE [hair_salon_test]
GO
/****** Object:  Table [dbo].[clients]    Script Date: 6/9/17 4:47:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[clients](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](255) NULL,
	[stylists_id] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[stylists]    Script Date: 6/9/17 4:47:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[stylists](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](255) NULL
) ON [PRIMARY]
GO
