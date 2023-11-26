create database hospital
use hospital

create table admin(
admin_id varchar(10) not null primary key,
name varchar(10) not null,
username varchar(15) not null unique,
password varchar(15) not null ,
email varchar(15) not null,)

alter table admin alter column email varchar(40) not null  


insert into admin values('1','Aasem Said','Aasem','12345','AasemTC@gmail.com')

insert into admin values('2','admin1','admin','admin','AasemTC@gmail.com')



alter table admin add constraint fk foreign key (username) references admin(admin_id)


