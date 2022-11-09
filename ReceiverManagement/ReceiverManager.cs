using DavidTielke.MailVerteilerApp.Data.DataStoring;

namespace DavidTielke.MailVerteilerApp.Logic.ReceiverManagement;

public class ReceiverManager
{
    private readonly ReceiverRepository _receiverRepository;

    public ReceiverManager()
    {
        _receiverRepository = new ReceiverRepository();
    }

    public void GetForPrefix()
    {
        Console.WriteLine("Empfänger (logisch) geladen");
        _receiverRepository.Load();
    }
}