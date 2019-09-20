----------------------------------------------------------------PROVEEDORES--------------------------------------------------------------------


---------------------------------------------------------------Modificacion de las tablas proveedores------------------------------------------


--------Eliminar columnas de proveedor-----------------------
alter table proveedores drop column  telefono
alter table proveedores drop column  email

-----------Agregar columnas a la tabla de proveedor------------
alter table proveedores add estatus char(1) 
alter table proveedores add rfc varchar(13) 
alter table proveedores add razonSocial varchar(100) 
alter table proveedores add idTipoCliente varchar (36)
alter table proveedores add fechaRegistro date

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

-----------------------Consultar proveedores---------------------------

create procedure sp_Consultar_Proveedores
as
begin 
select p.nombre as Nombre,  c.nombre as Alias, p.rfc as RFC, p.razonSocial as RazónSocial,t.tipo as Tipo, c.genero as Sexo, 
c.direccion as Dirección, 
c.telefono as Teléfono,c.email as Email, 
c.direccion2 as Dirección2,c.telefono2 as Teléfono2, c.email2 as EmailAlternativo, ci.nombre as OrigenMatriz,c.estado as Estado,c.municipio as Municipio,
c.codigoPostal as CodigoPostal from proveedores p inner join
conctatoProveedor c on p.idProveedor = c.idProveedor inner join  tipoCliente t on p.idTipoCliente  = t.idTipoCliente  inner join ciudad ci on 
ci.idCiudad = p.idCiudad where  p.estatus='A'
end

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
			insert into proveedores values (@idProveedor,@nombre,@idCiudad,@estatus,@rfc,@razonSocial,@idtipoPersona,GETDATE())--
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
begin 
select p.nombre as Nombre,  c.nombre as Alias, p.rfc as RFC, p.razonSocial as RazónSocial,t.tipo as Tipo, c.genero as Sexo, 
c.direccion as Dirección, 
c.telefono as Teléfono,c.email as Email, 
c.direccion2 as Dirección2,c.telefono2 as Teléfono2, c.email2 as EmailAlternativo, ci.nombre as OrigenMatriz,c.estado as Estado,c.municipio as Municipio,
c.codigoPostal as CodigoPostal from proveedores p inner join
conctatoProveedor c on p.idProveedor = c.idProveedor inner join  tipoCliente t on p.idTipoCliente  = t.idTipoCliente  inner join ciudad ci on 
ci.idCiudad = p.idCiudad where  p.estatus='A'
end
execute sp_Consultar_Proveedores 

---------------------------------------------------------------------------------------------------------------------------------------------------------
create procedure sp_Consultar_ProveedoresTodos
as
begin 
select p.nombre as Nombre,  c.nombre as Alias, p.rfc as RFC, p.razonSocial as RazónSocial,t.tipo as Tipo, c.genero as Sexo, 
c.direccion as Dirección, 
c.telefono as Teléfono,c.email as Email, 
c.direccion2 as Dirección2,c.telefono2 as Teléfono2, c.email2 as EmailAlternativo, p.estatus as Estatus, ci.nombre as OrigenMatriz,c.estado as Estado,c.municipio as Municipio,
c.codigoPostal as CodigoPostal from proveedores p inner join
conctatoProveedor c on p.idProveedor = c.idProveedor inner join  tipoCliente t on p.idTipoCliente  = t.idTipoCliente  inner join ciudad ci on 
ci.idCiudad = p.idCiudad 
end
execute sp_Consultar_ProveedoresTodos 

select * from proveedores 

----------------------------------------------------------------------------------------------------------------------------------------------------------

create procedure sp_BuscarOrigenCiudad
@nombreCiu varchar(50)
as
begin
select p.nombre as Nombre,  c.nombre as Alias, p.rfc as RFC, p.razonSocial as RazónSocial,t.tipo as Tipo, c.genero as Sexo, 
c.direccion as Dirección, 
c.telefono as Teléfono,c.email as Email, 
c.direccion2 as Dirección2,c.telefono2 as Teléfono2, c.email2 as EmailAlternativo, ci.nombre as OrigenMatriz,c.estado as Estado,c.municipio as Municipio,
c.codigoPostal as CodigoPostal from proveedores p inner join
conctatoProveedor c on p.idProveedor = c.idProveedor inner join  tipoCliente t on p.idTipoCliente  = t.idTipoCliente  inner join ciudad ci on 
ci.idCiudad = p.idCiudad where ci.nombre like '%'+@nombreCiu+'%'   and   p.estatus='A' 
end
execute sp_BuscarOrigenCiudad 'za'

----------------------------------------------------------------------------------------------------------------------------------------------------------

create procedure sp_BucarProveedor
@nombrePro varchar(50)
as
begin
select p.nombre as Nombre,  c.nombre as Alias, p.rfc as RFC, p.razonSocial as RazónSocial,t.tipo as Tipo, c.genero as Sexo, 
c.direccion as Dirección, 
c.telefono as Teléfono,c.email as Email, 
c.direccion2 as Dirección2,c.telefono2 as Teléfono2, c.email2 as EmailAlternativo, ci.nombre as OrigenMatriz,c.estado as Estado,c.municipio as Municipio,
c.codigoPostal as CodigoPostal from proveedores p inner join
conctatoProveedor c on p.idProveedor = c.idProveedor inner join  tipoCliente t on p.idTipoCliente  = t.idTipoCliente  inner join ciudad ci on 
ci.idCiudad = p.idCiudad where p.nombre like '%'+@nombrePro+'%'   and   p.estatus='A' 
end

execute sp_BucarProveedor 'Lu'

-----------------------------------------------------------------------------------------------------------------------------------------------------------
create procedure Buscar_TipoCliente_Empleado
@TipoPersona varchar(10)
as
begin 
select p.nombre as Nombre,  c.nombre as Alias, p.rfc as RFC, p.razonSocial as RazónSocial,t.tipo as Tipo, c.genero as Sexo, 
c.direccion as Dirección, 
c.telefono as Teléfono,c.email as Email, 
c.direccion2 as Dirección2,c.telefono2 as Teléfono2, c.email2 as EmailAlternativo, ci.nombre as OrigenMatriz,c.estado as Estado,c.municipio as Municipio,
c.codigoPostal as CodigoPostal from proveedores p inner join
conctatoProveedor c on p.idProveedor = c.idProveedor inner join  tipoCliente t on p.idTipoCliente  = t.idTipoCliente  inner join ciudad ci on 
ci.idCiudad = p.idCiudad where t.tipo like '%'+@TipoPersona+'%'   and   p.estatus='A' 
end
exec Buscar_TipoCliente_Empleado 'M'

----------------------------------------------------------------------------------------------------------------------------------------------------------
create procedure Buscar_RazonSocial_Empleado
@Rasocial varchar(10)
as
begin
select p.nombre as Nombre,  c.nombre as Alias, p.rfc as RFC, p.razonSocial as RazónSocial,t.tipo as Tipo, c.genero as Sexo, 
c.direccion as Dirección, 
c.telefono as Teléfono,c.email as Email, 
c.direccion2 as Dirección2,c.telefono2 as Teléfono2, c.email2 as EmailAlternativo, ci.nombre as OrigenMatriz,c.estado as Estado,c.municipio as Municipio,
c.codigoPostal as CodigoPostal from proveedores p inner join
conctatoProveedor c on p.idProveedor = c.idProveedor inner join  tipoCliente t on p.idTipoCliente  = t.idTipoCliente  inner join ciudad ci on 
ci.idCiudad = p.idCiudad where p.razonSocial  like '%'+@Rasocial+'%'   and   p.estatus='A' 
end
exec Buscar_RazonSocial_Empleado ''

---------------------------------------------------------------------------------------------------------------------------------------------------------

create procedure Buscar_AliasContacto_Empleado
@AliasCont varchar(10)
as
begin
select p.nombre as Nombre,  c.nombre as Alias, p.rfc as RFC, p.razonSocial as RazónSocial,t.tipo as Tipo, c.genero as Sexo, 
c.direccion as Dirección, 
c.telefono as Teléfono,c.email as Email, 
c.direccion2 as Dirección2,c.telefono2 as Teléfono2, c.email2 as EmailAlternativo, ci.nombre as OrigenMatriz,c.estado as Estado,c.municipio as Municipio,
c.codigoPostal as CodigoPostal from proveedores p inner join
conctatoProveedor c on p.idProveedor = c.idProveedor inner join  tipoCliente t on p.idTipoCliente  = t.idTipoCliente  inner join ciudad ci on 
ci.idCiudad = p.idCiudad where c.nombre   like '%'+@AliasCont +'%'   and   p.estatus='A' 
end

exec Buscar_AliasContacto_Empleado ''

------------------------------------------------------------------------------------------------------------------------------------------------------------

create procedure Buscar_RFC_Empleado
@rfc varchar(10)
as
begin 
select p.nombre as Nombre,  c.nombre as Alias, p.rfc as RFC, p.razonSocial as RazónSocial,t.tipo as Tipo, c.genero as Sexo, 
c.direccion as Dirección, 
c.telefono as Teléfono,c.email as Email, 
c.direccion2 as Dirección2,c.telefono2 as Teléfono2, c.email2 as EmailAlternativo, ci.nombre as OrigenMatriz,c.estado as Estado,c.municipio as Municipio,
c.codigoPostal as CodigoPostal from proveedores p inner join
conctatoProveedor c on p.idProveedor = c.idProveedor inner join  tipoCliente t on p.idTipoCliente  = t.idTipoCliente  inner join ciudad ci on 
ci.idCiudad = p.idCiudad where p.rfc  like '%'+@rfc+'%'   and   p.estatus='A' 
end

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






------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

---------------------------------------------------EMPLEADOS--------------------------------------------------------------------------------------------

---agregar los campos de nombre y descripcion a la tabla horario------
alter table horario 
add nombre varchar(30), descripcion varchar(200)


---------------------------------------------------Filtros-----------------------------------------------------------------------------------------------

create procedure sp_Consultar_Empleado
as
select e.nombre as Nombre, e.sexo as Sexo,e.salario as Salario,e.telefono as Telefono,e.direccion as Direccion,
b.nombre as Bodega,h.nombre as Horario,p.nombre as Puesto from empleado e left join bodega b on e.idBodega=b.idBodega
inner join horario h on e.idHorario=h.idHorario inner join puesto p on e.idPuesto=p.idPuesto where e.estatus = 'A'


----------------------------------------------------------------------------------------------------------------------------------------------------------

create procedure sp_Bus_Empleado
@nombreEm varchar(50)
as
select e.nombre as Nombre, e.sexo as Sexo,e.salario as Salario,e.telefono as Telefono,e.direccion as Direccion, 
b.nombre as Bodega, h.nombre as Horario, p.nombre as Puesto from empleado e inner join bodega b on e.idBodega=b.idBodega 
inner join puesto p on e.idPuesto=p.idPuesto inner join horario h on e.idHorario=h.idHorario  where e.nombre like '%'+@nombreEm+'%' and e.estatus= 'A'

-------------------------------------------------------------------------------------------------------------------------------------------------------------

create procedure sp_BuscarBodega_Empleado
@nombreBo varchar(50)
as
select e.nombre as Nombre, e.sexo as Sexo,e.salario as Salario,e.telefono as Telefono,e.direccion as Direccion, 
b.nombre as Bodega, h.nombre as Horario,p.nombre as Puesto from empleado e inner join bodega b on e.idBodega=b.idBodega 
inner join puesto p on e.idPuesto=p.idPuesto inner join horario h on e.idHorario=h.idHorario  where b.nombre like '%'+@nombreBo+'%'
and e.estatus='A'

------------------------------------------------------------------------------------------------------------------------------------------------------------

create procedure sp_BuscarPuesto_Empleado
@nombrePu varchar(50)
as
select e.nombre as Nombre, e.sexo as Sexo,e.salario as Salario,e.telefono as Telefono,e.direccion as Direccion, 
b.nombre as Bodega,h.nombre as Horario,p.nombre as Puesto from empleado e inner join bodega b on e.idBodega=b.idBodega 
inner join puesto p on e.idPuesto=p.idPuesto inner join horario h on e.idHorario=h.idHorario  where p.nombre like '%'+@nombrePu+'%'
and e.estatus='A'


-----------------------------------------------------------------------------------------------------------------------------------------------------------

declare @sal float
set @sal = 200
execute sp_Bus_Empleado4 @sal

create procedure sp_Bus_Empleado4
@Salario float
as
select e.nombre as Nombre, e.sexo as Sexo,e.salario as Salario,e.telefono as Telefono,e.direccion as Direccion, 
b.nombre as Bodega,h.nombre as Horario, p.nombre as Puesto from empleado e inner join bodega b on e.idBodega=b.idBodega 
inner join puesto p on e.idPuesto=p.idPuesto inner join horario h on e.idHorario=h.idHorario  
where e.salario like CONCAT(@Salario,'%') and e.estatus ='A'

------------------------------------------------------------------------------------------------------------------------------------------------------------

------------------------------------------------------------------------------------------------------------------------------------------------------------
create procedure sp_Sele_Bodega
as
begin
  select nombre from bodega where estatus like 'A' order by nombre asc
end

execute sp_Sele_Bodega

----------------------------------------------------------------------------------------------
create procedure sp_Sele_Horario
as
begin
  select nombre from horario order by nombre asc
end

execute sp_Sele_Horario

----------------------------------------------------------------------------------------------
create proc sp_select_Puesto
as
begin 
	select nombre from puesto where estatus like 'A' order by nombre asc
end

execute sp_select_CiudadEmple


--------------------------------------------------------------------------------------------------------------------------------------------------------------
create proc sp_select_CiudadPro
as
begin 
	select nombre from ciudad where estatus like 'A' order by nombre asc
end
execute sp_select_CiudadPro

--------------------------------------------------------------------------------------------------------------------------------------------------------------

create procedure sp_Insertar_Empleado
@nombre varchar(80),
@sexo char,
@salario float,
@telefono char(12),
@direccion varchar(100),
@estatus char,
@NomBodega varchar(30),
@EnSaHorario varchar(30),
@NomPuesto varchar(80)
as
declare @idEmpleado varchar(36)
declare @idBodega varchar(36)
declare @idHorario varchar(36)
declare @idPuesto varchar(36)
declare @error int
begin
	begin tran
		begin try
			select @idBodega= idBodega from bodega where nombre=@NomBodega
			select @idHorario= idHorario from horario where nombre=@EnSaHorario  
			select @idPuesto =idPuesto from puesto where nombre=@NomPuesto 
			set @idEmpleado = NEWID()
			insert into empleado values(@idEmpleado,@nombre,@sexo,@salario,@telefono,@direccion,@estatus,@idBodega,@idHorario,@idPuesto)
			select @error=@@ERROR 
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
		 
execute sp_Insertar_Empleado 'Manolo','M',2000,'123-456-7890','Benito Juarez #14','A','Bod Zamora','Vespertino','Cargador'

 ---------------------------------------------------------------------------------------------------------------------------------------------------------


 create procedure sp_EliminarEmple
@nombre varchar(80),
@sexo char,
@salario float,
@tel char(12),
@direccion varchar(100),
@NomBodega varchar(30),
@EnSaHorario varchar(30),
@NomPuesto varchar(80)
as
declare @idBodega varchar(36)
declare @idHorario varchar(36)
declare @idPuesto varchar(36)
declare @error int

begin 
	begin tran 
		begin try
			select @idBodega= idBodega from bodega where nombre like CONCAT('%',@NomBodega)
			select @idHorario= idHorario from horario where nombre like CONCAT('%',@EnSaHorario)
			select @idPuesto =idPuesto from puesto where nombre like CONCAT('%',@NomPuesto)
			update empleado set estatus='B' where nombre like CONCAT('%',@nombre) and @tel like CONCAT('%',@tel)
			and @direccion like CONCAT('%',@direccion) and idBodega=@idBodega and idHorario=@idHorario and idPuesto=@idPuesto 
			set @error=@@ERROR
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


-------------------------------------------------------------------------------------------------------------------------------------------------------------

create procedure sp_Actualizar_EmpleadoNuevo
@nombre varchar(80),
@sexo char,
@salario float,
@tel char(12),
@direccion varchar(100),
@estatus char,
@NomBodega varchar(30),
@EnSaHorario varchar(30),
@NomPuesto varchar(80),
@NomBodegaN varchar(30),
@EnSaHorarioN varchar(30),
@NomPuestoN varchar(80)
as
declare @idEmpleado varchar(36)
declare @idBodegaV varchar(36)
declare @idBodegaN varchar(36)
declare @idHorarioV varchar(36)
declare @idHorarioN varchar(36)
declare @idPuestoV varchar(36)
declare @idPuestoN varchar(36)
declare @error int
begin
	begin tran 
		begin try 
			select  @idBodegaV =idBodega from bodega  where nombre=@NomBodega  and estatus='A'
			select @idBodegaN=idBodega from bodega  where nombre=@NomBodegaN  and estatus='A'
			select @idHorarioV = idhorario from horario where nombre = @EnSaHorario 
			select @idHorarioN = idhorario from horario where nombre = @EnSaHorarioN 
			select @idPuestoV = idPuesto from puesto where nombre = @NomPuesto and estatus='A'
			select @idPuestoN = idPuesto from puesto where nombre = @NomPuestoN and estatus='A'
			select @idEmpleado= idEmpleado from empleado  where nombre like (@nombre) 
			update empleado set salario=@salario, telefono=@tel, direccion=@direccion, estatus= @estatus,idBodega=@idBodegaN, idHorario=@idHorarioN, idPuesto=@idPuestoN where idEmpleado= @idEmpleado 
		if @@ERROR <> 0 
			begin
				set @error=@@ERROR 
			end
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

execute sp_Actualizar_EmpleadoNuevo 'Martha','F',600,'351-555-5555','Jorge Chavolla #36','A','Bodega 1','Vespertino','Cargador','Bodega 1','Vespertino','Cajero'

--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------



