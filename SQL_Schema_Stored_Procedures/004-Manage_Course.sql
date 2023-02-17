create table Manage_Course
(
    Admin_ID  int          not null
        references Admin,
    Course_ID int          not null
        references Course,
    Operation varchar(100) not null,
    Date      datetime     not null,
    primary key (Admin_ID, Course_ID, Operation, Date)
)
go

