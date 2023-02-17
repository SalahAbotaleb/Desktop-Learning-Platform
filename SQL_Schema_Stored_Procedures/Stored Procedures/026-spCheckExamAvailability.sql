CREATE procedure spCheckExamAvailability @Exam_ID int
AS
    -- '2019-02-05 10:12:11' + CAST('15:30:00' AS datetime)
   if(EXISTS(select * from exam where Exam_ID=@Exam_ID and (Date + CAST(Duration AS datetime))>=dbo.fnReturnDate(GETDATE())
and (Date) <= dbo.fnReturnDate(GETDATE())))
    begin
        Throw 50001,'Enter',1;
    end
    else
        begin
            Throw 50002,'Exceeded exam time',1;
        end
go

