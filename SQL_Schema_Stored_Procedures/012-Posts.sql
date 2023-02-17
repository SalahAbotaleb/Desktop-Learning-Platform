create table Posts
(
    Class_ID      int          not null
        references Classroom
            on delete cascade,
    Timestamp     datetime     not null,
    Title         varchar(100) not null,
    Announcement  varchar(500),
    Instructor_ID int
        references Instructor,
    primary key (Class_ID, Timestamp)
)
go

