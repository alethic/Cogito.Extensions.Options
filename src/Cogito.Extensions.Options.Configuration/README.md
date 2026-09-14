# Cogito.Extensions.Options.Configuration

Binds options types to configuration sections.

## Why

`services.Configure<T>(configuration.GetSection("..."))` is the standard line, and it puts the
section name in startup rather than next to the type it configures. These extensions are the
building block for moving that decision to the options type.

## Install

```shell
dotnet add package Cogito.Extensions.Options.Configuration
```

## Use

```csharp
services.Configure<ImportSettings>("Import");
```

The section is resolved from the `IConfiguration` in the container rather than one passed in, so the
call does not need configuration in scope.

See `Cogito.Extensions.Options.Configuration.Autofac` for the declarative form.

## License

MIT.
