-- ************************************************************************UPDATE**********************************************************************

ALTER TABLE Usuarios
ADD AgregarCCCP bit NOT NULL DEFAULT(1)
GO

ALTER TABLE CuentasCobrar
ADD nueva bit NOT NULL DEFAULT(1),
nota varchar(300) not null DEFAULT ('')
GO

ALTER TABLE CuentasPagar
ADD nueva bit NOT NULL DEFAULT(1),
nota varchar(300) not null DEFAULT ('')
GO

ALTER procedure [dbo].[registrar_usuarios]
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
ALTER procedure [dbo].[actualizar_usuarios]
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


Go
ALTER procedure [dbo].[obtener_permiso_usuario]
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
ALTER procedure [dbo].[obtener_todos_usuarios]
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
--ALTER procedure [dbo].[obtener_cuentas_por_pagar]
--@propietario varchar(100), @desde date, @hasta date, @idTransaccion int
--as

--begin
--	if @propietario = ''
--		begin
			
--			if @idTransaccion = 2
--				begin 
--					select  CP.id_vehiculo as IDVEHICULO, CP.fecha as  'FECHA' ,TP.transaccion as TRANSACCION ,S.suplidor as 'PAGAR A',
--					CONVERT(varchar(200),
--					(F.fabricante + ' ' + M.modelo + ' ' + CONVERT(varchar(10), V.año) + ' ' + V.color)) as VEHICULO,
--					V.vin as CHASIS,
--					ISNULL(CP.balance_rd, 0) as 'PENDIENTE ($RD)', ISNULL(CP.balance_usd, 0) as 'PENDIENTE ($USD)',
--					ISNULL(DATEDIFF(DAY, format (CP.fecha, 'yyyy-MM-dd'),
--					 format (GETDATE(), 'yyyy-MM-dd')), 0) as 'DIAS VIGENTE', CP.id as IDCUENTAPAGAR, CP.nueva as NUEVA
--					from Vehiculos V  join CuentasPagar CP on CP.id_vehiculo = V.id
--					join Suplidores S on S.id = V.id_suplidor join Fabricantes F on F.id = V.fabricante_id 
--					join Modelos M on M.id = V.modelo_id  join TipoTransaccion TP on TP.id = CP.id_transaccion
			
--					where (ISNULL(CP.balance_usd,0) > 0 or ISNULL(CP.balance_rd,0)>0)
--					and format(CP.fecha,'yyyy-MM-dd') between
--					format (@desde, 'yyyy-MM-dd') and format (@hasta, 'yyyy-MM-dd') and CP.id_transaccion = @idTransaccion
--					and CP.nueva = 1

--					union

--					select  CP.id_vehiculo as IDVEHICULO, CP.fecha as  'FECHA' ,TP.transaccion as TRANSACCION ,S.suplidor as 'PAGAR A',
--					CONVERT(varchar(200),
--					(F.fabricante + ' ' + M.modelo + ' ' + CONVERT(varchar(10), V.año) + ' ' + V.color)) as VEHICULO,
--					V.chasis as CHASIS,
--					ISNULL(CP.balance_rd, 0) as 'PENDIENTE ($RD)', ISNULL(CP.balance_usd, 0) as 'PENDIENTE ($USD)',
--					ISNULL(DATEDIFF(DAY, format (CP.fecha, 'yyyy-MM-dd'),
--					 format (GETDATE(), 'yyyy-MM-dd')), 0) as 'DIAS VIGENTE', CP.id as IDCUENTAPAGAR,  CP.nueva as NUEVA
--					from CuentasPagar CP  join Detalle_CC_CP_Antiguas V on V.id_cuenta = CP.id
--					join Suplidores S on S.id = Cp.id_vendedor join Fabricantes F on F.id = V.id_fabricante
--					join Modelos M on M.id = V.id_modelo  join TipoTransaccion TP on TP.id = CP.id_transaccion
			
--					where (ISNULL(CP.balance_usd,0) > 0 or ISNULL(CP.balance_rd,0)>0)
--					and format(CP.fecha,'yyyy-MM-dd') between
--					format (@desde, 'yyyy-MM-dd') and format (@hasta, 'yyyy-MM-dd') and CP.id_transaccion = @idTransaccion 
--					and CP.nueva = 0 and V.id_tipo_cuenta = 1 

--					order by 'DIAS VIGENTE' DESC
--				end

--			else if @idTransaccion = 4
--				begin 
--					select CP.id_vehiculo as IDVEHICULO, CP.fecha as  'FECHA' ,TP.transaccion as TRANSACCION ,S.nombre as 'PAGAR A',
--					CONVERT(varchar(200),
--					(F.fabricante + ' ' + M.modelo + ' ' + CONVERT(varchar(10), V.año) + ' ' + V.color)) as VEHICULO,
--					V.vin as CHASIS,
--					ISNULL(CP.balance_rd, 0) as 'PENDIENTE ($RD)', ISNULL(CP.balance_usd, 0) as 'PENDIENTE ($USD)',
--					ISNULL(DATEDIFF(DAY, format (CP.fecha, 'yyyy-MM-dd'),
--					 format (GETDATE(), 'yyyy-MM-dd')), 0) as 'DIAS VIGENTE', CP.id as IDCUENTAPAGAR,  CP.nueva as NUEVA
--					from Vehiculos V  join CuentasPagar CP on CP.id_vehiculo = V.id
--					join Seguros S on S.id = V.id_suplidor join Fabricantes F on F.id = V.fabricante_id 
--					join Modelos M on M.id = V.modelo_id  join TipoTransaccion TP on TP.id = CP.id_transaccion
			
--					where (ISNULL(CP.balance_usd,0) > 0 or ISNULL(CP.balance_rd,0)>0)
--					and format(CP.fecha,'yyyy-MM-dd') between
--					format (@desde, 'yyyy-MM-dd') and format (@hasta, 'yyyy-MM-dd') and CP.id_transaccion = @idTransaccion
--					and CP.nueva = 1

--					union

--					select  CP.id_vehiculo as IDVEHICULO, CP.fecha as  'FECHA' ,TP.transaccion as TRANSACCION ,S.nombre as 'PAGAR A',
--					CONVERT(varchar(200),
--					(F.fabricante + ' ' + M.modelo + ' ' + CONVERT(varchar(10), V.año) + ' ' + V.color)) as VEHICULO,
--					V.chasis as CHASIS,
--					ISNULL(CP.balance_rd, 0) as 'PENDIENTE ($RD)', ISNULL(CP.balance_usd, 0) as 'PENDIENTE ($USD)',
--					ISNULL(DATEDIFF(DAY, format (CP.fecha, 'yyyy-MM-dd'),
--					 format (GETDATE(), 'yyyy-MM-dd')), 0) as 'DIAS VIGENTE', CP.id as IDCUENTAPAGAR,  CP.nueva as NUEVA
--					from CuentasPagar CP join Detalle_CC_CP_Antiguas V on V.id_cuenta = CP.id
--					join Seguros S on S.id = CP.id_vendedor join Fabricantes F on F.id = V.id_fabricante
--					join Modelos M on M.id = V.id_modelo  join TipoTransaccion TP on TP.id = CP.id_transaccion
			
--					where (ISNULL(CP.balance_usd,0) > 0 or ISNULL(CP.balance_rd,0)>0)
--					and format(CP.fecha,'yyyy-MM-dd') between
--					format (@desde, 'yyyy-MM-dd') and format (@hasta, 'yyyy-MM-dd') and CP.id_transaccion = @idTransaccion
--					and CP.nueva = 0 and V.id_tipo_cuenta = 1 
--					order by 'DIAS VIGENTE' DESC
--				end

--			else if @idTransaccion = 5
--				begin 
--					select  CP.id_vehiculo as IDVEHICULO, CP.fecha as  'FECHA' ,TP.transaccion as TRANSACCION ,S.taller as 'PAGAR A',
--					CONVERT(varchar(200),
--					(F.fabricante + ' ' + M.modelo + ' ' + CONVERT(varchar(10), V.año) + ' ' + V.color)) as VEHICULO,
--					V.vin as CHASIS,
--					ISNULL(CP.balance_rd, 0) as 'PENDIENTE ($RD)', ISNULL(CP.balance_usd, 0) as 'PENDIENTE ($USD)',
--					ISNULL(DATEDIFF(DAY, format (CP.fecha, 'yyyy-MM-dd'),
--					 format (GETDATE(), 'yyyy-MM-dd')), 0) as 'DIAS VIGENTE', CP.id as IDCUENTAPAGAR,  CP.nueva as NUEVA
--					from Vehiculos V  join CuentasPagar CP on CP.id_vehiculo = V.id
--					join TalleresRepuestos S on S.id = CP.id_vendedor join Fabricantes F on F.id = V.fabricante_id 
--					join Modelos M on M.id = V.modelo_id  join TipoTransaccion TP on TP.id = CP.id_transaccion
					
--					where (ISNULL(CP.balance_usd,0) > 0 or ISNULL(CP.balance_rd,0)>0) and CP.id_transaccion = 5
--					and format(CP.fecha,'yyyy-MM-dd') between
--					format (@desde, 'yyyy-MM-dd') and format (@hasta, 'yyyy-MM-dd') and CP.nueva = 1

--					union

--					select CP.id_vehiculo as IDVEHICULO, CP.fecha as  'FECHA' ,TP.transaccion as TRANSACCION ,S.taller as 'PAGAR A',
--					CONVERT(varchar(200),
--					(F.fabricante + ' ' + M.modelo + ' ' + CONVERT(varchar(10), V.año) + ' ' + V.color)) as VEHICULO,
--					V.chasis as CHASIS,
--					ISNULL(CP.balance_rd, 0) as 'PENDIENTE ($RD)', ISNULL(CP.balance_usd, 0) as 'PENDIENTE ($USD)',
--					ISNULL(DATEDIFF(DAY, format (CP.fecha, 'yyyy-MM-dd'),
--					 format (GETDATE(), 'yyyy-MM-dd')), 0) as 'DIAS VIGENTE', CP.id as IDCUENTAPAGAR,  CP.nueva as NUEVA
--					from CuentasPagar CP join Detalle_CC_CP_Antiguas V on CP.id = V.id_cuenta
--					join TalleresRepuestos S on S.id = CP.id_vendedor join Fabricantes F on F.id = V.id_fabricante
--					join Modelos M on M.id = V.id_modelo  join TipoTransaccion TP on TP.id = CP.id_transaccion
			
--					where (ISNULL(CP.balance_usd,0) > 0 or ISNULL(CP.balance_rd,0)>0) and CP.id_transaccion = 5
--					and format(CP.fecha,'yyyy-MM-dd') between
--					format (@desde, 'yyyy-MM-dd') and format (@hasta, 'yyyy-MM-dd') 
--					and CP.nueva = 0 and V.id_tipo_cuenta = 1 
--					order by 'DIAS VIGENTE' DESC
--				end
--			else if @idTransaccion = 6 
--				begin 
--					select  CP.id_vehiculo as IDVEHICULO, CP.fecha as  'FECHA' ,TP.transaccion as TRANSACCION ,S.taller as 'PAGAR A',
--					CONVERT(varchar(200),
--					(F.fabricante + ' ' + M.modelo + ' ' + CONVERT(varchar(10), V.año) + ' ' + V.color)) as VEHICULO,
--					V.vin as CHASIS,
--					ISNULL(CP.balance_rd, 0) as 'PENDIENTE ($RD)', ISNULL(CP.balance_usd, 0) as 'PENDIENTE ($USD)',
--					ISNULL(DATEDIFF(DAY, format (CP.fecha, 'yyyy-MM-dd'),
--					 format (GETDATE(), 'yyyy-MM-dd')), 0) as 'DIAS VIGENTE', CP.id as IDCUENTAPAGAR,  CP.nueva as NUEVA
--					from Vehiculos V  join CuentasPagar CP on CP.id_vehiculo = V.id
--					join TalleresRepuestos S on S.id = CP.id_vendedor join Fabricantes F on F.id = V.fabricante_id 
--					join Modelos M on M.id = V.modelo_id  join TipoTransaccion TP on TP.id = CP.id_transaccion
					
--					where (ISNULL(CP.balance_usd,0) > 0 or ISNULL(CP.balance_rd,0)>0) and CP.id_transaccion = 6
--					and format(CP.fecha,'yyyy-MM-dd') between
--					format (@desde, 'yyyy-MM-dd') and format (@hasta, 'yyyy-MM-dd') 
--					and CP.nueva = 1
					
--					union

--					select  CP.id_vehiculo as IDVEHICULO, CP.fecha as  'FECHA' ,TP.transaccion as TRANSACCION ,S.taller as 'PAGAR A',
--					CONVERT(varchar(200),
--					(F.fabricante + ' ' + M.modelo + ' ' + CONVERT(varchar(10), V.año) + ' ' + V.color)) as VEHICULO,
--					V.chasis as CHASIS,
--					ISNULL(CP.balance_rd, 0) as 'PENDIENTE ($RD)', ISNULL(CP.balance_usd, 0) as 'PENDIENTE ($USD)',
--					ISNULL(DATEDIFF(DAY, format (CP.fecha, 'yyyy-MM-dd'),
--					 format (GETDATE(), 'yyyy-MM-dd')), 0) as 'DIAS VIGENTE', CP.id as IDCUENTAPAGAR,  CP.nueva as NUEVA
--					from CuentasPagar CP join Detalle_CC_CP_Antiguas V on  CP.id = V.id_cuenta
--					join TalleresRepuestos S on S.id = CP.id_vendedor join Fabricantes F on F.id = V.id_fabricante 
--					join Modelos M on M.id = V.id_modelo  join TipoTransaccion TP on TP.id = CP.id_transaccion
					
--					where (ISNULL(CP.balance_usd,0) > 0 or ISNULL(CP.balance_rd,0)>0) and CP.id_transaccion = 6
--					and format(CP.fecha,'yyyy-MM-dd') between
--					format (@desde, 'yyyy-MM-dd') and format (@hasta, 'yyyy-MM-dd') 
--					and CP.nueva = 0 and V.id_tipo_cuenta = 1

--					order by 'DIAS VIGENTE' DESC
--				end
				
--			else if @idTransaccion = 7
--				begin 
--					select  CP.id_vehiculo as IDVEHICULO, CP.fecha as  'FECHA' ,TP.transaccion as TRANSACCION ,S.taller as 'PAGAR A',
--					CONVERT(varchar(200),
--					(F.fabricante + ' ' + M.modelo + ' ' + CONVERT(varchar(10), V.año) + ' ' + V.color)) as VEHICULO,
--					V.vin as CHASIS,
--					ISNULL(CP.balance_rd, 0) as 'PENDIENTE ($RD)', ISNULL(CP.balance_usd, 0) as 'PENDIENTE ($USD)',
--					ISNULL(DATEDIFF(DAY, format (CP.fecha, 'yyyy-MM-dd'),
--					 format (GETDATE(), 'yyyy-MM-dd')), 0) as 'DIAS VIGENTE', CP.id as IDCUENTAPAGAR,  CP.nueva as NUEVA
--					from Vehiculos V  join CuentasPagar CP on CP.id_vehiculo = V.id
--					join TalleresRepuestos S on S.id = CP.id_vendedor join Fabricantes F on F.id = V.fabricante_id 
--					join Modelos M on M.id = V.modelo_id  join TipoTransaccion TP on TP.id = CP.id_transaccion
			
--					where (ISNULL(CP.balance_usd,0) > 0 or ISNULL(CP.balance_rd,0)>0) and CP.id_transaccion = 7
--					and format(CP.fecha,'yyyy-MM-dd') between
--					format (@desde, 'yyyy-MM-dd') and format (@hasta, 'yyyy-MM-dd') 
--					and CP.nueva = 1

--					union

--					select  CP.id_vehiculo as IDVEHICULO, CP.fecha as  'FECHA' ,TP.transaccion as TRANSACCION ,S.taller as 'PAGAR A',
--					CONVERT(varchar(200),
--					(F.fabricante + ' ' + M.modelo + ' ' + CONVERT(varchar(10), V.año) + ' ' + V.color)) as VEHICULO,
--					V.chasis as CHASIS,
--					ISNULL(CP.balance_rd, 0) as 'PENDIENTE ($RD)', ISNULL(CP.balance_usd, 0) as 'PENDIENTE ($USD)',
--					ISNULL(DATEDIFF(DAY, format (CP.fecha, 'yyyy-MM-dd'),
--					 format (GETDATE(), 'yyyy-MM-dd')), 0) as 'DIAS VIGENTE', CP.id as IDCUENTAPAGAR,  CP.nueva as NUEVA
--					from CuentasPagar CP join Detalle_CC_CP_Antiguas V on CP.id = V.id_cuenta
--					join TalleresRepuestos S on S.id = CP.id_vendedor join Fabricantes F on F.id = V.id_fabricante
--					join Modelos M on M.id = V.id_modelo  join TipoTransaccion TP on TP.id = CP.id_transaccion
			
--					where (ISNULL(CP.balance_usd,0) > 0 or ISNULL(CP.balance_rd,0)>0) and CP.id_transaccion = 7
--					and format(CP.fecha,'yyyy-MM-dd') between
--					format (@desde, 'yyyy-MM-dd') and format (@hasta, 'yyyy-MM-dd') 
--					and CP.nueva = 0 and V.id_tipo_cuenta = 1
--					order by 'DIAS VIGENTE' DESC
--				end
			
			
--		end
--	else
--		begin
--			if @idTransaccion = 2
--				begin 
--					select  CP.id_vehiculo as IDVEHICULO, CP.fecha as  'FECHA' ,TP.transaccion as TRANSACCION ,S.suplidor as 'PAGAR A',
--					CONVERT(varchar(200),
--					(F.fabricante + ' ' + M.modelo + ' ' + CONVERT(varchar(10), V.año) + ' ' + V.color)) as VEHICULO,
--					V.vin as CHASIS,
--					ISNULL(CP.balance_rd, 0) as 'PENDIENTE ($RD)', ISNULL(CP.balance_usd, 0) as 'PENDIENTE ($USD)',
--					ISNULL(DATEDIFF(DAY, format (CP.fecha, 'yyyy-MM-dd'),
--					 format (GETDATE(), 'yyyy-MM-dd')), 0) as 'DIAS VIGENTE', CP.id as IDCUENTAPAGAR, CP.nueva as NUEVA
--					from Vehiculos V  join CuentasPagar CP on CP.id_vehiculo = V.id
--					join Suplidores S on S.id = V.id_suplidor join Fabricantes F on F.id = V.fabricante_id 
--					join Modelos M on M.id = V.modelo_id  join TipoTransaccion TP on TP.id = CP.id_transaccion
			
--					where (ISNULL(CP.balance_usd,0) > 0 or ISNULL(CP.balance_rd,0)>0)
--					and format(CP.fecha,'yyyy-MM-dd') between
--					format (@desde, 'yyyy-MM-dd') and format (@hasta, 'yyyy-MM-dd') and CP.id_transaccion = @idTransaccion
--					and CP.nueva = 1 and S.suplidor LIKE '%' + @propietario + '%'


--					union

--					select  CP.id_vehiculo as IDVEHICULO, CP.fecha as  'FECHA' ,TP.transaccion as TRANSACCION ,S.suplidor as 'PAGAR A',
--					CONVERT(varchar(200),
--					(F.fabricante + ' ' + M.modelo + ' ' + CONVERT(varchar(10), V.año) + ' ' + V.color)) as VEHICULO,
--					V.chasis as CHASIS,
--					ISNULL(CP.balance_rd, 0) as 'PENDIENTE ($RD)', ISNULL(CP.balance_usd, 0) as 'PENDIENTE ($USD)',
--					ISNULL(DATEDIFF(DAY, format (CP.fecha, 'yyyy-MM-dd'),
--					 format (GETDATE(), 'yyyy-MM-dd')), 0) as 'DIAS VIGENTE', CP.id as IDCUENTAPAGAR,  CP.nueva as NUEVA
--					from CuentasPagar CP  join Detalle_CC_CP_Antiguas V on V.id_cuenta = CP.id
--					join Suplidores S on S.id = Cp.id_vendedor join Fabricantes F on F.id = V.id_fabricante
--					join Modelos M on M.id = V.id_modelo  join TipoTransaccion TP on TP.id = CP.id_transaccion
			
--					where (ISNULL(CP.balance_usd,0) > 0 or ISNULL(CP.balance_rd,0)>0)
--					and format(CP.fecha,'yyyy-MM-dd') between
--					format (@desde, 'yyyy-MM-dd') and format (@hasta, 'yyyy-MM-dd') and CP.id_transaccion = @idTransaccion 
--					and CP.nueva = 0 and V.id_tipo_cuenta = 1 and S.suplidor LIKE '%' + @propietario + '%'


--					order by 'DIAS VIGENTE' DESC
--				end

--			else if @idTransaccion = 4
--				begin 
--					select  CP.id_vehiculo as IDVEHICULO, CP.fecha as  'FECHA' ,TP.transaccion as TRANSACCION ,S.nombre as 'PAGAR A',
--					CONVERT(varchar(200),
--					(F.fabricante + ' ' + M.modelo + ' ' + CONVERT(varchar(10), V.año) + ' ' + V.color)) as VEHICULO,
--					V.vin as CHASIS,
--					ISNULL(CP.balance_rd, 0) as 'PENDIENTE ($RD)', ISNULL(CP.balance_usd, 0) as 'PENDIENTE ($USD)',
--					ISNULL(DATEDIFF(DAY, format (CP.fecha, 'yyyy-MM-dd'),
--					 format (GETDATE(), 'yyyy-MM-dd')), 0) as 'DIAS VIGENTE', CP.id as IDCUENTAPAGAR,  CP.nueva as NUEVA
--					from Vehiculos V  join CuentasPagar CP on CP.id_vehiculo = V.id
--					join Seguros S on S.id = V.id_suplidor join Fabricantes F on F.id = V.fabricante_id 
--					join Modelos M on M.id = V.modelo_id  join TipoTransaccion TP on TP.id = CP.id_transaccion
			
--					where (ISNULL(CP.balance_usd,0) > 0 or ISNULL(CP.balance_rd,0)>0)
--					and format(CP.fecha,'yyyy-MM-dd') between
--					format (@desde, 'yyyy-MM-dd') and format (@hasta, 'yyyy-MM-dd') and CP.id_transaccion = @idTransaccion
--					and CP.nueva = 1 and S.nombre LIKE '%' + @propietario + '%'


--					union

--					select  CP.id_vehiculo as IDVEHICULO, CP.fecha as  'FECHA' ,TP.transaccion as TRANSACCION ,S.nombre as 'PAGAR A',
--					CONVERT(varchar(200),
--					(F.fabricante + ' ' + M.modelo + ' ' + CONVERT(varchar(10), V.año) + ' ' + V.color)) as VEHICULO,
--					V.chasis as CHASIS,
--					ISNULL(CP.balance_rd, 0) as 'PENDIENTE ($RD)', ISNULL(CP.balance_usd, 0) as 'PENDIENTE ($USD)',
--					ISNULL(DATEDIFF(DAY, format (CP.fecha, 'yyyy-MM-dd'),
--					 format (GETDATE(), 'yyyy-MM-dd')), 0) as 'DIAS VIGENTE', CP.id as IDCUENTAPAGAR,  CP.nueva as NUEVA
--					from CuentasPagar CP join Detalle_CC_CP_Antiguas V on V.id_cuenta = CP.id
--					join Seguros S on S.id = CP.id_vendedor join Fabricantes F on F.id = V.id_fabricante
--					join Modelos M on M.id = V.id_modelo  join TipoTransaccion TP on TP.id = CP.id_transaccion
			
--					where (ISNULL(CP.balance_usd,0) > 0 or ISNULL(CP.balance_rd,0)>0)
--					and format(CP.fecha,'yyyy-MM-dd') between
--					format (@desde, 'yyyy-MM-dd') and format (@hasta, 'yyyy-MM-dd') and CP.id_transaccion = @idTransaccion
--					and CP.nueva = 0 and V.id_tipo_cuenta = 1  and S.nombre LIKE '%' + @propietario + '%'

--					order by 'DIAS VIGENTE' DESC
--				end

--			else if @idTransaccion = 5
--				begin 
--					select  CP.id_vehiculo as IDVEHICULO, CP.fecha as  'FECHA' ,TP.transaccion as TRANSACCION ,S.taller as 'PAGAR A',
--					CONVERT(varchar(200),
--					(F.fabricante + ' ' + M.modelo + ' ' + CONVERT(varchar(10), V.año) + ' ' + V.color)) as VEHICULO,
--					V.vin as CHASIS,
--					ISNULL(CP.balance_rd, 0) as 'PENDIENTE ($RD)', ISNULL(CP.balance_usd, 0) as 'PENDIENTE ($USD)',
--					ISNULL(DATEDIFF(DAY, format (CP.fecha, 'yyyy-MM-dd'),
--					 format (GETDATE(), 'yyyy-MM-dd')), 0) as 'DIAS VIGENTE', CP.id as IDCUENTAPAGAR,  CP.nueva as NUEVA
--					from Vehiculos V  join CuentasPagar CP on CP.id_vehiculo = V.id
--					join TalleresRepuestos S on S.id = CP.id_vendedor join Fabricantes F on F.id = V.fabricante_id 
--					join Modelos M on M.id = V.modelo_id  join TipoTransaccion TP on TP.id = CP.id_transaccion
--					where (ISNULL(CP.balance_usd,0) > 0 or ISNULL(CP.balance_rd,0)>0) and CP.id_transaccion = 5
--					and format(CP.fecha,'yyyy-MM-dd') between
--					format (@desde, 'yyyy-MM-dd') and format (@hasta, 'yyyy-MM-dd')  and S.taller LIKE '%' + @propietario + '%'
--					and CP.nueva = 1 


--					union

--					select  CP.id_vehiculo as IDVEHICULO, CP.fecha as  'FECHA' ,TP.transaccion as TRANSACCION ,S.taller as 'PAGAR A',
--					CONVERT(varchar(200),
--					(F.fabricante + ' ' + M.modelo + ' ' + CONVERT(varchar(10), V.año) + ' ' + V.color)) as VEHICULO,
--					V.chasis as CHASIS,
--					ISNULL(CP.balance_rd, 0) as 'PENDIENTE ($RD)', ISNULL(CP.balance_usd, 0) as 'PENDIENTE ($USD)',
--					ISNULL(DATEDIFF(DAY, format (CP.fecha, 'yyyy-MM-dd'),
--					 format (GETDATE(), 'yyyy-MM-dd')), 0) as 'DIAS VIGENTE', CP.id as IDCUENTAPAGAR,  CP.nueva as NUEVA
--					from CuentasPagar CP join Detalle_CC_CP_Antiguas V on CP.id = V.id_cuenta
--					join TalleresRepuestos S on S.id = CP.id_vendedor join Fabricantes F on F.id = V.id_fabricante
--					join Modelos M on M.id = V.id_modelo  join TipoTransaccion TP on TP.id = CP.id_transaccion
			
--					where (ISNULL(CP.balance_usd,0) > 0 or ISNULL(CP.balance_rd,0)>0) and CP.id_transaccion = 5
--					and format(CP.fecha,'yyyy-MM-dd') between
--					format (@desde, 'yyyy-MM-dd') and format (@hasta, 'yyyy-MM-dd') 
--					and CP.nueva = 0 and V.id_tipo_cuenta = 1 and S.taller LIKE '%' + @propietario + '%'
--					order by 'DIAS VIGENTE' DESC
--				end
--			else if @idTransaccion = 6 
--				begin 
--					select  CP.id_vehiculo as IDVEHICULO, CP.fecha as  'FECHA' ,TP.transaccion as TRANSACCION ,S.taller as 'PAGAR A',
--					CONVERT(varchar(200),
--					(F.fabricante + ' ' + M.modelo + ' ' + CONVERT(varchar(10), V.año) + ' ' + V.color)) as VEHICULO,
--					V.vin as CHASIS,
--					ISNULL(CP.balance_rd, 0) as 'PENDIENTE ($RD)', ISNULL(CP.balance_usd, 0) as 'PENDIENTE ($USD)',
--					ISNULL(DATEDIFF(DAY, format (CP.fecha, 'yyyy-MM-dd'),
--					 format (GETDATE(), 'yyyy-MM-dd')), 0) as 'DIAS VIGENTE', CP.id as IDCUENTAPAGAR,  CP.nueva as NUEVA
--					from Vehiculos V  join CuentasPagar CP on CP.id_vehiculo = V.id
--					join TalleresRepuestos S on S.id = CP.id_vendedor join Fabricantes F on F.id = V.fabricante_id 
--					join Modelos M on M.id = V.modelo_id  join TipoTransaccion TP on TP.id = CP.id_transaccion
					
--					where (ISNULL(CP.balance_usd,0) > 0 or ISNULL(CP.balance_rd,0)>0) and CP.id_transaccion = 6
--					and format(CP.fecha,'yyyy-MM-dd') between
--					format (@desde, 'yyyy-MM-dd') and format (@hasta, 'yyyy-MM-dd') 
--					and CP.nueva = 1 and S.taller LIKE '%' + @propietario + '%'
					
--					union

--					select CP.id_vehiculo as IDVEHICULO, CP.fecha as  'FECHA' ,TP.transaccion as TRANSACCION ,S.taller as 'PAGAR A',
--					CONVERT(varchar(200),
--					(F.fabricante + ' ' + M.modelo + ' ' + CONVERT(varchar(10), V.año) + ' ' + V.color)) as VEHICULO,
--					V.chasis as CHASIS,
--					ISNULL(CP.balance_rd, 0) as 'PENDIENTE ($RD)', ISNULL(CP.balance_usd, 0) as 'PENDIENTE ($USD)',
--					ISNULL(DATEDIFF(DAY, format (CP.fecha, 'yyyy-MM-dd'),
--					 format (GETDATE(), 'yyyy-MM-dd')), 0) as 'DIAS VIGENTE', CP.id as IDCUENTAPAGAR,  CP.nueva as NUEVA
--					from CuentasPagar CP join Detalle_CC_CP_Antiguas V on  CP.id = V.id_cuenta
--					join TalleresRepuestos S on S.id = CP.id_vendedor join Fabricantes F on F.id = V.id_fabricante 
--					join Modelos M on M.id = V.id_modelo  join TipoTransaccion TP on TP.id = CP.id_transaccion
					
--					where (ISNULL(CP.balance_usd,0) > 0 or ISNULL(CP.balance_rd,0)>0) and CP.id_transaccion = 6
--					and format(CP.fecha,'yyyy-MM-dd') between
--					format (@desde, 'yyyy-MM-dd') and format (@hasta, 'yyyy-MM-dd') 
--					and CP.nueva = 0 and V.id_tipo_cuenta = 1 and S.taller LIKE '%' + @propietario + '%'

--					order by 'DIAS VIGENTE' DESC
--				end
				
--			else if @idTransaccion = 7
--				begin 
--					select  CP.id_vehiculo as IDVEHICULO, CP.fecha as  'FECHA' ,TP.transaccion as TRANSACCION ,S.taller as 'PAGAR A',
--					CONVERT(varchar(200),
--					(F.fabricante + ' ' + M.modelo + ' ' + CONVERT(varchar(10), V.año) + ' ' + V.color)) as VEHICULO,
--					V.vin as CHASIS,
--					ISNULL(CP.balance_rd, 0) as 'PENDIENTE ($RD)', ISNULL(CP.balance_usd, 0) as 'PENDIENTE ($USD)',
--					ISNULL(DATEDIFF(DAY, format (CP.fecha, 'yyyy-MM-dd'),
--					 format (GETDATE(), 'yyyy-MM-dd')), 0) as 'DIAS VIGENTE', CP.id as IDCUENTAPAGAR,  CP.nueva as NUEVA
--					from Vehiculos V  join CuentasPagar CP on CP.id_vehiculo = V.id
--					join TalleresRepuestos S on S.id = CP.id_vendedor join Fabricantes F on F.id = V.fabricante_id 
--					join Modelos M on M.id = V.modelo_id  join TipoTransaccion TP on TP.id = CP.id_transaccion
			
--					where (ISNULL(CP.balance_usd,0) > 0 or ISNULL(CP.balance_rd,0)>0) and CP.id_transaccion = 7
--					and format(CP.fecha,'yyyy-MM-dd') between
--					format (@desde, 'yyyy-MM-dd') and format (@hasta, 'yyyy-MM-dd') 
--					and CP.nueva = 1 and S.taller LIKE '%' + @propietario + '%'

--					union

--					select  CP.id_vehiculo as IDVEHICULO, CP.fecha as  'FECHA' ,TP.transaccion as TRANSACCION ,S.taller as 'PAGAR A',
--					CONVERT(varchar(200),
--					(F.fabricante + ' ' + M.modelo + ' ' + CONVERT(varchar(10), V.año) + ' ' + V.color)) as VEHICULO,
--					V.chasis as CHASIS,
--					ISNULL(CP.balance_rd, 0) as 'PENDIENTE ($RD)', ISNULL(CP.balance_usd, 0) as 'PENDIENTE ($USD)',
--					ISNULL(DATEDIFF(DAY, format (CP.fecha, 'yyyy-MM-dd'),
--					 format (GETDATE(), 'yyyy-MM-dd')), 0) as 'DIAS VIGENTE', CP.id as IDCUENTAPAGAR,  CP.nueva as NUEVA
--					from CuentasPagar CP join Detalle_CC_CP_Antiguas V on CP.id = V.id_cuenta
--					join TalleresRepuestos S on S.id = CP.id_vendedor join Fabricantes F on F.id = V.id_fabricante
--					join Modelos M on M.id = V.id_modelo  join TipoTransaccion TP on TP.id = CP.id_transaccion
			
--					where (ISNULL(CP.balance_usd,0) > 0 or ISNULL(CP.balance_rd,0)>0) and CP.id_transaccion = 7
--					and format(CP.fecha,'yyyy-MM-dd') between
--					format (@desde, 'yyyy-MM-dd') and format (@hasta, 'yyyy-MM-dd') 
--					and CP.nueva = 0 and V.id_tipo_cuenta = 1 and S.taller LIKE '%' + @propietario + '%'
--					order by 'DIAS VIGENTE' DESC
--				end	

--	    end
--end


GO
ALTER procedure [dbo].[obtener_cuentas_por_cobrar]
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

Go

ALTER procedure [dbo].[obtener_recibos_cobros]
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

--ALTER procedure [dbo].[reporte_cuentas_pagar]
--@desde date, @hasta date, @idTransaccion int
--as

--begin

	
--	if @idTransaccion = 2
--		begin
--			select CP.id as CUENTAPAGAR,TP.transaccion as TRANSACCION , CP.fecha as  FECHACOMPRA ,S.suplidor as PROPIETARIO,
--			CONVERT(varchar(200),(F.fabricante + ' ' + M.modelo + ' ' + CONVERT(varchar(10), V.año) + ' ' + V.color)) as VEHICULO,
--			CP.monto_rd as TOTALPAGARRD, CP.monto_usd as TOTALPAGARUSD,
--			(CP.monto_rd - CP.balance_rd) as PAGADORD, (CP.monto_usd - CP.balance_usd) as PAGADOUSD,
--			CP.balance_rd as PENDIENTERD, CP.balance_usd as PENDIENTEUSD,
--			ISNULL(DATEDIFF(DAY, format (CP.fecha, 'yyyy-MM-dd'),
--			format (GETDATE(), 'yyyy-MM-dd')), 0) as DIASVIGENTE
--			from CuentasPagar CP join Vehiculos V on V.id = CP.id_vehiculo join Suplidores S on S.id = V.id_suplidor
--			join Fabricantes F on F.id = V.fabricante_id join Modelos M on M.id = V.modelo_id
--			join TipoTransaccion TP on TP.id = CP.id_transaccion
--			where CP.balance_rd > 0 and CP.balance_usd > 0 and CP.id_transaccion = @idTransaccion
--			and format(CP.fecha,'yyyy-MM-dd') between
--			format (@desde, 'yyyy-MM-dd') and format (@hasta, 'yyyy-MM-dd') 
--			and CP.nueva = 1

--			union

--			select CP.id as CUENTAPAGAR,TP.transaccion as TRANSACCION ,CP.fecha as  FECHACOMPRA ,S.suplidor as PROPIETARIO,
--			CONVERT(varchar(200),(F.fabricante + ' ' + M.modelo + ' ' + CONVERT(varchar(10), V.año) + ' ' + V.color)) as VEHICULO,
--			CP.monto_rd as TOTALPAGARRD, CP.monto_usd as TOTALPAGARUSD,
--			(CP.monto_rd - CP.balance_rd) as PAGADORD, (CP.monto_usd - CP.balance_usd) as PAGADOUSD,
--			CP.balance_rd as PENDIENTERD, CP.balance_usd as PENDIENTEUSD,
--			ISNULL(DATEDIFF(DAY, format (CP.fecha, 'yyyy-MM-dd'),
--			format (GETDATE(), 'yyyy-MM-dd')), 0) as DIASVIGENTE
--			from CuentasPagar CP join Detalle_CC_CP_Antiguas V on V.id_cuenta = CP.id join Suplidores S on S.id = CP.id_vendedor
--			join Fabricantes F on F.id = V.id_fabricante join Modelos M on M.id = V.id_modelo
--			join TipoTransaccion TP on TP.id = CP.id_transaccion
--			where CP.balance_rd > 0 and CP.balance_usd > 0 and CP.id_transaccion = 2
--			and format(CP.fecha,'yyyy-MM-dd') between
--			format (@desde, 'yyyy-MM-dd') and format (@hasta, 'yyyy-MM-dd') 
--			and CP.nueva = 0 and V.id_tipo_cuenta = 1

--		end
--	 else if @idTransaccion = 4
--		begin
--			select CP.id as CUENTAPAGAR,TP.transaccion as TRANSACCION ,CP.fecha as  FECHACOMPRA ,S.nombre as PROPIETARIO,
--			CONVERT(varchar(200),(F.fabricante + ' ' + M.modelo + ' ' + CONVERT(varchar(10), V.año) + ' ' + V.color)) as VEHICULO,
--			CP.monto_rd as TOTALPAGARRD, CP.monto_usd as TOTALPAGARUSD,
--			(CP.monto_rd - CP.balance_rd) as PAGADORD, (CP.monto_usd - CP.balance_usd) as PAGADOUSD,
--			CP.balance_rd as PENDIENTERD, CP.balance_usd as PENDIENTEUSD,
--			ISNULL(DATEDIFF(DAY, format (CP.fecha, 'yyyy-MM-dd'),
--			format (GETDATE(), 'yyyy-MM-dd')), 0) as DIASVIGENTE
--			from CuentasPagar CP join Vehiculos V on V.id = CP.id_vehiculo join Seguros S on S.id = V.id_suplidor
--			join Fabricantes F on F.id = V.fabricante_id join Modelos M on M.id = V.modelo_id
--			join TipoTransaccion TP on TP.id = CP.id_transaccion
--			where CP.balance_rd > 0 and CP.balance_usd > 0 and CP.id_transaccion = 4
--			and format(CP.fecha,'yyyy-MM-dd') between
--			format (@desde, 'yyyy-MM-dd') and format (@hasta, 'yyyy-MM-dd') and CP.nueva = 1

--			union

--			select CP.id as CUENTAPAGAR,TP.transaccion as TRANSACCION ,CP.fecha as  FECHACOMPRA ,S.nombre as PROPIETARIO,
--			CONVERT(varchar(200),(F.fabricante + ' ' + M.modelo + ' ' + CONVERT(varchar(10), V.año) + ' ' + V.color)) as VEHICULO,
--			CP.monto_rd as TOTALPAGARRD, CP.monto_usd as TOTALPAGARUSD,
--			(CP.monto_rd - CP.balance_rd) as PAGADORD, (CP.monto_usd - CP.balance_usd) as PAGADOUSD,
--			CP.balance_rd as PENDIENTERD, CP.balance_usd as PENDIENTEUSD,
--			ISNULL(DATEDIFF(DAY, format (CP.fecha, 'yyyy-MM-dd'),
--			format (GETDATE(), 'yyyy-MM-dd')), 0) as DIASVIGENTE
--			from CuentasPagar CP join Detalle_CC_CP_Antiguas V on V.id_cuenta = CP.id join Seguros S on S.id = CP.id_vendedor
--			join Fabricantes F on F.id = V.id_fabricante join Modelos M on M.id = V.id_modelo
--			join TipoTransaccion TP on TP.id = CP.id_transaccion
--			where CP.balance_rd > 0 and CP.balance_usd > 0 and CP.id_transaccion = 4
--			and format(CP.fecha,'yyyy-MM-dd') between
--			format (@desde, 'yyyy-MM-dd') and format (@hasta, 'yyyy-MM-dd') and CP.nueva = 0 and V.id_tipo_cuenta = 1
--		end
	
--	else if @idTransaccion = 5
--		begin
--			select CP.id as CUENTAPAGAR,TP.transaccion as TRANSACCION ,CP.fecha as  FECHACOMPRA ,S.taller as PROPIETARIO,
--			CONVERT(varchar(200),(F.fabricante + ' ' + M.modelo + ' ' + CONVERT(varchar(10), V.año) + ' ' + V.color)) as VEHICULO,
--			CP.monto_rd as TOTALPAGARRD, CP.monto_usd as TOTALPAGARUSD,
--			(CP.monto_rd - CP.balance_rd) as PAGADORD, (CP.monto_usd - CP.balance_usd) as PAGADOUSD,
--			CP.balance_rd as PENDIENTERD, CP.balance_usd as PENDIENTEUSD,
--			ISNULL(DATEDIFF(DAY, format (CP.fecha, 'yyyy-MM-dd'),
--			format (GETDATE(), 'yyyy-MM-dd')), 0) as DIASVIGENTE
--			from CuentasPagar CP join Vehiculos V on V.id = CP.id_vehiculo join TalleresRepuestos S on S.id = CP.id_vendedor
--			join Fabricantes F on F.id = V.fabricante_id join Modelos M on M.id = V.modelo_id
--			join TipoTransaccion TP on TP.id = CP.id_transaccion
--			where CP.balance_rd > 0 and CP.balance_usd > 0 
--			and format(CP.fecha,'yyyy-MM-dd') between
--			format (@desde, 'yyyy-MM-dd') and format (@hasta, 'yyyy-MM-dd') and CP.id_transaccion = 5 and CP.nueva = 1

--			union

--			select CP.id as CUENTAPAGAR,TP.transaccion as TRANSACCION ,CP.fecha as  FECHACOMPRA ,S.taller as PROPIETARIO,
--			CONVERT(varchar(200),(F.fabricante + ' ' + M.modelo + ' ' + CONVERT(varchar(10), V.año) + ' ' + V.color)) as VEHICULO,
--			CP.monto_rd as TOTALPAGARRD, CP.monto_usd as TOTALPAGARUSD,
--			(CP.monto_rd - CP.balance_rd) as PAGADORD, (CP.monto_usd - CP.balance_usd) as PAGADOUSD,
--			CP.balance_rd as PENDIENTERD, CP.balance_usd as PENDIENTEUSD,
--			ISNULL(DATEDIFF(DAY, format (CP.fecha, 'yyyy-MM-dd'),
--			format (GETDATE(), 'yyyy-MM-dd')), 0) as DIASVIGENTE
--			from CuentasPagar CP join Detalle_CC_CP_Antiguas V on V.id_cuenta = CP.id join TalleresRepuestos S on S.id = CP.id_vendedor
--			join Fabricantes F on F.id = V.id_fabricante join Modelos M on M.id = V.id_modelo
--			join TipoTransaccion TP on TP.id = CP.id_transaccion
--			where CP.balance_rd > 0 and CP.balance_usd > 0 
--			and format(CP.fecha,'yyyy-MM-dd') between
--			format (@desde, 'yyyy-MM-dd') and format (@hasta, 'yyyy-MM-dd') and CP.id_transaccion = 5 and CP.nueva = 0 and V.id_tipo_cuenta = 1
--		end

--	 else if @idTransaccion = 6
--		begin
--			select CP.id as CUENTAPAGAR,TP.transaccion as TRANSACCION ,CP.fecha as  FECHACOMPRA ,S.taller as PROPIETARIO,
--			CONVERT(varchar(200),(F.fabricante + ' ' + M.modelo + ' ' + CONVERT(varchar(10), V.año) + ' ' + V.color)) as VEHICULO,
--			CP.monto_rd as TOTALPAGARRD, CP.monto_usd as TOTALPAGARUSD,
--			(CP.monto_rd - CP.balance_rd) as PAGADORD, (CP.monto_usd - CP.balance_usd) as PAGADOUSD,
--			CP.balance_rd as PENDIENTERD, CP.balance_usd as PENDIENTEUSD,
--			ISNULL(DATEDIFF(DAY, format (CP.fecha, 'yyyy-MM-dd'),
--			format (GETDATE(), 'yyyy-MM-dd')), 0) as DIASVIGENTE
--			from CuentasPagar CP join Vehiculos V on V.id = CP.id_vehiculo join TalleresRepuestos S on S.id = CP.id_vendedor
--			join Fabricantes F on F.id = V.fabricante_id join Modelos M on M.id = V.modelo_id
--			join TipoTransaccion TP on TP.id = CP.id_transaccion
--			where CP.balance_rd > 0 and CP.balance_usd > 0 
--			and format(CP.fecha,'yyyy-MM-dd') between
--			format (@desde, 'yyyy-MM-dd') and format (@hasta, 'yyyy-MM-dd') and CP.id_transaccion = 6 and CP.nueva = 1

--			union

--			select CP.id as CUENTAPAGAR,TP.transaccion as TRANSACCION ,CP.fecha as  FECHACOMPRA ,S.taller as PROPIETARIO,
--			CONVERT(varchar(200),(F.fabricante + ' ' + M.modelo + ' ' + CONVERT(varchar(10), V.año) + ' ' + V.color)) as VEHICULO,
--			CP.monto_rd as TOTALPAGARRD, CP.monto_usd as TOTALPAGARUSD,
--			(CP.monto_rd - CP.balance_rd) as PAGADORD, (CP.monto_usd - CP.balance_usd) as PAGADOUSD,
--			CP.balance_rd as PENDIENTERD, CP.balance_usd as PENDIENTEUSD,
--			ISNULL(DATEDIFF(DAY, format (CP.fecha, 'yyyy-MM-dd'),
--			format (GETDATE(), 'yyyy-MM-dd')), 0) as DIASVIGENTE
--			from CuentasPagar CP join Detalle_CC_CP_Antiguas V on V.id_cuenta = CP.id join TalleresRepuestos S on S.id = CP.id_vendedor
--			join Fabricantes F on F.id = V.id_fabricante join Modelos M on M.id = V.id_modelo
--			join TipoTransaccion TP on TP.id = CP.id_transaccion
--			where CP.balance_rd > 0 and CP.balance_usd > 0 
--			and format(CP.fecha,'yyyy-MM-dd') between
--			format (@desde, 'yyyy-MM-dd') and format (@hasta, 'yyyy-MM-dd') 
--			and CP.id_transaccion = 6 and CP.nueva = 0 and V.id_tipo_cuenta = 1
--		end

--	else 
--		begin
--			select CP.id as CUENTAPAGAR,TP.transaccion as TRANSACCION ,CP.fecha as  FECHACOMPRA ,S.taller as PROPIETARIO,
--			CONVERT(varchar(200),(F.fabricante + ' ' + M.modelo + ' ' + CONVERT(varchar(10), V.año) + ' ' + V.color)) as VEHICULO,
--			CP.monto_rd as TOTALPAGARRD, CP.monto_usd as TOTALPAGARUSD,
--			(CP.monto_rd - CP.balance_rd) as PAGADORD, (CP.monto_usd - CP.balance_usd) as PAGADOUSD,
--			CP.balance_rd as PENDIENTERD, CP.balance_usd as PENDIENTEUSD,
--			ISNULL(DATEDIFF(DAY, format (CP.fecha, 'yyyy-MM-dd'),
--			format (GETDATE(), 'yyyy-MM-dd')), 0) as DIASVIGENTE
--			from CuentasPagar CP join Vehiculos V on V.id = CP.id_vehiculo join TalleresRepuestos S on S.id = CP.id_vendedor
--			join Fabricantes F on F.id = V.fabricante_id join Modelos M on M.id = V.modelo_id
--			join TipoTransaccion TP on TP.id = CP.id_transaccion
--			where CP.balance_rd > 0 and CP.balance_usd > 0 
--			and format(CP.fecha,'yyyy-MM-dd') between
--			format (@desde, 'yyyy-MM-dd') and format (@hasta, 'yyyy-MM-dd') and CP.id_transaccion = 7 and CP.nueva = 1
			
--			union

--			select CP.id as CUENTAPAGAR,TP.transaccion as TRANSACCION ,CP.fecha as  FECHACOMPRA ,S.taller as PROPIETARIO,
--			CONVERT(varchar(200),(F.fabricante + ' ' + M.modelo + ' ' + CONVERT(varchar(10), V.año) + ' ' + V.color)) as VEHICULO,
--			CP.monto_rd as TOTALPAGARRD, CP.monto_usd as TOTALPAGARUSD,
--			(CP.monto_rd - CP.balance_rd) as PAGADORD, (CP.monto_usd - CP.balance_usd) as PAGADOUSD,
--			CP.balance_rd as PENDIENTERD, CP.balance_usd as PENDIENTEUSD,
--			ISNULL(DATEDIFF(DAY, format (CP.fecha, 'yyyy-MM-dd'),
--			format (GETDATE(), 'yyyy-MM-dd')), 0) as DIASVIGENTE
--			from CuentasPagar CP join Detalle_CC_CP_Antiguas V on V.id_cuenta = CP.id join TalleresRepuestos S on S.id = CP.id_vendedor
--			join Fabricantes F on F.id = V.id_fabricante join Modelos M on M.id = V.id_modelo
--			join TipoTransaccion TP on TP.id = CP.id_transaccion
--			where CP.balance_rd > 0 and CP.balance_usd > 0 
--			and format(CP.fecha,'yyyy-MM-dd') between
--			format (@desde, 'yyyy-MM-dd') and format (@hasta, 'yyyy-MM-dd') and CP.id_transaccion = 7 and CP.nueva = 0 and V.id_tipo_cuenta = 1
--		end

--end

GO

ALTER procedure [dbo].[reporte_cuentas_cobrar]
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
ALTER procedure [dbo].[reporte_efectivo_cobrado]
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

Go
-- ************************************************************************ CREATE **********************************************************************
CREATE TABLE Detalle_CC_CP_Antiguas (
    id int IDENTITY(1,1) NOT NULL PRIMARY KEY,
    id_cuenta int,
	id_fabricante int,
    id_modelo int,
	color varchar(50),
    año int,
	chasis varchar(50),
	id_seguro int,
	dias_seguro int,
	id_tipo_cuenta int
);

GO

create procedure registrar_cc_cp_antigua
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
Go

create procedure registrar_detalle_cc_cp_antigua
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

Go

create procedure obtener_detalle_cuenta_cobrar_antigua
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

create procedure reporte_datos_recibo_cobro_antiguo
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

Go

--create procedure [dbo].[obtener_detalle_cuenta_por_pagar_antiguo]
--@idCP int, @idTransaccion int
--as

--begin
	
--	if @idTransaccion = 2 -- Compra
--		begin 
--			select CP.id_vehiculo as ID,
--			CONVERT(varchar(200),(F.fabricante + ' ' + M.modelo + ' ' + CONVERT(varchar(10), V.año) + ' ' + V.color)) 
--			as VEHICULO, V.chasis as CHASIS, ISNULL(DATEDIFF(DAY, format (CP.fecha, 'yyyy-MM-dd'), format (GETDATE(), 'yyyy-MM-dd')), 0) as 'DIAS VIGENTE',	
--			Sup.suplidor as PROPIETARIO,Sup.direccion as DIRECCION, Sup.rnc_cedula as CEDULA, Sup.telefono as TEL ,
--			format(CP.fecha, 'dd/MM/yyyy' )as 'FECHA COMPRADO',
--			CP.monto_rd as 'PRECIO ($RD)', CP.monto_usd as 'PRECIO ($USD)',
--			P.pais as PAIS, C.ciudad as CIUDAD, CP.nota as NOTA
	
--			from CuentasPagar CP join Detalle_CC_CP_Antiguas V on V.id_cuenta = CP.id join Fabricantes F on V.id_fabricante = F.id join Modelos M on V.id_modelo = M.id 
--			join Suplidores Sup on CP.id_vendedor = Sup.id
--			join Paises P on P.id = Sup.id_pais join Ciudades C on C.id = Sup.id_ciudad
	
--			where CP.id = @idCP and CP.id_transaccion = 2 and CP.nueva = 0 and V.id_tipo_cuenta = 1
--		end
--	else if @idTransaccion = 4 --Seguro
--		begin 
--			select CP.id_vehiculo as ID,
--			CONVERT(varchar(200),(F.fabricante + ' ' + M.modelo + ' ' + CONVERT(varchar(10), V.año) + ' ' + V.color)) 
--			as VEHICULO, V.chasis as CHASIS, ISNULL(DATEDIFF(DAY, format (CP.fecha, 'yyyy-MM-dd'), format (GETDATE(), 'yyyy-MM-dd')), 0) as 'DIAS VIGENTE',	
--			seg.nombre as PROPIETARIO, Seg.telefono as TEL ,
--			format(CP.fecha, 'dd/MM/yyyy' )as 'FECHA COMPRADO', 
--			CP.monto_rd as 'PRECIO ($RD)', CP.monto_usd as 'PRECIO ($USD)', CP.nota as NOTA
			
--			from CuentasPagar CP join Detalle_CC_CP_Antiguas V on V.id_cuenta = CP.id join Fabricantes F on V.id_fabricante = F.id join Modelos M on V.id_modelo = M.id 
--			join Seguros Seg on CP.id_vendedor = Seg.id 

--			where CP.id = @idCP and CP.id_transaccion = 4 and CP.nueva = 0 and V.id_tipo_cuenta = 1
--		end

--	 else if @idTransaccion = 5 -- Pieza
--		begin 
--			select CP.id_vehiculo as ID,
--			CONVERT(varchar(200),(F.fabricante + ' ' + M.modelo + ' ' + CONVERT(varchar(10), V.año) + ' ' + V.color)) 
--			as VEHICULO, V.chasis as CHASIS, ISNULL(DATEDIFF(DAY, format (CP.fecha, 'yyyy-MM-dd'), format (GETDATE(), 'yyyy-MM-dd')), 0) as 'DIAS VIGENTE',	
--			TR.taller as PROPIETARIO, TR.telefono1 as TEL, TR.direccion as DIRECCION ,
--			format(CP.fecha, 'dd/MM/yyyy' )as 'FECHA COMPRADO', 
--			CP.monto_rd as 'PRECIO ($RD)', CP.monto_usd as 'PRECIO ($USD)',
--			(select  C.componente from Componentes C join CuentasPagar CP on CP.id_gasto = C.id where CP.id_transaccion = @idTransaccion and CP.id = @idCP) as PIEZA,
--			CP.nota as NOTA
			
--			from CuentasPagar CP join Detalle_CC_CP_Antiguas V on V.id_cuenta = CP.id join Fabricantes F on V.id_fabricante = F.id join Modelos M on V.id_modelo= M.id 
--			join TalleresRepuestos TR on TR.id = CP.id_vendedor 
			

--			where CP.id = @idCP and CP.id_transaccion = 5 and CP.nueva = 0 and V.id_tipo_cuenta = 1
--		end
--	else if @idTransaccion = 6 -- MECANICA
--		begin 
--			select CP.id_vehiculo as ID,
--			CONVERT(varchar(200),(F.fabricante + ' ' + M.modelo + ' ' + CONVERT(varchar(10), V.año) + ' ' + V.color)) 
--			as VEHICULO, V.chasis as CHASIS, ISNULL(DATEDIFF(DAY, format (CP.fecha, 'yyyy-MM-dd'), format (GETDATE(), 'yyyy-MM-dd')), 0) as 'DIAS VIGENTE',	
--			TR.taller as PROPIETARIO, TR.telefono1 as TEL, TR.direccion as DIRECCION ,
--			format(CP.fecha, 'dd/MM/yyyy' )as 'FECHA COMPRADO', 
--			CP.monto_rd as 'PRECIO ($RD)', CP.monto_usd as 'PRECIO ($USD)', 
--			(select  G.descripcion from CuentasPagar CP  join  Gastos G on CP.id_gasto = G.id where CP.id_transaccion = 6 and CP.id = @idCP) as GASTO,
--			CP.nota as NOTA
			
			
--			from CuentasPagar CP join Detalle_CC_CP_Antiguas V on V.id_cuenta = CP.id join Fabricantes F on V.id_fabricante = F.id join Modelos M on V.id_modelo= M.id 
--			join TalleresRepuestos TR on TR.id = CP.id_vendedor 

--			where CP.id = @idCP and CP.id_transaccion = 6 and CP.nueva = 0 and V.id_tipo_cuenta = 1
--		end

--	else if @idTransaccion = 7 -- OTROS
--		begin 
--			select CP.id_vehiculo as ID,
--			CONVERT(varchar(200),(F.fabricante + ' ' + M.modelo + ' ' + CONVERT(varchar(10), V.año) + ' ' + V.color)) 
--			as VEHICULO, V.chasis as CHASIS, ISNULL(DATEDIFF(DAY, format (CP.fecha, 'yyyy-MM-dd'), format (GETDATE(), 'yyyy-MM-dd')), 0) as 'DIAS VIGENTE',	
--			TR.taller as PROPIETARIO, TR.telefono1 as TEL, TR.direccion as DIRECCION ,
--			format(CP.fecha, 'dd/MM/yyyy' )as 'FECHA COMPRADO', 
--			CP.monto_rd as 'PRECIO ($RD)', CP.monto_usd as 'PRECIO ($USD)', 
--			(select  G.descripcion from Gastos G join  CuentasPagar CP on CP.id_gasto = G.id where CP.id_transaccion = 7 and CP.id = @idCP) as GASTO,
--			CP.nota as NOTA
			
--			from CuentasPagar CP join Detalle_CC_CP_Antiguas V on V.id_cuenta = CP.id join Fabricantes F on V.id_fabricante = F.id join Modelos M on V.id_modelo= M.id 
--			join TalleresRepuestos TR on TR.id = CP.id_vendedor 

--			where CP.id = @idCP and CP.id_transaccion = 7 and CP.nueva = 0 and V.id_tipo_cuenta = 1
--		end
	
	
		
--end

--GO

GO
create procedure [dbo].[obtener_tipo_cuenta_cobrar]
@idCC int

as

begin

	select TP.transaccion
	from CuentasCobrar CC join TipoTransaccion TP on TP.id = CC.id_transaccion 
	where CC.id = @idCC
end