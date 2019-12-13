


create procedure sp_ReportVentasCliente
@NombreCliente varchar(20)
as
	begin
		select vt.fecha as Periodo , pd.version ,vt.folio as Venta , vd.cantidad as Cantidad , pd.precio as Precio_Unitario , 
		vd.totalNeto as Total from venta vt  inner join ventaDetalle as vd on vt.idVenta = vd.idVenta 
		left join producto as pd on vd.idProducto = pd.idProducto 
		inner join cliente as cl on vt.idCliente   = cl.idCliente 
		where cl.nombre =  @NombreCliente 
	end


create procedure sp_ReportVentasEmpleado
@NombreEmpleado varchar(20)
as
	begin
		select vt.fecha as Periodo , pd.version ,vt.folio as Venta , vd.cantidad as Cantidad , pd.precio as Precio_Unitario , 
		vd.totalNeto as Total from venta vt  inner join ventaDetalle as vd on vt.idVenta = vd.idVenta 
		left join producto as pd on vd.idProducto = pd.idProducto 
		inner join empleado as em on vt.idEmpleado = em.idEmpleado 
		where em.nombre = @NombreEmpleado 
	end


create procedure sp_ReportVentasFechas
@fechaInicial date,
 @fechaFinal date
as
	begin
		select vt.fecha as Periodo , pd.version ,vt.folio as Venta , vd.cantidad as Cantidad , pd.precio as Precio_Unitario , 
		vd.totalNeto as Total from venta vt  inner join ventaDetalle as vd on vt.idVenta = vd.idVenta 
		left join producto as pd on vd.idProducto = pd.idProducto 
		---inner join empleado as em on em.idEmpleado = em.idEmpleado 
		where vt.fecha >= @fechaInicial and vt.fecha <= @fechaFinal
	end


create procedure sp_ReportVentasXCaja
@NombreCaja varchar(20)
as
	begin
		select vt.fecha as Periodo , pd.version ,vt.folio as Venta , vd.cantidad as Cantidad , pd.precio as Precio_Unitario , 
		vd.totalNeto as Total from venta vt  inner join ventaDetalle as vd on vt.idVenta = vd.idVenta 
		left join producto as pd on vd.idProducto = pd.idProducto 
		inner join caja as cj on vt.idCaja = cj.idCaja
		where cj.nombre = @NombreCaja
	end


create procedure sp_ReportVentasXSucursal
@NombreSucursal varchar(20)
as
	begin
		select vt.fecha as Periodo , pd.version ,vt.folio as Venta , vd.cantidad as Cantidad , pd.precio as Precio_Unitario , 
		vd.totalNeto as Total from venta vt  inner join ventaDetalle as vd on vt.idVenta = vd.idVenta 
		left join producto as pd on vd.idProducto = pd.idProducto 
		inner join bodega as cj on vt.idBodega  = cj.idBodega 
		where cj.nombre =  @NombreSucursal 
	end