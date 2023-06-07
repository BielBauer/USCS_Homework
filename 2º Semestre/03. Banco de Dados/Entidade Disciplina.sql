CREATE TABLE "DISCIPLINA" (
	"nome_disciplina"	VARCHAR(50),
	"turma"	VARCHAR(50),
	"nome_sigla"	VARCHAR(50),
	"idALUNO"	INT,
	"idCURSO"	VARCHAR(50),
	"idPROFESSOR"	INT,
	FOREIGN KEY("idALUNO") REFERENCES "ALUNO"("matricula_aluno"),
	FOREIGN KEY("idPROFESSOR") REFERENCES "PROFESSOR"("matricula_func"),
	FOREIGN KEY("idCURSO") REFERENCES "CURSO"("nome_curso"),
	PRIMARY KEY("nome_disciplina")
);
