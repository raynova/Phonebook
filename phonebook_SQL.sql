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