CREATE DATABASE RentCar

GO

USE RentCar

GO

CREATE TABLE MsCustomer(
	customer_id Nvarchar(36) PRIMARY KEY,
	email Nvarchar(100),
	password Nvarchar(100),
	name Nvarchar(100),
	phone_number Nvarchar(50),
	address Nvarchar(500),
	driver_license_number Nvarchar(100)
)

GO

CREATE TABLE MsCar(
	car_id Nvarchar(36) PRIMARY KEY,
	name Nvarchar(200),
	model Nvarchar(100),
	year int,
	license_plate Nvarchar(50),
	number_of_car_seats int,
	transmission Nvarchar(100),
	price_per_day decimal(10,2),
	status bit

)
GO

CREATE TABLE MsCarImages(
	image_car_id Nvarchar(36) PRIMARY KEY,
	car_id Nvarchar(36),
	image_link Nvarchar(2000),
	FOREIGN KEY (car_id) REFERENCES MsCar(car_id)
)

GO

CREATE TABLE MsEmployee(
	employee_id Nvarchar(36) PRIMARY KEY,
	name Nvarchar(200),
	position Nvarchar(4000),
	email NVARCHAR(100),
	phone_number Nvarchar(36)
)

GO

CREATE TABLE TrMaintenance(
	 maintenance_id Nvarchar(36) PRIMARY KEY,
	 maintenance_date datetime2(2),
	 description Nvarchar(400),
	 cost decimal(10,2),
	 car_id Nvarchar(36),
	 employee_id Nvarchar(36),
	 FOREIGN KEY (car_id) REFERENCES MsCar(Car_id),
	 FOREIGN KEY (employee_id) REFERENCES MsEmployee(Employee_id)
)

GO

CREATE TABLE TrRental (
    rental_id NVARCHAR(36) PRIMARY KEY,
    rental_date DATETIME2(2),
    return_date DATETIME2(2),
    total_price DECIMAL(10, 2),
    payment_status BIT,
    customer_id NVARCHAR(36),
    car_id NVARCHAR(36),
    FOREIGN KEY (customer_id) REFERENCES MsCustomer(customer_id),
    FOREIGN KEY (car_id) REFERENCES MsCar(car_id)
);

GO

CREATE TABLE LtPayment (
	payment_id NVARCHAR(36) PRIMARY KEY,
	payment_date datetime2(2),
	amount decimal(10,2),
	payment_method NVARCHAR(100),
    rental_id NVARCHAR(36),
    FOREIGN KEY (rental_id) REFERENCES TrRental(rental_id) 
);
GO
INSERT INTO MsCar (car_id, name, model, year, license_plate, number_of_car_seats, transmission, price_per_day, status)
VALUES ('car_002', 'Toyota Calya', 'Calya', 2021, 'AB1981XYa', 7, 'Manual', 351230.00, 1);
GO
SELECT * FROM MsCar


