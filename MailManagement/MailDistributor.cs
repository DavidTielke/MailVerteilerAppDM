using DavidTielke.MailVerteilerApp.Logic.ReceiverManagement;

namespace DavidTielke.MailVerteilerApp.Logic.MailManagement;

public class MailDistributor
{
    private readonly IMailPoller _mailPoller;

    private readonly IMailSender _mailSender;

    private readonly IReceiverManager _receiverManager;

    public MailDistributor(IMailPoller mailPoller, IMailSender mailSender, IReceiverManager receiverManager)
    {
        _mailPoller = mailPoller;
        _mailSender = mailSender;
        _receiverManager = receiverManager;
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