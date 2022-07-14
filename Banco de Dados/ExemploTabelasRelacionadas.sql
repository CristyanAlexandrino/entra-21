CREATE TABLE pecas(
	id INTEGER PRIMARY KEY IDENTITY(1,1),
	nome VARCHAR(50),
	tipo INTEGER,
	preco_unitario DECIMAL(6,2));

	CREATE TABLE clientes(
	id INTEGER PRIMARY KEY IDENTITY(1,1),
	nome VARCHAR(40),
	cpf VARCHAR(14));

	CREATE TABLE enderecos(
	id INTEGER PRIMARY KEY IDENTITY(1,1),
	id_cliente INTEGER NOT NULL, -- FK
	cep VARCHAR(9) NOT NULL,
	estado VARCHAR(2) NOT NULL,
	cidade VARCHAR(30) NOT NULL,
	bairro VARCHAR(40) NOT NULL,
	logradouro VARCHAR(40) NOT NULL,
	numero VARCHAR(10) NOT NULL,
	descricao TEXT,
	-- FOREIGN KEY nome_coluna_tabela_atual REFERENCES nome_tabela_pai(nome_coluna_pai pk)
	FOREIGN KEY (id_cliente)
	REFERENCES clientes(id));
	
	CREATE TABLE pedidos(
	id INTEGER PRIMARY KEY IDENTITY(1,1),
	id_cliente INTEGER NOT NULL,
	status TINYINT NOT NULL, -- 0..255,
	data_efetivacao_compra DATETIME2,
	data_criacao DATETIME2 NOT NULL,
	);

	CREATE TABLE pedidos_pecas(
		id INTEGER PRIMARY KEY IDENTITY(1,1), -- PK
		id_peca INTEGER, -- FK tabela pe�as
		id_pedido INTEGER, -- FK tabela pedido

		quantidade SMALLINT,

		FOREIGN KEY(id_pedido) REFERENCES pedidos(id),
		FOREIGN KEY(id_peca) REFERENCES pecas(id)
	);
	-- Tipo de Pe�as
	-- 1 SSD
	-- 2 - Placa de Video
	-- 3 - Placa m�e
	-- 4 - Fonte
	-- 5 - Mem�ria RAM
INSERT INTO pecas(nome, tipo, preco_unitario) VALUES
('SSD 240 GB', 1, 200),
('SSD 240 M2', 1, 420.39),
('RTX 3090 TI', 2, 9999.99),
('GTX 1060', 2, 1500),
('16GB DDRS 4800Ghz', 5, 800),
('16G DDR4 3200Ghz', 5,350);

INSERT INTO clientes(nome, cpf) VALUES
('Claudio', '070.355.489-73'),
('Cry', '032.599.384-69');

INSERT INTO clientes(nome, cpf) VALUES
('Juliana', '123.495.392-02');

INSERT INTO enderecos(id_cliente, estado, cidade, bairro, cep, logradouro, numero)
VALUES
(1, 'SC', 'Blumenau', 'Velha', '89070-301', 'Rua Divin�polis', 777),
(2, 'SC', 'Blumenau', 'Velha Grande', '89070-472', 'Morro da Edith', 36),
(3, 'SC', 'Blumenau', 'Judity', 'Sem cep', 'Rua da Kellen', 23);

-- Consulta para listar o nome, cpf e endere�o completo dos clientes
-- Consulta parte da tabela de clientes fazendo INNER JOIN com a tabela de endere�o

SELECT
	c.nome,
	c.cpf,
	CONCAT(
		e.estado, ' - ',
		e.cidade, ' - ',
		e.bairro, ' - ',
		e.logradouro, ' ',
		e.numero) AS 'Endere�o Completo'
		FROM clientes AS c
		INNER JOIN enderecos AS e ON(e.id_cliente = c.id);
-- Consulta os endere�os apresentando seu cliente filtrando
-- por bairros com nome 'Velha'
-- Consulta partindo da tabela de endere�os com outra consulta na tabelas de clientes

SELECT
	c.nome,
	e.bairro,
	e.logradouro
	FROM enderecos AS e
	INNER JOIN clientes AS c ON(c.id = e.id_cliente)
	WHERE e.bairro LIKE '%Velha%';

	-- STATUS de pedidos
-- 0 - Carrinho
-- 1 - Aguardando pagamento
-- 2 - Pagamento efetivado
-- 3 - Entrega Realizada
INSERT INTO pedidos(id_cliente, status, data_criacao) VALUES
(1, 0, GETDATE()), -- Pedido para o Claudio
((SELECT id FROM clientes WHERE nome = 'Cry'), 0, GETDATE()); -- Pedido para o Cry

--Consultar pedidos listando, datas de cria��o formato PT-BR, status com texto
-- e nome do cliente
-- Consulta partindo da tabela de pedidos com JOIN em clientes
SELECT
	FORMAT(p.data_criacao, 'dd/MM/yyyy'),
	CASE
		WHEN [status] = 0 THEN 'Carrinho'
		WHEN [status] = 1 THEN 'Aguardando pagamento'
		WHEN [status] = 2 THEN 'Pagamento efetivado'
		ELSE 'Entrega realizada'
		END AS 'Status pedido',
		c.nome
		FROM pedidos AS p
		INNER JOIN clientes AS c ON(p.id_cliente = c.id);
		UPDATE pedidos SET status = 1 WHERE id = 2;
SELECT * FROM pedidos;

-- Adicionar as oe�as ao pedido
SELECT * FROM pecas;


INSERT INTO pedidos_pecas(id_pedido, id_peca, quantidade) VALUES
(1, 2, 2), -- 2 SSDs M2 para o pedido 1
(1, 4, 1), -- 1 GTX 1060 para o pedido 1
(1, 6,1); -- 1 m�dulo 16G RAM DDS

UPDATE pedidos SET id_cliente = 2 WHERE id = 1;

-- Consultar apresentando nome cliente, nome pe�a,
-- quantidade, valor_unitario, total das pelas
SELECT
	pd.id AS 'C�digo do pedido',
	c.nome As 'Cliente',
	p.nome AS 'Pe�a',
	pp.quantidade AS 'Quantidade',
	CONCAT('R$ ', p.preco_unitario) AS 'Valor unit�rio',
	CONCAT('R$ ', p.preco_unitario * pp.quantidade) AS 'Total das pe�as'
	FROM pedidos_pecas AS pp
	INNER JOIN pecas AS p ON(pp.id_peca = p.id)
	INNER JOIN pedidos AS pd ON(pp.id_pedido = pd.id)
	INNER JOIN clientes AS c ON(pd.id_cliente = c.id);
	-- https://www.invertexto.com/fsens

	INSERT INTO pedidos (id_cliente, data_criacao, status) VALUES
	(1, GETDATE(), 0); -- GETDATE() � o mesmo que DateTime.Now

	-- Criado pedido para o Cla�dio
	INSERT INTO pedidos_pecas(id_pedido, id_peca, quantidade) VALUES
	(3, 2, 2), -- id_pedido = 3, id_peca = 2 (SSD 240M2), quantidade = 2
	(3, 3, 2), -- id_pedido = 2, id_peca = 3 (RTX3090 TI), quantidade = 2
	(3, 5, 4); -- id_pedido = 3, id_peca = 5 (16G RAM DDRS), quantidade = 4 Quad Chanel


	-- Apresentar informa��es do pedido do cliente Cla�dio
	SELECT 
		p.id AS 'C�digo Pedido',
		p.status AS 'Status Pedido',
		c.nome AS 'Cliente',
		CONCAT(
			e.estado, ' ',
			e.cidade, ' ',
			e.bairro, ' ',
			e.logradouro, ' ',
			e.numero) AS 'Endere�o completo'
		FROM pedidos AS p
		INNER JOIN clientes AS c ON(p.id_cliente = c.id)
		INNER JOIN enderecos AS e ON(c.id = e.id_cliente)
		WHERE p.id_cliente = (SELECT id FROM clientes WHERE cpf = '070.355.389-73');

-- Efeticar a compra do pedido do Cla�dio
UPDATE pedidos
	SET 
		status = 2,
		data_efetivacao_compra = '2022-07-12 17:30:00'
		WHERE id = 3

-- Consultar pe�as do pedido do Cla�dio
		SELECT 
		p.id AS 'C�digo Pedido',
		p.status AS 'Status Pedido',
		pec.nome AS 'Cliente'
		FROM pedidos AS p
		INNER JOIN clientes AS c ON(p.id_cliente = c.id)
		INNER JOIN pedidos_pecas AS pp ON(p.id = pp.id_pedido)
		INNER JOIN pecas AS pec ON(pp.id_peca = pec.id)
		WHERE p.id_cliente = (SELECT id FROM clientes WHERE cpf = '070.355.489-73');

		SELECT * FROM enderecos;




