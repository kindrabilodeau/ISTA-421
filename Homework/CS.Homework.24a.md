## Kindra Bilodeau
#### C# Homework 24A

1. **What is an asynchronous method? When the book talks about a contract, what is the contract and
who is it with?**
  - An asynchronous method is one that does not block the current thread on which it starts to run.
  - It's between an application and a asynchronous method. The application expects the method to return the values quickly and use it's own separate thread.
2. **What can be the problem with decomposing a series of discrete method calls into a set of tasks, such
as we saw in chapter 23?**
  - program will not be useable until each method is complete
3. **What can be the problem with decomposing a series of discrete method calls into a set of continuations? When does the last continuation “complete” as compared to the previous continuations? What problem might this cause?**
  - The start method initiates a task but does not wait for it to complete.
4. **What might be the problem with implementing the previous solution as a continuation passing a delegate? What would be your interpretation with this error message: “The application called an interface that was marshaled for a different thread.”?**
  - If you try to debug it, you will get a System.Exception exception
  - you called something that is being used by a differnt thread
5. **The book suggests a solution using a continuation delegate calling another continuation delegate via
an anonymous function. What does the book identify as a problem with this suggested solution?**
  - That it's messy and difficult to maintain
6. **What does the async modifier do? What does the await operator do?**
  - The async modifier indicates that a method contains functionality that can be run asynchronously.
  - The await operator specifies the points at which this asynchronous functionality should be performed.
7. **What is an awaitable object? Be specific.**
  - An awaitable object is a type that provides the GetAwaiter method
  - It returns an object that in turn provides methods for running code and waiting for it to complete.
8. **In a method definition, how do you create and run a Task and return a reference to the Task? What
is the type of such a method? What does the method return?**
  - you create a new task then return it.
  - It's of type task
9. **How do you define method calls in the implementation of an async method? Specifically, you must
define a task, you must run the task, you must implement the task, and you must await the task. What is the syntax for doing this?**
  - Task first = Task.Run()
  - await first;
10. **What is the difference between decomposing a series of method calls that do not return values, and
a series of method calls that return values? What is the Result property of a method that returns a
value? How do you use the await operator in this circumstance?**
  - For a method that returns a value you use the generic Task<TResult> where the type parameter, TResult, specifies the type of the result.
  - to get the value returned by the method, you use the Result property.
    -  the Result property blocks the caller.
    - you don’t have to perform any synchronization yourself, and you know that when the Result property returns a value, the task has completed its work.
  - The await operator extracts the value from the Task returned
11. **What is the difference between the await operator and the Wait method?**
  - The await operator indicates that a method should be run by a separate task, and the calling code is suspended until the method call completes
  - The Wait method always blocks the current thread and does not allow it to be reused until the task completes.
