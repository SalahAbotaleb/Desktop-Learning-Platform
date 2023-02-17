create procedure spExamTaken @Student_ID int,@Exam_ID int,@Grade int
As
    insert into Exam_Taken(Student_ID, Exam_ID, Grade)
    values(@Student_ID,@Exam_ID,@Grade)
go

