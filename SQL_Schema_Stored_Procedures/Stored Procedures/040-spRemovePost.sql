create procedure spRemovePost @class_id int,@timestamp datetime
AS
    delete from posts where Class_ID=@class_id and Timestamp=@timestamp
go

