# _[ %American Parks% ]_  

## _A C# MVC Application using a (locally-hosted) Web API, featuring an Entity Frameworks Database_

### _January 22nd, 2021_  
----------------------
## Description:
This project is a Web Api built in C#, called locally with information stored in an Entity-built database. This is to allow the practice of structuring a web application to call and receive information from an Api, but without making six hundred calls on someone else's data plan. This application will allow you to find State and National Parks throughout the United States, as well as create your own.

----------------------
## Project Criteria:  

As referenced from the [Epicodus](https://epicodus.com) program's curriculum:  

>    Create an API for state and national parks. The API will list state and national parks.
>
> You have the freedom to build out your APIs as you wish. At the very least, your API should include the following:
>
> -    Full CRUD functionality.
>
> -    Further exploration of one of the following objectives: authentication, versioning, pagination, Swagger documentation, or CORS.
>
> -    Complete documentation of API endpoints and the further exploration you did.
>
> Objectives:
>
> -    Application includes CRUD functionality and successfully returns responses to API calls.
>
> -    Application includes at least one of the further exploration objectives: authentication, versioning, pagination, Swagger documentation, or CORS.
>
> -    Application is well-documented, including specific documentation on further exploration.
>
> -    Commit history clearly shows eight hours of work.

The "further exploration" objective chosen for this project was _pagination_.

-------------------------------
## Known Issues / Current Bugs:
1. "Create New Park" `ApiClient` post method returns a 404 if routed through any non-index page.
2. Attempts at implementing search or client-routed endpoints results in JObject/JArray conflicts.

-------------------------------
## Bug log:
1. Local SQL connection server gets fussy. Replaced "localhost" routing in MySQL Workbench and in `appsettings.json` with "127.0.0.1".

-------------------------------
## Setup:

### Prior to downloading:
> Each of the following programs and softwares will be listed with the version numbers used in making this application. While you may not need to have these _specific_ versions installed, compatibility cannot be guaranteed with earlier or later releases.
>
> You will need to have the following installed and set up on your local machine before you will be able to utilize this program:
- [.NET core](https://dotnet.microsoft.com/download/dotnet-core/2.2), `.NET Version: 2.2.203`.
- [MySql Server & Workbench](https://dev.mysql.com/downloads/), `MySQL Server Version: 8.0.19`; `MySQL Workbench Version: 8.0.19`.
- [Postman (optional)](https://www.postman.com/).

For more step-by-step instructions on installing these programs, please visit [these Epicodus tutorials](https://www.learnhowtoprogram.com/c-and-net/getting-started-with-c).

----------------------
### To view locally on your machine / download from browser:  

1. Find the green **Code** button above the file list on this project's [main GitHub repository page](https://github.com/grand-scheme/ParksLookup.Solution).

2. Select the button to open a drop-down menu. Select "Open with GitHub Desktop" or, if you do not have this program installed, download the compressed .zip file.

3. Extract the .zip file to your local machine.

4. Directions were accurate as of January 22nd, 2021. If GitHub has since changed their protocol, please see [the GitHub help docs](https://docs.github.com/en) for up-to-date information.

----------------------
### To clone this project to your machine: 
> The following directions are based on Git Bash for a Windows machine; you may have to adjust terminology based on your local specs.
1. Launch your terminal of choice. 

2. Navigate to the containing directory into which you would like to clone this project.

3. Input:\
`$ git clone https://github.com/grand-scheme/ParksLookup.Solution`

4. This will clone the project to a folder called "ParksLookup.Solution." If you wish to clone it into a directory of a different name, append the new folder name to the end of the string, like so:\
`$ git clone https://github.com/grand-scheme/ParksLookup.Solution NEW-FOLDER`\
where `NEW-FOLDER` is where you would type the name of the folder you would like to use.\
**Note:** It is highly recommended that your destination folder retains the name `ParksLookup.Solution`.  

5. Directions were accurate as of Jan. 22nd, 2021. If GitHub has since changed their protocol, please see [the GitHub help docs](https://docs.github.com/en) for up-to-date information.

----------------------
## To run this project on your machine:

### ParksApi: 
1. Once you have the project locally stored, navigate to its main directory in your terminal of choice. By default, this is `ParksLookup.Solution`.

2. Navigate to the subfolder `ParksApi`.

3. Open the file `appsettings.json`. Any plain-text editor should do. Once you have opened the file, you'll see a block of code that looks like this:
```json
{
	"ConnectionStrings": {
		"DefaultConnection": "Server=localhost;Port=3306;database=grantski_2021_01_22;uid=USER;pwd=PASSWORD;"
	}
}
```
You will need to replace `USER` and `PASSWORD` with **your** MySql username and password. Depending on your local settings, you may also need to change the destinations for Server or Port. You can check what these settings should be in your local copy of MySql Workbench.

4. In your command line, input as separate commands:\
`$ dotnet restore`\
`$ dotnet build`\
`$ dotnet ef database update`\
`$ dotnet run`

5. If all goes well, the command terminal should inform you that a local host has been launched for this program at `http://localhost:5000`. If you would just like to test API calls and endpoints by url, you may jump to the next section.

### ParksClient:
6. After you have `ParksApi` running, launch a second terminal. Do not close or reuse the one running `ParksApi`.

7. Navigate to the subfolder `ParksClient`.

8. In your command line, input as separate commands:\
`$ dotnet restore`\
`$ dotnet build`\
`$ dotnet run`

9.  If all goes well, the command terminal should inform you that a local host has been launched for this program at `http://localhost:5004`. This will be your browser client.

-------------------------------
## Testing API Calls and Endpoints:  

### Base Calls:
Once you have `ParksApi` running, you can make test API calls in your browser or in [Postman](https://www.postman.com/). By default, the root url for the API will be located at **http://localhost:5000/** or **https://localhost:5001/**. For the rest of this section, this will be referred to as `{URL}`

The locations database for this project can be initially called at `{URL}/api/parks`. This will return the first 10 entries by ID.

To customize your call, you may use the following endpoints:

- _**`name=`**_ Name of a specific park.
	> _e.g._, `{URL}/api/parks/?name=Cape Disappointment`
- _**`state=`**_ Name of a U.S. State, District, or Territory.
	> _e.g._, `{URL}/api/parks/?state=Wyoming`, `{URL}/api/parks/?state=American Samoa`
- _**`stateornatl=`**_ Filter by State Parks vs National Parks.
	> _e.g._, `{URL}/api/parks/?stateornatl=national`

- _**`count=`**_ Number of results returned per page per call. The default count is 10 per page.

- _**`page=`**_ Page number. Page numbers 0, 1, and undeclared return the same results.

Endpoints can be stacked, but not all combinations will return data. \
	>> _e.g._, `{URL}/api/parks/?stateornatl=national&state=colorado&count=1` will return the one National Park in Colorado. \
	`{URL}/api/parks/?stateornatl=state&count=50&page=2` will return the 51st through 100th entries classified as State Parks.

To make a POST or PUT request to your local copy of the API database, the BODY of your request must follow this format:
```json
{
	"parkId": 999,
	"name": "NAME",
	"state": "STATE",
	"stateOrNational": "STATE or NATIONAL"
}
```
At the time of this publication, the final used `parkId` number is `213`. 

To DELETE, use `{URL}/api/parks/{parkID}`.

It is recommended you make non-GET requests through a client like Postman.

### Through the client:
> `ParksApi` will need to be running for `ParksClient` to access the database.

The root url for `ParksClient` is **https://localhost:5003/** or **http://localhost:5004/**. These urls will be referred to as `{SITE}`.

To "Establish a new park" (create new entry), use the link on the home page to navigate to `{SITE}/parks`. `ParkID` will be automatically generated; `Park Name` is your desired input; `Location` can be any use input, and valid states and territories will be automatically suggested.

To view parks, use the link on the home page to navigate to `{SITE}/parks/show`. This will display the first 10 entries of the database. Each individual park is located at `{SITE}/parks/details/{parkId}`, where you can edit or delete them from the database.

Search, filter, and pagination is not yet available in the web client.

-------------------------------
## Technologies Used:  
- Visual Studio Code
- Windows Powershell
- MySQL Workbench
- Postman
- .NET Core SDK Version: 2.2.203
- Microsoft.AspNetCore.Razor.Design Version: 2.2.0
- Entity Framework Core .NET 2.2.4
-------------------------------
## Tutorials Referenced:  
### API Pagination:
- [stack overflow (1)](https://stackoverflow.com/questions/38752848/paging-the-huge-data-that-is-returned-by-the-web-api?newreg=796af7cad18a4f51956c168615570be4)
- [stack overflow (2)](https://stackoverflow.com/questions/1364033/linq-take-question)
- [c-sharp corner](https://www.c-sharpcorner.com/article/how-to-implement-paging-using-skip-and-take-operators-in-linq/)

While there were a few other methods presented for paginating Api results, I decided to go with `System.Linq`'s `Take()` and `Skip()` methods for their simple flexibility.

-------------------------------
## License
- _GNU AGPLv3_  
- Project copyright (c) 2021 **_Shannon Grantski_**  
- Project criteria quoted text copyright (c) 2021 Epicodus, Inc.