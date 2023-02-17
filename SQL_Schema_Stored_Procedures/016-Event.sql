create table Event
(
    Event_ID int identity
        primary key,
    Class_ID int          not null
        references Classroom
            on delete cascade,
    Title    varchar(300) not null,
    Date     date         not null
)
go

