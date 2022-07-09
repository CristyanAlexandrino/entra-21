
-----------------------------------------------------Tabela Pokemons ------------------------------------------------------------------------------------

-- 1
SELECT TOP(10) id, nome, codigo, categoria, altura, peso, hp, ataque, defesa, especial_ataque, especial_defesa, velocidade, descricao 
FROM pokemons;

-- 2 
SELECT TOP(10 )ataque , especial_ataque, defesa, especial_defesa 
FROM pokemons 
ORDER BY ataque DESC;

-- 3
SELECT nome, categoria, ataque 
FROM pokemons
ORDER BY ataque ASC;

-- 4
ALTER TABLE pokemons ADD imc DECIMAL
UPDATE pokemons SET imc = (peso / (altura + altura));

-- 5
SELECT altura , peso, imc 
FROM pokemons
ORDER BY imc DESC;

-- 6
SELECT nome, LEN(nome) 
FROM pokemons
ORDER BY LEN(nome) DESC;

-- 7
SELECT nome, descricao FROM pokemons
WHERE LEN(nome) >= 10;

-- 8
SELECT nome, categoria, ataque 
FROM pokemons 
WHERE ataque = (SELECT MIN(poke.ataque) FROM pokemons poke);


-- 9
SELECT ataque, especial_ataque, nome, defesa, especial_defesa 
FROM pokemons
ORDER BY ataque;

-- 10
SELECT AVG(ataque) FROM pokemons;

-- 11
SELECT SUM(ataque) FROM pokemons;

-- 12
SELECT AVG(especial_ataque)
FROM pokemons
WHERE nome LIKE 'P%';


----------------------------------------------------- Tabela Cidades --------------------------------------------------------------------------

-- 1 
SELECT estado, cidade FROM cidades;

-- 2
SELECT cidade 
FROM cidades
WHERE cidade LIKE 'A%';

-- 3
SELECT cidade
FROM cidades
WHERE cidade LIKE '%apar%';

-- 4
SELECT cidade
FROM cidades
WHERE cidade LIKE 'W%';

-- 5
SELECT cidade, estado 
FROM cidades
WHERE cidade LIKE '%tuba' 
ORDER BY estado DESC;

-- 6
SELECT cidade 
FROM cidades 
WHERE LEN(cidade) > 15
ORDER BY LEN(cidade);

-- 7
SELECT COUNT(cidade) 
FROM cidades
WHERE estado = 'SC'

-- 8
SELECT COUNT(cidade)
FROM cidades
WHERE estado = 'SP'

-- 9 
SELECT cidade
FROM cidades
WHERE LEN(cidade) > 10;