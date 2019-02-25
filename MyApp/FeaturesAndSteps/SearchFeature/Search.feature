@smoke
Feature: Search
	In order to use Flickr Gallery 
	As a User
	I want to be able to search for images
	
Background:
    Given Flickr page is opened  

Scenario: Search field is present on the page
    Then The search field is present
    
Scenario: Search for images with one tag
    When Search for images with one tag
    Then The first image contains the search tag     
    
Scenario: Check Alert Message after search for nonexisting image tag
    When Search for images with nonexisting image tag
    Then Error message shows     
        
