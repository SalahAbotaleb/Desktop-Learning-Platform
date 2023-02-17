create function fnSecondsFromTime (@time as time)
returns int
as
begin
declare @total_seconds int
set @total_seconds =DATEPART(SECOND, @time) +60 * DATEPART(MINUTE, @time) + 3600 * DATEPART(HOUR, @time)
return @total_seconds
end
go

