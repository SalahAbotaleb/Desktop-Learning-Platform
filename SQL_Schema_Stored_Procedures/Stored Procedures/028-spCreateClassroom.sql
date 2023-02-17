CREATE procedure spCreateClassroom @Title varchar(50),@Course_ID int,@Created_By int
as
insert into Classroom (Access_code, Title, Course_ID, Created_by, Date_created_at)
values(SUBSTRING(CONVERT(varchar(40), NEWID()),0,6),@Title,@Course_ID,@Created_By,sysdatetime())
insert into Teaches(instructor_id, class_id)
values(@Created_By,@@identity);
select * from Classroom where Class_ID=IDENT_CURRENT ('Classroom');
go

