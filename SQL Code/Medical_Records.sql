create table medical_record(
p_id varchar(10) not null unique,
record_id varchar(10) not null unique,
blood_type varchar(2) not null,
date_of_examination date,)

alter table medical_record add constraint pk5 primary key(p_id,record_id)









