-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Aug 29, 2021 at 02:20 PM
-- Server version: 10.4.20-MariaDB
-- PHP Version: 8.0.8

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `la_ratatouille`
--

-- --------------------------------------------------------

--
-- Table structure for table `clientes`
--

CREATE TABLE `clientes` (
  `nome` char(40) NOT NULL,
  `telefone` int(11) NOT NULL,
  `email` char(30) NOT NULL,
  `password` char(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `clientes`
--

INSERT INTO `clientes` (`nome`, `telefone`, `email`, `password`) VALUES
('Henrique', 1255479562, 'rapazmacaco@gmail.com', '123456789');

-- --------------------------------------------------------

--
-- Table structure for table `menu`
--

CREATE TABLE `menu` (
  `seccao` char(15) NOT NULL,
  `prato` char(50) NOT NULL,
  `preco` int(11) NOT NULL,
  `descricao` char(120) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `menu`
--

INSERT INTO `menu` (`seccao`, `prato`, `preco`, `descricao`) VALUES
('Carne', 'Coq au Vin', 12, 'Galinha refogada com vinho, cogumelos e bacon'),
('Carne', 'Cassoulet', 13, 'Cozido de feijão branco com carne'),
('Carne', 'Boeuf Bourguignon', 14, 'Cozido de carne temperado com vinho vermelho e vegetais'),
('Carne', 'Confit de Canard', 10, 'Carne de pato marinada em sal e alho'),
('Carne', 'Tournedos à la Bordelaise', 11, 'Bifes de lombo de vaca grossos e redondos tostados na frigideira com molho bordelaise'),
('Peixe', 'Lamproie à la Bordelaise', 13, 'Lampreia cozida com presunto curado, vinho tinto, ervas frescas e vegetais'),
('Peixe', 'Thon Basquaise', 10, 'Bifes de atum com azeite, cebola, alho, tomate e pimentão vermelho'),
('Peixe', 'Saumon à Loseille', 11, 'Filé de salmão com azeda em molho cremoso de peixe'),
('Peixe', 'Bourride', 14, 'Cozido de cavalinha com vegetais e molho aioli'),
('Vegetariano', 'Ratatouille', 9, 'Vegetais fritos colocados numa cassarola e levados ao forno'),
('Vegetariano', 'Flamiche', 9, 'Massa folhada recheada com queijo e vegetais'),
('Saladas', 'Salade Niçoise', 8, 'Tomates frescos, anchovas, azeitonas pretas, alcaparras, feijão e um fiozinho de sumo de limão'),
('Saladas', 'Salade Rachel', 9, 'Aipo, trufas, alcachofras, batatas cozidas, aspargos e maionese'),
('Saladas', 'Salade Paysanne', 7, 'Alface, presunto, toucinho, queijo, nozes, tomates, batatas e ovos cozidos'),
('Sopas', 'Soupe à Loignon', 7, 'Sopa de cebola e caldo de carne servida com croutons'),
('Sopas', 'Soupe de Poissons', 8, 'Sopa de peixe branco com tomates picados, raspas de laranja e purê'),
('Sopas', 'Bisque', 8, 'Caldo de crustáceos engrossado com crème fraîche');

-- --------------------------------------------------------

--
-- Table structure for table `reservas`
--

CREATE TABLE `reservas` (
  `hora` char(10) NOT NULL,
  `npessoas` int(11) NOT NULL,
  `email` char(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `reservas`
--

INSERT INTO `reservas` (`hora`, `npessoas`, `email`) VALUES
('Jantar', 4, 'rapazmacaco@gmail.com');

-- --------------------------------------------------------

--
-- Table structure for table `staff`
--

CREATE TABLE `staff` (
  `user` char(20) NOT NULL,
  `pass` char(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `staff`
--

INSERT INTO `staff` (`user`, `pass`) VALUES
('admin', 'ADMIN'),
('staff1', 'pass1'),
('staff2', 'pass2');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `clientes`
--
ALTER TABLE `clientes`
  ADD PRIMARY KEY (`email`);

--
-- Indexes for table `reservas`
--
ALTER TABLE `reservas`
  ADD PRIMARY KEY (`email`);

--
-- Constraints for dumped tables
--

--
-- Constraints for table `reservas`
--
ALTER TABLE `reservas`
  ADD CONSTRAINT `reservas_ibfk_1` FOREIGN KEY (`email`) REFERENCES `clientes` (`Email`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
