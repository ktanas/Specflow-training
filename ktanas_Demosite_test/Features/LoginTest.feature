Feature: LoginTest
	Test login procedure on demosite.executeautomation.com

@LoginTest
Scenario: Login as a sample user
	Given Enter user credentials
    | UserName | Password |
    | kowalska | 777e!$s |
    Then PressLoginButton
    Then FillOutUserForm
    | Title | Initial | First Name | Middle Name | Gender |
    | Ms.   | K       | Anna       | Kowalska    | Female |
