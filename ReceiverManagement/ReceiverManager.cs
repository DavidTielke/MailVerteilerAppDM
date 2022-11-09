using DavidTielke.MailVerteilerApp.Data.DataStoring;

namespace DavidTielke.MailVerteilerApp.Logic.ReceiverManagement;

public class ReceiverManager : IReceiverManager
{
    private readonly IReceiverRepository _receiverRepository;

    public ReceiverManager(IReceiverRepository receiverRepository)
    {
        _receiverRepository = receiverRepository;
    }

    public void GetForPrefix()
    {
        Console.WriteLine("Empfänger (logisch) geladen");
        _receiverRepository.Load();
    }
}