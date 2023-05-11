USE AngebotVergleich;
CREATE TABLE Angebot
(
Firma varchar(15),
Listeneinkaufspreis float,
Lieferrabatt tinyint,
Lieferskonto tinyint,
bezugspreis float,
sonstRabatt tinyint
);

INSERT INTO Angebot
VALUES ('Alex',1000,20,30,60,0);