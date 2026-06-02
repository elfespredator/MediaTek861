-- phpMyAdmin SQL Dump
-- version 5.2.3
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le : mar. 02 juin 2026 à 21:43
-- Version du serveur : 8.4.7
-- Version de PHP : 8.3.28

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `mediatek86`
--

-- --------------------------------------------------------

--
-- Structure de la table `absence`
--

DROP TABLE IF EXISTS `absence`;
CREATE TABLE IF NOT EXISTS `absence` (
  `id` int NOT NULL AUTO_INCREMENT,
  `idPersonnel` int NOT NULL,
  `dateDebut` date NOT NULL,
  `dateFin` date NOT NULL,
  `idMotif` int NOT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_absence_personnel` (`idPersonnel`),
  KEY `fk_absence_motif` (`idMotif`)
) ENGINE=MyISAM AUTO_INCREMENT=51 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table `absence`
--

INSERT INTO `absence` (`id`, `idPersonnel`, `dateDebut`, `dateFin`, `idMotif`) VALUES
(1, 1, '2024-01-08', '2024-01-12', 1),
(2, 1, '2024-04-15', '2024-04-19', 2),
(3, 1, '2024-07-22', '2024-08-02', 1),
(4, 2, '2024-02-05', '2024-02-07', 2),
(5, 2, '2024-05-13', '2024-05-17', 1),
(6, 2, '2024-10-21', '2024-10-25', 3),
(7, 3, '2024-01-15', '2024-01-26', 4),
(8, 3, '2024-03-04', '2024-03-08', 2),
(9, 3, '2024-06-17', '2024-06-21', 1),
(10, 3, '2024-09-02', '2024-09-06', 3),
(11, 4, '2024-02-19', '2024-02-23', 1),
(12, 4, '2024-05-06', '2024-05-10', 2),
(13, 4, '2024-08-12', '2024-08-23', 1),
(14, 5, '2024-01-22', '2024-01-26', 3),
(15, 5, '2024-04-08', '2024-04-12', 2),
(16, 5, '2024-07-01', '2024-07-19', 1),
(17, 5, '2024-11-04', '2024-11-08', 2),
(18, 6, '2024-02-12', '2024-02-16', 1),
(19, 6, '2024-06-03', '2024-06-07', 2),
(20, 6, '2024-09-16', '2024-09-27', 4),
(21, 7, '2024-01-29', '2024-02-02', 2),
(22, 7, '2024-05-20', '2024-05-24', 1),
(23, 7, '2024-08-05', '2024-08-09', 3),
(24, 7, '2024-12-02', '2024-12-06', 2),
(25, 8, '2024-03-11', '2024-03-15', 1),
(26, 8, '2024-07-08', '2024-07-19', 1),
(27, 8, '2024-10-14', '2024-10-18', 2),
(28, 9, '2024-01-02', '2024-01-05', 3),
(29, 9, '2024-04-22', '2024-04-26', 2),
(30, 9, '2024-08-26', '2024-09-06', 1),
(31, 10, '2024-02-26', '2024-03-01', 2),
(32, 10, '2024-06-10', '2024-06-14', 1),
(33, 10, '2024-09-23', '2024-10-04', 4),
(34, 11, '2024-01-08', '2024-01-12', 1),
(35, 11, '2024-03-18', '2024-03-22', 2),
(36, 11, '2024-07-15', '2024-07-26', 1),
(37, 11, '2024-11-11', '2024-11-15', 3),
(38, 12, '2024-02-05', '2024-02-09', 2),
(39, 12, '2024-05-27', '2024-05-31', 1),
(40, 12, '2024-09-09', '2024-09-13', 2),
(41, 1, '2024-11-18', '2024-11-22', 3),
(42, 2, '2024-12-09', '2024-12-13', 1),
(43, 3, '2024-10-28', '2024-11-01', 2),
(44, 4, '2024-11-25', '2024-11-29', 1),
(45, 5, '2024-12-16', '2024-12-20', 3),
(46, 6, '2024-10-07', '2024-10-11', 2),
(47, 7, '2024-11-04', '2024-11-15', 4),
(48, 8, '2024-12-23', '2024-12-27', 1),
(49, 9, '2024-11-18', '2024-11-22', 2),
(50, 10, '2024-12-02', '2024-12-06', 1);

-- --------------------------------------------------------

--
-- Structure de la table `motif`
--

DROP TABLE IF EXISTS `motif`;
CREATE TABLE IF NOT EXISTS `motif` (
  `id` int NOT NULL AUTO_INCREMENT,
  `libelle` varchar(100) COLLATE utf8mb4_unicode_ci NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table `motif`
--

INSERT INTO `motif` (`id`, `libelle`) VALUES
(1, 'Vacances'),
(2, 'Maladie'),
(3, 'Motif familial'),
(4, 'Congé parental');

-- --------------------------------------------------------

--
-- Structure de la table `personnel`
--

DROP TABLE IF EXISTS `personnel`;
CREATE TABLE IF NOT EXISTS `personnel` (
  `id` int NOT NULL AUTO_INCREMENT,
  `nom` varchar(100) COLLATE utf8mb4_unicode_ci NOT NULL,
  `prenom` varchar(100) COLLATE utf8mb4_unicode_ci NOT NULL,
  `tel` varchar(20) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `mail` varchar(150) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `idService` int NOT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_personnel_service` (`idService`)
) ENGINE=MyISAM AUTO_INCREMENT=13 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table `personnel`
--

INSERT INTO `personnel` (`id`, `nom`, `prenom`, `tel`, `mail`, `idService`) VALUES
(1, 'Martin', 'Sophie', '0549112233', 'sophie.martin@mediatek86.fr', 1),
(2, 'Dubois', 'Luc', '0549223344', 'luc.dubois@mediatek86.fr', 1),
(3, 'Bernard', 'Claire', '0549334455', 'claire.bernard@mediatek86.fr', 2),
(4, 'Moreau', 'Thomas', '0549445566', 'thomas.moreau@mediatek86.fr', 2),
(5, 'Petit', 'Inès', '0549556677', 'ines.petit@mediatek86.fr', 2),
(6, 'Robert', 'Kevin', '0549667788', 'kevin.robert@mediatek86.fr', 3),
(7, 'Richard', 'Lucie', '0549778899', 'lucie.richard@mediatek86.fr', 3),
(8, 'Simon', 'Marc', '0549889900', 'marc.simon@mediatek86.fr', 3),
(9, 'Laurent', 'Amélie', '0549900011', 'amelie.laurent@mediatek86.fr', 1),
(10, 'Leroy', 'Nicolas', '0549011122', 'nicolas.leroy@mediatek86.fr', 2),
(11, 'Fournier', 'Camille', '0549122233', 'camille.fournier@mediatek86.fr', 3),
(12, 'Garcia', 'Julien', '0549233344', 'julien.garcia@mediatek86.fr', 1);

-- --------------------------------------------------------

--
-- Structure de la table `responsable`
--

DROP TABLE IF EXISTS `responsable`;
CREATE TABLE IF NOT EXISTS `responsable` (
  `login` varchar(64) COLLATE utf8mb4_unicode_ci NOT NULL,
  `pwd` varchar(64) COLLATE utf8mb4_unicode_ci NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table `responsable`
--

INSERT INTO `responsable` (`login`, `pwd`) VALUES
('test', '9f86d081884c7d659a2feaa0c55ad015a3bf4f1b2b0b822cd15d6c15b0f00a08');

-- --------------------------------------------------------

--
-- Structure de la table `service`
--

DROP TABLE IF EXISTS `service`;
CREATE TABLE IF NOT EXISTS `service` (
  `id` int NOT NULL AUTO_INCREMENT,
  `nom` varchar(100) COLLATE utf8mb4_unicode_ci NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table `service`
--

INSERT INTO `service` (`id`, `nom`) VALUES
(1, 'Administratif'),
(2, 'Médiation culturelle'),
(3, 'Prêt');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
