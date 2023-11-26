create table Department  (
dept_id varchar(10) not null primary key ,
dept_name varchar(20) not null ,
)
alter table Department alter column dept_id varchar(20) not null  
alter table Department add constraint fk1 foreign key (dept_name) references Department(dept_id)

select * from Department 

select dept_id from Department

select dept_name,dept_id from Department where dept_id ='12'

update Department set dept_id = '12'

update Department set dept_id ='15', dept_name='Hassan' where dept_id ='12'

DELETE FROM table_name WHERE condition;

delete from Department where dept_id='11' 

select * from Doctor