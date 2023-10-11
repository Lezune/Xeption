![Xeption](https://raw.githubusercontent.com/hassanhabib/Xeption/master/Xeption/Resources/git_logo.png)

[![.NET](https://github.com/hassanhabib/Xeption/actions/workflows/dotnet.yml/badge.svg)](https://github.com/hassanhabib/Xeption/actions/workflows/dotnet.yml)
[![Nuget](https://img.shields.io/nuget/v/Xeption)](https://www.nuget.org/packages/Xeption/)
[![The Standard - COMPLIANT](https://img.shields.io/badge/The_Standard-COMPLIANT-2ea44f)](https://github.com/hassanhabib/The-Standard)
[![The Standard](https://img.shields.io/github/v/release/hassanhabib/The-Standard?style=default&label=Standard%20Version&color=2ea44f)](https://github.com/hassanhabib/The-Standard)
[![The Standard Community](https://img.shields.io/discord/934130100008538142?color=%237289da&label=The%20Standard%20Community&logo=Discord)](https://discord.gg/vdPZ7hS52X)

# Xeption
A Better Exception for .NET

This simple library is engineered to expose a new API for the standard .NET `Exception` model to allow upserting a list of values against a key in the `Data` property of that very exception.

## The Purpose
The purpose of this library is to allow .NET engineers to easily collect errors for any given flow or attribute before throwing the exception.

This new API simplifies the process of appending and being able to access the `Data` aspect of any exception to collect errors at any point in time.

The key value implementation for the `Data` attribute should make it simpler for engineers to represent errors around the same issue, attribute or value such as validation errors easily without any additional work-around code.

## Standard-Promise
The most important fulfillment aspect in a Standard complaint system is aimed towards contributing to people, its evolution, and principles.
An organization that systematically honors an environment of learning, training, and sharing knowledge is an organization that learns from the past, makes calculated risks for the future, 
and brings everyone within it up to speed on the current state of things as honestly, rapidly, and efficiently as possible. 
 
We believe that everyone has the right to privacy, and will never do anything that could violate that right.
We are committed to writing ethical and responsible software, and will always strive to use our skills, coding, and systems for the good.
We believe that these beliefs will help to ensure that our software(s) are safe and secure and that it will never be used to harm or collect personal data for malicious purposes.
 
The Standard Community as a promise to you is in upholding these values.

## How to Use
To use Xeption; all you need to do is to inherit the `Xeption` model to your local Exception models as follows:

### Setup
```csharp
public class MyLocalException: Xeption
{
	// ...
}
```

### Adding Values
To add values to your `Xeption` inheriting class, you will need to call `.UpsertDataList(key, value)` API to add more values to the dictionary as follows:

```csharp
var myLocalException = new MyLocalException();
myLocalException.UpsertDataList(key: "MyKey", value: "MyValue");
```

### Throwing If Contains Errors
Xeption also provides the ability to throw the local exception iff the data dictionary contains values in it. You can simply call that API from your local instance as follows:

```csharp
myLocalException.ThrowIfContainsErrors();
```

### Native APIs
Xeption will maintain the native APIs for the `Exception` native class.

```csharp
var xeption = new Xeption();

var xeptionWithMessage = new Xeption(message: "Some Message");

var xeptionWithInnerException = new Xeption(
	message: "Some Message",
	innerException: someInnerException);

```

If you have any suggestions, comments or questions, please feel free to contact me on:

[Twitter](https://twitter.com/hassanrezkhabib)

[LinkedIn](https://www.linkedin.com/in/hassanrezkhabib/)

[E-Mail](mailto:hassanhabib@live.com)

### Important Notice
Special thanks to all the contributors, and a very special thanks to Mr. Hassan Habib and Mr. Christo du Toit for their 