 ![Flepper Logo](https://s26.postimg.org/u1hn213qh/frog_128.png)

Branch | status(windows) | status(unix) | coverage
---|---|---|---
| Master | [![Build status](https://ci.appveyor.com/api/projects/status/81gjbxxtwit9uqkx/branch/master?svg=true)](https://ci.appveyor.com/project/AlbertoMonteiro/flepper/branch/master) | [![Build Status](https://travis-ci.org/Flepper/flepper.svg?branch=master)](https://travis-ci.org/Flepper/flepper)| [![codecov](https://codecov.io/gh/Flepper/flepper/branch/master/graph/badge.svg)](https://codecov.io/gh/Flepper/flepper)
| Development | [![Build status](https://ci.appveyor.com/api/projects/status/81gjbxxtwit9uqkx/branch/development?svg=true)](https://ci.appveyor.com/project/AlbertoMonteiro/flepper/branch/development) | [![Build Status](https://travis-ci.org/Flepper/flepper.svg?branch=development)](https://travis-ci.org/Flepper/flepper)| [![codecov](https://codecov.io/gh/Flepper/flepper/branch/development/graph/badge.svg)](https://codecov.io/gh/Flepper/flepper)

> A SQL query builder that is flexible and fun to use!

Flepper is a library to facilitate some database interactions that we need to perform in our applications.
The initial idea of Flepper is to provide a query builder for writing SQL queries fluently, improving the readability of your code.

## Installing / Getting started

A quick introduction of the minimal setup you need to get a hello world up &
running.

Package Manager
```shell
Install-Package Flepper.QueryBuilder
```
.NET CLI
```shell
dotnet add package Flepper.QueryBuilder
```

After executing one of the commands above you will have the Flepper installed and ready to be used.

### More about

Access [Flepper Page](https://flepper.github.io/flepper/#) to learn more.

## Developing

Here's a brief intro about what a developer must do in order to start developing
the project further:

```shell
git clone https://github.com/Flepper/flepper
cd flepper/
dotnet restore
dotnet build
```

## Features
Functionality implemented
* Query Builder

### Database support
Currently supported databases
* MSSQL 2008 or greater

## Contributing

Hey, are you in the mood to contribute to Flepper? Then take a look at our file where it explains how to [contribute](https://github.com/Flepper/flepper/blob/development/CONTRIBUTING.md) and we love receiving feedback and pull requests.

## Licensing
"The code in this project is licensed under [MIT] license."

[MIT]:<https://github.com/Flepper/flepper/blob/development/LICENSE>
