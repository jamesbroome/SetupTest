using System;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace Endjin.BigBang.Specs
{
    [Binding]
    public class BigBangSteps
    {
        [Given(@"I have created a new project")]
        public void GivenIHaveCreatedANewProject()
        {
            
        }
        
        [Given(@"I have created a new build definition")]
        public void GivenIHaveCreatedANewBuildDefinition()
        {

        }
        
        [When(@"I run the build")]
        public void WhenIRunTheBuild()
        {

        }
        
        [Then(@"the everything should work first time")]
        public void ThenTheEverythingShouldWorkFirstTime()
        {
            Assert.IsTrue(true);
        }
    }
}
