using QuickFix.Server.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickFix.Server
{
    class Program
    {
        static void Main(string[] args)
        {
            SessionSettings settings = new SessionSettings(@"C:\acceptor.cfg");
            Startup application = new Startup();

            FileStoreFactory storeFactory = new FileStoreFactory(settings);
            ScreenLogFactory logFactory = new ScreenLogFactory(settings);
            IMessageFactory messageFactory = new DefaultMessageFactory();
            ThreadedSocketAcceptor server = new ThreadedSocketAcceptor(application, storeFactory, settings, logFactory, messageFactory);

            server.Start();
            Console.WriteLine("####### Server Socket Fix Start ...press <enter> to quit");

            Console.Read();
            server.Stop();
        }
    }
}
