// See https://aka.ms/new-console-template for more information

public class Persona {
    public string nome { get; set;}
    public string cognome { get; set;}
    public virtual string Denominazione {
        return nome + " " + cognome;
    }
}
public class Utente : Persona {
    public int id { get; set;}
    public int annoIscrizione { get; set;}
    public override string Denominazione {
        return id + " " + nome + " " + cognome;
    }
}
Console.WriteLine("Hello, World!");

