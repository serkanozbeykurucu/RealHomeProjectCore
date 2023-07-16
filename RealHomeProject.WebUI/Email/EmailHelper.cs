using System.Net.Mail;

namespace RealHomeProject.WebUI.Email
{
	public class EmailHelper
	{
		public bool SendEmail(string userEmail, string firstName, string subject, string content)
		{
			MailMessage mailMessage = new MailMessage();
			mailMessage.From = new MailAddress("kurucu741@yandex.com");
			mailMessage.To.Add(userEmail);

			mailMessage.Subject = firstName + " kişisinden " + subject + " Konulu Bir Mesajınız Var..!";
			mailMessage.IsBodyHtml = true;
			mailMessage.Body = content;

			SmtpClient client = new SmtpClient();
			client.Credentials = new System.Net.NetworkCredential("kurucu741@yandex.com", "yiwfpwmhimaufiyo");

			//wqrbmhiumkxjqkqv
			client.Host = "smtp.yandex.com";
			client.Port = 587;
			client.EnableSsl = true;
			try
			{
				client.Send(mailMessage);
				return true;
			}
			catch (Exception ex)
			{
				// log exception
			}
			return false;
		}
	}
}
