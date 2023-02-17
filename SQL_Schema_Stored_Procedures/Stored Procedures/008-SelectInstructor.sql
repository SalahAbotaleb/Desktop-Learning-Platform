CREATE procedure SelectInstructor @username Varchar(50), @password varchar(50)
AS
    if @username like '%@%'
        begin
        select Username,Instructor_ID,Fname,Lname,Email,Title from Instructor where email = @username and pwdcompare(@password,Password) = 1 and Activated=1
    end
    else
        begin
        select Username,Instructor_ID,Fname,Lname,Email,Title from Instructor where username = @username and pwdcompare(@password,Password) = 1 and Activated=1
    end
go

