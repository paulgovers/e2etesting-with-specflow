Feature: ForumSearch

Scenario: Search on forum
Given User On Forum website
When i click on magnifier 
And i search on keywords 'Cannondale Super-V DH'
Then Search result are shown