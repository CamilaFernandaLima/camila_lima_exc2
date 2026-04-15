using System;

// 1. criação dos objetos do sistema home theater
public class TV
{
    public void Ligar()
    {
        Console.WriteLine("TV: Ligada.");
    }
    public void Desligar()
    {
        Console.WriteLine("TV: Desligada.");
    }
}
public class Projetor
{
    public void Ligar()
    {
        Console.WriteLine("Projetor: Ligado.");
    }
    public void Desligar()
    {
        Console.WriteLine("Projetor: Desligado.");
    }
}
public class Receiver
{
    public void Ligar()
    {
        Console.WriteLine("Receiver: Ligado.");
    }
    public void Desligar()
    {
        Console.WriteLine("Receiver: Desligado.");
    }
    public void ModoSurround()
    {
        Console.WriteLine("Receiver: Configurado para Áudio Surround.");
    }
    public void ModoStereo()
    {
        Console.WriteLine("Receiver: Configurado para Áudio Stereo.");
    }
}
public class PlayerMidia
{
    public void Ligar()
    {
        Console.WriteLine("Player de Mídia: Ligado.");
    }
    public void Desligar()
    {
        Console.WriteLine("Player de Mídia: Desligado.");
    }   
    public void Reproduzir()
    {
        Console.WriteLine("Player de Mídia: Reproduzindo conteúdo.");
    }
}
public class SistemaSom
{
    public void Ligar()
    {
        Console.WriteLine("Sistema de Som: Ligado.");
    }
    public void Desligar()
    {
        Console.WriteLine("Sistema de Som: Desligado.");
    }
}
public class LuzAmbiente
{
    public void Escurecer()
    {
        Console.WriteLine("Luzes: Escurecidas para modo cinema.");
    }
    public void Ligar()
    {
        Console.WriteLine("Luzes: Acessas em intensidade normal.");
    }
}