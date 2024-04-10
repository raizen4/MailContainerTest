namespace MailContainerTest.Interfaces;

public interface IMailContainerDataStoreProvider
{
    public IMailContainerDataStore GetContainerDataStore(string dataStoreType);
}