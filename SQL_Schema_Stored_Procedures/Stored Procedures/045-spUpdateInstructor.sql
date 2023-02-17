CREATE procedure spUpdateInstructor @ID int,@username varchar(50),@Fname varchar(50),@Lname varchar(50),@Email varchar(100),@Title varchar(50),@Password varchar(50)=null,@Done_By int = null
AS

if(Exists(select username from Instructor where (Username=@username or Email=@Email) and Instructor_ID <> @ID) )
    begin
        Throw 50000,'Repeated Username or Email',1;
    end

DECLARE @prev_record Table(username varchar(50),Fname varchar(50),Lname varchar(50),Email varchar(100),Title varchar(50))
DECLARE @new_record Table(username varchar(50),Fname varchar(50),Lname varchar(50),Email varchar(100),Title varchar(50))

INSERT INTO @prev_record
select username ,Fname,Lname,Email,Title
from Instructor
where Instructor_ID=@ID

Declare @Updated_Fields varchar(100)='UPDATE'

if(Exists(select * from Instructor where pwdcompare(@Password,Password)=0 and Instructor_ID=@ID and Password is not null))
begin
    set @Updated_Fields=@Updated_Fields+' Password'
    UPDATE Instructor
    SET Username=@username,Fname=@Fname,Lname=@Lname,Email=@Email,Password=pwdencrypt(@Password),Title=@Title
    WHERE Instructor_ID=@ID
end
else
begin
    UPDATE Instructor
    SET Username=@username,Fname=@Fname,Lname=@Lname,Email=@Email,Title=@Title
    WHERE Instructor_ID=@ID
end



INSERT INTO @new_record
select username ,Fname,Lname,Email,Title
from Instructor
where Instructor_ID=@ID

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

if(EXISTS(select Title from @prev_record EXCEPT Select Title from @new_record))
begin
   set @Updated_Fields = @Updated_Fields+' Title'
end

if(@Done_By is not null)
    begin
        insert into Manage_Instructor(Admin_ID, Instructor_ID, Operation,Date)
        values (@Done_By,@ID,@Updated_Fields,sysdatetime())
    end
go

