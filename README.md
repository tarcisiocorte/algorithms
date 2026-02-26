# Algorithms

## Data Structures

it is algorithms to storage and organize data in the computer such way that will make easier to use these datas. When we implement these algorithms basically we are trying to organize data in the efficient manner.

## Array

Arrays are the simpliest data struture to store data. You can use array in order to store multiple data elements of the same type.
Keep in mind the arrays stored data sequentially and we can access it by index.

## Repository Structure

- `dotnet/`: existing C#/.NET solution and source code (`Tccp.Algorithm.sln`).
- `Python/`: Python project with equivalent algorithm implementations.

## Unit Tests

From repository root:
- Python: `python3 -m unittest discover -s Python/tests -t Python -v`
- .NET: `dotnet test dotnet/Tccp.Algorithm.Tests/Tccp.Algorithm.Tests.csproj`
