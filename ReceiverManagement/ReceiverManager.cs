using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MailVerteilerApp
{
    public class ReceiverManager
    {
        private ReceiverRepository _receiverRepository;

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
}