create database bdcadastro;

use bdcadastro;

create table cliente(
id int not null primary key,
nome varchar(50) not null,
endereco varchar(50) not null,
cep char(9) not null,
bairro varchar(50) not null,
cidade varchar(50) not null,
uf char(2) not null,
telefone char(15) not null
)engine = innodb;

