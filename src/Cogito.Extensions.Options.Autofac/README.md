# Cogito.Extensions.Options.Autofac

Makes `IOptions<T>`, `IOptionsSnapshot<T>` and `IOptionsMonitor<T>` resolvable from an Autofac
container.

## Why

The options types are open generics resolved per closed type, which a container has to be told about.
Without it, taking an `IOptions<MySettings>` dependency fails at resolution even though the options
themselves are registered.

## Install

```shell
dotnet add package Cogito.Extensions.Options.Autofac
```

## Use

```csharp
builder.RegisterAllAssemblyModules();
```

then depend on options as usual:

```csharp
public class Importer
{
    public Importer(IOptions<ImportSettings> options) { ... }
}
```

## License

MIT.
