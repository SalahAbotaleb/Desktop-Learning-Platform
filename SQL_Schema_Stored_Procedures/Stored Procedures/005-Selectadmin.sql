CREATE procedure Selectadmin @username Varchar(50), @password varchar(50)
AS
    if @username like '%@%'
        begin
        select Username,Admin_ID,Fname,Lname,Super_ID,Email from admin where email = @username and pwdcompare(@password,Password) = 1 and Activated=1
    end
    else
        begin
        select Username,Admin_ID,Fname,Lname,Super_ID,Email from admin where username = @username and pwdcompare(@password,Password) = 1 and Activated=1
    end
go

