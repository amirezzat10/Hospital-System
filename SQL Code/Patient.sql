create table patient(
patientID varchar(15) not null,
fname varchar(10) not null,
mname varchar(10) not null,
lname varchar(10) not null,
Adder varchar(20) default'cairo',
gender varchar(10) default 'male',
diagnosis varchar(40) not null, 
tele varchar(15) not null, 
relativeContact_phone varchar(15))

alter table patient add constraint un unique (patientID)
alter table patient add constraint ppk primary key (patientID)

alter table patient add constraint tun unique (tele)
alter table patient add constraint run unique (relativeContact_phone)

alter table patient add constraint fk2 foreign key (tele) references patient(patientID)

alter table patient alter column fname varchar(20) not null
alter table patient alter column mname varchar(20) not null
alter table patient alter column lname varchar(20) not null