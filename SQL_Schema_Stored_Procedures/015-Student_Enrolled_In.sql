create table Student_Enrolled_In
(
    Class_ID   int not null
        constraint Student_Enrolled_In_Classroom_Class_ID_fk
            references Classroom
            on delete cascade,
    Student_ID int not null
        constraint Student_Enrolled_In_Student_StudentID_fk
            references Student
            on delete cascade,
    constraint Student_Enrolled_In_pk
        primary key (Class_ID, Student_ID)
)
go

