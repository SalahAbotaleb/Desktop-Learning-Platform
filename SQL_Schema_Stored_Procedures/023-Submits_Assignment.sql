create table Submits_Assignment
(
    Student_ID       int          not null
        references Student
            on delete cascade,
    Assignment_ID    int          not null
        references Assignment
            on delete cascade,
    Submission_Link  varchar(200) not null,
    Assignment_Grade int,
    primary key (Student_ID, Assignment_ID)
)
go

