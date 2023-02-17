create table Exam
(
    Exam_ID  int identity
        primary key,
    Marks    int      not null,
    Date     datetime not null,
    Duration time     not null,
    Class_ID int      not null
        references Classroom
            on delete cascade,
    Title    varchar(300)
)
go

