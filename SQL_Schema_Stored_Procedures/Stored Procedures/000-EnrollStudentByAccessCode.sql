CREATE procedure EnrollStudentByAccessCode @AccessCode Varchar(50), @StudentID VARCHAR(50)
AS
    if Not Exists(select * from Classroom where Access_Code = @AccessCode)
        begin
        Throw 50000,'Recheck Access Code',1;
        end
    else
        if (Exists(select * from Student_Enrolled_In where Class_ID = (select Classroom.Class_ID from Classroom where @AccessCode=Access_code) AND Student_ID = @studentID))
            begin
                Throw 50000,'Already enrolled in course',1;
            end
        else
            begin
                insert into Student_Enrolled_In
                values((select Classroom.Class_ID from Classroom where @AccessCode=Access_code), @studentID);
            end
go

