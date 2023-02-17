create table Exam_Questions
(
    Exam_ID     int not null
        references Exam
            on delete cascade,
    Question_ID int not null
        references Question,
    IS_Answer   bit default 0,
    primary key (Exam_ID, Question_ID)
)
go

