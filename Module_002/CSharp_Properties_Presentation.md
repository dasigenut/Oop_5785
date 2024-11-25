
# C# Properties  
**A Guide to Encapsulation and Accessors**

---

## What Are Properties?  
- Properties in C# provide a mechanism to encapsulate fields.  
- Combine public data access with private fields.  
- Enable controlled access to data.  
- Enhance encapsulation and data validation.

---

## Key Components of Properties  
- **Get Accessor**: Retrieves the value of a property.  
- **Set Accessor**: Assigns a new value to a property.  
- **Backing Field**: Private variable storing the value.

---

## Basic Property Syntax  

```csharp
public class Example
{
    private int _field;
    public int Property
    {
        get { return _field; }
        set { _field = value; }
    }
}
```

---

## Auto-Implemented Properties  

- Simplifies syntax for properties without logic.  
- Example:  
  ```csharp
  public string Name { get; set; }
  ```  
- Includes automatic backing fields.

---

## Read-Only and Write-Only Properties  

- **Read-Only**: Only a getter, no setter.  
  ```csharp
  public int ReadOnlyProperty { get; } = 42;
  ```  
- **Write-Only**: Only a setter, no getter (rare).  
  ```csharp
  public int WriteOnlyProperty { set { _field = value; } }
  ```

---

## Validation in Setters  

- Add logic in the setter to validate or modify values.  
- Example:  
  ```csharp
  private int _age;
  public int Age
  {
      get { return _age; }
      set
      {
          if (value < 0) throw new ArgumentException("Age cannot be negative.");
          _age = value;
      }
  }
  ```

---

## Expression-Bodied Properties  

- Simplified syntax for simple getters and setters.  
- Example:  
  ```csharp
  public int Squared => _field * _field; // Read-only
  public int Value
  {
      get => _field;
      set => _field = value;
  }
  ```

---

## Static Properties  

- Belong to the class rather than an instance.  
- Shared across all objects of the class.  
- Example:  
  ```csharp
  public static int StaticProperty { get; set; }
  ```

---

## Access Modifiers in Properties  

- Set different access levels for getters and setters.  
- Example:  
  ```csharp
  public int LimitedAccess
  {
      get { return _field; }
      private set { _field = value; }
  }
  ```

---

## Summary  

- Properties encapsulate data and provide controlled access.  
- Types: Auto-implemented, Read-only, Write-only, Computed.  
- Use validation and access modifiers as needed.  
- Simplify syntax with expression-bodied properties.

---
