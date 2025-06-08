

# Shopping Cart Calculator
The Shopping Cart Calculator is a .NET 9.0 application that processes shopping cart items from JSON input, calculating totals with support for taxes, imports, or item categories. It includes a main executable project and a separate xUnit test project for robust validation.

## Table of Contents
- [Features](#features)
- [Project Structure](#project-structure)
- [Prerequisites](#prerequisites)
- [Setup](#setup)
- [Running the Application](#running-the-application)
- [Running Tests](#running-tests)

## Features
- Parses JSON input to create shopping cart items with properties (Name, Price, Quantity, IsImported).
- Supports extensible logic for calculating totals, including taxes or category-based rules.
- Comprehensive unit tests (14 passing) using xUnit to validate JSON parsing and item categorization.
- Modular design with separate core and test projects for maintainability.

## Prerequisites
- .NET 9.0 SDK (stable version, e.g., `9.0.100`). Download from [https://dotnet.microsoft.com/download/dotnet/9.0](https://dotnet.microsoft.com/download/dotnet/9.0).
- A code editor (e.g., Visual Studio 2022, VS Code with C# extension).
- Git for cloning the repository.

## Setup
1.  **Clone the Repository:**
    ```bash
    git clone <repository-url>
    cd Shopping Cart Calculator
    ```
    *(Replace `<repository-url>` with the actual URL of your repository)*

2.  **Restore Dependencies:**
    ```bash
    dotnet restore
    ```

3.  **Build the Solution:**
    ```bash
    dotnet build
    ```

## Running the Application
1.  **Run the main application:**
    Change directory to the `Core` project:
    ```bash
    cd Core
    dotnet run --configuration Debug
    ```
    Or, from the solution root:
    ```bash
    dotnet run --project Core/ShoppingCartCalculator.csproj --configuration Debug
    ```

2.  **Expected Output:**
    - Currently outputs a placeholder message ("Shopping Cart Calculator").
    - Extend `Program.cs` to process JSON input or calculate cart totals as needed.

## Running Tests
1.  **Run all tests:**
    ```bash
    dotnet test ShoppingCartCalculator.Tests --configuration Debug --verbosity detailed
    ```

2.  **Generate test coverage report:**
    ```bash
    dotnet test ShoppingCartCalculator.Tests --configuration Debug /p:CollectCoverage=true
    ```

3.  **Expected Outcome:**
    - 14 tests should pass, validating JSON parsing and item categorization.
    - Address the `xUnit1012` warning in `ItemCategoryTests.cs` by replacing `null` with valid strings (e.g., "book") or using nullable types.