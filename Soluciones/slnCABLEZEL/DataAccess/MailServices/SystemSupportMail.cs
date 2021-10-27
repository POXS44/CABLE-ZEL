using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.MailServices
{
    class SystemSupportMail:MasterMailServer
    {
        public SystemSupportMail()
        {
            senderMail = "vzeledon44@gmail.com";
            password = "manuel2000A";
            host = "smtp.gmail.com";
            port = 587;
            ssl = true;
            initializeSmtpClient();
        }
    }
}
