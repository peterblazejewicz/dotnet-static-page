# .NET Core Static page

A project with static web content hosted with Kestrel:

- Angular based client application built to static page
- .NET Core static page web site
- .NET Core WebApi endpoint

## Description

Note that this version uses Dotnet 3 preview and Angular 8.

## Usage

```sh
dotnet restore
```

### Start Web API server

```sh
cd EndPointServer
dotnet run
```

### Build client application

```sh
cd ClientApp
npm i
npm run build
```

### Start static page server

```sh
cd StaticPage
dotnet run
```

## Author

@peterblazejewicz
