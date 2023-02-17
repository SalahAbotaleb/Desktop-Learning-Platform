CREATE procedure spSubmitAssignment @Submission_Link varchar(200),@Student_ID int,@Assignment_ID int
AS
if(dbo.fnReturnDate(GETDATE())>(select Deadline from Assignment where Assignment_ID=@Assignment_ID))
begin
    throw 50001,'You Passed The Deadline',1;
end
if(Exists(select * from Submits_Assignment where Assignment_ID=@Assignment_ID and Student_ID=@Student_ID))
begin
    Update Submits_Assignment
    SET Submission_Link=@Submission_Link
    where Student_ID=@Student_ID
end
else
begin
    Insert into Submits_Assignment(student_id, assignment_id, submission_link)
    values(@Student_ID,@Assignment_ID,@Submission_Link)
end
go

