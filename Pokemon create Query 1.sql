--DROP DATABASE POKEDEXPOKEMON

--CREATE DATABASE POKEDEXPOKEMON

DROP TABLE Pokemon

--CREATE TABLE Pokemon
--(
--PokemonID INT NOT NULL IDENTITY (1,1) PRIMARY KEY
--,PokemonName VARCHAR(MAX)
--,PokemonImage1 VARCHAR(MAX)
--,PokemonImage2 VARCHAR (MAX)
--);


--	INSERT   [Pokemon]
--			([PokemonName]
--			,[PokemonImage1]
--			,[PokemonImage2])
--	VALUES
--		   ('Bulbasaur'
--		   ,'C:\Users\TECH-W129birm\Documents\Sparta Global Mitchell Work\Week 6\Images\bulbasaur.jpg'
--		   ,'C:\Users\TECH-W129birm\Documents\Sparta Global Mitchell Work\Week 6\Images\bulbasaur blacked.jpg')
--; 

--	INSERT   [Pokemon]
--		([PokemonName]
--		,[PokemonImage1]
--		,[PokemonImage2])

--	VALUES
--	('Pikachu'
--	,'C:\Users\TECH-W129birm\Documents\Sparta Global Mitchell Work\Week 6\Images\Pikachu.png'
--	,'C:\Users\TECH-W129birm\Documents\Sparta Global Mitchell Work\Week 6\Images\Pikachu Blacked.png')
--;



--DROP TABLE PokemonImage

--CREATE TABLE PokemonImage
--(
--PokemonID INT
--FOREIGN KEY (PokemonID) REFERENCES Pokemon (PokemonID)
--,PokemonImage VARBINARY(MAX) 
--);


--INSERT [Pokemon]
--		([PokemonName])
--		VALUES
--		('Bulbasaur')
--;
