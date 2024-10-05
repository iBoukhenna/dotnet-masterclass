# Coding Conventions and Guidelines

Coding conventions are a set of guidelines for a specific programming language that recommend programming styles, practices, and methods for each aspect of a program written in that particular language. They promote consistency, readability, and maintainability across the codebase.

This document outlines the recommended coding conventions and guidelines for C# development.

---

## Naming Conventions

Naming conventions define the way you write the name of a variable, type, function, or any other entity. Consistent naming conventions improve code readability and make it easier to understand.

### PascalCase
- **Used for**: Class, record, struct, interfaces, positional records, and public members in C#.
- **Example**: `CustomerRecord`, `CalculateTotal()`, `IService`.

### camelCase
- **Used for**: Private and Internal fields, static variables (prefixed with `s_`), thread variables (prefixed with `t_`), Method parameters.
- **Example**: `customerName`, `s_totalAmount`, `t_threadId`.

### lowercase
- **Used for**: Reserved for certain keywords or language constructs.
- **Example**: `foreach`, `return`.

---

## Layout Conventions

Proper layout and spacing improve the readability and structure of the code.

- Use the default code editor settings.
- Write only one statement per line and one declaration per line.
- If continuation lines are not indented automatically, indent them manually.
- Add at least one blank line between property definitions and methods.
- Use parentheses to clarify expressions.

---

## Comment Conventions

Commenting is essential for explaining the purpose and functionality of code.

- Place comments on separate lines, not at the end of a line of code.
- Begin comment text with an uppercase letter and end with a period.
- Insert one space between the comment delimiter (`//`) and the comment text.
- Use XML documentation comments (`///`) for documenting methods, parameters, and output. This can generate API documentation and human-readable documents.

---

## Guidelines

### String Interpolation
- Use string interpolation (`$`) to concatenate short strings.
- Use string interpolation over `String.Format()` for simplicity and readability.

### StringBuilder
- Use a `StringBuilder` object to append strings in loops to avoid performance issues due to immutable strings.

### Implicitly Typed Local Variables
- Declare implicitly typed variables using the `var` keyword when the type is apparent.
- Prefer using `int` instead of unsigned types.

### Arrays
- Use concise syntax when initializing arrays in a single line.
- Use `var` for explicit instantiation of array types.

### Delegates, Func, and Action
- Use delegates to pass methods as arguments.
- Prefer `Func<>` and `Action<>` for defining delegates as they are easier to define, use less code, and are compatible throughout your code.

### new, Operators, and using
- Use the new `new()` syntax that does not require braces.
- Prefer short-circuit operators (`&&`, `||`) for logical conditions.
- Simplify resource management using the `using` statement.

### Object Initializers and static
- Use object initializers to simplify object creation.
- Be cautious with static members; always access static members through the class name.

---

## LINQ (Language INtegrated Query)

LINQ allows querying capabilities directly in your C# code, making it easy to perform operations on collections and data sources.

### LINQ Do's
- Use meaningful names for query variables.
- Use aliases and ensure property names of anonymous types are correctly capitalized (Pascal casing).
- Use implicit typing (`var`) in the declaration of query variables.
- Align query clauses under the `from` clause.
- Use the `where` clause before other query clauses to operate on a filtered set of data.
