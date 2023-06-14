CREATE DATABASE bd_Gravadora;

use bd_Gravadora;

CREATE TABLE TBL_Musica(
  idMusica INT NOT NULL AUTO_INCREMENT,
  nome VARCHAR(50) DEFAULT NULL,
  nomeAutor VARCHAR(50) DEFAULT NULL,
  nomeGravadora VARCHAR(50) DEFAULT NULL,  
  PRIMARY KEY(idMusica)  
);
