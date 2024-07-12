using Models;

Console.WriteLine("**********************");
Console.WriteLine("* Heroes Vs Monsters *");
Console.WriteLine("**********************");
Console.WriteLine();
Console.WriteLine("Bienvenue dans la forêt de « Shorewood », forêt enchantée du pays de « Stormwall ».\r\nDans cette forêt, se livre un combat acharné entre les héros d’une part et les monstres d’autre part.\r\nDécrivons, un peu ce monde, nous retrouvons deux familles de personnages, les héros : Humain ou \r\nnain et les monstres : Loup, Orque ou dragonnet.");

Nain nain = new Nain();
nain.CreationPersonnage();
Humain humain = new Humain();
humain.CreationPersonnage();
Orque orque = new Orque();
orque.CreationPersonnage();
Loup loup = new Loup();
loup.CreationPersonnage();
Dragonnet dragonnet = new Dragonnet();
dragonnet.CreationPersonnage();

Console.WriteLine("Voici les stats de l'humain : ");
Console.WriteLine($"Force :{humain.Force}");
Console.WriteLine($"Endurance : {humain.Endurance}");
Console.WriteLine($"Points de vie : {humain.PointsDeVie}");
Console.WriteLine($"Or : {humain.Or}");
Console.WriteLine($"Cuir : {humain.Cuir}");
Console.WriteLine();

Console.WriteLine("Voici les stats du nain : ");
Console.WriteLine($"Force :{nain.Force}");
Console.WriteLine($"Endurance : {nain.Endurance}");
Console.WriteLine($"Points de vie : {nain.PointsDeVie}");
Console.WriteLine($"Or : {nain.Or}");
Console.WriteLine($"Cuir : {nain.Cuir}");
Console.WriteLine();

Console.WriteLine("Voici les stats de l'orque : ");
Console.WriteLine($"Force :{orque.Force}");
Console.WriteLine($"Endurance : {orque.Endurance}");
Console.WriteLine($"Points de vie : {orque.PointsDeVie}");
Console.WriteLine($"Or : {orque.Or}");
Console.WriteLine($"Cuir : {orque.Cuir}");
Console.WriteLine();

Console.WriteLine("Voici les stats du dragonnetdragonnet : ");
Console.WriteLine($"Force :{dragonnet.Force}");
Console.WriteLine($"Endurance : {dragonnet.Endurance}");
Console.WriteLine($"Points de vie : {dragonnet.PointsDeVie}");
Console.WriteLine($"Or : {dragonnet.Or}");
Console.WriteLine($"Cuir : {dragonnet.Cuir}");
Console.WriteLine();

Console.WriteLine("Voici les stats du loup : ");
Console.WriteLine($"Force :{loup.Force}");
Console.WriteLine($"Endurance : {loup.Endurance}");
Console.WriteLine($"Points de vie : {loup.PointsDeVie}");
Console.WriteLine($"Or : {loup.Or}");
Console.WriteLine($"Cuir : {loup.Cuir}");
Console.WriteLine();