# Introduction 
Best practice E2E testing with Specflow and Selenium

# Getting Started
1.	Install Visual studio 2019
2.	Install VS2019 extention 'SpecFlow for Visual Studio 2019'
3.  Install the LivingDoc CLI as a global dotnet tool (dotnet tool install --global SpecFlow.Plus.LivingDoc.CLI)
4.  NUnit 3 Test adapter

# Feature file
With F12 you go directly to the step definition

# Build and Test
Visual studio: Test->Run all test

# LivingDoc
Navigate to the output directory of the SpecFlow project. Run the LivingDoc CLI by using the below command to generate the HTML report.
```
livingdoc test-assembly SpecFlowCalculator.Specs.dll -t TestExecution.json
```
Open the generated HTML(LivingDoc.html) with your favorite browser. The HTML file is stored in the same folder as the output directory of the SpecFlow project.

# Handy
https://github.com/rosolko/WebDriverManager.Net

