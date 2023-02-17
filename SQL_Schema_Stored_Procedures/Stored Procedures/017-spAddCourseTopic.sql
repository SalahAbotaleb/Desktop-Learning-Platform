create procedure spAddCourseTopic @Classroom_ID int,@Topic varchar(50)
AS

    insert into Course_Topics(course_id, topic)
    values (( select Course_ID from classroom where class_ID=@Classroom_ID) ,@Topic)
go

