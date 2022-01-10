drop table cliente;
drop table formaPago;
drop table vendedor;
drop table cotizacion;
drop table productoOrden;
drop table productoCotizacion;
drop table usuario;
drop table compania;
drop table orden;
drop table producto;

--------------Tablas--------------------------------------

CREATE TABLE usuario
(
   idUsuario number(10) NOT NULL,
   PRIMARY KEY (idUsuario),

   username varchar2(25),
   pwd VARCHAR2(20) NOT NULL,
   tipoUsuario VARCHAR2(20) NOT NULL,
   idVendedor NUMBER(10) NOT NULL,
   idCompania NUMBER(10) DEFAULT 1 NOT NULL,
   estatus number(1) DEFAULT 1 NOT NULL
);


CREATE TABLE compania
(
   idCompania number(10) DEFAULT 1 NOT NULL,
   PRIMARY KEY (idCompania),

   nombre varchar2(25),
   telefono VARCHAR2(20) NOT NULL,
   calle VARCHAR2(20) NOT NULL,
   numero VARCHAR2(20) NOT NULL,
   colonia VARCHAR2(20) NOT NULL,
   estatus number(1) DEFAULT 1 NOT NULL
);


CREATE TABLE cliente
(
   idCompania NUMBER(10) DEFAULT 1 NOT NULL,
   idCliente NUMBER(10) NOT NULL ,
   PRIMARY KEY (idCompania, idCliente),
   
   nombre VARCHAR2(20),
   apellidos VARCHAR2(50),
   telefono VARCHAR2(20) NOT NULL,
   calle VARCHAR2(20) NOT NULL,
   numero VARCHAR2(20) NOT NULL,
   colonia VARCHAR2(20) NOT NULL,
   estatus number(1) DEFAULT 1 NOT NULL
);


CREATE TABLE vendedor
(
	idCompania NUMBER(10) DEFAULT 1 NOT NULL,
	idVendedor number(10) NOT NULL ,
   PRIMARY KEY (idCompania, idVendedor),
   
   nombre VARCHAR2(20),
   apellidos VARCHAR2(50),
   telefono VARCHAR2(20) NOT NULL,
   calle VARCHAR2(20) NOT NULL,
   numero VARCHAR2(20) NOT NULL,
   colonia VARCHAR2(20) NOT NULL,
   fechaIngreso DATE,
   
   estatus number(1) DEFAULT 1 NOT NULL
);


CREATE TABLE cotizacion
(
   idCompania NUMBER(10) DEFAULT 1 NOT NULL,
   idCotizacion NUMBER(10) NOT NULL ,
   PRIMARY KEY (idCompania, idCotizacion),
   
   fecha DATE, 
   vigencia DATE, 
   lugarEntrega VARCHAR2(20),
   tiempoEntrega VARCHAR2(20),
   
   idVendedor NUMBER(10) NOT NULL,
   idCliente NUMBER(10) NOT NULL,
   idFormaPago NUMBER(10) NOT NULL,  /*quiza quite esto*/
   
   estatus number(1) DEFAULT 1 NOT NULL
);


CREATE TABLE orden
(
   idCompania NUMBER(10) DEFAULT 1 NOT NULL,
   idOrden number(10) NOT NULL ,
   PRIMARY KEY (idCompania, idOrden),
   
   idCliente NUMBER(10) NOT NULL,

   nombreCliente VARCHAR2(50),
   lugarEntrega VARCHAR2(20),
   fecha DATE NOT NULL,
   hora interval day to second NOT NULL,
   
   idCotizacion NUMBER(10) NOT NULL,
   idVendedor NUMBER(10) NOT NULL,
   idFormaPago NUMBER(10) NOT NULL, /*quiza quite esto*/
   estatus number(1) DEFAULT 1 NOT NULL
);


CREATE TABLE producto
(
   idCompania NUMBER(10) DEFAULT 1 NOT NULL,
   idProducto NUMBER(10) NOT NULL ,
   PRIMARY KEY (idCompania, idProducto),
   
   precio NUMBER(18,0),
   color varchar2(20),
   nombre varchar2(20),
   tipoUnidad varchar2(20),
   cantidad NUMBER(10), 

   estatus number(1) DEFAULT 1 NOT NULL
);


CREATE TABLE formaPago
(
   idCompania NUMBER(10) DEFAULT 1 NOT NULL,
	idFormaPago number(10) NOT NULL ,
   PRIMARY KEY (idCompania, idFormaPago),

   nombre varchar2(25),
   estatus number(1) DEFAULT 1 NOT NULL
);


CREATE TABLE productoOrden
(
   idCompania NUMBER(10) DEFAULT 1 NOT NULL,
   idOrden NUMBER(10) NOT NULL,
   idProducto NUMBER(10) NOT NULL ,
   PRIMARY KEY (idCompania, idOrden, idProducto),
   
   nombreProducto VARCHAR2(20),
   cantidad NUMBER(10) NOT NULL,
   precio NUMBER(18,0),
   fechaEntrega DATE,
   precioTotal number(18,0), /**/
   partida number(10),           /**/

   estatus number(1) DEFAULT 1 NOT NULL
);


CREATE TABLE productoCotizacion
(
   idCompania NUMBER(10) DEFAULT 1 NOT NULL,
   idCotizacion NUMBER(10) NOT NULL,
   idProducto NUMBER(10) NOT NULL ,
   PRIMARY KEY (idCompania, idCotizacion, idProducto),
   
   nombreProducto VARCHAR2(20),
   partida number(10),
   cantidadSolicitada NUMBER(10),
   cantidadSolicitadaProveedor NUMBER(10), /*quiza quite esto*/
   cantidadDisponibleProveedor NUMBER(10),
   precio NUMBER(18,0),
   descuento NUMBER(18,0),
   subtotal NUMBER(18,0),
   iva NUMBER(18,0),
   total NUMBER(18,0),
   
   estatus number(1) DEFAULT 1 NOT NULL
);
--------------Index--------------------------------------


CREATE INDEX IX_compania ON compania(idCompania);

CREATE INDEX IX_cliente ON cliente(idCliente);

CREATE INDEX IX_vendedor ON vendedor(idVendedor);

CREATE INDEX IX_orden ON orden(idOrden);

CREATE INDEX IX_producto ON producto(idProducto);

CREATE INDEX IX_formaPago ON formaPago(idFormaPago);

CREATE INDEX IX_cotizacion ON cotizacion(idCotizacion);
--------------Relaciones--------------------------------------
ALTER TABLE usuario
ADD CONSTRAINT FK_usuarioVendedor
FOREIGN KEY (idCompania,idVendedor) REFERENCES Vendedor(idCompania,idVendedor);
 

ALTER TABLE vendedor
ADD CONSTRAINT FK_vendedorCompania
FOREIGN KEY (idCompania) REFERENCES compania(idCompania);
 


ALTER TABLE Orden
ADD CONSTRAINT FK_OrdenCliente
FOREIGN KEY (idCompania,idCliente) REFERENCES Cliente (idCompania,idCliente);
 
ALTER TABLE Orden
ADD CONSTRAINT FK_OrdenVendedor
FOREIGN KEY (idCompania,idVendedor) REFERENCES Vendedor (idCompania,idVendedor);
 
ALTER TABLE Orden
ADD CONSTRAINT FK_OrdenCotizacion
FOREIGN KEY (idCompania,idCotizacion) REFERENCES Cotizacion (idCompania,idCotizacion);
 
ALTER TABLE orden
ADD CONSTRAINT FK_ordenFormaPago
FOREIGN KEY (idCompania,idFormaPago) REFERENCES formaPago(idCompania,idFormaPago);
 

ALTER TABLE productoOrden
ADD CONSTRAINT FK_productoOrdenOrden
FOREIGN KEY (idCompania,idOrden) REFERENCES Orden (idCompania, idOrden);
 
ALTER TABLE productoOrden
ADD CONSTRAINT FK_productoOrdenProducto
FOREIGN KEY (idCompania,idProducto) REFERENCES Producto (idCompania,idProducto);
 


ALTER TABLE Cotizacion
ADD CONSTRAINT FK_CotizacionVendedor
FOREIGN KEY (idCompania,idVendedor) REFERENCES Vendedor (idCompania,idVendedor);
 
ALTER TABLE Cotizacion
ADD CONSTRAINT FK_CotizacionCliente
FOREIGN KEY (idCompania,idCliente) REFERENCES Cliente (idCompania,idCliente);
 
ALTER TABLE cotizacion
ADD CONSTRAINT FK_cotizacionFormaPago
FOREIGN KEY (idCompania,idFormaPago) REFERENCES formaPago(idCompania,idFormaPago);
 

ALTER TABLE productoCotizacion
ADD CONSTRAINT FK_DetalleCotizacionCotizacion
FOREIGN KEY (idCompania,idCotizacion) REFERENCES Cotizacion (idCompania,idCotizacion);
 
ALTER TABLE productoCotizacion
ADD CONSTRAINT FK_productoCotizacionProducto
FOREIGN KEY (idCompania,idProducto) REFERENCES Producto (idCompania,idProducto);
 


ALTER TABLE Producto
ADD CONSTRAINT FK_ProductoCompania
FOREIGN KEY (idCompania) REFERENCES Compania(idCompania);
 
ALTER TABLE Cotizacion
ADD CONSTRAINT FK_CotizacionCompania
FOREIGN KEY (idCompania) REFERENCES Compania(idCompania);
 
ALTER TABLE Orden
ADD CONSTRAINT FK_OrdenCompania
FOREIGN KEY (idCompania) REFERENCES Compania(idCompania);
 
ALTER TABLE formaPago
ADD CONSTRAINT FK_condicionPagoCompania
FOREIGN KEY (idCompania) REFERENCES compania(idCompania);
 
ALTER TABLE cliente
ADD CONSTRAINT FK_clienteCompania
FOREIGN KEY (idCompania) REFERENCES compania(idCompania);
 
ALTER TABLE productoCotizacion
ADD CONSTRAINT FK_DetalleCotizacionCompania
FOREIGN KEY (idCompania) REFERENCES Compania(idCompania);
  

ALTER TABLE productoOrden
ADD CONSTRAINT FK_productoOrdenCompania
FOREIGN KEY (idCompania) REFERENCES compania(idCompania);
 

--------------Poblacion--------------------------------------
Insert into compania (idCompania,nombre, calle, numero, colonia, telefono) 
 select 1,'concesiones gutierrez', 'blvd pape', '505', 'chapultepec', '8661234567' from dual union all 
 select 2,'concesiones alameda', 'blvd juarez', '1005', 'los pinos', '8668432514' from dual union all 
 select 3,'concesiones espejel', 'blvd madero', '104', 'guadalupe', '8668314525' from dual union all 
 select 4,'concesiones ramirez', 'avenida acereros', '236', 'huemac', '8669654237' from dual;

Insert into cliente (idCompania, idCliente, nombre, apellidos, telefono, calle, numero, colonia)
 select 1,2,'raul','jimenez espriu','7894561333','manzana','85','matilda' from dual union all 
 select 1,3,'maria','alvarez garza','8665214698','pizza','45','brujilda' from dual union all 
 select 1,1,'perla','dieguez vazquez','8719632587','hidalgo','96','centro' from dual;


Insert into formaPago (idCompania, idFormaPago,nombre)
 select 1,2,'debito' from dual union all 
 select 1,1,'credito' from dual union all 
 select 1,3,'efectivo' from dual;

Insert into producto (idCompania, idProducto, precio, color, nombre, tipoUnidad, cantidad)
 select 1,1,100000,'marron','cavalier', 'unidad',2 from dual union all 
 select 1,2,134000,'azul','sonic', 'unidad',4 from dual union all 
 select 1,3,232000,'rojo','crv', 'unidad',1 from dual;

Insert into vendedor (idCompania, idVendedor, nombre, apellidos, telefono, calle, numero, colonia, fechaIngreso)
 select 1,3,'juan','perez garza', '8661234567','anaconda', '89', 'atenas', date '1998-12-05' from dual union all 
 select 1,2,'jaime','leon sada', '8667894561','pelicano', '54', 'venecia', date '1954-05-31' from dual union all 
 select 1,1,'felipe','fernandez gomez', '8667463258','chilero', '86', 'grecia',date '1980-04-16' from dual union all 
 select 1,4,'alvaro','dieguez lopez', '8665364186','chanate', '15', 'paris',   date '1978-06-29' from dual union all 
 select 1,5,'ramiro','ordonez obrador', '8667854362','gorrion', '25', 'italia',date '1951-01-17' from dual union all 
 select 1,6,'raul','enriquez ramirez', '8716985473','avestruz', '87', 'las aves',date '1981-06-08' from dual;

Insert into cotizacion (idCompania, idCotizacion, fecha, vigencia, lugarEntrega, tiempoEntrega, idVendedor, idCliente, idFormaPago)
 select 1,1,date '1997-04-14',date '1997-05-14', 'monclova','3 semanas', 2, 3,1 from dual union all  
 select 1,2,date '1984-07-05',date '1984-08-05', 'sabinas','2 semanas', 3, 1,2 from dual union all 
 select 1,3,date '1965-01-15',date '1965-02-15', 'frontera','12 semanas', 1, 2,3 from dual;

Insert into orden (idCompania, idOrden, idCliente,nombreCliente, lugarEntrega, fecha,hora, idCotizacion,idVendedor,idFormaPago)
 select 1,1,2,'juan ramirez mendoza', 'sabinas',date '1997-04-15', to_dsinterval('0 07:39:33'),2,1,3 from dual union all 
 select 1,3,3,'alfredo casas cobalto', 'frontera',date '1984-07-06',to_dsinterval('0 13:05:10'),1,3,1 from dual union all 
 select 1,2,1,'wilfredo cardona hernandez', 'monclova',date '1965-02-18',to_dsinterval('0 16:45:00'),3,2,2 from dual;

Insert into productoOrden (idCompania,idOrden,idProducto,nombreProducto, cantidad, precio, fechaEntrega, precioTotal, partida)
 select 1,2,3,'cavalier',2,100000,date '1997-06-07',120000,1 from dual union all 
 select 1,3,1,'sonic',4,134000,date '1984-08-19',135000,2 from dual union all 
 select 1,1,2,'crv',1,232000,date '1965-05-15',235000,1 from dual;

Insert into productoCotizacion (idCompania,idCotizacion,idProducto,nombreProducto,partida, cantidadSolicitada, cantidadSolicitadaProveedor, cantidadDisponibleProveedor, precio, descuento, subtotal,iva,total)
 select 1,3,2,'cavalier',1,2, 10,12, 100000, 0,99000,16000,116000 from dual union all 
 select 1,2,3,'sonic',1,4, 12,15, 134000, 12,132000,21440,155440 from dual union all 
 select 1,1,1,'crv',1,1, 8,16, 232000, 20,228000,37120,269120 from dual;

Insert into usuario (idCompania,idVendedor,idUsuario,username,pwd, tipoUsuario)
 select 1,3,1,'juan','123','admin' from dual union all 
 select 1,1,2,'jaime','123','admin' from dual union all 
 select 1,2,3,'felipe','123','admin' from dual union all 
 select 1,6,4,'alvaro','123','user' from dual union all 
 select 1,4,5,'ramiro','123','user' from dual union all 
 select 1,5,6,'raul','123','user' from dual;


 
 --------------Select--------------------------------------
/*select * from compania;
select * from cliente;
select * from vendedor;
select * from cotizacion;
select * from orden;
select * from producto;
select * from formapago;
select * from productoOrden;
select * from productocotizacion;
select * from usuario;*/