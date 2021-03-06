create table aviso(
idaviso int not null,
horaaviso time,
aviso VARCHAR(200),
Constraint PK_Aviso primary key(idaviso));

create table controle(
idcontrole int not null,
os varchar(20),
descricao varchar(1000),
status varchar(20),
constraint PK_controle primary key(idcontrole));

create table tempo(
idtempo int not null,
idcontrole int,
datainicio timestamp,
datafim timestamp,
Constraint PK_Tempo primary key(idtempo),
Constraint FK_Tempo_Controle foreign KEY(idcontrole) references controle(idControle));



CREATE TABLE [dbo].[Table]
(
	[IDOS] INT NOT NULL PRIMARY KEY,
    [OS1] VARCHAR(50),
    [DESCRICAO] VARCHAR(5000),
    [DTINICIO] DATETIME,
    [DTFIM] DATETIME,
    [TEMPOGASTO] DATETIME
)
