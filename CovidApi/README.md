## API Documentation

Explore the API endpoints in Postman or a browser.

##### Using Swagger Documentation

To explore the API with Swashbuckle, launch using the command `dotnet run` in the terminal and go to `http://localhost:5000/` in browser. You will be able to view and try out the HTTP requests with the Swagger UI.

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

<summary>Diagnosis. Expand to access information about a diagnoses</summary>

#### HTTP Request

```
GET /api/diagnoses
GET api/diagnoses/ TODO parameters
POST /api/diagnoses
GET /api/diagnoses/{id}
PUT /api/diagnoses/{id}
DELETE /api/diagnoses/{id}
```

#### Path Parameters

| Parameter | Type | Default | Required | Description | Example |
| --------- | ---- | ------- | -------- | ----------- | ------- |
|           |      |         |          |             |         |

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
