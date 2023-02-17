CREATE FUNCTION fnReturnDate( @dFecha as datetime)
returns DATETIME
as
begin
DECLARE @D AS datetimeoffset
SET @D = CONVERT(datetimeoffset, @Dfecha) AT TIME ZONE 'Egypt Standard Time'
RETURN CONVERT(datetime, @D);
end
go

