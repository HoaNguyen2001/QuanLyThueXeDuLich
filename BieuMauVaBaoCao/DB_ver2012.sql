Create database QLXeDuLich
USE [QLXeDuLich]
GO
/****** Object:  Table [dbo].[Bills]    Script Date: 31-Aug-20 01:18:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bills](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[EmpID] [int] NOT NULL,
	[CustomerID] [int] NOT NULL,
	[DateOfHire] [datetime] NOT NULL,
	[DateOfPayment] [datetime] NOT NULL,
	[PricePerDay] [int] NULL,
	[InforCarID] [int] NULL,
	[CreateDay] [datetime] NULL,
	[Status] [bit] NULL,
 CONSTRAINT [PK_Bills] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 31-Aug-20 01:18:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customers](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Sex] [bit] NULL,
	[IDCardNumber] [int] NULL,
	[Phone] [nchar](15) NULL,
	[Address] [nvarchar](50) NULL,
 CONSTRAINT [PK_Customers] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 31-Aug-20 01:18:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Birthday] [datetime] NULL,
	[Address] [nvarchar](50) NULL,
	[Phone] [nchar](15) NULL,
	[Account] [nchar](20) NULL,
	[Password] [nchar](20) NULL,
	[Role] [int] NULL,
 CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[InforCar]    Script Date: 31-Aug-20 01:18:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[InforCar](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[ManufacturerCar] [nvarchar](50) NULL,
	[Color] [nvarchar](30) NULL,
	[RegistrationDate] [datetime] NULL,
	[Status] [nvarchar](20) NULL,
	[NumCar] [int] NULL,
	[PricePerDay] [int] NULL,
	[ManufactureYear] [datetime] NULL,
	[NumberOfCar] [int] NULL,
	[DateAddCar] [datetime] NULL,
 CONSTRAINT [PK_InforCar] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Punish]    Script Date: 31-Aug-20 01:18:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Punish](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[BillsID] [int] NOT NULL,
	[EmpID] [int] NOT NULL,
	[CustomerID] [int] NOT NULL,
	[Description] [nvarchar](100) NULL,
	[Price] [int] NULL,
	[Date] [datetime] NULL,
 CONSTRAINT [PK_Punish] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
