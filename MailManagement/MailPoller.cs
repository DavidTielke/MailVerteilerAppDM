namespace DavidTielke.MailVerteilerApp.Logic.MailManagement;

public class MailPoller : IMailPoller
{
    private readonly IMailDistributor _mailDistributor;
    private readonly IMailDownloader _mailDownloader;

    public MailPoller(IMailDistributor mailDistributor, IMailDownloader mailDownloader)
    {
        _mailDistributor = mailDistributor;
        _mailDownloader = mailDownloader;
    }

    public void Start()
    {
        Console.WriteLine("Polling gestartet");
        NewMailDetected();
    }

    public void Stop()
    {
        Console.WriteLine("Polling gestoppt");
    }

    private void NewMailDetected()
    {
        Console.WriteLine("Neue Mail erkannt");
        _mailDownloader.Download();
        _mailDistributor.Distribute();
    }
}