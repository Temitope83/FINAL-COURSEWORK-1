Feature: HomepageProductInfor
	As a registered user of the site
	i would like to login
	so that i can view products on my homepage

@mytag
Scenario: Homepage Product Information
	Given I navigate to giftrete website
	When I click on login 
	And  I enter my email address
	And  I enter my password
	And  I click sign in
	And  I click hometab
	And  I click free items
	And  I click wishlist
	And  I click community
	#Then I have information about the products
