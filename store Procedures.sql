--SELECT * FROM OPENQUERY(MYSQL, 'SELECT * FROM cliente');
--SELECT * FROM OPENQUERY(ORACLE, 'SELECT * FROM cliente');
--select* from cliente;
----------------------cliente---------------------
----------------------INSERT----------------------
CREATE PROC INSERT_cliente
(
@manejador as varchar (100),

@idCompania as int,
@idCliente as int,
@nombre as varchar(20),
@apellidos as varchar(20),
@telefono as varchar(20),
@calle as varchar(20),
@numero as varchar(20),
@colonia as varchar(20),
@estatus bit
)
AS
BEGIN
if @manejador ='SQL SERVER'
BEGIN 
INSERT INTO cliente ( idCliente, nombre, apellidos, telefono, calle, numero, colonia)VALUES ( @idCliente, @nombre, @apellidos, @telefono, @calle, @numero, @colonia)
END

IF @manejador = 'MYSQL'
BEGIN
INSERT INTO OPENQUERY (MYSQL, 'SELECT idCliente nombre, apellidos, telefono calle, numero, colonia  FROM autos.cliente')VALUES ( @idCliente, @nombre, @apellidos, @telefono, @calle, @numero, @colonia)
END 
end
go
IF @manejador = 'ORACLE'
BEGIN
INSERT INTO ORACLE...CLIENTE Values(@idCompania, @idCliente, @nombre, @apellidos, @telefono, @calle, @numero, @colonia, @estatus)
END
END
go

-------------UPDATE-------------------------------------
CREATE PROCEDURE SP_UPDATEcliente
(
@manejador as varchar (100),

@idCompania as int,
@idCliente as int,
@nombre as varchar(20),
@apellidos as varchar(20),
@telefono as varchar(20),
@calle as varchar(20),
@numero as varchar(20),
@colonia as varchar(20),
@estatus bit
)
AS
BEGIN
DECLARE @TSQL AS VARCHAR(8000)
IF @manejador ='SQL SERVER'
BEGIN
UPDATE cliente SET nombre=@nombre, apellidos=@apellidos, telefono=@telefono, calle=@calle, numero=@numero, colonia=@colonia
END

ELSE IF @manejador='MYSQL'
BEGIN
UPDATE MYSQL.autos..cliente SET nombre=@nombre, apellidos=@apellidos, telefono=@telefono, calle=@calle, numero=@numero, colonia=@colonia, estatus= @estatus
END

ELSE IF @manejador='ORACLE'
BEGIN 
UPDATE ORACLE...CLIENTE SET nombre=@nombre, apellidos=@apellidos, telefono=@telefono, calle=@calle, numero=@numero, colonia=@colonia, estatus= @estatus
END
END 
GO
-----------------------COMPAÑIA-------------------
----------------------INSERT----------------------
create proc SP_InsertCompania
(
@manejador as varchar (100),

@idCompania as int,
@nombre as varchar(20),
@telefono as varchar(20),
@calle as varchar(20),
@numero as varchar(20),
@colonia as varchar(20)
)
AS
BEGIN
if @manejador ='SQL SERVER'
BEGIN 
INSERT INTO compania(idCompania, nombre, telefono, calle, numero, colonia)VALUES (@idCompania, @nombre, @telefono, @calle, @numero, @colonia)
END

if @manejador = 'MYSQL'
BEGIN
INSERT INTO OPENQUERY (MYSQL, 'SELECT idCompania, nombre, telefono calle, numero, colonia FROM autos.compania')VALUES (@idCompania, @nombre, @telefono, @calle, @numero, @colonia)
END 

if @manejador = 'ORACLE'
BEGIN
INSERT INTO Oracle...COMPANIA Values(@idCompania, @nombre, @telefono, @calle, @numero, @colonia)
END

END
GO
-------------UPDATE-------------------------------------
CREATE PROCEDURE SP_updateCompania
(
@manejador as varchar (100),

@idCompania as int,
@nombre as varchar(20),
@telefono as varchar(20),
@calle as varchar(20),
@numero as varchar(20),
@colonia as varchar(20)
)
AS
BEGIN
DECLARE @TSQL AS VARCHAR(8000)
IF @manejador ='SQL SERVER'
BEGIN
UPDATE compania SET nombre=@nombre WHERE telefono=@telefono AND calle=@calle AND numero=@numero and colonia=@colonia
END

ELSE IF @manejador='MYSQL'
BEGIN
UPDATE MYSQL.autos..compania SET nombre=@nombre, telefono=@telefono, calle=@calle, numero=@numero, colonia=@colonia
END

ELSE IF @manejador='ORACLE'
BEGIN 
UPDATE ORACLE...COMPANIA SET nombre=@nombre, telefono=@telefono, calle=@calle, numero=@numero, colonia=@colonia
END
END 
GO

-----------------------vendedor-------------------
----------------------INSERT----------------------
create proc SP_InsertVendedor
(
@manejador as varchar (100),

@idCompania as int,
@idVendedor as int,
@nombre as varchar(20),
@apellidos as varchar(20),
@telefono as varchar(20),
@calle as varchar(20),
@numero as varchar(20),
@colonia as varchar(20)
)
AS
BEGIN
if @manejador ='SQL SERVER'
BEGIN 
INSERT INTO vendedor(idCompania, idVendedor, nombre, apellidos, telefono, calle, numero, colonia)VALUES (@idCompania, @idVendedor, @nombre, @apellidos, @telefono, @calle, @numero, @colonia)
END

if @manejador = 'MYSQL'
BEGIN
INSERT INTO OPENQUERY (MYSQL, 'SELECT idCompania, idCliente nombre, apellidos, telefono calle, numero, colonia FROM autos.vendedor')VALUES (@idCompania, @idVendedor, @nombre, @apellidos, @telefono, @calle, @numero, @colonia)
END 

if @manejador = 'ORACLE'
BEGIN
INSERT INTO Oracle...VENDEDOR Values(@idCompania, @idVendedor, @nombre, @apellidos, @telefono, @calle, @numero, @colonia)
END

END
GO
-------------UPDATE-------------------------------------
CREATE PROCEDURE SP_updateVendedor
(
@manejador as varchar (100),

@nombre as varchar(20),
@telefono as varchar(20),
@calle as varchar(20),
@numero as varchar(20),
@colonia as varchar(20)
)
AS
BEGIN
DECLARE @TSQL AS VARCHAR(8000)
IF @manejador ='SQL SERVER'
BEGIN
UPDATE vendedor SET nombre=@nombre, telefono=@telefono, calle=@calle, numero=@numero, colonia=@colonia
END

ELSE IF @manejador='MYSQL'
BEGIN
UPDATE MYSQL.autos..vendedor SET nombre=@nombre, telefono=@telefono, calle=@calle, numero=@numero, colonia=@colonia
END

ELSE IF @manejador='ORACLE'
BEGIN 
UPDATE ORACLE...VENDEDOR SET nombre=@nombre, telefono=@telefono, calle=@calle, numero=@numero, colonia=@colonia
END
END 
GO


-----------------------usuario---------------------------
----------------------INSERT----------------------
create proc SP_InsertUsuario
(
@manejador as varchar (100),

@idUsuario int,
@username as varchar(25),
@pwd as varchar(20),
@tipoUsuario as varchar(20),
@idCompania as int
)
AS
BEGIN
if @manejador ='SQL SERVER'
BEGIN 
INSERT INTO usuario(idUsuario, username, tipoUsuario, idCompania)VALUES (@idUsuario, @username, @pwd, @tipoUsuario,@idCompania)
END

if @manejador = 'MYSQL'
BEGIN
INSERT INTO OPENQUERY (MYSQL, 'SELECT idUsuario, username, tipoUsuario, idCompania FROM autos.usuario')VALUES (@idUsuario, @username, @pwd, @tipoUsuario,@idCompania)
END 

if @manejador = 'ORACLE'
BEGIN
INSERT INTO Oracle...USUARIO Values(@idUsuario,@username, @pwd, @tipoUsuario,@idCompania)
END

END
GO
-------------UPDATE-------------------------------------
CREATE PROCEDURE SP_updateUsuario
(
@manejador as varchar (100),

@username as varchar(25),
@pwd as varchar(20),
@tipoUsuario as varchar(20),
@idCompania as int
)
AS
BEGIN
DECLARE @TSQL AS VARCHAR(8000)
IF @manejador ='SQL SERVER'
BEGIN
UPDATE usuario SET username=@username, pwd=@pwd, tipoUsuario=@tipoUsuario, idCompania=@idCompania
END

ELSE IF @manejador='MYSQL'
BEGIN
UPDATE MYSQL.autos..usuario SET username=@username, pwd=@pwd, tipoUsuario=@tipoUsuario, idCompania=@idCompania 
END

ELSE IF @manejador='ORACLE'
BEGIN 
UPDATE ORACLE...USUARIO SET username=@username, pwd=@pwd, tipoUsuario=@tipoUsuario, idCompania=@idCompania 
END
END 
GO



