


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
	* Loaded from the UWP app's installation folder ([Windows.ApplicationModel.Package.Current.InstalledLocation[])
	* Loaded from the UWP app's local folder (ApplicationData.Current.LocalFolder)

<!--stackedit_data:
eyJoaXN0b3J5IjpbNDA4OTE5NjM5LDczMDk5ODExNl19
-->