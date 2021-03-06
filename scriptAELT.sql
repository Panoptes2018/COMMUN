USE [AEJT_WOTR]
GO
/****** Object:  User [ederidder]    Script Date: 11/03/2019 17:06:59 ******/
CREATE USER [ederidder] FOR LOGIN [PRINCE\ederidder] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [jboyer]    Script Date: 11/03/2019 17:06:59 ******/
CREATE USER [jboyer] FOR LOGIN [PRINCE\jboyer] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [tgisclard]    Script Date: 11/03/2019 17:06:59 ******/
CREATE USER [tgisclard] FOR LOGIN [PRINCE\tgisclard] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_datareader] ADD MEMBER [ederidder]
GO
ALTER ROLE [db_datawriter] ADD MEMBER [ederidder]
GO
ALTER ROLE [db_owner] ADD MEMBER [jboyer]
GO
ALTER ROLE [db_datareader] ADD MEMBER [tgisclard]
GO
ALTER ROLE [db_datawriter] ADD MEMBER [tgisclard]
GO
/****** Object:  Table [dbo].[Client]    Script Date: 11/03/2019 17:06:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Client](
	[idClie] [varchar](10) NOT NULL,
	[nomClie] [varchar](50) NULL,
	[prenomClie] [varchar](50) NULL,
	[dateNaissanceClie] [date] NULL,
	[pwdClie] [varchar](8) NULL,
	[codeAccesClie] [varchar](8) NULL,
	[villeClie] [varchar](50) NULL,
	[codePostaleClie] [varchar](50) NULL,
	[adresseClie] [varchar](50) NULL,
	[tellClie] [varchar](10) NULL,
	[mailClie] [varchar](50) NULL,
 CONSTRAINT [PK_Client] PRIMARY KEY CLUSTERED 
(
	[idClie] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employe]    Script Date: 11/03/2019 17:06:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employe](
	[idEmp] [varchar](10) NOT NULL,
	[mailEmp] [varchar](50) NULL,
	[pwdEmp] [nchar](10) NULL,
	[nomEmp] [varchar](50) NULL,
	[prenomEmp] [varchar](50) NULL,
 CONSTRAINT [PK_Employe] PRIMARY KEY CLUSTERED 
(
	[idEmp] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Client] ([idClie], [nomClie], [prenomClie], [dateNaissanceClie], [pwdClie], [codeAccesClie], [villeClie], [codePostaleClie], [adresseClie], [tellClie], [mailClie]) VALUES (N'01', N'Jean', N'Michel', CAST(N'1990-01-01' AS Date), N'123456', N'2486', N'SaintExupery', N'83400', N'858 rue charlois', N'0623678410', N'test@test.com')
INSERT [dbo].[Client] ([idClie], [nomClie], [prenomClie], [dateNaissanceClie], [pwdClie], [codeAccesClie], [villeClie], [codePostaleClie], [adresseClie], [tellClie], [mailClie]) VALUES (N'02', N'Pierre', N'Robert', CAST(N'1995-05-08' AS Date), N'789123', N'7931', N'SaintExupery', N'83400', N'25 rue charlois', N'0625236100', N'test2@test2.com')
INSERT [dbo].[Employe] ([idEmp], [mailEmp], [pwdEmp], [nomEmp], [prenomEmp]) VALUES (N'01', N'test@test.com', N'test      ', N'test1', N'test2')
