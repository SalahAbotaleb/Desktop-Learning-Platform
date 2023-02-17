CREATE FUNCTION fnCheckParticipant (@ID int)
RETURNS VARCHAR(5)
AS
BEGIN
    IF EXISTS (SELECT* FROM Instructor  WHERE Instructor_ID = @ID) or EXISTS (SELECT* FROM Student  WHERE StudentID = @ID)
        return 'True'
    return 'False'
END
go

