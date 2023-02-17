create table Exam_Taken
(
    Student_ID int not null
        constraint Exam_Taken_Student_Student_ID_fk
            references Student
            on delete cascade,
    Exam_ID    int not null
        constraint Exam_Taken_Exam_Exam_ID_fk
            references Exam
            on delete cascade,
    Grade      int,
    constraint Exam_Taken_pk
        primary key (Student_ID, Exam_ID)
)
go

