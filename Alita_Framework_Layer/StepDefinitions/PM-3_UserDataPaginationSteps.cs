using TechTalk.SpecFlow;
using RestSharp;

[Binding]
public class UserDataPaginationSteps
{
    private readonly string baseUrl = "https://reqres.in";
    private IRestResponse response;

    [Given(@"I have the endpoint /api/users\?page=2")]
    public void GivenIHaveTheEndpoint()
    {
        // Endpoint is set
    }

    [When(@"I send a GET request to the endpoint")]
    public void WhenISendAGETRequestToTheEndpoint()
    {
        response = RestSharpMethods.SendRequest(baseUrl, "/api/users?page=2", Method.GET);
    }

    [Then(@"I should receive a 200 status code")]
    public void ThenIShouldReceiveAStatusCode()
    {
        Assert.AreEqual(200, (int)response.StatusCode);
    }

    [Then(@"the response should contain user data for page 2")]
    public void ThenTheResponseShouldContainUserDataForPage2()
    {
        // Additional assertions can be added here to verify the content of the response
    }
}