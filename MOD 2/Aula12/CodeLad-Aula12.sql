CREATE TABLE pessoas(
	id SERIAL PRIMARY KEY,
	nome VARCHAR NOT NULL,
	sobrenome VARCHAR NOT NULL,
	idade INT
);

CREATE TABLE pedidos(
	id_pedido INT NOT NULL,
	data_pedido VARCHAR NOT NULL,
	descricao VARCHAR NOT NULL,
	PRIMARY KEY(id_pedido, data_pedido)  /* CHAVE PRIMARIA COM DUAS COLUNAS (EXEMPLO DO NUMERO DA FICHA NA SALA DE ESPERA) */
);

DROP TABLE pedidos -- APAGAR UMA TABELA

INSERT INTO pedidos (id_pedido, data_pedido, descricao)
VALUES (1, '22/06/2021', 'PEDIDO 1')

INSERT INTO pedidos (id_pedido, data_pedido, descricao)
VALUES (2, '22/06/2021', 'PEDIDO 2')

SELECT * FROM pedidos

INSERT INTO pessoas (nome, sobrenome, idade)
VALUES ('Lucia', 'Leao', 60),
 	   ('Lucia', 'Leao', 33),
 	   ('Marcia', 'Prates', 55),
 	   ('Alexandre', 'Magno', 50),
 	   ('Gustavo', 'Ramos', 33),
       ('Alfredo', 'Carneiro', 65),
       ('Alfredo', 'Junior', 35),
       ('Alessandra', 'Prates', 25),
       ('Jonas', 'John', 33);
       
SELECT * FROM pessoas 

UPDATE pessoas
SET sobrenome = 'Sauro',
	idade = 90
WHERE id = 11

UPDATE pessoas
SET sobrenome = 'Souza',
	idade = 48
WHERE id = 12

-- CUIDADO COM O COMANDO DELETE --
DELETE FROM pessoas 
WHERE id = 12

SELECT * FROM pessoas ORDER BY id

UPDATE pessoas
SET nome = 'Katia',
	idade = 54
WHERE id = 5


SELECT * FROM pessoas WHERE idade >= 18 AND nome LIKE 'A%' -- case sensitive
SELECT * FROM pessoas WHERE idade >= 18 AND nome LIKE '%l%'
SELECT * FROM pessoas WHERE idade >= 18 AND nome LIKE '%e'

SELECT * FROM pessoas WHERE idade < 50 
ORDER BY nome ASC -- ascending

SELECT * FROM pessoas WHERE idade < 50 
ORDER BY nome DESC LIMIT 3 -- descending com limite de 3

SELECT COUNT(*) FROM pessoas

DROP TABLE pedidos, pessoas

CREATE TABLE produtos_tipo(
	idTipo SERIAL PRIMARY KEY,
	descricaoTipo VARCHAR NOT NULL	
);

CREATE TABLE produtos(
	idProd SERIAL PRIMARY KEY,
	descricaoProd VARCHAR NOT NULL,
	precoProd DECIMAL(10,2),
	tipo INT REFERENCES produtos_tipo(idTipo)
);

INSERT INTO produtos_tipo(descricaoTipo)
VALUES ('Computador'),
       ('Impressora'),
	   ('Smartphone');

INSERT INTO produtos(descricaoProd, precoProd, tipo)
VALUES ('Desktop', 1200.00, 1),
       ('Notebook', 4000.00, 1),
       ('Impressora Laser', 1500.00, 2),
       ('Impressora Jato de Tinta', 500.00, 2),
       ('Headset Gamer', 300.00, NULL);


SELECT * FROM produtos p 
SELECT * FROM produtos_tipo pt

SELECT p.idProd, p.descricaoProd, p.precoProd, pt.descricaoTipo
FROM produtos p LEFT JOIN produtos_tipo pt
ON p.tipo = pt.idTipo

SELECT p.idProd, p.descricaoProd, p.precoProd, pt.descricaoTipo
FROM produtos p RIGHT JOIN produtos_tipo pt
ON p.tipo = pt.idTipo

SELECT p.idProd, p.descricaoProd, p.precoProd, pt.descricaoTipo
FROM produtos p FULL JOIN produtos_tipo pt
ON p.tipo = pt.idTipo

SELECT p.idProd, p.descricaoProd, p.precoProd, pt.descricaoTipo
FROM produtos p JOIN produtos_tipo pt
ON p.tipo = pt.idTipo
	   


