create database NovaTeam

use NovaTeam

create table [User]
(
	ID int primary key not null identity,
	Name nvarchar(100),
	Phone nvarchar(13) unique not null,
	City nvarchar(20)
)

create table Package
(
	ID int primary key not null identity,
	Number nvarchar(16) unique not null,
	City nvarchar(20) not null,
	Department nvarchar(20) not null,
	NameDest nvarchar(100) not null,
	Payer int check(Payer between 0 and 1) not null,
	Remittance int check(Remittance>0),
	[Description] nvarchar(100) not null,
	ID_User int foreign key references [User](ID)
)