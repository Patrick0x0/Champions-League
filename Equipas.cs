using System;
using System.Collections.Generic;
public class Equipas
{
    public string Nome {get; set;}
    public string PaisOrigem {get; set;}
    public int OverGeral {get; set;}
    public int Pontos;

    public Equipas(string nome, string paisorigem, int overgeral)
    {
        Nome = nome;
        PaisOrigem = paisorigem;
        OverGeral = overgeral;
        Pontos = 0;
    }

}  