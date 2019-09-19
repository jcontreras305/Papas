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

--##########################################################################################
--######################## consultas y cambios para cajas ##################################
--##########################################################################################


select * from venta
select * from ventaDetalle
select * from bodega 
select * from existenciaProductos
select * from caja
select * from corteCaja

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
	fechaInicio float,
	fechaFin float,
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
