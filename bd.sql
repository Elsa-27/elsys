USE [bdlogin]
GO
/****** Object:  Table [dbo].[permisos]    Script Date: 7/06/2021 12:41:54 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[permisos](
	[idpermiso] [int] IDENTITY(1,1) NOT NULL,
	[usuario] [nvarchar](30) NOT NULL,
	[rol] [nvarchar](40) NOT NULL,
 CONSTRAINT [PK_permisos] PRIMARY KEY CLUSTERED 
(
	[idpermiso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[roles]    Script Date: 7/06/2021 12:41:54 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[roles](
	[idrol] [int] IDENTITY(1,1) NOT NULL,
	[nombrerol] [nvarchar](30) NOT NULL,
 CONSTRAINT [PK_roles] PRIMARY KEY CLUSTERED 
(
	[idrol] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[usuarios]    Script Date: 7/06/2021 12:41:54 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[usuarios](
	[IdUsuario] [int] IDENTITY(1,1) NOT NULL,
	[usuario] [nchar](20) NOT NULL,
	[pass] [varbinary](max) NOT NULL,
 CONSTRAINT [PK_usuarios] PRIMARY KEY CLUSTERED 
(
	[IdUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[usuariose]    Script Date: 7/06/2021 12:41:54 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[usuariose](
	[iduser] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nvarchar](60) NOT NULL,
	[telefono] [nvarchar](20) NOT NULL,
	[usuario] [nvarchar](30) NOT NULL,
	[pass] [varbinary](50) NOT NULL,
	[rol] [nvarchar](50) NOT NULL,
	[empresa] [nvarchar](30) NOT NULL,
 CONSTRAINT [PK_usuariose] PRIMARY KEY CLUSTERED 
(
	[iduser] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[permisos] ON 

INSERT [dbo].[permisos] ([idpermiso], [usuario], [rol]) VALUES (1, N'admin', N'Admin')
INSERT [dbo].[permisos] ([idpermiso], [usuario], [rol]) VALUES (2, N'julioram', N'Desarrollador')
INSERT [dbo].[permisos] ([idpermiso], [usuario], [rol]) VALUES (3, N'admin', N'Analista')
SET IDENTITY_INSERT [dbo].[permisos] OFF
GO
SET IDENTITY_INSERT [dbo].[roles] ON 

INSERT [dbo].[roles] ([idrol], [nombrerol]) VALUES (2, N'Admin')
INSERT [dbo].[roles] ([idrol], [nombrerol]) VALUES (3, N'Desarrollador')
INSERT [dbo].[roles] ([idrol], [nombrerol]) VALUES (4, N'Analista')
INSERT [dbo].[roles] ([idrol], [nombrerol]) VALUES (5, N'Colaborador')
INSERT [dbo].[roles] ([idrol], [nombrerol]) VALUES (6, N'Probador')
SET IDENTITY_INSERT [dbo].[roles] OFF
GO
SET IDENTITY_INSERT [dbo].[usuarios] ON 

INSERT [dbo].[usuarios] ([IdUsuario], [usuario], [pass]) VALUES (1, N'admin               ', 0x610064006D0069006E00310032003300340020002000200020002000200020002000200020002000)
INSERT [dbo].[usuarios] ([IdUsuario], [usuario], [pass]) VALUES (2, N'julioram            ', 0x6A0075006C0069006F00720061006D00320037002000200020002000200020002000200020002000)
INSERT [dbo].[usuarios] ([IdUsuario], [usuario], [pass]) VALUES (11, N'admin               ', 0x01004B3CE6AB75EB6E9C8AD019DA7774C1434A32D79AD6D4FD31)
INSERT [dbo].[usuarios] ([IdUsuario], [usuario], [pass]) VALUES (13, N'elsys               ', 0x0100C17934A0E11F8ACAC046AD8606DD80EF77FD7068EA01AEC5)
SET IDENTITY_INSERT [dbo].[usuarios] OFF
GO
SET IDENTITY_INSERT [dbo].[usuariose] ON 

INSERT [dbo].[usuariose] ([iduser], [nombre], [telefono], [usuario], [pass], [rol], [empresa]) VALUES (28, N'elsa ', N'elsa ', N'elsa ', 0x01009AF3D99B60BA27DC750765BC36B654AC9E71E2A5CFBA36C0, N'elsa ', N'elsa ')
INSERT [dbo].[usuariose] ([iduser], [nombre], [telefono], [usuario], [pass], [rol], [empresa]) VALUES (29, N'admin', N'admin', N'admin', 0x010052EFE55DA66367888FC1D12423A4089CFFF19C07923F8068, N'admin', N'admin')
INSERT [dbo].[usuariose] ([iduser], [nombre], [telefono], [usuario], [pass], [rol], [empresa]) VALUES (30, N'prueba', N'prueba', N'prueba', 0x010052F9432FF2CDEE455A79149812D58B883EBE1EC4B7B9405E, N'prueba', N'prueba')
SET IDENTITY_INSERT [dbo].[usuariose] OFF
GO
/****** Object:  StoredProcedure [dbo].[IngresarUsuario]    Script Date: 7/06/2021 12:41:55 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

  Create Procedure [dbo].[IngresarUsuario]
  @usuario nvarchar(50), 
  @pass nvarchar(50)
As
Begin
    Insert Into Login
    (
        usuario,
        pass
    )
    Values
    (
        @usuario,
        ENCRYPTBYPASSPHRASE('pass', @pass)
    )
End
GO
/****** Object:  StoredProcedure [dbo].[sp_insert_usuarios]    Script Date: 7/06/2021 12:41:55 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_insert_usuarios]
  @users varchar(max),
  @pss varchar(max)
  as
  begin
  insert into usuarios values(@users, @pss)
  end
GO
