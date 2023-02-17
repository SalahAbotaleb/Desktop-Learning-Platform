CREATE procedure SelectClassroomTitleCourseNameByID @ID Varchar(50)
AS
    begin
        select Classroom.Title as 'Classroom Title',
               Course_Name as 'Course Name'
        from Classroom,Course
        where Class_ID = @ID AND
              Classroom.Course_ID = Course.Course_ID;
    end
go

