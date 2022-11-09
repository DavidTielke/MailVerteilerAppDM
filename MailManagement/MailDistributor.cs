namespace MailVerteilerApp;

public class MailDistributor
{
    private readonly MailPoller _mailPoller;

    private readonly MailSender _mailSender;

    private readonly ReceiverManager _receiverManager;

    public MailDistributor()
    {
        _receiverManager = new ReceiverManager();
        _mailPoller = new MailPoller(this);
        _mailSender = new MailSender(this);
    }

    public void Start()
    {
        Console.WriteLine("Mailvertieler gestartet");
        _mailPoller.Start();
    }

    public void Stop()
    {
        Console.WriteLine("Mailverteilung gestoppt");
        _mailPoller.Stop();
    }

    public void Distribute()
    {
        Console.WriteLine("Verteilung gestartet");
        _receiverManager.GetForPrefix();
        _mailSender.Send();
    }

    public void DistributionCompleted()
    {
        Console.WriteLine("Verteilung abgeschlossen");
    }
}