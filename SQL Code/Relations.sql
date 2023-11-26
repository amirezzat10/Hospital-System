-- RELATIONS

create table works
(
dept_id varchar (10) not null unique, 
doc_id varchar (15) not null unique,
num_hours int  not null
)
alter table works add constraint pk primary key (dept_id,doc_id)

alter table works add constraint fk5 foreign key (doc_id) references Doctor(id) on delete cascade on update cascade



create table addmitted
( 
dept_id varchar (10) not null unique,
patient_id varchar(15) not null unique,
primary key (dept_id,patient_id) 
)

alter table addmitted add constraint fk3 foreign key (patient_id) references patient(patientID) on delete cascade on update cascade

create table Manage (
admin_id varchar (15) not null unique ,
dept_id varchar (10) not null unique)


foreign key (admin_id) references admin(admin_id) on delete cascade on update cascade



alter table Manage add constraint pk1 primary key (admin_id,dept_id)


select Doctor.* from Doctor , Department where Department.dept_id = Doctor.doc_dept and dept_name = 'Optometry'
select * from Department



