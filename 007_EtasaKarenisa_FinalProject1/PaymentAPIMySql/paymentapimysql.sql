-- MySQL dump 10.13  Distrib 8.0.26, for Win64 (x86_64)
--
-- Host: remotemysql.com    Database: aH4Q6RpAfb
-- ------------------------------------------------------
-- Server version	8.0.13-4

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
-- Table structure for table `AspNetRoleClaims`
--

DROP TABLE IF EXISTS `AspNetRoleClaims`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `AspNetRoleClaims` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `RoleId` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `ClaimType` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  `ClaimValue` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  PRIMARY KEY (`Id`),
  KEY `IX_AspNetRoleClaims_RoleId` (`RoleId`),
  CONSTRAINT `FK_AspNetRoleClaims_AspNetRoles_RoleId` FOREIGN KEY (`RoleId`) REFERENCES `AspNetRoles` (`id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `AspNetRoleClaims`
--

LOCK TABLES `AspNetRoleClaims` WRITE;
/*!40000 ALTER TABLE `AspNetRoleClaims` DISABLE KEYS */;
/*!40000 ALTER TABLE `AspNetRoleClaims` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `AspNetRoles`
--

DROP TABLE IF EXISTS `AspNetRoles`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `AspNetRoles` (
  `Id` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `Name` varchar(256) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `NormalizedName` varchar(256) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `ConcurrencyStamp` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `RoleNameIndex` (`NormalizedName`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `AspNetRoles`
--

LOCK TABLES `AspNetRoles` WRITE;
/*!40000 ALTER TABLE `AspNetRoles` DISABLE KEYS */;
/*!40000 ALTER TABLE `AspNetRoles` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `AspNetUserClaims`
--

DROP TABLE IF EXISTS `AspNetUserClaims`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `AspNetUserClaims` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `UserId` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `ClaimType` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  `ClaimValue` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  PRIMARY KEY (`Id`),
  KEY `IX_AspNetUserClaims_UserId` (`UserId`),
  CONSTRAINT `FK_AspNetUserClaims_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `AspNetUsers` (`id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `AspNetUserClaims`
--

LOCK TABLES `AspNetUserClaims` WRITE;
/*!40000 ALTER TABLE `AspNetUserClaims` DISABLE KEYS */;
/*!40000 ALTER TABLE `AspNetUserClaims` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `AspNetUserLogins`
--

DROP TABLE IF EXISTS `AspNetUserLogins`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `AspNetUserLogins` (
  `LoginProvider` varchar(128) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `ProviderKey` varchar(128) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `ProviderDisplayName` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  `UserId` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  PRIMARY KEY (`LoginProvider`,`ProviderKey`),
  KEY `IX_AspNetUserLogins_UserId` (`UserId`),
  CONSTRAINT `FK_AspNetUserLogins_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `AspNetUsers` (`id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `AspNetUserLogins`
--

LOCK TABLES `AspNetUserLogins` WRITE;
/*!40000 ALTER TABLE `AspNetUserLogins` DISABLE KEYS */;
/*!40000 ALTER TABLE `AspNetUserLogins` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `AspNetUserRoles`
--

DROP TABLE IF EXISTS `AspNetUserRoles`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `AspNetUserRoles` (
  `UserId` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `RoleId` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  PRIMARY KEY (`UserId`,`RoleId`),
  KEY `IX_AspNetUserRoles_RoleId` (`RoleId`),
  CONSTRAINT `FK_AspNetUserRoles_AspNetRoles_RoleId` FOREIGN KEY (`RoleId`) REFERENCES `AspNetRoles` (`id`) ON DELETE CASCADE,
  CONSTRAINT `FK_AspNetUserRoles_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `AspNetUsers` (`id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `AspNetUserRoles`
--

LOCK TABLES `AspNetUserRoles` WRITE;
/*!40000 ALTER TABLE `AspNetUserRoles` DISABLE KEYS */;
/*!40000 ALTER TABLE `AspNetUserRoles` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `AspNetUserTokens`
--

DROP TABLE IF EXISTS `AspNetUserTokens`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `AspNetUserTokens` (
  `UserId` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `LoginProvider` varchar(128) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `Name` varchar(128) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `Value` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  PRIMARY KEY (`UserId`,`LoginProvider`,`Name`),
  CONSTRAINT `FK_AspNetUserTokens_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `AspNetUsers` (`id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `AspNetUserTokens`
--

LOCK TABLES `AspNetUserTokens` WRITE;
/*!40000 ALTER TABLE `AspNetUserTokens` DISABLE KEYS */;
/*!40000 ALTER TABLE `AspNetUserTokens` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `AspNetUsers`
--

DROP TABLE IF EXISTS `AspNetUsers`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `AspNetUsers` (
  `Id` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `UserName` varchar(256) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `NormalizedUserName` varchar(256) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `Email` varchar(256) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `NormalizedEmail` varchar(256) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `EmailConfirmed` tinyint(1) NOT NULL,
  `PasswordHash` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  `SecurityStamp` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  `ConcurrencyStamp` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  `PhoneNumber` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  `PhoneNumberConfirmed` tinyint(1) NOT NULL,
  `TwoFactorEnabled` tinyint(1) NOT NULL,
  `LockoutEnd` datetime(6) DEFAULT NULL,
  `LockoutEnabled` tinyint(1) NOT NULL,
  `AccessFailedCount` int(11) NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `UserNameIndex` (`NormalizedUserName`),
  KEY `EmailIndex` (`NormalizedEmail`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `AspNetUsers`
--

LOCK TABLES `AspNetUsers` WRITE;
/*!40000 ALTER TABLE `AspNetUsers` DISABLE KEYS */;
INSERT INTO `AspNetUsers` VALUES ('120d6aa3-c683-462e-a75e-879a1daa9482','hello','HELLO','hello@gmail.com','HELLO@GMAIL.COM',0,'AQAAAAEAACcQAAAAEBp2ugVjB9e1S6ZO/iNtw5vlKCRGj2aGVasgpgetv4S1XxjOmEB7v+3Wb9s9lGeX7Q==','FGUGBLPOSTRVAKEFEYZE2H7RUT7JOFYW','c8ab753b-4de2-4eee-8a83-fea58fa6efdf',NULL,0,0,NULL,1,0),('205e3aa0-4379-4e70-851a-849ecc5bdd6d','helloworld','HELLOWORLD','helloworld@gmail.com','HELLOWORLD@GMAIL.COM',0,'AQAAAAEAACcQAAAAEEOR/7YVzXIr91KPhXO/J6b9hG32/PzD/dsXDRc0n//a4qgCaM6vvOCr8/es1QoRXw==','5GGIVYKZGLB6THDP5AFQD7ADA4K4WRU5','4ebe48aa-8f46-4d86-a9e2-d0fe67f2df10',NULL,0,0,NULL,1,0);
/*!40000 ALTER TABLE `AspNetUsers` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Items`
--

DROP TABLE IF EXISTS `Items`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `Items` (
  `paymentDetailId` int(11) NOT NULL AUTO_INCREMENT,
  `cardOwnerName` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  `cardNumber` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  `expirationDate` datetime(6) NOT NULL,
  `securityCode` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  PRIMARY KEY (`paymentDetailId`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Items`
--

LOCK TABLES `Items` WRITE;
/*!40000 ALTER TABLE `Items` DISABLE KEYS */;
INSERT INTO `Items` VALUES (1,'Yeni Kusuma','1030 8374 9201 0000','2024-10-21 10:43:38.708000','120939'),(2,'Abigal','1029 8374 9201 0000','2025-10-21 10:43:38.708000','120938'),(3,'Andi Budi','1029 8374 2201 0000','2025-10-21 10:43:38.708000','121938');
/*!40000 ALTER TABLE `Items` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `RefreshTokens`
--

DROP TABLE IF EXISTS `RefreshTokens`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `RefreshTokens` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `userId` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `token` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  `jwtId` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  `isUsed` tinyint(1) NOT NULL,
  `isRevoked` tinyint(1) NOT NULL,
  `addedDate` datetime(6) NOT NULL,
  `expiryDate` datetime(6) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `IX_RefreshTokens_userId` (`userId`),
  CONSTRAINT `FK_RefreshTokens_AspNetUsers_userId` FOREIGN KEY (`userId`) REFERENCES `AspNetUsers` (`id`) ON DELETE RESTRICT
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `RefreshTokens`
--

LOCK TABLES `RefreshTokens` WRITE;
/*!40000 ALTER TABLE `RefreshTokens` DISABLE KEYS */;
INSERT INTO `RefreshTokens` VALUES (1,'120d6aa3-c683-462e-a75e-879a1daa9482','QSCOQW3Z1LETYRLZYBANPI0S0W5NXXKGFH77e7f5f56-09b2-4ed7-99a2-4381b53acb39','03ad6595-e3bf-47a4-a6a4-b4a827770372',0,0,'2021-10-21 10:42:16.861824','2021-10-21 11:12:16.861904'),(2,'120d6aa3-c683-462e-a75e-879a1daa9482','D3P8ZCQAAQC8VCMDMQY9IBL2GBE08ZS1J97d24eeb5b-a9cf-4cb0-ba89-55325119f8f2','8e6c9639-af8d-4154-93f5-b3096e5ebbe7',0,0,'2021-10-21 10:42:44.113889','2021-10-21 11:12:44.113889'),(3,'120d6aa3-c683-462e-a75e-879a1daa9482','ZIA7RDFF10XHXGCH3EZ2B9SGO603729FWNPfa4216d9-b4c7-43c5-8591-f1b5faef2807','cc24f79a-98d2-4931-ba46-188b1be5c135',0,0,'2021-10-21 10:49:15.206968','2021-10-21 11:19:15.207051'),(4,'205e3aa0-4379-4e70-851a-849ecc5bdd6d','D2KGLP01OYHR288ELMLAJ3L3FV93AWRMVC7a497786f-062c-4a40-8fd3-ba06b3ebde93','8d719b67-5045-4076-ad4a-dc894cdd3b97',0,0,'2021-10-21 13:59:47.109641','2021-10-21 14:29:47.109705'),(5,'205e3aa0-4379-4e70-851a-849ecc5bdd6d','PIGWNN1TE2AKIC4OQUYBLJ9RZUK8Y1TWHY742bd9cda-8335-4d8f-ab94-56cfa09023f7','ac124630-c2f4-4461-9994-48de03112875',0,0,'2021-10-21 14:00:23.143606','2021-10-21 14:30:23.143607');
/*!40000 ALTER TABLE `RefreshTokens` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `UserLogin`
--

DROP TABLE IF EXISTS `UserLogin`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `UserLogin` (
  `email` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `password` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  PRIMARY KEY (`email`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `UserLogin`
--

LOCK TABLES `UserLogin` WRITE;
/*!40000 ALTER TABLE `UserLogin` DISABLE KEYS */;
/*!40000 ALTER TABLE `UserLogin` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `UserRegist`
--

DROP TABLE IF EXISTS `UserRegist`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `UserRegist` (
  `email` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `username` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `password` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  PRIMARY KEY (`email`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `UserRegist`
--

LOCK TABLES `UserRegist` WRITE;
/*!40000 ALTER TABLE `UserRegist` DISABLE KEYS */;
/*!40000 ALTER TABLE `UserRegist` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `__EFMigrationsHistory`
--

DROP TABLE IF EXISTS `__EFMigrationsHistory`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `__EFMigrationsHistory` (
  `MigrationId` varchar(150) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `ProductVersion` varchar(32) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  PRIMARY KEY (`MigrationId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `__EFMigrationsHistory`
--

LOCK TABLES `__EFMigrationsHistory` WRITE;
/*!40000 ALTER TABLE `__EFMigrationsHistory` DISABLE KEYS */;
INSERT INTO `__EFMigrationsHistory` VALUES ('20211021052112_Initial','5.0.11'),('20211021052318_Adding authentication','5.0.11'),('20211021052345_Refresh token','5.0.11'),('20211021103908_Initial2','5.0.11'),('20211021104013_Adding Authentication2','5.0.11'),('20211021104047_Refresh Token2','5.0.11');
/*!40000 ALTER TABLE `__EFMigrationsHistory` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2021-10-21 21:29:42
