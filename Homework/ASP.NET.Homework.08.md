## Kindra Bilodeau
#### ASP.NET Homework 08

1. **What is the purpose of the startup class and explain the two default methods**
  - It is responsible for configuring the ASP.NET core application.
  - The ConfigureServices method is used to set up shared objects that can be used throughout the application through the dependency injection feature.
  - The Configure method is used to set up the features that receive and process HTTP requests.

2. **What is the difference between @using and @addTagHelper**
  - @using allows you to use the types without needing to refer to the namespace
  - @addTagHelper allows enable the built-in tag helpers.

3. **Why is IQueryable<T> interface useful? And Why might it not be useful?**
  - It is useful because it allows a collection of objects to be queried efficiently.
  - It might not be useful because each time the collection is enumerated, the query will be evaluated again. Which will result in being less efficient.

4. **Briefly describe loosely couple components and why it would be important**
  - Loosely coupled components means you can make one in part of the application without having to make changes everywhere it appears in the program. It's important because it can help to eliminate mistakes by only having to make a change in one spot.
5. **Decribe connection strings**
  - A connection string specifies the location and name of the database and provides configuration settings for how the application should connect to the database server. They are stored in  JSON file. 
