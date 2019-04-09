## Kindra Bilodeau
#### ASP.NET Homework 10

1. **What are services used for?**
  - They are most commonly used to hide details of how interfaces are implemented from the components that depend on them as well as many other things.

2. **What does the CartController class do?**
  - It indicates that it needs a Cart object by declaring a constructor argument, allowed you to remove the methods that read and write data from the session

3. **What does the Cart widget do?**
  - It allows you to click on it and view the contents in the cart.

4. **How do you migrate data?**
  - by using powershell or command prompt and running "dotnet ef migrations add (whatever)"
  - The command tells entity framework to take a snapshot of the application data model and find the differences for the previous version.

5. **How and why would you want to reset your database?**
  - You drop it by running "dotnet ef database drop --force" in the command prompt
  - You update by running "dotnet ef database update" in the command prompt
  - Doing so will reset the database so it accurately reflects your model 
