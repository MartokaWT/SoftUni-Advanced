using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailClient
{
	public class MailBox
	{
		private int capacity;
		private List<Mail> inbox;
		private List<Mail> archive;

		public int Capacity
		{
			get { return capacity; }
		}

		public MailBox(int capacity)
		{
			this.capacity = capacity;
			inbox = new List<Mail>();
			archive = new List<Mail>();
		}

		public void IncomingMail(Mail mail)
		{
			if (inbox.Count < Capacity)
			{
				inbox.Add(mail);
			}
		}

		public bool DeleteMail(string sender)
		{
			Mail mailToDelete = inbox.FirstOrDefault(mail => mail.Sender == sender);
			if (mailToDelete != null)
			{
				inbox.Remove(mailToDelete);
				return true;
			}
			return false;
		}

		public int ArchiveInboxMessages()
		{
			int count = inbox.Count;
			archive.AddRange(inbox);
			inbox.Clear();
			return count;
		}

		public string GetLongestMessage()
		{
			Mail longestMail = inbox.OrderByDescending(mail => mail.Body.Length)
				.FirstOrDefault() ?? archive
				.OrderByDescending(mail => mail.Body.Length)
				.FirstOrDefault();
			return longestMail.ToString();
		}

		public string InboxView()
		{
			StringBuilder inboxView = new StringBuilder("Inbox:");
			foreach (Mail mail in inbox)
			{
				inboxView.Append($"\n{mail}");
			}
			return inboxView.ToString();
		}
	}
}