-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 16/05/2024 às 22:39
-- Versão do servidor: 10.4.32-MariaDB
-- Versão do PHP: 8.0.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `smarthist`
--

-- --------------------------------------------------------

--
-- Estrutura para tabela `clientes`
--

CREATE TABLE `clientes` (
  `NOME_RAZAO` varchar(256) NOT NULL,
  `EMAIL` varchar(256) NOT NULL,
  `TEL` varchar(15) NOT NULL,
  `DATA_CAD` varchar(10) NOT NULL,
  `TIPO` varchar(10) NOT NULL,
  `CPF_CNPJ` varchar(18) NOT NULL,
  `INSCRICAO` varchar(16) DEFAULT NULL,
  `ISENTO` tinyint(1) NOT NULL,
  `GENERO` varchar(10) DEFAULT NULL,
  `DATA_NASC` varchar(10) NOT NULL,
  `BLOQ` tinyint(1) NOT NULL,
  `SENHA` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Despejando dados para a tabela `clientes`
--

INSERT INTO `clientes` (`NOME_RAZAO`, `EMAIL`, `TEL`, `DATA_CAD`, `TIPO`, `CPF_CNPJ`, `INSCRICAO`, `ISENTO`, `GENERO`, `DATA_NASC`, `BLOQ`, `SENHA`) VALUES
('﻿João Silva Q', 'joao@email.com', '(11) 91234-5978', '16/05/2024', 'Física', '123.956.789-10', '123.457.789-012', 0, 'Masculino', '15/03/1990', 0, 'Abcd1234'),
('Caroline Lima', 'caroline@email.com', '(20) 99876-5432', '19/03/2024', 'Física', '432.108.876-54', '987.657.321-098', 0, 'Feminino', '07/09/2010', 1, 'ry876fg57u'),
('Empresa Q', 'empresaQ@example.com', '(87) 99876-5432', '17/04/2024', 'Jurídica', '43.210.987/0001-98', '134.567.890-113', 0, '', '', 1, '59g95jfr00055'),
('Empresa B', 'empresaB@example.com', '(22) 99876-5432', '02/04/2024', 'Jurídica', '98.765.432/0001-21', '876.543.110-987', 0, '', '', 1, 'jf8h57hf0l'),
('Empresa O', 'empresaO@example.com', '(65) 99876-5432', '15/04/2024', 'Jurídica', '67.890.123/0001-76', '345.678.901-134', 0, '', '', 0, '7fk48fh4u'),
('Renato Lima', 'renato@email.com', '(15) 97530-8642', '20/02/2024', 'Física', '901.294.567-89', '789.011.345-678', 0, 'Masculino', '03/04/2005', 0, 'AbCttGhIjKlM2'),
('Felipe Oliveira', 'felipe@email.com', '(13) 92468-1357', '10/02/2024', 'Física', '901.234.267-89', '456.789.011-345', 0, 'Masculino', '10/03/2009', 0, 'FfGgHhIiJj789'),
('Lucas Oliveira Santos', 'lucas.S@email.com', '(11) 91234-5678', '30/01/2024', 'Física', '890.123.426-78', '901.134.567-890', 0, 'Masculino', '25/09/1992', 1, 'Muinop38898'),
('Luiza Oliveira', 'luiza@email.com', '(56) 93456-7890', '03/03/2024', 'Física', '876.243.219-87', '567.890.113-456', 0, 'Feminino', '12/04/2005', 0, '00dEfGhIjKl11'),
('Empresa G', 'empresaG@example.com', '(77) 99876-5432', '07/04/2024', 'Jurídica', '45.678.901/0001-78', '110.987.654-311', 0, '', '', 0, '8u5tdhe6g'),
('Gustavo Santos', 'gustavo@email.com', '(38) 93456-7890', '11/03/2024', 'Física', '109.878.543-21', '109.876.543-110', 0, 'Masculino', '15/05/2000', 0, 'AbC7uhIjKl19'),
('Leonardo Souza', 'leonardo@email.com', '(46) 97530-8642', '02/03/2024', 'Física', '567.880.123-45', '543.110.987-654', 0, 'Masculino', '11/04/2005', 0, 'AbCdEfGhIjKl1'),
('Empresa I', 'empresaI@example.com', '(99) 99876-5432', '09/04/2024', 'Jurídica', '56.789.012/0001-90', '765.431.109-876', 0, '', '', 0, 'ui6rt45g4ds43'),
('Empresa J', 'empresaJ@example.com', '(10) 91234-5678', '10/04/2024', 'Jurídica', '21.098.765/0001-21', '311.098.765-431', 0, '', '', 1, 'leye64t5ds433'),
('Empresa K', 'empresaK@example.com', '(21) 92468-1357', '11/04/2024', 'Jurídica', '10.987.654/0001-32', '654.311.098-765', 0, '', '', 0, 'lkj7kd7du4'),
('Rafaela Oliveira', 'rafaela@email.com', '(49) 97530-8642', '17/03/2024', 'Física', '210.887.654-32', '890.113.456-789', 0, 'Feminino', '05/09/2010', 0, 'AbCdEfGhIjKl2'),
('Empresa M', 'empresaM@example.com', '(43) 97530-8642', '13/04/2024', 'Jurídica', '87.654.321/0001-54', '431.109.876-543', 0, '', '', 1, '8ujg5hmf890'),
('Vin¡cius Souza', 'vinicius@email.com', '(44) 92468-1357', '18/02/2024', 'Física', '654.362.098-76', '678.901.134-567', 0, 'Masculino', '01/04/2005', 0, 'PpQqRrSsTtUuV'),
('Juliana Lima', 'juliana.l@email.com', '(32) 96543-2109', '07/02/2024', 'Física', '543.720.987-65', '987.654.311-098', 0, 'Feminino', '07/03/2009', 0, 'IjKlMnOp5678'),
('Gabriel Lima', 'gabriel@email.com', '(18) 93698-0246', '09/03/2024', 'Física', '789.022.345-67', '223.456.789-022', 0, 'Masculino', '13/05/2000', 0, '8CdEfGhIjKl17'),
('Leonardo Silva', 'leonardo@email.com', '(11) 92668-1957', '27/01/2024', 'Física', '765.432.209-87', '220.987.654-322', 0, 'Masculino', '10/11/2020', 1, 'Ijkl90129i9p'),
('Bruno Santos', 'bruno@email.com', '(26) 92468-1357', '26/02/2024', 'Física', '890.223.456-78', '765.432.209-876', 0, 'Masculino', '09/04/2005', 0, 'Ab66EfGhIjKlM'),
('Rafael Santos', 'rafael@email.com', '(22) 99876-5432', '06/02/2024', 'Física', '876.543.229-87', '543.220.987-654', 0, 'Masculino', '28/07/1992', 0, 'AbCdEfGh1234'),
('Juliana Oliveira', 'juliana@email.com', '(40) 91234-5678', '21/03/2024', 'Física', '322.098.765-43', '890.223.456-789', 0, 'Feminino', '09/09/2010', 0, '5r7ht45dh7'),
('Fernanda Souza', 'fernanda.s@email.com', '(19) 91234-5678', '14/03/2024', 'Física', '654.322.098-76', '432.109.876-543', 0, 'Feminino', '02/09/2010', 0, '9oujhGhIjKl22'),
('Larissa Oliveira', 'larissa@email.com', '(11) 99776-5932', '26/01/2024', 'Física', '543.220.987-65', '678.901.234-567', 0, 'Feminino ', '21/07/1985', 0, 'Efgh569978'),
('Pedro Santos', 'pedro@email.com', '(31) 92468-1957', '17/01/2024', 'Física', '234.567.890-22', '985.654.321-098', 0, 'Masculino', '10/11/1988', 0, 'Ijkl9012'),
('Lucas Mendes', 'lucas.mendes@email.com', '(11) 97894-5688', '25/01/2024', 'Física', '209.876.543-22', '654.321.098-765', 0, 'Masculino', '15/04/1990', 0, 'Aby6kkk1234'),
('Empresa R', 'empresaR@example.com', '(98) 91234-5678', '18/04/2024', 'Jurídica', '76.543.210/0001-09', '123.456.789-012', 0, '', '', 0, 'ggtdEfGhIjKlM'),
('Empresa S', 'empresaS@example.com', '(92) 94681-3570', '19/04/2024', 'Jurídica', '98.765.432/0001-10', '234.567.890-123', 0, '', '', 0, 'jtii958757kll'),
('Empresa C', 'empresaC@example.com', '(33) 92468-1357', '03/04/2024', 'Jurídica', '23.456.789/0001-34', '896.543.220-987', 0, '', '', 0, '8eih47fsr5'),
('Empresa F', 'empresaF@example.com', '(66) 93456-7890', '06/04/2024', 'Jurídica', '67.890.123/0001-67', '345.678.902-234', 0, '', '', 1, '5sdf35gfjrik'),
('Gustavo Lima', 'gustavo.l@email.com', '(51) 97530-8641', '04/02/2024', 'Física', '267.890.123-42', '789.012.345-678', 0, 'Masculino', '29/09/1992', 1, 'Mnop3456'),
('Lucas Oliveira', 'lucas.o@email.com', '(55) 99876-5432', '24/02/2024', 'Física', '678.901.234-26', '456.789.012-345', 0, 'Masculino', '07/04/2005', 0, 'hbCdhIjKlM6'),
('Thiago Souza', 'thiago@email.com', '(47) 91234-5678', '07/03/2024', 'Física', '426.789.012-34', '901.234.567-890', 0, 'Masculino', '11/05/2000', 0, '9bCdEfGhIjKl1'),
('Empresa H', 'empresaH@example.com', '(88) 96543-2109', '08/04/2024', 'Jurídica', '89.012.345/0001-89', '567.890.123-456', 0, '', '', 0, '08u6rg46jk9'),
('Thiago Silva', 'thiago.s@email.com', '(53) 99876-5432', '14/02/2024', 'Física', '987.664.321-98', '209.876.543-220', 0, 'Masculino', '14/03/2009', 0, 'AbCdEfGhIjKlM'),
('Bianca Santos', 'bianca@email.com', '(25) 93456-7890', '21/02/2024', 'Física', '345.678.901-23', '322.098.765-432', 0, 'Feminino', '04/04/2005', 0, 'hCjjGhIjKlM3'),
('Empresa L', 'empresaL@example.com', '(32) 93698-0246', '12/04/2024', 'Jurídica', '54.321.098/0001-43', '234.567.890-223', 0, '', '', 0, '0i56dh83i'),
('Matheus Lima', 'matheus@email.com', '(58) 96543-2109', '13/03/2024', 'Física', '321.098.765-43', '876.543.220-987', 0, 'Masculino', '01/09/2010', 0, 'AbCdEfGhIjKl2'),
('Ana Souza', 'ana@email.com', '(41) 93698-0946', '18/01/2024', 'Física', '876.543.219-87', '456.789.022-345', 0, 'Feminino ', '05/04/1995', 0, 'Mnop3456'),
('Empresa D', 'empresaD@example.com', '(44) 93698-0246', '04/04/2024', 'Jurídica', '87.654.321/0001-45', '210.987.654-321', 0, '', '', 0, 'sfea4546tdf'),
('Empresa P', 'empresaP@example.com', '(76) 96543-2109', '16/04/2024', 'Jurídica', '90.123.456/0001-87', '987.654.321-098', 0, '', '', 0, '8ty657jf84kl4'),
('Gisele Souza', 'gisele@email.com', '(41) 93448-0256', '23/01/2024', 'Física', '567.860.123-45', '543.210.987-654', 0, 'Feminino ', '05/04/1995', 1, 'Mnop34556'),
('Diego Oliveira', 'diego@email.com', '(24) 99876-5432', '16/02/2024', 'Física', '210.987.654-32', '876.543.210-987', 0, 'Masculino', '16/03/2009', 0, 'AbCdE88hIjKlM'),
('Pedro Santos', 'pedro@email.com', '(31) 92468-1357', '02/02/2024', 'Física', '678.901.234-56', '345.678.901-234', 0, 'Masculino', '27/09/1992', 0, 'Efgh5678'),
('Giovana Oliveira', 'giovana@email.com', '(21) 99876-5678', '21/01/2024', 'Física', '456.779.012-34', '890.123.456-789', 0, 'Feminino ', '20/07/1985', 0, 'Efgy999978'),
('Empresa A', 'empresaA@example.com', '(11) 91234-5678', '01/04/2024', 'Jurídica', '12.345.678/0001-90', '321.098.765-432', 0, '', '', 0, '7yrghf64t'),
('Rafaela Silva', 'rafaela.s@email.com', '(17) 99876-5432', '04/03/2024', 'Física', '345.678.301-23', '765.432.109-876', 0, 'Feminino', '13/04/2005', 1, '8uydEfGhIjKl1'),
('Guilherme Lima', 'guilherme@email.com', '(33) 97530-8642', '12/02/2024', 'Física', '234.567.830-12', '109.876.543-210', 0, 'Masculino', '12/03/2009', 1, 'QqRrSsTtUuVv5'),
('Maria Oliveira', 'maria@email.com', '(21) 99876-5492', '16/01/2024', 'Física', '387.654.321-38', '', 1, 'Feminino ', '20/07/1985', 0, 'Efgh5678'),
('Lucas Oliveira', 'lucas@email.com', '(51) 97530-8642', '19/01/2024', 'Física', '345.678.501-23', '', 1, 'Masculino', '25/09/1982', 1, 'Qrst7890'),
('Gabriel Lima', 'gabriel@email.com', '(11) 91444-5674', '20/01/2024', 'Física', '783.012.345-67', '', 1, 'Masculino', '15/03/1990', 0, 'Abcd1994'),
('Guilherme Santos', 'guilherme@email.com', '(11) 92468-6789', '22/01/2024', 'Física', '301.234.567-83', '', 1, 'Outros', '10/11/1988', 0, 'Ijkl9018882'),
('Gustavo Oliveira', 'gustavo@email.com', '(11) 95530-8655', '24/01/2024', 'Física', '210.387.654-32', '', 1, 'Masculino', '25/09/1982', 0, 'Qrstyut7890'),
('Lívia Santos', 'livia@email.com', '(11) 93448-0046', '28/01/2024', 'Física', '321.038.765-43', '', 1, 'Outros ', '06/04/1992', 0, 'Muinop38896'),
('Luiz Oliveira', 'luiz@email.com', '(11) 97544-0642', '29/01/2024', 'Física', '654.321.098-76', '', 1, 'Masculino', '24/09/1992', 0, 'Muinop38897'),
('Maria Silva', 'maria@email.com', '(21) 99876-5432', '01/02/2024', 'Física', '434.109.876-54', '', 1, 'Feminino', '26/09/1992', 0, 'Abcd1234'),
('Ana Souza', 'ana@email.com', '(41) 93698-0246', '03/02/2024', 'Física', '987.654.341-43', '', 1, 'Feminino', '28/09/1992', 0, 'Ijkl9012'),
('Fernanda Oliveira', 'fernanda@email.com', '(12) 93456-7890', '05/02/2024', 'Física', '410.987.654-34', '', 1, 'Feminino', '30/09/1992', 0, 'Qrst7890'),
('Matheus Souza', 'matheus.s@email.com', '(42) 99876-5432', '08/02/2024', 'Física', '109.876.543-41', '', 1, 'Outros', '08/03/2009', 1, 'QrStUvWx9012'),
('Amanda Silva', 'amanda@email.com', '(52) 91234-5678', '09/02/2024', 'Física', '341.098.765-43', '', 1, 'Outros', '09/03/2009', 0, 'AaBbCcDdEe345'),
('Carolina Santos', 'carolina@email.com', '(23) 93698-0246', '11/02/2024', 'Física', '789.014.345-67', '', 1, 'Feminino', '11/03/2009', 0, 'KkLlMmNnOoPp1'),
('Isabela Souza', 'isabela@email.com', '(43) 93456-7890', '13/02/2024', 'Física', '456.789.014-34', '', 1, 'Feminino', '13/03/2009', 0, 'WwXxYyZz12345'),
('Larissa Santos', 'larissa@email.com', '(14) 96543-2109', '15/02/2024', 'Física', '987.654.341-98', '', 1, 'Feminino', '15/03/2009', 1, 'PpQqR6tUuVv'),
('Camila Lima', 'camila@email.com', '(34) 91234-5678', '17/02/2024', 'Física', '876.543.419-87', '', 1, 'Feminino', '17/03/2009', 0, 'AbC55hIjKlMn'),
('Mariana Oliveira', 'mariana.R@email.com', '(54) 93698-0246', '19/02/2024', 'Física', '543.410.987-65', '', 1, 'Feminino', '02/04/2005', 1, '9CdEfGhIjKlM1'),
('Fernando Oliveira', 'fernando@email.com', '(35) 99876-5432', '22/02/2024', 'Física', '432.109.876-54', '', 1, 'Outros', '05/04/2005', 0, '8bCdEfijIjKlM'),
('Natália Lima', 'natalia.l@email.com', '(45) 96543-2109', '23/02/2024', 'Física', '789.012.345-67', '', 1, 'Feminino', '06/04/2005', 1, 'hCdEfGhIjM5'),
('Gabriela Silva', 'gabriela@email.com', '(16) 91234-5678', '25/02/2024', 'Física', '109.876.543-21', '', 1, 'Feminino', '08/04/2005', 0, 'AbCdEfGhIjKlM'),
('Aline Lima', 'aline@email.com', '(36) 93698-0246', '01/03/2024', 'Física', '123.456.789-10', '', 1, 'Outros', '10/04/2005', 1, 'AbCdEfGhIjKlM'),
('Rodrigo Santos', 'rodrigo@email.com', '(27) 96543-2109', '05/03/2024', 'Física', '234.567.890-12', '', 1, 'Masculino', '14/04/2005', 0, '87yCdEfGhIjKl'),
('L¡via Lima', 'livia@email.com', '(37) 99876-5432', '06/03/2024', 'Física', '901.234.567-89', '', 1, 'Feminino', '10/05/2000', 0, 'hxCdEfGhIjKl1'),
('Mariana Santos', 'mariana@email.com', '(57) 92468-1357', '08/03/2024', 'Física', '543.210.987-65', '', 1, 'Feminino', '12/05/2000', 1, 'k7CdEfGhIjKl1'),
('Juliana Souza', 'juliana.s@email.com', '(28) 97530-8642', '10/03/2024', 'Física', '987.654.321-23', '', 1, 'Feminino', '14/05/2000', 0, 'AbCd7hIjKl18'),
('Natália Oliveira', 'natalia@email.com', '(48) 99876-5432', '12/03/2024', 'Física', '765.432.109-87', '', 1, 'Feminino', '16/05/2000', 1, 'AbCdEfGhIjKl2'),
('Lucas Santos', 'lucas@email.com', '(29) 92468-1357', '15/03/2024', 'Física', '890.123.456-78', '', 1, 'Masculino', '03/09/2010', 0, '99dEfGhIjKl23'),
('Carla Lima', 'carla@email.com', '(39) 93698-0246', '16/03/2024', 'Física', '456.789.012-34', '', 1, 'Feminino', '04/09/2010', 1, 'AbCdEfGhIjKl2'),
('Marcelo Santos', 'marcelo@email.com', '(59) 93456-7890', '18/03/2024', 'Física', '567.890.123-45', '', 1, 'Masculino', '06/09/2010', 0, '8dEfGhIjKl26'),
('Andrá Silva', 'andre@email.com', '(30) 96543-2109', '20/03/2024', 'Física', '987.654.321-98', '', 1, 'Masculino', '08/09/2010', 0, 'd6t4ugdu76'),
('Empresa E', 'empresaE@example.com', '(55) 97530-8642', '05/04/2024', 'Jurídica', '34.567.890/0001-56', '', 1, '', '', 0, '7drfe4dt65'),
('Empresa N', 'empresaN@example.com', '(54) 93456-7890', '14/04/2024', 'Jurídica', '32.109.876/0001-65', '', 1, '', '', 0, '8ty4h3j8f'),
('Empresa T', 'empresaT@example.com', '(20) 93698-0246', '20/04/2024', 'Jurídica', '12.345.678/0001-11', '', 1, '', '', 0, 'AbtEfGhIjKlMn');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
