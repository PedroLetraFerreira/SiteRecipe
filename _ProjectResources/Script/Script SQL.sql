USE [master]
GO
/****** Object:  Database [PedroFerreira_SiteRecipes]    Script Date: 26/11/2020 15:37:16 ******/
CREATE DATABASE [PedroFerreira_SiteRecipes]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SiteRecipe', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\SiteRecipe.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'SiteRecipe_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\SiteRecipe_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [PedroFerreira_SiteRecipes] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [PedroFerreira_SiteRecipes].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [PedroFerreira_SiteRecipes] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [PedroFerreira_SiteRecipes] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [PedroFerreira_SiteRecipes] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [PedroFerreira_SiteRecipes] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [PedroFerreira_SiteRecipes] SET ARITHABORT OFF 
GO
ALTER DATABASE [PedroFerreira_SiteRecipes] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [PedroFerreira_SiteRecipes] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [PedroFerreira_SiteRecipes] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [PedroFerreira_SiteRecipes] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [PedroFerreira_SiteRecipes] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [PedroFerreira_SiteRecipes] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [PedroFerreira_SiteRecipes] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [PedroFerreira_SiteRecipes] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [PedroFerreira_SiteRecipes] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [PedroFerreira_SiteRecipes] SET  DISABLE_BROKER 
GO
ALTER DATABASE [PedroFerreira_SiteRecipes] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [PedroFerreira_SiteRecipes] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [PedroFerreira_SiteRecipes] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [PedroFerreira_SiteRecipes] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [PedroFerreira_SiteRecipes] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [PedroFerreira_SiteRecipes] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [PedroFerreira_SiteRecipes] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [PedroFerreira_SiteRecipes] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [PedroFerreira_SiteRecipes] SET  MULTI_USER 
GO
ALTER DATABASE [PedroFerreira_SiteRecipes] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [PedroFerreira_SiteRecipes] SET DB_CHAINING OFF 
GO
ALTER DATABASE [PedroFerreira_SiteRecipes] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [PedroFerreira_SiteRecipes] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [PedroFerreira_SiteRecipes] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [PedroFerreira_SiteRecipes] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [PedroFerreira_SiteRecipes] SET QUERY_STORE = OFF
GO
USE [PedroFerreira_SiteRecipes]
GO
/****** Object:  Table [dbo].[Accounts]    Script Date: 26/11/2020 15:37:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Accounts](
	[AccountId] [int] IDENTITY(1,1) NOT NULL,
	[Username] [nvarchar](100) NOT NULL,
	[Password] [nvarchar](100) NOT NULL,
	[UserId] [int] NOT NULL,
 CONSTRAINT [PK_Accounts] PRIMARY KEY CLUSTERED 
(
	[AccountId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Categories]    Script Date: 26/11/2020 15:37:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[CategoryId] [int] IDENTITY(1,1) NOT NULL,
	[CategoryName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED 
(
	[CategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Comments]    Script Date: 26/11/2020 15:37:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Comments](
	[CommentId] [int] IDENTITY(1,1) NOT NULL,
	[CommentContent] [nvarchar](500) NOT NULL,
	[CommentDate] [date] NOT NULL,
	[IsValidated] [bit] NOT NULL,
	[RecipeId] [int] NOT NULL,
	[UserId] [int] NOT NULL,
 CONSTRAINT [PK_Comments] PRIMARY KEY CLUSTERED 
(
	[CommentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ingredients]    Script Date: 26/11/2020 15:37:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ingredients](
	[IngredientId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
	[Quantity] [real] NOT NULL,
	[MeasurementUnit] [nvarchar](50) NOT NULL,
	[RecipeId] [int] NULL,
 CONSTRAINT [PK_Ingredients] PRIMARY KEY CLUSTERED 
(
	[IngredientId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Recipes]    Script Date: 26/11/2020 15:37:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Recipes](
	[RecipeId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
	[Rating] [tinyint] NOT NULL,
	[Difficulty] [tinyint] NOT NULL,
	[Description] [nvarchar](max) NOT NULL,
	[CookingTime] [time](0) NOT NULL,
	[IsValidated] [bit] NOT NULL,
	[UserId] [int] NOT NULL,
	[CategoryId] [int] NOT NULL,
 CONSTRAINT [PK_Recipes] PRIMARY KEY CLUSTERED 
(
	[RecipeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 26/11/2020 15:37:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[UserId] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[Country] [nvarchar](50) NOT NULL,
	[Gender] [tinyint] NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[BirthDate] [date] NOT NULL,
	[IsAdministrator] [bit] NOT NULL,
	[AccountId] [int] NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Accounts] ON 

INSERT [dbo].[Accounts] ([AccountId], [Username], [Password], [UserId]) VALUES (1, N'XaviChef', N'xavi12345', 1)
INSERT [dbo].[Accounts] ([AccountId], [Username], [Password], [UserId]) VALUES (2, N'SaraCardoso', N'sarocas345', 2)
INSERT [dbo].[Accounts] ([AccountId], [Username], [Password], [UserId]) VALUES (3, N'Abrilita', N'abril930612', 3)
INSERT [dbo].[Accounts] ([AccountId], [Username], [Password], [UserId]) VALUES (4, N'NandoBoss', N'cheguevara', 4)
INSERT [dbo].[Accounts] ([AccountId], [Username], [Password], [UserId]) VALUES (5, N'PabloDiaz', N'elpatron', 5)
SET IDENTITY_INSERT [dbo].[Accounts] OFF
GO
SET IDENTITY_INSERT [dbo].[Categories] ON 

INSERT [dbo].[Categories] ([CategoryId], [CategoryName]) VALUES (1, N'Meat')
INSERT [dbo].[Categories] ([CategoryId], [CategoryName]) VALUES (2, N'Fish')
INSERT [dbo].[Categories] ([CategoryId], [CategoryName]) VALUES (3, N'Pasta')
INSERT [dbo].[Categories] ([CategoryId], [CategoryName]) VALUES (4, N'Vegetarian')
INSERT [dbo].[Categories] ([CategoryId], [CategoryName]) VALUES (5, N'Soap')
INSERT [dbo].[Categories] ([CategoryId], [CategoryName]) VALUES (6, N'Dessert')
INSERT [dbo].[Categories] ([CategoryId], [CategoryName]) VALUES (7, N'Vegan')
SET IDENTITY_INSERT [dbo].[Categories] OFF
GO
SET IDENTITY_INSERT [dbo].[Comments] ON 

INSERT [dbo].[Comments] ([CommentId], [CommentContent], [CommentDate], [IsValidated], [RecipeId], [UserId]) VALUES (1, N'Amazing recipe', CAST(N'2020-09-23' AS Date), 1, 4, 1)
INSERT [dbo].[Comments] ([CommentId], [CommentContent], [CommentDate], [IsValidated], [RecipeId], [UserId]) VALUES (2, N'Tastes delicious', CAST(N'2020-04-11' AS Date), 1, 2, 4)
INSERT [dbo].[Comments] ([CommentId], [CommentContent], [CommentDate], [IsValidated], [RecipeId], [UserId]) VALUES (3, N'Easy to cook and amazing to eat', CAST(N'2019-12-13' AS Date), 1, 3, 5)
INSERT [dbo].[Comments] ([CommentId], [CommentContent], [CommentDate], [IsValidated], [RecipeId], [UserId]) VALUES (4, N'Got all the kitchen dirty', CAST(N'2019-10-25' AS Date), 1, 1, 3)
INSERT [dbo].[Comments] ([CommentId], [CommentContent], [CommentDate], [IsValidated], [RecipeId], [UserId]) VALUES (5, N'Disgusting', CAST(N'2020-01-09' AS Date), 1, 5, 2)
SET IDENTITY_INSERT [dbo].[Comments] OFF
GO
SET IDENTITY_INSERT [dbo].[Ingredients] ON 

INSERT [dbo].[Ingredients] ([IngredientId], [Name], [Quantity], [MeasurementUnit], [RecipeId]) VALUES (1, N'Eggs', 4, N'units', 1)
INSERT [dbo].[Ingredients] ([IngredientId], [Name], [Quantity], [MeasurementUnit], [RecipeId]) VALUES (2, N'Chicken', 750, N'grams', 2)
INSERT [dbo].[Ingredients] ([IngredientId], [Name], [Quantity], [MeasurementUnit], [RecipeId]) VALUES (3, N'Coconut Milk', 0.5, N'liters', 2)
INSERT [dbo].[Ingredients] ([IngredientId], [Name], [Quantity], [MeasurementUnit], [RecipeId]) VALUES (4, N'Curry', 2, N'soup spoons', 2)
INSERT [dbo].[Ingredients] ([IngredientId], [Name], [Quantity], [MeasurementUnit], [RecipeId]) VALUES (5, N'Milk', 200, N'liters', 3)
INSERT [dbo].[Ingredients] ([IngredientId], [Name], [Quantity], [MeasurementUnit], [RecipeId]) VALUES (6, N'Eggs', 2, N'units', 3)
INSERT [dbo].[Ingredients] ([IngredientId], [Name], [Quantity], [MeasurementUnit], [RecipeId]) VALUES (7, N'Chocolate', 250, N'grams', 3)
INSERT [dbo].[Ingredients] ([IngredientId], [Name], [Quantity], [MeasurementUnit], [RecipeId]) VALUES (8, N'Onion', 2, N'units', 4)
INSERT [dbo].[Ingredients] ([IngredientId], [Name], [Quantity], [MeasurementUnit], [RecipeId]) VALUES (9, N'Potato', 1, N'units', 4)
INSERT [dbo].[Ingredients] ([IngredientId], [Name], [Quantity], [MeasurementUnit], [RecipeId]) VALUES (10, N'Rice', 100, N'grams', 4)
INSERT [dbo].[Ingredients] ([IngredientId], [Name], [Quantity], [MeasurementUnit], [RecipeId]) VALUES (11, N'Flower', 100, N'grams', 3)
INSERT [dbo].[Ingredients] ([IngredientId], [Name], [Quantity], [MeasurementUnit], [RecipeId]) VALUES (12, N'Calamary', 350, N'grams', 5)
SET IDENTITY_INSERT [dbo].[Ingredients] OFF
GO
SET IDENTITY_INSERT [dbo].[Recipes] ON 

INSERT [dbo].[Recipes] ([RecipeId], [Name], [Rating], [Difficulty], [Description], [CookingTime], [IsValidated], [UserId], [CategoryId]) VALUES (1, N'Scrambled Eggs', 1, 1, N'1.Put oil in a pan 2.Break the eggs into the pan 3.With a woodspoon mix the eggs 4.After 5 minutes turn off the hoven 6.Ready to eat', CAST(N'00:05:00' AS Time), 1, 2, 4)
INSERT [dbo].[Recipes] ([RecipeId], [Name], [Rating], [Difficulty], [Description], [CookingTime], [IsValidated], [UserId], [CategoryId]) VALUES (2, N'Chicken Curry', 1, 3, N'1.Cut the chicken in small pieces 2.Put oil, garlic and onion in the pan and cook it for 3 min 3.Put the chcken in the pan 4.After 10 minutes put the coconut oil and curry 6.Let it cook for 5 minutes and turn it off', CAST(N'00:18:00' AS Time), 0, 1, 1)
INSERT [dbo].[Recipes] ([RecipeId], [Name], [Rating], [Difficulty], [Description], [CookingTime], [IsValidated], [UserId], [CategoryId]) VALUES (3, N'Pancakes', 1, 2, N'1.Mix eggs, milk and sugar 2.Put the mix in the pan 3.Leave 2 min and turn the side 4.Leave 2 min more 5.Take it from the pan put chocolate and fold it', CAST(N'00:05:00' AS Time), 0, 3, 6)
INSERT [dbo].[Recipes] ([RecipeId], [Name], [Rating], [Difficulty], [Description], [CookingTime], [IsValidated], [UserId], [CategoryId]) VALUES (4, N'Onion Soup', 1, 1, N'1.Put water, onion, potato in a pan 2.When boiling put the rice 3.Leave 5 min and turn it off', CAST(N'00:15:00' AS Time), 0, 4, 5)
INSERT [dbo].[Recipes] ([RecipeId], [Name], [Rating], [Difficulty], [Description], [CookingTime], [IsValidated], [UserId], [CategoryId]) VALUES (5, N'Fried Calamary', 1, 2, N'1.Put oil in the pan 
		2.Pass the calamary in egg and then in bread 
		3.When oil is boiling put the calamary
		4.After 5 min turn it off', CAST(N'00:10:00' AS Time), 1, 5, 2)
SET IDENTITY_INSERT [dbo].[Recipes] OFF
GO
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([UserId], [FirstName], [LastName], [Country], [Gender], [Email], [BirthDate], [IsAdministrator], [AccountId]) VALUES (1, N'Xavier', N'Antunes', N'Portugal', 1, N'xavi.antunes@gmail.com', CAST(N'1989-04-11' AS Date), 0, 1)
INSERT [dbo].[Users] ([UserId], [FirstName], [LastName], [Country], [Gender], [Email], [BirthDate], [IsAdministrator], [AccountId]) VALUES (2, N'Sara', N'Cardoso', N'Portugal', 2, N'saracardoso@gmail.com', CAST(N'1990-02-08' AS Date), 0, 2)
INSERT [dbo].[Users] ([UserId], [FirstName], [LastName], [Country], [Gender], [Email], [BirthDate], [IsAdministrator], [AccountId]) VALUES (3, N'Abril', N'Montserrat', N'Argentina', 2, N'abril.montserrat@gmail.com', CAST(N'1993-06-12' AS Date), 0, 3)
INSERT [dbo].[Users] ([UserId], [FirstName], [LastName], [Country], [Gender], [Email], [BirthDate], [IsAdministrator], [AccountId]) VALUES (4, N'Armando', N'Sousa', N'Portugal', 1, N'armando.sousa94@gmail.com', CAST(N'1994-12-24' AS Date), 0, 4)
INSERT [dbo].[Users] ([UserId], [FirstName], [LastName], [Country], [Gender], [Email], [BirthDate], [IsAdministrator], [AccountId]) VALUES (5, N'Pablo', N'Diaz', N'Spain', 1, N'pablodiaz1984@gmail.com', CAST(N'1984-10-18' AS Date), 1, 5)
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
/****** Object:  Index [IX_Accounts]    Script Date: 26/11/2020 15:37:17 ******/
ALTER TABLE [dbo].[Accounts] ADD  CONSTRAINT [IX_Accounts] UNIQUE NONCLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Accounts]  WITH CHECK ADD  CONSTRAINT [FK_Accounts_Users] FOREIGN KEY([AccountId])
REFERENCES [dbo].[Users] ([UserId])
GO
ALTER TABLE [dbo].[Accounts] CHECK CONSTRAINT [FK_Accounts_Users]
GO
ALTER TABLE [dbo].[Comments]  WITH CHECK ADD  CONSTRAINT [FK_Comments_Recipes] FOREIGN KEY([RecipeId])
REFERENCES [dbo].[Recipes] ([RecipeId])
GO
ALTER TABLE [dbo].[Comments] CHECK CONSTRAINT [FK_Comments_Recipes]
GO
ALTER TABLE [dbo].[Comments]  WITH CHECK ADD  CONSTRAINT [FK_Comments_Users] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([UserId])
GO
ALTER TABLE [dbo].[Comments] CHECK CONSTRAINT [FK_Comments_Users]
GO
ALTER TABLE [dbo].[Ingredients]  WITH CHECK ADD  CONSTRAINT [FK_Ingredients_Recipes] FOREIGN KEY([RecipeId])
REFERENCES [dbo].[Recipes] ([RecipeId])
GO
ALTER TABLE [dbo].[Ingredients] CHECK CONSTRAINT [FK_Ingredients_Recipes]
GO
ALTER TABLE [dbo].[Recipes]  WITH CHECK ADD  CONSTRAINT [FK_Recipes_Categories] FOREIGN KEY([CategoryId])
REFERENCES [dbo].[Categories] ([CategoryId])
GO
ALTER TABLE [dbo].[Recipes] CHECK CONSTRAINT [FK_Recipes_Categories]
GO
ALTER TABLE [dbo].[Recipes]  WITH CHECK ADD  CONSTRAINT [FK_Recipes_Users] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([UserId])
GO
ALTER TABLE [dbo].[Recipes] CHECK CONSTRAINT [FK_Recipes_Users]
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_Accounts] FOREIGN KEY([UserId])
REFERENCES [dbo].[Accounts] ([AccountId])
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_Users_Accounts]
GO
/****** Object:  StoredProcedure [dbo].[spAddCategory]    Script Date: 26/11/2020 15:37:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spAddCategory]
@CategoryName nvarchar(50),
@CategoryId int out

AS 
BEGIN
	INSERT INTO Categories  
		VALUES (@CategoryName)
		SET @CategoryId = cast(SCOPE_IDENTITY() as int)
	
END;
GO
/****** Object:  StoredProcedure [dbo].[spAddIngredient]    Script Date: 26/11/2020 15:37:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spAddIngredient]
@Name nvarchar(100),
@Quantity real,
@MeasurementUnit nvarchar(50),
@RecipeId int,
@IngredientId int out
AS 
BEGIN
	INSERT INTO Ingredients ([Name], Quantity, MeasurementUnit, RecipeId)
		VALUES (@Name, @Quantity, @MeasurementUnit, @RecipeId)
		SET @IngredientId = cast(SCOPE_IDENTITY() as int)
	
END;
GO
/****** Object:  StoredProcedure [dbo].[spAddUser]    Script Date: 26/11/2020 15:37:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spAddUser]
@FirstName nvarchar(50),
@LastName nvarchar(50),
@Country nvarchar(50),
@Gender tinyint,
@Email nvarchar(50),
@BirthDate date,
@IsAdministrator bit,
@AccountId int,
@UserId int out
AS 
BEGIN
	INSERT INTO Users (FirstName, LastName, Country, Gender, Email, BirthDate, IsAdministrator, AccountId)
		VALUES (@FirstName, @LastName, @Country, @Gender, @Email, @BirthDate, @IsAdministrator, @AccountId)
		SET @UserId = cast(SCOPE_IDENTITY() as int)

END;
GO
/****** Object:  StoredProcedure [dbo].[spGetAllAccounts]    Script Date: 26/11/2020 15:37:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spGetAllAccounts]

AS 
BEGIN
	SELECT * FROM Accounts 

END;
GO
/****** Object:  StoredProcedure [dbo].[spGetAllCategories]    Script Date: 26/11/2020 15:37:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spGetAllCategories]

AS 
BEGIN
	SELECT * FROM Categories  

END;
GO
/****** Object:  StoredProcedure [dbo].[spGetAllComments]    Script Date: 26/11/2020 15:37:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spGetAllComments]

AS 
BEGIN
	SELECT * FROM Comments  

END;
GO
/****** Object:  StoredProcedure [dbo].[spGetAllIngredients]    Script Date: 26/11/2020 15:37:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spGetAllIngredients]

AS 
BEGIN
	SELECT * FROM Ingredients

END;
GO
/****** Object:  StoredProcedure [dbo].[spGetAllRecipes]    Script Date: 26/11/2020 15:37:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spGetAllRecipes]

AS 
BEGIN
	SELECT * FROM Recipes

END;
GO
/****** Object:  StoredProcedure [dbo].[spGetAllUsers]    Script Date: 26/11/2020 15:37:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spGetAllUsers]

AS 
BEGIN
	SELECT * FROM Users 

END;
GO
/****** Object:  StoredProcedure [dbo].[spGetByIdAccount]    Script Date: 26/11/2020 15:37:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spGetByIdAccount]
@AccountId int
AS 
BEGIN
	SELECT * FROM Accounts
	WHERE AccountId = @AccountId  

END;
GO
/****** Object:  StoredProcedure [dbo].[spGetByIdCategory]    Script Date: 26/11/2020 15:37:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spGetByIdCategory]
@CategoryId int
AS 
BEGIN
	SELECT * FROM Categories 
	WHERE CategoryId = @CategoryId   

END;
GO
/****** Object:  StoredProcedure [dbo].[spGetByIdComment]    Script Date: 26/11/2020 15:37:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spGetByIdComment]
@CommentId int
AS 
BEGIN
	SELECT * FROM Comments 
	WHERE CommentId = @CommentId   

END;
GO
/****** Object:  StoredProcedure [dbo].[spGetByIdIngredient]    Script Date: 26/11/2020 15:37:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spGetByIdIngredient]
@IngredientId int
AS 
BEGIN
	SELECT * FROM Ingredients
	WHERE IngredientId = @IngredientId 

END;
GO
/****** Object:  StoredProcedure [dbo].[spGetByIdRecipe]    Script Date: 26/11/2020 15:37:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spGetByIdRecipe]
@RecipeId int
AS 
BEGIN
	SELECT * FROM Recipes
	WHERE RecipeId = @RecipeId 

END;
GO
/****** Object:  StoredProcedure [dbo].[spGetByIdUser]    Script Date: 26/11/2020 15:37:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spGetByIdUser]
@UserId int
AS 
BEGIN
	SELECT * FROM Users 
	WHERE UserId = @UserId  

END;
GO
/****** Object:  StoredProcedure [dbo].[spRemoveAccount]    Script Date: 26/11/2020 15:37:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spRemoveAccount]
@AccountId int 

AS
BEGIN
	DELETE FROM Accounts   
	WHERE AccountId = @AccountId 

END;
GO
/****** Object:  StoredProcedure [dbo].[spRemoveCategory]    Script Date: 26/11/2020 15:37:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spRemoveCategory]
@CategoryId int 

AS
BEGIN
	DELETE FROM Categories    
	WHERE CategoryId = @CategoryId  

END;
GO
/****** Object:  StoredProcedure [dbo].[spRemoveComment]    Script Date: 26/11/2020 15:37:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spRemoveComment]
@CommentId int 

AS
BEGIN
	DELETE FROM Comments    
	WHERE CommentId = @CommentId 

END;
GO
/****** Object:  StoredProcedure [dbo].[spRemoveIngredient]    Script Date: 26/11/2020 15:37:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spRemoveIngredient]
@IngredientId int 

AS
BEGIN
	DELETE FROM Ingredients  
	WHERE IngredientId = @IngredientId

END;
GO
/****** Object:  StoredProcedure [dbo].[spRemoveRecipe]    Script Date: 26/11/2020 15:37:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spRemoveRecipe]
@RecipeId int 

AS
BEGIN
	DELETE FROM Recipes  
	WHERE RecipeId = @RecipeId

END;
GO
/****** Object:  StoredProcedure [dbo].[spRemoveUser]    Script Date: 26/11/2020 15:37:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spRemoveUser]
@UserId int 

AS
BEGIN
	DELETE FROM Users   
	WHERE UserId = @UserId

END;
GO
/****** Object:  StoredProcedure [dbo].[spSearchRecipe]    Script Date: 26/11/2020 15:37:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spSearchRecipe]
@search nvarchar(50)

AS 
BEGIN
	SELECT * FROM Recipes 
	WHERE Name LIKE @search + '%'
			 
END;
GO
/****** Object:  StoredProcedure [dbo].[spUpdateAccount]    Script Date: 26/11/2020 15:37:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spUpdateAccount]
@Username nvarchar(100),
@Password nvarchar(100),
@UserId int,
@AccountId int 

AS
BEGIN
	UPDATE Accounts  
		SET Username = @Username,
			[Password] = @Password,
			UserId = @UserId
		WHERE AccountId = @AccountId 

END;
GO
/****** Object:  StoredProcedure [dbo].[spUpdateCategory]    Script Date: 26/11/2020 15:37:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spUpdateCategory]
@CategoryName nvarchar(50),
@CategoryId int 

AS
BEGIN
	UPDATE Categories   
		SET CategoryName = @CategoryName 
		WHERE CategoryId = @CategoryId 

END;
GO
/****** Object:  StoredProcedure [dbo].[spUpdateComment]    Script Date: 26/11/2020 15:37:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spUpdateComment]
	@CommentContent nvarchar(500),
	@CommentDate date,
	@IsValidated bit,
	@RecipeId int,
	@UserId int,
	@CommentId int

AS
BEGIN
	UPDATE Comments    
		SET CommentContent = @CommentContent,
			CommentDate = @CommentDate,
			IsValidated = @IsValidated,
			RecipeId = @RecipeId,
			UserId = @UserId 
		WHERE CommentId = @CommentId 

END;
GO
/****** Object:  StoredProcedure [dbo].[spUpdateIngredient]    Script Date: 26/11/2020 15:37:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spUpdateIngredient]
@Name nvarchar(100),
@Quantity real,
@MeasurementUnit nvarchar(50),
@RecipeId int,
@IngredientId int 

AS
BEGIN
	UPDATE Ingredients  
		SET [Name] = @Name,
			Quantity = @Quantity,
			MeasurementUnit = @MeasurementUnit,
			RecipeId = @RecipeId 
		WHERE IngredientId = @IngredientId

END;
GO
/****** Object:  StoredProcedure [dbo].[spUpdateRecipe]    Script Date: 26/11/2020 15:37:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spUpdateRecipe]
@Name nvarchar(100),
@Rating tinyint,
@Difficulty tinyint,
@Description nvarchar(1000),
@CookingTime time(7),
@IsValidated bit,
@UserId int,
@CategoryId int,
@RecipeId int 

AS
BEGIN
	UPDATE Recipes  
		SET [Name] = @Name,
			Rating = @Rating,
			Difficulty = @Difficulty,
			[Description] = @Description,
			CookingTime = @CookingTime,
			IsValidated = @IsValidated,
			UserId = @UserId,
			CategoryId = @CategoryId 
		WHERE RecipeId = @RecipeId

END;
GO
/****** Object:  StoredProcedure [dbo].[spUpdateUser]    Script Date: 26/11/2020 15:37:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spUpdateUser]
	@FirstName nvarchar(50),
	@LastName nvarchar(50),
	@Country nvarchar(50),
	@Gender tinyint,
	@Email nvarchar(50),
	@BirthDate date,
	@IsAdministrator bit,
	@AccountId int,
	@UserId int

AS
BEGIN
	UPDATE Users   
		SET FirstName = @FirstName,
			LastName = @LastName,
			Country = @Country,
			Gender = @Gender,
			Email = @Email,
			BirthDate = @BirthDate,
			IsAdministrator = @IsAdministrator,
			AccountId = @AccountId 
		WHERE UserId = @UserId

END;
GO
USE [master]
GO
ALTER DATABASE [PedroFerreira_SiteRecipes] SET  READ_WRITE 
GO
