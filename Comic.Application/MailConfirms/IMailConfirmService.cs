using Comic.ViewModels.MailConfirms;
using Comic.ViewModels.Users;

namespace Comic.Application.MailConfirms
{
    public interface IMailConfirmService
    {
        Task<string> SendMail(MailConfirmViewModel mailConfirmViewModel);

        string GetMailBody(UserViewModel userViewModel);
    }
}
