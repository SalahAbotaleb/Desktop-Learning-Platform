create procedure spAddQuestionToExam @Exam_ID int,@Question_ID int
AS
    insert into Exam_Questions(Exam_ID, Question_ID)
    values(@Exam_ID,@Question_ID)
    select Topic from Question where Question_ID=@Question_ID
    if(NOT EXISTS(select Exam_Topics.Topic from Exam_Topics where Exam_Topics.Exam_ID=@Exam_ID and (Exam_Topics.Topic IN (select Question.Topic from Question where Question_ID=@Question_ID))))
    begin
        Declare @Topic_Course Table(Topic varchar(50),Course_ID int)
        Insert into @Topic_Course
        select Question.Topic,Question.Course_ID from Question where Question_ID=@Question_ID

        insert into Exam_Topics(Exam_ID, Topic, Course_ID)
        VALUES(@Exam_ID,(select Topic from @Topic_Course),(select Course_ID from @Topic_Course))
    end
go

