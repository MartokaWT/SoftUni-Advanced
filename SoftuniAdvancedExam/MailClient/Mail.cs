using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailClient
{
	public class Mail
	{
		public Mail(string sender,
			string receiver,
			string body)
		{
			Sender = sender;
			Receiver = receiver;
			Body = body;
		}


		public string Sender { get; set; }
		public string Receiver { get; set; }
		public string Body { get; set; }

		public override string ToString()
		{
			return $"From: {Sender} / To: {Receiver}\nMessage: {Body}";
		}
	}
}