use master;
drop database Music;
create database Music;
go

use Music;

create table Concert ( ConcertID int identity(1,1) constraint PK_ConcertID primary key,
						[Group] nvarchar(max),
						ConcertDate datetime,
						DayOfWeak  as DATEPART(dw, ConcertDate),
						TicketsVIPZone int default(0),
						TicketsFanZone int default(0),
						TicketsDanceZone int default(0),
						TicketsTribuneZone int default(0))


insert into Concert
		values ('Scorpions', '12-12-2019', 100, 400, 10000, 50000),
			   ('Vasya', '10-02-2020', 0, 10, 0, 0),
			   ('LP', '11-01-2020', 40, 160, 0, 0)