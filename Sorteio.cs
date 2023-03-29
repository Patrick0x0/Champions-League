using System;
using System.Collections.Generic;
public class Sorteio
{
    public List<Equipas> equipas;

    public Sorteio(List<Equipas> equipas)
    {
        this.equipas = equipas;
    }

     public List<Grupo> SortearGrupos()
{
    List<Grupo> grupos = new List<Grupo>();
    for (char nomeGrupo = 'A'; nomeGrupo <= 'H'; nomeGrupo++)
    {
        grupos.Add(new Grupo(nomeGrupo.ToString(), new List<Equipas>()));
    }

    Random random = new Random();
    Dictionary<string, List<Equipas>> equipasPorNacionalidade = new Dictionary<string, List<Equipas>>();
    foreach (Equipas equipe in equipas)
    {
        if (!equipasPorNacionalidade.ContainsKey(equipe.PaisOrigem))
        {
            equipasPorNacionalidade[equipe.PaisOrigem] = new List<Equipas>();
        }
        equipasPorNacionalidade[equipe.PaisOrigem].Add(equipe);
    }

    List<Equipas> equipesRestantes = new List<Equipas>(equipas);

    foreach (var grupo in grupos)
    {
        for (int i = 0; i < 4; i++)
        {
            List<Equipas> candidatos = new List<Equipas>(equipesRestantes);
            candidatos.RemoveAll(e => grupo.Equipas.Exists(e2 => e2.PaisOrigem == e.PaisOrigem));

            if (candidatos.Count == 0)  // se não há candidatos, escolhe um aleatoriamente
            {
                int indiceAleatorio = random.Next(equipesRestantes.Count);
                Equipas equipeSelecionada = equipesRestantes[indiceAleatorio];
                grupo.Equipas.Add(equipeSelecionada);
                equipesRestantes.RemoveAt(indiceAleatorio);
            }
            else  // caso contrário, escolhe um candidato aleatoriamente
            {
                int indiceAleatorio = random.Next(candidatos.Count);
                Equipas equipeSelecionada = candidatos[indiceAleatorio];
                grupo.Equipas.Add(equipeSelecionada);
                equipesRestantes.Remove(equipeSelecionada);
            }
        }
    }
    return grupos;
}


public Eliminatorias SortearEliminatorias(List<Equipas> vencedores)
{
    List<Jogos> jogos = new List<Jogos>();
    for(int i = 0; i < vencedores.Count; i+=2)
    {
        Jogos jogo = new Jogos(vencedores[i], vencedores[i+1]);
        jogos.Add(jogo);
    }

        Eliminatorias eliminatorias = new Eliminatorias(jogos);
        return eliminatorias;

    }
}