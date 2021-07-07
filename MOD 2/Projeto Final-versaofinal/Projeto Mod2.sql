CREATE TABLE hamb(
	id SERIAL PRIMARY KEY,
	nome VARCHAR(255) NOT NULL,
	ingredientes VARCHAR(255) NOT NULL,
	preco FLOAT NOT NULL,
	imagem_url VARCHAR(255) NOT NULL
);

INSERT INTO hamb(nome, ingredientes, preco, imagem_url)
VALUES ('Batata Frita', 'Batata.', 15.00, 'https://images.pexels.com/photos/1893556/pexels-photo-1893556.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260'),
	   ('Salada', 'Alface, tomate, rúcula, cenoura, ricota e torradas.', 20.00, 'https://claudia.abril.com.br/wp-content/uploads/2020/02/receita-salada-cenoura-rucula-queijo.jpg'),
	   ('Cheedar', 'Pão brioche, hambúrguer e queijo cheddar.', 24.00, 'https://images.pexels.com/photos/1633528/pexels-photo-1633528.jpeg?auto=compress&cs=tinysrgb&dpr=1&w=500'),
	   ('Cheeseburguer', 'Pão brioche, hambúrguer, queijo, alface e tomate.', 17.00, 'https://images.pexels.com/photos/1633578/pexels-photo-1633578.jpeg?auto=compress&cs=tinysrgb&dpr=1&w=500'),
	   ('Duplo Cheeseburguer', 'Pão brioche, dois hambúrgueres, queijo, alface e tomate.', 21.00, 'https://images.pexels.com/photos/5908048/pexels-photo-5908048.jpeg?auto=compress&cs=tinysrgb&dpr=1&w=500'),
	   ('Cheesebacon', 'Pão brioche, hambúrguer, queijo, alface, tomate e bacon.', 19.00, 'https://images.pexels.com/photos/1199957/pexels-photo-1199957.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260'),
	   ('Coca-Cola', 'Coca-Cola.', 7.00, 'https://images.pexels.com/photos/2668308/pexels-photo-2668308.jpeg?auto=compress&cs=tinysrgb&dpr=1&w=500'),
	   ('Água', 'Água mineral.', 5.00, 'https://image.freepik.com/psd-gratuitas/maquete-de-garrafa-de-agua-doce_358694-279.jpg'),
	   ('Suco de Laranja', 'Laranja.', 10.00, 'https://image.freepik.com/fotos-gratis/suco-de-laranja-fresco-e-frio_144627-11208.jpg');
	   
SELECT * FROM hamb h 