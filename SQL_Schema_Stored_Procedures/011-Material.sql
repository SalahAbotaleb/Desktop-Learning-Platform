create table Material
(
    Material_ID int identity
        constraint Material_pk
            primary key,
    Class_ID    int          not null
        references Classroom
            on delete cascade,
    Link        varchar(250) not null,
    Title       varchar(100)
)
go

