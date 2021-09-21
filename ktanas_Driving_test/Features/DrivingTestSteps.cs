using System;
using TechTalk.SpecFlow;

namespace ktanas_DrivingTest.Features
{
    [Binding]
    public class DrivingTestSteps
    {
        private readonly ScenarioContext _scenarioContext;
        private readonly DrivingRegulations drivingRegulations;

        public DrivingTestSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            drivingRegulations = new DrivingRegulations();
        }

        [Given(@"Driver is (.*) years old")]
        public void GivenDriverIsYearsOld(int chosenAge)
        {
            _scenarioContext["Person"] = new Person { FirstName = "Xxx",
                                                      LastName = "Yyy",
                                                      Age = chosenAge };
        }
        
        [Given(@"Driver lives in (.*)")]
        public void GivenDriverLivesInCountry(string countryName)
        {
            var person = (Person)_scenarioContext["Person"];
            _scenarioContext["Result"] = drivingRegulations.IsAllowedToDrive(person, countryName);
        }
                
        [Then(@"Driver can drive")]
        public void ThenDriverCanDrive()
        {
            var result = (bool)_scenarioContext["Result"];
            NUnit.Framework.Assert.IsTrue(result);
        }
        
        [Then(@"Driver cannot drive")]
        public void ThenDriverCannotDrive()
        {
            var result = (bool)_scenarioContext["Result"];
            NUnit.Framework.Assert.IsFalse(result);
        }
    }
}
