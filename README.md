







  
**<h1 align = "center">Animal Shelter**



     
<br>

<h4 align = "center">
  <a href="#requirements">Requirements</a> •
  <a href="#setup">Setup</a> •
  <a href="#technologies-used">Technologies</a> •
  <a href="#known-bugs">Known Bugs</a> •  
  <a href="#license">License</a></h4>

<br>

## **ABOUT**

* This program will create an API for a local animal shelter. 
* The API will list the available cats and dogs at the shelter.



## **INSTALL NOTES** 

* navigate to desired directory for where your project will go
* git clone url
* add workspace
* cd AnimalShelter
* dotnet restore
* dotnet build
* create a new terminal
* cd into AnimalShelter
* dotnet ef database update
* dotnet watch run
* Open postman<br>
* click the + symbol in the middle of the page<br>

TO GET AN ITEM<br>
* Set your request to type "GET" <br>
* http://localhost:5000/api/animals/ (for index of all)<br>
or<br>
* http://localhost:5000/api/animals/id (for specific animal details)<br>
* Hit Send<br>
or<br>
* http://localhost:5000/api/animals/Page?pageNumber=2&PageSize=5 (to limit number of displayed animals)<br>

TO ADD AN ITEM<br>
* Set your request to type "POST"<br>
* http://localhost:5000/api/animals/ <br>
* Select Body Tab<br>
* Select Raw Radio Button<br>
* Select JSON from dropdown<br>
* Write your addition to the database in the following format<br>
{<br>
  "Name" = "your value",<br>
  "Species" = "your value",<br>
  "Age" = "your value",<br>
  "Gender" = "your value",<br>
}<br>

TO EDIT AN ITEM<br>
* Make a GET request for the id you wish to edit<br>
* http://localhost:5000/api/animals/id<br>
* You can select the returned item data and paste that into your request body section for editing.<br> 
* Once you have completed your edits, set your request to Put<br>
* Hit Send<br>

To DELETE AN ITEM<br>
* Set your route in Postman to the id you wish to delete<br>
* Set your request to Delete<br>
* Hit Send<br>


## **REQUIREMENTS** 

* Install [Git v2.62.2+](https://git-scm.com/downloads/)
* Install [.NET version 3.1 SDK v2.2+](https://dotnet.microsoft.com/download/dotnet-core/2.2)
* Install [Visual Studio Code](https://code.visualstudio.com/)
* Install [MySql Workbench](https://www.mysql.com/products/workbench/)


**You need to update your username and password in the appsettings.json file.**

_by default these are set to user:root and an empty password. if you are unsure, refer to the settings for your MySqlWorkbench._

![appsettings](https://coding-assets.s3-us-west-2.amazonaws.com/img/app-settings.png)



## **TECHNOLOGIES USED**

_**Written in:** [Visual Studio Code](https://code.visualstudio.com/)_

_**Database Mgmt:** [MySql Workbench](https://www.mysql.com/products/workbench/)_


<br>

## **KNOWN BUGS**

_**None as of:** 8/21/2020_

<br>



## **LICENSE**
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

Copyright (c) 2020 **_Erich Richter._**