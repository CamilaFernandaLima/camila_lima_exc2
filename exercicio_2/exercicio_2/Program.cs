using System;
using System.Runtime.Versioning;

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
    public void Desligar()
    {
        Console.WriteLine("Luzes: Desligadas.");
    }
}


// 2. criação da fachada (Facade) 
public class HomeTheaterFacade
{
    //guarda referencias aos subsistemas:
    private TV tv;
    private Projetor projetor;
    private Receiver receiver;
    private PlayerMidia player;
    private SistemaSom som;
    private LuzAmbiente luz;

    public HomeTheaterFacade()
    {
        tv = new TV();
        projetor = new Projetor();
        receiver = new Receiver();
        player = new PlayerMidia();
        som = new SistemaSom();
        luz = new LuzAmbiente();
    }

    //operação AssistirFilme()
    public void AssistirFilme()
    {
        Console.WriteLine("Preparando ambiente para assistir filme.");
        luz.Escurecer();
        projetor.Ligar();
        receiver.Ligar();
        receiver.ModoSurround();
        som.Ligar();
        player.Ligar();
        player.Reproduzir();
    }

    //operação OuvirMusica()
    public void OuvirMusica()
    {
        Console.WriteLine("Preparando ambiente para ouvir música");
        luz.Ligar();
        tv.Ligar();
        receiver.Ligar();
        receiver.ModoStereo();
        player.Ligar();
        player.Reproduzir();
    }

    //desligamento
    public void DesligarTudo()
    {
        Console.WriteLine("Desligando todos os dispositivos.");
        luz.Desligar();
        tv.Desligar();
        projetor.Desligar();
        receiver.Desligar();
        som.Desligar();
        player.Desligar();
    }
} 