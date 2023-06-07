CREATE TABLE "CURSO" (
	"nome_curso"	VARCHAR(50),
	"modelo"	VARCHAR(50),
	"periodo"	VARCHAR(50),
	"turma"	VARCHAR(50),
	"nome_sigla"	VARCHAR(50),
	"idUNIVERSIDADE"	VARCHAR(50),
	PRIMARY KEY("nome_curso"),
	FOREIGN KEY("idUNIVERSIDADE") REFERENCES "UNIVERSIDADE"("CNPJ_universidade")
);
