create table Teaches
(
    Instructor_ID int not null
        constraint Teaches_Instructor_Instructor_ID_fk
            references Instructor
            on delete cascade,
    Class_ID      int not null
        constraint Teaches_Classroom_Class_ID_fk
            references Classroom
            on update cascade on delete cascade,
    constraint Teaches_pk
        primary key (Instructor_ID, Class_ID)
)
go

