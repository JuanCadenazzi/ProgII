select * from Carrera

insert into Carrera (cod_Carrera,nombre,titulo)
values (2,'Administracion','Administrador de empresas')
insert into Carrera (cod_Carrera,nombre,titulo)
values(3,'economia','contador publico')
insert into Carrera (cod_Carrera,nombre,titulo)
values(4,'medicina','Licenciado en medicina y cirugia')


create procedure SP_MOSTRAR_ASIGNATURA
AS
select cod_materia, nombre
from asignatura


exec SP_MOSTRAR_ASIGNATURA

exec sp_consultar_carrera2

exec SP_Mostrar_Detalle

create procedure SP_NUEVA_MATERIA
@nombre varchar(100),
@newCod_materia int output
AS
insert into Asignatura
values (@nombre)
set @newCod_materia = SCOPE_IDENTITY();


create procedure SP_NUEVA_CARRERA
@nombre varchar(100),
@newCod_carrera int output
AS
insert into Asignatura
values (@nombre)
set @newCod_carrera = SCOPE_IDENTITY();

create procedure SP_INSERTAR_MAESTRO
@cod_carrera int,
@nombre varchar(100),
@titulo varchar(100),
@cod_carrera_salida int output
as
insert into Carrera(cod_Carrera,nombre,titulo)
values(@cod_carrera,@nombre,@titulo)
set @cod_carrera_salida=@cod_carrera

declare @p int
execute SP_INSERTAR_MAESTRO 5,Gatronomia,Chef,@p output

select * from Carrera

create procedure SP_INSERTAR_DETALLE
@anioCursado int,
@cuatrimestre varchar(30),
@cod_materia int,
@cod_carrera_salida int
as
insert into DetalleCarrera (anioCursado,cuatrimestre,cod_materia,cod_carrera)
values (@anioCursado,@cuatrimestre,@cod_materia,@cod_carrera_salida)


execute SP_MOSTRAR_DETALLE2
2
create Procedure SP_MOSTRAR_DETALLE2
AS
SELECT c.nombre 'Carrera',anioCursado 'Año Cursado', cuatrimestre 'Cuatrimestre',a.nombre 'Materia'
FROM Carrera C join DetalleCarrera dc on dc.cod_carrera=c.cod_Carrera
join Asignatura a on a.cod_materia=dc.cod_materia

alter table carrera 
add disponibilidad bit 

select * from Carrera

create procedure SP_DESABILITAR_CARRERA
@cod_carrera bit
AS
update Carrera
set disponibilidad = 0
where cod_Carrera=@cod_carrera

create procedure SP_HABILITAR_CARRERA
@cod_carrera bit
AS
update Carrera
set disponibilidad = 1
where cod_Carrera=@cod_carrera
