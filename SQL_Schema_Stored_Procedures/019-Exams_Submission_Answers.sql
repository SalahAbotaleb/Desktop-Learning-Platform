create table Exams_Submission_Answers
(
    Question_ID int
        references Question,
    Exam_ID     int
        references Exam,
    Student_ID  int
        references Student,
    Is_Correct  bit
)
go

