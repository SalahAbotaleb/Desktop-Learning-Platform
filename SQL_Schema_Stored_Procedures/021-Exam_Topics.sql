create table Exam_Topics
(
    Exam_ID   int         not null
        references Exam
            on delete cascade,
    Topic     varchar(50) not null,
    Course_ID int,
    primary key (Exam_ID, Topic),
    foreign key (Course_ID, Topic) references Course_Topics
        on update cascade on delete cascade
)
go

