
# Exercises: C# Properties

## Exercise 1: Basic Properties  
Create a class `Person` with the following:  
- A private field `_name` of type `string`.  
- A property `Name` with:
  - A getter that returns `_name`.
  - A setter that assigns a value to `_name`.

Write a program to create an instance of `Person`, set its `Name`, and display it.

---

## Exercise 2: Auto-Implemented Properties  
Define a class `Book` with the following auto-implemented properties:  
- `Title` (string)  
- `Author` (string)  
- `Price` (double)  

Write a program to create a `Book` object, assign values to its properties, and display them.

---

## Exercise 3: Read-Only Properties  
Create a class `Circle` with:  
- A private field `_radius` (double).  
- A property `Radius` (double) that allows getting and setting the value.  
- A read-only property `Area` that calculates and returns the area of the circle (`π * radius^2`).  

Write a program to create a `Circle` object, set its `Radius`, and display its `Area`.

---

## Exercise 4: Validation in Setters  
Create a class `Student` with the following:  
- A private field `_age` (int).  
- A property `Age` (int) with:
  - A getter that returns `_age`.
  - A setter that ensures the age is non-negative. If a negative value is provided, it throws an `ArgumentException`.  

Write a program to test the `Student` class by setting both valid and invalid ages.

---

## Exercise 5: Expression-Bodied Properties  
Create a class `Rectangle` with:  
- Two auto-implemented properties `Length` and `Width` (double).  
- A read-only property `Perimeter` that calculates the perimeter (`2 * (Length + Width)`) using an expression-bodied property.  

Write a program to create a `Rectangle` object, assign values to its properties, and display its `Perimeter`.

---

## Exercise 6: Static Properties  
Create a class `Counter` with:  
- A static property `Count` (int) that keeps track of the number of instances created.  
- A constructor that increments `Count` each time a new object is created.  

Write a program to create multiple `Counter` objects and display the value of `Count`.

---

## Exercise 7: Access Modifiers  
Create a class `BankAccount` with:  
- A private field `_balance` (double).  
- A public property `Balance` with:
  - A public getter that returns `_balance`.
  - A private setter that allows modification only within the class.  
- A method `Deposit(double amount)` to add money to the balance using the private setter.  

Write a program to create a `BankAccount` object, deposit money, and display the balance.

---
