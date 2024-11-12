Feature: Validate GET Request for User List on Page 2

  As a tester using the Reqres API
  I want to send a GET request to retrieve a paginated list of users on page 2
  So that I can verify the response and ensure it meets the expected criteria

  Scenario: GET User List on Page 2
    Given I have set the endpoint to '/api/users?page=2'
    When I send a GET request to the endpoint
    Then I expect the status code to be 200
    And I expect the response to contain a list of users
    And each user should have 'id', 'email', 'first_name', 'last_name', and 'avatar'