﻿using MailContainerTest.Interfaces;
using MailContainerTest.Models;

namespace MailContainerTest.Stores
{
    public class BackupMailContainerDataStore : IMailContainerDataStore
    {
        public MailContainer GetMailContainer(string mailContainerNumber)
        {
            // Access the database and return the retrieved mail container. Implementation not required for this exercise.
            return new MailContainer();
        }

        public void UpdateMailContainer(MailContainer mailContainer)
        {
            // Update mail container in the database. Implementation not required for this exercise.
        }
    }
}
