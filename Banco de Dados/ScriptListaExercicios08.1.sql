
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

