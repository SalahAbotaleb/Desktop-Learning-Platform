CREATE procedure SelectInstructorsForClassByID @ClassID Varchar(50)
AS
    begin
        select FName + ' ' + LName as 'Instructor Name'
        from Instructor,Teaches
        where Class_ID = @ClassID AND
              Instructor.Instructor_ID = Teaches.Instructor_ID;
    end
go

