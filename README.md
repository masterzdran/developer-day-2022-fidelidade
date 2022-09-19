# Developer Day 2022 @ Fidelidade

#Disclaimer
All code samples/snippets in this session are for demonstration purposes only and are intended to demonstrate programming tasks or scenarios or to demonstrate a particular program architecture.Do not use them in production code.

For production code, always consider applying the best software practices and designs and using static code analysis tools to improve your implementation.

#Don't call us, we'll call you!
This repository is an integrant part of the presentation  "Don't call us, 
 we'll call you", under the scope of Developer Day 2022, promoted by "Companhia de Seguros Fidelidade."

I want to reiterate the acknowledgment to Ana Ferreira and Rosa Mimoso and their unique and kind invitation to the organization, allowing me to do one fantastic session.

#Dependency Injection Demo
This solution is composed of four dotnet 6 APIs to demonstrate:
- Service Scopes Lifetime
- Simple service that validates Portuguese Document Number without dependency injection.
- Same service with dependency injection.
- Service Abstraction through dependency injection. 


#Credits

The document number validation library, are public nuget libraries provided by @masterzdran. The ones used are:
- DocumentNumber.Portugal.Nif.Validator - https://www.nuget.org/packages/DocumentNumber.Portugal.Nif.Validator
- DocumentNumber.Portugal.CitizenCard.Validator -  https://www.nuget.org/packages/DocumentNumber.Portugal.CitizenCard.Validator
- DocumentNumber.Portugal.Niss.Validator - https://www.nuget.org/packages/DocumentNumber.Portugal.Niss.Validator

There is a website that allow us to generate and validate portuguese document numbers. @masterzdran is also the maintainer of this open source project:
- Document Number Validation Website - https://app-dnv-dev.azurewebsites.net 