# Pquyquy.Domain

Pquyquy.Domain is a .NET library that forms part of the Pquyquy project group. It provides foundational properties and classes for the domain layer, specifically focusing on auditing capabilities. This project is necessary for Pquyquy.Persistence to function.

## Table of Contents

- [Installation](#installation)
- [Usage](#usage)
- [License](#license)

## Installation

Currently, the `Pquyquy.Domain` NuGet package is not available in the NuGet Gallery. You will need to download the project source code and generate the NuGet package locally. Follow these steps to get started:

   ```bash
   #1. Clone the repository or download the source code:
   git clone [URL]
   #2. Navigate to the project directory:
   cd Pquyquy.Domain
   #3. Restore dependencies and build the project
   dotnet restore
   dotnet build
   #4. Generate the NuGet package
   dotnet pack -c Release
   #5. The NuGet package (Pquyquy.Domain.[version].nupkg) will be generated in the bin/Release directory of the project. You can then reference this local package in your other projects as needed.
   ```

## Usage

Inheriting from AuditableEntity Base Classes (typically in classes models):
   
   ```csharp
   class [Name] : AuditableEntity or AuditableEntityId or AuditableEntityGuid
   ```

Available Base Classes:
- AuditableEntity: Basic auditing properties.
- AuditableEntityId: AuditableEntity + Auditing properties with an integer Id.
- AuditableEntityGuid: AuditableEntity + Auditing properties with a Guid Id.

## License

This project is licensed under the MIT License. 