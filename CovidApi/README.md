<div align="center">

# Team Week COVID API

</div>

<div align="center">
<img src="https://github.com/agatakolohe.png" width="200px" height="auto" >
<img src="https://github.com/besscampbell.png" width="200px" height="auto">
<img src="https://github.com/cschweig2.png" width="200px" height="auto">
<img src="https://github.com/dani-t-codes.png" width="200px" height="auto">
</div>
<h3 align="center">COVID API, 01-28-2021</h3>
<h4 align="center"> By Agata Kolodziej, Bess Campbell, Chelsea Becker & Danielle Thompson</h4>

## Description

COVID Risk Assessment API. A User can pull questions to use to assess a person's COVID risk level. There are built in answers for specific questions. It is a one to many relationship. Diagnoses will have all of the Evidence gathered from the questions to be able to get data for all users results, age, and sex. This application will allow a user to make API calls to create, read, edit and delete.

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

- Navigate to the CovidApi folder in the command line
- Use the command `dotnet build` to compile

##### Installing Packages

- Navigate to the CovidApi folder in the command line
- Use the command `dotnet restore`

<details>

  <summary>Expand for Database Installation Essentials!</summary>

### Database Connection

Create a connection string to connect the database to the web application

1. Create a file in the root directory called `appsettings.json`
2. Add the code below:

```
{
    "Logging": {
        "LogLevel": {
            "Default": "Warning"
        }
    },
    "AllowedHosts": "*",
    "ConnectionStrings": {
        "DefaultConnection": "Server=localhost;Port=3306;database=covid_api;uid=root;pwd=YourPassword;"
    }
}
```

- Put in your MySQL password in `pwd=YourPassword`. Change the server, port, and uid if necessary.

### Import Database Using Entity Framework Core

1. Navigate to CovidApi directory in terminal
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

## API Documentation

Explore the API endpoints in Postman or a browser.

##### Using Swagger Documentation

To explore the API with Swashbuckle, launch using the command `dotnet run` in the terminal and go to `http://localhost:5001/` in browser. You will be able to view and try out the HTTP requests with the Swagger UI.

## Endpoints

Base Url: `https://localhost:5001`

#### HTTP Request Structure

```
GET /api/{value}
POST /api/{value}
GET /api/{value}/{id}
PUT /api/{value}/{id}
DELETE /api/{value}/{id}
```

#### Example Query

`https://localhost:5001/api/diagnoses/3`

#### Sample JSON Response

```
 {
        "diagnosisId": 3,
        "sex": "female",
        "age": 30,
        "evidence": []
    }
```

<details>

<summary>Evidence. Expand to access information about a evidences</summary>

#### HTTP Request

```
GET /api/evidences
GET api/evidences/
POST /api/evidences
GET /api/evidences/{id}
PUT /api/evidences/{id}
DELETE /api/evidences/{id}
```

#### Example Query

1. `http://localhost:5001/api/evidences`

#### Sample JSON Response

1.

```
[
    {
        "evidenceId": 1,
        "question": "What is your sex?",
        "sexAnswer": "false",
        "ageAnswer": 1,
        "fever": false,
        "cough": false,
        "sob": false,
        "yesNo": false,
        "explanation": "false",
        "diagnosisId": 1
    },
    {
        "evidenceId": 2,
        "question": "What is your age?",
        "sexAnswer": "false",
        "ageAnswer": 1,
        "fever": false,
        "cough": false,
        "sob": false,
        "yesNo": false,
        "explanation": "false",
        "diagnosisId": 1
    },
    {
        "evidenceId": 3,
        "question": "Do you have an underlying conditions that put you at a high risk? List all that apply.",
        "sexAnswer": "false",
        "ageAnswer": 1,
        "fever": false,
        "cough": false,
        "sob": false,
        "yesNo": false,
        "explanation": "false",
        "diagnosisId": 1
    },
    {
        "evidenceId": 4,
        "question": "Do you have any of the following symptoms?",
        "sexAnswer": "false",
        "ageAnswer": 1,
        "fever": false,
        "cough": false,
        "sob": false,
        "yesNo": false,
        "explanation": "false",
        "diagnosisId": 1
    },
    {
        "evidenceId": 5,
        "question": "Do you have any other symptoms? List all that apply",
        "sexAnswer": "false",
        "ageAnswer": 1,
        "fever": false,
        "cough": false,
        "sob": false,
        "yesNo": false,
        "explanation": "false",
        "diagnosisId": 1
    },
    {
        "evidenceId": 6,
        "question": "Have you recently lost the ability to smell or taste?",
        "sexAnswer": "false",
        "ageAnswer": 1,
        "fever": false,
        "cough": false,
        "sob": false,
        "yesNo": false,
        "explanation": "false",
        "diagnosisId": 1
    },
    {
        "evidenceId": 7,
        "question": "Please explain your current exposure level.",
        "sexAnswer": "false",
        "ageAnswer": 1,
        "fever": false,
        "cough": false,
        "sob": false,
        "yesNo": false,
        "explanation": "false",
        "diagnosisId": 1
    },
    {
        "evidenceId": 8,
        "question": "Have you recently traveled?",
        "sexAnswer": "false",
        "ageAnswer": 1,
        "fever": false,
        "cough": false,
        "sob": false,
        "yesNo": false,
        "explanation": "false",
        "diagnosisId": 1
    }
]
```

</details>

<details>

<summary>Diagnosis. Expand to access information about a diagnoses</summary>

#### HTTP Request

```
GET /api/diagnoses
GET api/diagnoses/
POST /api/diagnoses
GET /api/diagnoses/{id}
PUT /api/diagnoses/{id}
DELETE /api/diagnoses/{id}
```

#### Example Query

1. `http://localhost:5001/api/diagnoses`

#### Sample JSON Response

1.

```
{
      {
         "diagnosisId": 1,
        "sex": "female",
        "age": 30,
        "evidence": []
    }
}
```

</details>

## Known Bugs

Will probably edit Evidence Properties soon. 01-28-2020

## Support and Contact Details

If any errors or bugs occur with installation, delete both bin and obj folders and follow the Compiling and Installing Packages instructions again. Get help or report a bug you have found in the .NET platform at [.NET Support](https://dotnet.microsoft.com/platform/support). Or please email me, <agatakolohe@gmail.com>.

## Technologies Used

- .NET Core 2.2.0
- ASP.NET Core MVC
- C# 7.3
- Entity Framework Core 2.2.6
- GitHub
- MySQL
- MySQL Workbench
- Postman
- [Infermedica](https://developer.infermedica.com/docs/covid-19#endpoints)
- Swagger/Open API
- Swashbuckle 5.5.0
- VS Code

### License

This software is licensed under the [MIT License](https://choosealicense.com/licenses/mit/).

Copyright (c) 2021 Agata Kolodziej Bess Campbell, Chelsea Becker, Danielle Thompson <img src="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcR8Q_3EVY7j95tTyemJwWxMR7jwvUK7gPe0_w&usqp=CAU" width="2%" height="auto">
