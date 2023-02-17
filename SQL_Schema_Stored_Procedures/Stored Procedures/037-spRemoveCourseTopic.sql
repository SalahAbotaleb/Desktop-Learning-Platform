create procedure spRemoveCourseTopic @Classroom_ID int,@Topic varchar(50)
AS
    delete from Course_Topics where Course_Topics.Course_ID=(select Classroom.Course_ID from Classroom where Class_ID=@Classroom_ID) and topic=@Topic
go

