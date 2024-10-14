Feature: Test API GET Request for User Data with Pagination

  As a tester
  I want to verify that the GET request to /api/users?page=2 returns the correct data
  So that I can confirm the server handles pagination correctly

  Scenario: Verify GET request for user data with pagination
    Given I have the endpoint /api/users?page=2
    When I send a GET request to the endpoint
    Then I should receive a 200 status code
    And the response should contain user data for page 2