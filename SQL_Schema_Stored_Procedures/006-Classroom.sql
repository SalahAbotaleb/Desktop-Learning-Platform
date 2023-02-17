create table Classroom
(
    Class_ID        int identity
        constraint Classroom_pk
            primary key,
    Access_code     varchar(50) not null
        constraint Classroom_pk2
            unique,
    Title           varchar(50) not null,
    Course_ID       int         not null
        constraint Classroom_Course_Course_ID_fk
            references Course,
    Created_by      int         not null
        constraint Classrom_Instructor_Instructor_ID_fk
            references Instructor
            on update cascade,
    Date_created_at date        not null
)
go

