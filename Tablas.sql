
CREATE TABLE [dbo].[Persona](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombres] [varchar](100) NULL,
	[Apellidos] [varchar](100) NULL,
	[NumeroIdentificacion] [varchar](20) NULL,
	[Email] [varchar](100) NULL,
	[TipoIdentificacion] [varchar](50) NULL,
	[FechaCreacion] [datetime] NULL,
	[TipoNumIdentificacion]  AS ([TipoIdentificacion]+[NumeroIdentificacion]),
	[NombresApellidos]  AS (([Nombres]+' ')+[Apellidos]),
 CONSTRAINT [PK_Personas] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 22/12/2022 2:36:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Usuario] [varchar](50) NULL,
	[Password] [varchar](100) NULL,
	[FechaCreacion] [datetime] NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[usp_ConsultarUsuarios]    Script Date: 22/12/2022 2:36:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_ConsultarUsuarios]	
AS
BEGIN
	select [Nombres], [Apellidos], [NumeroIdentificacion], [Email], [TipoIdentificacion], [FechaCreacion], [TipoNumIdentificacion], [NombresApellidos]
	from [dbo].[Persona]
END
GO
USE [master]
GO
ALTER DATABASE [PruebaDoubleV] SET  READ_WRITE 
GO
