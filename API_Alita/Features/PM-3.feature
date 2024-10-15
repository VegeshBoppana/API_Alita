Feature: Test API GET Request for User Data with Pagination

  Scenario: Successful GET request with pagination
    Given I have the endpoint "/api/users?page=2"
    When I send a GET request to the endpoint
    Then I should receive a 200 status code
    And the response should contain user data with pagination