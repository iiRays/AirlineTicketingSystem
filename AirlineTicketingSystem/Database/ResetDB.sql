DROP TABLE STOP;
DROP TABLE TICKET;
DROP TABLE BOOKING;
DROP TABLE FLIGHT;
DROP TABLE ROUTE;
DROP TABLE [USER];
DROP TABLE CITY;
DROP TABLE PLANE;

/* Tables with no foreign keys */

create table Plane(
	PlaneID varchar(10) not null primary key,
	Model varchar(30) not null,
	Manufacturer varchar(25) not null,
	Capacity integer not null,
	MaxColumns integer not null
);

create table City(
	CityID varchar(10) not null primary key,
	Name varchar(25) not null,
	Country varchar(35) not null,
	State varchar(30) not null,
	Longitude varchar(15) not null,
	Latitude varchar(15) not null
);

create table [User](
	UserID varchar(10) not null primary key,
	Name varchar(30) not null,
	Password VARCHAR(100),
	PasswordSalt VARCHAR(100),
	Gender character,
	Email varchar(35) not null,
	IsRegistered bit not null,
	DateOfBirth date,
	PhoneNo varchar(12),
	CreditCardNo varchar(20),
	Country varchar(35),
	City varchar(25),
	IsStaff bit not null
);

create table Route(
	RouteID varchar(10) not null primary key,
	DurationHour integer not null,
	DurationMins integer not null,
);

/* Tables with Foreign Keys */

create table Flight(
	FlightID varchar(10) not null primary key,
	RouteID varchar(10) foreign key references route(RouteID),
	PlaneID varchar(10) foreign key references plane(PlaneID),
	FlightNo varchar(10) not null,
	DepartureTime datetime not null,
	ArrivalTime datetime not null,
	Price decimal(7,2) not null,
	IsDaily bit not null,
	IsFlightInstance bit not null
);


create table Booking(
	BookingID varchar(10) not null primary key,
	UserID varchar(10) foreign key references [USER](UserID),
	FlightID varchar(10) foreign key references flight(FlightID),
	NoOfPassengers integer not null,
	TotalPrice decimal(8,2) not null,
	PaymentDate datetime not null,
CreditCardNo varchar(20),
	IsCancelled bit not null,
	ExtraBaggageKG integer not null
);

create table Ticket(
	TicketID varchar(10) not null primary key,
	BookingID varchar(10) foreign key references booking(BookingID),
	Name varchar(30) not null,
	Seat varchar(5) not null
);

/* Tables with Composite Keys */

create table Stop(
	RouteID varchar(10) foreign key references route(RouteID),
	CityID varchar(10) foreign key references city(CityID),
	IsOrigin bit not null,

	primary key(RouteID, CityID)
);
	

/* Dummy data (note: some data is not accurate in real world scenarios such as airplane model and their capacity)*/
insert into plane values ('P000000001', '737-800', 'Boeing', 192, 6);
insert into plane values ('P000000002', '737-300', 'Boeing', 150, 6);
insert into plane values ('P000000003', 'A320', 'Airbus', 150, 6);

insert into city values ('C000000001', 'Kuala Lumpur', 'Malaysia', 'Wilayah Persekutuan', 101.6869, 3.1390);
insert into city values ('C000000002', 'Kota Kinabalu', 'Malaysia', 'Sabah', 116.0735, 5.9804);

insert into route values ('R000000001', 1, 30);
insert into route values ('R000000002', 1, 30);

insert into flight values ('F000000001', 'R000000001', 'P000000001', 'MH001', '20200618 01:00 PM', '20200618 02:30 PM', 200.00, 0, 0);
insert into flight values ('F000000002', 'R000000002', 'P000000002','MH002', '20200708 06:00 PM', '20200708 07:30 PM', 200.00, 1, 0);

insert into stop values ('R000000001', 'C000000001', 1);
insert into stop values ('R000000001', 'C000000002', 0);

insert into stop values ('R000000002', 'C000000002', 1);
insert into stop values ('R000000002', 'C000000001', 0);




