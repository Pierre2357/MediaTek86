-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le : jeu. 05 juin 2025 à 12:58
-- Version du serveur : 9.1.0
-- Version de PHP : 8.3.14

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `mediatek`
--
CREATE DATABASE IF NOT EXISTS `mediatek` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci;
USE `mediatek`;

-- --------------------------------------------------------

--
-- Structure de la table `absence`
--

DROP TABLE IF EXISTS `absence`;
CREATE TABLE `absence` (
  `idpersonnel` int NOT NULL,
  `datedebut` datetime NOT NULL,
  `datefin` datetime DEFAULT NULL,
  `idmotif` int NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table `absence`
--

INSERT INTO `absence` (`idpersonnel`, `datedebut`, `datefin`, `idmotif`) VALUES
(9, '2024-11-07 07:49:37', '2025-05-18 16:45:47', 3),
(3, '2025-10-17 16:53:20', '2026-03-27 10:23:00', 2),
(9, '2025-10-03 10:55:39', '2025-08-13 14:15:03', 2),
(4, '2025-11-04 14:02:24', '2025-10-17 04:20:42', 1),
(9, '2026-03-24 07:16:50', '2025-01-25 12:48:43', 2),
(7, '2025-10-21 22:23:25', '2025-03-18 11:57:33', 3),
(7, '2025-09-15 05:49:20', '2026-03-30 06:06:00', 1),
(7, '2024-06-15 06:04:32', '2024-11-22 01:03:07', 2),
(4, '2026-02-02 01:21:59', '2025-11-01 11:31:46', 2),
(9, '2026-04-25 04:35:57', '2026-04-26 03:47:52', 2),
(1, '2025-04-03 03:15:02', '2025-05-05 22:51:57', 3),
(9, '2025-11-09 23:12:49', '2025-05-08 12:21:49', 2),
(1, '2025-10-29 20:34:06', '2026-01-25 02:45:20', 2),
(9, '2026-04-12 17:42:45', '2025-11-06 19:13:55', 4),
(3, '2024-10-12 15:07:11', '2026-05-04 07:52:29', 2),
(4, '2024-10-28 22:39:08', '2025-08-06 11:50:42', 3),
(7, '2026-05-19 06:19:47', '2025-10-20 20:41:55', 3),
(5, '2026-03-13 14:14:04', '2026-02-14 18:45:48', 3),
(10, '2024-10-08 13:24:13', '2025-08-19 13:32:19', 4),
(6, '2024-08-29 08:32:51', '2025-11-30 15:51:22', 3),
(9, '2025-11-09 04:29:57', '2025-10-29 10:46:25', 4),
(6, '2026-02-03 00:53:23', '2025-12-03 23:02:11', 3),
(5, '2025-09-26 19:06:09', '2025-11-26 15:58:22', 3),
(6, '2026-05-27 17:53:13', '2026-04-09 18:03:25', 2),
(8, '2024-07-28 06:57:08', '2025-10-21 02:20:36', 4),
(3, '2024-10-04 19:26:56', '2025-12-06 07:26:21', 4),
(6, '2025-08-17 16:23:18', '2025-07-16 19:18:23', 4),
(8, '2025-05-03 01:23:09', '2026-04-29 20:58:18', 3),
(4, '2025-12-20 18:35:33', '2025-12-13 19:41:35', 4),
(8, '2024-10-02 13:58:08', '2024-11-12 01:18:28', 3),
(2, '2025-06-20 13:46:50', '2025-06-28 13:46:50', 2),
(6, '2026-03-08 10:04:22', '2025-05-23 17:51:58', 1),
(10, '2026-02-19 04:16:19', '2024-12-10 10:24:14', 1),
(5, '2025-11-16 17:33:21', '2026-04-20 10:27:59', 4),
(7, '2025-10-17 10:14:20', '2025-01-28 07:56:24', 4),
(6, '2025-09-20 07:26:47', '2025-09-07 04:55:11', 3),
(6, '2025-03-15 06:03:00', '2026-02-10 15:06:50', 3),
(4, '2026-03-18 09:17:23', '2025-06-05 16:36:06', 3),
(3, '2026-02-02 02:40:26', '2025-12-06 09:51:47', 1),
(2, '2025-06-04 13:46:50', '2025-06-15 13:46:50', 1),
(1, '2026-01-23 13:28:01', '2024-11-11 05:58:23', 2),
(3, '2025-07-09 09:58:16', '2025-12-16 15:23:52', 2),
(9, '2025-02-15 06:43:46', '2025-04-29 08:30:49', 2),
(5, '2025-02-22 13:43:06', '2026-04-17 18:52:11', 4),
(3, '2026-01-20 09:44:27', '2024-07-23 18:19:57', 3),
(5, '2025-07-15 19:05:12', '2025-08-26 06:12:42', 2),
(3, '2025-11-18 03:57:09', '2025-11-04 20:01:44', 3),
(9, '2025-03-29 15:53:48', '2025-06-15 22:46:02', 2);

-- --------------------------------------------------------

--
-- Structure de la table `motif`
--

DROP TABLE IF EXISTS `motif`;
CREATE TABLE `motif` (
  `idmotif` int NOT NULL,
  `libelle` varchar(128) COLLATE utf8mb4_unicode_ci DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table `motif`
--

INSERT INTO `motif` (`idmotif`, `libelle`) VALUES
(1, 'vacances'),
(2, 'maladie'),
(3, 'motif familial'),
(4, 'conge parental');

-- --------------------------------------------------------

--
-- Structure de la table `personnel`
--

DROP TABLE IF EXISTS `personnel`;
CREATE TABLE `personnel` (
  `idpersonnel` int NOT NULL,
  `nom` varchar(50) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `prenom` varchar(50) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `tel` varchar(15) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `mail` varchar(128) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `idservice` int NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table `personnel`
--

INSERT INTO `personnel` (`idpersonnel`, `nom`, `prenom`, `tel`, `mail`, `idservice`) VALUES
(1, 'Fulton', 'Reese', '04 11 84 72 43', 'aliquam.nec@google.org', 2),
(2, 'Adam', 'Rose', '05 57 53 11 21', 'amet.ultricies@icloud.org', 2),
(3, 'Wilma', ' Davenport', '02 59 16 81 12', 'parturient.montes.nascetur@protonmail.net', 3),
(4, 'Clarke', 'Lucas', '09 12 56 78 22', 'scelerisque@hotmail.com', 1),
(5, 'Owen', 'Webster', '03 41 61 66 00', 'placerat@outlook.org', 1),
(6, 'Stone', 'Burch', '02 11 47 52 82', 'mauris@outlook.couk', 2),
(7, 'Vladimir', 'Byrd', '03 39 14 54 30', 'in.nec.orci@google.com', 2),
(8, 'Jamalia', 'Ingram', '04 74 60 23 75', 'aenean.euismod@hotmail.com', 2),
(9, 'Nasim', 'West', '03 28 20 62 71', 'aliquam.erat.volutpat@protonmail.com', 3),
(10, 'Rose', 'Atkinson', '04 88 81 43 50', 'vel@yahoo.ca', 3);

-- --------------------------------------------------------

--
-- Structure de la table `responsable`
--

DROP TABLE IF EXISTS `responsable`;
CREATE TABLE `responsable` (
  `login` varchar(64) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `pwd` varchar(64) COLLATE utf8mb4_unicode_ci DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table `responsable`
--

INSERT INTO `responsable` (`login`, `pwd`) VALUES
('ResponsableMediaTek', 'defb2266560c03034866c429360707f1e271eda6424cff751d96da4eaa8708a7');

-- --------------------------------------------------------

--
-- Structure de la table `service`
--

DROP TABLE IF EXISTS `service`;
CREATE TABLE `service` (
  `idservice` int NOT NULL,
  `nom` varchar(50) COLLATE utf8mb4_unicode_ci DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table `service`
--

INSERT INTO `service` (`idservice`, `nom`) VALUES
(1, 'administratif'),
(2, 'médiation culturelle'),
(3, 'prêt');

--
-- Index pour les tables déchargées
--

--
-- Index pour la table `absence`
--
ALTER TABLE `absence`
  ADD PRIMARY KEY (`idpersonnel`,`datedebut`),
  ADD KEY `idmotif` (`idmotif`);

--
-- Index pour la table `motif`
--
ALTER TABLE `motif`
  ADD PRIMARY KEY (`idmotif`);

--
-- Index pour la table `personnel`
--
ALTER TABLE `personnel`
  ADD PRIMARY KEY (`idpersonnel`),
  ADD KEY `idservice` (`idservice`);

--
-- Index pour la table `service`
--
ALTER TABLE `service`
  ADD PRIMARY KEY (`idservice`);

--
-- AUTO_INCREMENT pour les tables déchargées
--

--
-- AUTO_INCREMENT pour la table `motif`
--
ALTER TABLE `motif`
  MODIFY `idmotif` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT pour la table `personnel`
--
ALTER TABLE `personnel`
  MODIFY `idpersonnel` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;

--
-- AUTO_INCREMENT pour la table `service`
--
ALTER TABLE `service`
  MODIFY `idservice` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

DROP USER IF EXISTS 'user'@'%';
CREATE USER 'user'@'%' IDENTIFIED BY 'Userp@ssword';

GRANT SELECT, INSERT, UPDATE, DELETE, CREATE, DROP, RELOAD, 
SHUTDOWN, PROCESS, FILE, REFERENCES, INDEX, ALTER, SHOW DATABASES, 
SUPER, CREATE TEMPORARY TABLES, LOCK TABLES, EXECUTE, REPLICATION SLAVE, 
REPLICATION CLIENT, CREATE VIEW, SHOW VIEW, CREATE ROUTINE, ALTER ROUTINE, 
CREATE USER, EVENT, TRIGGER, CREATE TABLESPACE, CREATE ROLE, DROP ROLE ON *.* TO `user`@`%`;

GRANT ALLOW_NONEXISTENT_DEFINER,APPLICATION_PASSWORD_ADMIN,AUDIT_ABORT_EXEMPT,
AUDIT_ADMIN,AUTHENTICATION_POLICY_ADMIN,BACKUP_ADMIN,BINLOG_ADMIN,BINLOG_ENCRYPTION_ADMIN,
CLONE_ADMIN,CONNECTION_ADMIN,ENCRYPTION_KEY_ADMIN,FIREWALL_EXEMPT,FLUSH_OPTIMIZER_COSTS,
FLUSH_PRIVILEGES,FLUSH_STATUS,FLUSH_TABLES,FLUSH_USER_RESOURCES,GROUP_REPLICATION_ADMIN,
GROUP_REPLICATION_STREAM,INNODB_REDO_LOG_ARCHIVE,INNODB_REDO_LOG_ENABLE,OPTIMIZE_LOCAL_TABLE,
PASSWORDLESS_USER_ADMIN,PERSIST_RO_VARIABLES_ADMIN,REPLICATION_APPLIER,REPLICATION_SLAVE_ADMIN,
RESOURCE_GROUP_ADMIN,RESOURCE_GROUP_USER,ROLE_ADMIN,SENSITIVE_VARIABLES_OBSERVER,
SERVICE_CONNECTION_ADMIN,SESSION_VARIABLES_ADMIN,SET_ANY_DEFINER,SHOW_ROUTINE,SYSTEM_USER,
SYSTEM_VARIABLES_ADMIN,TABLE_ENCRYPTION_ADMIN,TELEMETRY_LOG_ADMIN,TRANSACTION_GTID_TAG,
XA_RECOVER_ADMIN ON *.* TO `user`@`%`;