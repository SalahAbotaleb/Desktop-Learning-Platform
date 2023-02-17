create table Course_Topics
(
    Course_ID int         not null
        constraint Course_Topics_Course_cou_fk
            references Course
            on update cascade on delete cascade,
    Topic     varchar(50) not null,
    constraint Course_Topics_pk
        primary key (Course_ID, Topic)
)
go

