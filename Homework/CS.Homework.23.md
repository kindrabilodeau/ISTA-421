## Kindra Bilodeau
#### C# Homework 23

1 **List two reasons for multitasking, and explain the rationale for them.**
  - To improve responsiveness: Which allows the program to operate more efficiently.
  - To improve scalability: By making the program more efficient you are able to run more things at a time
2 **Explain Moore’s law. What does Moore’s law have to do with multitasking?**
  - That every two years computer processing would get faster, by adding more transistors to a chip
  - Now we can't add more transistors but we can add more chips to allowing to run multiple things at a time.
3 **In UWP, what namespace is used as the container for the multitasking methods?**
  - System.Threading.Tasks
4 **What is the difference between tasks and threads? Explain.**
  - A task is something you want done
  - A thread is one of the workers that performs that task
5 **What is the ThreadPool?**
  - a class that creates threads and assigns tasks to it.
6 **What parameters does the Task() constructor take?**
  - at least One an action delegate
  - An action delegate references a method that accepts no parameters does not return value.
7 **How do you start a thread?**
  - By creating a task object then using the start method.
  - Task task = new Task(...);
    task.Start();
8 **What is the difference between the Start() and Run() methods?**
  - The Run method takes an action delegate as a parameter
9 **What is the difference between creating independent tasks with Tasks and parallelization with Parallel? Explain.**
  - An independent task is something that runs by itself
  - Tasks running in parallel are smaller independent tasks that run at the same time.
10 **Explain how manual cancellation works using a cancellation token.**
  - A cancellation token is a request to cancel one or more tasks
  - A program gets a cancellation token by creating a cancelleationtoken source object then by passing the token as a parameter to any methods started by taks
