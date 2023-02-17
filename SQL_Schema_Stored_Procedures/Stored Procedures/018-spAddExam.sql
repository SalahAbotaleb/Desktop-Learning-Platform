CREATE procedure spAddExam @Marks int,@Date datetime,@Duration time,@Class_ID int,@Title varchar(300)
AS
    insert into Exam(Marks, Date, Duration, Class_ID,Title)
    values (@Marks,@Date,@Duration,@Class_ID,@Title)
    insert into Event(Class_ID, Title, Date)
    values(@Class_ID,@Title,@Date)
go

