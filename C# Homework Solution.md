# C# Homework Solution

## Understanding Data Types

1. What type would you choose for the following “numbers”?
   - A person’s telephone number: string
   - A person’s height: two int
   - A person’s age: int
   - A person’s gender (Male, Female, Prefer Not To Answer): int (0 male; 1 female; 2 N/A)
   - A person’s salary: double
   - A book’s ISBN: string
   - A book’s price: double
   - A book’s shipping weight: double
   - A country’s population: long
   - The number of stars in the universe: ulong
   - The number of employees in each of the small or medium businesses in the
     United Kingdom (up to about 50,000 employees per business): int

2. What are the difference between value type and reference type variables? What is
   boxing and unboxing?
   - value type: 
     - directly hold value
     - stored in the stack memory
     - not be collected by the garbage collector
     -  be created by struct or enum
     - can not accept any null value
   - reference variable: 
     -  hold the memory address or reference of the value
     -  stored in the heap memory
     - be collected by the garbage collector
     -  be created by class, interface, delegates or array.
     - can accept any null value 
   - boxing: an operation that converts a value type to the reference type(object type)
   - unboxing: an operation that converts a reference type(object type) to the value type

3. What is meant by the terms managed resource and unmanaged resource in .NET
   - managed resource: organized by garbage collector 
   - unmanaged resource: file transmission, db connection, etc; call Dispose() method of the IDisposable interface. 

4. Whats the purpose of Garbage Collector in .NET?
   - Garbage collector will divide the heap memory into three different generations: 0, 1 and 2
   - it can manage and clean the unused memory to release and reuse it

## Controlling Flow and Converting Types

1. What happens when you divide an int variable by 0?

   Error show up

2. What happens when you divide a double variable by 0?

   infinity

3. What happens when you overflow an int variable, that is, set it to a value beyond its
  range?

  go back to 0

4. What is the difference between x = y++; and x = ++y;?

   first one will get x = y; second one get x = y + 1

5. What is the difference between break, continue, and return when used inside a loop
  statement?

  - break: stop current loop
  - continue: stop current Iterating of the loop
  - return: stop current function and return a value

6. What are the three parts of a for statement and which of them are required?

   initialization, condition, iterator

   None of them are required

7. What is the difference between the = and == operators?

   = is assign value to variable; == is compare two values

8. Does the following statement compile? for ( ; true; ) ;

   yes

9. What does the underscore _ represent in a switch expression?

   default statement

10. What interface must an object implement to be enumerated over by using the foreach
    statement?

    IEnumerable

## Array and String

1. When to use String vs. StringBuilder in C# ?

   only create once use string; need to mortify string use StingBulider

2. What is the base class for all arrays in C#?

   object

3. How do you sort an array in C#?

   Array.Sort();

4. What property of an array object can be used to get the total number of elements in
  an array?

  Length

5. Can you store multiple data types in System.Array?

   No

6. What’s the difference between the System.Array.CopyTo() and System.Array.Clone()?

   CopyTo is create new array and let the element point to it; clone is create the array and element

   