----------------------------------------------------------------Proveedores--------------------------------------------------------------------


---------------------------------------------------------------Modificacion de las tablas proveedores------------------------------------------


--------Eliminar columnas de proveedor-----------------------
alter table proveedores drop column  telefono
alter table proveedores drop column  email

-----------Agregar columnas a la tabla de proveedor------------
alter table proveedores add rfc varchar(13) 

alter table proveedores add razonSocial varchar(100) 

alter table proveedores
add constraint fk_idTipoCliente_Proveedor
foreign key (idTipoCliente)
references tipoCliente(idTipoCliente)

alter table proveedores add fechaRegistro date

select fechaRegistro from proveedores 

------------------creacion tabla contacto proveedores------------------------

create table conctatoProveedor(
	idContactoProveedor varchar(36) primary key not null,
	nombre varchar(100) not null,
	genero char not null,
	direccion varchar(100),
	direccion2 varchar(100),
	telefono char(12),
	telefono2 char(12),
	email varchar(100),
	email2 varchar(100),
	estado varchar(50),
	municipio varchar(50),
	codigoPostal char(5),
	idProveedor varchar(36) 
)

alter table conctatoProveedor
add  constraint fk_idProveedor_ContactoProveedor1
foreign key (idProveedor)
references proveedores(idProveedor)


-----------------------Modificacion tabla credito---------------------
alter table credito
add saldo float null


---------------------------------------------Insertar un proveedor---------------------------------------------

create procedure sp_Insertar_ProveedorNuevo
@nombre varchar(80),
@rfc varchar(13),
@razonSocial varchar(100),
@nombreCiu varchar(30),
@estatus char,
@TipoPer varchar(10),

@NomContacto varchar(100),
@genero char,
@direccion varchar(100),
@direccion2 varchar(100),
@telefono varchar(12),
@telefono2 varchar(12),
@email varchar(100),
@email2 varchar(100),
@estado varchar(50),
@municipio varchar(50),
@codigoPostal char(5)
as
declare @idProveedor varchar(36)
declare @idCiudad varchar(36)
declare @idtipoPersona varchar(36)
declare @flag int
   begin 
	begin tran 
		begin try
			select @idProveedor = NEWID ()
			select @idCiudad=idCiudad from ciudad where nombre = @nombreCiu 
			select @idtipoPersona = idTipoCliente  from tipoCliente where tipo = @TipoPer 
			insert into proveedores values (@idProveedor,@nombre,@idCiudad,@estatus,@rfc,@razonSocial,@idtipoPersona,GETDATE())
			if @@ERROR <> 0 begin set @flag = @@ERROR end 
			insert into conctatoProveedor  values (NEWID (),@NomContacto,@genero,@direccion,@direccion2,@telefono,@telefono2,@email,
			@email2,@estado,@municipio,@codigoPostal,@idProveedor)
			if @@ERROR <> 0 begin set @flag = @@ERROR end 
		end try
		begin catch
			goto solucionarproblema
		end catch
	commit tran
	solucionarproblema:
		if @flag <> 0
		begin 
			rollback tran
			print 'ERROR'
		end
	end


------------------------------------------------------Actualizar un proveedor---------------------------------------------

create procedure sp_Actualizar_ProveedorNuevo
@nombre varchar(80),
@rfc varchar(13),
@razonSocial varchar(100),
@nombreCiu varchar(30),
@estatus char,
@TipoPer varchar(10),

@NomContacto varchar(100),
@genero char,
@direccion varchar(100),
@telefono varchar(12),
@email varchar(100),
@direccion2 varchar(100),
@telefono2 varchar(12),
@email2 varchar(100),
@estado varchar(50),
@municipio varchar(50),
@codigoPostal char(5),
@nombreCiuN varchar(30)
as
declare @idCiudad varchar(36)
declare @idCiudadV varchar(36)
declare @idtipoPersona varchar(36)
declare @idProveedor varchar(36)
declare @error int
	begin 
	begin tran 
		select @idTipoPersona=idTipoCliente from tipoCliente where tipo = @tipoPer  
		begin try 
			select  @idCiudadV=idCiudad from ciudad where nombre=@nombreCiu  and estatus='A'
			select @idciudad=idCiudad from ciudad where nombre=@nombreCiuN  and estatus='A'
			select @idProveedor=idProveedor from proveedores where nombre like (@nombre)
			update proveedores set idProveedor =  @idProveedor,nombre = @nombre ,idCiudad=@idCiudad, estatus = @estatus,rfc = @rfc,razonSocial = @razonSocial ,idTipoCliente= @idTipoPersona where idProveedor  = @idProveedor 
			set @error = @@ERROR
		end try
		begin catch
			goto SolucionarError 
		end catch
	if @error <> 0	goto SolucionarError
		else 
		begin
			begin try 
				update conctatoProveedor set nombre = @NomContacto  ,genero=  @genero ,direccion= @direccion , telefono = @telefono , email = @email ,direccion2 = @direccion2,telefono2 = @telefono2 ,email2 = @email2,estado = @estado ,municipio = @municipio ,codigoPostal = @codigoPostal where idProveedor  = @idProveedor 
				set @error =@@ERROR
			end try 
			begin catch
				goto SolucionarError
			end catch
		end
commit tran
	SolucionarError: 
		if	@@ERROR<>0 
		begin 
			rollback tran
			
		end
end


-----------------------------------------------------Filtros de proveedores--------------------------------------------------------------


create procedure sp_Consultar_Proveedores
as
select p.nombre as Nombre,  c.nombre as Alias, p.rfc as RFC, p.razonSocial as RazónSocial,t.tipo as Tipo, c.genero as Sexo, 
c.direccion as Dirección, 
c.telefono as Teléfono,c.email as Email, 
c.direccion2 as Dirección2,c.telefono2 as Teléfono2, c.email2 as EmailAlternativo, ci.nombre as OrigenMatriz,c.estado as Estado,c.municipio as Municipio,
c.codigoPostal as CodigoPostal from proveedores p inner join
conctatoProveedor c on p.idProveedor = c.idProveedor inner join  tipoCliente t on p.idTipoCliente  = t.idTipoCliente  inner join ciudad ci on 
ci.idCiudad = p.idCiudad where  p.estatus='A'

execute sp_Consultar_Proveedores 

---------------------------------------------------------------------------------------------------------------------------------------------------------
create procedure sp_Consultar_ProveedoresTodos
as
select p.nombre as Nombre,  c.nombre as Alias, p.rfc as RFC, p.razonSocial as RazónSocial,t.tipo as Tipo, c.genero as Sexo, 
c.direccion as Dirección, 
c.telefono as Teléfono,c.email as Email, 
c.direccion2 as Dirección2,c.telefono2 as Teléfono2, c.email2 as EmailAlternativo, p.estatus as Estatus, ci.nombre as OrigenMatriz,c.estado as Estado,c.municipio as Municipio,
c.codigoPostal as CodigoPostal from proveedores p inner join
conctatoProveedor c on p.idProveedor = c.idProveedor inner join  tipoCliente t on p.idTipoCliente  = t.idTipoCliente  inner join ciudad ci on 
ci.idCiudad = p.idCiudad 

execute sp_Consultar_ProveedoresTodos 

select * from proveedores 

----------------------------------------------------------------------------------------------------------------------------------------------------------

create procedure sp_BuscarOrigenCiudad
@nombreCiu varchar(50)
as
select p.nombre as Nombre,  c.nombre as Alias, p.rfc as RFC, p.razonSocial as RazónSocial,t.tipo as Tipo, c.genero as Sexo, 
c.direccion as Dirección, 
c.telefono as Teléfono,c.email as Email, 
c.direccion2 as Dirección2,c.telefono2 as Teléfono2, c.email2 as EmailAlternativo, ci.nombre as OrigenMatriz,c.estado as Estado,c.municipio as Municipio,
c.codigoPostal as CodigoPostal from proveedores p inner join
conctatoProveedor c on p.idProveedor = c.idProveedor inner join  tipoCliente t on p.idTipoCliente  = t.idTipoCliente  inner join ciudad ci on 
ci.idCiudad = p.idCiudad where ci.nombre like '%'+@nombreCiu+'%'   and   p.estatus='A' 

execute sp_BuscarOrigenCiudad 'za'

----------------------------------------------------------------------------------------------------------------------------------------------------------

create procedure sp_BucarProveedor
@nombrePro varchar(50)
as
select p.nombre as Nombre,  c.nombre as Alias, p.rfc as RFC, p.razonSocial as RazónSocial,t.tipo as Tipo, c.genero as Sexo, 
c.direccion as Dirección, 
c.telefono as Teléfono,c.email as Email, 
c.direccion2 as Dirección2,c.telefono2 as Teléfono2, c.email2 as EmailAlternativo, ci.nombre as OrigenMatriz,c.estado as Estado,c.municipio as Municipio,
c.codigoPostal as CodigoPostal from proveedores p inner join
conctatoProveedor c on p.idProveedor = c.idProveedor inner join  tipoCliente t on p.idTipoCliente  = t.idTipoCliente  inner join ciudad ci on 
ci.idCiudad = p.idCiudad where p.nombre like '%'+@nombrePro+'%'   and   p.estatus='A' 

execute sp_BucarProveedor 'Lu'

-----------------------------------------------------------------------------------------------------------------------------------------------------------
create procedure Buscar_TipoCliente_Empleado
@TipoPersona varchar(10)
as
select p.nombre as Nombre,  c.nombre as Alias, p.rfc as RFC, p.razonSocial as RazónSocial,t.tipo as Tipo, c.genero as Sexo, 
c.direccion as Dirección, 
c.telefono as Teléfono,c.email as Email, 
c.direccion2 as Dirección2,c.telefono2 as Teléfono2, c.email2 as EmailAlternativo, ci.nombre as OrigenMatriz,c.estado as Estado,c.municipio as Municipio,
c.codigoPostal as CodigoPostal from proveedores p inner join
conctatoProveedor c on p.idProveedor = c.idProveedor inner join  tipoCliente t on p.idTipoCliente  = t.idTipoCliente  inner join ciudad ci on 
ci.idCiudad = p.idCiudad where t.tipo like '%'+@TipoPersona+'%'   and   p.estatus='A' 

exec Buscar_TipoCliente_Empleado 'M'

----------------------------------------------------------------------------------------------------------------------------------------------------------
create procedure Buscar_RazonSocial_Empleado
@Rasocial varchar(10)
as
select p.nombre as Nombre,  c.nombre as Alias, p.rfc as RFC, p.razonSocial as RazónSocial,t.tipo as Tipo, c.genero as Sexo, 
c.direccion as Dirección, 
c.telefono as Teléfono,c.email as Email, 
c.direccion2 as Dirección2,c.telefono2 as Teléfono2, c.email2 as EmailAlternativo, ci.nombre as OrigenMatriz,c.estado as Estado,c.municipio as Municipio,
c.codigoPostal as CodigoPostal from proveedores p inner join
conctatoProveedor c on p.idProveedor = c.idProveedor inner join  tipoCliente t on p.idTipoCliente  = t.idTipoCliente  inner join ciudad ci on 
ci.idCiudad = p.idCiudad where p.razonSocial  like '%'+@Rasocial+'%'   and   p.estatus='A' 

exec Buscar_RazonSocial_Empleado ''

---------------------------------------------------------------------------------------------------------------------------------------------------------

create procedure Buscar_AliasContacto_Empleado
@AliasCont varchar(10)
as
select p.nombre as Nombre,  c.nombre as Alias, p.rfc as RFC, p.razonSocial as RazónSocial,t.tipo as Tipo, c.genero as Sexo, 
c.direccion as Dirección, 
c.telefono as Teléfono,c.email as Email, 
c.direccion2 as Dirección2,c.telefono2 as Teléfono2, c.email2 as EmailAlternativo, ci.nombre as OrigenMatriz,c.estado as Estado,c.municipio as Municipio,
c.codigoPostal as CodigoPostal from proveedores p inner join
conctatoProveedor c on p.idProveedor = c.idProveedor inner join  tipoCliente t on p.idTipoCliente  = t.idTipoCliente  inner join ciudad ci on 
ci.idCiudad = p.idCiudad where c.nombre   like '%'+@AliasCont +'%'   and   p.estatus='A' 


exec Buscar_AliasContacto_Empleado ''

------------------------------------------------------------------------------------------------------------------------------------------------------------

create procedure Buscar_RFC_Empleado
@rfc varchar(10)
as
select p.nombre as Nombre,  c.nombre as Alias, p.rfc as RFC, p.razonSocial as RazónSocial,t.tipo as Tipo, c.genero as Sexo, 
c.direccion as Dirección, 
c.telefono as Teléfono,c.email as Email, 
c.direccion2 as Dirección2,c.telefono2 as Teléfono2, c.email2 as EmailAlternativo, ci.nombre as OrigenMatriz,c.estado as Estado,c.municipio as Municipio,
c.codigoPostal as CodigoPostal from proveedores p inner join
conctatoProveedor c on p.idProveedor = c.idProveedor inner join  tipoCliente t on p.idTipoCliente  = t.idTipoCliente  inner join ciudad ci on 
ci.idCiudad = p.idCiudad where p.rfc  like '%'+@rfc+'%'   and   p.estatus='A' 

exec Buscar_RFC_Empleado ''

-------------------------------------------------------------------------------------------------------------------------------------------------------------

--------------------------------------------------------------Eliminar un proveedor--------------------------------------------------------------------------

create procedure sp_Eliminar_Proveedor3
@nombre varchar(80),
@rfc varchar(13),
@razonSocial varchar(100),
@nombreCiu varchar(30),
@TipoPer varchar(10),

@NomContacto varchar(100),
@genero char,
@direccion varchar(100),
@telefono varchar(12),
@email varchar(100),
@direccion2 varchar(100),
@telefono2 varchar(12),
@email2 varchar(100),
@estado varchar(50),
@municipio varchar(50),
@codigoPostal char(5)
as
declare @idproveedor varchar(36)
declare @idciudad varchar(36)
declare @idtipoPersona varchar(36)
declare @error int 
begin 
	begin tran 
		begin try 
			select @idciudad= idCiudad from ciudad where nombre like CONCAT('%',@NombreCiu)
			select @idtipoPersona = idTipoCliente  from tipoCliente where tipo like   CONCAT('%',@TipoPer )
			update proveedores set estatus='B' where nombre like CONCAT('%',@nombre) and idCiudad= @idciudad and @rfc like CONCAT('%',@rfc) and 
			@razonSocial  like CONCAT('%',@razonSocial )  and idTipoCliente =@idtipoPersona and idProveedor = @idproveedor 
			select @idproveedor  = idproveedor  from conctatoProveedor  where nombre like (CONCAT('%',@NomContacto ))
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
