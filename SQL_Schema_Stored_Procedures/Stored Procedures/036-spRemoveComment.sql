create procedure spRemoveComment @class_id int,@timestamp datetime,@Comment_Owner_ID int,@Date Date
AS
delete from Comment_On_Post where Class_ID=@class_id and timestamp=@timestamp and Comment_Owner_ID=@Comment_Owner_ID and Date=@Date
go

