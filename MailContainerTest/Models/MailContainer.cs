using MailContainerTest.Enums;

namespace MailContainerTest.Models
{
    public class MailContainer
    {
        /* Should we keep this if not used? Probably not. However,
        due to now knowing the greater context of the application, I will keep them. */
        public string MailContainerNumber { get; set; } 
        public int Capacity { get; set; }   
        public MailContainerStatus Status { get; set; }
        public AllowedMailType AllowedMailType { get; set; }

    }
}
