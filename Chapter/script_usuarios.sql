CREATE TABLE Usuarios (
    Id INT PRIMARY KEY IDENTITY,
    Email VARCHAR(255) NOT NULL UNIQUE,
    Senha VARCHAR(120) NOT NULL,
	Tipo CHAR(1) NOT NULL
)
GO

INSERT INTO Usuarios VALUES ('email@sp.br', '1234', 1)
GO

SELECT * FROM Usuarios WHERE email = 'email@sp.br' AND senha = '1234'
GO

SELECT * FROM Livros
SELECT * FROM Usuarios