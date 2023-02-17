CREATE procedure spInsertCourse @Course_Name varchar(50),@Description varchar(50),@Added_By int
AS
if(Exists(select * from Course where Course_Name=@Course_Name))
    begin
        Throw 50000,'Repeated Course Name',1;
    end
insert into Course(Description, Course_Name)
values (@Description,@Course_Name)
insert into Manage_Course(Admin_ID,Course_ID, Operation,Date)
values (@Added_By,@@identity,'Insert',sysdatetime())
go

