CREATE procedure SelectManagingByAdmin @ID int
AS
    if (not EXISTS(select * from Admin where Admin_ID = @ID))
        begin
            throw 50000, 'Admin Not Found', 1
        end
    if (Not Exists(select * from Manage_Course where Admin_ID = @ID) And
        Not Exists(select * from Manage_Instructor where Admin_ID = @ID) And
        Not Exists(select * from Manage_Student where Admin_ID = @ID))
        begin
            throw 50000, 'Nothing is managed by this admin', 1
        end
    select Manage_Course.Course_ID as 'ID',
       Course_Name as 'Name',
       'Course' as 'Type',
       Operation,
       Date
    from Manage_Course,Course
    where Manage_Course.Course_ID = Course.Course_ID and Admin_ID = @ID
    union
    select Manage_Instructor.Instructor_ID as 'ID',
           FName + ' ' + LName as 'Name',
           'Instructor' as 'Type',
           Operation,
           Date
    from Manage_Instructor,Instructor
    where Manage_Instructor.Instructor_ID = Instructor.Instructor_ID and Admin_ID = @ID
    union
    select Student_ID as 'ID',
           FName + ' ' + LName as 'Name',
           'Student' as 'Type',
           Operation,
           Date
    from Manage_Student,Student
    where Manage_Student.Student_ID = Student.StudentID and Admin_ID = @ID
go

