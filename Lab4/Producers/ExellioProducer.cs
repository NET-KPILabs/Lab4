namespace Lab4.Producers;

public class ExellioProducer: IProducer
{
    public string GetContacts()
    {
        return "Email: info@exellio.com.ua\n" +
               "Phone number: (098) 443 15 80";
    }
    
    public override string ToString()
    {
        return "It was made by Exellio";
    }
}