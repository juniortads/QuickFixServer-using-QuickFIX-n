using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickFix.Server.Hosting
{
    public class Startup : MessageCracker, IApplication
    {
        public void FromAdmin(Message message, SessionID sessionID)
        {
            throw new NotImplementedException();
        }

        public void FromApp(Message message, SessionID sessionID)
        {
            throw new NotImplementedException();
        }

        public void OnCreate(SessionID sessionID)
        {
            throw new NotImplementedException();
        }

        public void OnLogon(SessionID sessionID)
        {
            throw new NotImplementedException();
        }

        public void OnLogout(SessionID sessionID)
        {
            throw new NotImplementedException();
        }

        public void ToAdmin(Message message, SessionID sessionID)
        {
            throw new NotImplementedException();
        }

        public void ToApp(Message message, SessionID sessionId)
        {
            throw new NotImplementedException();
        }
    }
}
