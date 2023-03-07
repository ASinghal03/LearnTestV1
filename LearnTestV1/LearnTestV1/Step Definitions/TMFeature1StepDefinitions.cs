using System;
using TechTalk.SpecFlow;

namespace LearnTestV1
{
    [Binding]
    public class TMFeature1StepDefinitions
    {
        [Given(@"I logged into portal successfully")]
        public void GivenILoggedIntoPortalSuccessfully()
        {
            throw new PendingStepException();
        }

        [When(@"I navigate to TM page")]
        public void WhenINavigateToTMPage()
        {
            throw new PendingStepException();
        }

        [When(@"I create a new record")]
        public void WhenICreateANewRecord()
        {
            throw new PendingStepException();
        }

        [Then(@"The record is created successfully")]
        public void ThenTheRecordIsCreatedSuccessfully()
        {
            throw new PendingStepException();
        }
    }
}
