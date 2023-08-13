Blazor Server Authentication and Authorization
=============================================

    

[![MIT License](https://img.shields.io/github/license/nuux14/AuthenticationInBlazor?color=%230b0&style=flat-square)](https://github.com/nuux14/AuthenticationInBlazor/blob/main/LICENSE)
[![Open Issues](https://img.shields.io/github/issues/nuux14/AuthenticationInBlazor/good%20first%20issue?color=%23512BD4&label=good%20first%20issue&style=flat-square)](https://github.com/nuux14/AuthenticationInBlazor/issues?q=is%3Aissue+is%3Aopen+label%3A%22good+first+issue%22)

An asp.net core blazor server with authentication and authorization (.NET 7). In this project we are using SQLite database

### Visual Studio Code (or any code editor)

1. Navigate to the `AuthenticationInBlazor` folder 
1. If you haven't installed the EF Core Command Line Interface (CLI), install it by following [these instructions](https://docs.microsoft.com/ef/core/miscellaneous/cli/dotnet). Choose the latest stable version (the project file currently ships with version 7.0.9).
1. This migration step has already been done but for reference this is what you'd have done: 

    ```text
   dotnet ef migrations add Initial
    ``` 

    or if you would want you could specify the DbContext option like this:


    ```text
   dotnet ef migrations add --context ApplicationDbContext Initial
   ```
   
    to set up the  database migrations (already done).
1. Run 

    ```text
   dotnet ef database update
   ``` 
    
    to create the AuthenticationInBlazor database.
1. Type 

   ```text
   dotnet run` or `dotnet watch
   ```
    
   to start the server. Navigate to the port specified.
  
> **Note**: the demo app is designed to show how to add authentication and authorization to an asp.net blazor server app. 

Don't forget to follow my account: <!-- Place this tag where you want the button to render. -->
<a class="github-button" href="https://github.com/nuux14" data-show-count="true" aria-label="Follow @nuux14 on GitHub">Follow @nuux14</a>

and start (🌟) the repos <!-- Place this tag where you want the button to render. -->
<a class="github-button" href="https://github.com/nuux14/AuthenticationInBlazor" data-icon="octicon-star" data-size="large" aria-label="Star nuux14/AuthenticationInBlazor on GitHub">Star AuthenticationInBlazor</a>

Submit any feedback, questions, suggestions, or issues [here](https://github.com/nuux14/AuthenticationInBlazor/issues/new).

Regards,

![Mubarek Abdi](https://github.com/nuux14)

[@nuux14](https://twitter.com/May28_2023)
