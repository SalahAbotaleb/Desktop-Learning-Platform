CREATE procedure spUpdateAdmin @ID int,@username varchar(50),@Fname varchar(50),@Lname varchar(50),@Email varchar(100)
AS

if(Exists(select username from Admin where (Username=@username or Email=@Email) and Admin_ID <> @ID) )
    begin
        Throw 50000,'Repeated Username or Email',1;
    end
UPDATE Admin
SET Username=@username,Fname=@Fname,Lname=@Lname,Email=@Email
WHERE Admin_ID=@ID
go

