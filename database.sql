create database InventoryManagementSystem;
use InventoryManagementSystem;

create table Categories (
	categoryId int primary key auto_increment not null,
    categoryname varchar(100) not null
);

create table Customers (
	customerId int primary key not null auto_increment,
    customerName varchar(100) not null,
    customerPhone varchar(10) not null
);

create table Invoice_counter(
	id int primary key not null auto_increment,
    last_invoice_number int not null
);

create table Orders(
	orderId int auto_increment not null primary key,
    orderDate datetime not null,
    productId int not null,
	customerId int not null,
    productName varchar(100) not null,
    qty int not null,
    price int not null,
    tPrice int not null,
    
    foreign key(productId)
    references Products(productId),
    
    foreign key(customerId)
    references Customer(customerId)
);


create table Products(
	productId int not null primary key,
	productName varchar(100) not null,
	productQuantity int not null,
	productPrice int not null,
    productDescription varchar(100),
    productCategory varchar(100) not null
);

create table TempOrders(
	temorderId int not null auto_increment,
    orderId int not null,
    temorderDate datetime not null,
    temproductId int not null,
    temcustomerId int not null ,
	temproductName varchar(100) not null,
    temqty int not null,
    temprice int not null,
    temtPrice int not null
);

create table Users(
	username varchar(100) primary key not null,
    fullname varchar(100),
    password varchar(100) not null,
    phone varchar(10)
);