


# Getting Started with UWP

Using the Nuget Package Manager install the AKSoftware.Localization.MultiLanguages package 
(Nuget Package Manager Console)
``` PS
Install-Package AKSoftware.Localization.MultiLanguages 
```
(Using dotNet CLI)
``` CLI
dotnet add package AKSoftware.Localization.MultiLanuages
```
**For UWP** additional package is required that helps managing the state of the component when changing the language 
(Nuget Package Manager Console)
``` PS
Install-Package AKSoftware.Localization.MultiLanguages.UWP 
```
(Using dotNet CLI)
``` CLI
dotnet add package AKSoftware.Localization.MultiLanuages.UWP
```
## Setting up resource files

The AKSoftware.Localization.MultiLanguages package ships with three ways of working with resource files:

* Embedded resource files
* External Resources files
	* Loaded from the UWP app's installation folder ([Windows.ApplicationModel.Package.Current.InstalledLocation](https://docs.microsoft.com/en-us/uwp/api/windows.applicationmodel.package.installedlocation))
	* Loaded from the UWP app's local folder ([ApplicationData.Current.LocalFolder](https://docs.microsoft.com/en-us/uwp/api/Windows.Storage.ApplicationData.LocalFolder))

### Embedded respource files

#### Create the Resources Folder

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
<!--stackedit_data:
eyJoaXN0b3J5IjpbMTkwNzQ3MTA3MCw3MzA5OTgxMTZdfQ==
-->