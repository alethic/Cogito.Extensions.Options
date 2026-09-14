# Cogito.Extensions.Options

Small additions to `Microsoft.Extensions.Options`.

## Why

The options pattern assumes you register each options type explicitly at startup. These extensions
cover the cases the built-in `IServiceCollection` methods leave out.

## Install

```shell
dotnet add package Cogito.Extensions.Options
```

## See also

- `Cogito.Extensions.Options.Configuration` — bind options from `IConfiguration`.
- `Cogito.Extensions.Options.Autofac` — resolve `IOptions<T>` from an Autofac container.
- `Cogito.Extensions.Options.Configuration.Autofac` — declare the binding on the options type itself.

## License

MIT.
