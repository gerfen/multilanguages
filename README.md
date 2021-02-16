

# AKSoftware.Localization.MultiLanguages
[![Build Badge](https://aksoftware98.visualstudio.com/AkMultiLanguages/_apis/build/status/aksoftware98.multilanguages?branchName=master)](https://aksoftware98.visualstudio.com/AkMultiLanguages/_build/latest?definitionId=4&branchName=master)

![Nuget](https://img.shields.io/nuget/dt/AKSoftware.Localization.MultiLanguages?color=nuget&label=Nuget&style=plastic)

Build awesome .NET applications that supports more than 69+ languages with just a few lines of code, in addition to an easy translation tool that helps you translate all your content to any language you want with just one click
Could be used for all type of .NET Apps (Blazor, UWP, Xamarin, Windows, ASP.NET Core MVC, Razor Pages ....)
https://akmultilanguages.azurewebsites.net
Build with Love by Ahmad Mozaffar
http://ahmadmozaffar.net

## YouTube Session 
https://youtu.be/Xz68c8GBYz4

![Simple UI supports German](https://github.com/aksoftware98/multilanguages/blob/master/Example/BlazorWasmMultiLanguages/BlazorWasmMultiLanguages/wwwroot/German.png?raw=true)

![Blazor UI with Japanease](https://raw.githubusercontent.com/aksoftware98/multilanguages/master/Example/BlazorWasmMultiLanguages/BlazorWasmMultiLanguages/wwwroot/Japan.png)


# UWP Support in Version 5.0.0
Special thanks for the contributor [Michael Gerfen](https://github.com/gerfen) for updating the library to add support to the UWP.
This version contains a major update that adds support for a new package under the name AKSoftware.Localization.MultiLangauges.UWP you can install it from Nuget with the following command 

``` PS
Install-Package AKSoftware.Localization.MultiLangauges.UWP
``` 

# What's new in Version 5.0.0
In the latest version of the library because right it started to support UWP and not only Blazor a new interface and abstract type has been introduced that allows you to easily create a keys provider to fetch your keys not only from the embedded resources, also from any source you would like (External folder, FTP, Azure Blob Storage ...etc)
By default there is the ***EmbeddedResourceKeysProvider*** to fetch the files from the resources and you can create your own by inhereting from the interface ***IKeysProvider***
More about the implementation in the Wiki soon 

# Getting Started with Blazor
[Click here to get started with Blazor](https://github.com/aksoftware98/multilanguages/Blazor-configuration.md)

# Getting Started with UWP
[Click here to get started with Blazor](https://github.com/aksoftware98/multilanguages/Blazor-configuration.md)
Thanks for the awesome contributors 
<a href="https://github.com/aksoftware98/multilanguages/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=aksoftware98/multilanguages" />
</a>

<!--stackedit_data:
eyJoaXN0b3J5IjpbLTEyMDA5Nzg5NjQsLTE2NTkwNDAxOTksLT
E2NTExOTI2ODhdfQ==
-->