Feature: CustomerCanViewProductDetail
	In order to know more about a product
	As a customer
	I want to be able to view the detail of the product


Scenario: Customer can view product price
	Given I navigate to Amazon homepage
	And I search for Wrist Watch
	And I click on one of the search results displayed
	Then the product price is displayed