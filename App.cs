using System;
using System.Collections.Generic;
class App {
    static void Main() {

        Random r = new Random();
        List <Equipas> equipas = new List<Equipas> 
    { 
        new Equipas("Real Madrid","Esp",r.Next(80,100)),
        new Equipas("Barcelona","Esp",r.Next(80,100)),
        new Equipas("Atlético de Madrid","Esp",r.Next(70,100)),
        new Equipas("Valencia","Esp",r.Next(60,100)),
        new Equipas("Manchester City","Ing",r.Next(80,100)),
        new Equipas("Manchester United","Ing",r.Next(80,100)),
        new Equipas("Liverpool","Ing",r.Next(80,100)),
        new Equipas("Chelsea","Ing",r.Next(80,100)),
        new Equipas("Arsenal","Ing",r.Next(80,100)),
        new Equipas("Paris Saint-Germain","Fra",r.Next(70,100)),
        new Equipas("Marseille","Fra",r.Next(70,95)),
        new Equipas("Lyon","Fra",r.Next(60,95)),
        new Equipas("Bayern de Munique","Alm",r.Next(80,100)),
        new Equipas("Borussia Dortmund","Alm",r.Next(70,100)),
        new Equipas("RB Leipzig","Alm",r.Next(60,95)),
        new Equipas("Juventus","Ita",r.Next(80,100)),
        new Equipas("Inter de Milão","Ita",r.Next(70,100)),
        new Equipas("AC Milan","Ita",r.Next(70,100)),
        new Equipas("Napoli","Ita",r.Next(70,100)),
        new Equipas("Ajax","Hol",r.Next(60,80)),
        new Equipas("PSV Eindhoven","Hol",r.Next(50,70)),
        new Equipas("Benfica","Pt",r.Next(85,100)),
        new Equipas("Porto","Pt",r.Next(70,100)),
        new Equipas("Sporting CP","Pt",r.Next(80,100)),
        new Equipas("Galatasaray","Tur",r.Next(50,80)),
        new Equipas("Fenerbahçe","Tur",r.Next(60,70)),
        new Equipas("Besiktas","Tur",r.Next(50,70)),
        new Equipas("Shakhtar Donetsk","Ukr",r.Next(50,70)),
        new Equipas("Dynamo Kiev","Ukr",r.Next(50,70)),
        new Equipas("Zenit São Petersburgo","Rus",r.Next(50,70)),
        new Equipas("CSKA Moscou","Rus",r.Next(50,70)),
        new Equipas("Dinamo Moscou","Rus",r.Next(50,70)),
    };

        ChampionsLeague championsLeague = new ChampionsLeague(equipas);
        championsLeague.SimularChampionsLeague();
    }


}

