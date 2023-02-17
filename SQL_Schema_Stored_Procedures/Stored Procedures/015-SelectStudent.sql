CREATE procedure SelectStudent @username Varchar(50), @password varchar(50)
AS
    if @username like '%@%'
        begin
        select Username,StudentID,Fname,Lname,Email,Birth_Date,year from Student where email = @username and pwdcompare(@password,Password) = 1 and Activated=1
    end
    else
        begin
        select Username,StudentID,Fname,Lname,Email,Birth_Date,year from Student where username = @username and pwdcompare(@password,Password) = 1 and Activated=1
    end
go

