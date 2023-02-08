# Proiect.net

Las aici niste inserturi pentru tabela "Products", pentru a putea aparea pe FRONTEND

SET IDENTITY_INSERT Products ON;
insert into Products(Id, Name, productType, Price, Path) values (
	20, 'Aranjament cu Suculente (Sanseveria)', 'suculenta', 169, 'path1'),
	(21, 'Terariu mic cu plante', 'suculenta', 119, 'path2'),
	(22, 'Bonsai Ficus in Vas Negru', 'bonsai', 199, 'path3'),
	(23, 'Bonsai in Ghiveci Alb', 'bonsai', 244, 'path5'),
	(24, 'Bonsai Mare (120 cm)', 'bonsai', 999, 'path6');
SET IDENTITY_INSERT Products OFF;
