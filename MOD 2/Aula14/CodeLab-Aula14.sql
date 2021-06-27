SELECT f.nome, f.sobrenome, f.email, f.cargo FROM funcionarios f WHERE cargo = 'Sales Rep'

SELECT * FROM produtos p 
SELECT * FROM detalhespedidos d


SELECT DISTINCT f.cargo FROM funcionarios f 
SELECT DISTINCT l.cidade FROM lojas l 

SELECT f.nome, f.sobrenome, f.email, l.cidade, l.pais, l.telefone 
FROM funcionarios f LEFT JOIN lojas l 
ON f.codloja = l.codloja
WHERE cargo = 'President'

SELECT * FROM produtos p ORDER BY precosugerido DESC LIMIT 1
SELECT * FROM produtos p ORDER BY precosugerido LIMIT 1
SELECT * FROM produtos p ORDER BY qtdestoque LIMIT 1
SELECT * FROM produtos p ORDER BY qtdestoque DESC LIMIT 1

SELECT p.nomeproduto, SUM(d.quantidadepedida)
FROM produtos p LEFT JOIN detalhespedidos d 
ON p.codproduto = p.codproduto
WHERE p.codproduto = 'S12_1108'
GROUP BY p.nomeproduto 