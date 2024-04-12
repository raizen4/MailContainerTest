### About the solution proposed (by the candidate)
- Please note that this code has been developed on a MAC machine using RIDER as IDE. Since it is NET6.0 it should work absolutely fine on both Windows and macOS.
- Please note I have begun coding for this test at 3:45PM . The email was received at 14:18PM but I was unable to work on the code challenge due to being in meetings until 3:45PM.
- I have added a few comments around the Models and Dtos classes, specifically around unused properties. Usually I am not a fan of having unused properties lying around but given I have no context of the grater system, I have left them in. Potentially, given a bit more context and time, I would have removed the unused ones.
- I have renamed most of the folders but there is still a few places (Constants folder and Services Folder) where the naming could be improved. Given more time, I would have definitely improved the naming.
- My testing framework of choice was XUnit, the DI container proposed was Microsoft.Extensions.DependencyInjection. I have written a few tests for the MailTransferService class and MailContainerDataStoreProvider class. Given more time, I would have definitely increased the coverage adding tests for edge cases and happy paths. Also, I would have used Theories and InlineData to streamline all use-cases of the code.
- The container provider that I created can be further improved. I have not realised, but I could have done a switch statement based on the type of data store.

### Mail Container Test 

The code for this exercise has been developed to manage the transfer of mail items from one container to another for processing.

#### Process for transferring mail

- Lookup the container the mail is being transferred from.
- Check the containers are in a valid state for the transfer to take place.
- Reduce the container capacity on the source container and increase the destination container capacity by the same amount.

#### Restrictions

- A container can only hold one type of mail.


#### Assumptions

- For the sake of simplicity, we can assume the containers have an unlimited capacity.

### The exercise brief

The exercise is to take the code in the solution and refactor it into a more suitable approach with the following things in mind:

- Testability
- Readability
- SOLID principles
- Architectural design of the code

You should not change the method signature of the MakeMailTransfer method.

You should add suitable tests into the MailContainerTest.Test project.

#### Note: you must not use Github Copilot, ChatGPT, Google Bard etc to generate code for this exercise.
#### Code committed should be working, with passing tests, and able to be compiled and run on another machine; make sure you have referenced all packages / included any instructions necessary for someone else to run your tests.

There are no additional constraints, use the packages and approach you feel appropriate. Aim to spend no more than 2 hours on this exercise, but when planning your time bear in mind that your code needs to run and your tests should pass.

When completed, either submit a pull request to this repository (if you have a Github account), or zip up the completed code and
send it back to the recruiter who assigned you the test. 

Please either comment the PR or update the readme with any specific comments on any areas that are unfinished, and what you would cover given more time.

