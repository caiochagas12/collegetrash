CREATE DATABASE  IF NOT EXISTS `banquinho_saude` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */;
USE `banquinho_saude`;
-- MySQL dump 10.13  Distrib 8.0.13, for Win64 (x86_64)
--
-- Host: localhost    Database: banquinho_saude
-- ------------------------------------------------------
-- Server version	8.0.13

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
 SET NAMES utf8 ;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `animal`
--

DROP TABLE IF EXISTS `animal`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `animal` (
  `id_animal` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(25) NOT NULL,
  `sexo` enum('M','F') DEFAULT NULL,
  `raca` varchar(53) DEFAULT NULL,
  `idade` char(3) DEFAULT NULL,
  `data_nascimento` varchar(8) DEFAULT NULL,
  `tipo` varchar(12) DEFAULT NULL,
  `porte` varchar(8) DEFAULT NULL,
  `descri` varchar(250) DEFAULT NULL,
  PRIMARY KEY (`id_animal`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `animal`
--

LOCK TABLES `animal` WRITE;
/*!40000 ALTER TABLE `animal` DISABLE KEYS */;
INSERT INTO `animal` VALUES (1,'spike','M','bolldoguie','2','01012017','cachorro','PP','forte'),(2,'sofi','M','pastor','1','pp','cachorro','01012018','frote'),(3,'pernalonga','M','dogmal','2','gg','dinossauro','01022017','brabo'),(4,'bingo','M','pastor','3','gg','cachorro','01022016','com saude');
/*!40000 ALTER TABLE `animal` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `dono`
--

DROP TABLE IF EXISTS `dono`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `dono` (
  `id_dono` int(11) NOT NULL AUTO_INCREMENT,
  `nomes` varchar(150) DEFAULT NULL,
  `cpf` char(9) NOT NULL,
  `email` varchar(60) DEFAULT NULL,
  `endereco` varchar(50) DEFAULT NULL,
  `telefone` varchar(17) DEFAULT NULL,
  `cidade` varchar(30) DEFAULT NULL,
  `estado` varchar(40) DEFAULT NULL,
  `data_nascimentos` varchar(8) DEFAULT NULL,
  PRIMARY KEY (`id_dono`,`cpf`),
  UNIQUE KEY `cpf` (`cpf`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `dono`
--

LOCK TABLES `dono` WRITE;
/*!40000 ALTER TABLE `dono` DISABLE KEYS */;
INSERT INTO `dono` VALUES (1,'bábara von hedwing stofenberg correia da silva santos','123456789','sla@gmail.com.br','rua alencar','9812432974','recife','pernambuco','02012000'),(9,'ruan','12345678','ruan@eu.com','logo ali','2335654','recife','pernambuco','01022000'),(10,'josefa','123456478','josefa@eu.com','rua santa tereza','123456789','recife','pernambuco','03011971');
/*!40000 ALTER TABLE `dono` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `funcionario`
--

DROP TABLE IF EXISTS `funcionario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `funcionario` (
  `id_funcionario` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(150) DEFAULT NULL,
  `sexo` enum('M','F') DEFAULT NULL,
  `cpf` char(9) NOT NULL,
  `data_nascimento` date DEFAULT NULL,
  `email` varchar(78) DEFAULT NULL,
  `telefone` varchar(17) DEFAULT NULL,
  `funcao` varchar(50) DEFAULT NULL,
  `endereco` varchar(80) DEFAULT NULL,
  `salario` float DEFAULT NULL,
  `pis_pasep` char(11) DEFAULT NULL,
  PRIMARY KEY (`id_funcionario`,`cpf`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `funcionario`
--

LOCK TABLES `funcionario` WRITE;
/*!40000 ALTER TABLE `funcionario` DISABLE KEYS */;
INSERT INTO `funcionario` VALUES (1,'elelton junior','M','9484646','1989-12-02','eleltonjru@hotmail.com.br','416848','estagiario','rua pqpqn2',200,'5465841');
/*!40000 ALTER TABLE `funcionario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `login_cadastro`
--

DROP TABLE IF EXISTS `login_cadastro`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `login_cadastro` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Lastname` varchar(40) DEFAULT NULL,
  `Firstname` varchar(50) DEFAULT NULL,
  `Senha` varchar(38) NOT NULL,
  `Email` varchar(80) DEFAULT NULL,
  PRIMARY KEY (`ID`,`Senha`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `login_cadastro`
--

LOCK TABLES `login_cadastro` WRITE;
/*!40000 ALTER TABLE `login_cadastro` DISABLE KEYS */;
INSERT INTO `login_cadastro` VALUES (1,'maria do grau','maria do grau','arlauakbar','mariaboladinha_Bol@gmail.com.br'),(3,'maria do breginha','geraldo','123','mariadobrega@gmail.com'),(4,'maria do baile','bacteria','1bailao','mariabaile@kond.com'),(5,'maria do bailao','geroso','zebostola','mariadobailao@kondzilla.com'),(6,'maria do culto','nuncei','12universal','maria@universal.ig'),(7,'maria do padre','alcantra','padee5','que isso'),(8,'maria gasolina','faro','5,00 o litro','mariaVpower@shell.com'),(9,'henrique','ruan','123','ruan@eu.com');
/*!40000 ALTER TABLE `login_cadastro` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `medicamento`
--

DROP TABLE IF EXISTS `medicamento`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `medicamento` (
  `id_medicamento` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(100) NOT NULL,
  `tipo` varchar(29) DEFAULT NULL,
  `quantidade` int(10) unsigned DEFAULT NULL,
  `informativo` text,
  `validade` date DEFAULT NULL,
  PRIMARY KEY (`id_medicamento`,`nome`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `medicamento`
--

LOCK TABLES `medicamento` WRITE;
/*!40000 ALTER TABLE `medicamento` DISABLE KEYS */;
INSERT INTO `medicamento` VALUES (1,'penicilina','antibiótico',1000,'e bom desde 1928 salvando vidas raiz','2025-12-30');
/*!40000 ALTER TABLE `medicamento` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2019-11-26 21:28:04
