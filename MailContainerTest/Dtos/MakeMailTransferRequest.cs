using MailContainerTest.Enums;

namespace MailContainerTest.Dtos
{
    public class MakeMailTransferRequest
    {
        public string SourceMailContainerNumber { get; set; }
        
        /* Should we keep this if not used? Probably not. However,
        due to now knowing the greater context of the application, I will keep them. */
        public string DestinationMailContainerNumber { get; set; }
        public int NumberOfMailItems { get; set; }
        
        /* Should we keep this if not used? Probably not. However,
        due to now knowing the greater context of the application, I will keep them. */
        public DateTime TransferDate { get; set; }   
        public MailType MailType { get; set; }  
    }
}
