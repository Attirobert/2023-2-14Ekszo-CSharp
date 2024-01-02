-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2024. Jan 02. 18:43
-- Kiszolgáló verziója: 10.4.28-MariaDB
-- PHP verzió: 8.1.17

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Adatbázis: `wpfmysql`
--
CREATE DATABASE IF NOT EXISTS `wpfmysql` DEFAULT CHARACTER SET utf8 COLLATE utf8_hungarian_ci;
USE `wpfmysql`;

DELIMITER $$
--
-- Eljárások
--
CREATE DEFINER=`root`@`localhost` PROCEDURE `DeletePerson` (IN `pId` INT(11))   DELETE FROM `persons` WHERE `id` = pId$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `InsertPerson` (IN `pName` VARCHAR(20))   INSERT INTO `persons`(`name`) VALUES (pName)$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `PersonsAll` ()   Select * from persons$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `UpdatePerson` (IN `pName` VARCHAR(20), IN `pId` INT(11))   UPDATE `persons` SET `name`= pName WHERE `id`= pId$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `persons`
--

CREATE TABLE `persons` (
  `id` int(11) NOT NULL,
  `name` varchar(20) NOT NULL,
  `Jelszo` varchar(10) NOT NULL,
  `Admin` tinyint(1) NOT NULL DEFAULT 0,
  `Neme` varchar(5) NOT NULL DEFAULT 'Férfi',
  `Szulev` date DEFAULT NULL,
  `Email` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_hungarian_ci;

--
-- A tábla adatainak kiíratása `persons`
--

INSERT INTO `persons` (`id`, `name`, `Jelszo`, `Admin`, `Neme`, `Szulev`, `Email`) VALUES
(1, 'Attila', '', 0, 'Férfi', NULL, ''),
(7, 'Zsuzsika', '', 0, 'Férfi', NULL, ''),
(9, 'István', '', 0, 'Férfi', NULL, '');

--
-- Indexek a kiírt táblákhoz
--

--
-- A tábla indexei `persons`
--
ALTER TABLE `persons`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `idx_name` (`name`);

--
-- A kiírt táblák AUTO_INCREMENT értéke
--

--
-- AUTO_INCREMENT a táblához `persons`
--
ALTER TABLE `persons`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
