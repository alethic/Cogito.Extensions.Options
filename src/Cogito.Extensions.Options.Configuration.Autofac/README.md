# Cogito.Extensions.Options.Configuration.Autofac

Declare on an options type which configuration section it binds to.

## Why

An options class and the section it reads belong together. Keeping the section name in startup means
every new options type edits the same file, and a rename splits the pair silently.

## Install

```shell
dotnet add package Cogito.Extensions.Options.Configuration.Autofac
```

## Use

```csharp
[RegisterOptions("Import")]
public class ImportSettings
{
    public string Directory { get; set; }
    public TimeSpan Interval { get; set; }
}
```

With module scanning in place the type is registered and bound, and `IOptions<ImportSettings>`
resolves with the section's values:

```csharp
builder.RegisterAllAssemblyModules();
```

`Configure` on the container builder is the imperative equivalent.

## License

MIT.
