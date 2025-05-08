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