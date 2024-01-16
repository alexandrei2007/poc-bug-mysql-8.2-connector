CREATE TABLE IF NOT EXISTS `store` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Name` varchar(50) NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `Id` (`Id`)
);

INSERT INTO `store` (Name) VALUES ('Example');