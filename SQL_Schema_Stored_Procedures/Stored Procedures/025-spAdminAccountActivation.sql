CREATE procedure spAdminAccountActivation @ID int,@Status BIT
AS
update Admin
set Activated=@Status
where Admin_ID=@ID
go

