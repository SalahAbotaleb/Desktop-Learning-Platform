CREATE procedure SelectManageDoneOnInstructor @ID int
AS
    if (not EXISTS(select * from Instructor where Instructor_ID = @ID))
        begin
            throw 50000, 'Instructor Not Found', 1
        end
    if (Not Exists(select * from Manage_Instructor where Instructor_ID = @ID))
        begin
            throw 50000, 'No operations done on Instructor', 1
        end
    select Admin.Admin_ID as 'ID',
           FName + ' ' + LName as 'Name',
           Operation,
           Date
    from Manage_Instructor,Admin
    where Instructor_ID = @ID and Manage_Instructor.Admin_ID = Admin.Admin_ID
go

