using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerCommLib
{
    public class CustomerCom
    {
        IMailSender _mailSender;
        public CustomerCom(IMailSender mailSender)
        {
            _mailSender = mailSender;
        }
        public bool SendMailToCustomer(string email,string message)
        {
            //Actual logic goes here
            //define message and mail address
            return _mailSender.SendMail(email,message);
            
        }
    }
}
