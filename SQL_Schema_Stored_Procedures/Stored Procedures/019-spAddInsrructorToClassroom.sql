create procedure spAddInsrructorToClassroom @Instructor_ID int,@Class_ID int
as
insert into Teaches(Instructor_ID, Class_ID)
values(@Instructor_ID,@Class_ID)
go

