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