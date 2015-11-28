# Missing static page template for ASP.NET 5

A missing static html page template for ASP.NET 5 for [StaticFiles middleware](https://github.com/aspnet/StaticFiles) and [Kestrel server](https://github.com/aspnet/KestrelHttpServer).

## Description

There is a set of official [ASP.NET 5 Templates](https://github.com/aspnet/Templates) which prodives starting points for most common ASP.NET 5 development scenarios. Strangely, it still misses static html page template like [HTML 5 Boilerplate](https://github.com/h5bp/html5-boilerplate).

This quick project provides such simple template, with the same features as could be found in related templates from [Base Templates source](https://github.com/aspnet/Templates/tree/dev/src/BaseTemplates).

## Usage

```
dnu restore

dnu build

dnx web
```

## Author
@peterblazejewicz