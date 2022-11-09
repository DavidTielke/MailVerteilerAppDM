using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace MailVerteilerApp
{
    public class MailPoller
    {
        private MailDistributor _mailDistributor;
        private MailDownloader _mailDownloader;

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
}