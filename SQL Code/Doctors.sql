create table Doctor (
id varchar(15) not null primary key,
name varchar(40) not null,
number varchar(11) not null,
address varchar(40) default 'cairo',
gender varchar(6) not null,
salary decimal(8,2) not null,
qualifications varchar(15)not null,
birthdate varchar(10) not null,
)

alter table Doctor add constraint fk4 foreign key (qualifications) references Doctor(id)

select * from Doctor

alter table Doctor add doc_dept varchar(20) not null default '1'
alter table Doctor add constraint fk10 foreign key (doc_dept) references Department (dept_id)