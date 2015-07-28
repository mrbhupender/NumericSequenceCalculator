# Numeric Sequence Calculator Web Application

This is a web based application to calculate some numeric sequences

## About Project

This application consists of following Projects:<br />
1. SequenceCalculatorWebApp: `A MVC application consisting of single home page having one Input text box to enter the numeric value against which user want to generate all required sequences.`<br />
2. SequenceCalculatorWebApp.Tests: `It includes all test scenarios covering each functional component and end to end UI test.`<br />
a) HomeControllerTest: `It includes test cases for each functional component. `<br />
b) CodeUITest1: `It includes end to end UI test cases covering all generated sequences. `<br />
c) OrderedTest1: `It is an ordered list of all unit test cases as per requirement document. `

## Instructions to use the application 
Using Visual Studio:<br />
1. The project can be run using VS2013. As the rule of Keep It Simple and Straight has been followed so user just have to open the project using VS2013 and press F5 to run it.<br />
2. This will open a page and provides user with Text box to enter the Number and press "GetSequences" button.<br />
3. This will generate all the required sequences.<br />

#### How to execute CodeUITest1 : 
To execute this specific test, the application must be running or the url must be available. So might have to deploy it using IIS and apply the following steps:<br />
1.	Deploy the application on IIS and check the new url is working on IE. <br />
2.	Find and replace all the instances of “http://localhost:1516/”  with new url on which the application is available.<br />
3.	Now run CodeUITest1 and this will pop up Internet explorer and run the Automated UI test.<br /> 


