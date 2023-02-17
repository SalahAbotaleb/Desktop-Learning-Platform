create procedure spAddNewPost @Title int,@Announcement varchar(500),@Owner_ID int,@Class_ID int
AS
    insert into Posts(Class_ID, Timestamp, Title, Announcement, Instructor_ID)
    values (@Class_ID,getdate(),@Title,@Announcement,@Owner_ID)
go

