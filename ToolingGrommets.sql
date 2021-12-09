CREATE DATABASE  IF NOT EXISTS `Tooling` /*!40100 DEFAULT CHARACTER SET latin1 */;
USE `Tooling`;
-- MySQL dump 10.13  Distrib 8.0.26, for Win64 (x86_64)
--
-- Host: 10.56.12.100    Database: Tooling
-- ------------------------------------------------------
-- Server version	5.7.23-0ubuntu0.18.04.1

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `ADMIN`
--

DROP TABLE IF EXISTS `ADMIN`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `ADMIN` (
  `IDLOGIN` varchar(255) NOT NULL,
  `PASSWORD` varchar(255) DEFAULT NULL,
  `NOMBRE` varchar(255) DEFAULT NULL,
  `APELLIDO` varchar(255) DEFAULT NULL,
  `EMAIL` varchar(255) DEFAULT NULL,
  `RECIBEEMAIL` varchar(1) DEFAULT NULL,
  `MENU` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`IDLOGIN`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `CAMBIO`
--

DROP TABLE IF EXISTS `CAMBIO`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `CAMBIO` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `EMPLEADO` varchar(15) DEFAULT NULL,
  `LINEA` varchar(10) DEFAULT NULL,
  `NUEVOSOLICITADO` varchar(45) DEFAULT NULL,
  `FECHASOLICITUD` datetime DEFAULT NULL,
  `ANTERIOR` varchar(45) DEFAULT NULL,
  `NUEVOINSTALADO` varchar(45) DEFAULT NULL,
  `FECHACAMBIO` datetime DEFAULT NULL,
  `TECNICO` varchar(45) DEFAULT NULL,
  `TM` varchar(45) DEFAULT '0',
  `STATUS` varchar(10) DEFAULT NULL,
  `FLAGBLOCK` int(11) DEFAULT '0',
  `FLAGPE` int(11) DEFAULT '0',
  `LAINALADO1` decimal(6,4) DEFAULT '0.0000',
  `LAINALADO2` decimal(6,4) DEFAULT '0.0000',
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=452 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `CONTROL`
--

DROP TABLE IF EXISTS `CONTROL`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `CONTROL` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `SETID` varchar(45) DEFAULT NULL,
  `countplate` int(10) DEFAULT NULL,
  `length` varchar(45) DEFAULT NULL,
  `desgaste` varchar(45) DEFAULT NULL,
  `ProduccionControl` bigint(50) DEFAULT NULL,
  `Alarm` tinyint(4) DEFAULT '0',
  `Email` tinyint(4) DEFAULT '0',
  `Email50` tinyint(4) DEFAULT '0',
  `Tipo` varchar(10) DEFAULT NULL,
  `Area` varchar(10) DEFAULT '0',
  `Marca` varchar(10) DEFAULT '0',
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=315 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `CONTROLSET`
--

DROP TABLE IF EXISTS `CONTROLSET`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `CONTROLSET` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `SETID` varchar(45) DEFAULT NULL,
  `Tooling` varchar(45) DEFAULT NULL,
  `Color` varchar(45) DEFAULT NULL,
  `Diametro` varchar(45) DEFAULT NULL,
  `FechaEntrada` datetime DEFAULT NULL,
  `TipeRunner` varchar(45) DEFAULT NULL,
  `IDColor` varchar(45) DEFAULT NULL,
  `Cantidad` varchar(45) DEFAULT NULL,
  `Tipo` varchar(45) DEFAULT NULL,
  `Status` varchar(45) DEFAULT NULL,
  `Linea` varchar(45) DEFAULT '- - - - -',
  `Produccion` int(50) DEFAULT '0',
  `Porcentaje` decimal(5,2) DEFAULT '0.00',
  `Vida` varchar(45) DEFAULT '- - - - -',
  `NParte` varchar(50) DEFAULT '- - - - -',
  `NBatch` varchar(45) DEFAULT '- - - - -',
  `LineHist` varchar(45) DEFAULT NULL,
  `AjustProd` int(50) DEFAULT '0',
  `Area` varchar(45) DEFAULT NULL,
  `Marca` varchar(45) DEFAULT '0',
  `SETSCANANT` varchar(45) DEFAULT NULL,
  `PlateQty` int(11) DEFAULT NULL,
  `Gauge` varchar(10) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=268603 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `CREATESET`
--

DROP TABLE IF EXISTS `CREATESET`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `CREATESET` (
  `idCREATESET` int(11) NOT NULL AUTO_INCREMENT,
  `fechabaja_ant` datetime DEFAULT NULL,
  `tooling` varchar(45) DEFAULT NULL,
  `color` varchar(45) DEFAULT NULL,
  `diametro` varchar(45) DEFAULT NULL,
  `tiperunner` varchar(45) DEFAULT NULL,
  `IDcolor` varchar(45) DEFAULT NULL,
  `cantidad` int(11) DEFAULT NULL,
  `tipo` varchar(45) DEFAULT NULL,
  `status` varchar(45) DEFAULT NULL,
  `numeroparte` varchar(45) DEFAULT NULL,
  `colorant` varchar(45) DEFAULT NULL,
  `retirar_ant` tinyint(4) DEFAULT '0',
  `fecha_ret_ant` datetime DEFAULT NULL,
  `empleado_ret_ant` varchar(45) DEFAULT NULL,
  `numvale` varchar(45) DEFAULT NULL,
  `revdimensiones` tinyint(4) DEFAULT '0',
  `revdimensiones_fecha` datetime DEFAULT NULL,
  `revdimensiones_emp` varchar(45) DEFAULT NULL,
  `singolpes` tinyint(4) DEFAULT '0',
  `singolpes_fecha` datetime DEFAULT NULL,
  `singolpes_emp` varchar(45) DEFAULT NULL,
  `armar` tinyint(4) DEFAULT NULL,
  `armar_fecha` datetime DEFAULT NULL,
  `armar_emp` varchar(45) DEFAULT NULL,
  `talquear` tinyint(4) DEFAULT NULL,
  `talquear_fecha` datetime DEFAULT NULL,
  `talquear_emp` varchar(45) DEFAULT NULL,
  `sopletear` tinyint(4) DEFAULT NULL,
  `sopletear_fecha` datetime DEFAULT NULL,
  `sopletear_emp` varchar(45) DEFAULT NULL,
  `pintar` tinyint(4) DEFAULT NULL,
  `pintar_fecha` datetime DEFAULT NULL,
  `pintar_emp` varchar(45) DEFAULT NULL,
  `curar` tinyint(4) DEFAULT '0',
  `curar_fecha` datetime DEFAULT NULL,
  `curar_emp` varchar(45) DEFAULT NULL,
  `desarmado` tinyint(4) DEFAULT '0',
  `desarmado_fecha` datetime DEFAULT NULL,
  `desarmado_emp` varchar(45) DEFAULT NULL,
  `altadb` tinyint(4) DEFAULT '0',
  `altadb_fecha` datetime DEFAULT NULL,
  `altadb_emp` varchar(45) DEFAULT NULL,
  `revisiontt` tinyint(4) DEFAULT '0',
  `revisiontt_fecha` datetime DEFAULT NULL,
  `revisiontt_emp` varchar(45) DEFAULT NULL,
  `entregaprod` tinyint(4) DEFAULT '0',
  `entregaprod_fecha` datetime DEFAULT NULL,
  `entregaprod_emp` varchar(45) DEFAULT NULL,
  `envioalmacen` tinyint(4) DEFAULT '0',
  `envioalmacen_fecha` datetime DEFAULT NULL,
  `envioalmacen_emp` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`idCREATESET`)
) ENGINE=InnoDB AUTO_INCREMENT=242 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `DIMENSIONES`
--

DROP TABLE IF EXISTS `DIMENSIONES`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `DIMENSIONES` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Ficha` varchar(5) DEFAULT NULL,
  `Herramienta` varchar(5) DEFAULT NULL,
  `OrificioR1` varchar(45) DEFAULT NULL,
  `OrificioR2` varchar(45) DEFAULT NULL,
  `Color` varchar(45) DEFAULT NULL,
  `Diametro` decimal(6,4) DEFAULT NULL,
  `Nomenclatura` varchar(45) DEFAULT NULL,
  `CantidaPlatos` int(11) DEFAULT NULL,
  `CantidadMinPlatos` int(11) DEFAULT NULL,
  `DiametroNominal` decimal(6,4) DEFAULT NULL,
  `DiametroPM` decimal(6,4) DEFAULT NULL,
  `LargoNominal` decimal(6,4) DEFAULT NULL,
  `LargoPM` decimal(6,4) DEFAULT NULL,
  `AnchoNominal` decimal(6,4) DEFAULT NULL,
  `AnchoPM` decimal(6,4) unsigned DEFAULT NULL,
  `Marca` varchar(10) DEFAULT '0',
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=147 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `Diametros`
--

DROP TABLE IF EXISTS `Diametros`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `Diametros` (
  `idDiametros` int(11) NOT NULL AUTO_INCREMENT,
  `Cycles` varchar(45) DEFAULT NULL,
  `Produccion` int(50) DEFAULT NULL,
  `Diametro` decimal(6,4) DEFAULT NULL,
  `Porcentaje` varchar(50) DEFAULT NULL,
  `Tooling` varchar(45) DEFAULT NULL,
  `Nominal` decimal(6,4) DEFAULT NULL,
  PRIMARY KEY (`idDiametros`)
) ENGINE=InnoDB AUTO_INCREMENT=2241 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `GromHer`
--

DROP TABLE IF EXISTS `GromHer`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `GromHer` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `tooling` varchar(45) DEFAULT NULL,
  `grommet` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=52 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `Grommets`
--

DROP TABLE IF EXISTS `Grommets`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `Grommets` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `SET_ID` varchar(45) DEFAULT NULL,
  `Tooling` varchar(45) DEFAULT NULL,
  `Color` varchar(45) DEFAULT NULL,
  `Diametro` varchar(45) DEFAULT NULL,
  `Status` varchar(45) DEFAULT NULL,
  `Area` varchar(45) DEFAULT NULL,
  `Fecha_Entrada` datetime DEFAULT NULL,
  `Fecha_Salida` datetime DEFAULT NULL,
  `Runner` varchar(45) DEFAULT NULL,
  `Identificacion` varchar(45) DEFAULT NULL,
  `Cantidad` int(10) DEFAULT NULL,
  `Tipo` varchar(45) DEFAULT NULL,
  `Desgaste` float DEFAULT NULL,
  `ProduccionMax` int(60) DEFAULT NULL,
  `LengthMin` varchar(10) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=132 DEFAULT CHARSET=ascii COMMENT='Control de gromets';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `HISTORIASET`
--

DROP TABLE IF EXISTS `HISTORIASET`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `HISTORIASET` (
  `idHISTORIASET` int(11) NOT NULL AUTO_INCREMENT,
  `SETID` varchar(45) DEFAULT NULL,
  `TipeHist` varchar(45) DEFAULT NULL,
  `NumEmp` int(11) DEFAULT NULL,
  `NomEmp` varchar(45) DEFAULT NULL,
  `Tooling` int(11) DEFAULT NULL,
  `Color` varchar(45) DEFAULT NULL,
  `Diametro` varchar(45) DEFAULT NULL,
  `FechaEntrada` datetime DEFAULT NULL,
  `FechaSalida` datetime DEFAULT NULL,
  `TipeRunner` varchar(45) DEFAULT NULL,
  `IDColor` varchar(45) DEFAULT NULL,
  `Cantidad` varchar(45) DEFAULT NULL,
  `Tipo` varchar(45) DEFAULT NULL,
  `ProdActual` varchar(45) DEFAULT NULL,
  `ProduccionMax` bigint(50) DEFAULT NULL,
  `Medicion` varchar(45) DEFAULT NULL,
  `MedidaLargo1` decimal(6,4) DEFAULT NULL,
  `MedidaLargo2` decimal(6,4) DEFAULT NULL,
  `MedidaLargo3` decimal(6,4) DEFAULT NULL,
  `MedidaLargo4` decimal(6,4) DEFAULT NULL,
  `MedidaLargo5` decimal(6,4) DEFAULT NULL,
  `MedidaLargo6` decimal(6,4) DEFAULT NULL,
  `MedidaLargo7` decimal(6,4) DEFAULT NULL,
  `MedidaLargo8` decimal(6,4) DEFAULT NULL,
  `MedidaLargo9` decimal(6,4) DEFAULT NULL,
  `MedidaLargo10` decimal(6,4) DEFAULT NULL,
  `MedidaAncho1` decimal(6,4) DEFAULT NULL,
  `MedidaAncho2` decimal(6,4) DEFAULT NULL,
  `MedidaAncho3` decimal(6,4) DEFAULT NULL,
  `MedidaAncho4` decimal(6,4) DEFAULT NULL,
  `MedidaAncho5` decimal(6,4) DEFAULT NULL,
  `MedidaAncho6` decimal(6,4) DEFAULT NULL,
  `MedidaAncho7` decimal(6,4) DEFAULT NULL,
  `MedidaAncho8` decimal(6,4) DEFAULT NULL,
  `MedidaAncho9` decimal(6,4) DEFAULT NULL,
  `MedidaAncho10` decimal(6,4) DEFAULT NULL,
  `MedidaDiametro1` decimal(6,4) DEFAULT NULL,
  `MedidaDiametro2` decimal(6,4) DEFAULT NULL,
  `MedidaDiametro3` decimal(6,4) DEFAULT NULL,
  `MedidaDiametro4` decimal(6,4) DEFAULT NULL,
  `MedidaDiametro5` decimal(6,4) DEFAULT NULL,
  `MedidaDiametro6` decimal(6,4) DEFAULT NULL,
  `MedidaDiametro7` decimal(6,4) DEFAULT NULL,
  `MedidaDiametro8` decimal(6,4) DEFAULT NULL,
  `MedidaDiametro9` decimal(6,4) DEFAULT NULL,
  `MedidaDiametro10` decimal(6,4) DEFAULT NULL,
  `MedidaDiametro11` decimal(6,4) DEFAULT NULL,
  `MedidaDiametro12` decimal(6,4) DEFAULT NULL,
  `MedidaDiametro13` decimal(6,4) DEFAULT NULL,
  `MedidaDiametro14` decimal(6,4) DEFAULT NULL,
  `MedidaDiametro15` decimal(6,4) DEFAULT NULL,
  `MedidaDiametro16` decimal(6,4) DEFAULT NULL,
  `MedidaDiametro17` decimal(6,4) DEFAULT NULL,
  `MedidaDiametro18` decimal(6,4) DEFAULT NULL,
  `MedidaDiametro19` decimal(6,4) DEFAULT NULL,
  `MedidaDiametro20` decimal(6,4) DEFAULT NULL,
  `MedidaDiametro21` decimal(6,4) DEFAULT NULL,
  `MedidaDiametro22` decimal(6,4) DEFAULT NULL,
  `MedidaDiametro23` decimal(6,4) DEFAULT NULL,
  `MedidaDiametro24` decimal(6,4) DEFAULT NULL,
  `MedidaDiametro25` decimal(6,4) DEFAULT NULL,
  `MedidaDiametro26` decimal(6,4) DEFAULT NULL,
  `MedidaDiametro27` decimal(6,4) DEFAULT NULL,
  `MedidaDiametro28` decimal(6,4) DEFAULT NULL,
  `MedidaDiametro29` decimal(6,4) DEFAULT NULL,
  `MedidaDiametro30` decimal(6,4) DEFAULT NULL,
  `MedidaDiametro31` decimal(6,4) DEFAULT NULL,
  `MedidaDiametro32` decimal(6,4) DEFAULT NULL,
  `MedidaDiametro33` decimal(6,4) DEFAULT NULL,
  `MedidaDiametro34` decimal(6,4) DEFAULT NULL,
  `MedidaDiametro35` decimal(6,4) DEFAULT NULL,
  `MedidaDiametro36` decimal(6,4) DEFAULT NULL,
  `MedidaDiametro37` decimal(6,4) DEFAULT NULL,
  `MedidaDiametro38` decimal(6,4) DEFAULT NULL,
  `MedidaDiametro39` decimal(6,4) DEFAULT NULL,
  `MedidaDiametro40` decimal(6,4) DEFAULT NULL,
  `MedidaDiametro41` decimal(6,4) DEFAULT NULL,
  `MedidaDiametro42` decimal(6,4) DEFAULT NULL,
  `MedidaDiametro43` decimal(6,4) DEFAULT NULL,
  `MedidaDiametro44` decimal(6,4) DEFAULT NULL,
  `MedidaDiametro45` decimal(6,4) DEFAULT NULL,
  `MedidaDiametro46` decimal(6,4) DEFAULT NULL,
  `MedidaDiametro47` decimal(6,4) DEFAULT NULL,
  `MedidaDiametro48` decimal(6,4) DEFAULT NULL,
  `MedidaDiametro49` decimal(6,4) DEFAULT NULL,
  `MedidaDiametro50` decimal(6,4) DEFAULT NULL,
  `MedidaDiametro51` decimal(6,4) DEFAULT NULL,
  `MedidaDiametro52` decimal(6,4) DEFAULT NULL,
  `MedidaDiametro53` decimal(6,4) DEFAULT NULL,
  `MedidaDiametro54` decimal(6,4) DEFAULT NULL,
  `MedidaDiametro55` decimal(6,4) DEFAULT NULL,
  `MedidaDiametro56` decimal(6,4) DEFAULT NULL,
  `MedidaDiametro57` decimal(6,4) DEFAULT NULL,
  `MedidaDiametro58` decimal(6,4) DEFAULT NULL,
  `MedidaDiametro59` decimal(6,4) DEFAULT NULL,
  `MedidaDiametro60` decimal(6,4) DEFAULT NULL,
  `MedidaDiametro61` decimal(6,4) DEFAULT NULL,
  `MedidaDiametro62` decimal(6,4) DEFAULT NULL,
  `MedidaDiametro63` decimal(6,4) DEFAULT NULL,
  `MedidaDiametro64` decimal(6,4) DEFAULT NULL,
  `MedidaDiametro65` decimal(6,4) DEFAULT NULL,
  `MedidaDiametro66` decimal(6,4) DEFAULT NULL,
  `MedidaDiametro67` decimal(6,4) DEFAULT NULL,
  `MedidaDiametro68` decimal(6,4) DEFAULT NULL,
  `MedidaDiametro69` decimal(6,4) DEFAULT NULL,
  `MedidaDiametro70` decimal(6,4) DEFAULT NULL,
  `MedidaDiametro71` decimal(6,4) DEFAULT NULL,
  `MedidaDiametro72` decimal(6,4) DEFAULT NULL,
  `MedidaDiametro73` decimal(6,4) DEFAULT NULL,
  `MedidaDiametro74` decimal(6,4) DEFAULT NULL,
  `MedidaDiametro75` decimal(6,4) DEFAULT NULL,
  `MedidaDiametro76` decimal(6,4) DEFAULT NULL,
  `MedidaDiametro77` decimal(6,4) DEFAULT NULL,
  `MedidaDiametro78` decimal(6,4) DEFAULT NULL,
  `MedidaDiametro79` decimal(6,4) DEFAULT NULL,
  `MedidaDiametro80` decimal(6,4) DEFAULT NULL,
  `MedidaDiametro81` decimal(6,4) DEFAULT NULL,
  `MedidaDiametro82` decimal(6,4) DEFAULT NULL,
  `MedidaDiametro83` decimal(6,4) DEFAULT NULL,
  `MedidaDiametro84` decimal(6,4) DEFAULT NULL,
  `MedidaDiametro85` decimal(6,4) DEFAULT NULL,
  `MedidaDiametro86` decimal(6,4) DEFAULT NULL,
  `MedidaDiametro87` decimal(6,4) DEFAULT NULL,
  `MedidaDiametro88` decimal(6,4) DEFAULT NULL,
  `MedidaDiametro89` decimal(6,4) DEFAULT NULL,
  `MedidaDiametro90` decimal(6,4) DEFAULT NULL,
  `MedidaDiametro91` decimal(6,4) DEFAULT NULL,
  `MedidaDiametro92` decimal(6,4) DEFAULT NULL,
  `MedidaDiametro93` decimal(6,4) DEFAULT NULL,
  `MedidaDiametro94` decimal(6,4) DEFAULT NULL,
  `MedidaDiametro95` decimal(6,4) DEFAULT NULL,
  `MedidaDiametro96` decimal(6,4) DEFAULT NULL,
  `MedidaDiametro97` decimal(6,4) DEFAULT NULL,
  `MedidaDiametro98` decimal(6,4) DEFAULT NULL,
  `MedidaDiametro99` decimal(6,4) DEFAULT NULL,
  `MedidaDiametro100` decimal(6,4) DEFAULT NULL,
  PRIMARY KEY (`idHISTORIASET`)
) ENGINE=InnoDB AUTO_INCREMENT=896 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `IDENTIFICACIONES`
--

DROP TABLE IF EXISTS `IDENTIFICACIONES`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `IDENTIFICACIONES` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Tooling` varchar(45) DEFAULT NULL,
  `Grommet` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `INFOLINES`
--

DROP TABLE IF EXISTS `INFOLINES`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `INFOLINES` (
  `FECHA` datetime DEFAULT NULL,
  `HORA` datetime DEFAULT NULL,
  `TURNO` varchar(3) DEFAULT NULL,
  `LINEA` varchar(3) DEFAULT NULL,
  `PRENSA` varchar(10) DEFAULT NULL,
  `AREA` varchar(10) DEFAULT NULL,
  `TOOLINGID` varchar(10) DEFAULT NULL,
  `PPACKANT` varchar(10) DEFAULT NULL,
  `PPACKNUEVO` varchar(10) DEFAULT NULL,
  `GREENPLATE` varchar(10) DEFAULT NULL,
  `QTYLABIOSDOBLADOS` varchar(10) DEFAULT '0',
  `QTYPINESDOBLADOS` varchar(255) DEFAULT '0',
  `QTYPINESQUEBRADOS` varchar(255) DEFAULT '0',
  `LAINA` varchar(10) DEFAULT NULL,
  `EMPLEADO` varchar(10) DEFAULT NULL,
  `INSTALO` varchar(20) DEFAULT NULL,
  `ESTADO` varchar(1) DEFAULT NULL,
  `VIDA` varchar(255) DEFAULT NULL,
  `QUITO` varchar(255) DEFAULT NULL,
  `DURATOTAL` varchar(255) DEFAULT NULL,
  `EFICIENCIA` varchar(255) DEFAULT NULL,
  `REPARO` varchar(255) DEFAULT NULL,
  `FECHAREP` datetime DEFAULT NULL,
  `INFOLINEScol` int(11) NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`INFOLINEScol`)
) ENGINE=InnoDB AUTO_INCREMENT=187804 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `PARTGROMMET`
--

DROP TABLE IF EXISTS `PARTGROMMET`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `PARTGROMMET` (
  `id` int(11) NOT NULL,
  `colotgromet` varchar(45) DEFAULT NULL,
  `diametro` varchar(45) DEFAULT NULL,
  `nparte` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `PRODUCTION`
--

DROP TABLE IF EXISTS `PRODUCTION`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `PRODUCTION` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Fecha` datetime DEFAULT NULL,
  `Linea` varchar(10) DEFAULT NULL,
  `Produccion` int(10) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `REGRESION`
--

DROP TABLE IF EXISTS `REGRESION`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `REGRESION` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Size` varchar(45) DEFAULT NULL,
  `Produccion` double DEFAULT NULL,
  `Cycle` varchar(45) DEFAULT NULL,
  `LengthNew` varchar(10) DEFAULT NULL,
  `LengthReaconditioned` varchar(10) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=588 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `RUNNING`
--

DROP TABLE IF EXISTS `RUNNING`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `RUNNING` (
  `FECHA` datetime DEFAULT NULL,
  `HORA` datetime DEFAULT NULL,
  `TURNO` varchar(3) DEFAULT NULL,
  `LINEA` varchar(3) NOT NULL,
  `PRENSA` varchar(10) DEFAULT NULL,
  `AREA` varchar(10) DEFAULT NULL,
  `TOOLINGID` varchar(10) DEFAULT NULL,
  `PPACKANT` varchar(10) DEFAULT NULL,
  `PPACKNUEVO` varchar(10) DEFAULT NULL,
  `GREENPLATE` varchar(10) DEFAULT NULL,
  `QTYLABIOSDOBLADOS` varchar(10) DEFAULT '0',
  `LAINA` varchar(10) DEFAULT '0',
  `EMPLEADO` varchar(10) DEFAULT NULL,
  `INSTALO` varchar(20) DEFAULT NULL,
  `ESTADO` varchar(1) DEFAULT NULL,
  `VIDA` varchar(6) DEFAULT NULL,
  `RUNNINGcol` int(11) NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`RUNNINGcol`)
) ENGINE=InnoDB AUTO_INCREMENT=39 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `Resets`
--

DROP TABLE IF EXISTS `Resets`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `Resets` (
  `idResets` int(11) NOT NULL AUTO_INCREMENT,
  `SetId` varchar(45) DEFAULT NULL,
  `Fecha` datetime DEFAULT NULL,
  `NumEmp` varchar(45) DEFAULT NULL,
  `NomEmp` varchar(45) DEFAULT NULL,
  `Medida` varchar(45) DEFAULT NULL,
  `ProdActual` varchar(45) DEFAULT NULL,
  `ProdMax` varchar(45) DEFAULT NULL,
  `PromAncho` varchar(45) DEFAULT NULL,
  `PromLargo` varchar(45) DEFAULT NULL,
  `PromDiametro` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`idResets`)
) ENGINE=InnoDB AUTO_INCREMENT=858 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `SOLICITUD_PLATOS`
--

DROP TABLE IF EXISTS `SOLICITUD_PLATOS`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `SOLICITUD_PLATOS` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `EMPLEADO` varchar(15) DEFAULT NULL,
  `LINEA` varchar(10) DEFAULT NULL,
  `TOOLING` varchar(10) DEFAULT NULL,
  `GROMMET` varchar(45) DEFAULT NULL,
  `FECHASOLICITUD` datetime DEFAULT NULL,
  `STATUS` varchar(15) DEFAULT NULL,
  `FECHAENTREGA` datetime DEFAULT NULL,
  `EMPLEADOENTREGA` varchar(15) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `TECNICOS`
--

DROP TABLE IF EXISTS `TECNICOS`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `TECNICOS` (
  `TECNICO` varchar(250) DEFAULT NULL,
  `TECNICOScol` int(11) NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`TECNICOScol`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `TOOLLINES`
--

DROP TABLE IF EXISTS `TOOLLINES`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `TOOLLINES` (
  `FECHA` datetime DEFAULT NULL,
  `HORA` datetime DEFAULT NULL,
  `TIPOTOOLING` varchar(255) DEFAULT NULL,
  `TOOLINGID` varchar(255) DEFAULT NULL,
  `DESCRIPCION` varchar(255) DEFAULT NULL,
  `STATUS` varchar(2) DEFAULT NULL,
  `VIDA` varchar(12) DEFAULT NULL,
  `TOOLLINEScol` int(11) NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`TOOLLINEScol`)
) ENGINE=InnoDB AUTO_INCREMENT=340 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2021-12-09  6:54:11
