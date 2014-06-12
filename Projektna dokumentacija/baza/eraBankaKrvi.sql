SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='TRADITIONAL,ALLOW_INVALID_DATES';


-- -----------------------------------------------------
-- Table `tipPacijenta`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `tipPacijenta` ;

CREATE TABLE IF NOT EXISTS `tipPacijenta` (
  `tipKorisnikaID` INT NOT NULL AUTO_INCREMENT,
  `naziv` VARCHAR(45) NULL,
  PRIMARY KEY (`tipKorisnikaID`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `krvnaGrupa`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `krvnaGrupa` ;

CREATE TABLE IF NOT EXISTS `krvnaGrupa` (
  `krvnaGrupaID` INT NOT NULL AUTO_INCREMENT,
  `naziv` VARCHAR(3) NULL,
  PRIMARY KEY (`krvnaGrupaID`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `spol`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `spol` ;

CREATE TABLE IF NOT EXISTS `spol` (
  `spolID` INT NOT NULL,
  `naziv` VARCHAR(45) NULL,
  PRIMARY KEY (`spolID`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `pacijent`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `pacijent` ;

CREATE TABLE IF NOT EXISTS `pacijent` (
  `pacijentID` INT NOT NULL AUTO_INCREMENT,
  `OIB` CHAR(11) NULL,
  `ime` VARCHAR(45) NULL,
  `prezime` VARCHAR(45) NULL,
  `adresa` VARCHAR(45) NULL,
  `brojPoliceOsiguranja` VARCHAR(45) NULL,
  `telefon` VARCHAR(45) NULL,
  `email` VARCHAR(45) NULL,
  `tezina` VARCHAR(45) NULL,
  `datum_rodenja` DATE NULL,
  `pacijent_krvnaGrupaID` INT NOT NULL,
  `pacijent_tipPacijentaID` INT NOT NULL,
  `pacijent_spolID` INT NOT NULL,
  PRIMARY KEY (`pacijentID`),
  INDEX `fk_korisnik_tipKorisnika_idx` (`pacijent_tipPacijentaID` ASC),
  INDEX `fk_korisnik_krvnaGrupa1_idx` (`pacijent_krvnaGrupaID` ASC),
  INDEX `fk_korisnik_spol1_idx` (`pacijent_spolID` ASC),
  CONSTRAINT `fk_korisnik_tipKorisnika`
    FOREIGN KEY (`pacijent_tipPacijentaID`)
    REFERENCES `tipPacijenta` (`tipKorisnikaID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_korisnik_krvnaGrupa1`
    FOREIGN KEY (`pacijent_krvnaGrupaID`)
    REFERENCES `krvnaGrupa` (`krvnaGrupaID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_korisnik_spol1`
    FOREIGN KEY (`pacijent_spolID`)
    REFERENCES `spol` (`spolID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `ustanova`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `ustanova` ;

CREATE TABLE IF NOT EXISTS `ustanova` (
  `ustanovaID` INT NOT NULL AUTO_INCREMENT,
  `naziv` VARCHAR(45) NULL,
  `adresa` VARCHAR(45) NULL,
  `email` VARCHAR(45) NULL,
  `telefon` VARCHAR(45) NULL,
  PRIMARY KEY (`ustanovaID`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `hladnjak`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `hladnjak` ;

CREATE TABLE IF NOT EXISTS `hladnjak` (
  `hladnjakID` INT NOT NULL AUTO_INCREMENT,
  `naziv` VARCHAR(45) NULL,
  `pun` TINYINT(1) NULL,
  `hladnjak_krvnaGrupaID` INT NOT NULL,
  PRIMARY KEY (`hladnjakID`),
  INDEX `fk_hladnjak_krvnaGrupa1_idx` (`hladnjak_krvnaGrupaID` ASC),
  CONSTRAINT `fk_hladnjak_krvnaGrupa1`
    FOREIGN KEY (`hladnjak_krvnaGrupaID`)
    REFERENCES `krvnaGrupa` (`krvnaGrupaID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `tipZaposlenika`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `tipZaposlenika` ;

CREATE TABLE IF NOT EXISTS `tipZaposlenika` (
  `tipZaposlenikaID` INT NOT NULL,
  `naziv` VARCHAR(45) NULL,
  PRIMARY KEY (`tipZaposlenikaID`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `zaposlenik`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `zaposlenik` ;

CREATE TABLE IF NOT EXISTS `zaposlenik` (
  `zaposlenikID` INT NOT NULL AUTO_INCREMENT,
  `ime` VARCHAR(45) NULL,
  `prezime` VARCHAR(45) NULL,
  `korisnickoIme` VARCHAR(45) NULL,
  `lozinka` VARCHAR(45) NULL,
  `email` VARCHAR(45) NULL,
  `telefon` VARCHAR(45) NULL,
  `zaposlenik_tipZaposlenikaID` INT NOT NULL,
  `zaposlenik_ustanovaID` INT NOT NULL,
  PRIMARY KEY (`zaposlenikID`),
  INDEX `fk_zaposlenik_tipZaposlenika1_idx` (`zaposlenik_tipZaposlenikaID` ASC),
  INDEX `fk_zaposlenik_ustanova1_idx` (`zaposlenik_ustanovaID` ASC),
  CONSTRAINT `fk_zaposlenik_tipZaposlenika1`
    FOREIGN KEY (`zaposlenik_tipZaposlenikaID`)
    REFERENCES `tipZaposlenika` (`tipZaposlenikaID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_zaposlenik_ustanova1`
    FOREIGN KEY (`zaposlenik_ustanovaID`)
    REFERENCES `ustanova` (`ustanovaID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `donacija`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `donacija` ;

CREATE TABLE IF NOT EXISTS `donacija` (
  `donacijaID` INT NOT NULL AUTO_INCREMENT,
  `vrijeme` TIMESTAMP NOT NULL DEFAULT NOW(),
  `napomena` TEXT NULL,
  `kolicina` INT NULL,
  `donacija_pacijentID` INT NOT NULL,
  `donacija_hladnjakID` INT NOT NULL,
  `donacija_zaposlenikID` INT NOT NULL,
  PRIMARY KEY (`donacijaID`),
  INDEX `fk_donacija_korisnik1_idx` (`donacija_pacijentID` ASC),
  INDEX `fk_donacija_hladnjak1_idx` (`donacija_hladnjakID` ASC),
  INDEX `fk_donacija_zaposlenik1_idx` (`donacija_zaposlenikID` ASC),
  CONSTRAINT `fk_donacija_korisnik1`
    FOREIGN KEY (`donacija_pacijentID`)
    REFERENCES `pacijent` (`pacijentID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_donacija_hladnjak1`
    FOREIGN KEY (`donacija_hladnjakID`)
    REFERENCES `hladnjak` (`hladnjakID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_donacija_zaposlenik1`
    FOREIGN KEY (`donacija_zaposlenikID`)
    REFERENCES `zaposlenik` (`zaposlenikID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `bolest`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `bolest` ;

CREATE TABLE IF NOT EXISTS `bolest` (
  `bolestID` INT NOT NULL AUTO_INCREMENT,
  `naziv` VARCHAR(45) NULL,
  PRIMARY KEY (`bolestID`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `test`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `test` ;

CREATE TABLE IF NOT EXISTS `test` (
  `testID` INT NOT NULL AUTO_INCREMENT,
  `odobren` TINYINT(1) NOT NULL,
  `vrijeme` TIMESTAMP NOT NULL DEFAULT NOW(),
  `test_ustanovaID` INT NOT NULL,
  `test_bolestID` INT NOT NULL,
  `test_donacijaID` INT NOT NULL,
  PRIMARY KEY (`testID`),
  INDEX `fk_test_ustanova1_idx` (`test_ustanovaID` ASC),
  INDEX `fk_test_bolest1_idx` (`test_bolestID` ASC),
  INDEX `fk_test_donacija1_idx` (`test_donacijaID` ASC),
  CONSTRAINT `fk_test_ustanova1`
    FOREIGN KEY (`test_ustanovaID`)
    REFERENCES `ustanova` (`ustanovaID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_test_bolest1`
    FOREIGN KEY (`test_bolestID`)
    REFERENCES `bolest` (`bolestID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_test_donacija1`
    FOREIGN KEY (`test_donacijaID`)
    REFERENCES `donacija` (`donacijaID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `transfuzija`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `transfuzija` ;

CREATE TABLE IF NOT EXISTS `transfuzija` (
  `transfuzijaID` INT NOT NULL AUTO_INCREMENT,
  `povjest_bolesti` TEXT NULL,
  `kolicina` INT NULL,
  `datum` TIMESTAMP NULL DEFAULT NOW(),
  `transfuzija_pacijentID` INT NOT NULL,
  `transfuzija_ustanovaID` INT NOT NULL,
  PRIMARY KEY (`transfuzijaID`),
  INDEX `fk_transfuzija_korisnik1_idx` (`transfuzija_pacijentID` ASC),
  INDEX `fk_transfuzija_ustanova1_idx` (`transfuzija_ustanovaID` ASC),
  CONSTRAINT `fk_transfuzija_korisnik1`
    FOREIGN KEY (`transfuzija_pacijentID`)
    REFERENCES `pacijent` (`pacijentID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_transfuzija_ustanova1`
    FOREIGN KEY (`transfuzija_ustanovaID`)
    REFERENCES `ustanova` (`ustanovaID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `tipPtReakcije`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `tipPtReakcije` ;

CREATE TABLE IF NOT EXISTS `tipPtReakcije` (
  `tipPtReakcijeID` INT NOT NULL,
  `naziv` VARCHAR(45) NULL,
  PRIMARY KEY (`tipPtReakcijeID`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `transfuzija_has_tipPtReakcije`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `transfuzija_has_tipPtReakcije` ;

CREATE TABLE IF NOT EXISTS `transfuzija_has_tipPtReakcije` (
  `transfuzija_transfuzijaID` INT NOT NULL,
  `tipPtReakcije_tipPtReakcijeID` INT NOT NULL,
  PRIMARY KEY (`transfuzija_transfuzijaID`, `tipPtReakcije_tipPtReakcijeID`),
  INDEX `fk_transfuzija_has_tipPtReakcije_tipPtReakcije1_idx` (`tipPtReakcije_tipPtReakcijeID` ASC),
  INDEX `fk_transfuzija_has_tipPtReakcije_transfuzija1_idx` (`transfuzija_transfuzijaID` ASC),
  CONSTRAINT `fk_transfuzija_has_tipPtReakcije_transfuzija1`
    FOREIGN KEY (`transfuzija_transfuzijaID`)
    REFERENCES `transfuzija` (`transfuzijaID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_transfuzija_has_tipPtReakcije_tipPtReakcije1`
    FOREIGN KEY (`tipPtReakcije_tipPtReakcijeID`)
    REFERENCES `tipPtReakcije` (`tipPtReakcijeID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `transfuzija_has_donacija`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `transfuzija_has_donacija` ;

CREATE TABLE IF NOT EXISTS `transfuzija_has_donacija` (
  `transfuzija_transfuzijaID` INT NOT NULL,
  `donacija_donacijaID` INT NOT NULL,
  PRIMARY KEY (`transfuzija_transfuzijaID`, `donacija_donacijaID`),
  INDEX `fk_transfuzija_has_donacija_donacija1_idx` (`donacija_donacijaID` ASC),
  INDEX `fk_transfuzija_has_donacija_transfuzija1_idx` (`transfuzija_transfuzijaID` ASC),
  CONSTRAINT `fk_transfuzija_has_donacija_transfuzija1`
    FOREIGN KEY (`transfuzija_transfuzijaID`)
    REFERENCES `transfuzija` (`transfuzijaID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_transfuzija_has_donacija_donacija1`
    FOREIGN KEY (`donacija_donacijaID`)
    REFERENCES `donacija` (`donacijaID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;

-- -----------------------------------------------------
-- Data for table `tipPacijenta`
-- -----------------------------------------------------
START TRANSACTION;
INSERT INTO `tipPacijenta` (`tipKorisnikaID`, `naziv`) VALUES (1, 'donor');
INSERT INTO `tipPacijenta` (`tipKorisnikaID`, `naziv`) VALUES (2, 'pacijent');

COMMIT;


-- -----------------------------------------------------
-- Data for table `krvnaGrupa`
-- -----------------------------------------------------
START TRANSACTION;
INSERT INTO `krvnaGrupa` (`krvnaGrupaID`, `naziv`) VALUES (1, 'A+');
INSERT INTO `krvnaGrupa` (`krvnaGrupaID`, `naziv`) VALUES (2, 'A-');
INSERT INTO `krvnaGrupa` (`krvnaGrupaID`, `naziv`) VALUES (3, 'B+');
INSERT INTO `krvnaGrupa` (`krvnaGrupaID`, `naziv`) VALUES (4, 'B-');
INSERT INTO `krvnaGrupa` (`krvnaGrupaID`, `naziv`) VALUES (5, 'AB+');
INSERT INTO `krvnaGrupa` (`krvnaGrupaID`, `naziv`) VALUES (6, 'AB-');
INSERT INTO `krvnaGrupa` (`krvnaGrupaID`, `naziv`) VALUES (7, '0+');
INSERT INTO `krvnaGrupa` (`krvnaGrupaID`, `naziv`) VALUES (8, '0-');

COMMIT;


-- -----------------------------------------------------
-- Data for table `spol`
-- -----------------------------------------------------
START TRANSACTION;
INSERT INTO `spol` (`spolID`, `naziv`) VALUES (1, 'muški');
INSERT INTO `spol` (`spolID`, `naziv`) VALUES (2, 'ženski');
INSERT INTO `spol` (`spolID`, `naziv`) VALUES (3, 'drugo');

COMMIT;


-- -----------------------------------------------------
-- Data for table `pacijent`
-- -----------------------------------------------------
START TRANSACTION;
INSERT INTO `pacijent` (`pacijentID`, `OIB`, `ime`, `prezime`, `adresa`, `brojPoliceOsiguranja`, `telefon`, `email`, `tezina`, `datum_rodenja`, `pacijent_krvnaGrupaID`, `pacijent_tipPacijentaID`, `pacijent_spolID`) VALUES (1, '65498732165', 'Roko', 'Rokic', 'Rokiceva 1', '123456789', '0925632587', 'rlabrovi@foi.hr', '80', '1992-02-03', 1, 1, 1);
INSERT INTO `pacijent` (`pacijentID`, `OIB`, `ime`, `prezime`, `adresa`, `brojPoliceOsiguranja`, `telefon`, `email`, `tezina`, `datum_rodenja`, `pacijent_krvnaGrupaID`, `pacijent_tipPacijentaID`, `pacijent_spolID`) VALUES (2, '45678912345', 'Marko', 'Markic', 'Markiceva 2', '987654321', '0932563254', 'vlazar@foi.hr', '75', '1993-04-05', 2, 1, 1);
INSERT INTO `pacijent` (`pacijentID`, `OIB`, `ime`, `prezime`, `adresa`, `brojPoliceOsiguranja`, `telefon`, `email`, `tezina`, `datum_rodenja`, `pacijent_krvnaGrupaID`, `pacijent_tipPacijentaID`, `pacijent_spolID`) VALUES (3, '25814736995', 'Ivan', 'Ivic', 'Ivaniceva 3', '147852369', '0958745632', 'vlazar@foi.hr', '60', '1992-05-06', 3, 1, 1);
INSERT INTO `pacijent` (`pacijentID`, `OIB`, `ime`, `prezime`, `adresa`, `brojPoliceOsiguranja`, `telefon`, `email`, `tezina`, `datum_rodenja`, `pacijent_krvnaGrupaID`, `pacijent_tipPacijentaID`, `pacijent_spolID`) VALUES (4, '18372946852', 'Jovanka', 'Jovankovic', 'Jovankoviceva 4', '369852147', '0956895321', 'vlazar@foi.hr', '60', '1992-06-07', 4, 1, 2);
INSERT INTO `pacijent` (`pacijentID`, `OIB`, `ime`, `prezime`, `adresa`, `brojPoliceOsiguranja`, `telefon`, `email`, `tezina`, `datum_rodenja`, `pacijent_krvnaGrupaID`, `pacijent_tipPacijentaID`, `pacijent_spolID`) VALUES (5, '95175385214', 'Radojka', 'Radodajka', 'Radodajkoviceva 5', '753159654', '0956985474', 'vlazar@foi.hr', '50', '1992-07-08', 5, 1, 2);
INSERT INTO `pacijent` (`pacijentID`, `OIB`, `ime`, `prezime`, `adresa`, `brojPoliceOsiguranja`, `telefon`, `email`, `tezina`, `datum_rodenja`, `pacijent_krvnaGrupaID`, `pacijent_tipPacijentaID`, `pacijent_spolID`) VALUES (6, '35795145632', 'Miloslava', 'Miloslavic', 'Mažuraniceva 6', '159357895', '0998523654', 'vlazar@foi.hr', '55', '1988-02-03', 6, 1, 2);
INSERT INTO `pacijent` (`pacijentID`, `OIB`, `ime`, `prezime`, `adresa`, `brojPoliceOsiguranja`, `telefon`, `email`, `tezina`, `datum_rodenja`, `pacijent_krvnaGrupaID`, `pacijent_tipPacijentaID`, `pacijent_spolID`) VALUES (7, '45698785236', 'Guido', 'Guidic', 'Ulica Krešimirove obale', '365214789', '0912365897', 'rlabrovi@foi.hr', '80', '1989-02-03', 7, 2, 1);
INSERT INTO `pacijent` (`pacijentID`, `OIB`, `ime`, `prezime`, `adresa`, `brojPoliceOsiguranja`, `telefon`, `email`, `tezina`, `datum_rodenja`, `pacijent_krvnaGrupaID`, `pacijent_tipPacijentaID`, `pacijent_spolID`) VALUES (8, '95145632145', 'Marina', 'Marinic', 'Put Dikla 55', '125478963', '0918524569', 'rlabrovi@foi.hr', '88', '1992-01-01', 8, 2, 2);
INSERT INTO `pacijent` (`pacijentID`, `OIB`, `ime`, `prezime`, `adresa`, `brojPoliceOsiguranja`, `telefon`, `email`, `tezina`, `datum_rodenja`, `pacijent_krvnaGrupaID`, `pacijent_tipPacijentaID`, `pacijent_spolID`) VALUES (9, '14523669854', 'Luka', 'Lukic', 'Put Nina 43', '365214789', '0913214569', 'rlabrovi@foi.hr', '90', '1992-02-02', 1, 2, 1);
INSERT INTO `pacijent` (`pacijentID`, `OIB`, `ime`, `prezime`, `adresa`, `brojPoliceOsiguranja`, `telefon`, `email`, `tezina`, `datum_rodenja`, `pacijent_krvnaGrupaID`, `pacijent_tipPacijentaID`, `pacijent_spolID`) VALUES (10, '78541236985', 'Miro', 'Miric', 'Augusta Harambašića 2', '965874123', '0984569874', 'rlabrovi@foi.hr', '97', '1996-06-03', 2, 2, 1);
INSERT INTO `pacijent` (`pacijentID`, `OIB`, `ime`, `prezime`, `adresa`, `brojPoliceOsiguranja`, `telefon`, `email`, `tezina`, `datum_rodenja`, `pacijent_krvnaGrupaID`, `pacijent_tipPacijentaID`, `pacijent_spolID`) VALUES (11, '45632158291', 'Marin', 'Marinic', 'Trpimirova obala 4b', '351759648', '0998521456', 'rlabrovi@foi.hr', '140', '1992-10-10', 3, 2, 1);

COMMIT;


-- -----------------------------------------------------
-- Data for table `ustanova`
-- -----------------------------------------------------
START TRANSACTION;
INSERT INTO `ustanova` (`ustanovaID`, `naziv`, `adresa`, `email`, `telefon`) VALUES (1, 'Opća bolnica \"Dr. Ivo Pedišić\"', 'J.J. Strossmayera 59', 'obs@obs.hr', '044/553-100');
INSERT INTO `ustanova` (`ustanovaID`, `naziv`, `adresa`, `email`, `telefon`) VALUES (2, 'Opća bolnica \"Dr. Josip Benčević\" ', 'Andrije Štampara 42', 'opca-bolnica-sb@sb.t-com.hr', '035/201-201');
INSERT INTO `ustanova` (`ustanovaID`, `naziv`, `adresa`, `email`, `telefon`) VALUES (3, 'Opća bolnica \"Dr. Tomislav Bardek\"', 'Željka Selingera bb', 'uprava@obkoprivnica.hr', '048/251-001');
INSERT INTO `ustanova` (`ustanovaID`, `naziv`, `adresa`, `email`, `telefon`) VALUES (4, 'Opća bolnica \"Hrvatski ponos\" ', 'Svetoslava Suronje 12,', 'bolnica@obhpknin.hr', '022/641-111');
INSERT INTO `ustanova` (`ustanovaID`, `naziv`, `adresa`, `email`, `telefon`) VALUES (5, 'Opća bolnica \"Veliko Srce\" ', 'Mihanovićeva 8', 'ravnateljstvo@obbj.hr', '043/279-222');
INSERT INTO `ustanova` (`ustanovaID`, `naziv`, `adresa`, `email`, `telefon`) VALUES (6, 'Opća bolnica \"Malo srce\" ', 'Roka Mišetića 2', 'uprava@bolnica-du.hr', '020/431-777');

COMMIT;


-- -----------------------------------------------------
-- Data for table `hladnjak`
-- -----------------------------------------------------
START TRANSACTION;
INSERT INTO `hladnjak` (`hladnjakID`, `naziv`, `pun`, `hladnjak_krvnaGrupaID`) VALUES (1, 'Hladnjak A+', 0, 1);
INSERT INTO `hladnjak` (`hladnjakID`, `naziv`, `pun`, `hladnjak_krvnaGrupaID`) VALUES (2, 'Hladnjak A-', 0, 2);
INSERT INTO `hladnjak` (`hladnjakID`, `naziv`, `pun`, `hladnjak_krvnaGrupaID`) VALUES (3, 'Hladnjak B+', 0, 3);
INSERT INTO `hladnjak` (`hladnjakID`, `naziv`, `pun`, `hladnjak_krvnaGrupaID`) VALUES (4, 'Hladnjak B-', 0, 4);
INSERT INTO `hladnjak` (`hladnjakID`, `naziv`, `pun`, `hladnjak_krvnaGrupaID`) VALUES (5, 'Hladnjak AB+', 0, 5);
INSERT INTO `hladnjak` (`hladnjakID`, `naziv`, `pun`, `hladnjak_krvnaGrupaID`) VALUES (6, 'Hladnjak Ab-', 0, 6);
INSERT INTO `hladnjak` (`hladnjakID`, `naziv`, `pun`, `hladnjak_krvnaGrupaID`) VALUES (7, 'Hladnjak 0+', 0, 7);
INSERT INTO `hladnjak` (`hladnjakID`, `naziv`, `pun`, `hladnjak_krvnaGrupaID`) VALUES (8, 'Hladnjak A+', 0, 8);

COMMIT;


-- -----------------------------------------------------
-- Data for table `tipZaposlenika`
-- -----------------------------------------------------
START TRANSACTION;
INSERT INTO `tipZaposlenika` (`tipZaposlenikaID`, `naziv`) VALUES (1, 'Zaposlenik');
INSERT INTO `tipZaposlenika` (`tipZaposlenikaID`, `naziv`) VALUES (2, 'Administrator');

COMMIT;


-- -----------------------------------------------------
-- Data for table `zaposlenik`
-- -----------------------------------------------------
START TRANSACTION;
INSERT INTO `zaposlenik` (`zaposlenikID`, `ime`, `prezime`, `korisnickoIme`, `lozinka`, `email`, `telefon`, `zaposlenik_tipZaposlenikaID`, `zaposlenik_ustanovaID`) VALUES (1, 'Hrvoje', 'Maletić', 'mmaletic', '123', 'rlabrovi@foi.hr', '0915632587', 2, 1);
INSERT INTO `zaposlenik` (`zaposlenikID`, `ime`, `prezime`, `korisnickoIme`, `lozinka`, `email`, `telefon`, `zaposlenik_tipZaposlenikaID`, `zaposlenik_ustanovaID`) VALUES (2, 'Julijan', 'Marin', 'jmarin', '123', 'rlabrovi@foi.hr', '0915632587', 1, 1);
INSERT INTO `zaposlenik` (`zaposlenikID`, `ime`, `prezime`, `korisnickoIme`, `lozinka`, `email`, `telefon`, `zaposlenik_tipZaposlenikaID`, `zaposlenik_ustanovaID`) VALUES (3, 'Mateo', 'Bobaček', 'mbobacek', '123', 'rlabrovi@foi.hr', '0915632587', 1, 1);
INSERT INTO `zaposlenik` (`zaposlenikID`, `ime`, `prezime`, `korisnickoIme`, `lozinka`, `email`, `telefon`, `zaposlenik_tipZaposlenikaID`, `zaposlenik_ustanovaID`) VALUES (4, 'Bruno', 'Marasović', 'bmarasovic', '123', 'rlabrovi@foi.hr', '0915632587', 1, 1);
INSERT INTO `zaposlenik` (`zaposlenikID`, `ime`, `prezime`, `korisnickoIme`, `lozinka`, `email`, `telefon`, `zaposlenik_tipZaposlenikaID`, `zaposlenik_ustanovaID`) VALUES (5, 'Mislav', 'Bago', 'mbago', '123', 'bago@gmail.com', '0915632587', 1, 2);

COMMIT;


-- -----------------------------------------------------
-- Data for table `donacija`
-- -----------------------------------------------------
START TRANSACTION;
INSERT INTO `donacija` (`donacijaID`, `vrijeme`, `napomena`, `kolicina`, `donacija_pacijentID`, `donacija_hladnjakID`, `donacija_zaposlenikID`) VALUES (1, '', NULL, 450, 1, 1, 2);
INSERT INTO `donacija` (`donacijaID`, `vrijeme`, `napomena`, `kolicina`, `donacija_pacijentID`, `donacija_hladnjakID`, `donacija_zaposlenikID`) VALUES (2, NULL, NULL, 450, 2, 2, 2);
INSERT INTO `donacija` (`donacijaID`, `vrijeme`, `napomena`, `kolicina`, `donacija_pacijentID`, `donacija_hladnjakID`, `donacija_zaposlenikID`) VALUES (3, NULL, NULL, 450, 3, 3, 2);
INSERT INTO `donacija` (`donacijaID`, `vrijeme`, `napomena`, `kolicina`, `donacija_pacijentID`, `donacija_hladnjakID`, `donacija_zaposlenikID`) VALUES (4, NULL, NULL, 450, 4, 4, 3);
INSERT INTO `donacija` (`donacijaID`, `vrijeme`, `napomena`, `kolicina`, `donacija_pacijentID`, `donacija_hladnjakID`, `donacija_zaposlenikID`) VALUES (5, NULL, NULL, 450, 4, 4, 3);

COMMIT;


-- -----------------------------------------------------
-- Data for table `bolest`
-- -----------------------------------------------------
START TRANSACTION;
INSERT INTO `bolest` (`bolestID`, `naziv`) VALUES (1, 'HIV-1');
INSERT INTO `bolest` (`bolestID`, `naziv`) VALUES (2, 'HIV-2');
INSERT INTO `bolest` (`bolestID`, `naziv`) VALUES (3, 'Hepatitis B');
INSERT INTO `bolest` (`bolestID`, `naziv`) VALUES (4, 'Hepatitis C');
INSERT INTO `bolest` (`bolestID`, `naziv`) VALUES (5, 'Sifilis');

COMMIT;


-- -----------------------------------------------------
-- Data for table `test`
-- -----------------------------------------------------
START TRANSACTION;
INSERT INTO `test` (`testID`, `odobren`, `vrijeme`, `test_ustanovaID`, `test_bolestID`, `test_donacijaID`) VALUES (1, 1, NULL, 1, 1, 1);
INSERT INTO `test` (`testID`, `odobren`, `vrijeme`, `test_ustanovaID`, `test_bolestID`, `test_donacijaID`) VALUES (2, 1, NULL, 1, 2, 1);
INSERT INTO `test` (`testID`, `odobren`, `vrijeme`, `test_ustanovaID`, `test_bolestID`, `test_donacijaID`) VALUES (3, 1, NULL, 1, 3, 1);
INSERT INTO `test` (`testID`, `odobren`, `vrijeme`, `test_ustanovaID`, `test_bolestID`, `test_donacijaID`) VALUES (4, 1, NULL, 1, 4, 1);
INSERT INTO `test` (`testID`, `odobren`, `vrijeme`, `test_ustanovaID`, `test_bolestID`, `test_donacijaID`) VALUES (5, 1, NULL, 1, 5, 1);
INSERT INTO `test` (`testID`, `odobren`, `vrijeme`, `test_ustanovaID`, `test_bolestID`, `test_donacijaID`) VALUES (6, 1, NULL, 1, 1, 2);
INSERT INTO `test` (`testID`, `odobren`, `vrijeme`, `test_ustanovaID`, `test_bolestID`, `test_donacijaID`) VALUES (7, 1, NULL, 1, 2, 2);
INSERT INTO `test` (`testID`, `odobren`, `vrijeme`, `test_ustanovaID`, `test_bolestID`, `test_donacijaID`) VALUES (8, 1, NULL, 1, 3, 2);
INSERT INTO `test` (`testID`, `odobren`, `vrijeme`, `test_ustanovaID`, `test_bolestID`, `test_donacijaID`) VALUES (9, 1, NULL, 1, 4, 2);
INSERT INTO `test` (`testID`, `odobren`, `vrijeme`, `test_ustanovaID`, `test_bolestID`, `test_donacijaID`) VALUES (10, 1, NULL, 1, 5, 2);

COMMIT;


-- -----------------------------------------------------
-- Data for table `transfuzija`
-- -----------------------------------------------------
START TRANSACTION;
INSERT INTO `transfuzija` (`transfuzijaID`, `povjest_bolesti`, `kolicina`, `datum`, `transfuzija_pacijentID`, `transfuzija_ustanovaID`) VALUES (1, 'Bolest 1', 450, '', 7, 1);
INSERT INTO `transfuzija` (`transfuzijaID`, `povjest_bolesti`, `kolicina`, `datum`, `transfuzija_pacijentID`, `transfuzija_ustanovaID`) VALUES (2, 'Bolest 2', 900, NULL, 8, 1);
INSERT INTO `transfuzija` (`transfuzijaID`, `povjest_bolesti`, `kolicina`, `datum`, `transfuzija_pacijentID`, `transfuzija_ustanovaID`) VALUES (3, 'Bolest 3', 450, NULL, 9, 2);
INSERT INTO `transfuzija` (`transfuzijaID`, `povjest_bolesti`, `kolicina`, `datum`, `transfuzija_pacijentID`, `transfuzija_ustanovaID`) VALUES (4, 'Bolest 4', 450, NULL, 10, 2);

COMMIT;


-- -----------------------------------------------------
-- Data for table `tipPtReakcije`
-- -----------------------------------------------------
START TRANSACTION;
INSERT INTO `tipPtReakcije` (`tipPtReakcijeID`, `naziv`) VALUES (1, 'Febrilna nehemolitička');
INSERT INTO `tipPtReakcije` (`tipPtReakcijeID`, `naziv`) VALUES (2, 'Akutna hemolitička');
INSERT INTO `tipPtReakcije` (`tipPtReakcijeID`, `naziv`) VALUES (3, 'Anafilaktička');

COMMIT;

