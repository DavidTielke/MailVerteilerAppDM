namespace DavidTielke.MailVerteilerApp.Logic.MailManagement;

public class MailSender : IMailSender
{
    private readonly MailDistributor _mailDistributor;

    public MailSender(IMailDistributor mailDistributor)
    {
        _mailDistributor = mailDistributor;
    }

    public void Send()
    {
        Console.WriteLine("Versende Email an XYZ");
        Console.WriteLine("Versende Email an ABC");
        _mailDistributor.DistributionCompleted();
    }
}