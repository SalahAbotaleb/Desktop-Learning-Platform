CREATE procedure spInsertStudent @username varchar(50),@Fname varchar(50),@Lname varchar(50),@Email varchar(100),@added_by int,@password varchar(50),
@Birth_Date Date,@Year int
AS
if(Exists(select * from Student where Username=@username or Email=@Email))
    begin
        Throw 50000,'Repeated Username or Email',1;
    end
insert into student(Username,fname,lname,Email,Password,Birth_Date,year)
values (@username,@Fname,@Lname,@Email,PWDENCRYPT(@password),@Birth_Date,@Year)
insert into Manage_Student(Admin_ID, Student_ID, Operation,Date)
values (@added_by,@@identity,'Insert and Activate',sysdatetime())
go

