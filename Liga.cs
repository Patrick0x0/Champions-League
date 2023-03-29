using System;
using System.Collections.Generic;
    public class ChampionsLeague 
    {
    public List<Equipas> equipas;
    public List<Grupo> grupos;
    public Sorteio sorteio;
 

    public ChampionsLeague(List <Equipas> equipas) 
    {
        this.equipas = equipas;
        this.sorteio = new Sorteio(equipas);
        grupos = sorteio.SortearGrupos();
    }

    public void SimularChampionsLeague()
    {   
        Eliminatorias eliminatorias;
        List<Equipas> vencedores = new List<Equipas>();

        Console.WriteLine($" FASE GRUPOS ");

        foreach (Grupo grupo in grupos)
        {
            grupo.GetInfo();
            grupo.GerarPartidas();
            grupo.JogarPartidas();
            grupo.SelecionarVencedores();
            foreach (Equipas equipa in grupo.Vencedores)
                vencedores.Add(equipa);
            
            Console.WriteLine();
        }
        foreach (Equipas equipa in vencedores)
        System.Console.WriteLine(equipa.Nome + " " + equipa.OverGeral);
        Console.WriteLine();
        Console.WriteLine( $" FASE ELIMINATÓRIAS ");
        Console.WriteLine();
        Console.WriteLine($" Oitavas de final ");

        //8avos
        eliminatorias = sorteio.SortearEliminatorias(vencedores);
        vencedores = eliminatorias.JogarEliminatorias();
        Console.WriteLine();
        Console.WriteLine(" Quartas de final ");

        //4ª de finais
        eliminatorias = sorteio.SortearEliminatorias(vencedores);
        vencedores = eliminatorias.JogarEliminatorias();
        Console.WriteLine();
        Console.WriteLine(" Semi-final ");

        //semifinais
        eliminatorias = sorteio.SortearEliminatorias(vencedores);
        vencedores = eliminatorias.JogarEliminatorias();
        Console.WriteLine();
        Console.WriteLine(" Final ");

        //final
        eliminatorias = sorteio.SortearEliminatorias(vencedores);
        vencedores = eliminatorias.JogarEliminatorias();
        Console.WriteLine();
        if( vencedores[0].Nome == "Real Madrid")
        {
            Console.WriteLine($" SIUUUUUUUUUU!!!!!!!!!!!!! ");
        }
        if( vencedores[0].Nome == "Benfica")
        {
            Console.WriteLine($" Benfica é o maior ");
        }
        Console.WriteLine($" O vencedor da Champions League foi {vencedores[0].Nome} ");
    }


}
