create database lab
go
use lab
go

create table Items
(
	ItemID char(8),
	ItemName varchar(500),
	Size int,
	primary key(ItemID)
)
go

create table Agents
(
	AgentID char(8),
	AgentName varchar(500),
	Address varchar(500),
	primary key(AgentID)
)
go

create table Orders
(
	OrderID char(8),
	OrderDate date,
	AgentID char(8),
	primary key(OrderID),
	foreign key(AgentID) references Agents(AgentID)
)
go

create table OrderDetail
(
	ID char(8),
	OrderID char(8),
	ItemID char(8),
	Quantity int,
	UnitAmount int,
	primary key(ID),
	foreign key(OrderID) references Orders(OrderID),
	foreign key(ItemID) references Items(ItemID)
)
go

create table ProvinceList
(
	ProvinceID int identity,
    Province nvarchar(500) unique,
	primary key(ProvinceID)
)
go

create table DataLogin
(
	UserName char(500),
	UserPassword char(500),
	FullName varchar(500),
	DateOfBirth datetime,
	PhoneNumber char(10),
	Province nvarchar(500),
	primary key(UserName),
	foreign key(Province) references ProvinceList(Province)
)
go

insert into Items (ItemID, ItemName, Size) values
('I101', 'Laptop HP', 14),
  ('I102', 'Smartphone Xiaomi', 6),
  ('I103', 'Tablet Samsung', 11),
  ('I104', 'TV LG', 50),
  ('I105', 'Refrigerator Samsung', 400),
  ('I106', 'Washing Machine LG', 7),
  ('I107', 'Air Fryer Philips', 2),
  ('I108', 'Juicer Hamilton Beach', 0),
  ('I109', 'Coffee Maker Keurig', 0),
  ('I110', 'Blu-ray Player Sony', 1),
  ('I111', 'Soundbar Yamaha', 20),
  ('I112', 'Gaming Laptop Acer', 15),
  ('I113', 'Wireless Earbuds Jabra', 0),
  ('I114', 'Desktop Computer Lenovo', 22),
  ('I115', 'Smart TV TCL', 65),
  ('I116', 'Robot Vacuum Cleaner iRobot', 2),
  ('I117', 'Electric Toothbrush Oral-B', 0),
  ('I118', 'Hair Dryer Conair', 9),
  ('I119', 'Air Purifier Coway', 12),
  ('I120', 'Electric Kettle Cuisinart', 1);
go

insert into Agents (AgentID, AgentName, Address) values
('A121', 'Nguyen Van A', '123 Nguyen Hue, Quan 1, TP Ho Chi Minh'),
  ('A122', 'Tran Thi B', '456 Tran Phu, Quan Hai Chau, TP Da Nang'),
  ('A123', 'Le Van C', '789 Le Loi, Quan 1, TP Ho Chi Minh'),
  ('A124', 'Pham Thi D', '1011 Nguyen Trai, Quan 5, TP Ho Chi Minh'),
  ('A125', 'Vu Duc E', '1213 Nguyen Dinh Chieu, Quan 3, TP Ho Chi Minh'),
  ('A126', 'Hoang Thi F', '1415 Le Duan, Quan 1, TP Ha Noi'),
  ('A127', 'Tran Van G', '1617 Tran Hung Dao, Quan 5, TP Ho Chi Minh'),
  ('A128', 'Nguyen Thi H', '1819 Ton That Thuyet, Quan Cau Giay, TP Ha Noi'),
  ('A129', 'Bui Minh I', '2021 Hoang Van Thu, Quan Tan Binh, TP Ho Chi Minh'),
  ('A130', 'Doan Thi K', '2223 Bach Dang, Quan Hai Chau, TP Da Nang'),
  ('A131', 'Nguyen Van L', '2425 Le Lai, Quan 1, TP Ho Chi Minh'),
  ('A132', 'Tran Thi M', '2627 Vo Van Kiet, Quan 5, TP Ho Chi Minh'),
  ('A133', 'Le Van N', '2829 Duong 3 Thang 2, Quan 10, TP Ho Chi Minh'),
  ('A134', 'Pham Thi O', '3031 Dien Bien Phu, Quan 3, TP Ho Chi Minh'),
  ('A135', 'Vu Duc P', '3233 Tran Quoc Toan, Quan 3, TP Ho Chi Minh'),
  ('A136', 'Hoang Thi Q', '3435 Cao Thang, Quan 3, TP Ho Chi Minh'),
  ('A137', 'Tran Van R', '3637 Phan Dinh Phung, Quan Phu Nhuan, TP Ho Chi Minh'),
  ('A138', 'Nguyen Thi S', '3839 Dinh Tien Hoang, Quan 1, TP Ha Noi'),
  ('A139', 'Bui Minh T', '4041 Le Quy Don, Quan 3, TP Ho Chi Minh'),
  ('A140', 'Doan Thi U', '4243 Nguyen Thi Minh Khai, Quan 1, TP Ho Chi Minh');
go

insert into Orders (OrderID, OrderDate, AgentID) values
('01001', '2022-10-01', 'A121'),
('01002', '2022-11-05', 'A122'),
('01003', '2022-12-02', 'A123'),
('01004', '2023-01-10', 'A124'),
('01005', '2023-02-15', 'A125'),
('01006', '2023-03-20', 'A126'),
('01007', '2023-04-01', 'A127'),
('01008', '2023-05-05', 'A128'),
('01009', '2023-06-10', 'A129'),
('01010', '2023-07-15', 'A130'),
('01011', '2023-08-20', 'A131'),
('01012', '2023-09-01', 'A132'),
('01013', '2023-10-05', 'A133'),
('01014', '2023-11-10', 'A134'),
('01015', '2023-12-15', 'A135'),
('01016', '2024-01-20', 'A136'),
('01017', '2024-02-01', 'A137'),
('01018', '2024-03-05', 'A138'),
('01019', '2024-04-10', 'A139'),
('01020', '2024-05-15', 'A140');
go

insert into OrderDetail (ID, OrderID, ItemID, Quantity, UnitAmount) values
('OD001', '01001', 'I101', 2, 15000000),
('OD002', '01001', 'I102', 3, 10000000),
('OD003', '01002', 'I103', 1, 12000000),
('OD004', '01002', 'I104', 1, 25000000),
('OD005', '01003', 'I105', 2, 7000000),
('OD006', '01003', 'I106', 1, 11000000),
('OD007', '01004', 'I107', 1, 5000000),
('OD008', '01004', 'I108', 2, 2000000),
('OD009', '01005', 'I109', 1, 3000000),
('OD010', '01005', 'I110', 3, 12000000),
('OD011', '01006', 'I111', 1, 15000000),
('OD012', '01006', 'I112', 1, 6000000),
('OD013', '01007', 'I113', 2, 4000000),
('OD014', '01007', 'I114', 1, 1500000),
('OD015', '01008', 'I115', 1, 20000000),
('OD016', '01008', 'I116', 1, 50000000),
('OD017', '01009', 'I117', 2, 8000000),
('OD018', '01009', 'I118', 1, 3000000),
('OD019', '01010', 'I119', 1, 10000000),
('OD020', '01010', 'I120', 2, 6000000);
go

insert into ProvinceList(Province) VALUES
(N'Hà Nội'),
(N'Hồ Chí Minh'),
(N'Hải Phòng'),
(N'Cần Thơ'),
(N'Đà Nẵng'),
(N'An Giang'),
(N'Bà Rịa-Vũng Tàu'),
(N'Bắc Giang'),
(N'Bắc Kạn'),
(N'Bạc Liêu'),
(N'Bắc Ninh'),
(N'Bến Tre'),
(N'Bình Định'),
(N'Bình Dương'),
(N'Bình Phước'),
(N'Bình Thuận'),
(N'Cà Mau'),
(N'Cao Bằng'),
(N'Đắk Lắk'),
(N'Đắk Nông'),
(N'Điện Biên'),
(N'Đồng Nai'),
(N'Đồng Tháp'),
(N'Gia Lai'),
(N'Hà Giang'),
(N'Hà Nam'),
(N'Hà Tĩnh'),
(N'Hải Dương'),
(N'Hậu Giang'),
(N'Hòa Bình'),
(N'Hưng Yên'),
(N'Khánh Hòa'),
(N'Kiên Giang'),
(N'Kon Tum'),
(N'Lai Châu'),
(N'Lâm Đồng'),
(N'Lạng Sơn'),
(N'Lào Cai'),
(N'Long An'),
(N'Nam Định'),
(N'Nghệ An'),
(N'Ninh Bình'),
(N'Ninh Thuận'),
(N'Phú Thọ'),
(N'Quảng Bình'),
(N'Quảng Nam'),
(N'Quảng Ngãi'),
(N'Quảng Ninh'),
(N'Quảng Trị'),
(N'Sóc Trăng'),
(N'Sơn La'),
(N'Tây Ninh'),
(N'Thái Bình'),
(N'Thái Nguyên'),
(N'Thanh Hóa'),
(N'Thừa Thiên Huế'),
(N'Tiền Giang'),
(N'Trà Vinh'),
(N'Tuyên Quang'),
(N'Vĩnh Long'),
(N'Vĩnh Phúc'),
(N'Yên Bái');
go

INSERT INTO DataLogin (UserName, UserPassword, FullName, DateOfBirth, PhoneNumber, Province) VALUES
('user2', '00002', 'Hoang Anh', '2002-05-28', '123456789', N'Hà Nội'),
('user3', '00003', 'Van An', '1999-12-01', '987654321', N'Hồ Chí Minh'),
('user4', '00004', 'Bao Trung', '1995-09-10', '012345678', N'Đà Nẵng'),
('user5', '00005', 'Tran Tuan', '1998-03-20', '111222333', N'Cần Thơ'),
('user6', '00006', 'Ngoc Lan', '2001-07-15', '555666777', N'An Giang'),
('user7', '00007', 'Minh Thu', '1994-02-02', '333444555', N'Bắc Ninh'),
('user8', '00008', 'Dinh Thien', '1996-10-30', '444555666', N'Bình Dương'),
('user9', '00009', 'Tien Dat', '2000-08-08', '777888999', N'Đắk Lắk'),
('user10', '00010', 'Anh Tuan', '1997-06-25', '222333444', N'Hải Phòng'),
('user11', '00011', 'Thanh Thuy', '1993-04-12', '888999000', N'Kiên Giang');
go
create procedure InsertItem
    @ItemName varchar(500),
    @Size int
as
begin
    declare @NewItemID char(8)
	declare @MaxID varchar(500)
	select @MaxID = cast(max(cast(substring(ItemID, 2, 8) as int)) + 1 as varchar) from Items
	while (len(@MaxID) < 3)
	begin
		set @MaxID = '0' + @MaxID
	end
    select @NewItemID = 'I' + @MaxID
    insert into Items (ItemID, ItemName, Size) values (@NewItemID, @ItemName, @Size)
end
go


create procedure InsertAgent
    @AgentName varchar(500),
    @Address varchar(500)
as
begin
    declare @NewAgentID char(8)
	declare @MaxID varchar(500)
	select @MaxID = cast(max(cast(substring(AgentID, 2, 8) as int)) + 1 as varchar) from Agents
	while (len(@MaxID) < 3)
	begin
		set @MaxID = '0' + @MaxID
	end
    select @NewAgentID = 'A' + @MaxID
    insert into Agents (AgentID, AgentName, Address) values (@NewAgentID, @AgentName, @Address)
end
go
select * from Items
select * from Agents
select * from Orders
select * from OrderDetail
select * from ProvinceList
select * from DataLogin
go

