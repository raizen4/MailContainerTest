using MailContainerTest.Dtos;
using MailContainerTest.Enums;
using MailContainerTest.Interfaces;
using MailContainerTest.Models;
using MailContainerTest.Services;
using Moq;
using Xunit;

namespace MailContainerTest.Tests.Services;

public class MailTransferServiceTests
{
    [Fact]
    public void MakeMailTransfer_WhenMailContainerIsNull_ReturnsUnsuccessfulResult()
    {
        // Arrange
        var dataStoreProviderMock = new Mock<IMailContainerDataStoreProvider>();
        var dataStoreMock = new Mock<IMailContainerDataStore>();
        
        var service = new MailTransferService(dataStoreProviderMock.Object);

        dataStoreProviderMock.Setup(x => x.GetContainerDataStore(It.IsAny<string>())).Returns(dataStoreMock.Object);
        dataStoreMock.Setup(x => x.GetMailContainer(It.IsAny<string>())).Returns((MailContainer)null);

        var request = new MakeMailTransferRequest { SourceMailContainerNumber = "123" };

        // Act
        var result = service.MakeMailTransfer(request);

        // Assert
        Assert.False(result.Success);
    }

    [Fact]
    public void MakeMailTransfer_WhenMailTypeIsNotAllowed_ReturnsUnsuccessfulResult()
    {
        // Arrange
        var dataStoreProviderMock = new Mock<IMailContainerDataStoreProvider>();
        var dataStoreMock = new Mock<IMailContainerDataStore>();
        var service = new MailTransferService(dataStoreProviderMock.Object);

        var mailContainer = new MailContainer { AllowedMailType = AllowedMailType.StandardLetter };
        dataStoreProviderMock.Setup(x => x.GetContainerDataStore(It.IsAny<string>())).Returns(dataStoreMock.Object);
        dataStoreMock.Setup(x => x.GetMailContainer(It.IsAny<string>())).Returns(mailContainer);

        var request = new MakeMailTransferRequest { SourceMailContainerNumber = "123", MailType = MailType.LargeLetter };

        // Act
        var result = service.MakeMailTransfer(request);

        // Assert
        Assert.False(result.Success);
    }
}