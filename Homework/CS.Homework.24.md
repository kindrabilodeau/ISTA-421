## Kindra Bilodeau
#### C# Homework 24

1. **What are the two scenarios in which you can use PLINQ to speed up operations? Why does using PLINQ in these scenarios speed up processing?**
  - Using PLINQ to improve performance while iterating through a collection
    - It's useful because it splits up the queries
  - Using PLINQ to join two collections

2. **How does AsParallel qualify as an extension method? First, explain what an extension method is and
how you define entension methods, and them explain why AsParallel qualifies as an extension method.**
  - Extension method allow you add methods to classes you don't have access to
- AsParallel is an extension method becuase it methods to LINQ?????
3. **How do you cancel a PLINQ query before it finishes? Be specific with respect to the variables and
methods used for the cancellation operation, and how the variables and methods are used.**
  - you specify a CancellationToken object from a CancellationTokenSource and use the WithCancellation extension method
  -  If the CancellationTokenSource  used to generate the CancellationToken is canceled, the query stops
4. **Why is it important to synchronize concurrent access to a server? Give an example of a specific
condition that will cause an error in your application if concurrent access is not synchronized.**
  -  If two tasks run at the same time  processing the same data, they might corrupt the data.
5. **What does the lock statement do?**
  - Ensures one thread is executing a piece of code at one time.
6. **This is not in the book. Define mutex, define semaphore, and explain the difference between them.**
  - Mutex - is like a lock but it can work across multiple processes. can be computer wide
  - Semaphore - allows you to limit the number of threads that have access to a shared resource at the same point of time
  -
7. **What does it mean to say that some collection classes are not thread safe? Explain how not being
thread safe may lead one of these collection classes to produce a malfunction in the program.**
  - ? Synchronization can be very expensive - it takes a lot of resources to keep it thread safe
  - they are prone to error and not scalable
  - multiple threads can access it at the same time
8. **Explain how thread safe collection classes are made thread safe.**
  - by using collections from the Collections.Concurrent namesapce
9. **Why are thread safe classes slower than non-thread safe classes? Be specific.**
  -  Adding thread safety to the methods in a collection class imposes additional run-time overhead, so these classes are not as fast
