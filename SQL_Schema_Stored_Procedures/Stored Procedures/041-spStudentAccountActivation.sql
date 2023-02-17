CREATE procedure spStudentAccountActivation @ID int,@Status BIT,@Done_By int
AS
update Student
set Activated=@Status
where StudentID=@ID
DECLARE @StatusF varchar(50)
if @status=1
begin
    set @StatusF='Activate'
end
if @status=0
begin
    set @StatusF='Deactivate'
end
insert into Manage_Student(Admin_ID, Student_ID, Operation,Date)
values (@Done_By,@ID,@StatusF,sysdatetime())
go

