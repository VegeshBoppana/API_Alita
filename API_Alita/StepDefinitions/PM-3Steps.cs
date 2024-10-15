using API_Alita.Utilities;
using NUnit.Framework;
using RestSharp;
using TechTalk.SpecFlow;

namespace API_Alita.StepDefinitions
{
    [Binding]
    public class PM3Steps
    {
        private string _baseUrl = "https://reqres.in";
        private string _resource;
        private IRestResponse _response;

        [Given("I have the endpoint (.*)")]
        public void GivenIHaveTheEndpoint(string endpoint)
        {
            _resource = endpoint;
        }

        [When("I send a GET request to the endpoint")]
        public void WhenISendAGetRequestToTheEndpoint()
        {
            _response = RestClientUtilities.SendRequest(_baseUrl, _resource, Method.GET);
        }

        [Then("I should receive a 200 status code")]
        public void ThenIShouldReceiveA200StatusCode()
        {
            Assert.AreEqual(200, (int)_response.StatusCode);
        }

        [Then("the response should contain user data with pagination")]
        public void ThenTheResponseShouldContainUserDataWithPagination()
        {
            Assert.IsTrue(_response.Content.Contains("page"));
        }
    }
}