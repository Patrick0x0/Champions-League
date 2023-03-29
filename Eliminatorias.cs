using System;
using System.Collections.Generic;
public class Eliminatorias
{
    public List<Equipas> vencedores;
    public List<Jogos> jogos;

    public Eliminatorias (List<Jogos> jogos){
        this.jogos = jogos;
        this.vencedores = new List<Equipas>();
    }
    public List<Equipas> JogarEliminatorias()
    {
         foreach (Jogos jogo in jogos)
        {
            Equipas vencedor = jogo.SimularPartida();
            if (vencedor != null)
            {
                vencedores.Add(vencedor);
            }
            if (vencedor == null)
                vencedores.Add(jogo.equipaCasa.OverGeral > jogo.equipaFora.OverGeral ? jogo.equipaCasa : jogo.equipaFora);
        }
        return vencedores;
    }
}


               
