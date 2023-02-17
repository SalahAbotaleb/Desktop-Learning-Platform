create table Assignment
(
    Assignment_ID int identity
        primary key,
    Deadline      datetime,
    Description   varchar(500),
    Class_ID      int
        references Classroom
            on delete cascade,
    Total_Grade   int not null,
    Title         varchar(300)
)
go

