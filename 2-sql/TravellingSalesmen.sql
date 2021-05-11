create table Salesmen
(
	id int identity primary key,
	salesmanName nvarchar(100) not null,
	phoneNumber nvarchar(20) 
);

create table Products
(
	productName nvarchar(100) primary key not null
);

create table SalesRoutes
(
	routeName nvarchar(1000) primary key not null
);

create table SalesmanProducts
(
	id int identity primary key,
	productName nvarchar(100) references Products(productName),
	salesmanId int references Salesmen(id)
);

create table SalesmanRoutes
(
	id int identity primary key,
	salesmanId int references Salesmen(id),
	routeName nvarchar(100) references SalesRoutes(routeName)
);

insert into Salesmen(salesmanName, phoneNumber) values
('Bob The Builder', '510-BUI-LDIT'), ('Fred Belotte', '415-HEY-FRED'), ('Nick Enscalada', '888-GET-COFI'),
('Pushpinder Kaur','213-TRA-INER'), ('Mark "Less is" Moore','635-SLI-DES!'), ('Jacob Davis','415-SEA-HAWK'),
('Marielle The Martian', '510-FLY-MARS');

insert into Products(productName) values
('hammer'), ('nails'), ('screws'), ('pizza'), ('coffee'), ('espresso'), ('latte'),
('cookies'), ('cakes'), ('books'), ('tea'), ('hot chocolate');

insert into SalesRoutes(routeName) values
('SFO'), ('LAX'), ('DFW'), ('IAH'), ('SAT'), ('DAL'), ('AUS'), ('TPA'), ('SEA'), ('STL'), ('OAK'), ('MNL');

insert into SalesmanProducts(productName, salesmanId) values
('hammer', 1), ('nails', 1), ('screws', 1), ('pizza', 2), ('coffee', 3), ('espresso', 3), ('latte', 3),
('cookies', 4), ('cakes', 4), ('books', 5), ('coffee', 6), ('espresso', 6), ('latte', 6), ('coffee', 7),
('tea', 7), ('hot chocolate', 7);

insert into SalesmanRoutes(salesmanId, routeName) values
(1, 'SFO'), (1, 'LAX'), (2, 'DFW'), (2, 'IAH'), (2, 'SAT'), (3, 'DAL'), (3, 'IAH'), (3, 'AUS'),
(4, 'TPA'), (4, 'DFW'), (4, 'DAL'), (5, 'DFW'), (6, 'SEA'), (6, 'STL'), (6, 'IAH'),
(7, 'OAK'), (7, 'SFO'), (7, 'MNL'), (7, 'DAL');

Select * from SalesmanRoutes;