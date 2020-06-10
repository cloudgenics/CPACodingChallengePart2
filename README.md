# CPACodingChallengePart2

It consists of

*   An **ASPNET Core 3.0 Web API**  service

The API has

*   an Entity project
    *   This contains the Entities used in the API.

*   a Repository project
    *   This contains
        
        *   a ExamResults Repository
            *   This uses HttpClient to fetch the results. It uses **Newtonsoft.Json** to deserialize the data. 

*   a Service project
    *   The service layer generally cotains any business logiccontains
        
      *   an Unit Test project
    *   This contains unit tests for the Controller. **Moq** is used to mock the Service layer.         
