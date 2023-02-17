CREATE procedure spAddQuestion @Topic varchar(50),@Classroom_ID int,@Points int,@Difficulty_level int,@Description varchar(1000)
AS
insert into Question(topic, course_id, points, difficulty_level, description)
values (@topic,(select Course_ID from Classroom where Class_ID=@Classroom_ID),@points,@Difficulty_level,@Description)
go

