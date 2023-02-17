create procedure spCommentOnPost @class_id int,@timestamp datetime,@Comment_Owner_ID int,@comment varchar(200)
AS
    insert into Comment_On_Post(class_id, timestamp, comment, comment_owner_id, date)
    values(@class_id,@timestamp,@comment,@Comment_Owner_ID,getdate())
go

