--cambio de la tabla clientes, contacto y credito
delete from cliente
delete from contacto
delete from credito

select * from cliente
select * from contacto
select * from credito

alter table cliente 
drop column idCredito

alter table cliente 
drop column idContacto

alter table cliente
drop constraint fk_idCredito

alter table cliente
drop constraint fk_idContacto

alter table contacto
add idCliente varchar(36)

alter table contacto
add constraint fk_idCliente_Contacto
foreign key (idCliente)
references cliente(idCliente)

alter table credito
add idCliente varchar (36)

alter table credito
add constraint fk_idCliente_Credito
foreign key (idCliente)
references cliente(idCliente)

alter table cliente 
alter column RFC varchar(13) null
--aleterando a null unas columnas de contacto
alter table contacto
alter column direccion varchar(100) null

alter table contacto
alter column telefono char(12) null

alter table contacto 
alter column email varchar(100) null

alter table contacto 
alter column estado varchar (50) null

alter table contacto 
alter column municipio varchar (50) null

alter table contacto 
alter column codigoPostal char(5) null
--Aqui se agregaron dos columnas mas a la tabla de horario
--para identificar los horarios y poder tener una idea mas
--mas clara del por que o para quien es ese horario
alter table horario 
add nombre varchar (30), descripcion varchar(200)


--###################################################################
--################### privilegio ####################################
--###################################################################

create table privilegio(
	idPrivilegio varchar(36) primary key not null,
	nombre varchar(30) 
)

create table UsuarioPrivilegio(
	idTipoUsario varchar (36) not null,
	idPrivilegio varchar (36) not null
)

alter table usuarioPrivilegio
add constraint pk_idTipoUsuarioYidPrivilegio_UsuarioPrivilegio
primary key (idTipoUsario,idPrivilegio)


alter table usuarioPrivilegio
add constraint fk_idTipoUsario_UsuarioPrivilegio
foreign key (idTipoUsario) references tipoUsuario(idTipoUsuario)

alter table usuarioPrivilegio
add constraint fk_idPrivilegio_UsuarioPrivilegio
foreign key (idPrivilegio) references privilegio(idPrivilegio)