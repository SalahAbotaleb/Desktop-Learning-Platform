create procedure spRemoveClassroom @Class_ID int
as
delete from Classroom where Class_ID=@Class_ID
go

