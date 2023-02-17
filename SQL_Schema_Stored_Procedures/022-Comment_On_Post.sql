create table Comment_On_Post
(
    Class_ID         int      not null,
    Timestamp        datetime not null,
    Comment          varchar(200),
    Comment_Owner_ID int      not null
        check ([dbo].[fnCheckParticipant]([Comment_Owner_ID]) = 'True'),
    Date             date     not null,
    primary key (Class_ID, Timestamp, Comment_Owner_ID, Date),
    foreign key (Class_ID, Timestamp) references Posts
)
go

