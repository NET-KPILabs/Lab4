namespace Lab4.Producers;

public class SmartKasaProducer : IProducer
{
    public string GetContacts()
    {
        return "Email: sale@smartkasa.ua";
    }
    
    public override string ToString()
    {
        return "It was made by SmartKasa";
    }
}