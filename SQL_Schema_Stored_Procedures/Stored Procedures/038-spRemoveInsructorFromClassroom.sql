create procedure spRemoveInsructorFromClassroom @Instructor_ID int,@Class_ID int
as
    delete from Teaches
    where Instructor_ID=@Instructor_ID and Class_ID=@Class_ID
go

