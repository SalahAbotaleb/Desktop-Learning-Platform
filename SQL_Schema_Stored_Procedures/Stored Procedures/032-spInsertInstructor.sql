CREATE procedure spInsertInstructor @username varchar(50),@Fname varchar(50),@Lname varchar(50),@Email varchar(100),@added_by int,@password varchar(50),
@Title varchar(50)
AS
if(Exists(select * from Instructor where Username=@username or Email=@Email))
    begin
        Throw 50000,'Repeated Username or Email',1;
    end
insert into Instructor(Username,fname,lname,Email,Password,Title)
values (@username,@Fname,@Lname,@Email,PWDENCRYPT(@password),@Title)
insert into Manage_Instructor(Admin_ID, Instructor_ID, Operation,Date)
values (@added_by,@@identity,'Insert and Activate',sysdatetime())
go

