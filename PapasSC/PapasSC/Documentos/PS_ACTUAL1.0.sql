--###############################################################################
--################INSERTAR NUEVO CLIENTE CON SU CONTACTO#########################
--###############################################################################

select * from cliente 
select * from contacto
select * from credito

execute  sp_insertar_nuevoCliente 'Pedro Marquez', 'XAXX010101000','','Moral',
'Pedro Zamora', 'M','5 de mayo 265',
'351-111-2233', 'PedroM@gmail.com','Michocan','Zamora','59752',10000.0,30

--delete from cliente where nombre like '%Pedro Marquez'\

create proc sp_insertar_nuevoCliente
--cliente
@nombreCliente varchar(80),
@RFC varchar(13),
@razonSocial varchar(100),
@tipoPersona varchar (10),
--contacto
@nombreContacto varchar(100),
@genero char(1),
@direccion varchar(100),
@telefono char(12),
@email varchar(100),
@estado varchar(50),
@municipio varchar(50),
@codigoPostal char(5),
--credito
@limiteCredito float,
@diasCredito int 
as 
declare @idCliente  varchar(36)
declare @idTipoPersona varchar(36)
declare @flag int
begin 
	select @idCliente = newid()
	select @idTipoPersona=idTipoCliente from tipoCliente where tipo = @tipoPersona  
	begin try 
		insert into cliente values (@idCliente, @nombreCliente , @RFC , @razonSocial , GETDATE(), @idTipoPersona)
		select @flag =  COUNT(*) from cliente where idCliente = @idCliente
	end try
	begin catch
		select @flag =  COUNT(*) from cliente where idCliente = @idCliente
	end catch
	if @flag > 0 
	begin
		begin try 
			insert into contacto values (NEWID(), @nombreContacto , @genero , @direccion , @telefono , @email , @estado , @municipio , @codigoPostal , @idCliente)
			insert into credito values (NEWID(), @limiteCredito , @diasCredito , @idCliente)
		end try 
		begin catch
			delete from cliente where idCliente = @idCliente
		end catch
	end
end




--########################################################################################
--################## METODOS PARA EL FILTRADO DE LA VENTANA DE INVENTARIO ################
--########################################################################################

create proc sp_invetario_bodega_clave_SExistencias
@bodega varchar(30),
@clave varchar (15)
as 
begin 
select pd.version , pd.clave , isnull(xp.cantidad,'0.00') as existencia from
existenciaProductos as xp left join bodega as  bd 
on xp.idBodega = bd.idBodega
right join producto as pd 
on xp.idProducto = pd.idProducto 
where bd.idBodega =(select idBodega from bodega where nombre=@bodega )  and pd.version like @clave 
end

--select pd.version , pd.clave , isnull(xp.cantidad,'0.00') as existencia from
--existenciaProductos as xp left join bodega as  bd 
--on xp.idBodega = bd.idBodega
--right join producto as pd 
--on xp.idProducto = pd.idProducto 
--where bd.nombre ='Bodega 1' and pd.version =  'Lavada segunda' 
--select * from producto
----listo
create proc sp_invetario_bodega_CExisitencia
@bodega varchar (30)
as 
begin
select pd.version , pd.clave , isnull(xp.cantidad,'0.00') as existencia from
existenciaProductos as xp left join bodega as  bd 
on xp.idBodega = bd.idBodega
right join producto as pd 
on xp.idProducto = pd.idProducto 
where bd.idBodega = (select idBodega from bodega where nombre=@bodega )  and xp.cantidad <> 0.0
end
--listo
create proc sp_invetario_bodega_SExisitencia
@bodega varchar (30)
as
begin 
select pd.version , pd.clave , isnull(xp.cantidad,'0.00') as existencia from
existenciaProductos as xp left join bodega as  bd 
on xp.idBodega = bd.idBodega
right join producto as pd 
on xp.idProducto = pd.idProducto 
where bd.idBodega = (select idBodega from bodega where nombre=@bodega ) 
end


create proc sp_invetario_clave_CExistencias
@clave as varchar(15)
as 
begin 
select pd.version , pd.clave , isnull(xp.cantidad,'0.00') as existencia from
existenciaProductos as xp left join bodega as  bd 
on xp.idBodega = bd.idBodega
right join producto as pd 
on xp.idProducto = pd.idProducto 
where pd.version like @clave and xp.cantidad <> 0.0
end

create proc sp_invetario_clave_sExistencias
@clave varchar (15)
as
begin 
select pd.version , pd.clave , isnull(xp.cantidad,'0.00') as existencia from
existenciaProductos as xp left join bodega as  bd 
on xp.idBodega = bd.idBodega
right join producto as pd 
on xp.idProducto = pd.idProducto 
where pd.version like @clave 
end
select * from usuarios
--#########################segundo metodo##########################################
--################ estos son para cuando inicia la interfaz de inventario########## 
create proc sp_selectMatriz
as
begin 
	select isnull( nombre , 'ND')as matriz
	from matriz
end
execute sp_selectBodega
create proc sp_selectBodega
as
begin 
	select ISNULL( nombre , 'ND') as bodega
	from bodega
end

create proc sp_selectTipoPapa
as
begin 
	select 
	isnull(version , 'ND') as producto
	from producto order by clave
end

--############### APLICA ESTO PARA CAMBIAR A NULL LA CLAVE DE PRODUCTO #############################
alter table producto
add clave varchar (10) not null

alter table producto
alter column version varchar(15)

--################################################################################################
--################################# ESTO ES PARA EL LOGIN ########################################

create proc sp_licencias_usuarios
@nombre varchar(20),
@contrasenia varchar (50)
as
begin 
	select top 1 tus.tipo, us.nombreUsuario, em.nombre from usuarios as us left join tipoUsuario as tus 
		on us.idTipoUsuario = tus.idTipoUsuario
		left join empleado as em 
		on em.idEmpleado = us.idEmpleado
		where nombreUsuario like  @nombre and contrasenia like @contrasenia
end

--###########################################################################################
--###################### PROCEDIMIENTOS MATRIZ ##############################################
--###########################################################################################

SELECT * FROM matriz
SELECT * FROM ciudad

alter table matriz
add estatus char(1)

update matriz set estatus = 'A'

create proc sp_select_Matriz
as
begin 
	
select mt.nombre as Matriz, mt.clave as Clave , cd.nombre as Ciudad
	 from matriz as mt left join  ciudad as cd  on mt.idCiudad = cd.idCiudad 
	 where mt.estatus = 'A'
end


--select mt.nombre as Matriz, mt.clave as Clave , cd.nombre as Ciudad
--	 from matriz as mt left join  ciudad as cd  on mt.idCiudad = cd.idCiudad 
--	 where mt.estatus = 'A'


create proc sp_select_Ciudad
as
begin 
	select nombre from ciudad where estatus like 'A' order by nombre asc
end

create proc sp_insertar_ciudad
@Nombre varchar(30)
as 
declare @error int 
begin 
	begin tran
		begin try 
			insert into ciudad values (newid(), @Nombre,'A')
			set @error = @@ERROR
		end try
		begin catch
			goto repararProblema
		end catch
	commit tran 
	repararProblema:
		if	@error <> 0
		begin 
			rollback tran
		end
end
select * from matriz

create proc sp_insertar_Matriz
@matriz varchar (50),
@clave varchar(36),
@ciudad varchar(50)
as 
declare @idCiudad  varchar (36)
declare @idMatriz varchar (36)
declare @error int 
begin 
	begin tran
		begin try	
			select @idCiudad = idCiudad from ciudad where nombre = @ciudad
			set @idMatriz = NEWID()
			insert into matriz values (@idMatriz,@matriz,@clave,@idCiudad,'A')
			set @error = @@ERROR
		end try
		begin catch
			goto repararproblema
		end catch
	commit tran

	repararproblema:
		if	@error <> 0
			begin 
				rollback tran
			end
end

select * from matriz

create proc sp_eliminar_Matriz
@matriz varchar (50),
@clave varchar(36),
@ciudad varchar(50)
as 
declare @idciudad varchar (36)
declare @error int 
begin 
	begin tran
		begin try	
			select @idciudad = idCiudad from ciudad where  nombre like CONCAT('%',@ciudad)
			update matriz set estatus = 'B' where nombre like CONCAT('%',@matriz) and @clave like CONCAT('%',@clave) and idCiudad = @idciudad
			set @error = @@ERROR
		end try
		begin catch
			goto repararproblema
		end catch
	commit tran

	repararproblema:
		if	@error <> 0
			begin 
				rollback tran
			end
end

--#############################################################################################
--#################### Procedimientos para datos de un usuarios ###############################
--#############################################################################################
execute sp_selectDatosUsuario 'admin'

create proc sp_selectDatosUsuario
@nombreUsuario varchar (20)
as 
declare @error int 
begin 
	begin tran
		begin try 
			select 
			 us.idUsuario , us.nombreUsuario, us.contrasenia ,tpus.tipo ,emp.nombre
			 from usuarios as us left join  empleado as emp on us.idEmpleado = emp.idEmpleado
			left join tipoUsuario as tpus on us.idTipoUsuario = tpus.idTipoUsuario
			where us.nombreUsuario like @nombreUsuario
		end try
		begin catch
			goto repararProblema
		end catch
	commit tran 
	repararProblema:
		if	@error <> 0
		begin 
			rollback tran
		end
end


--#####################################################################################################
--########################## Procedmiento para consultar usuarios #####################################
--#####################################################################################################

--execute sp_selectUsuarios
create proc sp_selectUsuarios 
as
begin 
	select nombreUsuario as Usuario, contrasenia as Contraseña , tpus.tipo , emp.nombre as NombreEmpleado
	from usuarios as us left join tipoUsuario as tpus on us.idTipoUsuario = tpus.idTipoUsuario 
	left join empleado as emp on us.idEmpleado = emp.idEmpleado
end

--#####################################################################################################
--########################## Procedmiento para insertar usuarios ######################################
--#####################################################################################################
create  proc sp_insertar_Usuario
@login  varchar(50),
@pass  varchar(50),
@tipoUsuario varchar(30),
@empleado varchar(80),
@estatus char(1)
as
declare @idUsuario  varchar(36)
declare @idTipoUsuario varchar (36)
declare @idEmpleado varchar(36)
declare @contador int
declare @error int
begin 
	set @contador = 0
	--Compruebo que no exista un usario asignado al mismo empleado 
	print 'comprobando usuarios'
	select @contador = count(*) from usuarios as usr left join empleado as emp on usr.idEmpleado  = emp.idEmpleado
	inner join tipoUsuario as tpus on usr.idTipoUsuario = tpus.idTipoUsuario 
	where usr.nombreUsuario like (@login) and emp.nombre like (CONCAT('%',@empleado))
	if @contador = 0 
	begin 
		--Compruebo que no exita un usuario con el mismo nombre
		select @contador = COUNT(*) from usuarios where nombreUsuario like(CONCAT('%',@login))
		if @contador = 0 
		begin
			print 'No existen usuarios con el mismo nombre'
			select @idEmpleado = idEmpleado from empleado where nombre = @empleado
			select @idTipoUsuario = idTipoUsuario from tipoUsuario where tipo = @tipoUsuario
			begin tran
				begin try
					set @idUsuario = NEWID()
					print concat('Usuario: ', @idUsuario, ' Emplado: ', @idEmpleado , ' TipoUsuario: ', @idTipoUsuario)
					insert into usuarios values(@idUsuario, @login , @pass , @idTipoUsuario , @idEmpleado,@estatus)	
					if @@ERROR <> 0
					begin 
						set @error = @@ERROR
					end
				end try
				begin catch
					goto solucionaProblema
				end catch
			commit tran 
			solucionaProblema:
				if @error <> 0 
				begin
					rollback tran
					print 'error'
				end
		end
	end	
end
--#####################################################################################################
--########################## Procedmiento para eliminar usuarios ######################################
--#####################################################################################################

create proc sp_eliminar_Usuario
@nombreUsuario as varchar(80),
@nombreEmpleado as varchar(80)
as 
declare @idUsuario varchar (36)
declare @idEmpleado varchar (36)
declare @error int
declare @cont int
begin 
	set @cont = 0
	select @cont = count (*) from usuarios left join empleado on usuarios.idEmpleado = empleado.idEmpleado 
	where usuarios.nombreUsuario like @nombreUsuario and empleado.nombre like @nombreEmpleado
	print CONCAT('Buscando Usuario ',@cont)
	if @cont > 0 
	begin 
		begin tran 
			begin try
				select @idEmpleado = idEmpleado from empleado where nombre like (CONCAT('%',@nombreEmpleado))
				print @idEmpleado
				select @idUsuario = idUsuario  from usuarios where nombreUsuario like (CONCAT('%',@nombreUsuario))
				print @idUsuario
				delete from usuarios where idEmpleado = @idEmpleado and idUsuario = @idUsuario
				if @@ERROR <> 0 
				begin 
					set @error = @@ERROR
					print 'Error al eliminar'
				end
			end try
			begin catch
				goto resolverProblema
			end catch
		commit tran 
		resolverProblema:
			if @error <> 0 
			begin 
				rollback tran
				print 'error'
			end
	end
end

--#####################################################################################################
--########################## Procedmiento para modificar usuarios #####################################
--#####################################################################################################

create  proc sp_modificar_Usuario
@loginN  varchar(50),
@passN  varchar(50),
@tipoUsuarioN varchar(30),
@empleadoN varchar(80),
@estatusN char(1),
@loginv  varchar(50),
@passv  varchar(50),
@tipoUsuariov varchar(30),
@empleadov varchar(80),
@estatusv char(1)
as
declare @error int 
declare @idEmpleadoN varchar(36)
declare @idEmpleadoV varchar(36)
declare @idTipoEmpleadoN varchar(36)
declare @idTipoEmpleadoV varchar(36)
declare @idUsuario varchar(36)
declare @cont int 
begin 
	--Obtenemos los datos necesarios para hacer el Update
	select @idUsuario = idUsuario from usuarios where nombreUsuario like (CONCAT('%',@loginv))
	select @idTipoEmpleadoN = idTipoUsuario from tipoUsuario where tipo like (@tipoUsuarioN)
	select @idTipoEmpleadoV = idTipoUsuario from tipoUsuario where tipo like (@tipoUsuarioV)
	select @idEmpleadoV  =  idEmpleado from empleado where nombre like (@empleadov)
	select @idEmpleadoN  =  idEmpleado from empleado where nombre like (@empleadoN)
	begin tran
		begin try 	
			select @cont = count(idUsuario) from usuarios where nombreUsuario like @loginv and idEmpleado = @idEmpleadoV
			if @cont = 1 --si solo existe un solo usuario si no es incorrecto cambiar 2 o mas usuario
			begin
				print 'entro2'
				update usuarios set nombreUsuario = @loginN , contrasenia = @passN , idTipoUsuario = @idTipoEmpleadoN , idEmpleado = @idEmpleadoN, estatus = @estatusN
				where nombreUsuario like @loginv and idEmpleado = @idEmpleadoV
				if @@ERROR <> 0
				begin 
					set @error = @@ERROR 
					print 'entro3'
				end
			end
		end try
		begin catch
			goto solucionarProblema
		end catch
	commit tran
	solucionarProblema:
		if	@error <> 0 
		begin 
			rollback tran
			print 'Error al actualizar'
		end
end

--#####################################################################################################
--############ Procedmiento seleccionar datos usuario y llenar la tabla ###############################
--#####################################################################################################

create proc sp_selectDatosUsuario
@nombreUsuario varchar (20)
as 
declare @error int 
begin 
	begin tran
		begin try 
			select 
			 us.idUsuario , us.nombreUsuario, us.contrasenia ,tpus.tipo ,emp.nombre , us.estatus
			 from usuarios as us left join  empleado as emp on us.idEmpleado = emp.idEmpleado
			left join tipoUsuario as tpus on us.idTipoUsuario = tpus.idTipoUsuario
			where us.nombreUsuario like @nombreUsuario
		end try
		begin catch
			goto repararProblema
		end catch
	commit tran 
	repararProblema:
		if	@error <> 0
		begin 
			rollback tran
		end
end

--#####################################################################################################
--######################## consultar usuarios para llenar un combo box ################################
--#####################################################################################################

execute sp_selectUsuarios

create proc sp_selectUsuarios
as
begin 
	select nombreUsuario as Usuario, contrasenia as Contraseña , tpus.tipo as Tipo , emp.nombre as NombreEmpleado ,
	case  
		when us.estatus = 'A' then 'Activo'
		when us.estatus = 'B' then 'Bloqueado'
	end as Estatus
	from usuarios as us left join tipoUsuario as tpus on us.idTipoUsuario = tpus.idTipoUsuario 
	left join empleado as emp on us.idEmpleado = emp.idEmpleado
end

--#####################################################################################################
--######################## consultar usuarios para busqueda por filtro ################################
--#####################################################################################################
execute sp_busqueda_usuario 'activo'

create proc sp_busqueda_usuario
@texto varchar(50)
as
begin 
	if @texto like CONCAT('%','bloqueado','%')
	begin 
		set	@texto = 'B'
			select us.nombreUsuario as Usuario, us.contrasenia as Contraseña, tpu.tipo as Tipo , em.nombre as NombreEmplado ,
		case  
			when us.estatus = 'A' then 'Activo'
			when us.estatus = 'B' then 'Bloqueado'
		end as Estatus
		from usuarios as us left join empleado as em on us.idEmpleado = em.idEmpleado
		inner join tipoUsuario as tpu on us.idTipoUsuario = tpu.idTipoUsuario
		where  us.estatus like 'B'
	end
	else if @texto like CONCAT('%','Activo','%')
	begin 
		set	@texto = 'A'
		select us.nombreUsuario as Usuario, us.contrasenia as Contraseña, tpu.tipo as Tipo , em.nombre as NombreEmplado ,
		case  
			when us.estatus = 'A' then 'Activo'
			when us.estatus = 'B' then 'Bloqueado'
		end as Estatus
		from usuarios as us left join empleado as em on us.idEmpleado = em.idEmpleado
		inner join tipoUsuario as tpu on us.idTipoUsuario = tpu.idTipoUsuario
		where us.estatus like 'A'
	end
	else 
	begin
		select us.nombreUsuario as Usuario, us.contrasenia as Contraseña, tpu.tipo as Tipo , em.nombre as NombreEmplado ,
		case  
			when us.estatus = 'A' then 'Activo'
			when us.estatus = 'B' then 'Bloqueado'
		end as Estatus
		from usuarios as us left join empleado as em on us.idEmpleado = em.idEmpleado
		inner join tipoUsuario as tpu on us.idTipoUsuario = tpu.idTipoUsuario
		where tpu.tipo like (CONCAT('%',@texto,'%')) or us.nombreUsuario like (CONCAT('%',@texto,'%'))	or em.nombre like (CONCAT('%',@texto,'%')) or us.estatus like (@texto) 	
	end
	--usuario, contrasenia , tipo, nombre empleado
	
end


--############################# estos son los tipos #################################################
--############################# de usuario basicos  #################################################
select * from usuarios
select * from tipoUsuario
insert into tipoUsuario values(NEWID(),'Administracion'),(NEWID(),'Operador'),(NEWID(),'Venta')
select * from empleado
update usuarios set estatus = 'A'
select nombre from empleado where estatus = 'A'
--############################# cambio en la tabla de usuario #################################################
--############################# solo se agrego el campo de status #############################################

alter table usuarios
add estatus char (1)

