drop table if exists Userdata

CREATE TABLE Userdata(
id_user int identity (1,1) not null,
login_user varchar(30) not null,
name_user varchar(50) not null,
surname_user varchar(50) not null,
email_user varchar(320) not null,
password_user varchar(50) not null,

);

insert into Userdata (login_user, name_user, surname_user, email_user, password_user) values ('nik', 'Nikolay', 'Shapilov', 'example@mail.ru', '1234')

select * from Userdata