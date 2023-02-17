create procedure spRemoveMaterial @Material_ID int
AS
    delete from material where Material_ID=@Material_ID
go

