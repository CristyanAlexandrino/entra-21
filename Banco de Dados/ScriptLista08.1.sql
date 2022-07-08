
------------------------------------------- Exercicio 1 -------------------------------------
CREATE TABLE pessoas(
	id INTEGER PRIMARY KEY IDENTITY(1,1),
	nome VARCHAR(100),
	cpf VARCHAR(14),
	rg VARCHAR (12),
	data_de_nascimento DATE,
	idade INT,
);

INSERT INTO pessoas
(nome, cpf, rg, data_de_nascimento, idade)
 VALUES ('Erick Bryan Enrico Vieira', '699.734.958-70', 
 '90.745.276-0', '1989/05/28', '29');
 
 INSERT INTO pessoas
(nome, cpf, rg, data_de_nascimento, idade)
 VALUES ('Samuel Ruan Dias', '802.790.194-40', 
 '55.318.691-7', '1988-02-08', '30');
 
 INSERT INTO pessoas
(nome, cpf, rg, data_de_nascimento, idade)
 VALUES ('Fábio Benjamin Souza', '522.445.349-60', '54.715.232-2', '1970-03-22', '48');
 
 INSERT INTO pessoas
(nome, cpf, rg, data_de_nascimento, idade)
 VALUES ('Elias Miguel Aparicio', '293.928.821-65',
 '12.680.444-8', '1986-06-07', '32');
 
 INSERT INTO pessoas
(nome, cpf, rg, data_de_nascimento, idade)
 VALUES ('Alexandre Gustavo Cardoso', '617.408.878-24',
 '8.888.574-4', '2003-04-15', '15');
 
 INSERT INTO pessoas
(nome, cpf, rg, data_de_nascimento, idade)
 VALUES ('Kauê Lucca Duarte', '943.163.990-47', 
 '46.977.509-9', '1965-06-15', '53');
 
 INSERT INTO pessoas
(nome, cpf, rg, data_de_nascimento, idade)
 VALUES ('Marcos Bryan Guilherme Mendes', '955.129.235-95', 
 '84.050.077-4', '2015-02-06', '3');
 
 INSERT INTO pessoas
(nome, cpf, rg, data_de_nascimento, idade)
 VALUES ('Benedito Pedro Carlos da Mota', '510.505.472-50', 
 '43.588.124-3', '1981-04-19', '37');
 
 INSERT INTO pessoas
(nome, cpf, rg, data_de_nascimento, idade)
 VALUES ('Luís Igor Barbosa', '370.570.311-06', 
 '40.651.407-0', '2013-05-06', '5');
 
 INSERT INTO pessoas
(nome, cpf, rg, data_de_nascimento, idade)
 VALUES ('José Heitor Ramos', '675.624.925-81', 
 '83.962.258-2', '1965-04-11', '53');
 
 INSERT INTO pessoas
(nome, cpf, rg, data_de_nascimento, idade)
 VALUES ('Lucca Tiago Galvão', '788.124.508-57', 
 '3.293.335-6', '1977-06-17', '41');
 
 INSERT INTO pessoas
(nome, cpf, rg, data_de_nascimento, idade)
 VALUES ('Tiago Edson Oliveira', '389.969.352-39',
 '8.198.446-9', '1977-06-09', '41');
 
 INSERT INTO pessoas
(nome, cpf, rg, data_de_nascimento, idade)
 VALUES ('Enrico Julio Fábio Martins', 
 '529.078.166-83', '99.886.242-3', '2017-03-11', '1');
 
 INSERT INTO pessoas
(nome, cpf, rg, data_de_nascimento, idade)
 VALUES ('Oliver Victor Benjamin da Mota', '798.556.805-02', '5.103.578-9', '1985-03-27', '33');
 
 INSERT INTO pessoas
(nome, cpf, rg, data_de_nascimento, idade)
 VALUES ('Bryan Caio Lopes', '213.217.201-30', '12.949.454-9', '1970-06-18', '48');

 SELECT TOP(10)id,nome, cpf, rg, data_de_nascimento, idade FROM pessoas;

 SELECT TOP(5) id, nome, cpf, rg, FORMAT(data_de_nascimento, 'dd/MM/yyyy'), idade FROM pessoas;


 ------------------------------------ Exercicio 2 -------------------------------------------------

 CREATE TABLE enderecos(
	id INTEGER PRIMARY KEY IDENTITY(1,1),
	estado VARCHAR(2),
	cidade VARCHAR(140),
	bairro VARCHAR(120),
	cep VARCHAR(10),
	logradouro VARCHAR(250),
	numero INT,
	complemento TEXT,
);

INSERT INTO enderecos
( estado, cidade, bairro, cep, logradouro, numero, complemento)
VALUES ('AC', 'Rio Branco', 'Ayrton Senna', '69.911-866',
'Estrada Deputado José Rui da Silveira Lino', '282', 'Casa');

INSERT INTO enderecos
( estado, cidade, bairro, cep, logradouro, numero, complemento)
VALUES ('SC', 'Biguaçu', 'Fundos', '88.161-400', '', '995', '');

INSERT INTO enderecos
( estado, cidade, bairro, cep, logradouro, numero, complemento)
VALUES ('MG', 'Santa Luzia', 'Padre Miguel', '33.082-050',
'Rua Buenos Aires', '371', 'Apartamento');

INSERT INTO enderecos
( estado, cidade, bairro, cep, logradouro, numero, complemento)
VALUES ('BA', '', 'São Tomé de Paripe', '40.800-361', 'Travessa Luís Hage', '685', '');

INSERT INTO enderecos
( estado, cidade, bairro, cep, logradouro, numero, complemento)
VALUES ('MG', 'Ipatinga', 'Vila Celeste', '', 
'Rua Antônio Boaventura Batista', '645', '');

INSERT INTO enderecos
( estado, cidade, bairro, cep, logradouro, numero, complemento)
VALUES ('RS', 'Passo Fundo', 'Nenê Graeff', '99.030-250', '', '154', '');

INSERT INTO enderecos
( estado, cidade, bairro, cep, logradouro, numero, complemento)
VALUES ('AM', 'Manaus', 'Petrópolis', '69.079-300', 
'Rua Coronel Ferreira Sobrinho', '264', 'Fundos');

INSERT INTO enderecos
( estado, cidade, bairro, cep, logradouro, numero, complemento)
VALUES ('TO', 'Gurupi', 'Muniz Santana', '77.402-130', 
'Rua Adelmo Aires Negri', '794', '');

INSERT INTO enderecos
( estado, cidade, bairro, cep, logradouro, numero, complemento)
VALUES ('AC', '', 'Preventório', '', 'Beco da Ligação II', '212', 'Bloco B');

INSERT INTO enderecos
( estado, cidade, bairro, cep, logradouro, numero, complemento)
VALUES ('AP', 'Santana', 'Comercial', '68.925-073', 'Rua Calçoene', '648', '');

INSERT INTO enderecos
( estado, cidade, bairro, cep, logradouro, numero, complemento)
VALUES ('PB', 'Cabedelo', 'Camalaú', '58.103-052', 'Rua Siqueira Campos', '249', '');


SELECT TOP(11)id, estado, cidade , bairro, cep, logradouro, numero, complemento FROM enderecos;

UPDATE enderecos SET bairro = 'Saveiro', logradouro = 'Rua Xingu', complemento = 'Casa' WHERE id = 2;
UPDATE enderecos SET cidade = 'Salvador', complemento = 'Casa' WHERE id = 4;
UPDATE enderecos SET cep = '35.162-484', complemento = 'Casa fundos' WHERE cidade = 'Ipatinga';
UPDATE enderecos SET logradouro = 'RS-324, 569' , complemento = 'Loja Rezende' WHERE numero = '154';
UPDATE enderecos SET complemento = 'Casa' WHERE logradouro = 'Rua Adelmo Aires Negri';
UPDATE enderecos SET cidade = 'Rio Branco', logradouro = 'Rua Minas Gerais' , cep = '69.900-318' WHERE bairro = 'Preventório';
UPDATE enderecos SET complemento = 'Apto 120 3° andar' WHERE cep = '68.925-073';
UPDATE enderecos SET complemento = 'Casa ao lado de um limoeiro' WHERE logradouro = 'Rua Siqueira Campos';

SELECT id, estado, cidade, bairro, cep, logradouro, numero, complemento FROM enderecos;


-------------------------------------- Exerciocio 3 -----------------------------------------------

 CREATE TABLE champions(
	id INTEGER PRIMARY KEY IDENTITY(1,1),
	nome VARCHAR(20),
	descricao VARCHAR(20),
	passiva VARCHAR(40),
	habilidade_2 VARCHAR(40),
	habilidade_3 VARCHAR(40),
	habilidade_4 VARCHAR(40),
	habilidade_5 VARCHAR(40)
);

INSERT INTO champions
( nome, descricao, passiva, habilidade_2, habilidade_3, habilidade_4, habilidade_5)
VALUES ('Katarina', 'A Lâmina Sinistra', 'Voracidade', 
'Lâmina Saltitante', 'Preparação', 'Shunpo', 'Lótus da Morte');

INSERT INTO champions
( nome, passiva, habilidade_2, habilidade_3, habilidade_4, habilidade_5)
VALUES ('Yasuo', 'Estilo do Errante', 'Tempestade de Aço', 
'Parede de Vento', 'Espada Ágil', 'Último suspiro')

INSERT INTO champions
( nome, descricao, passiva )
VALUES ('Master Yi', 'O Espadachim Wuju', 'Ataque Duplo')

INSERT INTO champions
( nome, descricao, passiva, habilidade_2, habilidade_3, habilidade_4)
VALUES ('Vayne', 'A Caçadora Noturna', 'Rolamento', 
'Dardo de Prata', 'Condenar', 'Hora Final')

INSERT INTO champions
( nome, descricao, passiva, habilidade_2, habilidade_3, habilidade_4)
VALUES ('Lee Sin', 'O Monge Cego', 'Agitação', 'Onda Sônica / Ataque Ressonante', 
'Proteger / Vontade de Ferro', 'Tempestade / Mutilar')

INSERT INTO champions
( nome, descricao, passiva, habilidade_3, habilidade_4, habilidade_5)
VALUES ('Vi', 'A Defensora de Piltover', 'Blindagem',
 'Pancada Certeira', 'Força Excessiva', 'Saque e Enterrada')

INSERT INTO champions
( nome, descricao, passiva, habilidade_2, habilidade_3, habilidade_4, habilidade_5)
VALUES ('Diana', 'o Escárnio da Lua', 'Espada de Prata Lunar', 'Golpe Crescente',
'Cascata Lívida', 'Colapso Minguante', 'Zênite Lunar')

INSERT INTO champions
( nome, descricao, passiva, habilidade_2, habilidade_3, habilidade_4, habilidade_5)
VALUES ('Annie', 'A Criança Sombria', 'Piromania', 'Desintegrar', 
'Incinerar', 'Escudo Fundido', 'Invocar: Tibbers')

INSERT INTO champions
( nome,  passiva, habilidade_2, habilidade_3, habilidade_4, habilidade_5)
VALUES ('Aatrox', 'Poço de Sangue', 'Voo Sombrio', 'Sede de Sangue / Preço em Sangue', 
'Lâminas da Aflição', 'Massacre')

SELECT nome,descricao, passiva, habilidade_2, habilidade_3, habilidade_4, habilidade_5 FROM champions;

UPDATE champions SET descricao = 'O Imperdoável' WHERE nome = 'Yasuo';
UPDATE champions SET habilidade_2 = 'Ataque Alpha' , habilidade_3 = 'Meditar',
 habilidade_4 = 'Estilo Wuju', habilidade_5 = 'Highlander' WHERE nome = 'Master Yi';
UPDATE champions SET passiva = 'Caçadora Noturna' , habilidade_2 = 'Rolamento', 
habilidade_3 = 'Dardos de Prata',  habilidade_4 = 'Condenar', habilidade_5 = 'Hora Final' WHERE nome = 'Vayne';
UPDATE champions SET habilidade_5 = 'Fúria do Dragão' WHERE nome = 'Lee Sin';
UPDATE champions SET descricao = 'A Espada Darkin' WHERE nome = 'Aatrox';

SELECT TOP(8)id, nome,descricao, passiva, habilidade_2, habilidade_3, habilidade_4, habilidade_5 FROM champions;