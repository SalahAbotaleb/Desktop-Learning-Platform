create table Question_Options
(
    Answer_ID          int identity
        primary key,
    Question_ID        int          not null
        references Question,
    Answer_Description varchar(500) not null,
    IS_Answer          bit default 0
)
go

