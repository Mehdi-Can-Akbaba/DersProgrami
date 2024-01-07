-- MySQL dump 10.13  Distrib 8.0.34, for Win64 (x86_64)
--
-- Host: localhost    Database: dersprogrami
-- ------------------------------------------------------
-- Server version	8.0.32

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
-- Table structure for table `dersderslik`
--

DROP TABLE IF EXISTS `dersderslik`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `dersderslik` (
  `dersderslik_id` int NOT NULL AUTO_INCREMENT,
  `ders_id` int NOT NULL,
  `derslik_id` int NOT NULL,
  PRIMARY KEY (`dersderslik_id`,`ders_id`,`derslik_id`),
  UNIQUE KEY `ders_id_UNIQUE` (`ders_id`),
  CONSTRAINT `ders_id_derslik` FOREIGN KEY (`ders_id`) REFERENCES `dersler` (`ders_id`)
) ENGINE=InnoDB AUTO_INCREMENT=46 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `dersderslik`
--

LOCK TABLES `dersderslik` WRITE;
/*!40000 ALTER TABLE `dersderslik` DISABLE KEYS */;
INSERT INTO `dersderslik` VALUES (1,1,2),(2,2,5),(3,3,2),(4,4,2),(5,5,4),(6,6,7),(7,7,7),(8,8,7),(11,9,4),(12,10,3),(13,11,2),(14,12,6),(15,13,2),(16,14,1),(17,15,5),(18,16,2),(19,17,4),(20,18,5),(21,19,4),(22,20,1),(23,21,5),(24,22,4),(25,23,3),(26,24,4),(27,25,3),(28,26,7),(29,27,1),(30,28,1),(31,29,4),(32,30,2),(33,31,3),(34,32,1),(35,33,5),(36,34,1),(37,35,3),(38,36,1),(39,37,3),(40,38,1),(41,39,3),(42,40,1),(43,41,2),(44,42,2);
/*!40000 ALTER TABLE `dersderslik` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `dersler`
--

DROP TABLE IF EXISTS `dersler`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `dersler` (
  `ders_id` int NOT NULL AUTO_INCREMENT,
  `ders_ad` varchar(55) NOT NULL,
  `ders_sinif` int NOT NULL,
  `ders_derslik` varchar(10) NOT NULL,
  `gun_ad` varchar(45) NOT NULL,
  `gun_id` int DEFAULT NULL,
  `saat_id` int DEFAULT NULL,
  PRIMARY KEY (`ders_id`),
  KEY `gun_id` (`gun_id`),
  KEY `saat_id` (`saat_id`),
  CONSTRAINT `dersler_ibfk_1` FOREIGN KEY (`gun_id`) REFERENCES `gunler` (`gun_id`),
  CONSTRAINT `dersler_ibfk_2` FOREIGN KEY (`saat_id`) REFERENCES `saat` (`saat_id`)
) ENGINE=InnoDB AUTO_INCREMENT=58 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `dersler`
--

LOCK TABLES `dersler` WRITE;
/*!40000 ALTER TABLE `dersler` DISABLE KEYS */;
INSERT INTO `dersler` VALUES (1,'Algoritma ve Programlama',1,'1040','Pazartesi',1,6),(2,'Programlama Lab.',1,'Z023','Perşembe',4,7),(3,'Bilişim Sis. Müh. Giriş',1,'1040','Çarşamba',3,7),(4,'Fizik 1 ',1,'1040','Pazartesi',1,2),(5,'Matematik 1',2,'1041','Çarşamba',2,2),(6,'Türk Dili 1',1,'UE','Cuma',5,1),(7,'Atatürk İlkeleri ve İnkılap Tarihi 1',1,'UE','Cuma',5,1),(8,'İngilizce 1',1,'UE','Salı',2,1),(9,'Diferansiyel Denklemler',2,'1044','Pazartesi',1,1),(10,'İşletme Ekonomisi',2,'1041','Pazartesi',1,6),(11,'Elektrik Elektronik Devreler',2,'1040','Salı',2,1),(12,'Elektrik Elektronik Devreler Lab.',2,'Z025','Salı',2,4),(13,'Nesne Yönelimli Programlama',2,'1040','Salı',2,6),(14,'Nanoteknolojiye Giriş',2,'1036','Çarşamba',3,2),(15,'Linux İşletim sistemi Kullanımı ve Yönetiimi',2,'Z023','Çarşamba',3,2),(16,'Mobil Uygulama Geliştirme',2,'1040','Çarşamba',3,2),(17,'Veri Yapıları ve Algoritmalar',2,'1044','Çarşamba',3,6),(18,'Veri Yapıları Lab.',2,'Z023','Çarşamba',3,5),(19,'İstatistik ve Olasılık',2,'1044','Perşembe',4,1),(20,'Web Tasarımı',3,'1036','Pazartesi',1,1),(21,'Web Tasarımı Lab.',3,'Z023','Pazartesi',1,3),(22,'Bulut Bilişimde Sanallaştırma Teknolojilerine Giriş',3,'1044','Pazartesi',1,6),(23,'Ayrık Matematik',3,'1041','Salı',2,2),(24,'Bilgisayar Mimari ve Organizasyonu',3,'1044','Salı',2,6),(25,'Bilişim Sistemleri Analizi ve Tasarımı',3,'1041','Çarşamba',3,2),(26,'Yazılım Geliştirme Lab.',3,'UE','Cuma',5,1),(27,'Yönetim ve Organizasyon',3,'1036','Cuma',5,7),(28,'Veri Haberleşmesi',3,'1036','Perşembe',4,2),(29,'E-İşletme ve E-Ticaret Uygulamaları',3,'1044','Perşembe',4,6),(30,'Sayısal İşaret İşleme',3,'1040','Perşembe',4,6),(31,'Oyun Programlama',4,'1041','Pazartesi',1,1),(32,'Bilişim Sistemleri Mühendisliğinde Özel Konular',4,'1036','Pazartesi',1,5),(33,'Görüntü İşleme',4,'Z023','Pazartesi',1,5),(34,'Kablosuz Ağ Teknolojileri ve Uygulamaları',4,'1036','Salı',2,2),(35,'Bulanık Mantık',4,'1041','Salı',2,6),(36,'Yapay Zeka',4,'1036','Salı',2,6),(37,'Kalite Yönetimi',4,'1041','Çarşamba',3,2),(38,'Veri Madenciliği',4,'1036','Çarşamba',3,5),(39,'Proje Yönetimi',4,'1041','Perşembe',4,4),(40,'Yapay Sinir Ağları',4,'1036','Perşembe',4,6),(41,'İş Sağlığı ve Güvenliği',1,'1040','Perşembe',4,2),(42,'Fizik 1 Lab.',1,'1040','Çarşamba',3,5),(49,'Ayrık Matematik',3,'1041','Pazartesi',1,6),(55,'Türk Dili 1',4,'1040','Pazartesi',NULL,7);
/*!40000 ALTER TABLE `dersler` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `derslikler`
--

DROP TABLE IF EXISTS `derslikler`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `derslikler` (
  `derslik_id` int NOT NULL AUTO_INCREMENT,
  `derslik_no` varchar(10) NOT NULL,
  PRIMARY KEY (`derslik_id`),
  UNIQUE KEY `derslik_no_UNIQUE` (`derslik_no`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `derslikler`
--

LOCK TABLES `derslikler` WRITE;
/*!40000 ALTER TABLE `derslikler` DISABLE KEYS */;
INSERT INTO `derslikler` VALUES (1,'1036'),(2,'1040'),(3,'1041'),(4,'1044'),(7,'UE'),(5,'Z023'),(6,'Z025');
/*!40000 ALTER TABLE `derslikler` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `dersogretmen`
--

DROP TABLE IF EXISTS `dersogretmen`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `dersogretmen` (
  `dersogretmen_id` int NOT NULL AUTO_INCREMENT,
  `ders_id` int NOT NULL,
  `ogretmen_id` int NOT NULL,
  PRIMARY KEY (`dersogretmen_id`,`ders_id`,`ogretmen_id`),
  UNIQUE KEY `ders_id_UNIQUE` (`ders_id`),
  KEY `ders_id_idx` (`ders_id`),
  KEY `ogretmen_id_idx` (`ogretmen_id`),
  CONSTRAINT `ders_id` FOREIGN KEY (`ders_id`) REFERENCES `dersler` (`ders_id`),
  CONSTRAINT `ogretmen_id` FOREIGN KEY (`ogretmen_id`) REFERENCES `ogretmen` (`ogretmen_id`)
) ENGINE=InnoDB AUTO_INCREMENT=54 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `dersogretmen`
--

LOCK TABLES `dersogretmen` WRITE;
/*!40000 ALTER TABLE `dersogretmen` DISABLE KEYS */;
INSERT INTO `dersogretmen` VALUES (1,1,10),(2,2,10),(3,3,11),(4,4,1),(5,5,25),(6,6,18),(7,7,22),(8,8,17),(9,9,23),(10,10,16),(11,11,6),(12,12,6),(13,13,7),(14,14,1),(15,15,4),(16,16,8),(17,17,4),(18,18,4),(19,19,24),(20,20,8),(21,21,8),(22,22,8),(23,23,5),(24,24,3),(35,25,11),(36,26,10),(37,27,19),(38,28,3),(39,29,11),(40,30,6),(41,31,10),(42,32,26),(43,33,4),(44,34,3),(45,35,6),(46,36,5),(47,37,27),(48,38,7),(49,39,21),(50,40,7),(51,41,20),(52,42,1);
/*!40000 ALTER TABLE `dersogretmen` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `gunler`
--

DROP TABLE IF EXISTS `gunler`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `gunler` (
  `gun_id` int NOT NULL,
  `gun_ad` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`gun_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `gunler`
--

LOCK TABLES `gunler` WRITE;
/*!40000 ALTER TABLE `gunler` DISABLE KEYS */;
INSERT INTO `gunler` VALUES (1,'Pazartesi'),(2,'Salı'),(3,'Çarşamba'),(4,'Perşembe'),(5,'Cuma');
/*!40000 ALTER TABLE `gunler` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ogretmen`
--

DROP TABLE IF EXISTS `ogretmen`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `ogretmen` (
  `ogretmen_id` int NOT NULL AUTO_INCREMENT,
  `ogretmen_unvan` varchar(25) NOT NULL,
  `ogretmen_ad` varchar(25) NOT NULL,
  `ogretmen_soyad` varchar(25) NOT NULL,
  PRIMARY KEY (`ogretmen_id`)
) ENGINE=InnoDB AUTO_INCREMENT=39 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ogretmen`
--

LOCK TABLES `ogretmen` WRITE;
/*!40000 ALTER TABLE `ogretmen` DISABLE KEYS */;
INSERT INTO `ogretmen` VALUES (1,'Prof. Dr.','Hikmet Hakan','Gürel'),(2,'Prof. Dr.','Mehmet','Yıldırım'),(3,'Prof. Dr.','Halil','Yiğit'),(4,'Doç Dr.','Serdar','Solak'),(5,'Doç Dr.','Süleyman','Eken'),(6,'Doç Dr.','Mustafa Hikmet Bilgehan','Uçar'),(7,'Doç Dr.','Zeynep Hilal','Kilimci'),(8,'Dr. Ogr. Uyesi','Önder','Yakut'),(9,'Dr. Ogr. Uyesi','Adnan','Sondaş'),(10,'Ögr. Gör.','Yavuz Selim','Fatihoğlu'),(11,'Ögr. Gör.','Alper','Metin'),(12,'Arş. Gör.','Gizem','Yıldız'),(13,'Arş. Gör.','Muhammet Mücahit Enes','Yurtsever'),(14,'Arş. Gör.','Seda Balta','Kaç'),(15,'Arş. Gör.','Zeynep','Sarı'),(16,'Ögr. Gör.','Kerem','Çolak'),(17,'Ögr. Gör.','Efsun','Akkaya'),(18,'Ögr. Gör.','Fatih','Kıran'),(19,'Prof. Dr.','Ceylan Gazi','Uçkun'),(20,'Ögr. Gör.','Meryem','Küçük'),(21,'Ögr. Gör.','Asiye','Yüksel'),(22,'Ögr. Gör.','Sibel','Orhan'),(23,'Doç Dr.','Vildan','Çetkin'),(24,'Arş. Gör.','İrem','Çay'),(25,'Prof. Dr.','Çiğdem','Gündüz'),(26,'Ögr. Gör.','İsmail','Gülsoy'),(27,'Ögr. Gör.','Kamile ','Demirel');
/*!40000 ALTER TABLE `ogretmen` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `saat`
--

DROP TABLE IF EXISTS `saat`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `saat` (
  `saat_id` int NOT NULL,
  `saat` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`saat_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `saat`
--

LOCK TABLES `saat` WRITE;
/*!40000 ALTER TABLE `saat` DISABLE KEYS */;
INSERT INTO `saat` VALUES (1,'09:00'),(2,'10:00'),(3,'11:00'),(4,'12:00'),(5,'13:00'),(6,'14:00'),(7,'15:00');
/*!40000 ALTER TABLE `saat` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-01-07 11:53:47
