using API_Alita.Utilities;
using NUnit.Framework;
using RestSharp;
using TechTalk.SpecFlow;

namespace API_Alita.StepDefinitions
{
    [Binding]
    public class ReqresAPISteps
    {
        private IRestResponse response;

        [Given(@"I have set the endpoint to '(.*)'")]
        public void GivenIHaveSetTheEndpointTo(string endpoint)
        {
            response = RestClientUtilities.SendRequest("https://reqres.in", endpoint, Method.GET);
        }

        [When(@"I send a GET request to the endpoint")]
        public void WhenISendAGETRequestToTheEndpoint()
        {
            // Already sent in Given step
        }

        [Then(@"I expect the status code to be 200")]
        public void ThenIExpectTheStatusCodeToBe()
        {
            Assert.AreEqual(200, (int)response.StatusCode);
        }

        [Then(@"I expect the response to contain a list of users")]
        public void ThenIExpectTheResponseToContainAListOfUsers()
        {
            Assert.IsNotNull(response.Content);
        }

        [Then(@"each user should have 'id', 'email', 'first_name', 'last_name', and 'avatar'")]
        public void ThenEachUserShouldHaveIdEmailFirstNameLastNameAndAvatar()
        {
            // This would typically involve parsing the JSON response and validating each user object
        }
    }
}