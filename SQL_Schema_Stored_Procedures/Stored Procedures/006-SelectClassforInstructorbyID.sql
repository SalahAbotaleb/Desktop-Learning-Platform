CREATE PROCEDURE SelectClassforInstructorbyID @Ins_ID varchar(50)
AS
begin
select  Title from Classroom,Teaches WHERE Classroom.Class_ID=@Ins_ID
end
go

