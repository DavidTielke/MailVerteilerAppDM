namespace DavidTielke.MailVerteilerApp.Logic.MailManagement;

public interface IMailPoller
{
    void Start();
    void Stop();
}