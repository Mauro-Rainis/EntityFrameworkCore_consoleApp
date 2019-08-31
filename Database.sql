create table studenti(
	id int primary key, 
	nome varchar(32), 
	sport int references sport(id));
insert into studenti values (1,'Mauro',1);
insert into studenti values (2,'Luca',2);
insert into studenti values (3,'Anna',NULL);

create table sport(
	id int primary key, 
	nome varchar(32)
	);
insert into sport values (1,'Mtb');
insert into sport values (2,'Sci');
insert into sport values (4,'Danza');
