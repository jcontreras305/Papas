use PapaSC
go
--########################################################################
--########### PROCEDIMINETO PARA LA INTERFAZ DE REUBICACION ##############
--########################################################################

create proc sp_insertar_reubicacion
@producto varchar(100),
@descripcion varchar(200),
@bodega1 varchar(50),
@bodega2 varchar(50),
@nombreUsuario varchar(20),
@cantidad float,
@msg varchar(100) output
as 
declare @error int
declare @idProducto varchar(36)
declare @idBodega1 varchar(36)
declare @idBodega2 varchar(36)
declare @idUsuario varchar(36)
declare @fecha varchar(15)
declare @idReubicacion varchar (36)
declare @diferencia float
declare @cont int
begin 
	begin tran
		begin try	 
			set @msg = 'Se hizo el cambio con exito'
			select @idBodega1 = idBodega  from bodega where nombre = @bodega1
			select @idBodega2 = idBodega  from bodega where nombre = @bodega2
			select @idProducto = idProducto from producto where version = @producto
			select @idUsuario = idUsuario from usuarios where nombreUsuario = @nombreUsuario

			select @cont = COUNT(*)  from existenciaProductos where idBodega = @idBodega2 and idProducto = @idProducto -- esto es prevetivo en caso de que no exista la relacion de existencia en un producto en una bodega
			if @cont = 0 begin --si en caso de que no exista el producto en la bodega a la que se esta reubicando se crea el producto en la bodega de destino con existencia 0
				insert into existenciaProductos values (@idBodega2 , @idProducto , 0)	
				set @msg = CONCAT(@msg,'El producto ',@producto, ' se agrego a la bodega ',@bodega2,'. ')
			end
				-- asigno datos necesarios para hacer la insercion de la reubicacion 
				set @fecha = CONVERT(varchar(15), GETDATE(),103)
				set @idReubicacion = NEWID()
				-- realizo el registro de la reubicaion 
				insert into reubicacion values (@idReubicacion, @fecha,@descripcion,@idBodega1,@idBodega2,@idUsuario)
				if @@ERROR <>0 begin set @error= @@ERROR
				goto resoverproblema
				 end -- si hay un error 
				insert into detalleReubicacion values (NEWID(),@idProducto,@idReubicacion,@cantidad)
				if @@ERROR <>0 begin set @error= @@ERROR
					goto resoverproblema
				end
				--actualizacion de las exitencias en las bodegas 
				select @diferencia = cantidad - @cantidad from existenciaProductos where idBodega = @idBodega1 and idProducto = @idProducto
				update existenciaProductos set cantidad = @diferencia where idBodega = @idBodega1 and idProducto = @idProducto 
				if @@ERROR <> 0 begin 
					set @error = @@ERROR
					goto resoverproblema
				end
				select @diferencia = cantidad + @cantidad from existenciaProductos where idBodega = @idBodega2 and idProducto = @idProducto
				update existenciaProductos set cantidad = @diferencia where idBodega = @idBodega2 and idProducto = @idProducto
				if @@ERROR <> 0 begin 
					set @error = @@ERROR
					goto resoverproblema
				end
		end try 
		begin catch
			goto resoverproblema
		end catch 
	commit tran
	resoverproblema:
		if @error <> 0
		begin 
			set	@msg = 'Surgio un problema intentelo de nuevo.'
			rollback
		end
end

declare @msg varchar(max)
execute sp_insertar_reubicacion 'Sucia tercera','calis','Bodega 1','Bodega2','admin',12.70, @msg output
select @msg

--########################################################################
--########### PROCEDIMINETO PARA LA INTERFAZ DE RECLASIFICACIO ###########
--########################################################################

select * from producto
select * from existenciaProductos
select nombre from bodega
select bg.nombre,  pd.version, pd.clave, ep.cantidad , 
	case 
		when pd.precio IS NULL THEN '0,00'
		when pd.precio is not null then concat(pd.precio,'')
	end as cantidad 
from producto as pd right join existenciaProductos as ep 
on pd.idProducto = ep.idProducto 
left join bodega as bg on ep.idBodega = bg.idBodega where bg.nombre = 'Bodega 1' 

select bg.nombre,  pd.version, pd.clave, ep.cantidad 
from producto as pd right join existenciaProductos as ep 
on pd.idProducto = ep.idProducto 
left join bodega as bg on ep.idBodega = bg.idBodega where bg.nombre = 'Bodega 1' and (pd.version like '%%%' or pd.clave like '%%%')

select pd.version from producto as pd right join existenciaProductos as ep 
on pd.idProducto = ep.idProducto left join bodega as bg on ep.idBodega = bg.idBodega where bg.nombre = 'Bodega 1' order by pd.version

declare @mesg varchar(100) 
execute sp_insertReclasificacion 'Bodega 1' ,'Sucia segunda', 'Lavada primera','50.00', @mesg 

create proc sp_insertReclasificacion
@nombreBodega varchar(30),
@nombreProducto1 varchar(15),
@nombreProducto2 varchar(15),
@cantidad float
--@msg varchar(100) output
as
declare @idBodega varchar(36)
declare @idProducto1 varchar(36)
declare @idProducto2 varchar(36)
declare @error int
begin 
	begin tran
		begin try
			--set @msg = 'Hecho'
			select @idBodega = idBodega from bodega where nombre = @nombreBodega
			select @idProducto1 = idProducto from producto where version = @nombreProducto1
			select @idProducto2 = idProducto from producto where version = @nombreProducto2
			if @@ERROR <> 0 begin
				set @error = @@ERROR 
				goto soloucionarproblema
			end 
			update existenciaProductos set cantidad = cantidad - @cantidad where idBodega = @idBodega and idProducto = @idProducto1
			if @@ERROR <> 0 begin 
				set @error = @@ERROR 
				goto soloucionarproblema	
			end 
			update existenciaProductos set cantidad = cantidad + @cantidad where idBodega = @idBodega and idProducto = @idProducto2
			if @@ERROR <> 0 begin 
				set @error = @@ERROR 
				goto soloucionarproblema
			end 
		end try
		begin catch
			goto soloucionarproblema	
		end catch
	commit tran
	soloucionarproblema:
		if @error <> 0 
		begin 
			rollback
			--set @msg  = 'No se logro completar los cambio'
		end
end




--##########################################################################################
--######################## consultas y cambios para cajas ##################################
--##########################################################################################


select * from venta
select * from ventaDetalle
select * from bodega 
select * from existenciaProductos
select * from caja


create table caja(
idCaja varchar(36) not null primary key,
nombre varchar(20) not null,
clave varchar(5),
estatus char(1)
)
go


create table corteCaja(
	idCorteCaja varchar(36) not null,
	montoInicial float,
	montoFinal float,
	fechaInicio smalldatetime,
	fechaFin smalldatetime,
	idCaja varchar(36),
	idEmpleado varchar(36),
)


alter table corteCaja  
add constraint fk_idCaja_Caja
foreign key (idCaja) references caja(idCaja)

alter table corteCaja 
add constraint fk_idEmpledo_Caja
foreign key (idEmpleado) references empleado(idEmpleado)

alter table venta 
add tipoPago varchar(30)

alter table venta 
add idCaja varchar(36)

alter table venta 
add constraint fk_idCaja_venta
foreign key (idCaja) references caja(idCaja)

alter table venta 
add folio int

alter table venta 
add idTicket varchar(36)

create table ticket(
	idTicket varchar(36) primary key not null,
	idBodega varchar(36),
	clave varchar(20),
	nombre varchar(50),
	tipoFuente varchar(30),
	tama�oFuente int,
	textoEnbezado varchar(50),
	textoPie varchar(100)
)

select * from tipoCliente	


alter table venta
add constraint fk_ticket_venta
foreign key (idTicket) references ticket(idTicket) 

select * from producto

select  vd.cantidad, pd.version as producto , pd.precio
 from venta as vt inner join ventaDetalle as vd 
on vt.idVenta = vd.idVenta 
left join producto as pd 
on vd.idProducto = pd.idProducto where vt.folio = 1


select * from ticket

create proc sp_datosTicket
@idVenta varchar(36)
as
begin
	select vt.fecha, vt.folio, em.nombre, cj.nombre, cl.nombre, vd.cantidad , pd.version , pd.precio,vt.cantidadPagada from 
	venta as vt inner join ventaDetalle as vd 
	on vt.idVenta = vd.idVenta 
	left join producto as pd 
	on vd.idProducto = pd.idProducto
	left join empleado as em 
	on em.idEmpleado = vt.idEmpleado
	left join caja as cj 
	on vt.idCaja = cj.idCaja
	left join cliente as cl
	on vt.idCliente = cl.idCliente
	where vt.idVenta = @idVenta
end

create proc sp_formatoTicket 
@clave int ,
@nombre varchar(50)
as
begin 
	select clave, bg.nombre as bodega , tk.nombre, tipoFuente, tama�oFuente, textoEncabezado as Encabezado, textoPie as Pie , textoDireccion as Direccion  from ticket as tk left join bodega as bg  on tk.idBodega = bg.idBodega
	where clave = @clave and bg.nombre = @nombre
end


select clave, bg.nombre as bodega , tk.nombre, tipoFuente, tama�oFuente, textoEnbezado as Encabezado, textoPie as Pie  from ticket as tk left join bodega as bg  on tk.idBodega = bg.idBodega 

select clave, bg.nombre as bodega , tk.nombre, tipoFuente, tama�oFuente, textoEncabezado as Encabezado, textoPie as Pie , textoDireccion as Direccion  from ticket as tk left join bodega as bg  on tk.idBodega = bg.idBodega

update ticket set tipoFuente = @tipoFuente , tama�oFuente = @tama�oFuente , textoEnbezado =@textoEnbezado, textoPie = @textoPie , textoDireccion = @textoDireccion
where clave = '' and nombre = ''


--##########################################################################################################
--############################  Procedimientos almacenados de Caja #########################################
--##########################################################################################################

select * from caja
select * from corteCaja
select * from bodega
select * from matriz
select * from venta
select * from ventaDetalle

alter table caja
add fase varchar(20)

alter table caja
add limiteEfectivo float 

alter table caja 
add idBodega varchar(36)

alter table caja 
add constraint fk_idBodega_Caja
foreign key (idBodega) references bodega(idBodega)

alter table caja 
add explicito char(1)

select idCaja , cj.nombre,cj.clave, cj.estatus,cj.fase , cj.limiteEfectivo, bd.nombre as Bodega  from caja as  cj left join bodega as bd
on cj.idBodega = bd.idBodega 

select * from caja
create  proc sp_Insertar_Caja
	@nombre varchar(20),
	@clave varchar(5),
	@estatus char(1),
	@fase varchar(20),
	@limiteEfectivo float,
	@explicito char(1),
	@idBodega varchar(36)
as
declare @error int
declare @idCaja varchar(36)
begin 
	begin tran 
		begin try	
			set @idCaja = NEWID()
			insert into caja values(@idCaja,@nombre,@clave,@estatus,@fase,@limiteEfectivo,@idBodega,@explicito)
			if @@ERROR <>0 begin set @error = @error goto solucionar end
			if @explicito = 'A' begin
				insert into contabilidadCaja  values(NEWID(),@idCaja,0.0,0,0,0,0,0,0,0,0,0,0,0,0)
			end
			else begin 
				insert into contabilidadCaja  values(NEWID(),@idCaja,0.0,null,null,null,null,null,null,null,null,null,null,null,null)
			end
			if @@ERROR <>0 begin set @error = @error goto solucionar end
		end try
		begin catch
			goto solucionar
		end catch
	commit tran
	solucionar:
		if @error <>0
		begin 
			rollback
		end
end
go

create proc sp_Actualizar_Caja
	@idCaja varchar(36),
	@nombre varchar(10),
	@clave varchar(5),
	@estatus char(1),
	@fase char(20),
	@limiteEfectivo float,
	@explicito char(1),
	@idBodega varchar(36)
as
declare @error int
begin
	begin tran	
		begin try
			update caja set nombre = @nombre , clave = @clave , estatus = @estatus, fase = @fase , limiteEfectivo = @limiteEfectivo , explicito=@explicito,idBodega = @idBodega where idCaja = @idCaja
			if @@ERROR <> 0 begin
				set @error = @@ERROR 
				goto resolver
			end
		end try
		begin catch
			goto resolver
		end catch
	commit tran
	resolver:
	if @error <>0 begin 
		rollback
	end
end
go

select * from bodega
select * from caja

select idCaja , cj.nombre as Caja,cj.clave as Referencia, cj.estatus as Estatus,cj.fase as Fase, cj.limiteEfectivo, bd.nombre as Bodega  
from caja as  cj left join bodega as bd on cj.idBodega = bd.idBodega  
where bd.nombre like '%c%' or cj.nombre like '%c%' or cj.fase like '%c%'

select nombre from caja where not estatus='B'
update caja set estatus = 'B'
select * from empleado 

select * from corteCaja
declare @fecha date
set @fecha = SYSDATETIME()
print @fecha


create alter proc sp_Iniciar_Caja
	@montoInicial float,
	@fechaInicio smalldatetime,
	@idCaja varchar(36),
	@idEmpleado varchar(36)
as 
declare @error int
declare @cont int 
begin
	begin tran 
		begin try
			select @cont = count(*) from empleado where idEmpleado = @idEmpleado
			if @cont = 1 begin 
				insert into corteCaja values(NEWID(),@montoInicial,null,@fechaInicio,null,@idCaja,@idEmpleado)
				if @@ERROR <> 0 begin set @error = @@ERROR goto resolver end
				update caja set fase = 'Abierta' where idCaja = @idCaja
				if @@ERROR <> 0 begin set @error = @@ERROR goto resolver end
			end
		end try
		begin catch
			goto resolver
		end catch
	commit tran
	resolver:
	if @error <>0 begin
		rollback	
	end
end
go

create proc  sp_Cerrar_Caja
	@fechaFin smalldatetime,
	@idCaja varchar(36)
as 
declare @error int
declare @cont int 
declare @montoFinal float
begin
	begin tran 
		begin try	
			select @cont= count(*) from caja where idCaja = @idCaja and estatus = 'A'
			if @cont = 1 begin 
				select @montoFinal = total from contabilidadCaja where idCaja = @idCaja
				update corteCaja set montoFinal = @montoFinal , fechaFin = @fechaFin where idCaja = @idCaja 
				if @@ERROR <> 0 begin set @error = @@ERROR goto resolver end
				update caja set fase = 'Cerrada' where idCaja = @idCaja
				if @@ERROR <> 0 begin set @error = @@ERROR goto resolver end
			end
		end try
		begin catch
			goto resolver
		end catch
	commit tran
	resolver:
	if @error <>0 begin
		rollback	
	end
end
go
	
	
select * from empleado
select * from cliente
select * from caja 
select * from contabilidadCaja 
select * from tipoCliente
select * from venta

select vt.folio as Clave, case 
							when cl.nombre= NULL then cl.razonSocial 
							when cl.razonSocial = null then cl.nombre
							else cl.RFC end as RazonSocial,
							tcl.tipo as Tipo,
							ct.limiteCredito as LimitaCr�dito,
							ct.diasCredito as D�asCr�dito,
							ct.saldo as Saldo,
							case when cl.estatus = 'A' then 'Activo'
								 when cl.estatus = 'I' then 'Inactivo'
								 when cl.estatus = 'B' then 'Bloqueado'
								 else 'Borrado' end as Estatus
								  from 
venta vt inner join caja as cj on vt.idCaja = cj.idCaja
left join cliente as cl on vt.idCliente = cl.idCliente
left join tipoCliente as tcl on cl.idTipoCliente = tcl.idTipoCliente 
left join credito as ct on ct.idCliente = cl.idCliente
where cl.nombre like '' 
or	cl.razonSocial like ''
or cl.RFC like ''
or limiteCredito like ''
or saldo like ''
and cj.nombre = ''
or vt.fecha between @fecha1 and @fecha2


select * from corteCaja
insert into contabilidadCaja values (NEWID(),'387FA85C-77E1-49AA-A1E1-C7D8438769A3',0.0,0,0,0,0,0,0,0,0,0,0,0,0),(NEWID(),'DE63F853-BF3F-4692-9B09-A21A6178F30F',0.0,0,0,0,0,0,0,0,0,0,0,0,0)

select total from contabilidadCaja

create table contabilidadCaja (
	idCont varchar(36) primary key not null,
	idCaja varchar(36) not null,
	total float not null,
	cantB1000 int null,
	cantB500 int null,
	cantB200 int null,
	cantB100 int null,
	cantB50 int null,
	cantB20 int null,
	cantM20 int null,
	cantM10 int null,
	cantM5 int null,
	cantM2 int null,
	cantM1 int null,
	cantM05 int null
)

alter table contabilidadCaja
add constraint fk_idCaja_ContabilidadCaja
foreign key (idCaja ) references caja(idCaja)

select * from ticket
select * from venta

select idCaja , cj.nombre as Caja,cj.clave as Referencia, cj.estatus as Estatus,cj.fase as Fase, cj.limiteEfectivo, bd.nombre as Bodega, cj.explicito as ValoresExplicitos from caja as  cj left join bodega as bd on cj.idBodega = bd.idBodega where not cj.estatus = 'B'



select vt.folio as Clave, case 
							when cl.nombre= NULL then cl.razonSocial 
							when cl.razonSocial = null then cl.nombre
							else cl.RFC end as RazonSocial,
							tcl.tipo as Tipo,
							ct.limiteCredito as LimitaCr�dito,
							ct.diasCredito as D�asCr�dito,
							ct.saldo as Saldo,
							case when cl.estatus = 'A' then 'Activo'
								 when cl.estatus = 'I' then 'Inactivo'
								 when cl.estatus = 'B' then 'Bloqueado'
								 else '' end as Estatus
								  from 
venta vt inner join caja as cj on vt.idCaja = cj.idCaja
left join cliente as cl on vt.idCliente = cl.idCliente
left join tipoCliente as tcl on cl.idTipoCliente = tcl.idTipoCliente 
left join credito as ct on ct.idCliente = cl.idCliente where cl.nombre like '' 
or	cl.razonSocial like '%'
or cl.RFC like '%'
or limiteCredito like '%'
or saldo like '%'
and cj.nombre =  'cajaIsaac'
go

select vt.folio as clave, cl.RFC, case 
							when cl.nombre= NULL then cl.razonSocial 
							when cl.razonSocial = null then cl.nombre
							else cl.RFC end as RazonSocial,
							cn.nombre as Contacto,
							case 
								when cn.telefono = null then telefono2
								when cn.telefono <> null then telefono
								else 'ND' end as Telefono,
							case 
								when cn.email = NULL then cn.email2
								when cn.email <> '' then cn.email
								else 'ND' end as Email,
							ct.limiteCredito as LimiteCredito,
							ct.diasCredito as D�as ,
							ct.limiteCredito - ct.saldo as Cobraza
							
from 
venta as vt inner join caja as cj on vt.idCaja = cj.idCaja
left join  cliente as cl on vt.idCliente = cl.idCliente
left join contacto as cn on cn.idCliente = cl.idCliente
left join tipoCliente as tcl on cl.idTipoCliente = tcl.idTipoCliente 
left join credito as ct on ct.idCliente = cl.idCliente
where cj.idCaja = '' and vt.estatus = 'P'

--===================================================================================================
--========================== Cambios en la interfaz de REUBICACIONES ================================
--===================================================================================================
--FUE NECESARIO HACER EL CAMBIO DE LA COLUMNA FEHCA DE TIPO DATE A SMALLDATETIME POR PRACTICIDAD
alter table reubicacion
alter column fecha smalldatetime

-- AHORA SON DOS PROCEDIMIENTOS 
--===================================================================================================
--===================== PROC PARA INSERTAR UNA REUBICACION ==========================================
--===================================================================================================

create proc sp_insertar_reubicar
@descripcion varchar(200),
@bodega1 varchar(50),
@bodega2 varchar(50),
@nombreUsuario varchar(20),
@fecha smalldatetime ,
@idReubicacion  as varchar (36) output, 
@msg as varchar (300) output
as 
declare @error int
declare @idBodega1 varchar(36)
declare @idBodega2 varchar(36)
declare @idUsuario varchar(36)
begin 
	set @msg = 'true'
	begin try
		select @idBodega1 = idBodega  from bodega where nombre = @bodega1
		select @idBodega2 = idBodega  from bodega where nombre = @bodega2
		select @idUsuario = idUsuario from usuarios where nombreUsuario = @nombreUsuario
		set @idReubicacion = NEWID()
		-- realizo el registro de la reubicaion 
		insert into reubicacion values (@idReubicacion, @fecha,@descripcion,@idBodega1,@idBodega2,@idUsuario)
	end try 
	begin catch 
		set @msg = 'flase'
	end catch 
end
--===================================================================================================
--===================== PROC PARA INSERTAR LOS DETALLE DE REUBICACION  ==============================
--===================================================================================================
create proc sp_insert_detalleReubicacion
	@idReubicacion varchar(36),
	@producto varchar(100),
	@cantidad float,
	@bodega1 varchar(50),
	@bodega2 varchar(50),
	@msg varchar(50) output
as
declare @idProducto varchar(36)
declare @idBodega1 varchar(36)
declare @idBodega2 varchar(36)
declare @diferencia float
declare @error int
begin 
	begin try
			set @msg = 'true'
			--obtengo los datos
			select @idProducto = idProducto from producto where version = @producto 
			select @idBodega1 = idBodega from bodega where nombre = @bodega1
			select @idBodega2 = idBodega from bodega where nombre = @bodega2
			--insercion del detalle de la reubicacion
			insert into detalleReubicacion values (NEWID(), @idProducto , @idReubicacion , @cantidad)
			--actualizar los datos de la bodega 1 
			select @diferencia = cantidad - @cantidad from existenciaProductos where idBodega = @idBodega1 and idProducto = @idProducto
			update existenciaProductos set cantidad = @diferencia where idBodega = @idBodega1 and idProducto = @idProducto 
			--actualizar los datos de la bodega 2
			select @diferencia = cantidad + @cantidad from existenciaProductos where idBodega = @idBodega2 and idProducto = @idProducto
			update existenciaProductos set cantidad = @diferencia  where idBodega = @idBodega2 and idProducto = @idProducto
		end try
		begin catch
			set @msg = 'false'
		end catch
end

--===================================================================================================
--========================= PROCEDIMIENTOS PARA REPORTE DE REUBICACIONES ============================
--===================================================================================================

create proc sp_report_Reubicacio_GRu
@idReubicacion as varchar(36)
as
begin
select fecha , descripcion , (select top 1 nombre from empleado where usr.idUsuario = ru.idUsuario) as Empleado from 
	reubicacion as ru  left join usuarios as usr on ru.idUsuario = usr.idUsuario
	left join empleado as emp on usr.idEmpleado = emp.idEmpleado
	where ru.idReubicacion = @idReubicacion
end

create proc sp_report_Reubicacion_DRu
@idReubicacion	varchar (36)
as
begin
	select pdr.version as Producto ,pdr.clave as 'Clave del Producto' , bdg1.nombre as Envia , bdg2.nombre as Recibe , dru.cantidad as Kilogramos  from 
	reubicacion as ru inner join detalleReubicacion as dru on ru.idReubicacion = dru.idReubicacion
	left join usuarios as usr on ru.idUsuario = usr.idUsuario
	left join producto as pdr on dru.idProducto = pdr.idProducto 
	left join bodega as bdg1 on ru.idBodegaOrigen = bdg1.idBodega 
	left join bodega as bdg2 on ru.idBodegaDestino = bdg2.idBodega
	where ru.idReubicacion = @idReubicacion	
end

