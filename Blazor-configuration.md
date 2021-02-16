


# Getting Started with Blazor

For Nuget Package Manager install the package 
(Nuget Package Manager Console)
``` PS
Install-Package AKSoftware.Localization.MultiLanguages 
```
(Using dotNet CLI)
``` CLI
dotnet add package AKSoftware.Localization.MultiLanuages
```
**For Blazor** additional package is required that helps managing the state of the component when changing the language 
(Nuget Package Manager Console)
``` PS
Install-Package AKSoftware.Localization.MultiLanguages.Blazor 
```
(Using dotNet CLI)
``` CLI
dotnet add package AKSoftware.Localization.MultiLanuages.Blazor
```
## Create the Resources Folder

Inside your project create a folder called "Resources"
and inside it create a file called "*en-US.yml*" which is a YAML file 
then set your keywords inside the file like this 
``` YAML
    HelloWorld: Hello World
    Welcome: Welcome
    ...
```
> We chose YAML files because it's very light comparing it to XML or JSON and make the output dll very small, in addition to that it's much way faster in serialization and deserialization 

## Set the build action of the file to EmbeddedResource

Select the file in the Solution Explorer window and from the properties window set the build action property to "Embeded Resources"

## Translate the file

Visit the online translation tool on the following link 
https://akmultilanguages.azurewebsites.net

Go to translate app page

Upload your YAML file and click submit
All the languages will be available with just one click - install all the languages you want to support in your application 

## Import the files to the Resources folder

Import the files to the resources folder you have just created and set the build action property for them as Embedded Resources also 

## Coding time
### Blazor Demo:

Go to **program.cs** and register the Language Container Service in the Dependency Injection container
Import the library 
``` C#
    using AKSoftware.Localization.MultiLanguages
```

Register the service  
``` C#
    // Specify the assembly that has the langauges files, in this situation it's the current assembly 
    builder.Services.AddLanguageContainer<EmbeddedResourceKeysProvider>(Assembly.GetExecutingAssembly());
	// You can specify the default culture of the project like this 
    // builder.Services.AddLanguageContainer(Assembly.GetExecutingAssembly(), CultureInfo.GetCultureInfo("fr-Fr"));
``` 
**Note:**
If you don't specify a default culture the library will try to find the file that matches the culture of the current user, if it's not existing it will try to find any file that matches the same language, then if it's not there it will try to find the English file then the first file in the folder, otherwise it will throw an exception 


# Start dealing with components 
In the _imports.razor file make sure to add the following namespaces
``` C#
using AKSoftware.Localization.MultiLanguages
using AKSoftware.Localization.MultiLanguages.Blazor
```
With in your components that you want to localize inject the service 
``` C#
    @inject ILanguageContainerService  languageContainer
```
And start getting the values from your files just like this 
``` Razor
    <h1>@languageContainer.Keys["HelloWorld"]</h1>
```

And to be able to get the state updated for each component that contains localized text call the extension method in the OnInitialized or OnInitializedAsync overriden methods for each component as following 
``` C#
protected override void OnInitialized()
{
      // This will make the current component gets updated whenever you change the language of the application 
      languageContainer.InitLocalizedComponent(this);
}
```

## Change the language from the UI

You are able to change the language and choose any language you have added from the UI like this 
Inject the service in the component 
``` C#
        @inject ILanguageContainerService  languageContainer
```
Add a button and set the @onclick method
``` Razor
    <button   @onclick="SetFrench">French</button>
    @code
    {
	    void SetFrench()
	    {
		    languageContainer.SetLanguage(System.Globalization.CultureInfo.GetCultureInfo("fr-FR"));
	    }
    }
```

## Interpolation Feature 
Starting from version 4.0 now there is the ability to create dynamic values to replace their values at runtime using Interpolation feature:
Following you can see how to use this feature

Language File en-US:
```YAML
Welcome: Welcome {username} to our system {version}
```

In C# to replace the value of username and version parameters at runtime you can use the new indexer that allows to pass an object for with these values as following: 

```C#
_language["Welcome", new 
{
	Username = "aksoftware98",
	Version = "v4.0"
}]
```

## Check the Sample Folder
Check the sample project here to see how to develop a full Blazor WebAssembly project with storing the last selected language with more than 8 languages available for one UI:
[Full Blazor WASM Sample](https://github.com/aksoftware98/multilanguages/tree/master/src/BlazorAKLocalization)

<!--stackedit_data:
eyJoaXN0b3J5IjpbLTE5NjI5ODM5NjMsMTAyMDY4NDldfQ==
-->