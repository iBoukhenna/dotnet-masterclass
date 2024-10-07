# Clean Classes and Methods

Writing clean classes and methods is fundamental to producing maintainable and understandable code. Code should be easy to read, with clarity and simplicity prioritized over complexity. This section outlines guidelines and best practices for structuring classes and methods in C#.

**Principles**:
- Code should be easily understood by humans—prioritize readability.
- Make it correct, make it clear, make it concise, and only then make it fast.
- Avoid creating complex "arrow code" structures; use guard clauses to exit early, making code flow simpler and clearer.

---

## Structure of a Class

A class in C# is a blueprint for creating objects and should be organized as follows:

- **Data Members**: Fields and properties that store data.
- **Function Members**: Methods and functions that define behavior.
- **Nested Types**: Other classes, interfaces, or enums defined within the class.

### Class Composition
A class typically includes:
1. **Signature**: The class name, access modifier, and any inheritance or interface implementation.
2. **Fields**: Variables that store data specific to the class.
3. **Properties**: Accessors and mutators to interact with data in a controlled manner.
4. **Constructors**: Special methods to initialize class instances.
5. **Methods**: Functions that perform actions or calculations.

---

## Naming Guidelines

Naming conventions are crucial for clarity and consistency in your code. Follow these guidelines when naming classes, methods, and other entities:

- **PascalCase**: Use PascalCase for class names, properties, methods, and other type names.
- **Nouns**: Use nouns for class names to represent entities or concepts.
- **Verbs**: Use verbs that indicate actions for method names.
- **Specific and Descriptive**: Class names should be specific, have a single responsibility, and avoid abbreviations.

### Method Naming
- Method names should indicate what they do. For example: `CalculateTotal()`, `GetUserDetails()`.
- Boolean methods should start with prefixes like `Is`, `Are`, `Was`, `Were`, etc., to indicate their purpose. For example: `IsValid()`, `AreConditionsMet()`.
- Methods should be designed to have constant time complexity (`O(1)`) for "Get" operations, if possible.

### File Organization
- Place each class in its own file.
- Arrange class members in the following order: fields, properties, and then methods.

---

## Methods and Functions

In C#, a method and a function are essentially the same thing—they define behavior and help organize functionality. Adhere to these practices:

- **Use Verbs for Names**: Use action-oriented names that describe what the method does.
- **Avoid Long Methods**: Methods should be concise and focused on a single task.
- **Guard Clauses**: Use guard clauses to handle invalid inputs or early exits to avoid deep nesting (e.g., `if` statements). This improves readability by reducing "arrow code".

---

## Using Static Classes

Use static classes for common code library components that do not require instantiation. Static classes should only contain static members and avoid storing state to ensure thread safety.

---

## Organizing with Namespaces

Namespaces help organize code by grouping related classes, interfaces, and other types.

- Follow the naming convention: `<Company>.<Technology>.<Feature>`.
- For example: `MyCompany.Core.Utilities`, `MyCompany.Web.Services`.
- Use namespaces to avoid name collisions and create logical separations within your application.

By following these conventions and guidelines, you can create clean, maintainable classes and methods that are easy to understand and modify over time.
