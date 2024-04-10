using System.Configuration;
using MailContainerTest.Constants;
using MailContainerTest.Dtos;
using MailContainerTest.Enums;
using MailContainerTest.Interfaces;
using MailContainerTest.Models;

namespace MailContainerTest.Services
{
    public class MailTransferService : IMailTransferService
    {
        private readonly IMailContainerDataStoreProvider _dataStoreProvider;

        public MailTransferService(IMailContainerDataStoreProvider dataStoreProvider)
        {
            _dataStoreProvider = dataStoreProvider;
        }

        public MakeMailTransferResult MakeMailTransfer(MakeMailTransferRequest request)
        {
            var dataStoreType = ConfigurationManager.AppSettings[AppConfigurationConstants.DataStoreType];
            var result = new MakeMailTransferResult { Success = true };
            var dataStore = _dataStoreProvider.GetContainerDataStore(dataStoreType == DataStoreTypesConstants.BackupDataStore ? DataStoreTypesConstants.BackupDataStore : DataStoreTypesConstants.MainDataStore);
            MailContainer mailContainer = null;
            
            mailContainer = dataStore.GetMailContainer(request.SourceMailContainerNumber);

            if (mailContainer == null)
            {
                result.Success = false;
            }
            else
            {
                switch (request.MailType)
                {
                    case MailType.StandardLetter:
                        if (!mailContainer.AllowedMailType.HasFlag(AllowedMailType.StandardLetter))
                        {
                            result.Success = false;
                        }
                        break;
                    case MailType.LargeLetter:
                        if (!mailContainer.AllowedMailType.HasFlag(AllowedMailType.LargeLetter))
                        {
                            result.Success = false;
                        }
                        else if (mailContainer.Capacity < request.NumberOfMailItems)
                        {
                            result.Success = false;
                        }
                        break;
                    case MailType.SmallParcel:
                        if (!mailContainer.AllowedMailType.HasFlag(AllowedMailType.SmallParcel))
                        {
                            result.Success = false;

                        }
                        else if (mailContainer.Status != MailContainerStatus.Operational)
                        {
                            result.Success = false;
                        }
                        break;
                }
            }

            if (result.Success)
            {
                mailContainer.Capacity -= request.NumberOfMailItems;
                dataStore.UpdateMailContainer(mailContainer);
            }
            return result;
        }
    }
}