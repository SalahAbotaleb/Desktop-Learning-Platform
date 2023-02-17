CREATE procedure SearchClassroomForStudent @AccessCode Varchar(50)
AS
    if Not Exists(select * from Classroom where Access_Code = @AccessCode)
        begin
            Throw 50000,'No Classroom found',1;
        end
    else
        begin
            select Classroom.Title as 'Classroom Title',
                   Course_Name as 'Course Name'
            from Classroom,Course
            where Access_code = @AccessCode AND
                  Classroom.Course_ID = Course.Course_ID;
        end
go

