using System;
using System.Collections.Generic;

public class Grupo
{
    public string Nome { get; set; }
    public List<Equipas> Equipas { get; set; }
    public List<Jogos> Partidas { get; set; }
    public List<Equipas> Vencedores { get; set; }

    public Grupo(string nome, List<Equipas> equipas)
    {
        Nome = nome;
        Equipas = equipas;
        Partidas = new List<Jogos>();
        Vencedores = new List<Equipas>();
    }

    public void GerarPartidas()
    {
        for (int i = 0; i < Equipas.Count - 1; i++)
        {
            for (int j = i + 1; j < Equipas.Count; j++)
            {
                Jogos casa = new Jogos(Equipas[i], Equipas[j]);
                Jogos fora = new Jogos(Equipas[j], Equipas[i]);

                Partidas.Add(casa);
                Partidas.Add(fora);
            }
        }
    }

    public void JogarPartidas()
    {
        Random random = new Random(Equipas.Count);
        foreach (Jogos jogo in Partidas)
        {
            Equipas vencedor = jogo.SimularPartida();
            if (vencedor != null)
            {
                vencedor.Pontos+=3;
            }
            else
            {
                jogo.equipaCasa.Pontos++;
                jogo.equipaFora.Pontos++;
            }
                
        }
        
    }

    public void SelecionarVencedores()
    {
        List<Equipas> passaram = new List<Equipas>();
        foreach (Equipas equipa in Equipas)
        {
           passaram = Equipas.OrderBy(x => x.Pontos).ToList();
        }
            Vencedores.Add(passaram[0]);
            Vencedores.Add(passaram[1]);
    }
    public void GetInfo()
    {
        Console.WriteLine($"Grupo: {Nome}");
        foreach (Equipas equipa in Equipas)
        {
            Console.WriteLine($"Equipa: {equipa.Nome}: {equipa.OverGeral}");
        }
    }
}

