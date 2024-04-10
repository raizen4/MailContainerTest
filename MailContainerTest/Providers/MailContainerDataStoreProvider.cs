using MailContainerTest.Constants;
using MailContainerTest.Interfaces;
using MailContainerTest.Stores;
using Microsoft.Extensions.DependencyInjection;
namespace MailContainerTest.Providers;

public class MailContainerDataStoreProvider : IMailContainerDataStoreProvider
{
    private readonly IServiceProvider _serviceProvider;

    public MailContainerDataStoreProvider(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public IMailContainerDataStore GetContainerDataStore(string dataStoreType)
    {
        if (dataStoreType == DataStoreTypesConstants.BackupDataStore)
            return (IMailContainerDataStore)_serviceProvider.GetRequiredService(typeof(BackupMailContainerDataStore));
        
        return (IMailContainerDataStore)_serviceProvider.GetRequiredService(typeof(MailContainerDataStore));
    }
}