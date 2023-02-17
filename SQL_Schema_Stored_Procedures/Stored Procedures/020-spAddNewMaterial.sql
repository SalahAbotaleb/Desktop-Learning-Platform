create procedure spAddNewMaterial @Class_ID int,@Link varchar(250),@Title varchar(100)
AS
    insert into Material(class_id, link, title)
    values(@Class_ID,@Link,@Title)
go

