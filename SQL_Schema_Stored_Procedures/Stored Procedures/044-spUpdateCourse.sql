CREATE procedure spUpdateCourse @ID int,@Course_Name varchar(50),@Description varchar(50),@Done_By int
AS

if(Exists(select * from course where Course_Name=@Course_Name and Course_ID <> @ID) )
    begin
        Throw 50000,'Repeated Course Name',1;
    end

DECLARE @prev_record Table(Course_Name varchar(50),Description varchar(50))
DECLARE @new_record Table(Course_Name varchar(50),Description varchar(50))

INSERT INTO @prev_record
select Course_Name,Description
from Course
where Course_ID=@ID

Declare @Updated_Fields varchar(100)='UPDATE'

UPDATE Course
SET Course_Name=@Course_Name,Description=@Description
WHERE Course_ID=@ID

INSERT INTO @new_record
select Course_Name,Description
from Course
where Course_ID=@ID

if(EXISTS(select Course_Name from @prev_record EXCEPT Select Course_Name from @new_record))
begin
   set @Updated_Fields = @Updated_Fields+' Name'
end

if(EXISTS(select Description from @prev_record EXCEPT Select Description from @new_record))
begin
   set @Updated_Fields = @Updated_Fields+' Description'
end

if(@Done_By is not null)
    begin
        insert into Manage_Course(Admin_ID, Course_ID, Operation,Date)
        values (@Done_By,@ID,@Updated_Fields,sysdatetime())
    end
go

