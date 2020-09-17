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

UPDATE contacts
SET email ='test@abc.com' 
WHERE id = 1

DROP TABLE contacts;

SELECT id, name, lastName
FROM contacts;

DELETE FROM contacts WHERE id = 4 OR id = 5

INSERT INTO contacts(name, lastName, phone, address, email)
VALUES ('Anna', 'Peterson', 5347357, 'Woder str, USA', 'myemail@test.com'),
('Dmitrijs', 'Peterson', 75737753, 'Woder str, USA', 'myemail@test.com'),
('Boris', 'Klava', 75373753, 'Woder str, USA', 'myemail@test.com'),
('Charlie', 'Peterson', 8769875, 'Woder str, USA', 'myemail@test.com'),
('Diana', 'Porty', 4543789, 'Woder str, USA', 'myemail@test.com'),
('Peter', 'Mederson', 45368334, 'Woder str, USA', 'myemail@test.com'),
('Mary', 'Peterson', 4537973, 'Woder str, USA', 'myemail@test.com'),
('Jhon', 'Hoy', 125443, 'Woder str, USA', 'myemail@test.com'),
('Arnold', 'Binger', 43399979, 'Woder str, USA', 'myemail@test.com'),
('Zac', 'Peterson', 35785875, 'Woder str, USA', 'myemail@test.com'),
('Violett', 'Peterson', 74667467, 'Woder str, USA', 'myemail@test.com'),
('Orin', 'Peterson', 34524525, 'Woder str, USA', 'myemail@test.com'),
('Lesley', 'Joackson', 16546516, 'Woder str, USA', 'myemail@test.com'),
('Kait', 'Parker', 5195154, 'Woder str, USA', 'myemail@test.com');