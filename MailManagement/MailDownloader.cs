namespace DavidTielke.MailVerteilerApp.Logic.MailManagement;

public class MailDownloader : IMailDownloader
{
    public void Download()
    {
        Console.WriteLine("Email wurde heruntergeladen");
    }
}