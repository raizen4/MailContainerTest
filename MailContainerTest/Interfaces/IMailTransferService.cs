using MailContainerTest.Dtos;

namespace MailContainerTest.Interfaces
{
    public interface IMailTransferService
    {
        MakeMailTransferResult MakeMailTransfer(MakeMailTransferRequest request);
    }
}