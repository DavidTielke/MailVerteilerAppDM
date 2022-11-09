namespace DavidTielke.MailVerteilerApp.Logic.MailManagement;

public class MailPoller
{
    private readonly MailDistributor _mailDistributor;
    private readonly MailDownloader _mailDownloader;

    public MailPoller(MailDistributor mailDistributor)
    {
        _mailDistributor = mailDistributor;
        _mailDownloader = new MailDownloader();
    }

    public void Start()
    {
        Console.WriteLine("Polling gestartet");
        NewMailDetected();
    }

    private void NewMailDetected()
    {
        Console.WriteLine("Neue Mail erkannt");
        _mailDownloader.Download();
        _mailDistributor.Distribute();
    }

    public void Stop()
    {
        Console.WriteLine("Polling gestoppt");
    }
}