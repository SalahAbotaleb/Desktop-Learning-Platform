CREATE procedure SelectManageDoneOnCourse @ID int
AS
    if (not EXISTS(select * from Course where Course_ID = @ID))
        begin
            throw 50000, 'Course Not Found', 1
        end
    if (Not Exists(select * from Manage_Course where Course_ID = @ID))
        begin
            throw 50000, 'No operations done on Course', 1
        end
    select Manage_Course.Course_ID as 'ID',
           FName + ' ' + LName as 'Name',
           Operation,
           Date
    from Manage_Course,Admin
    where Course_ID = @ID and Manage_Course.Admin_ID = Admin.Admin_ID
go

