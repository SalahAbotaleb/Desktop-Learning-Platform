create table Question
(
    Question_ID      int identity
        primary key,
    Topic            varchar(50)   not null,
    Course_ID        int           not null,
    Points           int           not null,
    Difficulty_Level int,
    Description      varchar(1000) not null,
    foreign key (Course_ID, Topic) references Course_Topics
        on update cascade on delete cascade
)
go

