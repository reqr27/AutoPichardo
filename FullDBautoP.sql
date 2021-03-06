USE [master]
GO
/****** Object:  Database [CarsImport]    Script Date: 7/5/2018 3:44:57 p. m. ******/
CREATE DATABASE [CarsImport]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'CarsImport', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\CarsImport.mdf' , SIZE = 10176KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'CarsImport_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\CarsImport_log.ldf' , SIZE = 2816KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [CarsImport] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [CarsImport].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [CarsImport] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [CarsImport] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [CarsImport] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [CarsImport] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [CarsImport] SET ARITHABORT OFF 
GO
ALTER DATABASE [CarsImport] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [CarsImport] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [CarsImport] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [CarsImport] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [CarsImport] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [CarsImport] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [CarsImport] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [CarsImport] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [CarsImport] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [CarsImport] SET  DISABLE_BROKER 
GO
ALTER DATABASE [CarsImport] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [CarsImport] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [CarsImport] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [CarsImport] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [CarsImport] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [CarsImport] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [CarsImport] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [CarsImport] SET RECOVERY FULL 
GO
ALTER DATABASE [CarsImport] SET  MULTI_USER 
GO
ALTER DATABASE [CarsImport] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [CarsImport] SET DB_CHAINING OFF 
GO
ALTER DATABASE [CarsImport] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [CarsImport] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [CarsImport] SET DELAYED_DURABILITY = DISABLED 
GO
USE [CarsImport]
GO
/****** Object:  Table [dbo].[Ciudades]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Ciudades](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idPais] [int] NULL,
	[ciudad] [varchar](100) NULL,
	[estado] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Clientes](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[cliente] [varchar](200) NOT NULL,
	[rnc_cedula] [varchar](50) NOT NULL,
	[direccion] [varchar](200) NULL,
	[telefono] [varchar](50) NOT NULL,
	[estado] [bit] NOT NULL,
	[id_pais] [int] NULL,
	[id_ciudad] [int] NULL,
 CONSTRAINT [PK_Clientes] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Colores]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Colores](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[color] [varchar](100) NULL,
	[estado] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Componentes]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Componentes](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[fabricante_id] [int] NOT NULL,
	[modelo_id] [int] NOT NULL,
	[año] [varchar](50) NOT NULL,
	[componente] [varchar](200) NOT NULL,
	[precio_rd] [decimal](18, 2) NOT NULL,
	[precio_usd] [decimal](18, 2) NOT NULL,
	[estado] [bit] NOT NULL,
 CONSTRAINT [PK_Componentes] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CuentasCobrar]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CuentasCobrar](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_vehiculo] [int] NULL,
	[id_factura] [int] NULL,
	[id_cliente] [int] NULL,
	[id_transaccion] [int] NULL,
	[monto_rd] [decimal](18, 2) NULL,
	[monto_usd] [decimal](18, 2) NULL,
	[balance_rd] [decimal](18, 2) NULL,
	[balance_usd] [decimal](18, 2) NULL,
	[fecha] [date] NULL,
	[nueva] [bit] NOT NULL,
	[nota] [varchar](300) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CuentasPagar]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CuentasPagar](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_vehiculo] [int] NULL,
	[id_factura] [int] NULL,
	[id_vendedor] [int] NULL,
	[id_transaccion] [int] NULL,
	[id_gasto] [int] NULL DEFAULT ((0)),
	[monto_rd] [decimal](18, 2) NULL,
	[monto_usd] [decimal](18, 2) NULL,
	[balance_rd] [decimal](18, 2) NULL,
	[balance_usd] [decimal](18, 2) NULL,
	[fecha] [date] NULL,
	[nueva] [bit] NOT NULL DEFAULT ((1)),
	[nota] [varchar](300) NOT NULL DEFAULT (''),
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Detalle_CC_CP_Antiguas]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Detalle_CC_CP_Antiguas](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_cuenta] [int] NULL,
	[id_fabricante] [int] NULL,
	[id_modelo] [int] NULL,
	[color] [varchar](50) NULL,
	[año] [int] NULL,
	[chasis] [varchar](50) NULL,
	[id_seguro] [int] NULL,
	[dias_seguro] [int] NULL,
	[id_tipo_cuenta] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DetalleComponentes]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetalleComponentes](
	[idVehiculo] [int] NOT NULL,
	[idComponente] [int] NOT NULL,
	[precioRD] [float] NOT NULL,
	[precioUSD] [float] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DetalleGastosAduanales]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetalleGastosAduanales](
	[idVehiculo] [int] NOT NULL,
	[idGastoAduanal] [int] NOT NULL,
	[precioRD] [decimal](18, 2) NOT NULL,
	[precioUSD] [decimal](18, 2) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DetallePagosComprasVehiculoCredito]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DetallePagosComprasVehiculoCredito](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idVehiculo] [int] NULL,
	[montoRD] [decimal](18, 2) NULL,
	[montoUSD] [decimal](18, 2) NULL,
	[fechaPago] [date] NULL,
	[detalles] [varchar](100) NULL,
	[idTipoPago] [int] NULL,
	[pendienteRD] [decimal](18, 2) NULL,
	[pendienteUSD] [decimal](18, 2) NULL,
 CONSTRAINT [PK_DetallePagosComprasVehiculoCredito] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DetallePagosVentasVehiculoCredito]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DetallePagosVentasVehiculoCredito](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idVehiculo] [int] NULL,
	[montoRD] [decimal](18, 2) NULL,
	[montoUSD] [decimal](18, 2) NULL,
	[fechaPago] [date] NULL,
	[detalles] [varchar](100) NULL,
	[idTipoPago] [int] NULL,
	[pendienteRD] [decimal](18, 2) NULL,
	[pendienteUSD] [decimal](18, 2) NULL,
 CONSTRAINT [PK_DetallePagosVentasVehiculoCredito] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DetallesEfectivoGeneral]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DetallesEfectivoGeneral](
	[idVehiculo] [int] NULL,
	[tipoCuenta] [int] NULL,
	[montoRD] [decimal](18, 2) NULL,
	[montoUSD] [decimal](18, 2) NULL,
	[fecha] [date] NULL,
	[documento] [varchar](50) NULL,
	[numeroDocumento] [int] NULL,
	[id_transaccion] [int] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DetallesGastosReparaciones]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetallesGastosReparaciones](
	[idVehiculo] [int] NOT NULL,
	[idMantenimiento] [int] NOT NULL,
	[idTaller] [int] NOT NULL,
	[precioRD] [float] NOT NULL,
	[precioUSD] [float] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Fabricantes]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Fabricantes](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[codigo] [varchar](50) NOT NULL,
	[fabricante] [varchar](50) NOT NULL,
	[estado] [bit] NOT NULL CONSTRAINT [DF_Fabricantes_estado]  DEFAULT ((1)),
 CONSTRAINT [PK_Fabricantes] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[facturas]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[facturas](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idVehiculo] [int] NOT NULL,
	[id_cliente] [int] NULL,
	[fecha] [date] NULL,
	[nota_venta] [varchar](300) NULL,
 CONSTRAINT [PK_facturas] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[FacturasServicios]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[FacturasServicios](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[fecha] [date] NULL,
	[id_vehiculo] [int] NULL,
	[id_suplidor] [int] NULL,
	[monto_rd] [decimal](18, 2) NULL,
	[monto_usd] [decimal](18, 2) NULL,
	[facturaSuplidor] [varchar](50) NULL,
	[nota] [varchar](300) NULL,
 CONSTRAINT [PK_FacturasServicios] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[FormaCompraVehiculo]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[FormaCompraVehiculo](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_vehiculo] [int] NULL,
	[id_transaccion] [int] NULL,
	[id_tipo_pago] [int] NULL,
	[id_factura] [int] NULL,
	[monto_rd] [decimal](18, 2) NULL,
	[monto_usd] [decimal](18, 2) NULL,
	[nota] [varchar](100) NULL,
	[fecha] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[FormaVentaVehiculo]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[FormaVentaVehiculo](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_vehiculo] [int] NULL,
	[id_transaccion] [int] NULL,
	[id_tipo_pago] [int] NULL,
	[id_factura] [int] NULL,
	[monto_rd] [decimal](18, 2) NULL,
	[monto_usd] [decimal](18, 2) NULL,
	[nota] [varchar](100) NULL,
	[fecha] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Gastos]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Gastos](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](250) NOT NULL,
	[tipo] [varchar](50) NOT NULL,
	[estado] [bit] NOT NULL,
 CONSTRAINT [PK_Mantenimientos] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[GastoVehiculo]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GastoVehiculo](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_factura_servicio] [int] NULL,
	[id_vehiculo] [int] NULL,
	[id_gasto] [int] NULL,
	[id_proveedor] [int] NULL,
	[id_transaccion] [int] NULL,
	[monto_rd] [decimal](18, 2) NULL,
	[monto_usd] [decimal](18, 2) NULL,
	[fecha] [date] NULL,
	[cantidad] [int] NULL,
 CONSTRAINT [PK__GastoVeh__3213E83F50449BF3] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HistorialUbicaciones]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HistorialUbicaciones](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_vehiculo] [int] NULL,
	[id_ubicacion] [int] NULL,
	[fecha] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ImagenesClientes]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ImagenesClientes](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idCliente] [int] NULL,
	[img] [varbinary](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ImagenesTraspasos]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ImagenesTraspasos](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_factura] [int] NULL,
	[id_vehiculo] [int] NULL,
	[img] [varbinary](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Modelos]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Modelos](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[noUso] [int] NULL,
	[fabricante_id] [int] NOT NULL,
	[codigo] [varchar](50) NOT NULL,
	[modelo] [varchar](50) NOT NULL,
	[estado] [bit] NOT NULL CONSTRAINT [DF_Modelos_estado]  DEFAULT ((1)),
 CONSTRAINT [PK_Modelos] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PagosCuentasCobrar]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PagosCuentasCobrar](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_cuentaCobrar] [int] NULL,
	[id_tipoPago] [int] NULL,
	[monto_rd] [decimal](18, 2) NULL,
	[monto_usd] [decimal](18, 2) NULL,
	[fecha] [date] NULL,
	[nota] [varchar](100) NULL,
	[balance_rd] [decimal](18, 2) NULL,
	[balance_usd] [decimal](18, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PagosCuentasPagar]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PagosCuentasPagar](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_cuentaPagar] [int] NULL,
	[id_tipoPago] [int] NULL,
	[monto_rd] [decimal](18, 2) NULL,
	[monto_usd] [decimal](18, 2) NULL,
	[fecha] [date] NULL,
	[nota] [varchar](100) NULL,
	[balance_rd] [decimal](18, 2) NULL,
	[balance_usd] [decimal](18, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Paises]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Paises](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[pais] [varchar](100) NULL,
	[estado] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PreciosSeguroVehiculo]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PreciosSeguroVehiculo](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_vehiculo] [int] NULL,
	[precioRD] [decimal](18, 2) NULL,
	[precioUSD] [decimal](18, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PreciosTraspasoVehiculo]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PreciosTraspasoVehiculo](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_vehiculo] [int] NULL,
	[precioRD] [decimal](18, 2) NULL,
	[precioUSD] [decimal](18, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Propietarios]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Propietarios](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[telefono] [varchar](50) NULL,
	[estado] [bit] NOT NULL,
	[direccion] [varchar](200) NULL,
	[rncCedula] [varchar](50) NULL,
 CONSTRAINT [PK_Propietarios] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Seguros]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Seguros](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](100) NULL,
	[telefono] [varchar](30) NULL,
	[estado] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SeguroVehiculo]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SeguroVehiculo](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_vehiculo] [int] NULL,
	[id_seguro] [int] NULL,
	[duracion_dias] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SerialKeyActivation]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SerialKeyActivation](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[fechaActivacion] [date] NULL,
	[fechaVencimiento] [date] NULL,
 CONSTRAINT [PK_SerialKeyActivation] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Settings]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Settings](
	[activado] [bit] NULL,
	[primeraCorrida] [bit] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Suplidores]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Suplidores](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[suplidor] [varchar](100) NULL,
	[rnc_cedula] [varchar](100) NULL,
	[id_pais] [int] NULL,
	[id_ciudad] [int] NULL,
	[direccion] [varchar](100) NULL,
	[telefono] [varchar](100) NULL,
	[estado] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TalleresRepuestos]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TalleresRepuestos](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[taller] [varchar](100) NOT NULL,
	[direccion] [varchar](200) NOT NULL,
	[telefono1] [varchar](50) NULL,
	[telefono2] [varchar](50) NULL,
	[estado] [bit] NOT NULL,
 CONSTRAINT [PK_TalleresRepuestos] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TasaDolar]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TasaDolar](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[tasaDolar] [float] NULL,
	[fechaActualizado] [date] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TipoFormaCobroVentaVehiculo]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TipoFormaCobroVentaVehiculo](
	[id_vehiculo] [int] NOT NULL,
	[id_tipo_pago] [int] NULL,
	[pago_usd] [decimal](18, 2) NOT NULL,
	[pago_rd] [decimal](18, 2) NOT NULL,
	[fecha_pago] [date] NOT NULL,
	[detalles] [varchar](100) NULL,
	[balanceRD] [decimal](18, 2) NULL,
	[balanceUSD] [decimal](18, 2) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TipoFormaPagoCompraVehiculo]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TipoFormaPagoCompraVehiculo](
	[idVehiculo] [int] NULL,
	[idTipoPago] [int] NULL,
	[montoRD] [decimal](18, 2) NULL,
	[montoUSD] [decimal](18, 2) NULL,
	[detalles] [varchar](100) NULL,
	[balanceRD] [decimal](18, 2) NULL,
	[balanceUSD] [decimal](18, 2) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TiposCuenta]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TiposCuenta](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[tipoCuenta] [varchar](50) NULL,
 CONSTRAINT [PK_TiposCuenta] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TiposGastos]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TiposGastos](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[gasto] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TiposPago]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TiposPago](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[formaPago] [varchar](50) NULL,
 CONSTRAINT [PK_TiposPago] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TipoTransaccion]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TipoTransaccion](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[transaccion] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Ubicaciones]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Ubicaciones](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_pais] [int] NULL,
	[id_ciudad] [int] NULL,
	[ubicacion] [varchar](100) NULL,
	[estado] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Usuarios](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[usuario] [varchar](50) NULL,
	[clave] [varchar](50) NULL,
	[nombreApellido] [varchar](50) NULL,
	[tasaDolar] [bit] NULL CONSTRAINT [DF_Usuarios_tasaDolar]  DEFAULT ((0)),
	[crearUsuarios] [bit] NULL CONSTRAINT [DF_Usuarios_crearUsuarios]  DEFAULT ((0)),
	[fabricantesModelos] [bit] NULL CONSTRAINT [DF_Usuarios_fabricantesModelos]  DEFAULT ((0)),
	[piezasRepuestos] [bit] NULL CONSTRAINT [DF_Usuarios_piezasRepuestos]  DEFAULT ((0)),
	[crearTaller] [bit] NULL CONSTRAINT [DF_Usuarios_crearTaller]  DEFAULT ((0)),
	[crearPropietarios] [bit] NULL CONSTRAINT [DF_Usuarios_crearPropietarios]  DEFAULT ((0)),
	[crearClientes] [bit] NULL CONSTRAINT [DF_Usuarios_crearClientes]  DEFAULT ((0)),
	[crearGastos] [bit] NULL CONSTRAINT [DF_Usuarios_crearGastos]  DEFAULT ((0)),
	[importarVehiculo] [bit] NULL CONSTRAINT [DF_Usuarios_importarVehiculo]  DEFAULT ((0)),
	[compras] [bit] NULL CONSTRAINT [DF_Usuarios_deshabilitar]  DEFAULT ((0)),
	[cambiarEstadosVehiculo] [bit] NULL CONSTRAINT [DF_Usuarios_cambiarEstadosVehiculo]  DEFAULT ((0)),
	[agreagarGastos] [bit] NULL CONSTRAINT [DF_Usuarios_agreagarGastos]  DEFAULT ((0)),
	[agregarPiezas] [bit] NULL CONSTRAINT [DF_Usuarios_agregarPiezas]  DEFAULT ((0)),
	[facturacion] [bit] NULL CONSTRAINT [DF_Usuarios_verHacerPagos]  DEFAULT ((0)),
	[reportes] [bit] NULL CONSTRAINT [DF_Usuarios_reportes]  DEFAULT ((0)),
	[estadoUsuario] [bit] NULL CONSTRAINT [DF_Usuarios_estadoUsuario]  DEFAULT ((1)),
	[modificarVehiculo] [bit] NULL,
	[cuentasCobrar] [bit] NULL,
	[cuentasPagar] [bit] NULL,
	[actualizarDiarioTasa] [bit] NULL,
	[agregar_paises] [bit] NOT NULL DEFAULT ((1)),
	[agregar_ciudades] [bit] NOT NULL DEFAULT ((1)),
	[agregar_colores] [bit] NOT NULL DEFAULT ((1)),
	[agregar_ubicaciones] [bit] NOT NULL DEFAULT ((1)),
	[agregar_suplidores] [bit] NOT NULL DEFAULT ((1)),
	[agregar_seguros] [bit] NOT NULL DEFAULT ((1)),
	[AgregarCCCP] [bit] NOT NULL DEFAULT ((1)),
 CONSTRAINT [PK_Usuarios] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Vehiculos]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Vehiculos](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[fabricante_id] [int] NOT NULL,
	[modelo_id] [int] NOT NULL,
	[año] [int] NOT NULL,
	[color] [varchar](50) NULL,
	[precioUSD] [decimal](18, 2) NOT NULL,
	[precioRD] [decimal](18, 2) NOT NULL,
	[id_cliente] [int] NULL,
	[id_propietario] [int] NOT NULL,
	[terminado] [bit] NOT NULL,
	[vendido] [bit] NOT NULL,
	[pagado] [bit] NOT NULL,
	[fecha_importe] [date] NOT NULL,
	[fecha_terminado] [date] NULL,
	[fecha_vendido] [date] NULL,
	[vin] [varchar](50) NOT NULL,
	[nota] [varchar](250) NULL,
	[estado] [bit] NOT NULL,
	[total_invertido_rd] [decimal](18, 2) NOT NULL,
	[total_invertido_usd] [decimal](18, 2) NOT NULL,
	[matricula] [bit] NULL,
	[cedula_vendedor] [bit] NULL,
	[acto_venta] [bit] NULL,
	[precioVentaRD] [decimal](18, 2) NULL,
	[precioVentaUSD] [decimal](18, 2) NULL,
	[id_suplidor] [int] NULL,
	[id_ubicacion] [int] NULL,
	[precio_estimado_rd] [decimal](18, 2) NULL,
	[precio_estimado_usd] [decimal](18, 2) NULL,
	[placa] [varchar](30) NULL,
	[numero_matricula] [varchar](100) NULL,
	[millaje] [varchar](100) NULL,
	[fuerza_motriz] [varchar](30) NULL,
 CONSTRAINT [PK_Vehiculos] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[CuentasCobrar] ADD  DEFAULT ((1)) FOR [nueva]
GO
ALTER TABLE [dbo].[CuentasCobrar] ADD  DEFAULT ('') FOR [nota]
GO
ALTER TABLE [dbo].[Settings] ADD  CONSTRAINT [DF_Settings_activado]  DEFAULT ((0)) FOR [activado]
GO
ALTER TABLE [dbo].[Settings] ADD  CONSTRAINT [DF_Settings_primeraCorrida]  DEFAULT ((0)) FOR [primeraCorrida]
GO
/****** Object:  StoredProcedure [dbo].[activar_software]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[activar_software]
@mensaje int output
as
set @mensaje = 0;
declare @fechaActivacion date = (select getdate())
declare @fechaVencimiento date = (select DATEADD(DAY, 30, getdate()))
begin
  update SerialKeyActivation set fechaActivacion = @fechaActivacion, fechaVencimiento = @fechaVencimiento
  where id = 1
  set @mensaje = 1;
	
end



GO
/****** Object:  StoredProcedure [dbo].[actualizar_ciudad]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

	create procedure [dbo].[actualizar_ciudad]
	@idCiudad int, @idPais int, @ciudad varchar(100), @estado bit, @mensaje int output
	as
	set @mensaje = 0
	begin
		Update Ciudades set ciudad = @ciudad, estado = @estado, idPais = @idPais where id = @idCiudad
		set @mensaje = 1
	end



GO
/****** Object:  StoredProcedure [dbo].[actualizar_cliente]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[actualizar_cliente]
@idCliente int,@cliente varchar(200), @cedulaRNC varchar(50), @tel varchar(50), @estado bit, @mensaje int output,
@direccion varchar(200), @idPais int, @idCiudad int
as
set @mensaje = 0

begin

	
	update Clientes set cliente = @cliente, rnc_cedula = @cedulaRNC, telefono = @tel, estado = @estado, 
	direccion = @direccion, id_pais = @idPais, id_ciudad = @idCiudad
	where id = @idCliente
	set @mensaje = 1

end




GO
/****** Object:  StoredProcedure [dbo].[actualizar_color]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
	

	create procedure [dbo].[actualizar_color]
	@idColor int, @color varchar(100), @estadoColor bit, @mensaje int output
	as
	set @mensaje = 0
	begin
		Update Colores set color = @color, estado = @estadoColor where id = @idColor
		set @mensaje = 1
	end



GO
/****** Object:  StoredProcedure [dbo].[actualizar_componentes]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[actualizar_componentes]
@id int, @componente varchar(200), @precioUsd decimal, 
@precioRd decimal, @estado bit, @mensaje int output
as
set @mensaje = 0

begin

	
		update Componentes set componente = @componente, precio_rd = @precioRd, precio_usd = @precioUsd, estado = @estado
		where id = @id
		set @mensaje = 1

		
end






GO
/****** Object:  StoredProcedure [dbo].[actualizar_fabricante]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[actualizar_fabricante]
@idFabricante int ,@fabricante varchar(50), @codigo varchar(50), @estado bit, @mensaje int output
as
set @mensaje = 0
begin
	update Fabricantes
	set fabricante = @fabricante, codigo = @codigo, estado = @estado
	where id = @idFabricante
	set @mensaje = 1
end






GO
/****** Object:  StoredProcedure [dbo].[actualizar_gasto]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[actualizar_gasto]
@idGasto int,@descripcion varchar(250),@tipo varchar(50), @estado bit, @mensaje int output
as
set @mensaje = 0

begin

	
			update Gastos set descripcion = @descripcion, tipo = @tipo, estado = @estado
			where id = @idGasto
			set @mensaje = 1

	
end






GO
/****** Object:  StoredProcedure [dbo].[actualizar_imagenes_clientes]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[actualizar_imagenes_clientes]
@img varbinary(max), @mensaje int output, @idCliente int
as
set @mensaje = 0;

begin
	insert into ImagenesClientes(idCliente,img)
	Values (@idCliente, @img)
	set @mensaje = 1;
	
end



GO
/****** Object:  StoredProcedure [dbo].[actualizar_modelo]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[actualizar_modelo]
@idModelo int ,@modelo varchar(50), @codigo varchar(50), @estado bit,@mensaje int output
as
set @mensaje = 0
begin
	update Modelos 
	set modelo = @modelo, codigo = @codigo, estado = @estado
	where id = @idModelo
	set @mensaje = 1
end






GO
/****** Object:  StoredProcedure [dbo].[actualizar_pais]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

	create procedure [dbo].[actualizar_pais]
	@idPais int, @pais varchar(100), @estadoPais bit, @mensaje int output
	as
	set @mensaje = 0
	begin
		Update Paises set pais = @pais, estado = @estadoPais where id = @idPais
		set @mensaje = 1
	end



GO
/****** Object:  StoredProcedure [dbo].[actualizar_propietario]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[actualizar_propietario]
@idPropietario int, @propietario varchar(50), @tel varchar(50), @estado bit, @mensaje int output, @direccion varchar(200),
@rncCedula varchar(50)
as
set @mensaje = 0

begin

	
	update Propietarios set nombre = @propietario, telefono = @tel, estado = @estado, direccion = @direccion, rncCedula = @rncCedula
	where id = @idPropietario
	set @mensaje = 1

end






GO
/****** Object:  StoredProcedure [dbo].[actualizar_seguro]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

	create procedure [dbo].[actualizar_seguro]
	@idSeguro int, @nombre varchar(100),@telefono varchar(50) ,@estado bit, @mensaje int output
	as
	set @mensaje = 0
	begin
		Update Seguros set nombre = @nombre,telefono = @telefono ,estado = @estado where id = @idSeguro
		set @mensaje = 1
	end



GO
/****** Object:  StoredProcedure [dbo].[actualizar_suplidor]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

	create procedure [dbo].[actualizar_suplidor]
	@idSuplidor int, @suplidor varchar(100), @rnc_cedula varchar(100), @idPais int, @idCiudad int , @direccion varchar(100),
	@telefono varchar(100) ,@estado bit, @mensaje int output
	as
	set @mensaje = 0;
	begin
		Update Suplidores set suplidor = @suplidor, rnc_cedula = @rnc_cedula, id_pais = @idPais, 
		id_ciudad = @idCiudad, direccion = @direccion, telefono = @telefono, estado = @estado
		where id = @idSuplidor
		set @mensaje = 1;
	
	end




GO
/****** Object:  StoredProcedure [dbo].[actualizar_talleres]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[actualizar_talleres]
@idTaller int, @taller varchar(100), @direccion varchar(200),@tel1 varchar(50), @tel2 varchar(50),@estado bit, @mensaje int output
as
set @mensaje = 0

begin

	
	update TalleresRepuestos set taller = @taller, direccion = @direccion, telefono1 = @tel1, telefono2 = @tel2, estado = @estado
	where id = @idTaller
	
	set @mensaje = 1
	
end






GO
/****** Object:  StoredProcedure [dbo].[actualizar_tasa_dolar]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[actualizar_tasa_dolar]
@tasaDolar float, @mensaje bit output
as
set @mensaje = 0;
begin

	update TasaDolar set tasaDolar = @tasaDolar, fechaActualizado = GETDATE() where id = 1
	set @mensaje = 1

end



GO
/****** Object:  StoredProcedure [dbo].[actualizar_ubicacion]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
	

	create procedure [dbo].[actualizar_ubicacion]
	@idUbicacion int, @ubicacion varchar(100), @estadoUbicacion bit, @mensaje int output, @idPais int,
	@idCiudad int
	as
	set @mensaje = 0
	begin
		Update Ubicaciones set ubicacion = @ubicacion, estado = @estadoUbicacion,
		id_pais = @idPais, id_ciudad = @idCiudad 
		where id = @idUbicacion
		set @mensaje = 1
	end



GO
/****** Object:  StoredProcedure [dbo].[actualizar_usuarios]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[actualizar_usuarios]
@usuario varchar(50), @nombre varchar(50), @clave varchar(50), @tasaDolar bit, @crearUsuarios bit,
@fabricantesModelos bit, @piezasRepuestos bit, @crearTaller bit, @crearPropietarios bit, @crearClientes bit, 
@crearGastos bit, @importarVehiculos bit, @compras bit, @cambiarEstadosVehiculos bit, @agregarGastos bit,
@agregarPiezas bit, @facturacion bit, @reportes bit, @estado bit, @mensaje int output, @idUsuario int,
@modificarVehiculo bit, @cuentasPagar bit, @cuentasCobrar bit, @actualizarTasaDiario bit, @crearPais bit, @crearCiudad bit, @crearSuplidor bit,
@crearColor bit, @crearUbicacion bit, @crearSeguros bit, @agregarCuentasAntiguas bit
as
set @mensaje = 0

begin

	if not exists(select * from Usuarios where usuario = @usuario and id != @idUsuario)
		begin
			update Usuarios set usuario = @usuario, clave = @clave, nombreApellido = @nombre, tasaDolar = @tasaDolar, 
			crearUsuarios = @crearUsuarios, fabricantesModelos = @fabricantesModelos, piezasRepuestos = @piezasRepuestos, 
			crearTaller = @crearTaller, crearPropietarios = @crearPropietarios, crearClientes = @crearClientes, 
			crearGastos = @crearGastos, importarVehiculo = @importarVehiculos, compras = @compras, 
			cambiarEstadosVehiculo = @cambiarEstadosVehiculos, agreagarGastos = @agregarGastos, agregarPiezas = @agregarPiezas, 
			facturacion = @facturacion, reportes = @reportes, estadoUsuario = @estado, modificarVehiculo = @modificarVehiculo,
			cuentasCobrar = @cuentasCobrar, cuentasPagar = @cuentasPagar, actualizarDiarioTasa = @actualizarTasaDiario,
			agregar_paises = @crearPais, agregar_ciudades = @crearCiudad, agregar_suplidores = @crearSuplidor,
			agregar_colores = @crearColor, agregar_ubicaciones = @crearUbicacion, agregar_seguros = @crearSeguros,
			AgregarCCCP = @agregarCuentasAntiguas
			
			where id = @idUsuario
			set @mensaje = 1

		end

	else
		begin 
			set @mensaje = 2
		end
end



GO
/****** Object:  StoredProcedure [dbo].[actualizar_vehiculo]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[actualizar_vehiculo]
@idVehiculo int,@vin varchar(50), @idPropietario int,
@nota varchar(250), @mensaje int output, @color varchar(50),
@idUbicacion varchar(50),
@matriculaOriginal bit, @cedulaVendedor bit, @actoVenta bit,
@rdPrecioVentaEstimado float,
@usdPrecioVentaEstimado float, @placa varchar(30), @numeroMatricula varchar(100), @millaje varchar(100),
@fuerzaMotriz varchar(30), @idSuplidor int, @año int, @fecha date
as
set @mensaje = 0

begin

    update Vehiculos set 
	id_propietario = @idPropietario, vin = @vin, nota = @nota,
	color = @color,id_ubicacion = @idUbicacion, 
    matricula =	@matriculaOriginal, acto_venta = @actoVenta, cedula_vendedor =  @cedulaVendedor,
	precio_estimado_rd = @rdPrecioVentaEstimado, precio_estimado_usd = @usdPrecioVentaEstimado, 
	placa = @placa, numero_matricula = @numeroMatricula,
	millaje = @millaje, fuerza_motriz = @fuerzaMotriz, id_suplidor = @idSuplidor, año = @año
	where id = @idVehiculo
	
	declare @ultimaUbicacion int= (SELECT TOP 1 id_ubicacion FROM HistorialUbicaciones where id_vehiculo = @idVehiculo ORDER BY ID DESC)
	if @ultimaUbicacion != @idUbicacion
		begin
			insert into HistorialUbicaciones(id_vehiculo,id_ubicacion, fecha) 
			Values (@idVehiculo, @idUbicacion, @fecha)
		end
	set @mensaje = 1
end




GO
/****** Object:  StoredProcedure [dbo].[asignar_componente_vehiculo]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[asignar_componente_vehiculo]
@idVehiculo int, @idComponente int,@precioRD float, @precioUSD float ,@mensaje int output
as
set @mensaje = 0
begin
	if not exists(select * from DetalleComponentes where idVehiculo = @idVehiculo and idComponente = @idComponente)
		begin
			insert into DetalleComponentes(idVehiculo, idComponente, precioRD, precioUSD)
			VALUES (@idVehiculo, @idComponente, @precioRD, @precioUSD)
			
			update Vehiculos set total_invertido_rd = total_invertido_rd + @precioRD, total_invertido_usd = total_invertido_usd + @precioUSD
			where id = @idVehiculo
			set @mensaje = 1
		end

	else
		begin
			set @mensaje = 2
		end
end






GO
/****** Object:  StoredProcedure [dbo].[asignar_gasto_aduanal_vehiculo]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[asignar_gasto_aduanal_vehiculo]
@idVehiculo int, @idGasto int,@precioRD decimal, @precioUSD decimal , @mensaje int output
as
set @mensaje = 0
begin
	if not exists(select * from DetalleGastosAduanales where idVehiculo = @idVehiculo and idGastoAduanal = @idGasto)
		begin
			insert into DetalleGastosAduanales(idVehiculo, idGastoAduanal, precioRD, precioUSD)
			VALUES (@idVehiculo, @idGasto, @precioRD, @precioUSD)

			update Vehiculos set total_invertido_rd = total_invertido_rd + @precioRD, total_invertido_usd = total_invertido_usd + @precioUSD
			where id = @idVehiculo
			set @mensaje = 1
		end

	else
		begin
			set @mensaje = 2
		end
end






GO
/****** Object:  StoredProcedure [dbo].[asignar_gasto_reparacion_vehiculo]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[asignar_gasto_reparacion_vehiculo]
@idVehiculo int, @idGasto int,@precioRD decimal, @precioUSD decimal ,@idTaller int, @mensaje int output
as
set @mensaje = 0
begin
	if not exists(select * from DetallesGastosReparaciones where idVehiculo = @idVehiculo and idMantenimiento = @idGasto)
		begin
			insert into DetallesGastosReparaciones(idVehiculo, idMantenimiento, precioRD, precioUSD, idTaller)
			VALUES (@idVehiculo, @idGasto, @precioRD, @precioUSD, @idTaller)

			update Vehiculos set total_invertido_rd = total_invertido_rd + @precioRD, total_invertido_usd = total_invertido_usd + @precioUSD
			where id = @idVehiculo
			set @mensaje = 1
		end

	else
		begin
			set @mensaje = 2
		end
end






GO
/****** Object:  StoredProcedure [dbo].[borrar_compra_y_detalles_pagos]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE Procedure [dbo].[borrar_compra_y_detalles_pagos]
as

begin

	declare @idVehiculo int = (Select MAX(id) from Vehiculos)
	Delete from Vehiculos where id = @idVehiculo
	Delete from CuentasPagar where id_vehiculo = @idVehiculo
	Delete from FormaCompraVehiculo where id_vehiculo = @idVehiculo
	
end




GO
/****** Object:  StoredProcedure [dbo].[borrar_imagen_cliente]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[borrar_imagen_cliente]
@id int, @mensaje int output
as
set @mensaje = 0;
begin
	delete from ImagenesClientes where id = @id
	set @mensaje = 1;
end




GO
/****** Object:  StoredProcedure [dbo].[borrar_venta_y_detalles_pagos]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE Procedure [dbo].[borrar_venta_y_detalles_pagos]
@idVehiculo int
as
--declare @idVehiculo int = 1;
begin

	update Vehiculos set vendido = 0, fecha_vendido = null, id_cliente = null,
			precioVentaRD = null, precioVentaUSD = null
			where id = @idVehiculo
	Delete from CuentasPagar where id_vehiculo = @idVehiculo
	Delete from CuentasCobrar where id_vehiculo = @idVehiculo
	delete from facturas where idVehiculo = @idVehiculo
	Delete from FormaVentaVehiculo where id_vehiculo = @idVehiculo
	Delete from DetallesEfectivoGeneral where idVehiculo = @idVehiculo
	Delete from SeguroVehiculo where id_vehiculo = @idVehiculo
	Delete from PreciosTraspasoVehiculo where id_vehiculo = @idVehiculo
	Delete from PreciosSeguroVehiculo where id_vehiculo = @idVehiculo
	Delete from CuentasPagar where id_vehiculo = @idVehiculo and id_transaccion = 4
	 

end



GO
/****** Object:  StoredProcedure [dbo].[cambiar_estados_vehiculo]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[cambiar_estados_vehiculo]
@idVehiculo int, @tipoEstado varchar(50), @mensaje int output
as

set @mensaje = 0
begin
	
	    if @tipoEstado = 'terminar'
		begin
			update Vehiculos set terminado = 1, fecha_terminado = GETDATE()  where id = @idVehiculo
			set @mensaje = 1
		end
	else --poner en proceso 
		begin 
			update Vehiculos set terminado = 0, vendido = 0 where id = @idVehiculo
			set @mensaje = 1
		end
end






GO
/****** Object:  StoredProcedure [dbo].[deshabilitar_vehiculo]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[deshabilitar_vehiculo]
@idVehiculo int, @mensaje int output
as
set @mensaje = 0

begin

	
	update Vehiculos set estado = 0 where id = @idVehiculo
	set @mensaje = 1

end






GO
/****** Object:  StoredProcedure [dbo].[eliminar_componente_vehiculo]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[eliminar_componente_vehiculo]
@idVehiculo int, @idComponente int, @mensaje int output
as
set @mensaje = 0

begin

	declare @precioRD float
	set @precioRD = (select monto_rd from GastoVehiculo where id  = @idComponente and id_vehiculo =  @idVehiculo)
	declare @precioUSD float 
	set @precioUSD = (select monto_usd from GastoVehiculo where id  = @idComponente and id_vehiculo =  @idVehiculo)
	

	update Vehiculos set total_invertido_rd = total_invertido_rd - @precioRD, total_invertido_usd = total_invertido_usd - @precioUSD
	where id = @idVehiculo

	declare @idCP int= (select id from CuentasPagar where id_gasto = @idComponente)
	
	delete from PagosCuentasPagar where id = @idCP
	delete from FormaCompraVehiculo where id_vehiculo = @idVehiculo and id_transaccion = 5
	delete from CuentasPagar where id = @idCP

	delete from GastoVehiculo where id = @idComponente and id_vehiculo =  @idVehiculo
	
	set @mensaje = 1
		
end




GO
/****** Object:  StoredProcedure [dbo].[eliminar_gasto_aduanal_vehiculo]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[eliminar_gasto_aduanal_vehiculo]
@idVehiculo int, @idGasto int,@mensaje int output
as
set @mensaje = 0
begin
	
	declare @precioRD float
	set @precioRD = (select monto_rd from GastoVehiculo where id  = @idGasto and id_vehiculo =  @idVehiculo)
	declare @precioUSD float 
	set @precioUSD = (select monto_usd from GastoVehiculo where id  = @idGasto and id_vehiculo =  @idVehiculo)
	

	update Vehiculos set total_invertido_rd = total_invertido_rd - @precioRD, total_invertido_usd = total_invertido_usd - @precioUSD
	where id = @idVehiculo

	declare @idCP int= (select id from CuentasPagar where id_gasto = @idGasto)
	
	delete from PagosCuentasPagar where id = @idCP
	delete from FormaCompraVehiculo where id_vehiculo = @idVehiculo and id_transaccion = 7
	delete from CuentasPagar where id = @idCP

	delete from GastoVehiculo where id = @idGasto and id_vehiculo =  @idVehiculo
	set @mensaje = 1
		
end




GO
/****** Object:  StoredProcedure [dbo].[eliminar_gasto_reparacion_vehiculo]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[eliminar_gasto_reparacion_vehiculo]
@idVehiculo int, @idGasto int,@mensaje int output
as
set @mensaje = 0
begin
	
	declare @precioRD float
	set @precioRD = (select monto_rd from GastoVehiculo where id  = @idGasto and id_vehiculo =  @idVehiculo)
	declare @precioUSD float 
	set @precioUSD = (select monto_usd from GastoVehiculo where id  = @idGasto and id_vehiculo =  @idVehiculo)
	

	update Vehiculos set total_invertido_rd = total_invertido_rd - @precioRD, total_invertido_usd = total_invertido_usd - @precioUSD
	where id = @idVehiculo
	
	declare @idCP int= (select id from CuentasPagar where id_gasto = @idGasto)
	
	delete from PagosCuentasPagar where id = @idCP
	delete from FormaCompraVehiculo where id_vehiculo = @idVehiculo and id_transaccion = 6
	delete from CuentasPagar where id = @idCP
	delete from GastoVehiculo where id = @idGasto and id_vehiculo =  @idVehiculo
	set @mensaje = 1
		
end




GO
/****** Object:  StoredProcedure [dbo].[habilitar_vehiculo]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[habilitar_vehiculo]
@idVehiculo int, @mensaje int output
as
set @mensaje = 0

begin
	update Vehiculos set estado = 1 where id = @idVehiculo
	set @mensaje = 1
end






GO
/****** Object:  StoredProcedure [dbo].[inicio_sesion]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[inicio_sesion]
@usuario varchar(50), @clave varchar(50), @mensaje int output
as

set @mensaje = 0
begin
	if exists (select id from Usuarios where estadoUsuario = 1 and usuario = @usuario and clave = @clave )
		begin
			set @mensaje = (select id from Usuarios where usuario = @usuario and clave = @clave)
		end	
end






GO
/****** Object:  StoredProcedure [dbo].[insertar_detalle_pago_compras_vehiculo]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[insertar_detalle_pago_compras_vehiculo]
@pagoRD float, @pagoUSD float, @mensaje int output, @idTipoPago int, 
@detalles varchar(200)

as
set @mensaje = 0
declare @idVehiculo int = (SELECT MAX(id) from Vehiculos)
declare @fecha date = (select fecha_importe from Vehiculos where id = @idVehiculo)

begin
		
				
		insert into TipoFormaPagoCompraVehiculo (idVehiculo, idTipoPago, montoRD, montoUSD, detalles, balanceRD, balanceUSD)
		VALUES (@idVehiculo, @idTipoPago , @pagoRD, @pagoUSD, @detalles, @pagoRD, @pagoUSD)
		

		if @idTipoPago = 1
			begin
				 insert into DetallesEfectivoGeneral(idVehiculo, tipoCuenta, montoRD, montoUSD, fecha, documento, numeroDocumento)
				 values (@idVehiculo, 1, @pagoRD, @pagoUSD, @fecha, 'COMPRA VEHICULO', @idVehiculo)
			end
		set @mensaje = 1
			
		
				
end






GO
/****** Object:  StoredProcedure [dbo].[insertar_factura]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE procedure [dbo].[insertar_factura]
@idVehiculo int, @mensaje int output, @idCliente int,
@fecha date, @nota varchar(300)
as
set @mensaje = 0
begin
	insert into facturas(idVehiculo, id_cliente, fecha, nota_venta) VALUES (@idVehiculo, @idCliente, @fecha, @nota)
	set @mensaje = 1
end




GO
/****** Object:  StoredProcedure [dbo].[insertar_factura_servicios]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create procedure [dbo].[insertar_factura_servicios]
@idVehiculo int, @mensaje int output, @idSuplidor int, @montoRD float, @montoUSD float, @numeroFactura varchar(50),
@fecha date, @nota varchar(300)
as
set @mensaje = 0
begin
	if not exists (select * from FacturasServicios where facturaSuplidor = @numeroFactura and id_suplidor = @idSuplidor)
		begin
			insert into FacturasServicios(id_vehiculo, id_suplidor, fecha, monto_rd, monto_usd, nota, facturaSuplidor) 
			VALUES (@idVehiculo, @idSuplidor, @fecha, @montoRD, @montoUSD,@nota, @numeroFactura)


			update Vehiculos set total_invertido_rd = total_invertido_rd + @montoRD, total_invertido_usd = total_invertido_usd + @montoUSD
			where id = @idVehiculo

			set @mensaje = 1
		end
	else
		begin
			set @mensaje = 2
		end
	
end




GO
/****** Object:  StoredProcedure [dbo].[insertar_gasto_vehiculo]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

	CREATE procedure  [dbo].[insertar_gasto_vehiculo]
	@idGasto int, @idProveedor int, @idVehiculo int, @montoRD float, @montoUSD float, @fecha date,
	@mensaje int output, @idTransaccion int, @cantidad int
	as
	declare @idFactura int= (select MAX(id) from FacturasServicios)
	set @mensaje = 0;
	begin
		insert into GastoVehiculo(id_gasto, id_proveedor, id_vehiculo, monto_rd, monto_usd, fecha, id_transaccion, id_factura_servicio, cantidad)
		VALUES (@idGasto, @idProveedor, @idVehiculo, @montoRD, @montoUSD, @fecha, @idTransaccion, @idFactura, @cantidad)
		
		--update Vehiculos set total_invertido_rd = total_invertido_rd + @montoRD, total_invertido_usd = total_invertido_usd + @montoUSD
		--where id = @idVehiculo

		set @mensaje = 1;
	end




GO
/****** Object:  StoredProcedure [dbo].[insertar_imagenes_clientes]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[insertar_imagenes_clientes]
@img varbinary(max), @mensaje int output
as
set @mensaje = 0;
declare @idCliente int = (select MAX(id) from Clientes)
begin
	insert into ImagenesClientes(idCliente,img)
	Values (@idCliente, @img)
	set @mensaje = 1;
	
end



GO
/****** Object:  StoredProcedure [dbo].[insertar_imagenes_traspaso]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[insertar_imagenes_traspaso]
@img varbinary(max), @mensaje int output
as
set @mensaje = 0;
declare @idfactura int = (select MAX(id) from facturas)
declare @idVehiculo int = (select idVehiculo from facturas where id = @idfactura)
begin
	insert into ImagenesTraspasos(id_vehiculo,id_factura,img)
	Values (@idVehiculo,@idfactura, @img)
	set @mensaje = 1;
	
end



GO
/****** Object:  StoredProcedure [dbo].[insertarFormaGastos]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
	CREATE procedure [dbo].[insertarFormaGastos]
	@idVehiculo int, @idTransaccion int, @idTipoPago int, @montoRD float, @montoUSD float,
	@nota varchar(100), @fecha date, @mensaje int output, @idSuplidor int
	as
	declare @idFactura int = (select MAX(id) from FacturasServicios)
	set @mensaje = 0;
	begin
		insert into FormaCompraVehiculo (id_vehiculo, id_transaccion, id_tipo_pago, id_factura, monto_rd, monto_usd, nota, fecha)
		VALUES (@idVehiculo, @idTransaccion, @idTipoPago, @idFactura, @montoRD, @montoUSD, @nota, @fecha)
		
		
		
		
		if @idTipoPago = 3 
			begin
				 insert into CuentasPagar (id_factura, id_vendedor, id_transaccion, monto_rd, monto_usd,
				  balance_rd, balance_usd, fecha, id_vehiculo)
				  VALUES(@idFactura, @idSuplidor, @idTransaccion, @montoRD, @montoUSD, @montoRD, @montoUSD,
				  @fecha, @idVehiculo)

				  if @idTransaccion = 5 or @idTransaccion = 6 or @idTransaccion = 7
					begin
						update CuentasPagar set id_gasto = ((select IsNull(MAX(id), 0) from GastoVehiculo) + 1)
						where id = (select Max(id) from CuentasPagar)
					end
			end

		
		set @mensaje = 1;
		 
	end



GO
/****** Object:  StoredProcedure [dbo].[insertarFormaTransaccionesCompras]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
	create procedure [dbo].[insertarFormaTransaccionesCompras]
	@idVehiculo int, @idTransaccion int, @idTipoPago int, @montoRD float, @montoUSD float,
	@nota varchar(100), @fecha date, @mensaje int output
	as
	declare @idFactura int = 0
	set @mensaje = 0;
	set @idVehiculo = (select MAX(id) from Vehiculos)
	begin
		insert into FormaCompraVehiculo (id_vehiculo, id_transaccion, id_tipo_pago, id_factura, monto_rd, monto_usd, nota, fecha)
		VALUES (@idVehiculo, @idTransaccion, @idTipoPago, @idFactura, @montoRD, @montoUSD, @nota, @fecha)
		
		
		declare @idSuplidor int = (select id_suplidor from Vehiculos where id = (select MAX(id) from Vehiculos))
		
		if @idTipoPago = 3 
			begin
				 insert into CuentasPagar (id_factura, id_vendedor, id_transaccion, monto_rd, monto_usd,
				  balance_rd, balance_usd, fecha, id_vehiculo)
				  VALUES(@idFactura, @idSuplidor, @idTransaccion, @montoRD, @montoUSD, @montoRD, @montoUSD,
				  @fecha, @idVehiculo)
			end

		--if @idTipoPago = 1
		--	begin
		--		 insert into DetallesEfectivoGeneral(idVehiculo, tipoCuenta, montoRD, montoUSD, fecha, documento, numeroDocumento,id_transaccion)
		--		 values (@idVehiculo, 2, @montoRD, @montoRD, @fecha, 'Factura', @idFactura, @idTransaccion)
		--	end
		
		set @mensaje = 1;
		 
	end



GO
/****** Object:  StoredProcedure [dbo].[insertarFormaTransaccionesFacturacion]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
	create procedure [dbo].[insertarFormaTransaccionesFacturacion]
	@idVehiculo int, @idTransaccion int, @idTipoPago int, @montoRD float, @montoUSD float,
	@nota varchar(100), @fecha date, @mensaje int output
	as
	declare @idFactura int = (select MAX(id) from facturas)
	set @mensaje = 0;
	begin
		insert into FormaVentaVehiculo (id_vehiculo, id_transaccion, id_tipo_pago, id_factura, monto_rd, monto_usd, nota, fecha)
		VALUES (@idVehiculo, @idTransaccion, @idTipoPago, @idFactura, @montoRD, @montoUSD, @nota, @fecha)
		
		
		declare @idCliente int= (Select id_cliente from facturas where id = @idFactura)
		
		if @idTipoPago = 3
			begin
				 insert into CuentasCobrar (id_factura, id_cliente, id_transaccion, monto_rd, monto_usd,
				  balance_rd, balance_usd, fecha, id_vehiculo)
				  VALUES(@idFactura, @idCliente, @idTransaccion, @montoRD, @montoUSD, @montoRD, @montoUSD,
				  @fecha, @idVehiculo)
			end

		if @idTipoPago = 1
			begin
				 insert into DetallesEfectivoGeneral(idVehiculo, tipoCuenta, montoRD, montoUSD, fecha, documento, numeroDocumento,id_transaccion)
				 values (@idVehiculo, 2, @montoRD, @montoUSD, @fecha, 'Factura', @idFactura, @idTransaccion)
			end
		
		set @mensaje = 1;
		 
	end



GO
/****** Object:  StoredProcedure [dbo].[llenar_tablas]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[llenar_tablas]
as

begin
	if not exists(select * from Fabricantes where id = 1)
		begin
			INSERT INTO Fabricantes (codigo, fabricante) VALUES
			('ACURA', 'Acura'),
			('ALFA', 'Alfa Romeo'),
			('AMC', 'AMC'),
			('ASTON', 'Aston Martin'),
			('AUDI', 'Audi'),
			('AVANTI', 'Avanti'),
			('BENTL', 'Bentley'),
			('BMW', 'BMW'),
			('BUICK', 'Buick'),
			('CAD', 'Cadillac'),
			('CHEV', 'Chevrolet'),
			('CHRY', 'Chrysler'),
			('DAEW', 'Daewoo'),
			('DAIHAT', 'Daihatsu'),
			('DATSUN', 'Datsun'),
			('DELOREAN', 'DeLorean'),
			('DODGE', 'Dodge'),
			('EAGLE', 'Eagle'),
			('FER', 'Ferrari'),
			('FIAT', 'FIAT'),
			('FISK', 'Fisker'),
			('FORD', 'Ford'),
			('FREIGHT', 'Freightliner'),
			('GEO', 'Geo'),
			('GMC', 'GMC'),
			('HONDA', 'Honda'),
			('AMGEN', 'HUMMER'),
			('HYUND', 'Hyundai'),
			('INFIN', 'Infiniti'),
			('ISU', 'Isuzu'),
			('JAG', 'Jaguar'),
			('JEEP', 'Jeep'),
			('KIA', 'Kia'),
			('LAM', 'Lamborghini'),
			('LAN', 'Lancia'),
			('ROV', 'Land Rover'),
			('LEXUS', 'Lexus'),
			('LINC', 'Lincoln'),
			('LOTUS', 'Lotus'),
			('MAS', 'Maserati'),
			('MAYBACH', 'Maybach'),
			('MAZDA', 'Mazda'),
			('MCLAREN', 'McLaren'),
			('MB', 'Mercedes-Benz'),
			('MERC', 'Mercury'),
			('MERKUR', 'Merkur'),
			('MINI', 'MINI'),
			('MIT', 'Mitsubishi'),
			('NISSAN', 'Nissan'),
			('OLDS', 'Oldsmobile'),
			('PEUG', 'Peugeot'),
			('PLYM', 'Plymouth'),
			('PONT', 'Pontiac'),
			('POR', 'Porsche'),
			('RAM', 'RAM'),
			('REN', 'Renault'),
			('RR', 'Rolls-Royce'),
			('SAAB', 'Saab'),
			('SATURN', 'Saturn'),
			('SCION', 'Scion'),
			('SMART', 'smart'),
			('SRT', 'SRT'),
			('STERL', 'Sterling'),
			('SUB', 'Subaru'),
			('SUZUKI', 'Suzuki'),
			('TESLA', 'Tesla'),
			('TOYOTA', 'Toyota'),
			('TRI', 'Triumph'),
			('VOLKS', 'Volkswagen'),
			('VOLVO', 'Volvo'),
			('YUGO', 'Yugo');
		end

		if not exists(select * from Modelos where id = 1)
		begin
			Insert into Modelos (noUso, fabricante_id, codigo, modelo) VALUES
			
			(1, 1, 'CL_MODELS', 'CL Models (4)'),
			(2, 1, '2.2CL', ' - 2.2CL'),
			(3, 1, '2.3CL', ' - 2.3CL'),
			(4, 1, '3.0CL', ' - 3.0CL'),
			(5, 1, '3.2CL', ' - 3.2CL'),
			(6, 1, 'ILX', 'ILX'),
			(7, 1, 'INTEG', 'Integra'),
			(8, 1, 'LEGEND', 'Legend'),
			(9, 1, 'MDX', 'MDX'),
			(10, 1, 'NSX', 'NSX'),
			(11, 1, 'RDX', 'RDX'),
			(12, 1, 'RL_MODELS', 'RL Models (2)'),
			(13, 1, '3.5RL', ' - 3.5 RL'),
			(14, 1, 'RL', ' - RL'),
			(15, 1, 'RSX', 'RSX'),
			(16, 1, 'SLX', 'SLX'),
			(17, 1, 'TL_MODELS', 'TL Models (3)'),
			(18, 1, '2.5TL', ' - 2.5TL'),
			(19, 1, '3.2TL', ' - 3.2TL'),
			(20, 1, 'TL', ' - TL'),
			(21, 1, 'TSX', 'TSX'),
			(22, 1, 'VIGOR', 'Vigor'),
			(23, 1, 'ZDX', 'ZDX'),
			(24, 1, 'ACUOTH', 'Other Acura Models'),
			(25, 2, 'ALFA164', '164'),
			(26, 2, 'ALFA8C', '8C Competizione'),
			(27, 2, 'ALFAGT', 'GTV-6'),
			(28, 2, 'MIL', 'Milano'),
			(29, 2, 'SPID', 'Spider'),
			(30, 2, 'ALFAOTH', 'Other Alfa Romeo Models'),
			(31, 3, 'AMCALLIAN', 'Alliance'),
			(32, 3, 'CON', 'Concord'),
			(33, 3, 'EAGLE', 'Eagle'),
			(34, 3, 'AMCENC', 'Encore'),
			(35, 3, 'AMCSPIRIT', 'Spirit'),
			(36, 3, 'AMCOTH', 'Other AMC Models'),
			(37, 4, 'DB7', 'DB7'),
			(38, 4, 'DB9', 'DB9'),
			(39, 4, 'DBS', 'DBS'),
			(40, 4, 'LAGONDA', 'Lagonda'),
			(41, 4, 'RAPIDE', 'Rapide'),
			(42, 4, 'V12VANT', 'V12 Vantage'),
			(43, 4, 'VANTAGE', 'V8 Vantage'),
			(44, 4, 'VANQUISH', 'Vanquish'),
			(45, 4, 'VIRAGE', 'Virage'),
			(46, 4, 'UNAVAILAST', 'Other Aston Martin Models'),
			(47, 5, 'AUDI100', '100'),
			(48, 5, 'AUDI200', '200'),
			(49, 5, '4000', '4000'),
			(50, 5, '5000', '5000'),
			(51, 5, '80', '80'),
			(52, 5, '90', '90'),
			(53, 5, 'A3', 'A3'),
			(54, 5, 'A4', 'A4'),
			(55, 5, 'A5', 'A5'),
			(56, 5, 'A6', 'A6'),
			(57, 5, 'A7', 'A7'),
			(58, 5, 'A8', 'A8'),
			(59, 5, 'ALLRDQUA', 'allroad'),
			(60, 5, 'AUDICABRI', 'Cabriolet'),
			(61, 5, 'AUDICOUPE', 'Coupe'),
			(62, 5, 'Q3', 'Q3'),
			(63, 5, 'Q5', 'Q5'),
			(64, 5, 'Q7', 'Q7'),
			(65, 5, 'QUATTR', 'Quattro'),
			(66, 5, 'R8', 'R8'),
			(67, 5, 'RS4', 'RS 4'),
			(68, 5, 'RS5', 'RS 5'),
			(69, 5, 'RS6', 'RS 6'),
			(70, 5, 'S4', 'S4'),
			(71, 5, 'S5', 'S5'),
			(72, 5, 'S6', 'S6'),
			(73, 5, 'S7', 'S7'),
			(74, 5, 'S8', 'S8'),
			(75, 5, 'TT', 'TT'),
			(76, 5, 'TTRS', 'TT RS'),
			(77, 5, 'TTS', 'TTS'),
			(78, 5, 'V8', 'V8 Quattro'),
			(79, 5, 'AUDOTH', 'Other Audi Models'),
			(80, 6, 'CONVERT', 'Convertible'),
			(81, 6, 'COUPEAVANT', 'Coupe'),
			(82, 6, 'SEDAN', 'Sedan'),
			(83, 6, 'UNAVAILAVA', 'Other Avanti Models'),
			(84, 7, 'ARNAGE', 'Arnage'),
			(85, 7, 'AZURE', 'Azure'),
			(86, 7, 'BROOKLANDS', 'Brooklands'),
			(87, 7, 'BENCONT', 'Continental'),
			(88, 7, 'CORNICHE', 'Corniche'),
			(89, 7, 'BENEIGHT', 'Eight'),
			(90, 7, 'BENMUL', 'Mulsanne'),
			(91, 7, 'BENTURBO', 'Turbo R'),
			(92, 7, 'UNAVAILBEN', 'Other Bentley Models'),
			(93, 8, '1_SERIES', '1 Series (3)'),
			(94, 8, '128I', ' - 128i'),
			(95, 8, '135I', ' - 135i'),
			(96, 8, '135IS', ' - 135is'),
			(97, 8, '3_SERIES', '3 Series (29)'),
			(98, 8, '318I', ' - 318i'),
			(99, 8, '318IC', ' - 318iC'),
			(100, 8, '318IS', ' - 318iS'),
			(101, 8, '318TI', ' - 318ti'),
			(102, 8, '320I', ' - 320i'),
			(103, 8, '323CI', ' - 323ci'),
			(104, 8, '323I', ' - 323i'),
			(105, 8, '323IS', ' - 323is'),
			(106, 8, '323IT', ' - 323iT'),
			(107, 8, '325CI', ' - 325Ci'),
			(108, 8, '325E', ' - 325e'),
			(109, 8, '325ES', ' - 325es'),
			(110, 8, '325I', ' - 325i'),
			(111, 8, '325IS', ' - 325is'),
			(112, 8, '325IX', ' - 325iX'),
			(113, 8, '325XI', ' - 325xi'),
			(114, 8, '328CI', ' - 328Ci'),
			(115, 8, '328I', ' - 328i'),
			(116, 8, '328IS', ' - 328iS'),
			(117, 8, '328XI', ' - 328xi'),
			(118, 8, '330CI', ' - 330Ci'),
			(119, 8, '330I', ' - 330i'),
			(120, 8, '330XI', ' - 330xi'),
			(121, 8, '335D', ' - 335d'),
			(122, 8, '335I', ' - 335i'),
			(123, 8, '335IS', ' - 335is'),
			(124, 8, '335XI', ' - 335xi'),
			(125, 8, 'ACTIVE3', ' - ActiveHybrid 3'),
			(126, 8, 'BMW325', ' - 325'),
			(127, 8, '5_SERIES', '5 Series (19)'),
			(128, 8, '524TD', ' - 524td'),
			(129, 8, '525I', ' - 525i'),
			(130, 8, '525XI', ' - 525xi'),
			(131, 8, '528E', ' - 528e'),
			(132, 8, '528I', ' - 528i'),
			(133, 8, '528IT', ' - 528iT'),
			(134, 8, '528XI', ' - 528xi'),
			(135, 8, '530I', ' - 530i'),
			(136, 8, '530IT', ' - 530iT'),
			(137, 8, '530XI', ' - 530xi'),
			(138, 8, '533I', ' - 533i'),
			(139, 8, '535I', ' - 535i'),
			(140, 8, '535IGT', ' - 535i Gran Turismo'),
			(141, 8, '535XI', ' - 535xi'),
			(142, 8, '540I', ' - 540i'),
			(143, 8, '545I', ' - 545i'),
			(144, 8, '550I', ' - 550i'),
			(145, 8, '550IGT', ' - 550i Gran Turismo'),
			(146, 8, 'ACTIVE5', ' - ActiveHybrid 5'),
			(147, 8, '6_SERIES', '6 Series (8)'),
			(148, 8, '633CSI', ' - 633CSi'),
			(149, 8, '635CSI', ' - 635CSi'),
			(150, 8, '640I', ' - 640i'),
			(151, 8, '640IGC', ' - 640i Gran Coupe'),
			(152, 8, '645CI', ' - 645Ci'),
			(153, 8, '650I', ' - 650i'),
			(154, 8, '650IGC', ' - 650i Gran Coupe'),
			(155, 8, 'L6', ' - L6'),
			(156, 8, '7_SERIES', '7 Series (15)'),
			(157, 8, '733I', ' - 733i'),
			(158, 8, '735I', ' - 735i'),
			(159, 8, '735IL', ' - 735iL'),
			(160, 8, '740I', ' - 740i'),
			(161, 8, '740IL', ' - 740iL'),
			(162, 8, '740LI', ' - 740Li'),
			(163, 8, '745I', ' - 745i'),
			(164, 8, '745LI', ' - 745Li'),
			(165, 8, '750I', ' - 750i'),
			(166, 8, '750IL', ' - 750iL'),
			(167, 8, '750LI', ' - 750Li'),
			(168, 8, '760I', ' - 760i'),
			(169, 8, '760LI', ' - 760Li'),
			(170, 8, 'ACTIVE7', ' - ActiveHybrid 7'),
			(171, 8, 'ALPINAB7', ' - Alpina B7'),
			(172, 8, '8_SERIES', '8 Series (4)'),
			(173, 8, '840CI', ' - 840Ci'),
			(174, 8, '850CI', ' - 850Ci'),
			(175, 8, '850CSI', ' - 850CSi'),
			(176, 8, '850I', ' - 850i'),
			(177, 8, 'L_SERIES', 'L Series (1)'),
			(178, 8, 'L7', ' - L7'),
			(179, 8, 'M_SERIES', 'M Series (8)'),
			(180, 8, '1SERIESM', ' - 1 Series M'),
			(181, 8, 'BMWMCOUPE', ' - M Coupe'),
			(182, 8, 'BMWROAD', ' - M Roadster'),
			(183, 8, 'M3', ' - M3'),
			(184, 8, 'M5', ' - M5'),
			(185, 8, 'M6', ' - M6'),
			(186, 8, 'X5M', ' - X5 M'),
			(187, 8, 'X6M', ' - X6 M'),
			(188, 8, 'X_SERIES', 'X Series (5)'),
			(189, 8, 'ACTIVEX6', ' - ActiveHybrid X6'),
			(190, 8, 'X1', ' - X1'),
			(191, 8, 'X3', ' - X3'),
			(192, 8, 'X5', ' - X5'),
			(193, 8, 'X6', ' - X6'),
			(194, 8, 'Z_SERIES', 'Z Series (3)'),
			(195, 8, 'Z3', ' - Z3'),
			(196, 8, 'Z4', ' - Z4'),
			(197, 8, 'Z8', ' - Z8'),
			(198, 8, 'BMWOTH', 'Other BMW Models'),
			(199, 9, 'CENT', 'Century'),
			(200, 9, 'ELEC', 'Electra'),
			(201, 9, 'ENCLAVE', 'Enclave'),
			(202, 9, 'BUIENC', 'Encore'),
			(203, 9, 'LACROSSE', 'LaCrosse'),
			(204, 9, 'LESA', 'Le Sabre'),
			(205, 9, 'LUCERNE', 'Lucerne'),
			(206, 9, 'PARK', 'Park Avenue'),
			(207, 9, 'RAINIER', 'Rainier'),
			(208, 9, 'REATTA', 'Reatta'),
			(209, 9, 'REG', 'Regal'),
			(210, 9, 'RENDEZVOUS', 'Rendezvous'),
			(211, 9, 'RIV', 'Riviera'),
			(212, 9, 'BUICKROAD', 'Roadmaster'),
			(213, 9, 'SKYH', 'Skyhawk'),
			(214, 9, 'SKYL', 'Skylark'),
			(215, 9, 'SOMER', 'Somerset'),
			(216, 9, 'TERRAZA', 'Terraza'),
			(217, 9, 'BUVERANO', 'Verano'),
			(218, 9, 'BUOTH', 'Other Buick Models'),
			(219, 10, 'ALLANT', 'Allante'),
			(220, 10, 'ATS', 'ATS'),
			(221, 10, 'BROUGH', 'Brougham'),
			(222, 10, 'CATERA', 'Catera'),
			(223, 10, 'CIMA', 'Cimarron'),
			(224, 10, 'CTS', 'CTS'),
			(225, 10, 'DEV', 'De Ville'),
			(226, 10, 'DTS', 'DTS'),
			(227, 10, 'ELDO', 'Eldorado'),
			(228, 10, 'ESCALA', 'Escalade'),
			(229, 10, 'ESCALAESV', 'Escalade ESV'),
			(230, 10, 'EXT', 'Escalade EXT'),
			(231, 10, 'FLEE', 'Fleetwood'),
			(232, 10, 'SEV', 'Seville'),
			(233, 10, 'SRX', 'SRX'),
			(234, 10, 'STS', 'STS'),
			(235, 10, 'XLR', 'XLR'),
			(236, 10, 'XTS', 'XTS'),
			(237, 10, 'CADOTH', 'Other Cadillac Models'),
			(238, 11, 'ASTRO', 'Astro'),
			(239, 11, 'AVALNCH', 'Avalanche'),
			(240, 11, 'AVEO', 'Aveo'),
			(241, 11, 'AVEO5', 'Aveo5'),
			(242, 11, 'BERETT', 'Beretta'),
			(243, 11, 'BLAZER', 'Blazer'),
			(244, 11, 'CAM', 'Camaro'),
			(245, 11, 'CAP', 'Caprice'),
			(246, 11, 'CHECAPS', 'Captiva Sport'),
			(247, 11, 'CAV', 'Cavalier'),
			(248, 11, 'CELE', 'Celebrity'),
			(249, 11, 'CHEVETTE', 'Chevette'),
			(250, 11, 'CITATION', 'Citation'),
			(251, 11, 'COBALT', 'Cobalt'),
			(252, 11, 'COLORADO', 'Colorado'),
			(253, 11, 'CORSI', 'Corsica'),
			(254, 11, 'CORV', 'Corvette'),
			(255, 11, 'CRUZE', 'Cruze'),
			(256, 11, 'ELCAM', 'El Camino'),
			(257, 11, 'EQUINOX', 'Equinox'),
			(258, 11, 'G15EXP', 'Express Van'),
			(259, 11, 'G10', 'G Van'),
			(260, 11, 'HHR', 'HHR'),
			(261, 11, 'CHEVIMP', 'Impala'),
			(262, 11, 'KODC4500', 'Kodiak C4500'),
			(263, 11, 'LUMINA', 'Lumina'),
			(264, 11, 'LAPV', 'Lumina APV'),
			(265, 11, 'LUV', 'LUV'),
			(266, 11, 'MALI', 'Malibu'),
			(267, 11, 'CHVMETR', 'Metro'),
			(268, 11, 'CHEVMONT', 'Monte Carlo'),
			(269, 11, 'NOVA', 'Nova'),
			(270, 11, 'CHEVPRIZM', 'Prizm'),
			(271, 11, 'CHVST', 'S10 Blazer'),
			(272, 11, 'S10PICKUP', 'S10 Pickup'),
			(273, 11, 'CHEV150', 'Silverado and other C/K1500'),
			(274, 11, 'CHEVC25', 'Silverado and other C/K2500'),
			(275, 11, 'CH3500PU', 'Silverado and other C/K3500'),
			(276, 11, 'SONIC', 'Sonic'),
			(277, 11, 'SPARK', 'Spark'),
			(278, 11, 'CHEVSPEC', 'Spectrum'),
			(279, 11, 'CHSPRINT', 'Sprint'),
			(280, 11, 'SSR', 'SSR'),
			(281, 11, 'CHEVSUB', 'Suburban'),
			(282, 11, 'TAHOE', 'Tahoe'),
			(283, 11, 'TRACKE', 'Tracker'),
			(284, 11, 'TRAILBLZ', 'TrailBlazer'),
			(285, 11, 'TRAILBZEXT', 'TrailBlazer EXT'),
			(286, 11, 'TRAVERSE', 'Traverse'),
			(287, 11, 'UPLANDER', 'Uplander'),
			(288, 11, 'VENTUR', 'Venture'),
			(289, 11, 'VOLT', 'Volt'),
			(290, 11, 'CHEOTH', 'Other Chevrolet Models'),
			(291, 12, 'CHRYS200', '200'),
			(292, 12, '300', '300'),
			(293, 12, 'CHRY300', '300M'),
			(294, 12, 'ASPEN', 'Aspen'),
			(295, 12, 'CARAVAN', 'Caravan'),
			(296, 12, 'CIRRUS', 'Cirrus'),
			(297, 12, 'CONC', 'Concorde'),
			(298, 12, 'CHRYCONQ', 'Conquest'),
			(299, 12, 'CORDOBA', 'Cordoba'),
			(300, 12, 'CROSSFIRE', 'Crossfire'),
			(301, 12, 'ECLASS', 'E Class'),
			(302, 12, 'FIFTH', 'Fifth Avenue'),
			(303, 12, 'CHRYGRANDV', 'Grand Voyager'),
			(304, 12, 'IMPE', 'Imperial'),
			(305, 12, 'INTREPID', 'Intrepid'),
			(306, 12, 'CHRYLAS', 'Laser'),
			(307, 12, 'LEBA', 'LeBaron'),
			(308, 12, 'LHS', 'LHS'),
			(309, 12, 'CHRYNEON', 'Neon'),
			(310, 12, 'NY', 'New Yorker'),
			(311, 12, 'NEWPORT', 'Newport'),
			(312, 12, 'PACIFICA', 'Pacifica'),
			(313, 12, 'CHPROWLE', 'Prowler'),
			(314, 12, 'PTCRUIS', 'PT Cruiser'),
			(315, 12, 'CHRYSEB', 'Sebring'),
			(316, 12, 'CHRYTC', 'TC by Maserati'),
			(317, 12, 'TANDC', 'Town & Country'),
			(318, 12, 'VOYAGER', 'Voyager'),
			(319, 12, 'CHOTH', 'Other Chrysler Models'),
			(320, 13, 'LANOS', 'Lanos'),
			(321, 13, 'LEGANZA', 'Leganza'),
			(322, 13, 'NUBIRA', 'Nubira'),
			(323, 13, 'DAEOTH', 'Other Daewoo Models'),
			(324, 14, 'CHAR', 'Charade'),
			(325, 14, 'ROCKY', 'Rocky'),
			(326, 14, 'DAIHOTH', 'Other Daihatsu Models'),
			(327, 15, 'DAT200SX', '200SX'),
			(328, 15, 'DAT210', '210'),
			(329, 15, '280Z', '280ZX'),
			(330, 15, '300ZX', '300ZX'),
			(331, 15, '310', '310'),
			(332, 15, '510', '510'),
			(333, 15, '720', '720'),
			(334, 15, '810', '810'),
			(335, 15, 'DATMAX', 'Maxima'),
			(336, 15, 'DATPU', 'Pickup'),
			(337, 15, 'PUL', 'Pulsar'),
			(338, 15, 'DATSENT', 'Sentra'),
			(339, 15, 'STAN', 'Stanza'),
			(340, 15, 'DATOTH', 'Other Datsun Models'),
			(341, 16, 'DMC12', 'DMC-12'),
			(342, 17, '400', '400'),
			(343, 17, 'DOD600', '600'),
			(344, 17, 'ARI', 'Aries'),
			(345, 17, 'AVENGR', 'Avenger'),
			(346, 17, 'CALIBER', 'Caliber'),
			(347, 17, 'DODCARA', 'Caravan'),
			(348, 17, 'CHALLENGER', 'Challenger'),
			(349, 17, 'DODCHAR', 'Charger'),
			(350, 17, 'DODCOLT', 'Colt'),
			(351, 17, 'DODCONQ', 'Conquest'),
			(352, 17, 'DODDW', 'D/W Truck'),
			(353, 17, 'DAKOTA', 'Dakota'),
			(354, 17, 'DODDART', 'Dart'),
			(355, 17, 'DAY', 'Daytona'),
			(356, 17, 'DIPLOMA', 'Diplomat'),
			(357, 17, 'DURANG', 'Durango'),
			(358, 17, 'DODDYNA', 'Dynasty'),
			(359, 17, 'GRANDCARAV', 'Grand Caravan'),
			(360, 17, 'INTRE', 'Intrepid'),
			(361, 17, 'JOURNEY', 'Journey'),
			(362, 17, 'LANCERDODG', 'Lancer'),
			(363, 17, 'MAGNUM', 'Magnum'),
			(364, 17, 'MIRADA', 'Mirada'),
			(365, 17, 'MONACO', 'Monaco'),
			(366, 17, 'DODNEON', 'Neon'),
			(367, 17, 'NITRO', 'Nitro'),
			(368, 17, 'OMNI', 'Omni'),
			(369, 17, 'RAIDER', 'Raider'),
			(370, 17, 'RAM1504WD', 'Ram 1500 Truck'),
			(371, 17, 'RAM25002WD', 'Ram 2500 Truck'),
			(372, 17, 'RAM3502WD', 'Ram 3500 Truck'),
			(373, 17, 'RAM4500', 'Ram 4500 Truck'),
			(374, 17, 'DODD50', 'Ram 50 Truck'),
			(375, 17, 'CV', 'RAM C/V'),
			(376, 17, 'RAMSRT10', 'Ram SRT-10'),
			(377, 17, 'RAMVANV8', 'Ram Van'),
			(378, 17, 'RAMWAGON', 'Ram Wagon'),
			(379, 17, 'RAMCGR', 'Ramcharger'),
			(380, 17, 'RAMPAGE', 'Rampage'),
			(381, 17, 'DODSHAD', 'Shadow'),
			(382, 17, 'DODSPIR', 'Spirit'),
			(383, 17, 'SPRINTER', 'Sprinter'),
			(384, 17, 'SRT4', 'SRT-4'),
			(385, 17, 'STREGIS', 'St. Regis'),
			(386, 17, 'STEAL', 'Stealth'),
			(387, 17, 'STRATU', 'Stratus'),
			(388, 17, 'VIPER', 'Viper'),
			(389, 17, 'DOOTH', 'Other Dodge Models'),
			(390, 18, 'EAGLEMED', 'Medallion'),
			(391, 18, 'EAGLEPREM', 'Premier'),
			(392, 18, 'SUMMIT', 'Summit'),
			(393, 18, 'TALON', 'Talon'),
			(394, 18, 'VISION', 'Vision'),
			(395, 18, 'EAGOTH', 'Other Eagle Models'),
			(396, 19, '308GTB', '308 GTB Quattrovalvole'),
			(397, 19, '308TBI', '308 GTBI'),
			(398, 19, '308GTS', '308 GTS Quattrovalvole'),
			(399, 19, '308TSI', '308 GTSI'),
			(400, 19, '328GTB', '328 GTB'),
			(401, 19, '328GTS', '328 GTS'),
			(402, 19, '348GTB', '348 GTB'),
			(403, 19, '348GTS', '348 GTS'),
			(404, 19, '348SPI', '348 Spider'),
			(405, 19, '348TB', '348 TB'),
			(406, 19, '348TS', '348 TS'),
			(407, 19, '360', '360'),
			(408, 19, '456GT', '456 GT'),
			(409, 19, '456MGT', '456M GT'),
			(410, 19, '458ITALIA', '458 Italia'),
			(411, 19, '512BBI', '512 BBi'),
			(412, 19, '512M', '512M'),
			(413, 19, '512TR', '512TR'),
			(414, 19, '550M', '550 Maranello'),
			(415, 19, '575M', '575M Maranello'),
			(416, 19, '599GTB', '599 GTB Fiorano'),
			(417, 19, '599GTO', '599 GTO'),
			(418, 19, '612SCAGLIE', '612 Scaglietti'),
			(419, 19, 'FERCALIF', 'California'),
			(420, 19, 'ENZO', 'Enzo'),
			(421, 19, 'F355', 'F355'),
			(422, 19, 'F40', 'F40'),
			(423, 19, 'F430', 'F430'),
			(424, 19, 'F50', 'F50'),
			(425, 19, 'FERFF', 'FF'),
			(426, 19, 'MOND', 'Mondial'),
			(427, 19, 'TEST', 'Testarossa'),
			(428, 19, 'UNAVAILFER', 'Other Ferrari Models'),
			(429, 20, '2000', '2000 Spider'),
			(430, 20, 'FIAT500', '500'),
			(431, 20, 'BERTON', 'Bertone X1/9'),
			(432, 20, 'BRAVA', 'Brava'),
			(433, 20, 'PININ', 'Pininfarina Spider'),
			(434, 20, 'STRADA', 'Strada'),
			(435, 20, 'FIATX19', 'X1/9'),
			(436, 20, 'UNAVAILFIA', 'Other Fiat Models'),
			(437, 21, 'KARMA', 'Karma'),
			(438, 22, 'AERO', 'Aerostar'),
			(439, 22, 'ASPIRE', 'Aspire'),
			(440, 22, 'BRON', 'Bronco'),
			(441, 22, 'B2', 'Bronco II'),
			(442, 22, 'FOCMAX', 'C-MAX'),
			(443, 22, 'FORDCLUB', 'Club Wagon'),
			(444, 22, 'CONTOUR', 'Contour'),
			(445, 22, 'COURIER', 'Courier'),
			(446, 22, 'CROWNVIC', 'Crown Victoria'),
			(447, 22, 'E150ECON', 'E-150 and Econoline 150'),
			(448, 22, 'E250ECON', 'E-250 and Econoline 250'),
			(449, 22, 'E350ECON', 'E-350 and Econoline 350'),
			(450, 22, 'EDGE', 'Edge'),
			(451, 22, 'ESCAPE', 'Escape'),
			(452, 22, 'ESCO', 'Escort'),
			(453, 22, 'EXCURSION', 'Excursion'),
			(454, 22, 'EXP', 'EXP'),
			(455, 22, 'EXPEDI', 'Expedition'),
			(456, 22, 'EXPEDIEL', 'Expedition EL'),
			(457, 22, 'EXPLOR', 'Explorer'),
			(458, 22, 'SPORTTRAC', 'Explorer Sport Trac'),
			(459, 22, 'F100', 'F100'),
			(460, 22, 'F150PICKUP', 'F150'),
			(461, 22, 'F250', 'F250'),
			(462, 22, 'F350', 'F350'),
			(463, 22, 'F450', 'F450'),
			(464, 22, 'FAIRM', 'Fairmont'),
			(465, 22, 'FESTIV', 'Festiva'),
			(466, 22, 'FIESTA', 'Fiesta'),
			(467, 22, 'FIVEHUNDRE', 'Five Hundred'),
			(468, 22, 'FLEX', 'Flex'),
			(469, 22, 'FOCUS', 'Focus'),
			(470, 22, 'FREESTAR', 'Freestar'),
			(471, 22, 'FREESTYLE', 'Freestyle'),
			(472, 22, 'FUSION', 'Fusion'),
			(473, 22, 'GRANADA', 'Granada'),
			(474, 22, 'GT', 'GT'),
			(475, 22, 'LTD', 'LTD'),
			(476, 22, 'MUST', 'Mustang'),
			(477, 22, 'PROBE', 'Probe'),
			(478, 22, 'RANGER', 'Ranger'),
			(479, 22, 'TAURUS', 'Taurus'),
			(480, 22, 'TAURUSX', 'Taurus X'),
			(481, 22, 'TEMPO', 'Tempo'),
			(482, 22, 'TBIRD', 'Thunderbird'),
			(483, 22, 'TRANSCONN', 'Transit Connect'),
			(484, 22, 'WINDST', 'Windstar'),
			(485, 22, 'FORDZX2', 'ZX2 Escort'),
			(486, 22, 'FOOTH', 'Other Ford Models'),
			(487, 23, 'FRESPRINT', 'Sprinter'),
			(488, 24, 'GEOMETRO', 'Metro'),
			(489, 24, 'GEOPRIZM', 'Prizm'),
			(490, 24, 'SPECT', 'Spectrum'),
			(491, 24, 'STORM', 'Storm'),
			(492, 24, 'GEOTRACK', 'Tracker'),
			(493, 24, 'GEOOTH', 'Other Geo Models'),
			(494, 25, 'ACADIA', 'Acadia'),
			(495, 25, 'CABALLERO', 'Caballero'),
			(496, 25, 'CANYON', 'Canyon'),
			(497, 25, 'ENVOY', 'Envoy'),
			(498, 25, 'ENVOYXL', 'Envoy XL'),
			(499, 25, 'ENVOYXUV', 'Envoy XUV'),
			(500, 25, 'JIM', 'Jimmy'),
			(501, 25, 'RALLYWAG', 'Rally Wagon'),
			(502, 25, 'GMCS15', 'S15 Jimmy'),
			(503, 25, 'S15', 'S15 Pickup'),
			(504, 25, 'SAFARIGMC', 'Safari'),
			(505, 25, 'GMCSAVANA', 'Savana'),
			(506, 25, '15SIPU4WD', 'Sierra C/K1500'),
			(507, 25, 'GMCC25PU', 'Sierra C/K2500'),
			(508, 25, 'GMC3500PU', 'Sierra C/K3500'),
			(509, 25, 'SONOMA', 'Sonoma'),
			(510, 25, 'SUB', 'Suburban'),
			(511, 25, 'GMCSYCLON', 'Syclone'),
			(512, 25, 'TERRAIN', 'Terrain'),
			(513, 25, 'TOPC4500', 'TopKick C4500'),
			(514, 25, 'TYPH', 'Typhoon'),
			(515, 25, 'GMCVANDUR', 'Vandura'),
			(516, 25, 'YUKON', 'Yukon'),
			(517, 25, 'YUKONXL', 'Yukon XL'),
			(518, 25, 'GMCOTH', 'Other GMC Models'),
			(519, 26, 'ACCORD', 'Accord'),
			(520, 26, 'CIVIC', 'Civic'),
			(521, 26, 'CRV', 'CR-V'),
			(522, 26, 'CRZ', 'CR-Z'),
			(523, 26, 'CRX', 'CRX'),
			(524, 26, 'CROSSTOUR_MODELS', 'Crosstour and Accord Crosstour Models (2)'),
			(525, 26, 'CROSSTOUR', ' - Accord Crosstour'),
			(526, 26, 'HONCROSS', ' - Crosstour'),
			(527, 26, 'HONDELSOL', 'Del Sol'),
			(528, 26, 'ELEMENT', 'Element'),
			(529, 26, 'FIT', 'Fit'),
			(530, 26, 'INSIGHT', 'Insight'),
			(531, 26, 'ODYSSEY', 'Odyssey'),
			(532, 26, 'PASSPO', 'Passport'),
			(533, 26, 'PILOT', 'Pilot'),
			(534, 26, 'PRE', 'Prelude'),
			(535, 26, 'RIDGELINE', 'Ridgeline'),
			(536, 26, 'S2000', 'S2000'),
			(537, 26, 'HONOTH', 'Other Honda Models'),
			(538, 27, 'HUMMER', 'H1'),
			(539, 27, 'H2', 'H2'),
			(540, 27, 'H3', 'H3'),
			(541, 27, 'H3T', 'H3T'),
			(542, 27, 'AMGOTH', 'Other Hummer Models'),
			(543, 28, 'ACCENT', 'Accent'),
			(544, 28, 'AZERA', 'Azera'),
			(545, 28, 'ELANTR', 'Elantra'),
			(546, 28, 'HYUELANCPE', 'Elantra Coupe'),
			(547, 28, 'ELANTOUR', 'Elantra Touring'),
			(548, 28, 'ENTOURAGE', 'Entourage'),
			(549, 28, 'EQUUS', 'Equus'),
			(550, 28, 'HYUEXCEL', 'Excel'),
			(551, 28, 'GENESIS', 'Genesis'),
			(552, 28, 'GENESISCPE', 'Genesis Coupe'),
			(553, 28, 'SANTAFE', 'Santa Fe'),
			(554, 28, 'SCOUPE', 'Scoupe'),
			(555, 28, 'SONATA', 'Sonata'),
			(556, 28, 'TIBURO', 'Tiburon'),
			(557, 28, 'TUCSON', 'Tucson'),
			(558, 28, 'VELOSTER', 'Veloster'),
			(559, 28, 'VERACRUZ', 'Veracruz'),
			(560, 28, 'XG300', 'XG300'),
			(561, 28, 'XG350', 'XG350'),
			(562, 28, 'HYUOTH', 'Other Hyundai Models'),
			(563, 29, 'EX_MODELS', 'EX Models (2)'),
			(564, 29, 'EX35', ' - EX35'),
			(565, 29, 'EX37', ' - EX37'),
			(566, 29, 'FX_MODELS', 'FX Models (4)'),
			(567, 29, 'FX35', ' - FX35'),
			(568, 29, 'FX37', ' - FX37'),
			(569, 29, 'FX45', ' - FX45'),
			(570, 29, 'FX50', ' - FX50'),
			(571, 29, 'G_MODELS', 'G Models (4)'),
			(572, 29, 'G20', ' - G20'),
			(573, 29, 'G25', ' - G25'),
			(574, 29, 'G35', ' - G35'),
			(575, 29, 'G37', ' - G37'),
			(576, 29, 'I_MODELS', 'I Models (2)'),
			(577, 29, 'I30', ' - I30'),
			(578, 29, 'I35', ' - I35'),
			(579, 29, 'J_MODELS', 'J Models (1)'),
			(580, 29, 'J30', ' - J30'),
			(581, 29, 'JX_MODELS', 'JX Models (1)'),
			(582, 29, 'JX35', ' - JX35'),
			(583, 29, 'M_MODELS', 'M Models (6)'),
			(584, 29, 'M30', ' - M30'),
			(585, 29, 'M35', ' - M35'),
			(586, 29, 'M35HYBRID', ' - M35h'),
			(587, 29, 'M37', ' - M37'),
			(588, 29, 'M45', ' - M45'),
			(589, 29, 'M56', ' - M56'),
			(590, 29, 'Q_MODELS', 'Q Models (1)'),
			(591, 29, 'Q45', ' - Q45'),
			(592, 29, 'QX_MODELS', 'QX Models (2)'),
			(593, 29, 'QX4', ' - QX4'),
			(594, 29, 'QX56', ' - QX56'),
			(595, 29, 'INFOTH', 'Other Infiniti Models'),
			(596, 30, 'AMIGO', 'Amigo'),
			(597, 30, 'ASCENDER', 'Ascender'),
			(598, 30, 'AXIOM', 'Axiom'),
			(599, 30, 'HOMBRE', 'Hombre'),
			(600, 30, 'I280', 'i-280'),
			(601, 30, 'I290', 'i-290'),
			(602, 30, 'I350', 'i-350'),
			(603, 30, 'I370', 'i-370'),
			(604, 30, 'ISUMARK', 'I-Mark'),
			(605, 30, 'ISUIMP', 'Impulse'),
			(606, 30, 'OASIS', 'Oasis'),
			(607, 30, 'ISUPU', 'Pickup'),
			(608, 30, 'RODEO', 'Rodeo'),
			(609, 30, 'STYLUS', 'Stylus'),
			(610, 30, 'TROOP', 'Trooper'),
			(611, 30, 'TRP2', 'Trooper II'),
			(612, 30, 'VEHICROSS', 'VehiCROSS'),
			(613, 30, 'ISUOTH', 'Other Isuzu Models'),
			(614, 31, 'STYPE', 'S-Type'),
			(615, 31, 'XTYPE', 'X-Type'),
			(616, 31, 'XF', 'XF'),
			(617, 31, 'XJ_SERIES', 'XJ Series (10)'),
			(618, 31, 'JAGXJ12', ' - XJ12'),
			(619, 31, 'JAGXJ6', ' - XJ6'),
			(620, 31, 'JAGXJR', ' - XJR'),
			(621, 31, 'JAGXJRS', ' - XJR-S'),
			(622, 31, 'JAGXJS', ' - XJS'),
			(623, 31, 'VANDEN', ' - XJ Vanden Plas'),
			(624, 31, 'XJ', ' - XJ'),
			(625, 31, 'XJ8', ' - XJ8'),
			(626, 31, 'XJ8L', ' - XJ8 L'),
			(627, 31, 'XJSPORT', ' - XJ Sport'),
			(628, 31, 'XK_SERIES', 'XK Series (3)'),
			(629, 31, 'JAGXK8', ' - XK8'),
			(630, 31, 'XK', ' - XK'),
			(631, 31, 'XKR', ' - XKR'),
			(632, 31, 'JAGOTH', 'Other Jaguar Models'),
			(633, 32, 'CHER', 'Cherokee'),
			(634, 32, 'JEEPCJ', 'CJ'),
			(635, 32, 'COMANC', 'Comanche'),
			(636, 32, 'COMMANDER', 'Commander'),
			(637, 32, 'COMPASS', 'Compass'),
			(638, 32, 'JEEPGRAND', 'Grand Cherokee'),
			(639, 32, 'GRWAG', 'Grand Wagoneer'),
			(640, 32, 'LIBERTY', 'Liberty'),
			(641, 32, 'PATRIOT', 'Patriot'),
			(642, 32, 'JEEPPU', 'Pickup'),
			(643, 32, 'SCRAMBLE', 'Scrambler'),
			(644, 32, 'WAGONE', 'Wagoneer'),
			(645, 32, 'WRANGLER', 'Wrangler'),
			(646, 32, 'JEOTH', 'Other Jeep Models'),
			(647, 33, 'AMANTI', 'Amanti'),
			(648, 33, 'BORREGO', 'Borrego'),
			(649, 33, 'FORTE', 'Forte'),
			(650, 33, 'FORTEKOUP', 'Forte Koup'),
			(651, 33, 'OPTIMA', 'Optima'),
			(652, 33, 'RIO', 'Rio'),
			(653, 33, 'RIO5', 'Rio5'),
			(654, 33, 'RONDO', 'Rondo'),
			(655, 33, 'SEDONA', 'Sedona'),
			(656, 33, 'SEPHIA', 'Sephia'),
			(657, 33, 'SORENTO', 'Sorento'),
			(658, 33, 'SOUL', 'Soul'),
			(659, 33, 'SPECTRA', 'Spectra'),
			(660, 33, 'SPECTRA5', 'Spectra5'),
			(661, 33, 'SPORTA', 'Sportage'),
			(662, 33, 'KIAOTH', 'Other Kia Models'),
			(663, 34, 'AVENT', 'Aventador'),
			(664, 34, 'COUNT', 'Countach'),
			(665, 34, 'DIABLO', 'Diablo'),
			(666, 34, 'GALLARDO', 'Gallardo'),
			(667, 34, 'JALPA', 'Jalpa'),
			(668, 34, 'LM002', 'LM002'),
			(669, 34, 'MURCIELAGO', 'Murcielago'),
			(670, 34, 'UNAVAILLAM', 'Other Lamborghini Models'),
			(671, 35, 'BETA', 'Beta'),
			(672, 35, 'ZAGATO', 'Zagato'),
			(673, 35, 'UNAVAILLAN', 'Other Lancia Models'),
			(674, 36, 'DEFEND', 'Defender'),
			(675, 36, 'DISCOV', 'Discovery'),
			(676, 36, 'FRELNDR', 'Freelander'),
			(677, 36, 'LR2', 'LR2'),
			(678, 36, 'LR3', 'LR3'),
			(679, 36, 'LR4', 'LR4'),
			(680, 36, 'RANGE', 'Range Rover'),
			(681, 36, 'EVOQUE', 'Range Rover Evoque'),
			(682, 36, 'RANGESPORT', 'Range Rover Sport'),
			(683, 36, 'ROVOTH', 'Other Land Rover Models'),
			(684, 37, 'CT_MODELS', 'CT Models (1)'),
			(685, 37, 'CT200H', ' - CT 200h'),
			(686, 37, 'ES_MODELS', 'ES Models (5)'),
			(687, 37, 'ES250', ' - ES 250'),
			(688, 37, 'ES300', ' - ES 300'),
			(689, 37, 'ES300H', ' - ES 300h'),
			(690, 37, 'ES330', ' - ES 330'),
			(691, 37, 'ES350', ' - ES 350'),
			(692, 37, 'GS_MODELS', 'GS Models (6)'),
			(693, 37, 'GS300', ' - GS 300'),
			(694, 37, 'GS350', ' - GS 350'),
			(695, 37, 'GS400', ' - GS 400'),
			(696, 37, 'GS430', ' - GS 430'),
			(697, 37, 'GS450H', ' - GS 450h'),
			(698, 37, 'GS460', ' - GS 460'),
			(699, 37, 'GX_MODELS', 'GX Models (2)'),
			(700, 37, 'GX460', ' - GX 460'),
			(701, 37, 'GX470', ' - GX 470'),
			(702, 37, 'HS_MODELS', 'HS Models (1)'),
			(703, 37, 'HS250H', ' - HS 250h'),
			(704, 37, 'IS_MODELS', 'IS Models (6)'),
			(705, 37, 'IS250', ' - IS 250'),
			(706, 37, 'IS250C', ' - IS 250C'),
			(707, 37, 'IS300', ' - IS 300'),
			(708, 37, 'IS350', ' - IS 350'),
			(709, 37, 'IS350C', ' - IS 350C'),
			(710, 37, 'ISF', ' - IS F'),
			(711, 37, 'LEXLFA', 'LFA'),
			(712, 37, 'LS_MODELS', 'LS Models (4)'),
			(713, 37, 'LS400', ' - LS 400'),
			(714, 37, 'LS430', ' - LS 430'),
			(715, 37, 'LS460', ' - LS 460'),
			(716, 37, 'LS600H', ' - LS 600h'),
			(717, 37, 'LX_MODELS', 'LX Models (3)'),
			(718, 37, 'LX450', ' - LX 450'),
			(719, 37, 'LX470', ' - LX 470'),
			(720, 37, 'LX570', ' - LX 570'),
			(721, 37, 'RX_MODELS', 'RX Models (5)'),
			(722, 37, 'RX300', ' - RX 300'),
			(723, 37, 'RX330', ' - RX 330'),
			(724, 37, 'RX350', ' - RX 350'),
			(725, 37, 'RX400H', ' - RX 400h'),
			(726, 37, 'RX450H', ' - RX 450h'),
			(727, 37, 'SC_MODELS', 'SC Models (3)'),
			(728, 37, 'SC300', ' - SC 300'),
			(729, 37, 'SC400', ' - SC 400'),
			(730, 37, 'SC430', ' - SC 430'),
			(731, 37, 'LEXOTH', 'Other Lexus Models'),
			(732, 38, 'AVIATOR', 'Aviator'),
			(733, 38, 'BLKWOOD', 'Blackwood'),
			(734, 38, 'CONT', 'Continental'),
			(735, 38, 'LSLINCOLN', 'LS'),
			(736, 38, 'MARKLT', 'Mark LT'),
			(737, 38, 'MARK6', 'Mark VI'),
			(738, 38, 'MARK7', 'Mark VII'),
			(739, 38, 'MARK8', 'Mark VIII'),
			(740, 38, 'MKS', 'MKS'),
			(741, 38, 'MKT', 'MKT'),
			(742, 38, 'MKX', 'MKX'),
			(743, 38, 'MKZ', 'MKZ'),
			(744, 38, 'NAVIGA', 'Navigator'),
			(745, 38, 'NAVIGAL', 'Navigator L'),
			(746, 38, 'LINCTC', 'Town Car'),
			(747, 38, 'ZEPHYR', 'Zephyr'),
			(748, 38, 'LINOTH', 'Other Lincoln Models'),
			(749, 39, 'ELAN', 'Elan'),
			(750, 39, 'LOTELISE', 'Elise'),
			(751, 39, 'ESPRIT', 'Esprit'),
			(752, 39, 'EVORA', 'Evora'),
			(753, 39, 'EXIGE', 'Exige'),
			(754, 39, 'UNAVAILLOT', 'Other Lotus Models'),
			(755, 40, '430', '430'),
			(756, 40, 'BITRBO', 'Biturbo'),
			(757, 40, 'COUPEMAS', 'Coupe'),
			(758, 40, 'GRANSPORT', 'GranSport'),
			(759, 40, 'GRANTURISM', 'GranTurismo'),
			(760, 40, 'QP', 'Quattroporte'),
			(761, 40, 'SPYDER', 'Spyder'),
			(762, 40, 'UNAVAILMAS', 'Other Maserati Models'),
			(763, 41, '57MAYBACH', '57'),
			(764, 41, '62MAYBACH', '62'),
			(765, 41, 'UNAVAILMAY', 'Other Maybach Models'),
			(766, 42, 'MAZDA323', '323'),
			(767, 42, 'MAZDA626', '626'),
			(768, 42, '929', '929'),
			(769, 42, 'B-SERIES', 'B-Series Pickup'),
			(770, 42, 'CX-5', 'CX-5'),
			(771, 42, 'CX-7', 'CX-7'),
			(772, 42, 'CX-9', 'CX-9'),
			(773, 42, 'GLC', 'GLC'),
			(774, 42, 'MAZDA2', 'MAZDA2'),
			(775, 42, 'MAZDA3', 'MAZDA3'),
			(776, 42, 'MAZDA5', 'MAZDA5'),
			(777, 42, 'MAZDA6', 'MAZDA6'),
			(778, 42, 'MAZDASPD3', 'MAZDASPEED3'),
			(779, 42, 'MAZDASPD6', 'MAZDASPEED6'),
			(780, 42, 'MIATA', 'Miata MX5'),
			(781, 42, 'MILL', 'Millenia'),
			(782, 42, 'MPV', 'MPV'),
			(783, 42, 'MX3', 'MX3'),
			(784, 42, 'MX6', 'MX6'),
			(785, 42, 'NAVAJO', 'Navajo'),
			(786, 42, 'PROTE', 'Protege'),
			(787, 42, 'PROTE5', 'Protege5'),
			(788, 42, 'RX7', 'RX-7'),
			(789, 42, 'RX8', 'RX-8'),
			(790, 42, 'TRIBUTE', 'Tribute'),
			(791, 42, 'MAZOTH', 'Other Mazda Models'),
			(792, 43, 'MP4', 'MP4-12C'),
			(793, 44, '190_CLASS', '190 Class (2)'),
			(794, 44, '190D', ' - 190D'),
			(795, 44, '190E', ' - 190E'),
			(796, 44, '240_CLASS', '240 Class (1)'),
			(797, 44, '240D', ' - 240D'),
			(798, 44, '300_CLASS_E_CLASS', '300 Class / E Class (6)'),
			(799, 44, '300CD', ' - 300CD'),
			(800, 44, '300CE', ' - 300CE'),
			(801, 44, '300D', ' - 300D'),
			(802, 44, '300E', ' - 300E'),
			(803, 44, '300TD', ' - 300TD'),
			(804, 44, '300TE', ' - 300TE'),
			(805, 44, 'C_CLASS', 'C Class (13)'),
			(806, 44, 'C220', ' - C220'),
			(807, 44, 'C230', ' - C230'),
			(808, 44, 'C240', ' - C240'),
			(809, 44, 'C250', ' - C250'),
			(810, 44, 'C280', ' - C280'),
			(811, 44, 'C300', ' - C300'),
			(812, 44, 'C320', ' - C320'),
			(813, 44, 'C32AMG', ' - C32 AMG'),
			(814, 44, 'C350', ' - C350'),
			(815, 44, 'C36AMG', ' - C36 AMG'),
			(816, 44, 'C43AMG', ' - C43 AMG'),
			(817, 44, 'C55AMG', ' - C55 AMG'),
			(818, 44, 'C63AMG', ' - C63 AMG'),
			(819, 44, 'CL_CLASS', 'CL Class (6)'),
			(820, 44, 'CL500', ' - CL500'),
			(821, 44, 'CL550', ' - CL550'),
			(822, 44, 'CL55AMG', ' - CL55 AMG'),
			(823, 44, 'CL600', ' - CL600'),
			(824, 44, 'CL63AMG', ' - CL63 AMG'),
			(825, 44, 'CL65AMG', ' - CL65 AMG'),
			(826, 44, 'CLK_CLASS', 'CLK Class (7)'),
			(827, 44, 'CLK320', ' - CLK320'),
			(828, 44, 'CLK350', ' - CLK350'),
			(829, 44, 'CLK430', ' - CLK430'),
			(830, 44, 'CLK500', ' - CLK500'),
			(831, 44, 'CLK550', ' - CLK550'),
			(832, 44, 'CLK55AMG', ' - CLK55 AMG'),
			(833, 44, 'CLK63AMG', ' - CLK63 AMG'),
			(834, 44, 'CLS_CLASS', 'CLS Class (4)'),
			(835, 44, 'CLS500', ' - CLS500'),
			(836, 44, 'CLS550', ' - CLS550'),
			(837, 44, 'CLS55AMG', ' - CLS55 AMG'),
			(838, 44, 'CLS63AMG', ' - CLS63 AMG'),
			(839, 44, 'E_CLASS', 'E Class (18)'),
			(840, 44, '260E', ' - 260E'),
			(841, 44, '280CE', ' - 280CE'),
			(842, 44, '280E', ' - 280E'),
			(843, 44, '400E', ' - 400E'),
			(844, 44, '500E', ' - 500E'),
			(845, 44, 'E300', ' - E300'),
			(846, 44, 'E320', ' - E320'),
			(847, 44, 'E320BLUE', ' - E320 Bluetec'),
			(848, 44, 'E320CDI', ' - E320 CDI'),
			(849, 44, 'E350', ' - E350'),
			(850, 44, 'E350BLUE', ' - E350 Bluetec'),
			(851, 44, 'E400', ' - E400 Hybrid'),
			(852, 44, 'E420', ' - E420'),
			(853, 44, 'E430', ' - E430'),
			(854, 44, 'E500', ' - E500'),
			(855, 44, 'E550', ' - E550'),
			(856, 44, 'E55AMG', ' - E55 AMG'),
			(857, 44, 'E63AMG', ' - E63 AMG'),
			(858, 44, 'G_CLASS', 'G Class (4)'),
			(859, 44, 'G500', ' - G500'),
			(860, 44, 'G550', ' - G550'),
			(861, 44, 'G55AMG', ' - G55 AMG'),
			(862, 44, 'G63AMG', ' - G63 AMG'),
			(863, 44, 'GL_CLASS', 'GL Class (5)'),
			(864, 44, 'GL320BLUE', ' - GL320 Bluetec'),
			(865, 44, 'GL320CDI', ' - GL320 CDI'),
			(866, 44, 'GL350BLUE', ' - GL350 Bluetec'),
			(867, 44, 'GL450', ' - GL450'),
			(868, 44, 'GL550', ' - GL550'),
			(869, 44, 'GLK_CLASS', 'GLK Class (1)'),
			(870, 44, 'GLK350', ' - GLK350'),
			(871, 44, 'M_CLASS', 'M Class (11)'),
			(872, 44, 'ML320', ' - ML320'),
			(873, 44, 'ML320BLUE', ' - ML320 Bluetec'),
			(874, 44, 'ML320CDI', ' - ML320 CDI'),
			(875, 44, 'ML350', ' - ML350'),
			(876, 44, 'ML350BLUE', ' - ML350 Bluetec'),
			(877, 44, 'ML430', ' - ML430'),
			(878, 44, 'ML450HY', ' - ML450 Hybrid'),
			(879, 44, 'ML500', ' - ML500'),
			(880, 44, 'ML550', ' - ML550'),
			(881, 44, 'ML55AMG', ' - ML55 AMG'),
			(882, 44, 'ML63AMG', ' - ML63 AMG'),
			(883, 44, 'R_CLASS', 'R Class (6)'),
			(884, 44, 'R320BLUE', ' - R320 Bluetec'),
			(885, 44, 'R320CDI', ' - R320 CDI'),
			(886, 44, 'R350', ' - R350'),
			(887, 44, 'R350BLUE', ' - R350 Bluetec'),
			(888, 44, 'R500', ' - R500'),
			(889, 44, 'R63AMG', ' - R63 AMG'),
			(890, 44, 'S_CLASS', 'S Class (30)'),
			(891, 44, '300SD', ' - 300SD'),
			(892, 44, '300SDL', ' - 300SDL'),
			(893, 44, '300SE', ' - 300SE'),
			(894, 44, '300SEL', ' - 300SEL'),
			(895, 44, '350SD', ' - 350SD'),
			(896, 44, '350SDL', ' - 350SDL'),
			(897, 44, '380SE', ' - 380SE'),
			(898, 44, '380SEC', ' - 380SEC'),
			(899, 44, '380SEL', ' - 380SEL'),
			(900, 44, '400SE', ' - 400SE'),
			(901, 44, '400SEL', ' - 400SEL'),
			(902, 44, '420SEL', ' - 420SEL'),
			(903, 44, '500SEC', ' - 500SEC'),
			(904, 44, '500SEL', ' - 500SEL'),
			(905, 44, '560SEC', ' - 560SEC'),
			(906, 44, '560SEL', ' - 560SEL'),
			(907, 44, '600SEC', ' - 600SEC'),
			(908, 44, '600SEL', ' - 600SEL'),
			(909, 44, 'S320', ' - S320'),
			(910, 44, 'S350', ' - S350'),
			(911, 44, 'S350BLUE', ' - S350 Bluetec'),
			(912, 44, 'S400HY', ' - S400 Hybrid'),
			(913, 44, 'S420', ' - S420'),
			(914, 44, 'S430', ' - S430'),
			(915, 44, 'S500', ' - S500'),
			(916, 44, 'S550', ' - S550'),
			(917, 44, 'S55AMG', ' - S55 AMG'),
			(918, 44, 'S600', ' - S600'),
			(919, 44, 'S63AMG', ' - S63 AMG'),
			(920, 44, 'S65AMG', ' - S65 AMG'),
			(921, 44, 'SL_CLASS', 'SL Class (13)'),
			(922, 44, '300SL', ' - 300SL'),
			(923, 44, '380SL', ' - 380SL'),
			(924, 44, '380SLC', ' - 380SLC'),
			(925, 44, '500SL', ' - 500SL'),
			(926, 44, '560SL', ' - 560SL'),
			(927, 44, '600SL', ' - 600SL'),
			(928, 44, 'SL320', ' - SL320'),
			(929, 44, 'SL500', ' - SL500'),
			(930, 44, 'SL550', ' - SL550'),
			(931, 44, 'SL55AMG', ' - SL55 AMG'),
			(932, 44, 'SL600', ' - SL600'),
			(933, 44, 'SL63AMG', ' - SL63 AMG'),
			(934, 44, 'SL65AMG', ' - SL65 AMG'),
			(935, 44, 'SLK_CLASS', 'SLK Class (8)'),
			(936, 44, 'SLK230', ' - SLK230'),
			(937, 44, 'SLK250', ' - SLK250'),
			(938, 44, 'SLK280', ' - SLK280'),
			(939, 44, 'SLK300', ' - SLK300'),
			(940, 44, 'SLK320', ' - SLK320'),
			(941, 44, 'SLK32AMG', ' - SLK32 AMG'),
			(942, 44, 'SLK350', ' - SLK350'),
			(943, 44, 'SLK55AMG', ' - SLK55 AMG'),
			(944, 44, 'SLR_CLASS', 'SLR Class (1)'),
			(945, 44, 'SLR', ' - SLR'),
			(946, 44, 'SLS_CLASS', 'SLS Class (1)'),
			(947, 44, 'SLSAMG', ' - SLS AMG'),
			(948, 44, 'SPRINTER_CLASS', 'Sprinter Class (1)'),
			(949, 44, 'MBSPRINTER', ' - Sprinter'),
			(950, 44, 'MBOTH', 'Other Mercedes-Benz Models'),
			(951, 45, 'CAPRI', 'Capri'),
			(952, 45, 'COUGAR', 'Cougar'),
			(953, 45, 'MERCGRAND', 'Grand Marquis'),
			(954, 45, 'LYNX', 'Lynx'),
			(955, 45, 'MARAUDER', 'Marauder'),
			(956, 45, 'MARINER', 'Mariner'),
			(957, 45, 'MARQ', 'Marquis'),
			(958, 45, 'MILAN', 'Milan'),
			(959, 45, 'MONTEGO', 'Montego'),
			(960, 45, 'MONTEREY', 'Monterey'),
			(961, 45, 'MOUNTA', 'Mountaineer'),
			(962, 45, 'MYSTIQ', 'Mystique'),
			(963, 45, 'SABLE', 'Sable'),
			(964, 45, 'TOPAZ', 'Topaz'),
			(965, 45, 'TRACER', 'Tracer'),
			(966, 45, 'VILLA', 'Villager'),
			(967, 45, 'MERCZEP', 'Zephyr'),
			(968, 45, 'MEOTH', 'Other Mercury Models'),
			(969, 46, 'SCORP', 'Scorpio'),
			(970, 46, 'XR4TI', 'XR4Ti'),
			(971, 46, 'MEROTH', 'Other Merkur Models'),
			(972, 47, 'COOPRCLUB_MODELS', 'Cooper Clubman Models (2)'),
			(973, 47, 'COOPERCLUB', ' - Cooper Clubman'),
			(974, 47, 'COOPRCLUBS', ' - Cooper S Clubman'),
			(975, 47, 'COOPCOUNTRY_MODELS', 'Cooper Countryman Models (2)'),
			(976, 47, 'COUNTRYMAN', ' - Cooper Countryman'),
			(977, 47, 'COUNTRYMNS', ' - Cooper S Countryman'),
			(978, 47, 'COOPCOUP_MODELS', 'Cooper Coupe Models (2)'),
			(979, 47, 'MINICOUPE', ' - Cooper Coupe'),
			(980, 47, 'MINISCOUPE', ' - Cooper S Coupe'),
			(981, 47, 'COOPER_MODELS', 'Cooper Models (2)'),
			(982, 47, 'COOPER', ' - Cooper'),
			(983, 47, 'COOPERS', ' - Cooper S'),
			(984, 47, 'COOPRROAD_MODELS', 'Cooper Roadster Models (2)'),
			(985, 47, 'COOPERROAD', ' - Cooper Roadster'),
			(986, 47, 'COOPERSRD', ' - Cooper S Roadster'),
			(987, 48, '3000GT', '3000GT'),
			(988, 48, 'CORD', 'Cordia'),
			(989, 48, 'DIAMAN', 'Diamante'),
			(990, 48, 'ECLIP', 'Eclipse'),
			(991, 48, 'ENDEAVOR', 'Endeavor'),
			(992, 48, 'MITEXP', 'Expo'),
			(993, 48, 'GALANT', 'Galant'),
			(994, 48, 'MITI', 'i'),
			(995, 48, 'LANCERMITS', 'Lancer'),
			(996, 48, 'LANCEREVO', 'Lancer Evolution'),
			(997, 48, 'MITPU', 'Mighty Max'),
			(998, 48, 'MIRAGE', 'Mirage'),
			(999, 48, 'MONT', 'Montero')

			 Insert into Modelos (noUso, fabricante_id, codigo, modelo) VALUES
			(1000, 48, 'MONTSPORT', 'Montero Sport'),
			(1001, 48, 'OUTLANDER', 'Outlander'),
			(1002, 48, 'OUTLANDSPT', 'Outlander Sport'),
			(1003, 48, 'PRECIS', 'Precis'),
			(1004, 48, 'RAIDERMITS', 'Raider'),
			(1005, 48, 'SIGMA', 'Sigma'),
			(1006, 48, 'MITSTAR', 'Starion'),
			(1007, 48, 'TRED', 'Tredia'),
			(1008, 48, 'MITVAN', 'Van'),
			(1009, 48, 'MITOTH', 'Other Mitsubishi Models'),
			(1010, 49, 'NIS200SX', '200SX'),
			(1011, 49, '240SX', '240SX'),
			(1012, 49, '300ZXTURBO', '300ZX'),
			(1013, 49, '350Z', '350Z'),
			(1014, 49, '370Z', '370Z'),
			(1015, 49, 'ALTIMA', 'Altima'),
			(1016, 49, 'PATHARMADA', 'Armada'),
			(1017, 49, 'AXXESS', 'Axxess'),
			(1018, 49, 'CUBE', 'Cube'),
			(1019, 49, 'FRONTI', 'Frontier'),
			(1020, 49, 'GT-R', 'GT-R'),
			(1021, 49, 'JUKE', 'Juke'),
			(1022, 49, 'LEAF', 'Leaf'),
			(1023, 49, 'MAX', 'Maxima'),
			(1024, 49, 'MURANO', 'Murano'),
			(1025, 49, 'MURANOCROS', 'Murano CrossCabriolet'),
			(1026, 49, 'NV', 'NV'),
			(1027, 49, 'NX', 'NX'),
			(1028, 49, 'PATH', 'Pathfinder'),
			(1029, 49, 'NISPU', 'Pickup'),
			(1030, 49, 'PULSAR', 'Pulsar'),
			(1031, 49, 'QUEST', 'Quest'),
			(1032, 49, 'ROGUE', 'Rogue'),
			(1033, 49, 'SENTRA', 'Sentra'),
			(1034, 49, 'STANZA', 'Stanza'),
			(1035, 49, 'TITAN', 'Titan'),
			(1036, 49, 'NISVAN', 'Van'),
			(1037, 49, 'VERSA', 'Versa'),
			(1038, 49, 'XTERRA', 'Xterra'),
			(1039, 49, 'NISSOTH', 'Other Nissan Models'),
			(1040, 50, '88', '88'),
			(1041, 50, 'ACHIEV', 'Achieva'),
			(1042, 50, 'ALERO', 'Alero'),
			(1043, 50, 'AURORA', 'Aurora'),
			(1044, 50, 'BRAV', 'Bravada'),
			(1045, 50, 'CUCR', 'Custom Cruiser'),
			(1046, 50, 'OLDCUS', 'Cutlass'),
			(1047, 50, 'OLDCALAIS', 'Cutlass Calais'),
			(1048, 50, 'CIERA', 'Cutlass Ciera'),
			(1049, 50, 'CSUPR', 'Cutlass Supreme'),
			(1050, 50, 'OLDSFIR', 'Firenza'),
			(1051, 50, 'INTRIG', 'Intrigue'),
			(1052, 50, '98', 'Ninety-Eight'),
			(1053, 50, 'OMEG', 'Omega'),
			(1054, 50, 'REGEN', 'Regency'),
			(1055, 50, 'SILHO', 'Silhouette'),
			(1056, 50, 'TORO', 'Toronado'),
			(1057, 50, 'OLDOTH', 'Other Oldsmobile Models'),
			(1058, 51, '405', '405'),
			(1059, 51, '504', '504'),
			(1060, 51, '505', '505'),
			(1061, 51, '604', '604'),
			(1062, 51, 'UNAVAILPEU', 'Other Peugeot Models'),
			(1063, 52, 'ACC', 'Acclaim'),
			(1064, 52, 'ARROW', 'Arrow'),
			(1065, 52, 'BREEZE', 'Breeze'),
			(1066, 52, 'CARAVE', 'Caravelle'),
			(1067, 52, 'CHAMP', 'Champ'),
			(1068, 52, 'COLT', 'Colt'),
			(1069, 52, 'PLYMCONQ', 'Conquest'),
			(1070, 52, 'GRANFURY', 'Gran Fury'),
			(1071, 52, 'PLYMGRANV', 'Grand Voyager'),
			(1072, 52, 'HORI', 'Horizon'),
			(1073, 52, 'LASER', 'Laser'),
			(1074, 52, 'NEON', 'Neon'),
			(1075, 52, 'PROWLE', 'Prowler'),
			(1076, 52, 'RELI', 'Reliant'),
			(1077, 52, 'SAPPOROPLY', 'Sapporo'),
			(1078, 52, 'SCAMP', 'Scamp'),
			(1079, 52, 'SUNDAN', 'Sundance'),
			(1080, 52, 'TRAILDUST', 'Trailduster'),
			(1081, 52, 'VOYA', 'Voyager'),
			(1082, 52, 'PLYOTH', 'Other Plymouth Models'),
			(1083, 53, 'T-1000', '1000'),
			(1084, 53, '6000', '6000'),
			(1085, 53, 'AZTEK', 'Aztek'),
			(1086, 53, 'BON', 'Bonneville'),
			(1087, 53, 'CATALINA', 'Catalina'),
			(1088, 53, 'FIERO', 'Fiero'),
			(1089, 53, 'FBIRD', 'Firebird'),
			(1090, 53, 'G3', 'G3'),
			(1091, 53, 'G5', 'G5'),
			(1092, 53, 'G6', 'G6'),
			(1093, 53, 'G8', 'G8'),
			(1094, 53, 'GRNDAM', 'Grand Am'),
			(1095, 53, 'GP', 'Grand Prix'),
			(1096, 53, 'GTO', 'GTO'),
			(1097, 53, 'J2000', 'J2000'),
			(1098, 53, 'LEMANS', 'Le Mans'),
			(1099, 53, 'MONTANA', 'Montana'),
			(1100, 53, 'PARISI', 'Parisienne'),
			(1101, 53, 'PHOENIX', 'Phoenix'),
			(1102, 53, 'SAFARIPONT', 'Safari'),
			(1103, 53, 'SOLSTICE', 'Solstice'),
			(1104, 53, 'SUNBIR', 'Sunbird'),
			(1105, 53, 'SUNFIR', 'Sunfire'),
			(1106, 53, 'TORRENT', 'Torrent'),
			(1107, 53, 'TS', 'Trans Sport'),
			(1108, 53, 'VIBE', 'Vibe'),
			(1109, 53, 'PONOTH', 'Other Pontiac Models'),
			(1110, 54, '911', '911'),
			(1111, 54, '924', '924'),
			(1112, 54, '928', '928'),
			(1113, 54, '944', '944'),
			(1114, 54, '968', '968'),
			(1115, 54, 'BOXSTE', 'Boxster'),
			(1116, 54, 'CARRERAGT', 'Carrera GT'),
			(1117, 54, 'CAYENNE', 'Cayenne'),
			(1118, 54, 'CAYMAN', 'Cayman'),
			(1119, 54, 'PANAMERA', 'Panamera'),
			(1120, 54, 'POROTH', 'Other Porsche Models'),
			(1121, 55, 'RAM1504WD', '1500'),
			(1122, 55, 'RAM25002WD', '2500'),
			(1123, 55, 'RAM3502WD', '3500'),
			(1124, 55, 'RAM4500', '4500'),
			(1125, 56, '18I', '18i'),
			(1126, 56, 'FU', 'Fuego'),
			(1127, 56, 'LECAR', 'Le Car'),
			(1128, 56, 'R18', 'R18'),
			(1129, 56, 'RENSPORT', 'Sportwagon'),
			(1130, 56, 'UNAVAILREN', 'Other Renault Models'),
			(1131, 57, 'CAMAR', 'Camargue'),
			(1132, 57, 'CORN', 'Corniche'),
			(1133, 57, 'GHOST', 'Ghost'),
			(1134, 57, 'PARKWARD', 'Park Ward'),
			(1135, 57, 'PHANT', 'Phantom'),
			(1136, 57, 'DAWN', 'Silver Dawn'),
			(1137, 57, 'SILSERAPH', 'Silver Seraph'),
			(1138, 57, 'RRSPIR', 'Silver Spirit'),
			(1139, 57, 'SPUR', 'Silver Spur'),
			(1140, 57, 'UNAVAILRR', 'Other Rolls-Royce Models'),
			(1141, 58, '9-2X', '9-2X'),
			(1142, 58, '9-3', '9-3'),
			(1143, 58, '9-4X', '9-4X'),
			(1144, 58, '9-5', '9-5'),
			(1145, 58, '97X', '9-7X'),
			(1146, 58, '900', '900'),
			(1147, 58, '9000', '9000'),
			(1148, 58, 'SAOTH', 'Other Saab Models'),
			(1149, 59, 'ASTRA', 'Astra'),
			(1150, 59, 'AURA', 'Aura'),
			(1151, 59, 'ION', 'ION'),
			(1152, 59, 'L_SERIES', 'L Series (3)'),
			(1153, 59, 'L100', ' - L100'),
			(1154, 59, 'L200', ' - L200'),
			(1155, 59, 'L300', ' - L300'),
			(1156, 59, 'LSSATURN', 'LS'),
			(1157, 59, 'LW_SERIES', 'LW Series (4)'),
			(1158, 59, 'LW', ' - LW1'),
			(1159, 59, 'LW2', ' - LW2'),
			(1160, 59, 'LW200', ' - LW200'),
			(1161, 59, 'LW300', ' - LW300'),
			(1162, 59, 'OUTLOOK', 'Outlook'),
			(1163, 59, 'RELAY', 'Relay'),
			(1164, 59, 'SC_SERIES', 'SC Series (2)'),
			(1165, 59, 'SC1', ' - SC1'),
			(1166, 59, 'SC2', ' - SC2'),
			(1167, 59, 'SKY', 'Sky'),
			(1168, 59, 'SL_SERIES', 'SL Series (3)'),
			(1169, 59, 'SL', ' - SL'),
			(1170, 59, 'SL1', ' - SL1'),
			(1171, 59, 'SL2', ' - SL2'),
			(1172, 59, 'SW_SERIES', 'SW Series (2)'),
			(1173, 59, 'SW1', ' - SW1'),
			(1174, 59, 'SW2', ' - SW2'),
			(1175, 59, 'VUE', 'Vue'),
			(1176, 59, 'SATOTH', 'Other Saturn Models'),
			(1177, 60, 'SCIFRS', 'FR-S'),
			(1178, 60, 'IQ', 'iQ'),
			(1179, 60, 'TC', 'tC'),
			(1180, 60, 'XA', 'xA'),
			(1181, 60, 'XB', 'xB'),
			(1182, 60, 'XD', 'xD'),
			(1183, 61, 'FORTWO', 'fortwo'),
			(1184, 61, 'SMOTH', 'Other smart Models'),
			(1185, 62, 'SRTVIPER', 'Viper'),
			(1186, 63, '825', '825'),
			(1187, 63, '827', '827'),
			(1188, 63, 'UNAVAILSTE', 'Other Sterling Models'),
			(1189, 64, 'BAJA', 'Baja'),
			(1190, 64, 'BRAT', 'Brat'),
			(1191, 64, 'SUBBRZ', 'BRZ'),
			(1192, 64, 'FOREST', 'Forester'),
			(1193, 64, 'IMPREZ', 'Impreza'),
			(1194, 64, 'IMPWRX', 'Impreza WRX'),
			(1195, 64, 'JUSTY', 'Justy'),
			(1196, 64, 'SUBL', 'L Series'),
			(1197, 64, 'LEGACY', 'Legacy'),
			(1198, 64, 'LOYALE', 'Loyale'),
			(1199, 64, 'SUBOUTBK', 'Outback'),
			(1200, 64, 'SVX', 'SVX'),
			(1201, 64, 'B9TRIBECA', 'Tribeca'),
			(1202, 64, 'XT', 'XT'),
			(1203, 64, 'XVCRSSTREK', 'XV Crosstrek'),
			(1204, 64, 'SUBOTH', 'Other Subaru Models'),
			(1205, 65, 'AERIO', 'Aerio'),
			(1206, 65, 'EQUATOR', 'Equator'),
			(1207, 65, 'ESTEEM', 'Esteem'),
			(1208, 65, 'FORENZA', 'Forenza'),
			(1209, 65, 'GRANDV', 'Grand Vitara'),
			(1210, 65, 'KIZASHI', 'Kizashi'),
			(1211, 65, 'RENO', 'Reno'),
			(1212, 65, 'SAMUR', 'Samurai'),
			(1213, 65, 'SIDE', 'Sidekick'),
			(1214, 65, 'SWIFT', 'Swift'),
			(1215, 65, 'SX4', 'SX4'),
			(1216, 65, 'VERONA', 'Verona'),
			(1217, 65, 'VITARA', 'Vitara'),
			(1218, 65, 'X90', 'X-90'),
			(1219, 65, 'XL7', 'XL7'),
			(1220, 65, 'SUZOTH', 'Other Suzuki Models'),
			(1221, 66, 'ROADSTER', 'Roadster'),
			(1222, 67, '4RUN', '4Runner'),
			(1223, 67, 'AVALON', 'Avalon'),
			(1224, 67, 'CAMRY', 'Camry'),
			(1225, 67, 'CELICA', 'Celica'),
			(1226, 67, 'COROL', 'Corolla'),
			(1227, 67, 'CORONA', 'Corona'),
			(1228, 67, 'CRESS', 'Cressida'),
			(1229, 67, 'ECHO', 'Echo'),
			(1230, 67, 'FJCRUIS', 'FJ Cruiser'),
			(1231, 67, 'HIGHLANDER', 'Highlander'),
			(1232, 67, 'LC', 'Land Cruiser'),
			(1233, 67, 'MATRIX', 'Matrix'),
			(1234, 67, 'MR2', 'MR2'),
			(1235, 67, 'MR2SPYDR', 'MR2 Spyder'),
			(1236, 67, 'PASEO', 'Paseo'),
			(1237, 67, 'PICKUP', 'Pickup'),
			(1238, 67, 'PREVIA', 'Previa'),
			(1239, 67, 'PRIUS', 'Prius'),
			(1240, 67, 'PRIUSC', 'Prius C'),
			(1241, 67, 'PRIUSV', 'Prius V'),
			(1242, 67, 'RAV4', 'RAV4'),
			(1243, 67, 'SEQUOIA', 'Sequoia'),
			(1244, 67, 'SIENNA', 'Sienna'),
			(1245, 67, 'SOLARA', 'Solara'),
			(1246, 67, 'STARLET', 'Starlet'),
			(1247, 67, 'SUPRA', 'Supra'),
			(1248, 67, 'T100', 'T100'),
			(1249, 67, 'TACOMA', 'Tacoma'),
			(1250, 67, 'TERCEL', 'Tercel'),
			(1251, 67, 'TUNDRA', 'Tundra'),
			(1252, 67, 'TOYVAN', 'Van'),
			(1253, 67, 'VENZA', 'Venza'),
			(1254, 67, 'YARIS', 'Yaris'),
			(1255, 67, 'TOYOTH', 'Other Toyota Models'),
			(1256, 68, 'TR7', 'TR7'),
			(1257, 68, 'TR8', 'TR8'),
			(1258, 68, 'TRIOTH', 'Other Triumph Models'),
			(1259, 69, 'BEETLE', 'Beetle'),
			(1260, 69, 'VOLKSCAB', 'Cabrio'),
			(1261, 69, 'CAB', 'Cabriolet'),
			(1262, 69, 'CC', 'CC'),
			(1263, 69, 'CORR', 'Corrado'),
			(1264, 69, 'DASHER', 'Dasher'),
			(1265, 69, 'EOS', 'Eos'),
			(1266, 69, 'EUROVAN', 'Eurovan'),
			(1267, 69, 'VOLKSFOX', 'Fox'),
			(1268, 69, 'GLI', 'GLI'),
			(1269, 69, 'GOLFR', 'Golf R'),
			(1270, 69, 'GTI', 'GTI'),
			(1271, 69, 'GOLFANDRABBITMODELS', 'Golf and Rabbit Models (2)'),
			(1272, 69, 'GOLF', ' - Golf'),
			(1273, 69, 'RABBIT', ' - Rabbit'),
			(1274, 69, 'JET', 'Jetta'),
			(1275, 69, 'PASS', 'Passat'),
			(1276, 69, 'PHAETON', 'Phaeton'),
			(1277, 69, 'RABBITPU', 'Pickup'),
			(1278, 69, 'QUAN', 'Quantum'),
			(1279, 69, 'R32', 'R32'),
			(1280, 69, 'ROUTAN', 'Routan'),
			(1281, 69, 'SCIR', 'Scirocco'),
			(1282, 69, 'TIGUAN', 'Tiguan'),
			(1283, 69, 'TOUAREG', 'Touareg'),
			(1284, 69, 'VANAG', 'Vanagon'),
			(1285, 69, 'VWOTH', 'Other Volkswagen Models'),
			(1286, 70, '240', '240'),
			(1287, 70, '260', '260'),
			(1288, 70, '740', '740'),
			(1289, 70, '760', '760'),
			(1290, 70, '780', '780'),
			(1291, 70, '850', '850'),
			(1292, 70, '940', '940'),
			(1293, 70, '960', '960'),
			(1294, 70, 'C30', 'C30'),
			(1295, 70, 'C70', 'C70'),
			(1296, 70, 'S40', 'S40'),
			(1297, 70, 'S60', 'S60'),
			(1298, 70, 'S70', 'S70'),
			(1299, 70, 'S80', 'S80'),
			(1300, 70, 'S90', 'S90'),
			(1301, 70, 'V40', 'V40'),
			(1302, 70, 'V50', 'V50'),
			(1303, 70, 'V70', 'V70'),
			(1304, 70, 'V90', 'V90'),
			(1305, 70, 'XC60', 'XC60'),
			(1306, 70, 'XC', 'XC70'),
			(1307, 70, 'XC90', 'XC90'),
			(1308, 70, 'VOLOTH', 'Other Volvo Models'),
			(1309, 71, 'GV', 'GV'),
			(1310, 71, 'GVC', 'GVC'),
			(1311, 71, 'GVL', 'GVL'),
			(1312, 71, 'GVS', 'GVS'),
			(1313, 71, 'GVX', 'GVX'),
			(1314, 71, 'YUOTH', 'Other Yugo Models');
		end
		
		if not exists(select * from Usuarios where id = 1)
			begin
				insert into Usuarios(usuario, clave, nombreApellido, tasaDolar, crearUsuarios, fabricantesModelos, piezasRepuestos,
				crearTaller, crearPropietarios, crearClientes, crearGastos, importarVehiculo, compras, cambiarEstadosVehiculo,
				agreagarGastos, agregarPiezas, facturacion, reportes, modificarVehiculo, cuentasCobrar, cuentasPagar, actualizarDiarioTasa) 
				VALUES ('admin','admin', 'Administrador Sistema',1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,0)
			
			end

		if not exists(select * from TiposPago where id = 1)
			begin
				insert into TiposPago (formaPago)
				VALUES('EFECTIVO'),('VEHICULO RECIBIDO'), ('CREDITO'),('OTRO');

			end
		if not exists(select * from TiposCuenta where id = 1)
			begin
				insert into TiposCuenta (tipoCuenta)
				VALUES('CUENTA POR PAGAR'),('CUENTA POR COBRAR');

			end
		if not exists(select * from SerialKeyActivation where id = 1)
			begin
				insert into SerialKeyActivation(fechaActivacion, fechaVencimiento)
				VALUES(GETDATE(),GETDATE())

			end
		if not exists(select * from TasaDolar where id = 1)
			begin
				insert into TasaDolar(tasaDolar, fechaActualizado)
				VALUES(47 ,DATEADD(day,-1,GETDATE()))

			end
		if not exists (select * from TipoTransaccion where id = 1)
			begin
				insert into TipoTransaccion(transaccion)
				Values ('VENTA'),('COMPRA'),('TRASPASO'), ('SEGURO'), ('PIEZAS'),('TALLER MECANICO'), ('OTROS'), ('FACTURA SERVICIOS')

			end
end






GO
/****** Object:  StoredProcedure [dbo].[obtener_ciudades_activos]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

	create procedure [dbo].[obtener_ciudades_activos]
	@idPais int
	as
	
	begin
		select id as ID, ciudad as CIUDAD, estado as ESTADO from Ciudades  where estado = 1 and idPais = @idPais
	end




GO
/****** Object:  StoredProcedure [dbo].[obtener_clientes_activos]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[obtener_clientes_activos]

as


begin

	select id as ID, cliente as CLIENTE, rnc_cedula as 'RNC/CEDULA', telefono as 'TEL.', estado as HABILITADO
	from Clientes
	where estado = 1
	
end






GO
/****** Object:  StoredProcedure [dbo].[obtener_cobros_credito_vehiculo]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[obtener_cobros_credito_vehiculo]
@idCC int
as

begin
	
			select format (PCC.fecha, 'dd/MM/yyyy') as 'FECHA PAGO', TP.formaPago as 'TIPO PAGO',PCC.monto_rd as 'PAGADO ($RD)', PCC.monto_usd as 'PAGADO ($USD)',
			PCC.nota as 'NOTA'
			from
			PagosCuentasCobrar PCC join TiposPago TP on TP.id = PCC.id_tipoPago
			where
			PCC.id_cuentaCobrar= @idCC
		
end



GO
/****** Object:  StoredProcedure [dbo].[obtener_cobros_vehiculo]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[obtener_cobros_vehiculo]
@idVehiculo int, @idTransaccion int
as


begin
	select Format(V.fecha_importe,'dd/MM/yyyy') as 'FECHA DE PAGO', TP.formaPago as 'TIPO PAGO' ,
	FV.monto_rd as 'PAGO($RD)', FV.monto_usd as 'PAGO($USD)', FV.nota as 'DETALLE'
	from FormaVentaVehiculo FV join Vehiculos V on V.id = FV.id_vehiculo join TiposPago TP on TP.id = FV.id_tipo_pago
	where FV.id_vehiculo = @idVehiculo and FV.id_transaccion = @idTransaccion 
	
end






GO
/****** Object:  StoredProcedure [dbo].[obtener_colores_activos]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

	create procedure [dbo].[obtener_colores_activos]
	as
	
	begin
		select id as ID, color as COLOR, estado as ESTADO from Colores  where estado = 1
	end




GO
/****** Object:  StoredProcedure [dbo].[obtener_componentes_vehiculo_FabricanteModeloAño]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[obtener_componentes_vehiculo_FabricanteModeloAño]
@idVehiculo int
as
	declare @idFabricante int 
	declare @idModelo int
	declare @año int

	set @idFabricante = (select fabricante_id from Vehiculos Where id = @idVehiculo)
	set @idModelo = (select modelo_id from Vehiculos Where id = @idVehiculo)
	set @año = (select año from Vehiculos Where id = @idVehiculo)
begin
	
	select componente as COMPONENTES, id as ID, precio_rd as 'PRECIO ($RD)', precio_usd as 'PRECIO ($USD)'
	from Componentes 
	where fabricante_id = @idFabricante and modelo_id = @idModelo and año = @año and estado = 1	
end






GO
/****** Object:  StoredProcedure [dbo].[obtener_costo_chasis_vehiculo]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[obtener_costo_chasis_vehiculo]
@idVehiculo int
as

begin
	
	select V.vin as VIN, 
	(V.total_invertido_rd) as COSTORD,
	(V.total_invertido_usd) as COSTOUSD,
	V.precio_estimado_rd as 'PRECIO VENTA ESTIMADO RD',
	V.precio_estimado_usd as 'PRECIO VENTA ESTIMADO USD'
	from  Vehiculos V where V.id = @idVehiculo
	
end



GO
/****** Object:  StoredProcedure [dbo].[obtener_cuentas_por_cobrar]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[obtener_cuentas_por_cobrar]
@cliente varchar(100), @desde date, @hasta date
as

begin
	if @cliente = ''
		begin

			select  V.id as IDVEHICULO, CC.fecha as  'FECHA', TP.transaccion as 'TRANSACCION',C.cliente as CLIENTE,
			CONVERT(varchar(200),(F.fabricante + ' ' + M.modelo + ' ' + CONVERT(varchar(10), V.año) + ' ' + V.color)) as VEHICULO,
			V.vin as CHASIS, 
			CC.balance_rd as 'PENDIENTE ($RD)', CC.balance_usd as 'PENDIENTE ($USD)',
			ISNULL(DATEDIFF(DAY, format (CC.fecha, 'yyyy-MM-dd'), format (GETDATE(), 'yyyy-MM-dd')), 0) as 'DIAS VIGENTE',
			CC.id as IDCUENTACOBRAR, CC.nueva as NUEVA
			From 
			CuentasCobrar CC join TipoTransaccion TP on TP.id = CC.id_transaccion join Clientes C on CC.id_cliente = C.id
			join Vehiculos V on CC.id_vehiculo = V.id join Fabricantes F on V.fabricante_id = F.id join Modelos M on M.id = V.modelo_id
			where V.vendido = 1 and (CC.balance_rd > 0 and CC.balance_usd > 0) and CC.nueva = 1
			and format(CC.fecha,'yyyy-MM-dd') between
			format (@desde, 'yyyy-MM-dd') and format (@hasta, 'yyyy-MM-dd')

			union

			select  CC.id_vehiculo as IDVEHICULO, CC.fecha as  'FECHA', TP.transaccion as 'TRANSACCION',C.cliente as CLIENTE,
			CONVERT(varchar(200),(F.fabricante + ' ' + M.modelo + ' ' + CONVERT(varchar(10), V.año) + ' ' + V.color)) as VEHICULO,
			V.chasis as CHASIS, 
			CC.balance_rd as 'PENDIENTE ($RD)', CC.balance_usd as 'PENDIENTE ($USD)',
			ISNULL(DATEDIFF(DAY, format (CC.fecha, 'yyyy-MM-dd'), format (GETDATE(), 'yyyy-MM-dd')), 0) as 'DIAS VIGENTE',
			CC.id as IDCUENTACOBRAR, CC.nueva as NUEVA
			From 
			CuentasCobrar CC join TipoTransaccion TP on TP.id = CC.id_transaccion join Clientes C on CC.id_cliente = C.id
			join Detalle_CC_CP_Antiguas V on CC.id = V.id_cuenta join Fabricantes F on V.id_fabricante = F.id join Modelos M on M.id = V.id_modelo
			where V.id_tipo_cuenta = 2 and (CC.balance_rd > 0 and CC.balance_usd > 0) and CC.nueva = 0
			and format(CC.fecha,'yyyy-MM-dd') between
			format (@desde, 'yyyy-MM-dd') and format (@hasta, 'yyyy-MM-dd') 

			order by 'DIAS VIGENTE' DESC
			 
		end
	else
		begin
			select  V.id as IDVEHICULO, CC.fecha as  'FECHA', TP.transaccion as 'TRANSACCION',C.cliente as CLIENTE,
			CONVERT(varchar(200),(F.fabricante + ' ' + M.modelo + ' ' + CONVERT(varchar(10), V.año) + ' ' + V.color)) as VEHICULO,
			V.vin as CHASIS, 
			CC.balance_rd as 'PENDIENTE ($RD)', CC.balance_usd as 'PENDIENTE ($USD)',
			ISNULL(DATEDIFF(DAY, format (CC.fecha, 'yyyy-MM-dd'), format (GETDATE(), 'yyyy-MM-dd')), 0) as 'DIAS VIGENTE',
			CC.id as IDCUENTACOBRAR, CC.nueva as NUEVA
			From 
			CuentasCobrar CC join TipoTransaccion TP on TP.id = CC.id_transaccion join Clientes C on CC.id_cliente = C.id
			join Vehiculos V on CC.id_vehiculo = V.id join Fabricantes F on V.fabricante_id = F.id join Modelos M on M.id = V.modelo_id
			where V.vendido = 1 and (CC.balance_rd > 0 and CC.balance_usd > 0) and CC.nueva = 1
			and format(CC.fecha,'yyyy-MM-dd') between
			format (@desde, 'yyyy-MM-dd') and format (@hasta, 'yyyy-MM-dd')
			and C.cliente LIKE '%' + @cliente + '%'
			
			union

			select  CC.id_vehiculo as IDVEHICULO, CC.fecha as  'FECHA', TP.transaccion as 'TRANSACCION',C.cliente as CLIENTE,
			CONVERT(varchar(200),(F.fabricante + ' ' + M.modelo + ' ' + CONVERT(varchar(10), V.año) + ' ' + V.color)) as VEHICULO,
			V.chasis as CHASIS, 
			CC.balance_rd as 'PENDIENTE ($RD)', CC.balance_usd as 'PENDIENTE ($USD)',
			ISNULL(DATEDIFF(DAY, format (CC.fecha, 'yyyy-MM-dd'), format (GETDATE(), 'yyyy-MM-dd')), 0) as 'DIAS VIGENTE',
			CC.id as IDCUENTACOBRAR, CC.nueva as NUEVA
			From 
			CuentasCobrar CC join TipoTransaccion TP on TP.id = CC.id_transaccion join Clientes C on CC.id_cliente = C.id
			join Detalle_CC_CP_Antiguas V on CC.id = V.id_cuenta join Fabricantes F on V.id_fabricante = F.id join Modelos M on M.id = V.id_modelo
			where V.id_tipo_cuenta = 2 and (CC.balance_rd > 0 and CC.balance_usd > 0) and CC.nueva = 0
			and format(CC.fecha,'yyyy-MM-dd') between
			format (@desde, 'yyyy-MM-dd') and format (@hasta, 'yyyy-MM-dd') 
			and C.cliente LIKE '%' + @cliente + '%'
			order by 'DIAS VIGENTE' DESC	
		end
end


GO
/****** Object:  StoredProcedure [dbo].[obtener_cuentas_por_pagar]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[obtener_cuentas_por_pagar]
@propietario varchar(100), @desde date, @hasta date, @idTransaccion int
as

begin
	if @propietario = ''
		begin
				
			select  V.id as IDVEHICULO, CP.fecha as  'FECHA' , TP.transaccion as TRANSACCION , '0' as '#FACTURA' ,S.suplidor as 'PAGAR A',
			CONVERT(varchar(200),
			(F.fabricante + ' ' + M.modelo + ' ' + CONVERT(varchar(10), V.año) + ' ' + V.color)) as VEHICULO,
			V.vin as CHASIS,
			ISNULL(CP.balance_rd, 0) as 'PENDIENTE ($RD)', ISNULL(CP.balance_usd, 0) as 'PENDIENTE ($USD)',
			ISNULL(DATEDIFF(DAY, format (CP.fecha, 'yyyy-MM-dd'),
				format (GETDATE(), 'yyyy-MM-dd')), 0) as 'DIAS VIGENTE', CP.id as IDCUENTAPAGAR
			from Vehiculos V  join CuentasPagar CP on CP.id_vehiculo = V.id
			join Suplidores S on S.id = V.id_suplidor join Fabricantes F on F.id = V.fabricante_id 
			join Modelos M on M.id = V.modelo_id  join TipoTransaccion TP on TP.id = CP.id_transaccion
			
			where (ISNULL(CP.balance_usd,0) > 0 or ISNULL(CP.balance_rd,0)>0) and CP.id_transaccion = 2
			and format(CP.fecha,'yyyy-MM-dd') between
			format (@desde, 'yyyy-MM-dd') and format (@hasta, 'yyyy-MM-dd')
				
			union 

			select  V.id as IDVEHICULO, CP.fecha as  'FECHA' ,TP.transaccion as TRANSACCION , FS.facturaSuplidor as '#FACTURA' , TR.taller as 'PAGAR A',
			CONVERT(varchar(200),
			(F.fabricante + ' ' + M.modelo + ' ' + CONVERT(varchar(10), V.año) + ' ' + V.color)) as VEHICULO,
			V.vin as CHASIS,
			ISNULL(CP.balance_rd, 0) as 'PENDIENTE ($RD)', ISNULL(CP.balance_usd, 0) as 'PENDIENTE ($USD)',
			ISNULL(DATEDIFF(DAY, format (CP.fecha, 'yyyy-MM-dd'),
				format (GETDATE(), 'yyyy-MM-dd')), 0) as 'DIAS VIGENTE', CP.id as IDCUENTAPAGAR
			from Vehiculos V  join CuentasPagar CP on CP.id_vehiculo = V.id
			join Suplidores S on S.id = V.id_suplidor join Fabricantes F on F.id = V.fabricante_id 
			join Modelos M on M.id = V.modelo_id  join TipoTransaccion TP on TP.id = CP.id_transaccion
			join FacturasServicios FS on FS.id = CP.id_factura join TalleresRepuestos TR on TR.id = CP.id_vendedor
			
			where (ISNULL(CP.balance_usd,0) > 0 or ISNULL(CP.balance_rd,0)>0) and CP.id_transaccion = 8
			and format(CP.fecha,'yyyy-MM-dd') between
			format (@desde, 'yyyy-MM-dd') and format (@hasta, 'yyyy-MM-dd')
					
			order by 'DIAS VIGENTE' DESC

			
		end
	else
		begin
			select  V.id as IDVEHICULO, CP.fecha as  'FECHA' , TP.transaccion as TRANSACCION , '0' as '#FACTURA' ,S.suplidor as 'PAGAR A',
			CONVERT(varchar(200),
			(F.fabricante + ' ' + M.modelo + ' ' + CONVERT(varchar(10), V.año) + ' ' + V.color)) as VEHICULO,
			V.vin as CHASIS,
			ISNULL(CP.balance_rd, 0) as 'PENDIENTE ($RD)', ISNULL(CP.balance_usd, 0) as 'PENDIENTE ($USD)',
			ISNULL(DATEDIFF(DAY, format (CP.fecha, 'yyyy-MM-dd'),
				format (GETDATE(), 'yyyy-MM-dd')), 0) as 'DIAS VIGENTE', CP.id as IDCUENTAPAGAR
			from Vehiculos V  join CuentasPagar CP on CP.id_vehiculo = V.id
			join Suplidores S on S.id = V.id_suplidor join Fabricantes F on F.id = V.fabricante_id 
			join Modelos M on M.id = V.modelo_id  join TipoTransaccion TP on TP.id = CP.id_transaccion
			
			where (ISNULL(CP.balance_usd,0) > 0 or ISNULL(CP.balance_rd,0)>0) and CP.id_transaccion = 2 and S.suplidor LIKE '%' + @propietario + '%'
			and format(CP.fecha,'yyyy-MM-dd') between
			format (@desde, 'yyyy-MM-dd') and format (@hasta, 'yyyy-MM-dd')
				
			union 

			select  V.id as IDVEHICULO, CP.fecha as  'FECHA' ,TP.transaccion as TRANSACCION , FS.facturaSuplidor as '#FACTURA' , TR.taller as 'PAGAR A',
			CONVERT(varchar(200),
			(F.fabricante + ' ' + M.modelo + ' ' + CONVERT(varchar(10), V.año) + ' ' + V.color)) as VEHICULO,
			V.vin as CHASIS,
			ISNULL(CP.balance_rd, 0) as 'PENDIENTE ($RD)', ISNULL(CP.balance_usd, 0) as 'PENDIENTE ($USD)',
			ISNULL(DATEDIFF(DAY, format (CP.fecha, 'yyyy-MM-dd'),
				format (GETDATE(), 'yyyy-MM-dd')), 0) as 'DIAS VIGENTE', CP.id as IDCUENTAPAGAR
			from Vehiculos V  join CuentasPagar CP on CP.id_vehiculo = V.id
			join Suplidores S on S.id = V.id_suplidor join Fabricantes F on F.id = V.fabricante_id 
			join Modelos M on M.id = V.modelo_id  join TipoTransaccion TP on TP.id = CP.id_transaccion
			join FacturasServicios FS on FS.id = CP.id_factura join TalleresRepuestos TR on TR.id = CP.id_vendedor
			
			where (ISNULL(CP.balance_usd,0) > 0 or ISNULL(CP.balance_rd,0)>0) and CP.id_transaccion = 8 and TR.taller LIKE '%' + @propietario + '%'
			and format(CP.fecha,'yyyy-MM-dd') between
			format (@desde, 'yyyy-MM-dd') and format (@hasta, 'yyyy-MM-dd')
					
			order by 'DIAS VIGENTE' DESC
		end
end





GO
/****** Object:  StoredProcedure [dbo].[obtener_detalle_cuenta_cobrar_antigua]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[obtener_detalle_cuenta_cobrar_antigua]
@idCC int
as

begin
	select C.id as IDCLIENTE,
	CONVERT(varchar(200),(F.fabricante + ' ' + M.modelo + ' ' + CONVERT(varchar(10), D.año) + ' ' + D.color)) as VEHICULO,
	D.chasis as CHASIS, CC.fecha as FECHA, C.rnc_cedula as CEDULA, C.cliente as CLIENTE,
	ISNULL(DATEDIFF(DAY, format (CC.fecha, 'yyyy-MM-dd'), format (GETDATE(), 'yyyy-MM-dd')), 0) as 'DIAS VIGENTE',
	C.direccion as DIRECCION, C.telefono as TEL, CC.monto_rd as 'CREDITO RD', CC.monto_usd as 'CREDITO USD', CC.nota AS NOTA,
	D.dias_seguro as DURACION
	from CuentasCobrar CC join Detalle_CC_CP_Antiguas D on D.id_cuenta = CC.id join Clientes C on C.id = CC.id_cliente
	join Fabricantes F on F.id = D.id_fabricante join Modelos M on M.id = D.id_modelo
	where D.id_tipo_cuenta = 2 and CC.nueva = 0 and CC.id = 1 and D.id_tipo_cuenta = 2
end


GO
/****** Object:  StoredProcedure [dbo].[obtener_detalle_cuenta_por_cobrar]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[obtener_detalle_cuenta_por_cobrar]
@idVehiculo int
as

begin
	
	select V.id as ID,
	CONVERT(varchar(200),(F.fabricante + ' ' + M.modelo + ' ' + CONVERT(varchar(10), V.año) + ' ' + V.color)) 
	as VEHICULO, V.vin as CHASIS, ISNULL(DATEDIFF(DAY, format (v.fecha_vendido, 'yyyy-MM-dd'), format (GETDATE(), 'yyyy-MM-dd')), 0) as 'DIAS VIGENTE',	
	C.cliente as CLIENTE, C.direccion as DIRECCION, C.rnc_cedula as CEDULA, C.telefono as TEL , C.id as IDCLIENTE,
	format(V.fecha_vendido, 'dd/MM/yyyy' )as 'FECHA VENTA', 
	V.precioVentaRD as 'PRECIO ($RD)', V.precioVentaUSD as 'PRECIO ($USD)', PS.precioRD as 'PRECIO SEGURO RD',
	PS.precioUSD as 'PRECIO SEGURO USD', PT.precioRD as 'PRECIO TRASPASO RD',
	PT.precioUSD as 'PRECIO TRASPASO USD'
	from Vehiculos V join Fabricantes F on V.fabricante_id = F.id join Modelos M on V.modelo_id = M.id
	join Clientes C on V.id_cliente = C.id join PreciosSeguroVehiculo PS on PS.id_vehiculo = V.id
	join PreciosTraspasoVehiculo PT on PT.id_vehiculo = V.id
	where V.id = @idVehiculo and V.vendido = 1
		
end


GO
/****** Object:  StoredProcedure [dbo].[obtener_detalle_cuenta_por_pagar]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[obtener_detalle_cuenta_por_pagar]
@idVehiculo int, @idTransaccion int, @facturaSuplidor varchar(50)
as

begin
	
	if @idTransaccion = 2 -- Compra
		begin 
			select V.id as ID,
			CONVERT(varchar(200),(F.fabricante + ' ' + M.modelo + ' ' + CONVERT(varchar(10), V.año) + ' ' + V.color)) 
			as VEHICULO, V.vin as CHASIS, ISNULL(DATEDIFF(DAY, format (v.fecha_importe, 'yyyy-MM-dd'), format (GETDATE(), 'yyyy-MM-dd')), 0) as 'DIAS VIGENTE',	
			Sup.suplidor as PROPIETARIO,Sup.direccion as DIRECCION, Sup.rnc_cedula as CEDULA, Sup.telefono as TEL ,
			format(CP.fecha, 'dd/MM/yyyy' )as 'FECHA COMPRADO', 
			CP.monto_rd as 'PRECIO ($RD)', CP.monto_usd as 'PRECIO ($USD)',
			P.pais as PAIS, C.ciudad as CIUDAD
	
			from CuentasPagar CP join Vehiculos V on V.id = CP.id_vehiculo join Fabricantes F on V.fabricante_id = F.id join Modelos M on V.modelo_id = M.id 
			join Suplidores Sup on V.id_suplidor = Sup.id
			join Paises P on P.id = Sup.id_pais join Ciudades C on C.id = Sup.id_ciudad
	
			where CP.id_vehiculo = @idVehiculo and CP.id_transaccion = 2
		end
	else if @idTransaccion = 4 --Seguro
		begin 
			select V.id as ID,
			CONVERT(varchar(200),(F.fabricante + ' ' + M.modelo + ' ' + CONVERT(varchar(10), V.año) + ' ' + V.color)) 
			as VEHICULO, V.vin as CHASIS, ISNULL(DATEDIFF(DAY, format (v.fecha_importe, 'yyyy-MM-dd'), format (GETDATE(), 'yyyy-MM-dd')), 0) as 'DIAS VIGENTE',	
			seg.nombre as PROPIETARIO, Seg.telefono as TEL ,
			format(CP.fecha, 'dd/MM/yyyy' )as 'FECHA COMPRADO', 
			CP.monto_rd as 'PRECIO ($RD)', CP.monto_usd as 'PRECIO ($USD)'
			
			from CuentasPagar CP join Vehiculos V on V.id = CP.id_vehiculo join Fabricantes F on V.fabricante_id = F.id join Modelos M on V.modelo_id = M.id 
			join Seguros Seg on V.id_suplidor = Seg.id 

			where CP.id_vehiculo = @idVehiculo and CP.id_transaccion = 4
		end
	else
		begin
			select V.id as ID,
			CONVERT(varchar(200),(F.fabricante + ' ' + M.modelo + ' ' + CONVERT(varchar(10), V.año) + ' ' + V.color)) 
			as VEHICULO, V.vin as CHASIS, ISNULL(DATEDIFF(DAY, format (v.fecha_importe, 'yyyy-MM-dd'), format (GETDATE(), 'yyyy-MM-dd')), 0) as 'DIAS VIGENTE',	
			TR.taller as PROPIETARIO, TR.telefono1 as TEL, TR.direccion as DIRECCION ,
			format(CP.fecha, 'dd/MM/yyyy' )as 'FECHA COMPRADO', 
			CP.monto_rd as 'PRECIO ($RD)', CP.monto_usd as 'PRECIO ($USD)', FS.facturaSuplidor as FACTURA, FS.id as IDFACTURA
			
			from CuentasPagar CP join Vehiculos V on V.id = CP.id_vehiculo join Fabricantes F on V.fabricante_id = F.id join Modelos M on V.modelo_id = M.id 
			join TalleresRepuestos TR on TR.id = CP.id_vendedor join FacturasServicios FS on FS.id = CP.id_factura
			

			where CP.id_vehiculo = @idVehiculo and FS.facturaSuplidor = @facturaSuplidor and CP.id_transaccion = 8

		end

	-- else if @idTransaccion = 5 -- Pieza
	--	begin 
	--		select V.id as ID,
	--		CONVERT(varchar(200),(F.fabricante + ' ' + M.modelo + ' ' + CONVERT(varchar(10), V.año) + ' ' + V.color)) 
	--		as VEHICULO, V.vin as CHASIS, ISNULL(DATEDIFF(DAY, format (v.fecha_importe, 'yyyy-MM-dd'), format (GETDATE(), 'yyyy-MM-dd')), 0) as 'DIAS VIGENTE',	
	--		TR.taller as PROPIETARIO, TR.telefono1 as TEL, TR.direccion as DIRECCION ,
	--		format(CP.fecha, 'dd/MM/yyyy' )as 'FECHA COMPRADO', 
	--		CP.monto_rd as 'PRECIO ($RD)', CP.monto_usd as 'PRECIO ($USD)',
	--		(select  C.componente from Componentes C join GastoVehiculo GV on GV.id_gasto = C.id join CuentasPagar CP on CP.id_gasto = GV.id where CP.id_transaccion = @idTransaccion) as PIEZA
			
	--		from CuentasPagar CP join Vehiculos V on V.id = CP.id_vehiculo join Fabricantes F on V.fabricante_id = F.id join Modelos M on V.modelo_id = M.id 
	--		join TalleresRepuestos TR on TR.id = CP.id_vendedor 
			

	--		where CP.id_vehiculo = @idVehiculo and CP.id_transaccion = 5
	--	end
	--else if @idTransaccion = 6 -- MECANICA
	--	begin 
	--		select V.id as ID,
	--		CONVERT(varchar(200),(F.fabricante + ' ' + M.modelo + ' ' + CONVERT(varchar(10), V.año) + ' ' + V.color)) 
	--		as VEHICULO, V.vin as CHASIS, ISNULL(DATEDIFF(DAY, format (v.fecha_importe, 'yyyy-MM-dd'), format (GETDATE(), 'yyyy-MM-dd')), 0) as 'DIAS VIGENTE',	
	--		TR.taller as PROPIETARIO, TR.telefono1 as TEL, TR.direccion as DIRECCION ,
	--		format(CP.fecha, 'dd/MM/yyyy' )as 'FECHA COMPRADO', 
	--		CP.monto_rd as 'PRECIO ($RD)', CP.monto_usd as 'PRECIO ($USD)', 
	--		(select  G.descripcion from Gastos G join GastoVehiculo GV on GV.id_gasto = G.id join CuentasPagar CP on CP.id_gasto = GV.id where CP.id_transaccion = 6) as GASTO
			
			
	--		from CuentasPagar CP join Vehiculos V on V.id = CP.id_vehiculo join Fabricantes F on V.fabricante_id = F.id join Modelos M on V.modelo_id = M.id 
	--		join TalleresRepuestos TR on TR.id = CP.id_vendedor 

	--		where CP.id_vehiculo = @idVehiculo and CP.id_transaccion = 6
	--	end

	--else if @idTransaccion = 7 -- OTROS
	--	begin 
	--		select V.id as ID,
	--		CONVERT(varchar(200),(F.fabricante + ' ' + M.modelo + ' ' + CONVERT(varchar(10), V.año) + ' ' + V.color)) 
	--		as VEHICULO, V.vin as CHASIS, ISNULL(DATEDIFF(DAY, format (v.fecha_importe, 'yyyy-MM-dd'), format (GETDATE(), 'yyyy-MM-dd')), 0) as 'DIAS VIGENTE',	
	--		TR.taller as PROPIETARIO, TR.telefono1 as TEL, TR.direccion as DIRECCION ,
	--		format(CP.fecha, 'dd/MM/yyyy' )as 'FECHA COMPRADO', 
	--		CP.monto_rd as 'PRECIO ($RD)', CP.monto_usd as 'PRECIO ($USD)', 
	--		(select  G.descripcion from Gastos G join GastoVehiculo GV on GV.id_gasto = G.id join CuentasPagar CP on CP.id_gasto = GV.id where CP.id_transaccion = 7) as GASTO
			
			
	--		from CuentasPagar CP join Vehiculos V on V.id = CP.id_vehiculo join Fabricantes F on V.fabricante_id = F.id join Modelos M on V.modelo_id = M.id 
	--		join TalleresRepuestos TR on TR.id = CP.id_vendedor 

	--		where CP.id_vehiculo = @idVehiculo and CP.id_transaccion = 7
	--	end
	
	
		
end





GO
/****** Object:  StoredProcedure [dbo].[obtener_detalle_vehiculo_especifico]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[obtener_detalle_vehiculo_especifico]
@idVehiculo int
as

begin
	
	select V.id as ID,F.fabricante as FABRICANTE, M.modelo as MODELO, V.año as AÑO, P.nombre as PROPIETARIO, 
	 V.vin as VIN, V.nota as NOTA, format(V.fecha_importe, 'dd/MM/yyyy' )as 'FECHA COMPRADO', V.terminado as TERMINADO,
	 V.fecha_vendido as 'FECHA VENDIDO', V.precioRD as 'PRECIO ($RD)',
	 V.precioUSD as 'PRECIO ($USD)', V.vendido as VENDIDO, V.pagado as PAGADO, V.color as COLOR, V.nota as DETALLES,
	 V.acto_venta as 'ACTO VENTA', V.matricula as 'MATRICULA ORIGINAL', v.cedula_vendedor as 'CEDULA VENDEDOR',
	 U.ubicacion as UBICACION, format(V.fecha_terminado, 'dd/MM/yyyy' )as 'FECHA TERMINADO', S.suplidor as SUPLIDOR,
	 V.placa as PLACA, V.numero_matricula as 'NUMERO MATRICULA', V.millaje as MILLAJE, V.precio_estimado_rd as 'PRECIO ESTIMADO RD',
	 V.precio_estimado_usd as 'PRECIO ESTIMADO USD', V.fuerza_motriz as 'FUERZA MOTRIZ'
	from Vehiculos V join Fabricantes F on V.fabricante_id = F.id join Modelos M on V.modelo_id = M.id
	join Propietarios P on V.id_propietario = P.id join Ubicaciones U on U.id = V.id_ubicacion
	join Suplidores S on S.id = V.id_suplidor
	where V.id = @idVehiculo
		
end






GO
/****** Object:  StoredProcedure [dbo].[obtener_detalles_factura_servicio]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[obtener_detalles_factura_servicio]
@idFactura int
as

begin


select GV.id as ID, GV.cantidad as CANTIDAD, G.descripcion as DESCRIPCION, GV.monto_rd as 'TOTAL ($RD)',
GV.monto_usd as 'TOTAL ($USD)' 
from FacturasServicios F join GastoVehiculo GV on GV.id_factura_servicio = F.id
 join Gastos G on G.id = GV.id_gasto
where F.id = @idFactura and GV.id_transaccion != 5
union
select GV.id as ID, GV.cantidad as CANTIDAD, G.componente as DESCRIPCION, GV.monto_rd as 'TOTAL ($RD)',
GV.monto_usd as 'TOTAL ($USD)' 
from FacturasServicios F join GastoVehiculo GV on GV.id_factura_servicio = F.id
 join Componentes G on G.id = GV.id_gasto
where F.id = @idFactura and GV.id_transaccion = 5
end


GO
/****** Object:  StoredProcedure [dbo].[obtener_dias_activo]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[obtener_dias_activo]

as

declare @fechaActivacion date = (select fechaActivacion from SerialKeyActivation where id = 1)
declare @fechaVencimiento date = (select fechaVencimiento from SerialKeyActivation where id = 1)
declare @dias int = ISNULL(DATEDIFF(DAY,format (GETDATE(), 'yyyy-MM-dd'),  format (@fechaVencimiento, 'yyyy-MM-dd')), 0)
begin
  
	select @dias as DIAS
end



GO
/****** Object:  StoredProcedure [dbo].[obtener_fabricantes_activos]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[obtener_fabricantes_activos]
as


begin

	select id as ID, fabricante as FABRICANTE, codigo as CODIGO, estado as HABILITADO 
	from Fabricantes
	where estado = 1
	ORDER BY FABRICANTE
end






GO
/****** Object:  StoredProcedure [dbo].[obtener_facturas]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[obtener_facturas]
@desde date, @hasta date
as

begin
	--select V.id, Fac.id as '# Factura', format(V.fecha_vendido,'dd/MM/yyyy') as FECHAVENDIDO, 
	--CONVERT(varchar(200),(F.fabricante + ' ' + M.modelo + ' ' + CONVERT(varchar(10), V.año) + ' ' + V.color)) as VEHICULO,
	--(V.precioVentaRD + PS.precioRD + PT.precioRD) as PRECIORD, sum(pa.monto_rd) as PAGADORD,
	--(V.precioVentaUSD + PS.precioUSD + PT.precioUSD) as PRECIOUSD, sum(pa.monto_usd) as PAGADOUSD, C.cliente as CLIENTE
	--from facturas Fac join Vehiculos V on Fac.idVehiculo = V.id join Fabricantes F on V.fabricante_id = F.id join Modelos M on V.modelo_id = M.id
	--join Propietarios P on V.id_propietario = P.id join FormaVentaVehiculo Pa on V.id=pa.id_vehiculo join Clientes C on V.id_cliente = C.id
	--join PreciosSeguroVehiculo PS on PS.id = Fac.idVehiculo join PreciosTraspasoVehiculo PT on PT.id_vehiculo = Fac.idVehiculo
	--where V.vendido = 1 
	----and format(V.fecha_importe,'yyyy-MM-dd') between
	----format (@desde, 'yyyy-MM-dd') and format (@hasta, 'yyyy-MM-dd')
	--GROUP BY Fac.id ,V.id,V.precioVentaRD, PT.precioRD, PT.precioUSD, PS.precioRD, PS.precioUSD, V.precioVentaUSD ,F.fabricante, M.modelo, V.año, V.total_invertido_usd,V.total_invertido_rd ,V.fecha_vendido, C.cliente, V.color
	
	select F.id as '# Factura', format(V.fecha_vendido,'dd/MM/yyyy') as FECHAVENDIDO,
	CONVERT(varchar(200),(Fab.fabricante + ' ' + M.modelo + ' ' + CONVERT(varchar(10), V.año) + ' ' + V.color)) as VEHICULO,
	(V.precioVentaRD + PS.precioRD + PT.precioRD) as PRECIORD, (V.precioVentaUSD + PS.precioUSD + PT.precioUSD) as PRECIOUSD,
	C.cliente as CLIENTE
	from facturas F join Vehiculos V on V.id = F.idVehiculo join Fabricantes Fab on Fab.id = V.fabricante_id 
	join Modelos M on M.id = V.modelo_id join PreciosSeguroVehiculo PS on PS.id_vehiculo = F.idVehiculo 
	join PreciosTraspasoVehiculo PT on PT.id_vehiculo = F.idVehiculo join Clientes C on F.id_cliente = C.id
	where V.vendido = 1 and format(V.fecha_importe,'yyyy-MM-dd') between
	format (@desde, 'yyyy-MM-dd') and format (@hasta, 'yyyy-MM-dd')

end





GO
/****** Object:  StoredProcedure [dbo].[obtener_facturas_servicio_vehiculo_individual]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[obtener_facturas_servicio_vehiculo_individual]
@idVehiculo int
as

begin
		
	select format(F.fecha,'dd/MM/yyyy') as FECHA, F.facturaSuplidor as '# Factura',TR.taller as 'TALLER/REPUESTO',
	 F.monto_rd as PRECIORD, F.monto_usd as PRECIOUSD,
	 F.nota as NOTA, F.id as ID
	from FacturasServicios F join Vehiculos V on V.id = F.id_vehiculo
	join Modelos M on M.id = V.modelo_id join TalleresRepuestos TR on TR.id = F.id_suplidor
	where F.id_vehiculo = @idVehiculo
	

end





GO
/****** Object:  StoredProcedure [dbo].[obtener_gastos_aduanales_activos]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[obtener_gastos_aduanales_activos]
as

begin 

	select id as ID, descripcion as DESCRIPCION, tipo as 'TIPO GASTO', estado as HABILITADO
	from Gastos
	where estado = 1 and tipo = 'OTROS GASTOS'
end






GO
/****** Object:  StoredProcedure [dbo].[obtener_gastos_reparacion_activos]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[obtener_gastos_reparacion_activos]
as

begin 

	select id as ID, descripcion as DESCRIPCION, tipo as 'TIPO GASTO', estado as HABILITADO
	from Gastos
	where estado = 1 and tipo = 'REPARACION'
end






GO
/****** Object:  StoredProcedure [dbo].[obtener_historial_ubicaciones]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
	create procedure [dbo].[obtener_historial_ubicaciones]
	@idVehiculo int
	as
	
	begin
		select format(HU.fecha, 'dd/MM/yyyy' ) as  FECHA ,U.ubicacion as UBICACION
		from HistorialUbicaciones HU join Ubicaciones U on U.id = HU.id_ubicacion
		where HU.id_vehiculo = @idVehiculo
		 
	end



GO
/****** Object:  StoredProcedure [dbo].[obtener_imagenes_clientes]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[obtener_imagenes_clientes] 
@idCliente  int
as
begin
	select id,img from ImagenesClientes where idCliente = @idCliente
	
end




GO
/****** Object:  StoredProcedure [dbo].[obtener_imagenes_traspasos]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[obtener_imagenes_traspasos] 
@idVehiculo  int
as
begin
	select id,img from ImagenesTraspasos where id_vehiculo = @idVehiculo
	
end




GO
/****** Object:  StoredProcedure [dbo].[obtener_modelos_activos]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[obtener_modelos_activos]
@idFabricante int
as


begin

	select m.id as ID, m.modelo as MODELO, m.codigo as CODIGO, m.estado as HABILITADO 
	from Modelos m join Fabricantes f on m.fabricante_id = f.id 
	where m.fabricante_id = @idFabricante and m.estado = 1
	order by MODELO
end






GO
/****** Object:  StoredProcedure [dbo].[obtener_pagos_credito_vehiculo]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[obtener_pagos_credito_vehiculo]
@idCP int
as

begin
	
		    select format (PCP.fecha, 'dd/MM/yyyy') as 'FECHA PAGO', TP.formaPago as 'TIPO PAGO',PCP.monto_rd as 'PAGADO ($RD)', PCP.monto_usd as 'PAGADO ($USD)',
			PCP.nota as 'NOTA'
			from PagosCuentasPagar PCP join TiposPago TP on TP.id = PCP.id_tipoPago
			where
			PCP.id_cuentaPagar = @idCP
			


		
end




GO
/****** Object:  StoredProcedure [dbo].[obtener_pagos_vehiculo]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[obtener_pagos_vehiculo]
@idVehiculo int, @idTransaccion int
as


begin
	select Format(V.fecha_importe,'dd/MM/yyyy') as 'FECHA DE PAGO', TP.formaPago as 'TIPO PAGO' ,
	FC.monto_rd as 'PAGO($RD)', FC.monto_usd as 'PAGO($USD)', FC.nota as 'DETALLE'
	from FormaCompraVehiculo FC join Vehiculos V on V.id = FC.id_vehiculo join TiposPago TP on TP.id = FC.id_tipo_pago
	where FC.id_vehiculo = @idVehiculo and FC.id_transaccion = @idTransaccion 
	
end





GO
/****** Object:  StoredProcedure [dbo].[obtener_paises_activos]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

	create procedure [dbo].[obtener_paises_activos]
	as
	
	begin
		select id as ID, pais as PAIS, estado as ESTADO from Paises  where estado = 1
	end



GO
/****** Object:  StoredProcedure [dbo].[obtener_permiso_usuario]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[obtener_permiso_usuario]
@idUsuario int
as


begin

	select tasaDolar as 'TASA CAMBIO', 
	crearUsuarios as 'CREAR USUARIOS', fabricantesModelos as 'CREAR FABRICANTES/MODELOS',
	piezasRepuestos as 'CREAR PIEZAS/REPUESTOS', crearTaller as 'CREAR TALLER', crearPropietarios as 'CREAR PROPIETARIOS', 
	crearClientes as 'CREAR CLIENTES',crearGastos as 'CREAR GASTOS', importarVehiculo 'IMPORTAR VEHICULOS', 
	compras as 'COMPRAS', cambiarEstadosVehiculo as 'CAMBIAR ESTADO VEHICULOS',
	agreagarGastos as 'AGREGAR GASTO A VEHICULO', agregarPiezas as 'AGREGAR PIEZAS A VEHICULO', 
	facturacion as 'FACTURACION', reportes as REPORTES, estadoUsuario as 'ESTADO USUARIO', modificarVehiculo as 'MODIFICAR VEHICULO',
	cuentasCobrar as 'CUENTAS COBRAR', cuentasPagar as 'CUENTAS PAGAR', actualizarDiarioTasa 'ACTUALIZAR TASA DIARIO',
	agregar_paises as 'AGREGAR PAISES', agregar_ciudades as 'AGREGAR CIUDADES', agregar_colores as 'AGREGAR COLORES',
	agregar_ubicaciones as 'AGREGAR UBICACIONES', agregar_suplidores as 'AGREGAR SUPLIDORES', agregar_seguros as 'AGREGAR SEGUROS',
	AgregarCCCP as 'AGREGAR CUENTAS ANTIGUAS'

	from Usuarios where id = @idUsuario
	
end


GO
/****** Object:  StoredProcedure [dbo].[obtener_precio_componente_seleccionado]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[obtener_precio_componente_seleccionado]
@idComponente int
as


begin

	select precio_rd as 'PRECIO ($RD)', precio_usd as 'PRECIO ($USD)'
	from Componentes where id = @idComponente
	
end






GO
/****** Object:  StoredProcedure [dbo].[obtener_propietarios_activos]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[obtener_propietarios_activos]

as


begin

	select id as ID, nombre as PROPIETARIO, telefono as 'TEL.', estado as HABILITADO
	from Propietarios
	where estado = 1
	
end






GO
/****** Object:  StoredProcedure [dbo].[obtener_recibos_cobros]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[obtener_recibos_cobros]
@desde date, @hasta date, @cliente varchar(50)
as

begin
	if @cliente = ''
		begin
			select V.id as 'ID VEHICULO',PCC.id as '# RECIBO', C.cliente as CLIENTE, PCC.monto_rd as 'MONTO ($RD)',
			PCC.monto_usd as 'MONTO $(USD)', CC.id as '# CUENTA COBRAR'
			from 
			PagosCuentasCobrar PCC join CuentasCobrar CC on PCC.id_cuentaCobrar = CC.id join
			Vehiculos V on V.id = CC.id_vehiculo
			join Clientes C on C.id = V.id_cliente
			where format(PCC.fecha,'yyyy-MM-dd') between
			format (@desde, 'yyyy-MM-dd') and format (@hasta, 'yyyy-MM-dd')
			
			union

			select CC.id_vehiculo as 'ID VEHICULO',PCC.id as '# RECIBO', C.cliente as CLIENTE, PCC.monto_rd as 'MONTO ($RD)',
			PCC.monto_usd as 'MONTO $(USD)', CC.id as '# CUENTA COBRAR'
			from 
			PagosCuentasCobrar PCC join CuentasCobrar CC on PCC.id_cuentaCobrar = CC.id join
			Detalle_CC_CP_Antiguas V on V.id_cuenta = CC.id
			join Clientes C on C.id = CC.id_cliente
			where format(PCC.fecha,'yyyy-MM-dd') between
			format (@desde, 'yyyy-MM-dd') and format (@hasta, 'yyyy-MM-dd') and CC.nueva  = 0
			and V.id_tipo_cuenta = 2
		end
	else
		begin
			select V.id as 'ID VEHICULO',PCC.id as '# RECIBO', C.cliente as CLIENTE, PCC.monto_rd as 'MONTO ($RD)',
			PCC.monto_usd as 'MONTO $(USD)',CC.id as '# CUENTA COBRAR'
			from 
			PagosCuentasCobrar PCC join CuentasCobrar CC on PCC.id_cuentaCobrar = CC.id join
			Vehiculos V on V.id = CC.id_vehiculo
			join Clientes C on C.id = V.id_cliente
			where format(PCC.fecha,'yyyy-MM-dd') between
			format (@desde, 'yyyy-MM-dd') and format (@hasta, 'yyyy-MM-dd')
			and C.cliente LIKE '%' + @cliente + '%'

			union

			select CC.id_vehiculo as 'ID VEHICULO',PCC.id as '# RECIBO', C.cliente as CLIENTE, PCC.monto_rd as 'MONTO ($RD)',
			PCC.monto_usd as 'MONTO $(USD)', CC.id as '# CUENTA COBRAR'
			from 
			PagosCuentasCobrar PCC join CuentasCobrar CC on PCC.id_cuentaCobrar = CC.id join
			Detalle_CC_CP_Antiguas V on V.id_cuenta = CC.id
			join Clientes C on C.id = CC.id_cliente
			where format(PCC.fecha,'yyyy-MM-dd') between
			format (@desde, 'yyyy-MM-dd') and format (@hasta, 'yyyy-MM-dd') and CC.nueva  = 0
			and V.id_tipo_cuenta = 2 and C.cliente LIKE '%' + @cliente + '%'
		end

end

GO
/****** Object:  StoredProcedure [dbo].[obtener_seguros_activos]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

	create procedure [dbo].[obtener_seguros_activos]
	as
	
	begin
		select id as ID, nombre as SEGURO, estado as ESTADO from Seguros  where estado = 1
	end



GO
/****** Object:  StoredProcedure [dbo].[obtener_suplidores_activos]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

	create procedure [dbo].[obtener_suplidores_activos]
	as
	
	begin
		select id as ID, suplidor as SUPLIDOR, estado as ESTADO from Suplidores  where estado = 1
	end




GO
/****** Object:  StoredProcedure [dbo].[obtener_talleresRepuestos_activos]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[obtener_talleresRepuestos_activos]

as


begin

	select id as ID ,taller as 'TALLER', direccion as DIRECCION, telefono1 as 'TEL. 1', telefono2 as 'TEL. 2', estado as HABILITADO
	from TalleresRepuestos where estado = 1
	

end






GO
/****** Object:  StoredProcedure [dbo].[obtener_tasa_dolar]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[obtener_tasa_dolar]

as

begin

	select tasaDolar as TASA, format(fechaActualizado,'dd/MM/yyyy') as FACTUALIZADO from TasaDolar where id = 1
	

end



GO
/****** Object:  StoredProcedure [dbo].[obtener_tipo_cuenta_cobrar]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[obtener_tipo_cuenta_cobrar]
@idCC int

as

begin

	select TP.transaccion
	from CuentasCobrar CC join TipoTransaccion TP on TP.id = CC.id_transaccion 
	where CC.id = @idCC
end
GO
/****** Object:  StoredProcedure [dbo].[obtener_tipos_pagos_sin_credito]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[obtener_tipos_pagos_sin_credito]

as


begin

	select id as ID, formaPago as TIPOPAGO from TiposPago
	where id != 3
	
end






GO
/****** Object:  StoredProcedure [dbo].[obtener_tipos_pagos_sin_vehiculo]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
	create procedure [dbo].[obtener_tipos_pagos_sin_vehiculo]
	
	as
	
	begin
		select id as ID, formaPago as TIPOPAGO from TiposPago
		where id != 2
		 
	end



GO
/****** Object:  StoredProcedure [dbo].[obtener_tipos_transacciones_cp]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
	CREATE procedure [dbo].[obtener_tipos_transacciones_cp]
	
	as
	
	begin
		select id as ID, transaccion as TRANSACCION from TipoTransaccion
		where id != 1 and id != 3 and id != 4
		 
	end



GO
/****** Object:  StoredProcedure [dbo].[obtener_todos_ciudades]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

	create procedure [dbo].[obtener_todos_ciudades]
	@idPais int
	as
	
	begin
		select id as ID, ciudad as CIUDAD, estado as ESTADO from Ciudades
		where idPais = @idPais
	end



GO
/****** Object:  StoredProcedure [dbo].[obtener_todos_clientes]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[obtener_todos_clientes]
as
begin

	select C.id as ID, C.cliente as CLIENTE, C.rnc_cedula as 'RNC/CEDULA', C.direccion as DIRECCION ,
	telefono as 'TEL.',P.pais as PAIS, Ci.ciudad as CIUDAD ,C.estado as HABILITADO
	
	from Clientes C left join Paises P on P.id = C.id_pais left join Ciudades Ci on Ci.id = C.id_ciudad
	
end


--***********************************************NEW*********************************************************************
--*************************************************************************************************************************
--*************************************************************************************************************************



GO
/****** Object:  StoredProcedure [dbo].[obtener_todos_colores]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
	create procedure [dbo].[obtener_todos_colores]
	as
	
	begin
		select id as ID, color as COLOR, estado as ESTADO from Colores 
	end



GO
/****** Object:  StoredProcedure [dbo].[obtener_todos_componentes]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[obtener_todos_componentes]
@idFabricante int, @idModelo int, @año int
as


begin

	select componente as REPUESTO, precio_rd as 'PRECIO ($RD)', precio_usd as 'PRECIO ($USD)', estado as HABILITADO, id as ID
	from Componentes
	where fabricante_id = @idFabricante AND modelo_id = @idModelo AND año = @año

end






GO
/****** Object:  StoredProcedure [dbo].[obtener_todos_fabricantes]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[obtener_todos_fabricantes]
as


begin

	select id as ID, fabricante as FABRICANTE, codigo as CODIGO, estado as HABILITADO from Fabricantes
	ORDER BY FABRICANTE
end






GO
/****** Object:  StoredProcedure [dbo].[obtener_todos_gastos]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[obtener_todos_gastos]
as

begin 

	select id as ID, descripcion as DESCRIPCION, tipo as 'TIPO GASTO', estado as HABILITADO
	from Gastos
end






GO
/****** Object:  StoredProcedure [dbo].[obtener_todos_modelos]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[obtener_todos_modelos]
@idFabricante int
as


begin

	select m.id as ID, m.modelo as MODELO, m.codigo as CODIGO, m.estado as HABILITADO 
	from Modelos m join Fabricantes f on m.fabricante_id = f.id 
	where m.fabricante_id = @idFabricante
	order by MODELO
end






GO
/****** Object:  StoredProcedure [dbo].[obtener_todos_paises]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
	create procedure [dbo].[obtener_todos_paises]
	as
	
	begin
		select id as ID, pais as PAIS, estado as ESTADO from Paises 
	end



GO
/****** Object:  StoredProcedure [dbo].[obtener_todos_propietarios]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[obtener_todos_propietarios]

as


begin

	select id as ID, nombre as PROPIETARIO,rncCedula as 'RNC/CEDULA', direccion as DIRECCION ,telefono as 'TEL.', estado as HABILITADO
	from Propietarios
	
end






GO
/****** Object:  StoredProcedure [dbo].[obtener_todos_seguros]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
	create procedure [dbo].[obtener_todos_seguros]
	as
	
	begin
		select id as ID, nombre as NOMBRE,telefono as TELEFONO ,estado as ESTADO from Seguros 
	end



GO
/****** Object:  StoredProcedure [dbo].[obtener_todos_suplidores]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
	create procedure [dbo].[obtener_todos_suplidores]
	as
	
	begin
		select S.id as ID,S.suplidor as SUPLIDOR,S.rnc_cedula as 'RNC/CEDULA' ,P.pais as PAIS, C.ciudad as CIUDAD,
		 S.direccion as DIRECCION,S.telefono ,S.estado as ESTADO
		from Suplidores S join Paises P on P.id = S.id_pais
		join Ciudades C on C.id = S.id_ciudad
	end



GO
/****** Object:  StoredProcedure [dbo].[obtener_todos_talleresRepuestos]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[obtener_todos_talleresRepuestos]

as


begin

	select id as ID ,taller as 'TALLER O TIENDA', direccion as DIRECCION, telefono1 as 'TEL. 1', telefono2 as 'TEL. 2', estado as HABILITADO
	from TalleresRepuestos
	

end






GO
/****** Object:  StoredProcedure [dbo].[obtener_todos_tipos_pagos]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[obtener_todos_tipos_pagos]

as


begin

	select id as ID, formaPago as TIPOPAGO from TiposPago
	
end






GO
/****** Object:  StoredProcedure [dbo].[obtener_todos_ubicaciones]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
	create procedure [dbo].[obtener_todos_ubicaciones]
	as
	
	begin
		select U.id as ID, P.pais as PAIS, C.ciudad as CIUDAD, U.ubicacion as LUGAR, U.estado as ESTADO
		from Ubicaciones U join Paises P on P.id = U.id_pais
		join Ciudades C on C.id = U.id_ciudad
	end



GO
/****** Object:  StoredProcedure [dbo].[obtener_todos_usuarios]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[obtener_todos_usuarios]
as
begin

	select id as ID, usuario as USUARIO, nombreApellido as NOMBRE, tasaDolar as 'TASA CAMBIO', 
	crearUsuarios as 'CREAR USUARIOS', fabricantesModelos as 'CREAR FABRICANTES/MODELOS',
	piezasRepuestos as 'CREAR PIEZAS/REPUESTOS', crearTaller as 'CREAR TALLER', crearPropietarios as 'CREAR PROPIETARIOS', 
	crearClientes as 'CREAR CLIENTES',crearGastos as 'CREAR GASTOS', importarVehiculo 'VEHICULOS INVENTARIO', 
	compras as 'COMPRAS', cambiarEstadosVehiculo as 'CAMBIAR ESTADO VEHICULOS',
	agreagarGastos as 'AGREGAR GASTO A VEHICULO', agregarPiezas as 'AGREGAR PIEZAS A VEHICULO', 
	facturacion as 'FACTURACION',modificarVehiculo as 'MODIFICAR VEHICULO', cuentasPagar as 'CUENTAS PAGAR' ,cuentasCobrar as 'CUENTAS COBRAR',
	reportes as REPORTES, actualizarDiarioTasa as 'ACTUALIZAR TASA DIARIO' ,estadoUsuario as 'ESTADO USUARIO', clave as CLAVE,
	agregar_paises as 'AGREGAR PAISES', agregar_ciudades as 'AGREGAR CIUDADES', agregar_colores as 'AGREGAR COLORES',
	agregar_ubicaciones as 'AGREGAR UBICACIONES', agregar_suplidores as 'AGREGAR SUPLIDORES', agregar_seguros as 'AGREGAR SEGUROS',
	AgregarCCCP as 'AGREGAR CUENTAS ANTIGUAS'
	from Usuarios where id != 1
	
end


GO
/****** Object:  StoredProcedure [dbo].[obtener_total_a_cobrar_credito_vehiculo]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[obtener_total_a_cobrar_credito_vehiculo]
@idCC int
as

begin
	select monto_rd as 'CREDITO RD' , monto_usd as 'CREDITO USD' 
	from CuentasCobrar where id = @idCC
		
			
end




GO
/****** Object:  StoredProcedure [dbo].[obtener_total_a_pagar_credito_vehiculo]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[obtener_total_a_pagar_credito_vehiculo]
@idCP int
as

begin
	select monto_rd as 'CREDITO RD' , monto_usd as 'CREDITO USD' 
	from CuentasPagar where id = @idCP
		
			
end



GO
/****** Object:  StoredProcedure [dbo].[obtener_ubicaciones_activos]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

	create procedure [dbo].[obtener_ubicaciones_activos]
	as
	
	begin
		select id as ID, ubicacion as LUGAR, estado as ESTADO from Ubicaciones  where estado = 1
	end




GO
/****** Object:  StoredProcedure [dbo].[obtener_vehiculo_componentes]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[obtener_vehiculo_componentes]
@idVehiculo int
as

begin
	
	select C.componente as DESCRIPCION, GV.monto_rd as'PRECIO ($RD)',GV.monto_usd 'PRECIO ($USD)' , GV.id as ID,
	GV.fecha as FECHA
	from GastoVehiculo GV join Componentes C on C.id = GV.id_gasto
	where GV.id_vehiculo = @idVehiculo and GV.id_transaccion = 5
	
end





GO
/****** Object:  StoredProcedure [dbo].[obtener_vehiculo_gastos_aduanales]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[obtener_vehiculo_gastos_aduanales]
@idVehiculo int
as


begin

	select G.descripcion as DESCRIPCION, TR.taller as TALLER ,GV.monto_rd as'PRECIO ($RD)', Gv.monto_usd as 'PRECIO ($USD)' , GV.id as ID,
	GV.fecha as FECHA
	from GastoVehiculo GV join Gastos G on GV.id_gasto = G.id join TalleresRepuestos TR on GV.id_proveedor = TR.id
	where GV.id_vehiculo = @idVehiculo and GV.id_transaccion = 7
	
end





GO
/****** Object:  StoredProcedure [dbo].[obtener_vehiculo_gastos_reparacion]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[obtener_vehiculo_gastos_reparacion]
@idVehiculo int
as


begin

	select G.descripcion as DESCRIPCION, TR.taller as TALLER ,GV.monto_rd as'PRECIO ($RD)', Gv.monto_usd as 'PRECIO ($USD)' , GV.id as ID,
	GV.fecha as FECHA
	from GastoVehiculo GV join Gastos G on GV.id_gasto = G.id join TalleresRepuestos TR on GV.id_proveedor = TR.id
	where GV.id_vehiculo = @idVehiculo and GV.id_transaccion = 6
	
end



GO
/****** Object:  StoredProcedure [dbo].[obtener_vehiculos]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[obtener_vehiculos]
@tipo varchar(50), @desde date, @hasta date
as
/*
format(@desde,'dd/MM/yyyy') and format(@hasta,'dd/MM/yyyy')
*/

begin
	if @tipo = 'proceso'
		begin
			select V.id as ID,F.fabricante as MARCA, M.modelo as MODELO, V.año as AÑO, V.color as COLOR ,total_invertido_rd as 'COSTO ($RD)',
			total_invertido_usd as 'COSTO($USD)' , P.nombre as PROPIETARIO, 
			V.vin as VIN, V.nota as DETALLES, format(V.fecha_importe, 'dd/MM/yyyy' )as 'FECHA COMPRA', V.acto_venta as 'ACTO DE VENTA',
			v.matricula as 'MATRICULA ORIGINAL', V.cedula_vendedor as 'CEDULA VENDEDOR', U.ubicacion as 'UBICACION',  S.suplidor as SUPLIDOR, 
			V.numero_matricula as '#Matrícula', V.placa as PLACA, V.millaje as MILLAJE, 
			v.fuerza_motriz as 'FUERZA MOTRIZ'
			from Vehiculos V join Fabricantes F on V.fabricante_id = F.id join Modelos M on V.modelo_id = M.id
			join Propietarios P on V.id_propietario = P.id join Ubicaciones U on U.id = V.id_ubicacion 
			join Suplidores S on S.id = V.id_suplidor
			where format(V.fecha_importe,'yyyy-MM-dd')  between  format(@desde,'yyyy-MM-dd') and format(@hasta,'yyyy-MM-dd')
			and V.terminado = 0 and V.vendido = 0 and V.estado = 1
			ORDER By ID DESC
		end
	else if @tipo = 'terminado'
		begin
			select V.id as ID,F.fabricante as MARCA, M.modelo as MODELO, V.año as AÑO, V.color as COLOR ,total_invertido_rd as 'COSTO($RD)',
			total_invertido_usd as 'COSTO($USD)' , P.nombre as PROPIETARIO, 
			V.vin as VIN, V.nota as DETALLES, format(V.fecha_importe, 'dd/MM/yyyy' )as 'FECHA COMPRADO', 
			format(V.fecha_terminado, 'dd/MM/yyyy' )as 'FECHA INVENTARIO' , V.acto_venta as 'ACTO DE VENTA',
			v.matricula as 'MATRICULA ORIGINAL', V.cedula_vendedor as 'CEDULA VENDEDOR', U.ubicacion as 'UBICACION',  S.suplidor as SUPLIDOR, 
			V.numero_matricula as '#Matrícula', V.placa as PLACA, V.millaje as MILLAJE, 
			v.fuerza_motriz as 'FUERZA MOTRIZ'  
			from Vehiculos V join Fabricantes F on V.fabricante_id = F.id join Modelos M on V.modelo_id = M.id
			join Propietarios P on V.id_propietario = P.id join Ubicaciones U on U.id = V.id_ubicacion
			join Suplidores S on S.id = V.id_suplidor
			where format(V.fecha_importe,'yyyy-MM-dd')  between  format(@desde,'yyyy-MM-dd') and format(@hasta,'yyyy-MM-dd')
			and V.terminado = 1 and vendido = 0 and V.estado = 1
			ORDER By ID DESC
		end
	end





GO
/****** Object:  StoredProcedure [dbo].[obtener_vehiculos_no_vendidos]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[obtener_vehiculos_no_vendidos]

as

begin


	select  
	CONVERT(varchar(200),(F.fabricante + ' ' + M.modelo + ' ' + CONVERT(varchar(10), V.año) + ' ' + V.color + ' --> ' + V.vin)) as VEHICULO, 
	V.id as ID
	from Vehiculos V 
	join Fabricantes F on V.fabricante_id = F.id join Modelos M on V.modelo_id = M.id
	
	and v.vendido = 0


end





GO
/****** Object:  StoredProcedure [dbo].[obtener_vehiculos_para_facturar]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[obtener_vehiculos_para_facturar]

as

begin


	select  
	CONVERT(varchar(200),(F.fabricante + ' ' + M.modelo + ' ' + CONVERT(varchar(10), V.año) + ' ' + V.color)) as VEHICULO, 
	V.id as ID
	from Vehiculos V 
	join Fabricantes F on V.fabricante_id = F.id join Modelos M on V.modelo_id = M.id
	
	and V.terminado = 1 and v.vendido = 0


end





GO
/****** Object:  StoredProcedure [dbo].[registrar_cc_cp_antigua]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[registrar_cc_cp_antigua]
@tipoCuenta varchar(10), @idClienteSuplidor int, @idTransaccion int, @montoRD float,
@montoUSD float, @idGastoPieza int, @fecha date,
@nota varchar(300), @mensaje int output
as
set @mensaje = 0;
begin

	if @tipoCuenta = 'COBRAR'
		begin
			insert into CuentasCobrar (id_vehiculo, id_factura, id_cliente, id_transaccion, monto_rd, monto_usd,
			balance_rd, balance_usd, fecha, nueva, nota)
			VALUES (0, 0, @idClienteSuplidor, @idTransaccion, @montoRD, @montoUSD, @montoRD, @montoUSD,
			@fecha, 0, @nota) 
			set @mensaje = 1
		end
	else --PAGAR
		begin
			insert into CuentasPagar(id_vehiculo, id_factura, id_vendedor, id_transaccion, monto_rd, monto_usd,
			balance_rd, balance_usd, fecha, nueva, nota, id_gasto)
			VALUES (0, 0, @idClienteSuplidor, @idTransaccion, @montoRD, @montoUSD, @montoRD, @montoUSD,
			@fecha, 0, @nota, @idGastoPieza) 
			set @mensaje = 1
		end

end

GO
/****** Object:  StoredProcedure [dbo].[registrar_ciudad]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

	create procedure [dbo].[registrar_ciudad]
	@idPais int,@ciudad varchar(100), @estado bit, @mensaje int output
	as
	set @mensaje = 0;
	begin
		insert into Ciudades(idPais,ciudad,estado)
		Values (@idPais,@ciudad ,@estado)
		set @mensaje = 1;
	
	end



GO
/****** Object:  StoredProcedure [dbo].[registrar_cliente]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[registrar_cliente]
@cliente varchar(200), @cedulaRNC varchar(50), @tel varchar(50), @estado bit, @mensaje int output, @direccion varchar(200),
@idPais int, @idCiudad int
as
set @mensaje = 0

begin

	if not exists(select * from Clientes where cliente = @cliente or rnc_cedula = @cedulaRNC)
		begin
			insert into Clientes(cliente, rnc_cedula, telefono, estado, direccion, id_pais, id_ciudad)
			VALUES (@cliente, @cedulaRNC, @tel, @estado, @direccion, @idPais, @idCiudad)
			set @mensaje = 1

		end

	else
		begin 
			set @mensaje = 2
		end
end




GO
/****** Object:  StoredProcedure [dbo].[registrar_color]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

	create procedure [dbo].[registrar_color]
	@color varchar(100), @estado bit, @mensaje int output
	as
	set @mensaje = 0;
	begin
		insert into Colores (color,estado)
		Values (@color, @estado)
		set @mensaje = 1;
	
	end




GO
/****** Object:  StoredProcedure [dbo].[registrar_componentes]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[registrar_componentes]
@idFabricante int, @idModelo int, @año int, @componente varchar(200), @precioUsd float, 
@precioRd float, @estado bit, @mensaje int output
as
set @mensaje = 0

begin

	if not exists(select * from Componentes where fabricante_id = @idFabricante AND modelo_id = @idModelo AND año = @año AND componente = @componente)
		begin
			insert into Componentes (fabricante_id, modelo_id,año, componente, precio_rd, precio_usd, estado)
			VALUES (@idFabricante, @idModelo, @año, @componente, @precioRd, @precioUsd, @estado)
			set @mensaje = 1

		end

	else
		begin 
			set @mensaje = 2
		end
end






GO
/****** Object:  StoredProcedure [dbo].[registrar_detalle_cc_cp_antigua]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[registrar_detalle_cc_cp_antigua]
@tipoCuenta varchar(10), @idFabricante int, @idModelo int, @año int, @color varchar(100),
@chasis varchar(50), @idSeguro int, @duracion int ,@mensaje int output
as
set @mensaje = 0;
declare @idTipoCuenta int;
declare @idCuenta int;
begin

	if @tipoCuenta = 'COBRAR'
		begin
			set @idTipoCuenta = 2 
			set @idCuenta = (select Max(id) from CuentasCobrar)
			insert into Detalle_CC_CP_Antiguas (id_cuenta, id_fabricante, id_modelo, año, color, id_seguro, dias_seguro, chasis, id_tipo_cuenta)
			Values(@idCuenta, @idFabricante, @idModelo, @año, @color, @idSeguro, @duracion, @chasis, @idTipoCuenta)
			set @mensaje = 1
		end
	else --PAGAR
		begin
			set @idTipoCuenta = 1
			set @idCuenta = (select Max(id) from CuentasPagar)
			insert into Detalle_CC_CP_Antiguas (id_cuenta, id_fabricante, id_modelo, año, color, id_seguro, dias_seguro, chasis, id_tipo_cuenta)
			Values(@idCuenta, @idFabricante, @idModelo, @año, @color, @idSeguro, @duracion, @chasis, @idTipoCuenta)
			set @mensaje = 1
		end

end


GO
/****** Object:  StoredProcedure [dbo].[registrar_fabricante]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[registrar_fabricante]
@fabricante varchar(50), @codigo varchar(50), @estado bit, @mensaje int output
as
set @mensaje = 0
begin
	if exists(select * from Fabricantes where fabricante = @fabricante OR codigo = @codigo)
		begin
			set @mensaje = 2
		end
	else
		begin
			insert into Fabricantes(codigo, fabricante, estado)
			Values (@codigo, @fabricante, @estado)
			set @mensaje = 1
		end
end






GO
/****** Object:  StoredProcedure [dbo].[registrar_gasto]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[registrar_gasto]
@descripcion varchar(250),@tipo varchar(50), @estado bit, @mensaje int output
as
set @mensaje = 0

begin

	if not exists(select * from Gastos where descripcion = @descripcion)
		begin
			insert into Gastos(descripcion, tipo, estado)
			VALUES (@descripcion, @tipo, @estado)
			set @mensaje = 1

		end

	else
		begin 
			set @mensaje = 2
		end
end






GO
/****** Object:  StoredProcedure [dbo].[registrar_modelo]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[registrar_modelo]
@modelo varchar(50), @codigo varchar(50), @estado bit, @id_fabricante int,@mensaje int output
as
set @mensaje = 0
begin
	if exists(select * from Modelos where modelo = @modelo OR codigo = @codigo and fabricante_id = @id_fabricante)
		begin
			set @mensaje = 2
		end
	else
		begin
			insert into Modelos(fabricante_id ,codigo, modelo, estado)
			Values (@id_fabricante,@codigo, @modelo, @estado)
			set @mensaje = 1
		end
end






GO
/****** Object:  StoredProcedure [dbo].[registrar_pago_cuenta_cobrar]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[registrar_pago_cuenta_cobrar]
@idVehiculo int, @montoRD float, @montoUSD float, @detalles varchar(200), @mensaje bit output, @fecha date,
@idTipoPago int, @idCC int
as
set @mensaje = 0;
begin
	
	
	update CuentasCobrar set balance_rd = balance_rd - @montoRD, balance_usd = balance_usd - @montoUSD where
	id_vehiculo = @idVehiculo and id = @idCC
	
	declare @balanceRD float= (Select balance_rd from CuentasCobrar where id = @idCC)
	declare @balanceUSD float= (Select balance_usd from CuentasCobrar where id = @idCC)

	insert into PagosCuentasCobrar(id_cuentaCobrar, monto_rd, monto_usd, nota, fecha, id_tipoPago, balance_rd, balance_usd)
	VALUES (@idCC, @montoRD, @montoUSD, @detalles, @fecha, @idTipoPago, @balanceRD, @balanceUSD)
	
	if @idTipoPago = 1
			begin
				 insert into DetallesEfectivoGeneral(idVehiculo, tipoCuenta, montoRD, montoUSD, fecha, documento, numeroDocumento)
				 values (@idVehiculo, 2, @montoRD, @montoUSD, @fecha, 'CxC RECIBO PAGO', (select MAX(id) from CuentasCobrar))
			end
	set @mensaje = 1;
end




GO
/****** Object:  StoredProcedure [dbo].[registrar_pago_cuenta_pagar]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[registrar_pago_cuenta_pagar]
@idVehiculo int, @montoRD float, @montoUSD float, @detalles varchar(200), @mensaje bit output, @fecha date,
@idTipoPago int, @idCP int
as
set @mensaje = 0;
begin

	update CuentasPagar set balance_rd = balance_rd - @montoRD, balance_usd = balance_usd - @montoUSD where
	id_vehiculo = @idVehiculo and id = @idCP
	declare @balanceRD float= (Select balance_rd from CuentasPagar where id = @idCP)
	declare @balanceUSD float= (Select balance_usd from CuentasPagar where id = @idCP)

	insert into PagosCuentasPagar(id_cuentaPagar, monto_rd, monto_usd, nota, fecha, id_tipoPago, balance_rd, balance_usd)
	VALUES (@idCP, @montoRD, @montoUSD, @detalles, @fecha, @idTipoPago, @balanceRD, @balanceUSD)
	
	

	
	
	if @idTipoPago = 1
		begin
			insert into DetallesEfectivoGeneral(idVehiculo, tipoCuenta, montoRD, montoUSD, fecha, documento, numeroDocumento)
			values (@idVehiculo, 1, @montoRD, @montoUSD, @fecha, 'CxP RECIBO PAGO', (select MAX(id) from CuentasPagar))
		end

	set @mensaje = 1;
end




GO
/****** Object:  StoredProcedure [dbo].[registrar_pais]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

	create procedure [dbo].[registrar_pais]
	@pais varchar(100), @estado bit, @mensaje int output
	as
	set @mensaje = 0;
	begin
		insert into Paises (pais,estado)
		Values (@pais, @estado)
		set @mensaje = 1;
	
	end



GO
/****** Object:  StoredProcedure [dbo].[registrar_propietario]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[registrar_propietario]
@propietario varchar(50), @tel varchar(50), @estado bit, @mensaje int output, @direccion varchar(200),
@rncCedula varchar(50)
as
set @mensaje = 0

begin

	if not exists(select * from Propietarios where rncCedula = @rncCedula)
		begin
			insert into Propietarios(nombre, telefono, estado, direccion, rncCedula)
			VALUES (@propietario, @tel, @estado, @direccion, @rncCedula)
			set @mensaje = 1

		end

	else
		begin 
			set @mensaje = 2
		end
end






GO
/****** Object:  StoredProcedure [dbo].[registrar_seguro]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

	create procedure [dbo].[registrar_seguro]
	@nombre varchar(100),@telefono varchar(50) ,@estado bit, @mensaje int output
	as
	set @mensaje = 0;
	begin
		insert into Seguros (nombre, telefono, estado)
		Values (@nombre,@telefono ,@estado)
		set @mensaje = 1;
	
	end



GO
/****** Object:  StoredProcedure [dbo].[registrar_suplidor]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

	create procedure [dbo].[registrar_suplidor]
	@suplidor varchar(100), @rnc_cedula varchar(100), @idPais int, @idCiudad int , @direccion varchar(100),
	@telefono varchar(100) ,@estado bit, @mensaje int output
	as
	set @mensaje = 0;
	begin
		insert into Suplidores(suplidor, rnc_cedula,id_pais, id_ciudad, direccion, telefono, estado)
		Values (@suplidor,@rnc_cedula,@idPais, @idCiudad, @direccion ,@telefono ,@estado)
		set @mensaje = 1;
	
	end




GO
/****** Object:  StoredProcedure [dbo].[registrar_talleres]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[registrar_talleres]
@taller varchar(100), @direccion varchar(200),@tel1 varchar(50), @tel2 varchar(50),@estado bit, @mensaje int output
as
set @mensaje = 0

begin

	if not exists(select * from TalleresRepuestos where taller =@taller)
		begin
			insert into TalleresRepuestos (taller, direccion, telefono1, telefono2, estado)
			VALUES (@taller, @direccion, @tel1, @tel2, @estado)
			set @mensaje = 1

		end

	else
		begin 
			set @mensaje = 2
		end
end






GO
/****** Object:  StoredProcedure [dbo].[registrar_ubicacion]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

	create procedure [dbo].[registrar_ubicacion]
	@ubicacion varchar(100),@idPais int, @idCiudad int ,@estado bit, @mensaje int output
	as
	set @mensaje = 0;
	begin
		insert into Ubicaciones(id_pais, id_ciudad, ubicacion, estado)
		Values (@idPais, @idCiudad, @ubicacion ,@estado)
		set @mensaje = 1;
	
	end




GO
/****** Object:  StoredProcedure [dbo].[registrar_usuarios]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[registrar_usuarios]
@usuario varchar(50), @nombre varchar(50), @clave varchar(50), @tasaDolar bit, @crearUsuarios bit,
@fabricantesModelos bit, @piezasRepuestos bit, @crearTaller bit, @crearPropietarios bit, @crearClientes bit, 
@crearGastos bit, @importarVehiculos bit, @compras bit, @cambiarEstadosVehiculos bit, @agregarGastos bit,
@agregarPiezas bit, @facturacion bit, @reportes bit, @estado bit, @mensaje int output, @modificarVehiculo bit, 
@cuentasPagar bit, @cuentasCobrar bit, @actualizarTasaDiario bit, @crearPais bit, @crearCiudad bit, @crearSuplidor bit,
@crearColor bit, @crearUbicacion bit, @crearSeguros bit, @agregarCuentasAntiguas bit
as
set @mensaje = 0

begin

	if not exists(select * from Usuarios where usuario = @usuario)
		begin
			insert into Usuarios(usuario, clave, nombreApellido, tasaDolar, crearUsuarios, fabricantesModelos,
			 piezasRepuestos, crearTaller, crearPropietarios, crearClientes, crearGastos, importarVehiculo, 
			 compras, cambiarEstadosVehiculo, agreagarGastos, agregarPiezas, facturacion, reportes, estadoUsuario,
			 modificarVehiculo, cuentasCobrar, cuentasPagar, actualizarDiarioTasa, agregar_paises, agregar_ciudades,
			 agregar_suplidores, agregar_colores, agregar_ubicaciones, agregar_seguros, AgregarCCCP) 
			VALUES(@usuario, @clave, @nombre, @tasaDolar, @crearUsuarios, @fabricantesModelos, @piezasRepuestos,
			@crearTaller, @crearPropietarios, @crearClientes, @crearGastos, @importarVehiculos, @compras,
			@cambiarEstadosVehiculos, @agregarGastos, @agregarPiezas, @facturacion, @reportes, @estado, @modificarVehiculo,
			@cuentasCobrar, @cuentasPagar, @actualizarTasaDiario, @crearPais, @crearCiudad, @crearSuplidor, @crearColor,
			@crearUbicacion, @crearSeguros, @agregarCuentasAntiguas) 
			set @mensaje = 1

		end

	else
		begin 
			set @mensaje = 2
		end
end



GO
/****** Object:  StoredProcedure [dbo].[registrar_vehiculo]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[registrar_vehiculo]
@idFabricante int, @idModelo int, @año int, @precioUsd float,@vin varchar(50), @idPropietario int, @fecha date,
@nota varchar(250),@precioRd float, @mensaje int output, @color varchar(50),
@matriculaOriginal bit, @cedulaVendedor bit, @actoVenta bit, @idUbicacion int, @rdPrecioVentaEstimado float,
@usdPrecioVentaEstimado float, @placa varchar(30), @numeroMatricula varchar(100), @millaje varchar(100),
@fuerzaMotriz varchar(30), @idSuplidor int

as
set @mensaje = 0

begin

	insert into Vehiculos(fabricante_id, modelo_id, año, precioUSD, precioRD, id_propietario, terminado, 
	vendido, pagado, fecha_importe, vin, nota, estado,total_invertido_rd, total_invertido_usd, color, matricula, acto_venta, cedula_vendedor, id_ubicacion,
	precio_estimado_rd, precio_estimado_usd, placa, numero_matricula, millaje, fuerza_motriz, id_suplidor)
	VALUES(@idFabricante, @idModelo, @año, @precioUsd, @precioRd, @idPropietario, 0,0,0,@fecha, @vin, @nota, 1, @precioRd,
	@precioUsd, @color, @matriculaOriginal, @actoVenta, @cedulaVendedor, @idUbicacion, @rdPrecioVentaEstimado, @usdPrecioVentaEstimado,
	@placa, @numeroMatricula, @millaje, @fuerzaMotriz, @idSuplidor)
	
	insert into HistorialUbicaciones(id_vehiculo, id_ubicacion, fecha)
	values ((SELECT MAX(id) from Vehiculos), @idUbicacion, @fecha)
	set @mensaje = 1
end



GO
/****** Object:  StoredProcedure [dbo].[reporte_cuentas_cobrar]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[reporte_cuentas_cobrar]
--@desde date, @hasta date
as

begin
	select  V.id as IDVEHICULO,V.fecha_vendido as  FECHAVENTA ,C.cliente as CLIENTE,
			CONVERT(varchar(200),(F.fabricante + ' ' + M.modelo + ' ' + CONVERT(varchar(10), V.año) + ' ' + V.color)) as VEHICULO, V.vin as CHASIS,
			CC.monto_rd as TOTALPAGARRD, CC.monto_usd as TOTALPAGARUSD, (CC.monto_rd - CC.balance_rd ) as PAGADORD,(CC.monto_usd - CC.balance_usd )as PAGADOUSD,
			cc.balance_rd as PENDIENTERD, cc.balance_usd as PENDIENTEUSD,
			ISNULL(DATEDIFF(DAY, format (v.fecha_vendido, 'yyyy-MM-dd'), format (GETDATE(), 'yyyy-MM-dd')), 0) as DIASVIGENTE, CC.id as IDCUENTACOBRAR,
			TP.transaccion as TRANSACCION, CC.id_factura as 'FACTURA'
			from Vehiculos V 
			join Clientes C on C.id = V.id_cliente join Fabricantes F on F.id = V.fabricante_id 
			join Modelos M on M.id = V.modelo_id  
			join CuentasCobrar CC on CC.id_vehiculo = V.id
			join TipoTransaccion TP on TP.id = CC.id_transaccion
			where V.vendido = 1 and (CC.balance_rd != 0 and CC.balance_usd !=0  ) and CC.nueva = 1
			
			--and format(CC.fecha,'yyyy-MM-dd') between
			--format (@desde, 'yyyy-MM-dd') and format (@hasta, 'yyyy-MM-dd')
			union

			select  V.id as IDVEHICULO, CC.fecha as  FECHAVENTA ,C.cliente as CLIENTE,
			CONVERT(varchar(200),(F.fabricante + ' ' + M.modelo + ' ' + CONVERT(varchar(10), V.año) + ' ' + V.color)) as VEHICULO, V.chasis CHASIS,
			CC.monto_rd as TOTALPAGARRD, CC.monto_usd as TOTALPAGARUSD, (CC.monto_rd - CC.balance_rd ) as PAGADORD,(CC.monto_usd - CC.balance_usd )as PAGADOUSD,
			cc.balance_rd as PENDIENTERD, cc.balance_usd as PENDIENTEUSD,
			ISNULL(DATEDIFF(DAY, format (CC.fecha, 'yyyy-MM-dd'), format (GETDATE(), 'yyyy-MM-dd')), 0) as DIASVIGENTE, CC.id as IDCUENTACOBRAR,
			TP.transaccion as TRANSACCION, CC.id_factura as 'FACTURA'
			from CuentasCobrar CC join Detalle_CC_CP_Antiguas V on V.id_cuenta = CC.id
			join Clientes C on C.id = CC.id_cliente join Fabricantes F on F.id = V.id_fabricante
			join Modelos M on M.id = V.id_modelo 
			
			join TipoTransaccion TP on TP.id = CC.id_transaccion
			where CC.nueva = 0 and V.id_tipo_cuenta = 2 and (CC.balance_rd != 0 and CC.balance_usd !=0  )
			
			--and format(CC.fecha,'yyyy-MM-dd') between
			--format (@desde, 'yyyy-MM-dd') and format (@hasta, 'yyyy-MM-dd')
			
			

			order by DIASVIGENTE DESC
end


GO
/****** Object:  StoredProcedure [dbo].[reporte_cuentas_pagar]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[reporte_cuentas_pagar]
@desde date, @hasta date, @idTransaccion int
as

begin

			select CP.id as CUENTAPAGAR,TP.transaccion as TRANSACCION , V.fecha_importe as  FECHACOMPRA ,S.suplidor as PROPIETARIO,
			CONVERT(varchar(200),(F.fabricante + ' ' + M.modelo + ' ' + CONVERT(varchar(10), V.año) + ' ' + V.color)) as VEHICULO,
			CP.monto_rd as TOTALPAGARRD, CP.monto_usd as TOTALPAGARUSD,
			(CP.monto_rd - CP.balance_rd) as PAGADORD, (CP.monto_usd - CP.balance_usd) as PAGADOUSD,
			CP.balance_rd as PENDIENTERD, CP.balance_usd as PENDIENTEUSD,
			ISNULL(DATEDIFF(DAY, format (v.fecha_importe, 'yyyy-MM-dd'),
			format (GETDATE(), 'yyyy-MM-dd')), 0) as DIASVIGENTE
			from CuentasPagar CP join Vehiculos V on V.id = CP.id_vehiculo join Suplidores S on S.id = V.id_suplidor
			join Fabricantes F on F.id = V.fabricante_id join Modelos M on M.id = V.modelo_id
			join TipoTransaccion TP on TP.id = CP.id_transaccion
			where CP.balance_rd > 0 and CP.balance_usd > 0 and CP.id_transaccion = 2
			and format(CP.fecha,'yyyy-MM-dd') between
			format (@desde, 'yyyy-MM-dd') and format (@hasta, 'yyyy-MM-dd')
			union
			select CP.id as CUENTAPAGAR,TP.transaccion as TRANSACCION , V.fecha_importe as  FECHACOMPRA , S.taller as PROPIETARIO,
			CONVERT(varchar(200),(F.fabricante + ' ' + M.modelo + ' ' + CONVERT(varchar(10), V.año) + ' ' + V.color)) as VEHICULO,
			CP.monto_rd as TOTALPAGARRD, CP.monto_usd as TOTALPAGARUSD,
			(CP.monto_rd - CP.balance_rd) as PAGADORD, (CP.monto_usd - CP.balance_usd) as PAGADOUSD,
			CP.balance_rd as PENDIENTERD, CP.balance_usd as PENDIENTEUSD,
			ISNULL(DATEDIFF(DAY, format (v.fecha_importe, 'yyyy-MM-dd'),
			format (GETDATE(), 'yyyy-MM-dd')), 0) as DIASVIGENTE
			from CuentasPagar CP join Vehiculos V on V.id = CP.id_vehiculo join TalleresRepuestos S on S.id = V.id_suplidor
			join Fabricantes F on F.id = V.fabricante_id join Modelos M on M.id = V.modelo_id
			join TipoTransaccion TP on TP.id = CP.id_transaccion 
			where CP.balance_rd > 0 and CP.balance_usd > 0 and CP.id_transaccion = 8
			and format(CP.fecha,'yyyy-MM-dd') between
			format (@desde, 'yyyy-MM-dd') and format (@hasta, 'yyyy-MM-dd')

	-- else if @idTransaccion = 4
	--	begin
	--		select CP.id as CUENTAPAGAR,TP.transaccion as TRANSACCION ,V.fecha_importe as  FECHACOMPRA ,S.nombre as PROPIETARIO,
	--		CONVERT(varchar(200),(F.fabricante + ' ' + M.modelo + ' ' + CONVERT(varchar(10), V.año) + ' ' + V.color)) as VEHICULO,
	--		CP.monto_rd as TOTALPAGARRD, CP.monto_usd as TOTALPAGARUSD,
	--		(CP.monto_rd - CP.balance_rd) as PAGADORD, (CP.monto_usd - CP.balance_usd) as PAGADOUSD,
	--		CP.balance_rd as PENDIENTERD, CP.balance_usd as PENDIENTEUSD,
	--		ISNULL(DATEDIFF(DAY, format (v.fecha_importe, 'yyyy-MM-dd'),
	--		format (GETDATE(), 'yyyy-MM-dd')), 0) as DIASVIGENTE
	--		from CuentasPagar CP join Vehiculos V on V.id = CP.id_vehiculo join Seguros S on S.id = V.id_suplidor
	--		join Fabricantes F on F.id = V.fabricante_id join Modelos M on M.id = V.modelo_id
	--		join TipoTransaccion TP on TP.id = CP.id_transaccion
	--		where CP.balance_rd > 0 and CP.balance_usd > 0 and CP.id_transaccion = 4
	--		and format(CP.fecha,'yyyy-MM-dd') between
	--		format (@desde, 'yyyy-MM-dd') and format (@hasta, 'yyyy-MM-dd')
	--	end
	
	--else if @idTransaccion = 5
	--	begin
	--		select CP.id as CUENTAPAGAR,TP.transaccion as TRANSACCION ,V.fecha_importe as  FECHACOMPRA ,S.taller as PROPIETARIO,
	--		CONVERT(varchar(200),(F.fabricante + ' ' + M.modelo + ' ' + CONVERT(varchar(10), V.año) + ' ' + V.color)) as VEHICULO,
	--		CP.monto_rd as TOTALPAGARRD, CP.monto_usd as TOTALPAGARUSD,
	--		(CP.monto_rd - CP.balance_rd) as PAGADORD, (CP.monto_usd - CP.balance_usd) as PAGADOUSD,
	--		CP.balance_rd as PENDIENTERD, CP.balance_usd as PENDIENTEUSD,
	--		ISNULL(DATEDIFF(DAY, format (v.fecha_importe, 'yyyy-MM-dd'),
	--		format (GETDATE(), 'yyyy-MM-dd')), 0) as DIASVIGENTE
	--		from CuentasPagar CP join Vehiculos V on V.id = CP.id_vehiculo join TalleresRepuestos S on S.id = CP.id_vendedor
	--		join Fabricantes F on F.id = V.fabricante_id join Modelos M on M.id = V.modelo_id
	--		join TipoTransaccion TP on TP.id = CP.id_transaccion
	--		where CP.balance_rd > 0 and CP.balance_usd > 0 
	--		and format(CP.fecha,'yyyy-MM-dd') between
	--		format (@desde, 'yyyy-MM-dd') and format (@hasta, 'yyyy-MM-dd') and CP.id_transaccion = 5
	--	end

	-- else if @idTransaccion = 6
	--	begin
	--		select CP.id as CUENTAPAGAR,TP.transaccion as TRANSACCION ,V.fecha_importe as  FECHACOMPRA ,S.taller as PROPIETARIO,
	--		CONVERT(varchar(200),(F.fabricante + ' ' + M.modelo + ' ' + CONVERT(varchar(10), V.año) + ' ' + V.color)) as VEHICULO,
	--		CP.monto_rd as TOTALPAGARRD, CP.monto_usd as TOTALPAGARUSD,
	--		(CP.monto_rd - CP.balance_rd) as PAGADORD, (CP.monto_usd - CP.balance_usd) as PAGADOUSD,
	--		CP.balance_rd as PENDIENTERD, CP.balance_usd as PENDIENTEUSD,
	--		ISNULL(DATEDIFF(DAY, format (v.fecha_importe, 'yyyy-MM-dd'),
	--		format (GETDATE(), 'yyyy-MM-dd')), 0) as DIASVIGENTE
	--		from CuentasPagar CP join Vehiculos V on V.id = CP.id_vehiculo join TalleresRepuestos S on S.id = CP.id_vendedor
	--		join Fabricantes F on F.id = V.fabricante_id join Modelos M on M.id = V.modelo_id
	--		join TipoTransaccion TP on TP.id = CP.id_transaccion
	--		where CP.balance_rd > 0 and CP.balance_usd > 0 
	--		and format(CP.fecha,'yyyy-MM-dd') between
	--		format (@desde, 'yyyy-MM-dd') and format (@hasta, 'yyyy-MM-dd') and CP.id_transaccion = 6
	--	end

	--else 
	--	begin
	--		select CP.id as CUENTAPAGAR,TP.transaccion as TRANSACCION ,V.fecha_importe as  FECHACOMPRA ,S.taller as PROPIETARIO,
	--		CONVERT(varchar(200),(F.fabricante + ' ' + M.modelo + ' ' + CONVERT(varchar(10), V.año) + ' ' + V.color)) as VEHICULO,
	--		CP.monto_rd as TOTALPAGARRD, CP.monto_usd as TOTALPAGARUSD,
	--		(CP.monto_rd - CP.balance_rd) as PAGADORD, (CP.monto_usd - CP.balance_usd) as PAGADOUSD,
	--		CP.balance_rd as PENDIENTERD, CP.balance_usd as PENDIENTEUSD,
	--		ISNULL(DATEDIFF(DAY, format (v.fecha_importe, 'yyyy-MM-dd'),
	--		format (GETDATE(), 'yyyy-MM-dd')), 0) as DIASVIGENTE
	--		from CuentasPagar CP join Vehiculos V on V.id = CP.id_vehiculo join TalleresRepuestos S on S.id = CP.id_vendedor
	--		join Fabricantes F on F.id = V.fabricante_id join Modelos M on M.id = V.modelo_id
	--		join TipoTransaccion TP on TP.id = CP.id_transaccion
	--		where CP.balance_rd > 0 and CP.balance_usd > 0 
	--		and format(CP.fecha,'yyyy-MM-dd') between
	--		format (@desde, 'yyyy-MM-dd') and format (@hasta, 'yyyy-MM-dd') and CP.id_transaccion = 7
	--	end

end


GO
/****** Object:  StoredProcedure [dbo].[reporte_datos_recibo_cobro_antiguo]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[reporte_datos_recibo_cobro_antiguo]
@idCC int
as
begin
	select C.cliente as CLIENTE, C.rnc_cedula as CEDULA,
	CONVERT(varchar(200),(F.fabricante + ' ' + M.modelo + ' ' + CONVERT(varchar(10), D.año) + ' ' + D.color)) as VEHICULO,
	S.nombre as SEGURO, D.dias_seguro as DURACION, CC.monto_rd as TOTALRD, CC.monto_usd as TOTALUSD, CC.nota as NOTA,
	D.chasis as CHASIS, CC.fecha as FECHA
	from CuentasCobrar CC join Clientes C on CC.id_cliente = C.id
	join Detalle_CC_CP_Antiguas D on D.id_cuenta = CC.id
	join Fabricantes F on D.id_fabricante = F.id join Modelos M on M.id = D.id_modelo
	left join Seguros S on S.id = D.id_seguro
	where CC.id = @idCC and D.id_tipo_cuenta = 2 and CC.nueva = 0
	 
end


GO
/****** Object:  StoredProcedure [dbo].[reporte_detalle_seguro]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[reporte_detalle_seguro]
@idVehiculo int
as
-- PAGOS VENTA
begin
	
	begin
		
		select P.monto_usd as PAGO, format(P.fecha,'dd/MM/yyyy') as FECHAPAGO, P.monto_rd as PAGORD,
		P.nota as DETALLEPAGO, TP.formaPago as TIPOPAGO
		from Vehiculos V join FormaVentaVehiculo P on V.id = P.id_vehiculo left join TiposPago TP on TP.id = P.id_tipo_pago
		where V.id = @idVehiculo and P.id_transaccion = 4	
	end
	
end




GO
/****** Object:  StoredProcedure [dbo].[reporte_detalle_seguro_vehiculo]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[reporte_detalle_seguro_vehiculo]
@idVehiculo int
as
-- PAGOS VENTA
begin
	
	begin
		
		select P.monto_usd as PAGO, format(P.fecha,'dd/MM/yyyy') as FECHAPAGO, P.monto_rd as PAGORD,
		P.nota as DETALLEPAGO, TP.formaPago as TIPOPAGO
		from  FormaVentaVehiculo P join Vehiculos V on V.id = P.id_vehiculo join TiposPago TP on TP.id = P.id_tipo_pago
		where P.id_vehiculo = @idVehiculo and P.id_transaccion = 4
	end
	
end



GO
/****** Object:  StoredProcedure [dbo].[reporte_detalle_traspaso]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[reporte_detalle_traspaso]
@idVehiculo int
as
-- PAGOS VENTA
begin
	
	begin
		
		select P.monto_usd as PAGO, format(P.fecha,'dd/MM/yyyy') as FECHAPAGO, P.monto_rd as PAGORD,
		P.nota as DETALLEPAGO, TP.formaPago as TIPOPAGO
		from Vehiculos V join FormaVentaVehiculo P on V.id = P.id_vehiculo left join TiposPago TP on TP.id = P.id_tipo_pago
		where V.id = @idVehiculo and P.id_transaccion = 3	
	end
	
end




GO
/****** Object:  StoredProcedure [dbo].[reporte_detalle_traspaso_vehiculo]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[reporte_detalle_traspaso_vehiculo]
@idVehiculo int
as
-- PAGOS VENTA
begin
	
	begin
		
		select P.monto_usd as PAGO, format(P.fecha,'dd/MM/yyyy') as FECHAPAGO, P.monto_rd as PAGORD,
		P.nota as DETALLEPAGO, TP.formaPago as TIPOPAGO
		from Vehiculos V join FormaVentaVehiculo P on V.id = P.id_vehiculo left join TiposPago TP on TP.id = P.id_tipo_pago
		where V.id = @idVehiculo and P.id_transaccion = 3
	end
	
end



GO
/****** Object:  StoredProcedure [dbo].[reporte_efectivo_cobrado]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[reporte_efectivo_cobrado]
@desde date, @hasta date

as 

begin 
	select DEG.fecha as FECHACOBRO, V.vin as CHASIS, DEG.montoRD as MONTORD,
	DEG.montoUSD as MONTOUSD, C.cliente as CLIENTE, 
	(DEG.documento + ' #' +  Convert (varchar(50),FORMAT(DEG.numeroDocumento, '000000'))) as DOCUMENTO
	from DetallesEfectivoGeneral DEG  join Vehiculos V on V.id = DEG.idVehiculo
	join Clientes C on C.id = V.id_cliente
	where DEG.tipoCuenta = 2 and format(DEG.fecha,'yyyy-MM-dd') between
	format (@desde, 'yyyy-MM-dd') and format (@hasta, 'yyyy-MM-dd')

	union

	select DEG.fecha as FECHACOBRO, V.chasis as CHASIS, DEG.montoRD as MONTORD,
	DEG.montoUSD as MONTOUSD, C.cliente as CLIENTE, 
	(DEG.documento + ' #' +  Convert (varchar(50),FORMAT(DEG.numeroDocumento, '000000'))) as DOCUMENTO
	from DetallesEfectivoGeneral DEG  join CuentasCobrar CC on CC.id = DEG.numeroDocumento join Detalle_CC_CP_Antiguas V on V.id_cuenta = CC.id
	join Clientes C on C.id = CC.id_cliente
	where DEG.tipoCuenta = 2 and format(DEG.fecha,'yyyy-MM-dd') between
	format (@desde, 'yyyy-MM-dd') and format (@hasta, 'yyyy-MM-dd')
end


GO
/****** Object:  StoredProcedure [dbo].[reporte_factura_obtener_monto_pendiente]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[reporte_factura_obtener_monto_pendiente]
@idVehiculo int
as

begin
	
	begin
		
		select ISNULL(sum(monto_rd), 0) as PENDIENTERD, ISNULL(sum(monto_usd), 0) as PENDIENTEUSD 
		from FormaVentaVehiculo
		where id_vehiculo = @idVehiculo and id_tipo_pago = 3
				
					
	
	end
	
end



GO
/****** Object:  StoredProcedure [dbo].[reporte_factura_seguro_precio]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[reporte_factura_seguro_precio]
@idVehiculo int
as

begin
	
	begin
		
		select S.nombre as SEGURO, PS.precioRD as PRECIORD, PS.precioUSD as PRECIOUSD, duracion_dias as DURACION
		from PreciosSeguroVehiculo PS join SeguroVehiculo SV on SV.id_vehiculo = PS.id_vehiculo
		join Seguros S on S.id = SV.id_seguro 
		where PS.id_vehiculo = @idVehiculo
		Group by S.nombre, PS.precioRD , PS.precioUSD, Sv.duracion_dias
		
	end
	
end



GO
/****** Object:  StoredProcedure [dbo].[reporte_factura_traspaso_precio]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[reporte_factura_traspaso_precio]
@idVehiculo int
as

begin
	
	begin
		
		select precioRD as PRECIORD, precioUSD as PRECIOUSD
		from PreciosTraspasoVehiculo 
		where id_vehiculo = @idVehiculo
		
	end
	
end



GO
/****** Object:  StoredProcedure [dbo].[reporte_factura_vehiculo]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[reporte_factura_vehiculo]
@idVehiculo int
as

begin
	
	begin
		
		select V.id as ID, F.fabricante as FABRICANTE, M.modelo as MODELO, V.año as AÑO, V.total_invertido_usd as INVERTIDO,
		V.precioVentaRD as PRECIORD, V.precioVentaUSD as PRECIO,V.vin as VIN, 
		format(V.fecha_importe,'dd/MM/yyyy') as IMPORTADO, V.nota as COMENTARIO, C.cliente as CLIENTE, C.rnc_cedula as CEDULA,
		format(V.fecha_vendido,'dd/MM/yyyy') as FVENDIDO, V.pagado as PAGADO, P.nombre as PROPIETARIO, V.vendido as VENDIDO,
		V.terminado as TERMINADO, V.nota as DETALLES, V.color as COLOR, fac.id as FACTURA, fac.nota_venta as NOTAVENTA
		from Vehiculos V join Fabricantes F on V.fabricante_id = F.id join Modelos M on V.modelo_id = M.id 
		join facturas fac on V.id = fac.idVehiculo join Propietarios P on V.id_propietario = P.id 
		left join Clientes C on V.id_cliente = C.id
		where V.id = @idVehiculo
				
					
	
	end
	
end










GO
/****** Object:  StoredProcedure [dbo].[reporte_individual_vehiculo_gastos_aduanales]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[reporte_individual_vehiculo_gastos_aduanales]
@idVehiculo int
as

begin
	
	begin
		
		select G.descripcion as MANTENIMIENTO, DA.precioUSD as PRECIO
		from Vehiculos V join DetalleGastosAduanales DA on V.id = DA.idVehiculo 
		join Gastos G on DA.idGastoAduanal = G.id

		where V.id = @idVehiculo
				
					
	
	end
	
end






GO
/****** Object:  StoredProcedure [dbo].[reporte_individual_vehiculo_gastos_componentes]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[reporte_individual_vehiculo_gastos_componentes]
@idVehiculo int
as

begin
	
	begin
		
		select C.componente as PIEZA, DC.precioUSD as PRECIO
		from Vehiculos V join DetalleComponentes DC on V.id = Dc.idVehiculo join Componentes C on DC.idComponente = C.id
		where V.id = @idVehiculo
				
					
	
	end
	
end






GO
/****** Object:  StoredProcedure [dbo].[reporte_individual_vehiculo_gastos_reparación]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[reporte_individual_vehiculo_gastos_reparación]
@idVehiculo int
as

begin
	
	begin
		
		select G.descripcion as MANTENIMIENTO, T.taller as TALLER, DG.precioUSD as PRECIO
		from Vehiculos V join DetallesGastosReparaciones DG on V.id = DG.idVehiculo 
		join TalleresRepuestos T on DG.idTaller = T.id join Gastos G on DG.idMantenimiento = G.id

		where V.id = @idVehiculo
				
					
	
	end
	
end






GO
/****** Object:  StoredProcedure [dbo].[reporte_individual_vehiculo_pagos]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[reporte_individual_vehiculo_pagos]
@idVehiculo int
as
-- PAGOS VENTA
begin
	
	begin
		
		select P.monto_usd as PAGO, format(P.fecha,'dd/MM/yyyy') as FECHAPAGO, P.monto_rd as PAGORD,
		P.nota as DETALLEPAGO, TP.formaPago as TIPOPAGO
		from Vehiculos V join FormaVentaVehiculo P on V.id = P.id_vehiculo left join TiposPago TP on TP.id = P.id_tipo_pago
		where V.id = @idVehiculo and P.id_transaccion = 1	
	end
	
end




GO
/****** Object:  StoredProcedure [dbo].[reporte_obtener_detalle_cobros]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[reporte_obtener_detalle_cobros]
@idCC int, @tipoReporte varchar(50), @numeroRecibo int
as

begin 
	if @tipoReporte = 'Recibo'
		begin
			select PCC.id as NUMERORECIBO, PCC.monto_rd as MONTORD, PCC.monto_usd as MONTOUSD, PCC.fecha as FECHACOBRO,
			TP.formaPago as FORMAPAGO, PCC.balance_rd as PENDIENTERD, PCC.balance_usd as PENDIENTEUSD
			from PagosCuentasCobrar PCC join TiposPago TP on Tp.id = PCC.id_tipoPago
			join CuentasCobrar CC on CC.id = PCC.id_cuentaCobrar
			where PCC.id_cuentaCobrar = @idCC
		end
	else
		begin
			
			select PCC.id as NUMERORECIBO, PCC.monto_rd as MONTORD, PCC.monto_usd as MONTOUSD, PCC.fecha as FECHACOBRO,
			TP.formaPago as FORMAPAGO, PCC.balance_rd  as PENDIENTERD, PCC.balance_usd as PENDIENTEUSD
			from PagosCuentasCobrar PCC join TiposPago TP on Tp.id = PCC.id_tipoPago
			join CuentasCobrar CC on CC.id = PCC.id_cuentaCobrar
			where PCC.id_cuentaCobrar = @idCC
			and  PCC.id <= @numeroRecibo
		end
	
	
end




GO
/****** Object:  StoredProcedure [dbo].[reporte_obtener_detalle_cobros_seguro]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[reporte_obtener_detalle_cobros_seguro]
@idCC int, @tipoReporte varchar(50), @numeroRecibo int
as

begin 
	if @tipoReporte = 'Recibo'
		begin
			select PCC.id as NUMERORECIBO, PCC.monto_rd as MONTORD, PCC.monto_usd as MONTOUSD, PCC.fecha as FECHACOBRO,
			TP.formaPago as FORMAPAGO, PCC.balance_rd as PENDIENTERD, PCC.balance_usd as PENDIENTEUSD
			from PagosCuentasCobrar PCC join TiposPago TP on Tp.id = PCC.id_tipoPago
			join CuentasCobrar CC on CC.id = PCC.id_cuentaCobrar
			where PCC.id_cuentaCobrar = @idCC
		end
	else
		begin
			
			select PCC.id as NUMERORECIBO, PCC.monto_rd as MONTORD, PCC.monto_usd as MONTOUSD, PCC.fecha as FECHACOBRO,
			TP.formaPago as FORMAPAGO, PCC.balance_rd as PENDIENTERD, PCC.balance_usd as PENDIENTEUSD
			from PagosCuentasCobrar PCC join TiposPago TP on Tp.id = PCC.id_tipoPago
			join CuentasCobrar CC on CC.id = PCC.id_cuentaCobrar
			where PCC.id_cuentaCobrar = @idCC
			and  PCC.id <= @numeroRecibo
		end
	
	
end



GO
/****** Object:  StoredProcedure [dbo].[reporte_obtener_detalle_cobros_traspaso]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[reporte_obtener_detalle_cobros_traspaso]
@idCC int, @tipoReporte varchar(50), @numeroRecibo int
as

begin 
	if @tipoReporte = 'Recibo'
		begin
			select PCC.id as NUMERORECIBO, PCC.monto_rd as MONTORD, PCC.monto_usd as MONTOUSD, PCC.fecha as FECHACOBRO,
			TP.formaPago as FORMAPAGO, PCC.balance_rd as PENDIENTERD, PCC.balance_usd as PENDIENTEUSD
			from PagosCuentasCobrar PCC join TiposPago TP on Tp.id = PCC.id_tipoPago
			join CuentasCobrar CC on CC.id = PCC.id_cuentaCobrar
			where PCC.id_cuentaCobrar = @idCC
		end
	else
		begin
			
			select PCC.id as NUMERORECIBO, PCC.monto_rd as MONTORD, PCC.monto_usd as MONTOUSD, PCC.fecha as FECHACOBRO,
			TP.formaPago as FORMAPAGO, PCC.balance_rd as PENDIENTERD, PCC.balance_usd as PENDIENTEUSD
			from PagosCuentasCobrar PCC join TiposPago TP on Tp.id = PCC.id_tipoPago
			join CuentasCobrar CC on CC.id = PCC.id_cuentaCobrar
			where PCC.id_cuentaCobrar = @idCC
			and  PCC.id <= @numeroRecibo
		end
	
	
end



GO
/****** Object:  StoredProcedure [dbo].[reporte_precio_total_seguro]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[reporte_precio_total_seguro]
@idVehiculo int
as
-- PAGOS VENTA
begin
	
	begin
		
		select Distinct S.nombre, PS.precioRD as PRECIOSEGURORD, PS.precioUSD as PRECIOSEGUROUSD, SV.duracion_dias as DURACION from 
		PreciosSeguroVehiculo PS join SeguroVehiculo SV on SV.id_vehiculo = PS.id_vehiculo join Seguros S on S.id = SV.id_seguro
		where PS.id_vehiculo = @idVehiculo
	end
	
end


GO
/****** Object:  StoredProcedure [dbo].[reporte_precio_total_traspaso]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[reporte_precio_total_traspaso]
@idVehiculo int
as
-- PAGOS VENTA
begin
	
	begin
		
		select precioRD as PRECIOSEGURORD, precioUSD as PRECIOSEGUROUSD from PreciosTraspasoVehiculo
		where id_vehiculo = @idVehiculo
	end
	
end




GO
/****** Object:  StoredProcedure [dbo].[reporte_recibo_de_cobro]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[reporte_recibo_de_cobro]
@idCC int, @tipoRecibo varchar(50), @numeroRecibo int
as

begin 
    if @tipoRecibo = 'Recibo'
		begin
			select PCC.id as NUMERORECIBO, PCC.monto_rd as MONTORD, pcc.monto_usd as MONTOUSD, PCC.fecha as FECHACOBRO,
			TP.formaPago as FORMAPAGO, CC.balance_rd  as PENDIENTERD, CC.balance_usd as PENDIENTEUSD
			from 
			PagosCuentasCobrar PCC join TiposPago TP on Tp.id = PCC.id_tipoPago
			join CuentasCobrar CC on CC.id = PCC.id_cuentaCobrar
	
			where PCC.id = (SELECT MAX(id) From PagosCuentasCobrar) and CC.id = @idCC
			

		end
	else
		begin
			select PCC.id as NUMERORECIBO, PCC.monto_rd as MONTORD, pcc.monto_usd as MONTOUSD, PCC.fecha as FECHACOBRO,
			TP.formaPago as FORMAPAGO, PCC.balance_rd  as PENDIENTERD, PCC.balance_usd as PENDIENTEUSD
			from 
			PagosCuentasCobrar PCC join TiposPago TP on Tp.id = PCC.id_tipoPago
			join CuentasCobrar CC on CC.id = PCC.id_cuentaCobrar
	
			where PCC.id = @numeroRecibo and CC.id = @idCC
			
			--group by DPV.id, DPV.montoRD, DPV.montoUSD,  DPV.fechaPago, TP.formaPago, TFC.balanceRD,
			--TFC.balanceUSD 

		end
	
	
end


GO
/****** Object:  StoredProcedure [dbo].[reporte_recibo_de_cobro_seguro]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[reporte_recibo_de_cobro_seguro]
@idCC int, @tipoRecibo varchar(50), @numeroRecibo int
as

begin 
    if @tipoRecibo = 'Recibo'
		begin
			select PCC.id as NUMERORECIBO, PCC.monto_rd as MONTORD, pcc.monto_usd as MONTOUSD, PCC.fecha as FECHACOBRO,
			TP.formaPago as FORMAPAGO, PCC.balance_rd  as PENDIENTERD, PCC.balance_usd as PENDIENTEUSD
			from 
			PagosCuentasCobrar PCC join TiposPago TP on Tp.id = PCC.id_tipoPago
			join CuentasCobrar CC on CC.id = PCC.id_cuentaCobrar
	
			where PCC.id = (SELECT MAX(id) From PagosCuentasCobrar) and CC.id = @idCC
			

		end
	else
		begin
			select PCC.id as NUMERORECIBO, PCC.monto_rd as MONTORD, pcc.monto_usd as MONTOUSD, PCC.fecha as FECHACOBRO,
			TP.formaPago as FORMAPAGO, CC.balance_rd  as PENDIENTERD, CC.balance_usd as PENDIENTEUSD
			from 
			PagosCuentasCobrar PCC join TiposPago TP on Tp.id = PCC.id_tipoPago
			join CuentasCobrar CC on CC.id = PCC.id_cuentaCobrar
	
			where PCC.id = @numeroRecibo and CC.id = @idCC
		end
	
	
end


GO
/****** Object:  StoredProcedure [dbo].[reporte_recibo_de_cobro_traspaso]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[reporte_recibo_de_cobro_traspaso]
@idCC int, @tipoRecibo varchar(50), @numeroRecibo int
as

begin 
    if @tipoRecibo = 'Recibo'
		begin
			select PCC.id as NUMERORECIBO, PCC.monto_rd as MONTORD, pcc.monto_usd as MONTOUSD, PCC.fecha as FECHACOBRO,
			TP.formaPago as FORMAPAGO, CC.balance_rd  as PENDIENTERD, CC.balance_usd as PENDIENTEUSD
			from 
			PagosCuentasCobrar PCC join TiposPago TP on Tp.id = PCC.id_tipoPago
			join CuentasCobrar CC on CC.id = PCC.id_cuentaCobrar
	
			where PCC.id = (SELECT MAX(id) From PagosCuentasCobrar) and CC.id = @idCC
			

		end
	else
		begin
			select PCC.id as NUMERORECIBO, PCC.monto_rd as MONTORD, pcc.monto_usd as MONTOUSD, PCC.fecha as FECHACOBRO,
			TP.formaPago as FORMAPAGO, PCC.balance_rd  as PENDIENTERD, PCC.balance_usd as PENDIENTEUSD
			from 
			PagosCuentasCobrar PCC join TiposPago TP on Tp.id = PCC.id_tipoPago
			join CuentasCobrar CC on CC.id = PCC.id_cuentaCobrar
	
			where PCC.id = @numeroRecibo and CC.id = @idCC
		end
	
	
end


GO
/****** Object:  StoredProcedure [dbo].[reporte_resultados_rd]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[reporte_resultados_rd]
@desde date, @hasta date
as

begin

	select format(V.fecha_vendido,'dd/MM/yyyy') as FECHAVENDIDO, 
	CONVERT(varchar(200),(F.fabricante + ' ' + M.modelo + ' ' + CONVERT(varchar(10), V.año) + ' ' + V.color)) as VEHICULO,
	V.precioVentaRD as PRECIORD,  V.total_invertido_rd as COSTORD,
	(V.precioVentaRD - V.total_invertido_rd) as RESULTADORD,
	C.cliente as CLIENTE,
	ISNULL((select monto_rd from FormaVentaVehiculo where id_transaccion = 1 and id_tipo_pago = 1),0) as EFECTIVO, 
	ISNULL((select monto_rd from FormaVentaVehiculo where id_transaccion = 1 and id_tipo_pago = 2),0) as VRECIBIDO,
	ISNULL((select monto_rd from FormaVentaVehiculo where id_transaccion = 1 and id_tipo_pago = 3),0) as CREDITO, 
	ISNULL((select monto_rd from FormaVentaVehiculo where id_transaccion = 1 and id_tipo_pago = 4),0) as OTROS
	from Vehiculos V join Fabricantes F on V.fabricante_id = F.id join Modelos M on V.modelo_id = M.id
	join Propietarios P on V.id_propietario = P.id 
	join Clientes C on V.id_cliente = C.id 
	and format(V.fecha_vendido,'yyyy-MM-dd') between
	format (@desde, 'yyyy-MM-dd') and format (@hasta, 'yyyy-MM-dd')
	where V.vendido = 1

end





GO
/****** Object:  StoredProcedure [dbo].[reporte_resultados_usd]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[reporte_resultados_usd]
@desde date, @hasta date
as

begin
	
	select format(V.fecha_vendido,'dd/MM/yyyy') as FECHAVENDIDO, 
	CONVERT(varchar(200),(F.fabricante + ' ' + M.modelo + ' ' + CONVERT(varchar(10), V.año) + ' ' + V.color)) as VEHICULO,
	V.precioVentaUSD as PRECIOUSD,  V.total_invertido_usd as COSTOUSD,
	(V.precioVentaUSD - V.total_invertido_usd) as RESULTADOUSD,
	C.cliente as CLIENTE,
	ISNULL((select monto_usd from FormaVentaVehiculo where id_transaccion = 1 and id_tipo_pago = 1),0) as EFECTIVO, 
	ISNULL((select monto_usd from FormaVentaVehiculo where id_transaccion = 1 and id_tipo_pago = 2),0) as VRECIBIDO,
	ISNULL((select monto_usd from FormaVentaVehiculo where id_transaccion = 1 and id_tipo_pago = 3),0) as CREDITO, 
	ISNULL((select monto_usd from FormaVentaVehiculo where id_transaccion = 1 and id_tipo_pago = 4),0) as OTROS
	from Vehiculos V join Fabricantes F on V.fabricante_id = F.id join Modelos M on V.modelo_id = M.id
	join Propietarios P on V.id_propietario = P.id 
	join Clientes C on V.id_cliente = C.id 
	and format(V.fecha_vendido,'yyyy-MM-dd') between
	format (@desde, 'yyyy-MM-dd') and format (@hasta, 'yyyy-MM-dd')
	where V.vendido = 1
	

end




GO
/****** Object:  StoredProcedure [dbo].[reporte_vehiculos_comprado]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[reporte_vehiculos_comprado]
@desde date, @hasta date
as

begin


	select  format(V.fecha_importe,'dd/MM/yyyy') as FECHAIMPORTE, 
	CONVERT(varchar(200),(F.fabricante + ' ' + M.modelo + ' ' + CONVERT(varchar(10), V.año) + ' ' + V.color)) as VEHICULO, V.vin as VIN,
	V.precioRD as PRECIOCOMPRARD, V.precioUSD as PRECIOCOMPRAUSD, P.nombre as PROPIETARIO
	from Vehiculos V 
	join Fabricantes F on V.fabricante_id = F.id join Modelos M on V.modelo_id = M.id
	join Propietarios P on P.id = V.id_propietario
	where format(V.fecha_importe,'yyyy-MM-dd') between
	format (@desde, 'yyyy-MM-dd') and format (@hasta, 'yyyy-MM-dd') 
	and V.estado = 1


end





GO
/****** Object:  StoredProcedure [dbo].[reporte_vehiculos_inventario]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[reporte_vehiculos_inventario]
@desde date, @hasta date
as

begin


	select  format(V.fecha_importe,'dd/MM/yyyy') as FECHAIMPORTE, format(V.fecha_terminado,'dd/MM/yyyy') as FECHAINVENTARIO, 
	CONVERT(varchar(200),(F.fabricante + ' ' + M.modelo + ' ' + CONVERT(varchar(10), V.año) + ' ' + V.color)) as VEHICULO, V.vin as VIN,
	V.precioRD as PRECIOCOMPRARD, V.precioUSD as PRECIOCOMPRAUSD,V.total_invertido_rd as INVERTIDO_RD,V.total_invertido_usd as INVERTIDO_USD ,P.nombre as PROPIETARIO
	from Vehiculos V 
	join Fabricantes F on V.fabricante_id = F.id join Modelos M on V.modelo_id = M.id
	join Propietarios P on P.id = V.id_propietario
	where format(V.fecha_importe,'yyyy-MM-dd') between
	format (@desde, 'yyyy-MM-dd') and format (@hasta, 'yyyy-MM-dd') 
	and V.estado = 1 and v.terminado = 1 and v.vendido = 0


end





GO
/****** Object:  StoredProcedure [dbo].[reporte_vehiculos_vendidos]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[reporte_vehiculos_vendidos]
@desde date, @hasta date
as

begin
    -- FECHAVENDIDO
	
	Select format(V.fecha_vendido,'dd/MM/yyyy') as FECHAVENDIDO, 
	CONVERT(varchar(200),(F.fabricante + ' ' + M.modelo + ' ' + CONVERT(varchar(10), V.año) + ' ' + V.color)) as VEHICULO,
	V.precioVentaRD as PRECIORD,
	((select ISNULL(SUM(PCC.monto_rd),0) from PagosCuentasCobrar PCC join CuentasCobrar CC on CC.id = PCC.id_cuentaCobrar) + (select sum(monto_rd) from FormaVentaVehiculo FV where FV.id_transaccion = 1 and Fv.id_tipo_pago !=3) ) as PAGADORD ,
	V.precioVentaUSD as PRECIOUSD,
	((select ISNULL(SUM(PCC.monto_usd),0) from PagosCuentasCobrar PCC join CuentasCobrar CC on CC.id = PCC.id_cuentaCobrar) + (select sum(monto_usd) from FormaVentaVehiculo FV where FV.id_transaccion = 1 and Fv.id_tipo_pago !=3) ) as PAGADOUSD ,
	C.cliente as CLIENTE
	from 

	Vehiculos V join CuentasCobrar CC on CC.id_vehiculo = V.id
	
	join Modelos M on M.id = V.modelo_id join Fabricantes F on F.id = V.fabricante_id join Clientes C on C.id = V.id_cliente
	where V.vendido = 1
	and format(V.fecha_vendido,'yyyy-MM-dd') between
	format (@desde, 'yyyy-MM-dd') and format (@hasta, 'yyyy-MM-dd')
	Group by V.fecha_vendido, F.fabricante, M.modelo, V.año, V.color, V.precioVentaRD, V.precioVentaUSD, C.cliente, V.id

end


GO
/****** Object:  StoredProcedure [dbo].[validar_software_activado]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[validar_software_activado]
@mensaje int output
as
set @mensaje = 0;
declare @fechaActivacion date = (select fechaActivacion from SerialKeyActivation where id = 1)
declare @fechaVencimiento date = (select fechaVencimiento from SerialKeyActivation where id = 1)
--set @dias = ISNULL(DATEDIFF(DAY, format (@fechaVencimiento, 'yyyy-MM-dd'),format (GETDATE(), 'yyyy-MM-dd')), 0)
begin
  if (format (getdate(), 'yyyy-MM-dd') < format (@fechaVencimiento, 'yyyy-MM-dd'))
	begin
		set @mensaje = 1
	end
	
end



GO
/****** Object:  StoredProcedure [dbo].[vender_vehiculo]    Script Date: 7/5/2018 3:44:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[vender_vehiculo]
@idVehiculo int, @fecha date ,@mensaje int output, 
@idCliente int, @precioVentaRd float, @precioVentaUsd float,
@precioTraspasoRd float, @precioTraspasoUsd float, @precioSeguroRd float, @precioSeguroUsd float,
@idSeguro int, @duracion int
as
set @mensaje = 0



begin
		if (select vendido from Vehiculos where id = @idVehiculo) = 0
		 begin
			update Vehiculos set vendido = 1, fecha_vendido = @fecha, id_cliente = @idCliente,
			precioVentaRD = @precioVentaRd, precioVentaUSD = @precioVentaUsd
			where id = @idVehiculo

			--insert into SeguroVehiculo (id_vehiculo, id_seguro, duracion_dias)
			--Values (@idVehiculo, @idSeguro, @duracion)

			insert into PreciosTraspasoVehiculo(id_vehiculo,precioRD, precioUSD )
			Values (@idVehiculo, @precioTraspasoRd, @precioTraspasoUsd)

			--insert into PreciosSeguroVehiculo(id_vehiculo,precioRD, precioUSD )
			--Values (@idVehiculo, @precioSeguroRd, @precioSeguroUsd)
			
			--insert into CuentasPagar(id_factura, id_vendedor, id_transaccion, monto_rd, monto_usd,
			--balance_rd, balance_usd, fecha, id_vehiculo)
			--VALUES(0, @idCliente, 4, @precioSeguroRd, @precioSeguroUsd, @precioSeguroRd, @precioSeguroUsd,
			--@fecha, @idVehiculo)

			--insert into FormaCompraVehiculo (id_vehiculo, id_transaccion, id_tipo_pago, id_factura, monto_rd, monto_usd, nota, fecha)
			--VALUES (@idVehiculo, 4, 3, 0, @precioSeguroRd, @precioSeguroUsd, 'CUENTA PAGAR SEGURO', @fecha)
		set @mensaje = 1	

		 end
				
		--if @idTipoPago = 1
		--	begin
		--		 insert into DetallesEfectivoGeneral(idVehiculo, tipoCuenta, montoRD, montoUSD, fecha, documento, numeroDocumento)
		--		 values (@idVehiculo, 2, @pagoRD, @pagoUSD, @fecha, 'Factura', (select id from facturas where id = (select max(id) from facturas)))
		--	end
				
end



GO
USE [master]
GO
ALTER DATABASE [CarsImport] SET  READ_WRITE 
GO
