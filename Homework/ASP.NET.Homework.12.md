## Kindra Bilodeau
#### ASP.NET Homework 12

1. **How do you use Entity Framework migrations to create a new migration to the database?**
  - You create a new migration for the database by running the command in powershell
    - ex: dotnet ef migrations add Initial --context AppIdentityDbContext
2. **What does the "-context" argument mean?**
- The context argument specifies the name of the context class associated with the database you want to work with
  - from the example in the book, the class he wants to use is AppIdentityDbContext
3. **What does the Authorize attribute do?**
  - The authorize attribute allows you to restrict access to methods and make sure that only authenticated users can execute it.
4. **What does the Required attribute do? What does the UIHint attribute do?**
- The required attribute ensures that those values have been provided
- The UIHint attribute will hide the text.
  - Ex: typing a password
5. **How do you create the database in Azure?**
  - Login, select the SQL Databases resource category and click the Add button to create a new database.
  - Setup the name, then setup the server
  - Then setup a database administrator username and password
