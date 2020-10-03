using System.Threading.Tasks;

namespace JomKuliah.Application.Core.Interfaces
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string to, string from, string subject, string body);
    }
}
