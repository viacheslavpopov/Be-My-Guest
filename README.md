# Be My Guest

<div align="center">
<img src="https://github.com/agatakolohe.png" width="200px" height="auto">
<img src="https://github.com/besscampbell.png" width="200px" height="auto">
<img src="https://github.com/cschweig2.png" width="200px" height="auto">
<img src="https://github.com/dani-t-codes.png" width="200px" height="auto">
</div>

## **Authors and Contributors**

<table>
  <tr>
    <th>Author</th>
    <th>GitHub Profile</th>
    <th>Contact Email</th>
  </tr>
  <tr>
    <td>Agata Kolodziej</td>
    <td>https://github.com/agatakolohe</td>
    <td>agatakolohe@gmail.com</td>
  </tr>
  <tr>
    <td>Bess Campbell</td>
    <td>https://github.com/besscampbell</td>
    <td>bess.k.campbell@gmail.com</td>
  </tr>
  <tr>
    <td>Chelsea Becker</td>
    <td>https://github.com/cschweig2</td>
    <td>chelraebecker@gmail.com</td>
  </tr>
  <tr>
    <td>Danielle Thompson</td>
    <td>https://github.com/dani-t-codes</td>
    <td>danithompson74@gmail.com</td>
  </tr>
</table>

[![Be-My-Guest-Opt1-3.png](https://i.postimg.cc/ydMmPLrY/Be-My-Guest-Opt1-3.png)

## **Description**

## **Preview**

## **Schema**

[![Be-My-Guest-Schema.png](https://i.postimg.cc/8C0NgnV9/Be-My-Guest-Schema.png)

## Setup/Installation Requirements

##### Software Requirements

1. Internet browser
2. A code editor such as VSCode to view and edit the code
3. .NET or follow along with the Installing .NET instructions to install .NET

##### Open Locally

- Click on the link to my repository: [My Repository](https://github.com/cschweig2/BeMyGuest_TeamWeek.git)
- Click on the green "Code" button and copy the repository URL
- Open your terminal and use the command `git clone ` into the directory you would like to clone the repository
- Open in text editor to view code and make changes

##### Installing .NET

In order to run the application, please install .NET for your computer to recognize the `dotnet` command.

1. Download [.NET Core SDK (Software Development Kit)](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.106-macos-x64-installer). Clicking this link will prompt a file download for your particular OS from Microsoft.
2. Open the file. Follow the installation steps.
3. Confirm the installation is successful by opening your terminal and running the command `dotnet --version`. The response should be something similar to this:`2.2.105`. This means it was successfully installed.

##### Installing MySQL

MySQL is a type of database software used to create, edit, query, and manage SQL data.

- For Mac Users please [Click Here](https://dev.mysql.com/downloads/file/?id=484914) to download MySQL Installer
- For Windows Users please [Click Here](https://dev.mysql.com/downloads/file/?id=484919)

- Verify MySQL installation by opening the terminal and entering the command `mysql -uroot -p[THEPASSWORDYOUSELECTED]`
- If you gain access you will see see the MYSQL command line!

##### Installing MySQL Workbench

- Please [Click Here](https://dev.mysql.com/downloads/workbench/) to install the correct version for your machine
- Open MySQL Workbench and select `Local instance 3306 server`. You will need to enter the password you selected

##### Compiling

- Navigate to the APIParks folder in the command line
- Use the command `dotnet build` to compile

##### Installing Packages

- Navigate to the APIParks folder in the command line
- Use the command `dotnet restore`

<details>

  <summary>Expand for Database Installation Essentials!</summary>

### Database Connection

Create a connection string to connect the database to the web application

1. Create a file in the root directory called `appsettings.json`
2. Add the code below:

```
{
    "ConnectionStrings": {
        "DefaultConnection": "Server=localhost;Port=3306;database=TODO;uid=root;pwd=YourPassword;"
    }
}
```

TODO

- Put in your MySQL password in `pwd=YourPassword`. Change the server, port, and uid if necessary.

### Import Database Using Entity Framework Core

1. Navigate to APIParks directory in terminal
2. Use the command `dotnet ef database update` to generate the database through Entity Framework Core

### Update Database Using Entity Framework Core

1. Write any new code you wish to add to the database. Use the command `dotnet build` to check for any compiling errors. If no errors, proceed to step 2.
2. To update the database with any changes made to the code, use the command `dotnet ef migrations add [MigrationsName]`
3. Use the command `dotnet ef database update` to update the database

### Update Database Using MySQL Workbench

1. Open MySQL Workbench
2. Click on Server > Data Import in the top navigation bar
3. Select `Import from Self-Contained File`
4. Select the `Default Target Schema` or create new schema
5. Select all Schema Objects you would like to import
6. Select `Dump Structure and Data`
7. Click `Start Import`

</details>

##### View In Browser

TODO

<details>

<summary>Expand for more information</summary>

</details>

## **Known Bugs**

[Report bugs here.](https://github.com/cschweig2/BeMyGuest.Solution/issues) | [Request features here.](https://github.com/cschweig2/BeMyGuest.Solution/issues)

## **Technologies Used**

VS Code <br>
C# 7.3.0<br>
.NET Core 2.2.0<br>
Entity Framework Core 2.2.6<br>
Identity<br>
MySQL Workbench 8.0 for Windows<br>
CSS<br>
HTML<br>
Bootstrap<br>
JQuery<br>
JavaScript<br>
[Google Fonts](fonts.google.com)<br>
[Canva](canva.com)<br>

## Stretch Goals

- Implementing OAuth for user login.
- Integrate social media connections.

## Installation Requirements

### License

This software is licensed under the [MIT License](https://choosealicense.com/licenses/mit/).
Copyright (c) 2021 _*Agata Kolodziej, Bess Campbell, Chelsea Becker, Danielle Thompson*_