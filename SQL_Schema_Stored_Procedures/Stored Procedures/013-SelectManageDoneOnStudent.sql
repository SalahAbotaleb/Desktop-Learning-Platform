CREATE procedure SelectManageDoneOnStudent @ID int
AS
    if (not EXISTS(select * from Student where StudentID = @ID))
        begin
            throw 50000, 'Student Not Found', 1
        end
    if (Not Exists(select * from Manage_Student where Student_ID = @ID))
        begin
            throw 50000, 'No operations done on student', 1
        end
    select Admin.Admin_ID as 'ID',
           FName + ' ' + LName as 'Name',
           Operation,
           Date
    from Manage_Student,Admin
    where Student_ID = @ID and Manage_Student.Admin_ID = Admin.Admin_ID
go

