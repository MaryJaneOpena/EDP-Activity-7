CREATE DATABASE  IF NOT EXISTS `books` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `books`;
-- MySQL dump 10.13  Distrib 8.0.36, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: books
-- ------------------------------------------------------
-- Server version	8.3.0

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
-- Table structure for table `authors`
--

DROP TABLE IF EXISTS `authors`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `authors` (
  `AuthorsID` int NOT NULL,
  `FirstName` varchar(45) NOT NULL,
  `LastName` varchar(45) NOT NULL,
  `BirthDate` timestamp NOT NULL,
  `Country` varchar(45) NOT NULL,
  PRIMARY KEY (`AuthorsID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `authors`
--

LOCK TABLES `authors` WRITE;
/*!40000 ALTER TABLE `authors` DISABLE KEYS */;
INSERT INTO `authors` VALUES (1,'John','Smith','1980-05-14 16:00:00','United States'),(2,'Jane','Doe','1975-08-19 16:00:00','Canada'),(3,'Michael','Johnson','1992-03-09 16:00:00','United Kingdom'),(4,'Sarah','Williams','1988-11-24 16:00:00','Australia'),(5,'Robert','Brown','1970-07-17 16:00:00','Germany'),(6,'Emily','Davis','1985-01-29 16:00:00','France'),(7,'William','Miller','1995-09-04 16:00:00','Brazil'),(8,'Olivia','Wilson','1982-12-11 16:00:00','India'),(9,'Ethan','Moore','1978-06-07 16:00:00','China'),(10,'Mia','Taylor','1990-04-21 16:00:00','Japan');
/*!40000 ALTER TABLE `authors` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary view structure for view `authorview`
--

DROP TABLE IF EXISTS `authorview`;
/*!50001 DROP VIEW IF EXISTS `authorview`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `authorview` AS SELECT 
 1 AS `BookTitle`,
 1 AS `AuthorFirstName`,
 1 AS `AuthorLastName`*/;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `availablegenre`
--

DROP TABLE IF EXISTS `availablegenre`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `availablegenre` (
  `AG_ID` int NOT NULL AUTO_INCREMENT,
  `Genre` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`AG_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=37 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `availablegenre`
--

LOCK TABLES `availablegenre` WRITE;
/*!40000 ALTER TABLE `availablegenre` DISABLE KEYS */;
INSERT INTO `availablegenre` VALUES (31,'Science Fiction'),(32,'Romance'),(33,'Fantasy'),(34,'Magical Realism'),(35,'Philosophy');
/*!40000 ALTER TABLE `availablegenre` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `bookauthors`
--

DROP TABLE IF EXISTS `bookauthors`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `bookauthors` (
  `BookAuthorID` int NOT NULL,
  `BookID` int NOT NULL,
  `AuthorID` int NOT NULL,
  PRIMARY KEY (`BookAuthorID`),
  KEY `AuthorID_idx` (`AuthorID`),
  CONSTRAINT `AuthorID` FOREIGN KEY (`AuthorID`) REFERENCES `authors` (`AuthorsID`),
  CONSTRAINT `BookID` FOREIGN KEY (`AuthorID`) REFERENCES `authors` (`AuthorsID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `bookauthors`
--

LOCK TABLES `bookauthors` WRITE;
/*!40000 ALTER TABLE `bookauthors` DISABLE KEYS */;
INSERT INTO `bookauthors` VALUES (1,1,1),(2,2,2),(3,3,3),(4,4,4),(5,5,5),(6,6,6),(7,7,7),(8,8,8),(9,9,9),(10,10,10);
/*!40000 ALTER TABLE `bookauthors` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `books`
--

DROP TABLE IF EXISTS `books`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `books` (
  `BookID` int NOT NULL,
  `Title` varchar(255) NOT NULL,
  `ISBN` varchar(40) NOT NULL,
  `PublishedDate` date NOT NULL,
  `Genre` varchar(45) NOT NULL,
  `AuthorID` int NOT NULL,
  PRIMARY KEY (`BookID`),
  KEY `AuthorID_idx` (`AuthorID`),
  KEY `books_AuthorID_idx` (`AuthorID`),
  CONSTRAINT `books_AuthorID` FOREIGN KEY (`AuthorID`) REFERENCES `authors` (`AuthorsID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `books`
--

LOCK TABLES `books` WRITE;
/*!40000 ALTER TABLE `books` DISABLE KEYS */;
INSERT INTO `books` VALUES (1,'The Great Gatsby','978-0743273565','2003-09-30','Fiction',2),(2,'To Kill a Mockingbird','978-0061120084','2006-05-23','Fiction',2),(3,'Hello','978-0451524935','2000-06-08','Science Fiction',3),(4,'Pride and Prejudice','978-1613823729','2000-01-28','Romance',4),(5,'The Hobbit','978-0345339683','2005-09-21','Fantasy',5),(6,'The Catcher in the Rye','978-0316769480','2000-07-16','Fiction',2),(7,'One Hundred Years of Solitude','978-0060883287','2004-05-30','Magical Realism',7),(8,'The Alchemist','978-0061122415','2009-09-01','Fiction',2),(9,'Harry Potter and the Sorcerer\'s Stone','978-0590353427','2000-06-26','Fantasy',9),(10,'The Art of War','978-1590302255','2000-01-17','Philosophy',10);
/*!40000 ALTER TABLE `books` ENABLE KEYS */;
UNLOCK TABLES;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `insert_books_trigger` AFTER INSERT ON `books` FOR EACH ROW BEGIN
    INSERT INTO availablegenre (Genre)
    SELECT DISTINCT Genre FROM books;
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `update_books_trigger` AFTER UPDATE ON `books` FOR EACH ROW BEGIN
    DELETE FROM availableGenre;
    INSERT INTO availableGenre (Genre)
    SELECT DISTINCT Genre FROM books;
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `delete_books_trigger` AFTER DELETE ON `books` FOR EACH ROW BEGIN
    DELETE FROM availableGenre;
    INSERT INTO availableGenre (Genre)
    SELECT DISTINCT Genre FROM books;
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Temporary view structure for view `booksview`
--

DROP TABLE IF EXISTS `booksview`;
/*!50001 DROP VIEW IF EXISTS `booksview`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `booksview` AS SELECT 
 1 AS `BookID`,
 1 AS `Title`,
 1 AS `ISBN`,
 1 AS `PublishedDate`,
 1 AS `Genre`,
 1 AS `FirstName`,
 1 AS `LastName`*/;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `genres`
--

DROP TABLE IF EXISTS `genres`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `genres` (
  `GenreID` int NOT NULL,
  `GenreName` varchar(45) NOT NULL,
  PRIMARY KEY (`GenreID`),
  CONSTRAINT `GenreID` FOREIGN KEY (`GenreID`) REFERENCES `books` (`BookID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `genres`
--

LOCK TABLES `genres` WRITE;
/*!40000 ALTER TABLE `genres` DISABLE KEYS */;
INSERT INTO `genres` VALUES (1,'Fiction'),(2,'Science Fiction'),(3,'Romance'),(4,'Fantasy'),(5,'Mystery'),(6,'Thriller'),(7,'Historical'),(8,'Non-Fiction'),(9,'Biography'),(10,'Philosophy');
/*!40000 ALTER TABLE `genres` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `publishers`
--

DROP TABLE IF EXISTS `publishers`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `publishers` (
  `PublisherID` int NOT NULL,
  `PublisherName` varchar(45) NOT NULL,
  `FoundedDate` date NOT NULL,
  `Country` varchar(45) NOT NULL,
  PRIMARY KEY (`PublisherID`),
  CONSTRAINT `PublisherID` FOREIGN KEY (`PublisherID`) REFERENCES `books` (`BookID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `publishers`
--

LOCK TABLES `publishers` WRITE;
/*!40000 ALTER TABLE `publishers` DISABLE KEYS */;
INSERT INTO `publishers` VALUES (1,'Penguin Random','1927-07-01','United States'),(2,'HarperCollins','1989-01-17','United Kingdom'),(3,'Hachette Livre','1826-01-01','France'),(4,'Springer','1842-05-10','Germany'),(5,'Pearson','1844-01-01','United Kingdom'),(6,'Random House','1927-01-01','United States'),(7,'Macmillan','1843-01-01','United Kingdom'),(8,'Simon & Schuster','1924-04-02','United States'),(9,'Elsevier','1880-01-01','Netherlands'),(10,'Wiley','1807-01-01','United States');
/*!40000 ALTER TABLE `publishers` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `users`
--

DROP TABLE IF EXISTS `users`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `users` (
  `users_id` int NOT NULL AUTO_INCREMENT,
  `username` varchar(45) NOT NULL,
  `password` varchar(45) NOT NULL,
  `name` varchar(45) NOT NULL DEFAULT 'Add Name',
  `contact` varchar(45) NOT NULL DEFAULT 'Add Contact',
  `acc_type` varchar(45) NOT NULL DEFAULT 'user',
  `status` tinyint NOT NULL DEFAULT '0',
  PRIMARY KEY (`users_id`),
  UNIQUE KEY `username_UNIQUE` (`username`)
) ENGINE=InnoDB AUTO_INCREMENT=48 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `users`
--

LOCK TABLES `users` WRITE;
/*!40000 ALTER TABLE `users` DISABLE KEYS */;
INSERT INTO `users` VALUES (1,'emjey','0511','Mary Jane Opeña','0976666666','admin',1),(43,'mjay','0511','Mary Jane opeña','0944264184','admin',0),(46,'MJ','password','Mary Jane','0998765432','user',0),(47,'charo','0987654321','Charo','098765432','user',0);
/*!40000 ALTER TABLE `users` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary view structure for view `viewbooksgenre`
--

DROP TABLE IF EXISTS `viewbooksgenre`;
/*!50001 DROP VIEW IF EXISTS `viewbooksgenre`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `viewbooksgenre` AS SELECT 
 1 AS `Title`,
 1 AS `Genre`*/;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `wishlist`
--

DROP TABLE IF EXISTS `wishlist`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `wishlist` (
  `wishlist_id` int NOT NULL AUTO_INCREMENT,
  `user_id` int NOT NULL,
  `book_id` int NOT NULL,
  PRIMARY KEY (`wishlist_id`),
  KEY `userfk1_idx` (`user_id`),
  KEY `bookfk1_idx` (`book_id`),
  CONSTRAINT `bookfk1` FOREIGN KEY (`book_id`) REFERENCES `books` (`BookID`),
  CONSTRAINT `userfk1` FOREIGN KEY (`user_id`) REFERENCES `users` (`users_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `wishlist`
--

LOCK TABLES `wishlist` WRITE;
/*!40000 ALTER TABLE `wishlist` DISABLE KEYS */;
/*!40000 ALTER TABLE `wishlist` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping events for database 'books'
--

--
-- Dumping routines for database 'books'
--
/*!50003 DROP FUNCTION IF EXISTS `CountBooksByAuthor` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = cp850 */ ;
/*!50003 SET character_set_results = cp850 */ ;
/*!50003 SET collation_connection  = cp850_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` FUNCTION `CountBooksByAuthor`(AuthorID INT) RETURNS int
    DETERMINISTIC
BEGIN
    DECLARE BookCount INT;
    SELECT COUNT(*)
    INTO BookCount
    FROM Books
    WHERE Author = AuthorID;
    RETURN BookCount;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP FUNCTION IF EXISTS `CountBooksByGenre` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = cp850 */ ;
/*!50003 SET character_set_results = cp850 */ ;
/*!50003 SET collation_connection  = cp850_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` FUNCTION `CountBooksByGenre`(GenreID INT) RETURNS int
    DETERMINISTIC
BEGIN
    DECLARE BookCount INT;
    SELECT COUNT(*)
    INTO BookCount
    FROM Books
    WHERE Genre = GenreID;
    RETURN BookCount;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `GetBooksByAuthorID` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = cp850 */ ;
/*!50003 SET character_set_results = cp850 */ ;
/*!50003 SET collation_connection  = cp850_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `GetBooksByAuthorID`(
    IN p_AuthorID INT
)
BEGIN
    SELECT BookID, Title, ISBN, PublishedDate, Genre
    FROM Books
    WHERE AuthorID = p_AuthorID;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Final view structure for view `authorview`
--

/*!50001 DROP VIEW IF EXISTS `authorview`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `authorview` AS select `b`.`Title` AS `BookTitle`,`a`.`FirstName` AS `AuthorFirstName`,`a`.`LastName` AS `AuthorLastName` from (`authors` `a` join `books` `b` on((`a`.`AuthorsID` = `b`.`AuthorID`))) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `booksview`
--

/*!50001 DROP VIEW IF EXISTS `booksview`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `booksview` AS select `b`.`BookID` AS `BookID`,`b`.`Title` AS `Title`,`b`.`ISBN` AS `ISBN`,`b`.`PublishedDate` AS `PublishedDate`,`b`.`Genre` AS `Genre`,`a`.`FirstName` AS `FirstName`,`a`.`LastName` AS `LastName` from (`books` `b` join `authors` `a` on((`b`.`AuthorID` = `a`.`AuthorsID`))) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `viewbooksgenre`
--

/*!50001 DROP VIEW IF EXISTS `viewbooksgenre`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `viewbooksgenre` AS select `books`.`Title` AS `Title`,`books`.`Genre` AS `Genre` from `books` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-04-12  7:52:41
