using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MailVerteilerApp
{
    public class MailSender
    {
        private MailDistributor _mailDistributor;

        public MailSender(MailDistributor mailDistributor)
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
}