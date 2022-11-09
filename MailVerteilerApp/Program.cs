using DavidTielke.MailVerteilerApp.Data.DataStoring;
using DavidTielke.MailVerteilerApp.Logic.MailManagement;
using DavidTielke.MailVerteilerApp.Logic.ReceiverManagement;

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
        var downloader = new MailDownloader();
        var poller = new MailPoller(null, downloader);
        var sender = new MailSender(null);
        var repository = new ReceiverRepository();
        var manager = new ReceiverManager(repository);

        var verteiler = new MailDistributor(poller, sender, manager);
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