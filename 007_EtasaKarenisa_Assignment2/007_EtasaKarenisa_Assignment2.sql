CREATE TABLE customers_tb(
	customerNumber int PRIMARY KEY,
	customerName varchar(30),
	contactLastName varchar(10),
	contactFirstName varchar(10),
	phone varchar(12),
	addressLine1 varchar(20),
	addressLine2 varchar(20),
	city varchar(10),
	state varchar(10),
	postalCode varchar(5),
	country varchar(10),
	salesRepEmployeeNumber int,
	creditLimit varchar(10),
	FOREIGN KEY (salesRepEmployeeNumber) REFERENCES employees_tb(employeeNumber), 
);

INSERT INTO customers_tb(customerNumber, customerName, contactLastName, contactFirstName, phone, addressLine1, addressLine2, city, state, postalCode, country, salesRepEmployeeNumber, creditLimit)
VALUES ('001', 'Abi', 'Andria', 'Abi', '089082773647', 'Jl. A', 'No. 172', 'Surabaya', 'Indonesia', '61200', 'Indonesia', '01', '10000000');
INSERT INTO customers_tb(customerNumber, customerName, contactLastName, contactFirstName, phone, addressLine1, addressLine2, city, state, postalCode, country, salesRepEmployeeNumber, creditLimit)
VALUES ('002', 'Alfi', 'Andrian', 'Alfi', '089082773557', 'Jl. AB', 'No. 17', 'Sidoarjo', 'Indonesia', '61250', 'Indonesia', '02', '10000000');
INSERT INTO customers_tb(customerNumber, customerName, contactLastName, contactFirstName, phone, addressLine1, addressLine2, city, state, postalCode, country, salesRepEmployeeNumber, creditLimit)
VALUES ('003', 'Doni', 'Abisa', 'Doni', '089082883647', 'Jl. ACD', 'No. 12', 'Jakarta', 'Indonesia', '61220', 'Indonesia', '03', '30000000');
INSERT INTO customers_tb(customerNumber, customerName, contactLastName, contactFirstName, phone, addressLine1, addressLine2, city, state, postalCode, country, salesRepEmployeeNumber, creditLimit)
VALUES ('004', 'Dunu', 'Mukti', 'Dunu', '089032773647', 'Jl. AAA', 'No. 7', 'Bandung', 'Indonesia', '61210', 'Indonesia', '04', '10000000');
INSERT INTO customers_tb(customerNumber, customerName, contactLastName, contactFirstName, phone, addressLine1, addressLine2, city, state, postalCode, country, salesRepEmployeeNumber, creditLimit)
VALUES ('005', 'Anton', 'Amani', 'Anton', '089083273647', 'Jl. AA', 'No. 13', 'Semarang', 'Indonesia', '61240', 'Indonesia', '05', '10000000');

SELECT * FROM customers_tb INNER JOIN employees_tb ON customers_tb.customerNumber = employees_tb.employeeNumber;

CREATE TABLE products_tb(
	productCode int PRIMARY KEY,
	productName varchar(30),
	productLine int,
	FOREIGN KEY (productLine) REFERENCES product_lines_tb(productLine), 
	productScale int,
	productVendor varchar(10),
	productDescription varchar(30),
	quantityInStock int,
	buyPrice int,
	MSRP int,
);

INSERT INTO products_tb(productCode, productName, productLine, productScale, productVendor, productDescription, quantityInStock, buyPrice, MSRP)
VALUES ('551', 'Sabun Wajah', '101', '30', 'somethinc', 'Sabun wajah kulit kering', '10', '30000', '33000');
INSERT INTO products_tb(productCode, productName, productLine, productScale, productVendor, productDescription, quantityInStock, buyPrice, MSRP)
VALUES ('552', 'Handphone', '102', '300', 'xiaomi', 'Handphone edisi terkini', '5', '300000', '330000');
INSERT INTO products_tb(productCode, productName, productLine, productScale, productVendor, productDescription, quantityInStock, buyPrice, MSRP)
VALUES ('553', 'Tas', '103', '100', 'nevada', 'Tas ringan modern', '1', '50000','55000');
INSERT INTO products_tb(productCode, productName, productLine, productScale, productVendor, productDescription, quantityInStock, buyPrice, MSRP)
VALUES ('554', 'Coklat', '104', '50', 'silverq', 'Coklat manis', '30', '11000', '13000');
INSERT INTO products_tb(productCode, productName, productLine, productScale, productVendor, productDescription, quantityInStock, buyPrice, MSRP)
VALUES ('555', 'Paracetamol', '105', '5', 'sanmol', 'Obat sakit kepala', '30', '3000', '3000');

SELECT * FROM products_tb INNER JOIN product_lines_tb ON products_tb.productLine = product_lines_tb.productLine;

CREATE TABLE product_lines_tb(
	productLine int PRIMARY KEY,
	textDescription varchar(255) NOT NULL,
	htmlDescription varchar(255) NOT NULL, 
	imageProduct varchar(255) NOT NULL,
);

INSERT INTO product_lines_tb(productLine, textDescription, htmlDescription, imageProduct)
VALUES ('101', 'Makeup dan Skincare', 'MakeupDanSkincare', 'kosmetik.jpg');
INSERT INTO product_lines_tb(productLine, textDescription, htmlDescription, imageProduct)
VALUES ('102', 'Gadget', 'Gadget', 'gadget.jpg');
INSERT INTO product_lines_tb(productLine, textDescription, htmlDescription, imageProduct)
VALUES ('103', 'Aksesoris', 'Aksesoris', 'aksesoris.jpg');
INSERT INTO product_lines_tb(productLine, textDescription, htmlDescription, imageProduct)
VALUES ('104', 'Makanan', 'Makanan', 'makanan.jpg');
INSERT INTO product_lines_tb(productLine, textDescription, htmlDescription, imageProduct)
VALUES ('105', 'Obat', 'Obat', 'obat.jpg');

SELECT * FROM product_lines_tb;

CREATE TABLE orders_tb(
	orderNumber int PRIMARY KEY,
	orderDate Date,
	requiredDate Date,
	shippedDate Date,
	status varchar(10),
	comments varchar(10),
	customerNumber int,
	FOREIGN KEY (customerNumber) REFERENCES customers_tb(customerNumber), 
);

INSERT INTO orders_tb(orderNumber, orderDate, requiredDate, shippedDate, status, comments, customerNumber)
VALUES ('1010', '2021/10/08', '2021/10/11', '2021/10/09', 'shipped', '', '001');
INSERT INTO orders_tb(orderNumber, orderDate, requiredDate, shippedDate, status, comments, customerNumber)
VALUES ('1011', '2021/10/08', '2021/10/11', '2021/10/09', 'shipped', '', '002');
INSERT INTO orders_tb(orderNumber, orderDate, requiredDate, shippedDate, status, comments, customerNumber)
VALUES ('1012', '2021/10/08', '2021/10/11', '2021/10/09', 'shipped', '', '003');
INSERT INTO orders_tb(orderNumber, orderDate, requiredDate, shippedDate, status, comments, customerNumber)
VALUES ('1013', '2021/10/08', '2021/10/11', '2021/10/09', 'shipped', '', '004');
INSERT INTO orders_tb(orderNumber, orderDate, requiredDate, shippedDate, status, comments, customerNumber)
VALUES ('1014', '2021/10/08', '2021/10/11', '2021/10/09', 'shipped', '', '005');

SELECT * FROM orders_tb INNER JOIN customers_tb ON orders_tb.customerNumber = customers_tb.customerNumber ;

CREATE TABLE order_details_tb(
	orderNumber int UNIQUE,
	productCode int UNIQUE,
	quantityOrdered int,
	priceEach int,
	orderLineNumber int,
	FOREIGN KEY (orderNumber) REFERENCES orders_tb(orderNumber), 
	FOREIGN KEY (productCode) REFERENCES products_tb(productCode),  
);

INSERT INTO order_details_tb(orderNumber, productCode, quantityOrdered, priceEach, orderLineNumber)
VALUES ('1010','551','1','32000', '701');
INSERT INTO order_details_tb(orderNumber, productCode, quantityOrdered, priceEach, orderLineNumber)
VALUES ('1011','552','1','3200000', '702');
INSERT INTO order_details_tb(orderNumber, productCode, quantityOrdered, priceEach, orderLineNumber)
VALUES ('1012','553','1','53000', '703');
INSERT INTO order_details_tb(orderNumber, productCode, quantityOrdered, priceEach, orderLineNumber)
VALUES ('1013','554','1','12000', '704');
INSERT INTO order_details_tb(orderNumber, productCode, quantityOrdered, priceEach, orderLineNumber)
VALUES ('1014','555','1','3000', '705');

SELECT * FROM order_details_tb INNER JOIN orders_tb ON order_details_tb.orderNumber = orders_tb.orderNumber ;

CREATE TABLE payments_tb(
	customerNumber int UNIQUE,
	checkNumber int UNIQUE,
	paymentDate Date,
	amount int,
	FOREIGN KEY (customerNumber) REFERENCES customers_tb(customerNumber),
);

INSERT INTO payments_tb(customerNumber, checkNumber, paymentDate, amount)
VALUES ('001', '10001', '2021/10/08', '32000');
INSERT INTO payments_tb(customerNumber, checkNumber, paymentDate, amount)
VALUES ('002', '10002', '2021/10/08', '3200000');
INSERT INTO payments_tb(customerNumber, checkNumber, paymentDate, amount)
VALUES ('003', '10003', '2021/10/08', '53000');
INSERT INTO payments_tb(customerNumber, checkNumber, paymentDate, amount)
VALUES ('004', '10004', '2021/10/08', '12000');
INSERT INTO payments_tb(customerNumber, checkNumber, paymentDate, amount)
VALUES ('005', '10005', '2021/10/08', '3000');

SELECT * FROM payments_tb INNER JOIN customers_tb ON payments_tb.customerNumber = customers_tb.customerNumber ;

CREATE TABLE employees_tb(
	employeeNumber int PRIMARY KEY,
	lastName varchar(10),
	firstName varchar(10),
	extension int,
	email varchar(255),
	officeCode int, 
	reportsTo int, 
	jobTitle varchar(50),
	FOREIGN KEY (officeCode) REFERENCES offices_tb(officeCode), 
);

INSERT INTO employees_tb(employeeNumber, lastName, firstName, extension, email, officeCode, reportsTo, jobTitle)
VALUES ('01', 'Andria', 'Bagas', '111', 'bagas@gmail.com', '150', '', 'CS');
INSERT INTO employees_tb(employeeNumber, lastName, firstName, extension, email, officeCode, reportsTo, jobTitle)
VALUES ('02', 'Andrian', 'Agas', '112', 'agas@gmail.com', '160', '', 'CS');
INSERT INTO employees_tb(employeeNumber, lastName, firstName, extension, email, officeCode, reportsTo, jobTitle)
VALUES ('03', 'Alinski', 'Sari', '113', 'sari@gmail.com', '170', '', 'CS');
INSERT INTO employees_tb(employeeNumber, lastName, firstName, extension, email, officeCode, reportsTo, jobTitle)
VALUES ('04', 'Utomo', 'Bambang', '114', 'bambang@gmail.com', '180', '', 'CS');
INSERT INTO employees_tb(employeeNumber, lastName, firstName, extension, email, officeCode, reportsTo, jobTitle)
VALUES ('05', 'Sastro', 'Ani', '115', 'ani@gmail.com', '190', '', 'CS');

SELECT * FROM employees_tb INNER JOIN offices_tb ON employees_tb.officeCode = offices_tb.officeCode ;

CREATE TABLE offices_tb(
	officeCode int PRIMARY KEY,
	city varchar(10),
	phone varchar(12),
	addressLine1 varchar(20),
	addressLine2 varchar(20),
	state varchar(10),
	country varchar(10),
	postalCode varchar(5),
	territory varchar(10),
);

INSERT INTO offices_tb(officeCode, city, phone, addressLine1, addressLine2, state, country, postalCode, territory)
VALUES ('150', 'Surabaya', '0219090920', 'Jl. A', 'No. 50', 'Indonesia', 'Indonesia', '01019', 'Indonesia');
INSERT INTO offices_tb(officeCode, city, phone, addressLine1, addressLine2, state, country, postalCode, territory)
VALUES ('160', 'Sidoarjo', '0219090921', 'Jl. B', 'No. 51', 'Indonesia', 'Indonesia', '01029', 'Indonesia');
INSERT INTO offices_tb(officeCode, city, phone, addressLine1, addressLine2, state, country, postalCode, territory)
VALUES ('170', 'Jakarta', '0219090922', 'Jl. C', 'No. 60', 'Indonesia', 'Indonesia', '01039', 'Indonesia');
INSERT INTO offices_tb(officeCode, city, phone, addressLine1, addressLine2, state, country, postalCode, territory)
VALUES ('180', 'Bandung', '0219090923', 'Jl. D', 'No. 100', 'Indonesia', 'Indonesia', '01119', 'Indonesia');
INSERT INTO offices_tb(officeCode, city, phone, addressLine1, addressLine2, state, country, postalCode, territory)
VALUES ('190', 'Semarang', '0219090924', 'Jl. E', 'No. 80', 'Indonesia', 'Indonesia', '01419', 'Indonesia');

SELECT * FROM offices_tb; 
