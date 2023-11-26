-- Insert Patient Data:

insert into patient values ('1','aasem','said','hamed','maadi','male','cold','01155555101','01050015584')
insert into patient values ('2','amir','ezzat','thabet','zaitoun','male','cold','01246789485','01050504655')
insert into patient values ('3','engy','ezzat','mahmoud','qaluip','female','flu','01110123456','010500150845')
insert into patient values ('4','kariman','mohamed','thabet','qaluip','female','flu','0115555510100','01050015584213')
insert into patient values ('5','fady','farag','fekry','zaitoun','male','sugar','0115555510112','0105001558418')
insert into patient values ('6','nesrien','hassan','magdy','nasr city','female','high pressure','0115555510101','0105001558499')
insert into patient values ('7','abdelrahman','yasser','ismaiel','5th settlement','male','tall','01155555108','01012500155')

delete from patient where patientID ='7'

select * from admin



-- Insert Doctor Data:


insert into Doctor values ('1','ahmed','0120213256','suiz','male','5000.28','General Surgery','10/28/2000')
insert into Doctor values ('2','aly','011254652','cairo','male','5000.25','Eyes','10/25/2001')
insert into Doctor values ('3','engy','0110213256','alex','female','3000','heart','8/22/1992')
insert into Doctor values ('4','nersien','01613256','alex','female','2500.55','General Surgery','9/27/1995')
insert into Doctor values ('5','ahmed','012332132','suiz','male','1500','General Surgery','10/23/1980')
insert into Doctor values ('6','koko','0115852256','cairo','female','-500','Eyes','11/01/1975')
insert into Doctor values ('7','abdo','0165600056','cairo','male','3602.5','heart','12/21/1985')


select * from Doctor,Department





-- Insert Department Data:


insert into Department values ('1','Optometry')
insert into Department values ('2','General Surgery')
insert into Department values ('3','Ear,nose and throat')
insert into Department values ('4','Physiotherapy')

select * from Department


--Insert Medical Record Data:

insert into medical_record values('1','1','AB','10/1/2020')
insert into medical_record values('2','2','O','10/1/2020')
insert into medical_record values('3','3','A+','10/1/2020')
insert into medical_record values('4','4','B-','10/1/2020')
select * from medical_record


select * from Department , Doctor where dept_name = 'General Surgery' and dept_name = qualifications



select * from patient,medical_record

select * from Doctor 