using MailContainerTest.Stores;

namespace MailContainerTest.Tests.Providers;

using Xunit;
using Moq;
using MailContainerTest.Providers;
using Constants;

public class MailContainerDataStoreProviderTests
{
    [Fact]
    public void GetContainerDataStore_WhenDataStoreTypeIsBackup_ReturnsBackupDataStore()
    {
        // Arrange
        var serviceProviderMock = new Mock<IServiceProvider>();
        var provider = new MailContainerDataStoreProvider(serviceProviderMock.Object);

        serviceProviderMock.Setup(x => x.GetService(typeof(BackupMailContainerDataStore))).Returns(new BackupMailContainerDataStore());

        // Act
        var result = provider.GetContainerDataStore(DataStoreTypesConstants.BackupDataStore);

        // Assert
        Assert.IsType<BackupMailContainerDataStore>(result);
    }

    [Fact]
    public void GetContainerDataStore_WhenDataStoreTypeIsMain_ReturnsMainDataStore()
    {
        // Arrange
        var serviceProviderMock = new Mock<IServiceProvider>();
        var provider = new MailContainerDataStoreProvider(serviceProviderMock.Object);

        serviceProviderMock.Setup(x => x.GetService(typeof(MailContainerDataStore))).Returns(new MailContainerDataStore());

        // Act
        var result = provider.GetContainerDataStore(DataStoreTypesConstants.MainDataStore);

        // Assert
        Assert.IsType<MailContainerDataStore>(result);
    }
}