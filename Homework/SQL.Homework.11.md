 ## Kindra Bilodeau
#### SQL Homework 11

1. **Why do we use variables in T-SQL? How do you declare and initialize T-SQL variables?**
  - To store data values for later use and use in the same batch in which they were declared.
  - To declare a variable use SET statements
  - EX: declare @i as int;
        set@i = 10;
2. **Describe what is meant by a batch file in T-SQL? What is the difference between batches and transactions?**
  - Batch - one or more SQL statement sent by a client application to SQL Server for execution as a single unit
  - A transactions is an atomic unit of work. a batch can have multiple transactions. a transaction can be submitted in parts as multiple batches
3. **What is the scope of variables with respect to T-SQL batches?**
  - It is local to the batch and can't be accessed outside the scope of that batch.
4. **Write a T-SQL code snippet that returns a data element stating whether the current person can legally
purchase alcohol, that is, has reached his 21st birthday.**
  - declare @i as int set @i = 21;
    if int > 21
      print "old enough
    else  
      printo 'not old enough'
5. **(Not in book) Does T-SQL have a for loop construction?**
  - yes = they are used in flow control statements
6. **What is a cursor? What is the difference between a relation and a cursor?**
  - It is used tp process rows from a query one at a time in a requested order
  - A relational model is based on set theory and the order isn't guaranteed  
7. **How do you declare a temporary table? Why would you declare a temporary table?**
  - It's created by using a pound sign as a prefix #table
  - you would declare a temporary table when you need the data in the current session.
8. **What is the difference between a stored procedure, a user defined function, and a trigger?**
  - stored procedures are routines that encapsulate code give you better control of security
  - user defined function is to encapsulate logics that calculates something
  - Trigger is a type of store procedure one that cannot be executed explicitly
9. **Write a user defined function that returns a Booleans as to whether a customer may purchase alcohol
as of the instant that the function runs.**
  -
10. **Write a trigger that places a customer in the OFF LIMITS table if he attempt to purchase alcohol
when he is underage.**
  -
11. **Write a stored procedure that deletes customers from the OFF LIMITS table when they have reached
their 21st birthday.**
  -
