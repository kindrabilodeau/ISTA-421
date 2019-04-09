## Kindra Bilodeau
#### 421 C# Homework Chapter 19

1. **What is an enumerable collection?**
  - A collection that uses the system.collections.Ienumerable interface
2. **What properties and methods does the IEnumerable interface contain?**
  - IEnumerator GetEnumerator();
3. **What properties and methods does the IEnumerator interface contain?**
  - object Current {get;}
  - bool MoveNext();
  - void reset();
4. **What values does the MoveNext() method return? What does it do?**
  - The MoveNext moves the pointer down to the next item.  it will return true if there is another item, and returns false if there is not.
5. **What values does the Reset() method return? What does it do?**
  - It's a void method?
  - It returns the pointer back to before the first item in the list.
6. **Are IEnumerable and IEnumerator type safe? Why or why not? If not, how do you implement type
safety?**
  - No they are not. To ensure type safety you must provide a type parameter and implement the IEnumerator interface
7. **Why don’t recursive methods retain state when used with data structures like binary trees?**
  - The data is reset every time the method is called
8. **How do you define an enumerator?**
  - A pointer indicating to elements in a list
9. **What is an iterator?**
  - yields or Returns
10. **What does yield do?**
  - Returns one value at a time
  - doesn't evaluate until called 
