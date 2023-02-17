CREATE procedure spUpdateStudent @ID int,@username varchar(50),@Fname varchar(50),@Lname varchar(50),@Email varchar(100),@year int,@Password varchar(50) = null,@Done_By int = null
AS

if(Exists(select username from Student where (Username=@username or Email=@Email) and StudentID <> @ID) )
    begin
        Throw 50000,'Repeated Username or Email',1;
    end

DECLARE @prev_record Table(username varchar(50),Fname varchar(50),Lname varchar(50),Email varchar(100),year int)
DECLARE @new_record Table(username varchar(50),Fname varchar(50),Lname varchar(50),Email varchar(100),year int)

INSERT INTO @prev_record
select username ,Fname,Lname,Email,year
from Student
where StudentID=@ID

Declare @Updated_Fields varchar(100)='UPDATE'

if(Exists(select * from student where pwdcompare(@Password,Password)=0 and StudentID=@ID AND @Password is not null))
begin
    set @Updated_Fields=@Updated_Fields+' Password'
    UPDATE Student
    SET Username=@username,Fname=@Fname,Lname=@Lname,Email=@Email,Password=pwdencrypt(@Password),year=@year
    WHERE StudentID=@ID
end
else
    begin
        UPDATE Student
        SET Username=@username,Fname=@Fname,Lname=@Lname,Email=@Email,year=@year
        WHERE StudentID=@ID
    end


INSERT INTO @new_record
select username ,Fname,Lname,Email,year
from Student
where StudentID=@ID

if(EXISTS(select Username from @prev_record EXCEPT Select username from @new_record))
begin
   set @Updated_Fields = @Updated_Fields+' Username'
end

if(EXISTS(select Email from @prev_record EXCEPT Select Email from @new_record))
begin
   set @Updated_Fields = @Updated_Fields+' Email'
end

if(EXISTS(select Fname from @prev_record EXCEPT Select Fname from @new_record))
begin
   set @Updated_Fields = @Updated_Fields+' Fname'
end

if(EXISTS(select Lname from @prev_record EXCEPT Select Lname from @new_record))
begin
   set @Updated_Fields = @Updated_Fields+' Lname'
end

if(EXISTS(select Year from @prev_record EXCEPT Select Year from @new_record))
begin
   set @Updated_Fields = @Updated_Fields+' Year'
end
if(@Done_By is not null)
    begin
        insert into Manage_Student(Admin_ID, Student_ID, Operation,Date)
        values (@Done_By,@ID,@Updated_Fields,sysdatetime())
    end
go

