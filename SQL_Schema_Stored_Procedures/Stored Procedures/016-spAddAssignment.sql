create procedure spAddAssignment @Deadline datetime,@Description varchar(500),@Class_ID int,@Title varchar(300),@Total_Grade int
AS
insert into Assignment(deadline, description, class_id, total_grade, title)
values(@Deadline,@Description,@Class_ID,@Total_Grade,@Title)
insert into Event(class_id, title, date)
values (@Class_ID,@Title,@Deadline)
go

