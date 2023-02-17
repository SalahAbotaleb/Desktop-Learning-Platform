CREATE procedure spInsertAdmin @username varchar(50),@Fname varchar(50),@Lname varchar(50),@Email varchar(100),@added_by int,@password varchar(50)

AS
if(Exists(select * from Admin where Username=@username or Email=@Email))
    begin
        Throw 50000,'Repeated Username or Email',1;
    end
insert into admin(Username,fname,lname,Email,Super_ID,Password)
values (@username,@Fname,@Lname,@Email,(select Admin_ID from admin where Admin_ID=@added_by),PWDENCRYPT(@password))
go

