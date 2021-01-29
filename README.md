<div align="center">

# Be My Guest

</div>

<div align="center">

![Be-My-Guest-Opt1-3.png](https://i.postimg.cc/ydMmPLrY/Be-My-Guest-Opt1-3.png)

</div>

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
    <th>LinkedIn Connections</th>
  </tr>
  <tr>
    <td>Agata Kolodziej</td>
    <td>https://github.com/agatakolohe</td>
    <td>agatakolohe@gmail.com</td>
    <td>https://www.linkedin.com/in/agatakolohe/</td>
  </tr>
  <tr>
    <td>Bess Campbell</td>
    <td>https://github.com/besscampbell</td>
    <td>bess.k.campbell@gmail.com</td>
    <td>https://www.linkedin.com/in/bess-campbell
  </tr>
  <tr>
    <td>Chelsea Becker</td>
    <td>https://github.com/cschweig2</td>
    <td>chelraebecker@gmail.com</td>
    <td>https://www.linkedin.com/in/chelsearaebecker/</td>
  </tr>
  <tr>
    <td>Danielle Thompson</td>
    <td>https://github.com/dani-t-codes</td>
    <td>danithompson74@gmail.com</td>
    <td>https://linkedin.com/in/daniellethompson74</td>
  </tr>
</table>

## **Description**

 Be my Guest stemmed from the need to handle social gatherings with ever-changing social standards. As more people get vaccinated and the virus evolves, Be my Guest is a  way to clearly communicate how different expectations will be handled. Using the site as a Host allows you to create an event and invite guests to that event. When creating an event you can let guests know what kind of expectations they can have for the safety standards of your gathering. You can request that your guests fill out a built in COVID questionnaire and as a bonus a Social Q's questionnaire to handle the less than comfortable conversations that one doesn't need to have with every single person.  It creates a space for guests and hosts to get on the same page about how everyone will be expected to behave at the party.

## **Preview**

Web Page Preview <br>

<div align="center">

[![Be-My-Guest-Preview.png](https://i.postimg.cc/L6FHrkc2/Be-My-Guest-Preview.png)](https://postimg.cc/fk5nddWr)

</div>

<br>

To view a mobile demo of the app, please download the Fluid UI app for [iOS](https://www.fluidui.com/ios) or [Android](https://www.fluidui.com/android), then scan this code:
<div align="center">

  <iframe data-id="p_Qqp3m3svolrxqJN31QZEBSdIZMTETEbZ" data-src="https://www.fluidui.com/editor/live/project/p_Qqp3m3svolrxqJN31QZEBSdIZMTETEbZ" src="https://www.fluidui.com/editor/live/project/p_Qqp3m3svolrxqJN31QZEBSdIZMTETEbZ"></iframe>

</div>

Alternatively, visit this [page](https://www.fluidui.com/editor/live/project/p_Qqp3m3svolrxqJN31QZEBSdIZMTETEbZ) to view the live prototype.

## **Schema**

<div align="center">

![Be-My-Guest-Schema.png](https://i.postimg.cc/8C0NgnV9/Be-My-Guest-Schema.png)

</div>

<details>

<summary> Setup/Installation Requirements </summary>

##### Software Requirements

1. Internet browser
2. A code editor such as [VSCode](https://code.visualstudio.com/) to view and edit the code
3. .NET Core, or follow along with the 'Installing .NET Core' instructions

##### Open Locally

- Click on the link to my repository: [My Repository](https://github.com/cschweig2/BeMyGuest_TeamWeek.git)
- Click on the green "Code" button and copy the repository URL
- Open your terminal and use the command `git clone https://github.com/cschweig2/BeMyGuest_TeamWeek.git` into the directory you would like to clone the repository
- Open in text editor to view code and make changes

##### Installing .NET Core

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

##### Installing Packages

- Navigate to the BeMyGuest folder in the command line
- Use the command `dotnet restore`
- Run the same command in the CovidApi folder

##### Compiling

- Navigate to the BeMyGuest folder in the command line
- Use the command `dotnet build` to compile
- Run the same command in the CovidApi folder

</details>

<details>

  <summary>Expand for Database Installation Essentials!</summary>

### Database Connection

Create a connection string to connect the database to the web application.

1. Create one file in the CovidAPI folder and one file in the BeMyGuest folder, with both files called `appsettings.json`
2. Add the code below to each file:

```
{
    "Logging": {
        "LogLevel": {
          "Default": "Warning"
        }
      },
      "AllowedHosts": "*",
    "ConnectionStrings": {
        "DefaultConnection": "Server=localhost;Port=3306;database=be_my_guest;uid=root;pwd=YourPassword;"
    }
}
```

- Put in your MySQL password in `pwd=YourPassword`. Change the server, port, and uid if necessary.

### Import Database Using Entity Framework Core

1. Navigate to CovidApi directory in terminal
2. Use the command `dotnet ef database update` to generate the database on your local machine through Entity Framework Core
3. Navigate to BeMyGuest directory in terminal
4. Repeat step 2

### Update Database Using Entity Framework Core

1. Write any new code you wish to add to the database. Use the command `dotnet build` to check for any compiling errors. If no errors, proceed to step 2
2. To update the database with any changes made to the code, use the command `dotnet ef migrations add [MigrationsName]`
3. Use the command `dotnet ef database update` to update the database

</details>

##### View In Browser

1. In one terminal, navigate to BeMyGuest directory and use the command `dotnet run`
2. In a second terminal, navigate to CovidApi directory and use the command `dotnet run`
3. To view the application in browser, go to `https://localhost:5000`
4. The API will be running in `https://localhost:5001`
5. To view the Swagger API Documentation in browser, go to `https://localhost:5001`
6. When viewing the main application, register with your email and unique password
7. Log in using your email and password once you have registered
8. Choose either Guest or Host role to navigate through role specific pages


## **Known Bugs**

01-28-2021

- Relationship between host and diagnoses is not currently established
- Roles not authorizing precisely and when not authorized the error is not handled
- Date/Time not showing as stand alone Date or Time
- Getting COVID answers is not established
- Social Q's form in Guests Edit view is not functional
- Social Q's view is not functional, keeping for future referenece
- GuestCovidInfos views are not functional


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
[Google Fonts](fonts.google.com)<br>
[Canva](canva.com) for logo & in-app graphics<br>
[Fluid UI](fluidui.com) for mobile app prototyping<br>
[Monday]() for project management & planning<br>

<details>

<summary>Stretch Goals</summary>

- Implementing OAuth for user login.
- Integrate social media connections.
- There was a number of design-related features and little design flaws that we wanted to incorporate/fix, but did not have time to get through everything.
- The design logo wasn't as integrated into the app theme as much as we would have liked, and in a perfect world, would've had some Javascript incorporated to animate a "fly in" of the logo, etc.
- We wanted to create small icons or badges for some of the SocialQ's to be displayed in-app and when looking at a guest list or a guest's details.
- Including some visual representations of the guests in attendance (graphs, charts, etc) for viewing their host and other guests' important SocialQ's in mobile and desktop applications would be ideal.
- Additionally, we would have liked to incorporate JWT Token authorization for the API/UI.
- Being able to generate a specific event ID by a host creating an event that would then get sent to potential guests through an auto-generated email. This was a much loftier goal than could be accomplished with just four days, but with more time, would be essential to streamlined user experience.
- We would like to have all the views fully functional, as some of them currently are hard-coded or not as set up as we would like.

</details>

### License

This software is licensed under the [MIT License](https://choosealicense.com/licenses/mit/).
Copyright (c) 2021 _*Agata Kolodziej, Bess Campbell, Chelsea Becker, Danielle Thompson*_