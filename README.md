# _Pierre's Bakery: Authentication with Identity_

#### By _**Brian Yoder**_

#### _Pierre is back! Now we're creating many to many relationships while using user authentication. This app allows a user to create associations between treats and flavors, and allows non-logged in users to view a list of each._

## Technologies Used

* MacBook Pro (13-inch, M1, 2020), macOS Sonoma 14.0
* VSCode v. 1.83.1
* C#
* ASP.NET Core
* ASP.NET Identity
* Razor Markup
* Entity Framework Core


## Setup / Installation Requirements / Configuration

* Open Terminal/Command line
* Navigate to the desktop by typing **cd ~/Desktop** and press Enter on the keybord
* type **git clone https://github.com/brnydr/BakeryWithAuth.Solution** into the terminal and press Enter on the keyboard
* Navigate to the desktop and click on the "BakeryWithAuth.Solution" folder.
* Open the folder in VS Code


## Adding Packages

* In the terminal, navigate to "BakeryWithAuth" folder by using the following command: $ cd BakeryWithAuth
* The .csproj file should have all necessary packages included. 
* In the terminal enter the following command: $ dotnet restore
* All packages should be restored and ready to go.

## Setting up appsettings.json
* In the terminal navigate to the project directory "BakeryWithAuth".
* Next, will add the file. In the terminal, enter the following:
  - $ touch appsettings.json
* Open the file in the code editor, and enter the following:
  ```json
  {
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=[YOUR DATABASE NAME];uid=[YOUR USER ID];pwd=[YOUR PASSWORD];"
    }
  } 
  ```
* Save and done and done!

## Creating the database

* Install the following in the terminal:

```
  $ dotnet tool install --global dotnet-ef --version 6.0.0
```
```
  $ dotnet add package Microsoft.EntityFrameworkCore.Design -v 6.0.0
```
``` 
  $ dotnet ef migrations add Initial
```
```
$ dotnet ef database update
```
* The database has been migarated and the program is now functional. 



## Running the program
* In the terminal, navigate to the BakeryWithAuth folder
* Next, type this in the terminal:
  - $ dotnet run
* The program is ready to run on localhost. 


## A few things to note:
* Only logged in users can create, edit, or delete treats and flavors.
* Non-logged in users can view a list of treats and flavors on the home page, and can view details of each treat and flavor.

## Known Bugs

* None

## [License](https://mit-license.org/)

_If there are any issues found with the site, feel free to contact me at_ [brianyoder@gmail.com](brianyoder@gmail.com)

Copyright (c) _2023_ _Brian Yoder_