using DavidTielke.MailVerteilerApp.Logic.MailManagement;

namespace DavidTielke.MailVerteilerApp.UI.ConsoleClient;

// Namesmuster
// # *Klassen
// + *Repository
// + *Manager
// + *Poller
// + *Sender
// + *Distributor
// # Komponenten
// + DataStoring
// + DataClasses
// + *Management
// + *Client
public class Program
{
    public static void Main()
    {
        var verteiler = new MailDistributor();
        verteiler.Start();


        #region Alt

        //Console.WriteLine("Mailverteiler gestartet");
        //Console.WriteLine("Polling wurde gestartet");
        //Console.WriteLine("Neue Email wurde erkannt");
        //Console.WriteLine("Email wurde heruntergeladen");
        //Console.WriteLine("Verteilung wird gestartet");
        //Console.WriteLine("Empfänger ermittelt");
        //Console.WriteLine("Email wird an Adressat XYZ versendet");
        //Console.WriteLine("Email wird an Adressat ABC versendet");
        //Console.WriteLine("Polling wurde gestoppt");
        //Console.WriteLine("Mailverteiler wurde gestoppt"); 

        #endregion
    }
}