CREATE procedure SelectInstructorsForClassByCode @AccessCode Varchar(50)
AS
    if Not Exists(select * from Classroom where Access_Code = @AccessCode)
        begin
            Throw 50000,'No Classroom found',1;
        end
    else
        begin
            select FName + ' ' + LName as 'Instructor Name'
            from Instructor,Classroom,Teaches
            where Access_code = @AccessCode AND
                  Classroom.Class_ID = Teaches.Class_ID AND
                  Instructor.Instructor_ID = Teaches.Instructor_ID;
        end
go

