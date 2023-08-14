# Store Inventory 2.0

### Descripcion
Este proyecto es una versión "optimizada" de la anterior versión que esta también subida al repositorio. Los cambios/mejoras a grandes rasgos son los siguientes:
1. Reducción de las vistas a solo una que engloba los tres modelos.
2. Centralización de toda la lógica/métodos en una sola clase, tanto para el presentador como para el repositorio (base de datos).
3. Simplificación del uso de los métodos anclando argumentos a los botones para mejorar su reutilización pensando en POO
### Finalidad
Este proyecto tiene la intención de ayudarme a mejorar el autoaprendizaje de la herramienta visual studio, así como del uso de C# y SQL Server. Bajo la modalidad de necesidades y errores que ayudan en la búsqueda de soluciones. Ya que al final, la práctica es mejor maestro que solo la teoría. 
### Autor
**Felipe**
### Instalacion
- Descargar código
- Copiar script BD
- Cambiar el string de connection Program.cs
### Script Base de Datos
```
create database Inventory
go
use Inventory
go

-- Tablas
create table Store
(
	_id int identity (0,1) primary key,
	_name nvarchar (50) not null,
	_address nvarchar (100) not null,
	_description nvarchar (250) not null,
	_status bit not null
)
go
create table Product
(
	_cod nvarchar (20) primary key,
	_name nvarchar (50) not null,
	_description nvarchar (500) not null,
	_status bit not null
)
go
create table Detail 
(
	_id int identity (0,1) primary key,
	_codProduct nvarchar (20) not null,
	_idStore int not null,
	_price numeric not null,
	_stock int not null

	Constraint FK_detail_Product
	Foreign Key (_codProduct) references Product (_cod)
	On update cascade
	On delete cascade,

	Constraint FK_detail_Store
	Foreign Key (_idStore) references Store (_id)
	On update cascade
	On delete cascade
)
go

-- Datos de Prueba
-- Store
insert into Store values('Central', 'AV. Providencia Calle 123', 'Sucrusal madre de la empresa', 1)
insert into Store values('Santiago', 'Calle Agustinas 123', 'Sucrusal de santiago centro', 1)
insert into Store values('Maipu', 'Los Heroes 543', 'Sucrusal de la comuna de maipu', 1)
insert into Store values('La Florida', 'Vicuna Mackenna 7714', 'Sucrusal de la comuna de florida', 1)
insert into Store values('Serena', 'Av Del Mar 333', 'Sucrusal norte de chile', 1)
insert into Store values('Temuco', 'Pedro de valdivia 345', 'Sucrusal sur de chile', 1)

-- Product
insert into Product values ('A001', 'Samsung Galaxy A14 5G', 'PantallaPLS 6.6" táctil (2408x1080) / 90 HzMemoria interna128 GBRAM4 GBCámara principalEstándar 50.0 MP + Percepción profundidad (Bokeh) 2.0 MP + Macro 2.0 MPCámara frontalEstándar 13.0 MPBatería5000 mAhSistema operativoAndroid 13Conectividad celular5G', 1)
insert into Product values ('A002', 'TCL 30 5G', 'PantallaAMOLED 6.7" táctil (2400x1080) / 60 HzMemoria interna128 GBRAM4 GBCámara principalEstándar 50.0 MP + Macro 2.0 MP + Percepción profundidad (Bokeh) 2.0 MPCámara frontalEstándar 13.0 MPBatería5010 mAhSistema operativoAndroid 12Conectividad celular5G', 1)
insert into Product values ('A003', 'Samsung Galaxy A22 5G', 'PantallaTFT 6.6" táctil (2408x1080) / 90 HzMemoria interna128 GBRAM4 GBCámara principalEstándar 48.0 MP + Gran angular (Wide angle) 5.0 MP + Percepción profundidad (Bokeh) 2.0 MPCámara frontalEstándar 8.0 MPBatería5000 mAhSistema operativoAndroid 11Conectividad celular5G', 1)
insert into Product values ('A004', 'Motorola Moto G50 5G', 'PantallaLCD IPS 6.5" táctil (1600x720) / 90 HzMemoria interna128 GBRAM4 GBCámara principalEstándar 48.0 MP + Macro 5.0 MP + Percepción profundidad (Bokeh) 2.0 MPCámara frontalEstándar 13.0 MPBatería5000 mAhSistema operativoAndroid 11Conectividad celular5G', 1)
insert into Product values ('A005', 'Xiaomi Redmi Note 10 5G', 'PantallaLCD IPS 6.5" táctil (2400x1080) / 90 HzMemoria interna128 GBRAM4 GBCámara principalEstándar 48.0 MP + Percepción profundidad (Bokeh) 2.0 MP + Macro 2.0 MPCámara frontalEstándar 8.0 MPBatería5000 mAhSistema operativoAndroid 11Conectividad celular5G', 1)
insert into Product values ('A006', 'Honor X7a', 'PantallaLCD IPS 6.8" táctil (1600x720) / 60 HzMemoria interna128 GBRAM6 GBCámara principalEstándar 50.0 MP + Gran angular (Wide angle) 5.0 MP + Percepción profundidad (Bokeh) 2.0 MP + Macro 2.0 MPCámara frontalEstándar 8.0 MPBatería6000 mAhSistema operativoAndroid 12Conectividad celular5G', 1)
insert into Product values ('A007', 'Motorola Moto G53', 'PantallaLCD IPS 6.5" táctil (1600x720) / 120 HzMemoria interna128 GBRAM6 GBCámara principalEstándar 50.0 MP + Macro 2.0 MPCámara frontalEstándar 8.0 MPBatería5000 mAhSistema operativoAndroid 13Conectividad celular5G', 1)
insert into Product values ('A008', 'Motorola Moto G51 5G', 'PantallaLCD IPS 6.8" táctil (2400x1080) / 120 HzMemoria interna128 GBRAM4 GBCámara principalEstándar 50.0 MP + Gran angular (Wide angle) 8.0 MP + Macro 2.0 MPCámara frontalEstándar 13.0 MPBatería5000 mAhSistema operativoAndroid 11Conectividad celular5G', 1)
insert into Product values ('A009', 'Xiaomi Redmi 10 5G ', 'PantallaLCD IPS 6.6" táctil (2408x1080) / 90 HzMemoria interna128 GBRAM4 GBCámara principalEstándar 50.0 MP + Macro 2.0 MPCámara frontalEstándar 5.0 MPBatería5000 mAhSistema operativoAndroid 12Conectividad celular5G', 1)
insert into Product values ('A010', 'Motorola One 5G Ace', 'PantallaLCD IPS 6.7" táctil (2400x1080) / 60 HzMemoria interna64 GBRAM4 GBCámara principalEstándar 48.0 MP + Gran angular (Wide angle) 8.0 MP + Macro 2.0 MPCámara frontalEstándar 16.0 MPBatería5000 mAhSistema operativoAndroid 10Conectividad celular5G', 1)
insert into Product values ('A011', 'Xiaomi Redmi Note 12 5G', 'PantallaAMOLED 6.7" táctil (2400x1080) / 120 HzMemoria interna128 GBRAM4 GBCámara principalEstándar 48.0 MP + Gran angular (Wide angle) 8.0 MP + Macro 2.0 MPCámara frontalEstándar 13.0 MPBatería5000 mAhSistema operativoAndroid 12Conectividad celular5G', 1)
insert into Product values ('A012', 'Samsung Galaxy A32 5G', 'PantallaLCD IPS 6.5" táctil (1560x720) / 60 HzMemoria interna128 GBRAM4 GBCámara principalEstándar 48.0 MP + Gran angular (Wide angle) 8.0 MP + Macro 5.0 MP + Percepción profundidad (Bokeh) 2.0 MPCámara frontalEstándar 20.0 MPBatería5000 mAhSistema operativoAndroid 11Conectividad celular5G', 1)
insert into Product values ('A013', 'Oppo A78', 'PantallaLCD IPS 6.6" táctil (1612x720) / 90 HzMemoria interna128 GBRAM4 GBCámara principalEstándar 50.0 MP + Percepción profundidad (Bokeh) 2.0 MPCámara frontalEstándar 8.0 MPBatería5000 mAhSistema operativoAndroid 12Conectividad celular5G', 1)
insert into Product values ('A014', 'Xiaomi Poco M4 5G ', 'PantallaLCD IPS 6.6" táctil (2408x1080) / 90 HzMemoria interna64 GBRAM6 GBCámara principalEstándar 13.0 MP + Percepción profundidad (Bokeh) 2.0 MPCámara frontalEstándar 5.0 MPBatería5000 mAhSistema operativoAndroid 12Conectividad celular5G', 1)
insert into Product values ('A015', 'Honor X8a 5G', 'PantallaLCD IPS 6.5" táctil (1600x720) / 60 HzMemoria interna128 GBRAM6 GBCámara principalEstándar 50.0 MP + Percepción profundidad (Bokeh) 2.0 MP + Macro 2.0 MPCámara frontalEstándar 8.0 MPBatería5000 mAhSistema operativoAndroid 12Conectividad celular5G', 1)
insert into Product values ('A016', 'Samsung Galaxy A23 5G', 'PantallaPLS 6.6" táctil (2408x1080) / 120 HzMemoria interna128 GBRAM6 GBCámara principalEstándar 50.0 MP + Gran angular (Wide angle) 5.0 MP + Macro 2.0 MP + Percepción profundidad (Bokeh) 2.0 MPCámara frontalEstándar 8.0 MPBatería5000 mAhSistema operativoAndroid 12Conectividad celular5G', 1)
insert into Product values ('A017', 'TCL 40R', 'PantallaLCD IPS 6.6" táctil (1612x720) / 90 HzMemoria interna128 GBRAM4 GBCámara principalEstándar 50.0 MP + Percepción profundidad (Bokeh) 2.0 MP + Macro 2.0 MPCámara frontalEstándar 8.0 MPBatería5000 mAhSistema operativoAndroid 12Conectividad celular5G', 1)
insert into Product values ('A018', 'Motorola Moto G71 5G ', 'PantallaG-OLED 6.4" táctil (2400x1080) / 60 HzMemoria interna128 GBRAM6 GBCámara principalEstándar 50.0 MP + Percepción profundidad (Bokeh) 8.0 MP + Macro 2.0 MPCámara frontalEstándar 16.0 MPBatería5000 mAhSistema operativoAndroid 11Conectividad celular5G', 1)

-- Detail
insert into Detail values ('A001', 0, 119990, 100)
insert into Detail values ('A002', 0, 129990, 100)
insert into Detail values ('A003', 0, 139990, 100)
insert into Detail values ('A004', 0, 149990, 100)
insert into Detail values ('A005', 0, 149990, 100)
insert into Detail values ('A006', 0, 150000, 100)
insert into Detail values ('A007', 0, 152990, 100)
insert into Detail values ('A008', 0, 154900, 100)
insert into Detail values ('A009', 0, 161490, 100)
insert into Detail values ('A010', 0, 169990, 100)
insert into Detail values ('A011', 0, 169990, 100)
insert into Detail values ('A012', 0, 179200, 100)
insert into Detail values ('A014', 0, 179990, 100)
insert into Detail values ('A015', 0, 179990, 100)
insert into Detail values ('A016', 0, 179990, 100)
insert into Detail values ('A017', 0, 184800, 100)
insert into Detail values ('A018', 0, 188390, 100)

insert into Detail values ('A001', 1, 119990, 10)
insert into Detail values ('A002', 1, 129990, 1)
insert into Detail values ('A003', 1, 139990, 0)
insert into Detail values ('A004', 1, 149990, 50)
insert into Detail values ('A005', 1, 149990, 70)
insert into Detail values ('A006', 1, 150000, 99)
insert into Detail values ('A007', 1, 152990, 10)
insert into Detail values ('A008', 1, 154900, 10)
insert into Detail values ('A009', 1, 161490, 20)
insert into Detail values ('A010', 1, 169990, 0)
insert into Detail values ('A011', 1, 169990, 1)
insert into Detail values ('A012', 1, 179200, 10)
insert into Detail values ('A014', 1, 179990, 10)
insert into Detail values ('A015', 1, 179990, 0)
insert into Detail values ('A016', 1, 179990, 10)
insert into Detail values ('A017', 1, 184800, 10)
insert into Detail values ('A018', 1, 188390, 10)

insert into Detail values ('A001', 2, 119990, 100)
insert into Detail values ('A002', 2, 129990, 10)
insert into Detail values ('A003', 2, 139990, 10)
insert into Detail values ('A004', 2, 149990, 0)
insert into Detail values ('A005', 2, 149990, 0)
insert into Detail values ('A006', 2, 150000, 9)
insert into Detail values ('A007', 2, 152990, 1)
insert into Detail values ('A008', 2, 154900, 100)
insert into Detail values ('A009', 2, 161490, 2)
insert into Detail values ('A010', 2, 169990, 0)
insert into Detail values ('A011', 2, 169990, 1)
insert into Detail values ('A012', 2, 179200, 10)
insert into Detail values ('A014', 2, 179990, 10)
insert into Detail values ('A015', 2, 179990, 10)
insert into Detail values ('A016', 2, 179990, 100)
insert into Detail values ('A017', 2, 184800, 10)
insert into Detail values ('A018', 2, 188390, 10)

insert into Detail values ('A001', 3, 119990, 0)
insert into Detail values ('A002', 3, 129990, 1)
insert into Detail values ('A003', 3, 139990, 0)
insert into Detail values ('A004', 3, 149990, 5)
insert into Detail values ('A005', 3, 149990, 7)
insert into Detail values ('A006', 3, 150000, 9)
insert into Detail values ('A007', 3, 152990, 1)
insert into Detail values ('A008', 3, 154900, 10)
insert into Detail values ('A009', 3, 161490, 20)
insert into Detail values ('A010', 3, 169990, 0)
insert into Detail values ('A011', 3, 169990, 1)
insert into Detail values ('A012', 3, 179200, 0)
insert into Detail values ('A014', 3, 179990, 0)
insert into Detail values ('A015', 3, 179990, 0)
insert into Detail values ('A016', 3, 179990, 10)
insert into Detail values ('A017', 3, 184800, 100)
insert into Detail values ('A018', 3, 188390, 10)

insert into Detail values ('A001', 4, 119990, 10)
insert into Detail values ('A002', 4, 129990, 22)
insert into Detail values ('A003', 4, 139990, 33)
insert into Detail values ('A004', 4, 149990, 90)
insert into Detail values ('A005', 4, 149990, 70)
insert into Detail values ('A006', 4, 150000, 9)
insert into Detail values ('A007', 4, 152990, 100)
insert into Detail values ('A008', 4, 154900, 100)
insert into Detail values ('A009', 4, 161490, 2)
insert into Detail values ('A010', 4, 169990, 30)
insert into Detail values ('A011', 4, 169990, 10)
insert into Detail values ('A012', 4, 179200, 30)
insert into Detail values ('A014', 4, 179990, 40)
insert into Detail values ('A015', 4, 179990, 50)
insert into Detail values ('A016', 4, 179990, 0)
insert into Detail values ('A017', 4, 184800, 0)
insert into Detail values ('A018', 4, 188390, 14)

insert into Detail values ('A001', 5, 119990, 100)
insert into Detail values ('A002', 5, 129990, 25)
insert into Detail values ('A003', 5, 139990, 39)
insert into Detail values ('A004', 5, 149990, 90)
insert into Detail values ('A015', 5, 179990, 0)
insert into Detail values ('A016', 5, 179990, 0)
insert into Detail values ('A017', 5, 184800, 0)
insert into Detail values ('A018', 5, 188390, 100)
```