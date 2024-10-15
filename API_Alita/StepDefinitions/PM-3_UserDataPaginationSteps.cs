using API_Alita.Utilities;
using NUnit.Framework;
using TechTalk.SpecFlow;

[Binding]
public class PM3_UserDataPaginationSteps
{
    private string baseUrl = "https://reqres.in";
    private string endpoint = "/api/users?page=2";
    private IRestResponse response;

    [Given("I have the endpoint \\"(.*)\\"")]
    public void GivenIHaveTheEndpoint(string endpoint)
    {
        this.endpoint = endpoint;
    }

    [When("I send a GET request to the endpoint")]
    public void WhenISendAGETRequestToTheEndpoint()
    {
        response = RestClientMethods.SendGetRequest(baseUrl, endpoint);
    }

    [Then("I should receive a 200 status code")]
    public void ThenIShouldReceiveA200StatusCode()
    {
        Assert.AreEqual(200, (int)response.StatusCode);
    }

    [Then("the response should contain user data with pagination")]
    public void ThenTheResponseShouldContainUserDataWithPagination()
    {
        Assert.IsNotNull(response.Content);
        Assert.IsTrue(response.Content.Contains("page"));
    }
}