# assessment
Note: I was having issues with appium that is why I have configured the tests for iOS and Android to run against browser mobile simulation.

Functional Test cases:

Search field is present on the page
Search for existing image tag
Search for nonexisting image tag

//TODO 
Order images by Published
Order images by Date taken
Clear search and check if the results are back 
Search for more than one tag
Download should open the image in a new tab


Unit Tests:

Alert Tests:

1. renders children - this test is to check if the children of the alert are rendered. It finds the div alert element and checks the text of the element to be as the text given to the “children” const
2. sets proper className - checks if the alert has class - "alert-warning”

Loading Tests:

1. renders a div with loading text - finds the Loading element and checks its text to be “Loading …”

GalleryList Tests:

1. renders two GalleryListItems - checks the gallery list items to contain two items  by checking the length of the “items” array of objects 

App Tests:

1. renders without crashing - checks if the app renders without crashing  

Alert Reducers: The tests check the different alert states - success, alert/danger and clear


