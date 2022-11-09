namespace DavidTielke.MailVerteilerApp.Data.DataStoring;

public class ReceiverRepository : IReceiverRepository
{
    public void Load()
    {
        Console.WriteLine("Empfänger aus Datenbank geladen");
    }
}