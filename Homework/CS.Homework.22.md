## Kindra Bilodeau
#### C# Homework 22

1. **Explain the difference between the concepts of associativity and precedence.**
  - Precedence is the order in which you process something
  - associativity is whether you read something from right to left or left to right.
2. **Explain the difference between the concepts of binary and unary operators.**
  - Unary operators are an operator that has just one operand (ex:++)
  - Binary operator is an operator that has two operands ex:*
3. **List four constraints imposed by C# with respect to operator overloading.**
  - You cannot change the precedence and associativity of an operator.
  - You cannot change the multiplicity (the number of operands) of an operator
  - You cannot invent new operator symbols.
  - You can’t change the meaning of operators when they are applied to built-in types.
4. **What is the syntax for overloading operators? Discuss access, scope, return value types, and parameter
types and multiplicity.**
  - All operators must be public and static
  - A binary operator has two explicit arguments, and a unary operator has one explicit argument.
  - At least one of the parameters must always be of the containing type.
5. **What are symmetric overloaded binary operators and how do they differ from non-symmetric overloaded binary operators?**
  - Symmetric overloaded binary operators would allow you to add in any order then the compiler would automatically convert it 
6. **Can you overload compound assignment operators? If so, please state how you do so. If not, explain
why not.**
  - yes. You do it like +=
7. **What is the difference between overloading increment and decrement operators for value types and
reference types?**
  - With a reference type it would update all the variables
  - With a value type it would make a copy of the variable and only update that one
8. **Why do we overload some operators in pairs?**
  - Because you want a definition for a comparison and its opposite comparison. To explain what should happen in each case
9. **What is the difference between widening conversion and narrowing conversion?**
  - A widening conversion is a value that ends up with at least as much information if not more than the original
  - A narrowing conversion is a value that contains less information than the original
10. **What is the difference between explicit conversion and implicit conversion?**
  - Implicit is a conversion that is type safe and does not run the risk of losing information.
  - Explicit is a conversion that is not type safe and the type must cast
