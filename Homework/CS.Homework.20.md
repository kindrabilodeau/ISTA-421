## Kindra Bilodeau
#### C# Homework 20

1. **What is a delegate? Explain delegates in terms of pointers and reference types.**
  - A delegate is an object that refers to a method. It stores the reference to the method.
2. **How do you declare a delegate? Include a discussion of types, return values, names, and parameters.**
  - declare that it's a delegate name the type and give it a name, and list any parameters
  - ex: delegate int myNewDelegate
3. **How do you create instances of delegates and assign values to the instance? What are the values?**
  - You declare it like a field. private delegate delegatename
  - You assign it values using += operator and you assign it field name . methods
4. **How do you invoke a method that has been added to a delegate?**
  - By calling the delegate name followed by parenthesis.
5. **What is an event? Why do we have events?**
  - It something that notifies the program that something occurred
  - You want it so that you can automate things
6. **How do you declare events?**
  - It's declared like an event but it prefixed with the event keyword, And the type is a delegate.
7. **How do delegates recognize event subscriptions? How do you unsubscribe an event from a delegate?**
  - It's recognized by using the += operator.
  - You unsubscribe using the -= operator  
8. **How do you raise an event? How do you declare code that raises an event?**
  - You raise an event by calling it.
9. **Explain with specificity what happens when an event fires and that event has been attached to a
delegate.**
  - when the event is triggered is the delegate performs the method(s)
