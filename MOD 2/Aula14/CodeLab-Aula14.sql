SELECT f.nome, f.sobrenome, f.email, f.cargo FROM funcionarios f WHERE cargo LIKE '%Sales Rep%';

SELECT * FROM produtos p; 
SELECT * FROM detalhespedidos d;
SELECT * FROM clientes c; 
SELECT * FROM pedidos pe;
SELECT * FROM funcionarios f; 
SELECT * FROM pagamentos pa; 

SELECT DISTINCT f.cargo FROM funcionarios f; 
SELECT DISTINCT l.cidade FROM lojas l;

SELECT f.nome, f.sobrenome, f.email, l.cidade, l.pais, l.telefone 
FROM funcionarios f LEFT JOIN lojas l
ON f.codloja = l.codloja
WHERE f.cargo = 'President';

SELECT * FROM produtos p ORDER BY precosugerido DESC LIMIT 1;
SELECT * FROM produtos p ORDER BY precosugerido LIMIT 1;
SELECT * FROM produtos p ORDER BY qtdestoque LIMIT 1;
SELECT * FROM produtos p ORDER BY qtdestoque DESC LIMIT 1;


SELECT p.nomeproduto AS "Produto", SUM(d.quantidadepedida) AS "Qtd Vendas"
FROM produtos p LEFT JOIN detalhespedidos d 
ON p.codproduto = p.codproduto
WHERE p.codproduto = 'S12_1108'
GROUP BY p.nomeproduto; 

-- DESAFIO --
-- 1
SELECT c.nomecontato AS "Nome", c.sobrenomecontato AS "Sobrenome", c.cidade AS "Cidade", c.estado AS "Estado", COUNT(pe.numpedido) AS "Qtd Vendas"
FROM clientes c JOIN pedidos pe 
ON pe.numcliente = c.numcliente
GROUP BY c.nomecontato, c.sobrenomecontato, c.cidade, c.estado
ORDER BY "Qtd Vendas" DESC;
-- 2
SELECT p.nomeproduto AS "Nome Produto", p.descricaoproduto AS "Descrição", p.precosugerido AS "Preço produto", COUNT(d.quantidadepedida) AS "Qtd Vendas"
FROM produtos p JOIN detalhespedidos d
ON p.codproduto = d.codproduto 
GROUP BY p.nomeproduto, p.descricaoproduto , p.precosugerido
ORDER BY "Qtd Vendas" DESC;
-- 3
SELECT f.nome AS "Nome", f.sobrenome AS "Sobrenome", f.email AS "Email",  f.reportaa AS "Reporta a"
FROM funcionarios f 
JOIN clientes c ON f.numfuncionario = c.numfuncionarioreprvendas
JOIN pedidos p ON c.numcliente = p.numcliente 
JOIN detalhespedidos d ON p.numpedido = d.numpedido
GROUP BY f.nome, f.sobrenome , f.email, f.reportaa 
ORDER BY COUNT(d.quantidadepedida) DESC ;
-- 4
SELECT c.nomecontato AS "Nome", c.sobrenomecontato AS "Sobrenome", c.cidade AS "Cidade", c.estado AS "Estado", c.limitecredito AS "Limite", SUM(pa.valor) AS "Valor total"
FROM pagamentos pa
JOIN clientes c ON pa.numcliente = c.numcliente 
GROUP BY c.nomecontato, c.sobrenomecontato, c.cidade, c.estado, c.limitecredito 
ORDER BY "Valor total" DESC
-- 5
SELECT * 
FROM funcionarios f
JOIN lojas l ON f.codloja = l.codloja 
JOIN clientes c ON f.numfuncionario = c.numfuncionarioreprvendas 