create procedure spAddQuestionOption @Question_ID int,@Option varchar(500),@IsAnswer BIT=0
AS
    insert into Question_Options(question_id, answer_description,IS_Answer)
    values (@Question_ID,@Option,@IsAnswer)
go

