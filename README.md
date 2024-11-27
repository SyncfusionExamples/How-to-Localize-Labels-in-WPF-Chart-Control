# How to Localize Labels in WPF Chart Control

Localization of the [**WPF Chart**](https://www.syncfusion.com/wpf-controls/charts) can be customized by using the [**CurrentUICulture**](https://learn.microsoft.com/en-us/dotnet/api/system.globalization.cultureinfo.currentuiculture?view=netcore-3.1) property in the WPF Chart. You can change the language by assigning the culture name of the desired language to this property.

## Set Current UI Culture to the Application
 
 ```
public MainWindow()
{
    InitializeComponent();
    System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("fr-FR");
} 
 ```


## Steps to localize based on CurrentUICulture using Resource files

1.	Create new folder, named as Resources in the application.
2.	Add the default resource file of Chart into Resources folder (Syncfusion.SfChart.WPF.resx).
 
 ![Add_Default_Folder.png](https://support.syncfusion.com/kb/agent/attachment/article/18165/inline?token=eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6IjMyNTEwIiwib3JnaWQiOiIzIiwiaXNzIjoic3VwcG9ydC5zeW5jZnVzaW9uLmNvbSJ9.PRnjBmQYSMT_kThqqZYolBc2n9L2o-hKhoGHBHMSNzc)

3.	Right-click on the Resources folder, select Add, and then click New Item. In the Add New Item dialog, select the Resource File option and name the file as `Syncfusion.SfChart.WPF.<culture name>.resx`. For example, name it as `Syncfusion.SfChart.WPF.fr-FR.resx` to add localization support for the French language.

 ![Add_Localization_Resource_File.png](https://support.syncfusion.com/kb/agent/attachment/article/18165/inline?token=eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6IjMyNTExIiwib3JnaWQiOiIzIiwiaXNzIjoic3VwcG9ydC5zeW5jZnVzaW9uLmNvbSJ9.FcENlDMM3L40xbxMBMvdO_JF7UDWFGGnyXKGL3Ank68)

4.	The culture name that indicates the name of language and country.
5.	Now, add the Name/Value pair in Resource Designer of Syncfusion.SfChart.WPF.fr-FR.resx file and change its corresponding value to the corresponding culture.

 ![Add_Localized_Value.png](https://support.syncfusion.com/kb/agent/attachment/article/18165/inline?token=eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6IjMyNTE0Iiwib3JnaWQiOiIzIiwiaXNzIjoic3VwcG9ydC5zeW5jZnVzaW9uLmNvbSJ9.7flN-Ic-sbPFkAJ4vf3ZK80ZqTZJ-cGUqI0LlyQB02k) 

The following image illustrates the WPF Chart successfully localized in the French language, displaying the changes applied through the provided localization steps.
 
 ## Output
 ![FinalOutput.png](https://support.syncfusion.com/kb/agent/attachment/article/18165/inline?token=eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6IjMyNTEzIiwib3JnaWQiOiIzIiwiaXNzIjoic3VwcG9ydC5zeW5jZnVzaW9uLmNvbSJ9.PE-DDVupHY9H6vfQ0kDSLqrpk9l7elAR9boMCecIj68)

## Troubleshooting

#### Path too long exception

If you are facing a path too long exception when building this example project, close Visual Studio and rename the repository to a shorter name before building the project.

For better understanding, we have attached the [GitHub project](https://github.com/SyncfusionExamples/How-to-Localize-Labels-in-WPF-Chart-Control) for your future reference.