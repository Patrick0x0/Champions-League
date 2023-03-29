using System;
using System.Collections.Generic;
public class Jogos
{
    public Equipas equipaCasa { get; set;}
    public Equipas equipaFora { get; set;} 

    public Jogos(Equipas a, Equipas b)
    {
        this.equipaCasa = a;
        this.equipaFora = b;
    }
    public Equipas SimularPartida()
    {
        double fatorVantagemCasa = equipaCasa.OverGeral / (equipaCasa.OverGeral + equipaFora.OverGeral);
        double fatorVantagemFora = equipaFora.OverGeral / (equipaCasa.OverGeral + equipaFora.OverGeral);

        // Determine the probability of winning for each team
        double probabilidadeCasa = fatorVantagemCasa * 0.6 + (1 - fatorVantagemCasa) * 0.4;
        double probabilidadeFora = fatorVantagemFora * 0.3 + (1 - fatorVantagemFora) * 0.4;

        // Generate a random number between 0 and 1 to determine the outcome of the match
        Random random = new Random();
        double resultado = random.NextDouble();

        // Determine the winner of the match based on the probabilities and the random result
        Equipas vencedor;
        if (resultado < probabilidadeCasa)
        {
            vencedor = equipaCasa;
        }
        else if (resultado < probabilidadeCasa + probabilidadeFora)
        {
            vencedor = equipaFora;
        }
        else
        {
            vencedor = null; // match ends in a draw
        }

        // Print the result of the match
        if (vencedor == null)
        {
            Console.WriteLine();
            Console.WriteLine($"{equipaCasa.Nome} vs {equipaFora.Nome} terminou empatado!");
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine($"{equipaCasa.Nome} {(vencedor == equipaCasa ? "venceu" : "perdeu")} {equipaFora.Nome} ");
        }

        return vencedor;
    }
}
