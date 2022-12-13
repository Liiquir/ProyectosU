-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema taxonomía
-- ----------------------------------------------------
DROP SCHEMA IF EXISTS `taxonomía` ;

-- -----------------------------------------------------
-- Schema taxonomía
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `taxonomía` DEFAULT CHARACTER SET utf8 COLLATE utf8_spanish2_ci ;
USE `taxonomía` ;

-- -----------------------------------------------------
-- Table `taxonomía`.`categorias`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `taxonomía`.`categorias` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `reino` VARCHAR(45) NULL,
  `phylum` VARCHAR(45) NULL,
  `clase` VARCHAR(45) NULL,
  PRIMARY KEY (`id`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `taxonomía`.`clasificaciones`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `taxonomía`.`clasificaciones` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `orden` VARCHAR(45) NULL,
  `familia` VARCHAR(45) NULL,
  `categorias_id` INT NOT NULL,
  PRIMARY KEY (`id`, `categorias_id`),
  INDEX `fk_clasificaciones_categorias1_idx` (`categorias_id` ASC),
  CONSTRAINT `fk_clasificaciones_categorias1`
    FOREIGN KEY (`categorias_id`)
    REFERENCES `taxonomía`.`categorias` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `taxonomía`.`nomenclaturas`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `taxonomía`.`nomenclaturas` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `genero` VARCHAR(45) NULL COMMENT 'Epíteto genérico',
  `especie` VARCHAR(45) NULL COMMENT 'Epíteto específico',
  `clasificaciones_id` INT NOT NULL,
  PRIMARY KEY (`id`, `clasificaciones_id`),
  INDEX `fk_nomenclaturas_clasificaciones1_idx` (`clasificaciones_id` ASC),
  CONSTRAINT `fk_nomenclaturas_clasificaciones1`
    FOREIGN KEY (`clasificaciones_id`)
    REFERENCES `taxonomía`.`clasificaciones` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `taxonomía`.`nombres`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `taxonomía`.`nombres` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `cientifico` VARCHAR(85) NULL,
  `comun` VARCHAR(85) NULL,
  `nomenclaturas_id` INT NOT NULL,
  PRIMARY KEY (`id`, `nomenclaturas_id`),
  INDEX `fk_nombres_nomenclaturas_idx` (`nomenclaturas_id` ASC),
  CONSTRAINT `fk_nombres_nomenclaturas`
    FOREIGN KEY (`nomenclaturas_id`)
    REFERENCES `taxonomía`.`nomenclaturas` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;

-- -----------------------------------------------------
-- Data for table `taxonomía`.`categorias`
-- -----------------------------------------------------
START TRANSACTION;
USE `taxonomía`;
INSERT INTO `taxonomía`.`categorias` (`id`, `reino`, `phylum`, `clase`) VALUES (DEFAULT, 'Animalia', 'Chordata', 'Mammalia');
INSERT INTO `taxonomía`.`categorias` (`id`, `reino`, `phylum`, `clase`) VALUES (DEFAULT, 'Vegetal', 'Tracheophyta', 'Angiosperma');

COMMIT;


-- -----------------------------------------------------
-- Data for table `taxonomía`.`clasificaciones`
-- -----------------------------------------------------
START TRANSACTION;
USE `taxonomía`;
INSERT INTO `taxonomía`.`clasificaciones` (`id`, `orden`, `familia`, `categorias_id`) VALUES (DEFAULT, 'Artiodactyla', 'Bovidae', 1);
INSERT INTO `taxonomía`.`clasificaciones` (`id`, `orden`, `familia`, `categorias_id`) VALUES (DEFAULT, 'Glumifloral', 'Gramínea', 2);

COMMIT;


-- -----------------------------------------------------
-- Data for table `taxonomía`.`nomenclaturas`
-- -----------------------------------------------------
START TRANSACTION;
USE `taxonomía`;
INSERT INTO `taxonomía`.`nomenclaturas` (`id`, `genero`, `especie`, `clasificaciones_id`) VALUES (DEFAULT, 'Bos', 'Taurus', 1);
INSERT INTO `taxonomía`.`nomenclaturas` (`id`, `genero`, `especie`, `clasificaciones_id`) VALUES (DEFAULT, 'Zea', 'Maíz', 2);

COMMIT;


-- -----------------------------------------------------
-- Data for table `taxonomía`.`nombres`
-- -----------------------------------------------------
START TRANSACTION;
USE `taxonomía`;
INSERT INTO `taxonomía`.`nombres` (`id`, `cientifico`, `comun`, `nomenclaturas_id`) VALUES (DEFAULT, 'Bos Taurus ', 'Vaca', 1);
INSERT INTO `taxonomía`.`nombres` (`id`, `cientifico`, `comun`, `nomenclaturas_id`) VALUES (DEFAULT, 'Zea Maiz', 'Maíz', 2);

COMMIT;

-- -----------------------------------------------------
-- SQL Query ejemplo de la base de datos de taxonomía
-- -----------------------------------------------------
SELECT categorias.*,clasificaciones.orden,clasificaciones.familia, nomenclaturas.genero,nomenclaturas.especie,nombres.cientifico,nombres.comun
FROM categorias 
inner join clasificaciones on clasificaciones.categorias_id = categorias.id
inner join nomenclaturas on nomenclaturas.clasificaciones_id = clasificaciones.id
inner join nombres on nombres.nomenclaturas_id = nomenclaturas.id
;

