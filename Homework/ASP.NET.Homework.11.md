## Kindra Bilodeau
#### ASP.NET Homework 11

1. **How does the Entity Framework help the iterative development process?**
  - It's made easier by not having to manually synchronize the database by writing your own SQL commands.
2. **What is CRUD?**
  - Create, Read, Update, Delete
  - It allows a user to make changes to a page
3. **What are the two parts needed to add a product editing page?**
  - Display a page that will the user to change the values
  - Add an action method that can process the changes
4. **What does the viewbag do and why can't the author use it when he handles the edit post requests?**
  - The viewbag passes data between the controller and view and it cannot hold data for longer than the current HTTP request
  - He can't use the viewbag because when the browser is redirected to a new page the data is lost.
5. **Why do you need model validation?**
  - You need model validation to ensure the data being input is in the correct format. 
