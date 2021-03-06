USE [master]
GO
/****** Object:  Database [Student_Management]    Script Date: 1/12/2022 16:11:50 ******/
CREATE DATABASE [Student_Management]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Student_Management', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Student_Management.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Student_Management_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Student_Management_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Student_Management] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Student_Management].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Student_Management] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Student_Management] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Student_Management] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Student_Management] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Student_Management] SET ARITHABORT OFF 
GO
ALTER DATABASE [Student_Management] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Student_Management] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Student_Management] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Student_Management] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Student_Management] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Student_Management] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Student_Management] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Student_Management] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Student_Management] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Student_Management] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Student_Management] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Student_Management] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Student_Management] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Student_Management] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Student_Management] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Student_Management] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Student_Management] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Student_Management] SET RECOVERY FULL 
GO
ALTER DATABASE [Student_Management] SET  MULTI_USER 
GO
ALTER DATABASE [Student_Management] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Student_Management] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Student_Management] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Student_Management] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Student_Management] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Student_Management] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'Student_Management', N'ON'
GO
ALTER DATABASE [Student_Management] SET QUERY_STORE = OFF
GO
USE [Student_Management]
GO
/****** Object:  Table [dbo].[Admin]    Script Date: 1/12/2022 16:11:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Admin](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Fname] [nvarchar](50) NULL,
	[Lname] [nvarchar](50) NULL,
	[Email] [nvarchar](max) NULL,
	[password] [nvarchar](max) NULL,
	[phone] [nvarchar](50) NULL,
	[active] [int] NULL,
	[usertype] [int] NULL,
 CONSTRAINT [PK_Admin] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Course_list]    Script Date: 1/12/2022 16:11:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Course_list](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NULL,
	[course_no] [int] NULL,
	[semester] [nvarchar](50) NULL,
	[year] [int] NULL,
	[description] [nvarchar](max) NULL,
	[capacity] [int] NULL,
	[active] [int] NULL,
 CONSTRAINT [PK_Course_list] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Student_Registration]    Script Date: 1/12/2022 16:11:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student_Registration](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Fname] [nvarchar](50) NULL,
	[Lname] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[password] [nvarchar](max) NULL,
	[phone] [nvarchar](50) NULL,
	[active] [int] NULL,
	[usertype] [int] NULL,
 CONSTRAINT [PK_Student_Registration] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Teacher_Registration]    Script Date: 1/12/2022 16:11:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Teacher_Registration](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Fname] [nvarchar](50) NULL,
	[Lname] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[password] [nvarchar](max) NULL,
	[phone] [nvarchar](50) NULL,
	[active] [int] NULL,
	[usertype] [int] NULL,
 CONSTRAINT [PK_Teacher_Registration] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[Admin] ADD  CONSTRAINT [DF_Admin_active]  DEFAULT ((1)) FOR [active]
GO
ALTER TABLE [dbo].[Admin] ADD  CONSTRAINT [DF_Admin_usertype]  DEFAULT ((1)) FOR [usertype]
GO
ALTER TABLE [dbo].[Course_list] ADD  CONSTRAINT [DF_Course_list_active]  DEFAULT ((1)) FOR [active]
GO
ALTER TABLE [dbo].[Student_Registration] ADD  CONSTRAINT [DF_Student_Registration_active]  DEFAULT ((1)) FOR [active]
GO
ALTER TABLE [dbo].[Student_Registration] ADD  CONSTRAINT [DF_Student_Registration_usertype]  DEFAULT ((3)) FOR [usertype]
GO
ALTER TABLE [dbo].[Teacher_Registration] ADD  CONSTRAINT [DF_Teacher_Registration_active]  DEFAULT ((1)) FOR [active]
GO
ALTER TABLE [dbo].[Teacher_Registration] ADD  CONSTRAINT [DF_Teacher_Registration_usertype]  DEFAULT ((2)) FOR [usertype]
GO
/****** Object:  StoredProcedure [dbo].[AdminViewByID]    Script Date: 1/12/2022 16:11:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AdminViewByID]
	-- Add the parameters for the stored procedure here
	 @id int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    SELECT * FROM Admin WHERE id= @id and active=1
END
GO
/****** Object:  StoredProcedure [dbo].[CourseViewByID]    Script Date: 1/12/2022 16:11:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CourseViewByID]
  @id int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    SELECT * FROM Course_list WHERE id= @id and active=1
END
GO
/****** Object:  StoredProcedure [dbo].[createadmin]    Script Date: 1/12/2022 16:11:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[createadmin]
	-- Add the parameters for the stored procedure here
	@Fname nvarchar(50),
	@Lname nvarchar(50),
	@Email nvarchar(max),
	@password nvarchar(MAX),
	@phone nvarchar(50)
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	insert into Admin(Fname, Lname, Email, password,phone) values (@Fname,@Lname,@Email,@password,@phone) 
	SELECT CAST(SCOPE_IDENTITY() as int)

END 
GO
/****** Object:  StoredProcedure [dbo].[createCourselist]    Script Date: 1/12/2022 16:11:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[createCourselist]
	-- Add the parameters for the stored procedure here
	@name nvarchar(50),
	@course_no int,
	@semester nvarchar(50),
	@year int,
	@description nvarchar(MAX),
	@capacity int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	insert into Course_list(name,course_no,semester, year, description, capacity) values (@name,@course_no,@semester,@year,@description,@capacity) 
	SELECT CAST(SCOPE_IDENTITY() as int)

END 
GO
/****** Object:  StoredProcedure [dbo].[createstudentslist]    Script Date: 1/12/2022 16:11:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[createstudentslist]
	-- Add the parameters for the stored procedure here
	@Fname nvarchar(50),
	@Lname nvarchar(50),
	@Email nvarchar(50),
	@password nvarchar(MAX),
	@phone nvarchar(50)
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	insert into Student_Registration(Fname, Lname, Email, password,phone) values (@Fname,@Lname,@Email,@password,@phone) 
	SELECT CAST(SCOPE_IDENTITY() as int)

END 
GO
/****** Object:  StoredProcedure [dbo].[createTeacherlist]    Script Date: 1/12/2022 16:11:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[createTeacherlist]
	-- Add the parameters for the stored procedure here
	@Fname nvarchar(50),
	@Lname nvarchar(50),
	@Email nvarchar(50),
	@password nvarchar(MAX),
	@phone nvarchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	insert into Teacher_Registration(Fname, Lname, Email, password,phone) values (@Fname,@Lname,@Email,@password,@phone) 
	SELECT CAST(SCOPE_IDENTITY() as int)

END 
GO
/****** Object:  StoredProcedure [dbo].[deleteCourse]    Script Date: 1/12/2022 16:11:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[deleteCourse]
	-- Add the parameters for the stored procedure here
	 @id int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	update Course_list 
	set active=0
	where id = @id
END
GO
/****** Object:  StoredProcedure [dbo].[deletestudent]    Script Date: 1/12/2022 16:11:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[deletestudent]
	-- Add the parameters for the stored procedure here
	 @id int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	
	update Student_Registration
	set active=0
	where id=@id
END
GO
/****** Object:  StoredProcedure [dbo].[deleteTeacher]    Script Date: 1/12/2022 16:11:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[deleteTeacher]
	-- Add the parameters for the stored procedure here
	 @id int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here

	update Teacher_Registration
	set active=0
	where id=@id
END
GO
/****** Object:  StoredProcedure [dbo].[getCourselist]    Script Date: 1/12/2022 16:11:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[getCourselist] 
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	select * from Course_list where active =1
END
GO
/****** Object:  StoredProcedure [dbo].[getstudentslist]    Script Date: 1/12/2022 16:11:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[getstudentslist] 
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	select * from Student_Registration where active=1
END
GO
/****** Object:  StoredProcedure [dbo].[getTeacherlist]    Script Date: 1/12/2022 16:11:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[getTeacherlist] 
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	select * from Teacher_Registration where active=1
END
GO
/****** Object:  StoredProcedure [dbo].[loginadmin]    Script Date: 1/12/2022 16:11:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[loginadmin] 
	-- Add the parameters for the stored procedure here
	@Email nvarchar(Max)
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	select id,password from Admin where Email=@Email and active=1
END
GO
/****** Object:  StoredProcedure [dbo].[loginstudent]    Script Date: 1/12/2022 16:11:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[loginstudent] 
	-- Add the parameters for the stored procedure here
	@Email nvarchar(50)
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	select id,password from Student_Registration where Email=@Email and active=1
END



GO
/****** Object:  StoredProcedure [dbo].[loginteacher]    Script Date: 1/12/2022 16:11:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[loginteacher]
	-- Add the parameters for the stored procedure here
	@Email nvarchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	select id,password from Teacher_Registration where Email=@Email and active=1
END
GO
/****** Object:  StoredProcedure [dbo].[StudentViewByID]    Script Date: 1/12/2022 16:11:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[StudentViewByID]
  @id int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    SELECT * FROM Student_Registration WHERE id= @id and active=1
END
GO
/****** Object:  StoredProcedure [dbo].[TeacherViewByID]    Script Date: 1/12/2022 16:11:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[TeacherViewByID]
  @id int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    SELECT * FROM Teacher_Registration WHERE id= @id and  active=1
END
GO
/****** Object:  StoredProcedure [dbo].[updateAdmin]    Script Date: 1/12/2022 16:11:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[updateAdmin]
	-- Add the parameters for the stored procedure here
	@id int,
	@Fname nvarchar(50),
	@Lname nvarchar(50),
	@phone nvarchar(50)

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	update Admin
	set Fname = @Fname, Lname = @Lname, phone = @phone
	where id=@id
END
GO
/****** Object:  StoredProcedure [dbo].[updateAdminPassword]    Script Date: 1/12/2022 16:11:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[updateAdminPassword] 
	-- Add the parameters for the stored procedure here
	@id int,
	@password nvarchar(MAX)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	update Admin
	set password=@password
	where id=@id
END
GO
/****** Object:  StoredProcedure [dbo].[updateCourse]    Script Date: 1/12/2022 16:11:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[updateCourse] 
	-- Add the parameters for the stored procedure here
	@id int,
	@name nvarchar(50),
	@course_no int
	

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	update Course_list
	set name = @name, course_no = @course_no
	where id=@id
END
GO
/****** Object:  StoredProcedure [dbo].[updateStudent]    Script Date: 1/12/2022 16:11:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[updateStudent] 
	-- Add the parameters for the stored procedure here
	@id int,
	@Fname nvarchar(50),
	@Lname nvarchar(50),
	@phone nvarchar(50)

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	update Student_Registration
	set Fname = @Fname, Lname = @Lname, phone = @phone
	where id=@id
END
GO
/****** Object:  StoredProcedure [dbo].[updateStudentPassword]    Script Date: 1/12/2022 16:11:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[updateStudentPassword] 
	-- Add the parameters for the stored procedure here
	@id int,
	@password nvarchar(MAX)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	update Student_Registration
	set password=@password
	where id=@id
END
GO
/****** Object:  StoredProcedure [dbo].[updateTeacher]    Script Date: 1/12/2022 16:11:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[updateTeacher] 
	-- Add the parameters for the stored procedure here
	@id int,
	@Fname nvarchar(50),
	@Lname nvarchar(50),
	
	@phone nvarchar(50)

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	update Teacher_Registration
	set Fname = @Fname, Lname = @Lname,phone = @phone
	where id=@id
END
GO
/****** Object:  StoredProcedure [dbo].[updateTeacherPassword]    Script Date: 1/12/2022 16:11:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[updateTeacherPassword]
	@id int,
	@password nvarchar(MAX)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	update Teacher_Registration
	set password=@password
	where id=@id
END
GO
USE [master]
GO
ALTER DATABASE [Student_Management] SET  READ_WRITE 
GO
