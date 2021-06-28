using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace DemoSentEmail
{
    public class Email
    {

        private string _from = ConfigurationManager.AppSettings["Username"];
        private string _pass = ConfigurationManager.AppSettings["Password"];
        private string _server = ConfigurationManager.AppSettings["ServerClient"];

        public void Send(string sendto, string cc, string bcc, string subject, string content)
        {
            //sendto: Email receiver (người nhận)
            //subject: Tiêu đề email
            //content: Nội dung của email, bạn có thể viết mã HTML
            //Nếu gửi email thành công, sẽ trả về kết quả: OK, không thành công sẽ trả về thông tin l�-i
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient(_server);

                mail.From = new MailAddress(_from);
                mail.To.Add(sendto);
                if (cc != "" && cc != null)
                {
                    mail.CC.Add(cc);
                }
                if (bcc != "" && bcc != null)
                {
                    mail.Bcc.Add(bcc);
                }

                mail.Subject = subject;
                mail.IsBodyHtml = true;
                mail.Body = content;

                mail.Priority = MailPriority.High;

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential(_from, _pass);
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);

            }
            catch (Exception ex)
            {

            }
        }
    }
}
