using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechTalk.SpecFlow;

namespace TLDR.ClassLibraryTemplate.UnitTests.Steps
{
    [Binding]
    public class HelloWorldSteps
    {
        private string _name;
        private HelloWorld _testObject;
        private string _result;
        private Exception _exception;

        [Given(@"I have a hello world class")]
        public void GivenIHaveAHelloWorldClass()
        {
            _testObject = new HelloWorld();
        }
        
        [Given(@"I have a inputName of '(.*)'")]
        public void GivenIHaveAInputNameOf(string name)
        {
            _name = name;
        }


        [When(@"I call the Greeting method and pass in the name")]
        public void WhenICallTheGreetingMethodAndPassInTheName()
        {
            try
            {
                _result = _testObject.Greeting(_name);
            }
            catch(Exception ex)
            {
                _exception = ex;
            }
        }
      

        [When(@"I call the WhoDis method")]
        public void WhenICallTheWhoDisMethod()
        {
            _result = _testObject.WhoDis();
        }

     
        [Then(@"the result should contain be '(.*)'")]
        public void ThenTheResultShouldContainBe(string expected)
        {
            Assert.AreEqual(expected, _result);
        }

        [Then(@"the result should be an exception with the typoe of ""(.*)""")]
        public void ThenTheResultShouldBeAnExceptionWithTheTypoeOf(string expectedException)
        {
            Assert.AreEqual(expectedException, _exception.GetType().Name);
        }

        [Then(@"the result should a random string")]
        public void ThenTheResultShouldARandomString()
        {
            Assert.IsNotNull(_result);
        }

    }
}
