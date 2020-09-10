CREATE TABLE contacts(
	id INT PRIMARY KEY AUTO_INCREMENT,
    name VARCHAR(50),
    lastName VARCHAR(50),
    phone INT,
    address VARCHAR(200),
    email VARCHAR(150)
);

INSERT INTO contacts(name, lastName, phone)
VALUES ('Target', 'Dummy', 123);

DROP TABLE contacts