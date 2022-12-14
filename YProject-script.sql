USE [AGACKAKAN]
GO
/****** Object:  Table [dbo].[Categories]    Script Date: 8.06.2021 15:42:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[CategoryId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NULL,
	[OrderNumber] [tinyint] NULL,
 CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED 
(
	[CategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Colors]    Script Date: 8.06.2021 15:42:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Colors](
	[ColorId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
 CONSTRAINT [PK_Colors] PRIMARY KEY CLUSTERED 
(
	[ColorId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductImages]    Script Date: 8.06.2021 15:42:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductImages](
	[ProductImageId] [int] IDENTITY(1,1) NOT NULL,
	[ProductId] [int] NULL,
	[ImagePath] [nvarchar](max) NULL,
	[OrderNumber] [tinyint] NULL,
 CONSTRAINT [PK_ProductImages] PRIMARY KEY CLUSTERED 
(
	[ProductImageId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 8.06.2021 15:42:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[ProductId] [int] IDENTITY(1,1) NOT NULL,
	[CategoryId] [int] NULL,
	[ColorId] [int] NULL,
	[Name] [varchar](100) NULL,
	[Description] [varchar](max) NULL,
	[Price1] [decimal](18, 2) NULL,
	[Price2] [decimal](18, 2) NULL,
	[Barcode] [varchar](20) NULL,
	[Stock] [int] NULL,
	[IsActive] [bit] NULL,
	[OrderNumber] [tinyint] NULL,
	[ShowHomePage] [bit] NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Test]    Script Date: 8.06.2021 15:42:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Test](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
 CONSTRAINT [PK_Test] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 8.06.2021 15:42:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[UserId] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](100) NULL,
	[LastName] [nvarchar](80) NULL,
	[UserName] [varchar](50) NOT NULL,
	[Email] [varchar](100) NULL,
	[Password] [varchar](20) NOT NULL,
	[PhoneNumber] [varchar](50) NULL,
	[Token] [varchar](250) NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Categories] ADD  CONSTRAINT [DF_Categories_OrderNumber]  DEFAULT ((0)) FOR [OrderNumber]
GO
ALTER TABLE [dbo].[Products] ADD  CONSTRAINT [DF_Products_IsActive]  DEFAULT ((1)) FOR [IsActive]
GO
ALTER TABLE [dbo].[Products] ADD  CONSTRAINT [DF_Products_OrderNumber]  DEFAULT ((0)) FOR [OrderNumber]
GO
ALTER TABLE [dbo].[Products] ADD  CONSTRAINT [DF_Products_ShowHomePage]  DEFAULT ((0)) FOR [ShowHomePage]
GO
/****** Object:  StoredProcedure [dbo].[CategoryGet]    Script Date: 8.06.2021 15:42:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CategoryGet] (@Id INT)
AS
SELECT 
*
FROM Categories WITH(NOLOCK) WHERE CategoryId = @Id
GO
/****** Object:  StoredProcedure [dbo].[CategoryList]    Script Date: 8.06.2021 15:42:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[CategoryList]
(
	@Records int,
	@Page int,
	@Search VARCHAR(250)
)
AS
BEGIN
SET @Page = IIF(@Page > 0, @Page-1, @Page)

SELECT 
	Categories.CategoryId,
	Categories.OrderNumber,
	Categories.Name,
	TotalRecords = COUNT(*) OVER(),
	TotalPages = CONVERT(INT,CEILING(CAST(COUNT(*) OVER() AS decimal) / CAST(IIF(@Records = 0, @Records + 1, @Records) AS decimal)))
FROM 
Categories WITH(NOLOCK)
WHERE (Categories.Name LIKE '%'+@Search+'%'
OR Categories.OrderNumber LIKE '%'+@Search+'%')
ORDER BY Categories.CategoryId DESC OFFSET @Page * @Records ROWS FETCH NEXT @Records ROWS ONLY
END
GO
/****** Object:  StoredProcedure [dbo].[ColorList]    Script Date: 8.06.2021 15:42:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[ColorList]
(
	@Records int,
	@Page int,
	@Search VARCHAR(250)
)
AS
BEGIN
SET @Page = IIF(@Page > 0, @Page-1, @Page)

SELECT 
	Colors.ColorId, 
	Colors.Name,
	TotalRecords = COUNT(*) OVER(),
	TotalPages = CONVERT(INT,CEILING(CAST(COUNT(*) OVER() AS decimal) / CAST(IIF(@Records = 0, @Records + 1, @Records) AS decimal)))
FROM 
Colors WITH(NOLOCK)
WHERE (Colors.Name LIKE '%'+@Search+'%')
ORDER BY Colors.Name OFFSET @Page * @Records ROWS FETCH NEXT @Records ROWS ONLY
END
GO
/****** Object:  StoredProcedure [dbo].[ProductGet]    Script Date: 8.06.2021 15:42:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ProductGet] (@Id INT)
AS
SELECT 
*
FROM Products WITH(NOLOCK) WHERE ProductId = @Id
GO
/****** Object:  StoredProcedure [dbo].[ProductList]    Script Date: 8.06.2021 15:42:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[ProductList]
(
	@Records int,
	@Page int,
	@Search VARCHAR(250)
)
AS
BEGIN
SET @Page = IIF(@Page > 0, @Page-1, @Page)

SELECT 
	Products.ProductId,
	CategoryName = (SELECT TOP(1) Name From Categories WITH(NOLOCK) WHERE Categories.CategoryId = Products.CategoryId ),
	ColorName = (SELECT TOP(1) Name From Colors WITH(NOLOCK) WHERE Colors.ColorId = Products.ColorId ),
	Products.Name,
	Products.Price1,
	Products.Price2,
	Products.Barcode,
	Products.Stock,
	Products.IsActive,
	Products.ShowHomePage,
	Products.OrderNumber,
	Image= (select TOP(1)ImagePath Image from ProductImages where ProductId = Products.ProductId AND OrderNumber=1),
	TotalRecords = COUNT(*) OVER(),
	TotalPages = CONVERT(INT,CEILING(CAST(COUNT(*) OVER() AS decimal) / CAST(IIF(@Records = 0, @Records + 1, @Records) AS decimal)))
FROM 
Products WITH(NOLOCK)
WHERE (Products.Name LIKE '%'+@Search+'%'
OR (SELECT TOP(1) Name From Categories WITH(NOLOCK) WHERE Categories.CategoryId = Products.CategoryId )LIKE '%'+@Search+'%'
OR Products.Price1 LIKE '%'+@Search+'%'
OR Products.Price2 LIKE '%'+@Search+'%'
OR Products.Barcode LIKE '%'+@Search+'%'
OR Products.Stock LIKE '%'+@Search+'%'
OR Products.IsActive LIKE '%'+@Search+'%'
OR Products.OrderNumber LIKE '%'+@Search+'%'
)
ORDER BY Products.ProductId DESC OFFSET @Page * @Records ROWS FETCH NEXT @Records ROWS ONLY
END
GO
