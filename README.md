# Cogito.Extensions.Options

[![Build](https://github.com/alethic/Cogito.Extensions.Options/actions/workflows/Cogito.Extensions.Options.yml/badge.svg)](https://github.com/alethic/Cogito.Extensions.Options/actions/workflows/Cogito.Extensions.Options.yml)

Binds options types to configuration sections declaratively, and makes them resolvable from Autofac.

## Packages

**[Cogito.Extensions.Options](https://www.nuget.org/packages/Cogito.Extensions.Options)** — Small additions to `Microsoft.Extensions.Options`.

**[Cogito.Extensions.Options.Autofac](https://www.nuget.org/packages/Cogito.Extensions.Options.Autofac)** — Makes `IOptions<T>`, `IOptionsSnapshot<T>` and `IOptionsMonitor<T>` resolvable from an Autofac container.

**[Cogito.Extensions.Options.Configuration](https://www.nuget.org/packages/Cogito.Extensions.Options.Configuration)** — Binds options types to configuration sections.

**[Cogito.Extensions.Options.Configuration.Autofac](https://www.nuget.org/packages/Cogito.Extensions.Options.Configuration.Autofac)** — Declare on an options type which configuration section it binds to.

Each package carries its own README with the detail; the links above go to nuget.org.

## Building

```shell
dotnet restore Cogito.Extensions.Options.sln
dotnet msbuild -p:Configuration=Release Cogito.Extensions.Options.dist.msbuildproj
```

Packages are staged into `dist/nuget` and test suites into `dist/tests`; run a suite with
`dotnet test -f <tfm> <path to its assembly>`.

## License

MIT — see [LICENSE](LICENSE).
