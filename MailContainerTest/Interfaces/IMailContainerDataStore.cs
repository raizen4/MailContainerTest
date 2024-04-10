using MailContainerTest.Models;

namespace MailContainerTest.Interfaces;

public interface IMailContainerDataStore
{
    public MailContainer GetMailContainer(string mailContainerNumber);
    public void UpdateMailContainer(MailContainer mailContainer);
}