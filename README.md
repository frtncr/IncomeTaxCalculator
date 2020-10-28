# IncomeTaxCalculator
A sample repo that applies strategy pattern while calculating the income tax

![example workflow name](https://github.com/frtncr/IncomeTaxCalculator/workflows/.NET%20Core/badge.svg)

Our directory structure is as seen below:

```
└── src
    ├── IncomeTaxCalculator
    │   ├── Contexts
    │   │   └── TaxCalculatorContext.cs
    │   ├── Controllers
    │   │   ├── HomeController.cs
    │   │   └── TaxCalculatorController.cs
    │   ├── IncomeTaxCalculator.csproj
    │   ├── Models
    │   │   └── TaxLevel.cs
    │   ├── Program.cs
    │   ├── Properties
    │   │   └── launchSettings.json
    │   ├── Services
    │   │   ├── ITaxCalculatorService.cs
    │   │   └── TaxCalculatorService.cs
    │   ├── Startup.cs
    │   ├── Strategies
    │   │   └── IncomeTax
    │   │       ├── BelgiumTaxCalculatorStrategy.cs
    │   │       ├── ITaxCalculatorStrategy.cs
    │   │       ├── TaxCalculatorStrategy.cs
    │   │       └── TurkeyTaxCalculatorStrategy.cs
    │   ├── appsettings.Development.json
    │   ├── appsettings.json
    │   └── dockerfile
    └── IncomeTaxCalculatorTest
        ├── HomeControllerTests.cs
        ├── IncomeTaxCalculatorTest.csproj
        ├── TaxCalculatorControllerTests.cs
        └── TaxCalculatorServiceTests.cs
```

> Run ```tree -I 'obj|bin'``` on parent of the src folder to get the directory output

Steps required to build/test/run our code not in the filesystem we have but in a container. We might have several reasons to use this approach and one particular reason would be that we'd like to try our code against a different version of SDK and we feel lazy to create a dockerfile. Couch potatoes, aren't we all?

Run the command in the parent of the **/src** folder.

```
docker run -it -p 8089:5000 -v $(pwd):/app -w "/app" mcr.microsoft.com/dotnet/core/sdk:3.1 /bin/bash
```

```
docker run -it -p 8089:5000 -v $(pwd):/app -w "/app" mcr.microsoft.com/dotnet/core/sdk:3.1.201-alpine /bin/sh
```

>The difference between docker run commands is that the latter uses **alpine** image and it has no **/bin/bash** installed.

Now we are in the container so we can call dotnet commands like dotnet build, dotnet test, dotnet run

Get into the folder your .csproj is in and run dotnet run.

> Don't forget you've either set ```"applicationUrl": "http://+:5000"``` in launchSettings.json or run application by following ```dotnet run --urls="http://+:5000"```

