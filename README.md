#Getting started

## How to Build

The generated code uses a few NuGet Packages e.g., Newtonsoft.Json, UniRest,
and Microsoft Base Class Library. The reference to these packages is already
added as in the packages.config file. If the automatic NuGet package restore
is enabled, these dependencies will be installed automatically. Therefore,
you will need internet access for build.

1. Open the solution (APIMATICCalculatorTestcases.sln) file.
2. Invoke the build process using `Ctrl+Shift+B` shortcut key or using the `Build` menu as shown below.

![Building SDK using Visual Studio](http://apidocs.io/illustration/cs?step=buildSDK&workspaceFolder=APIMATIC%20Calculator%20Testcases-CSharp&workspaceName=APIMATICCalculatorTestcases&projectName=APIMATICCalculatorTestcases.PCL)

## How to Use

The build process generates a portable class library, which can be used like a normal class library. The generated library is compatible with Windows Forms, Windows RT, Windows Phone 8,
Silverlight 5, Xamarin iOS, Xamarin Android and Mono. More information on how to use can be found at the [MSDN Portable Class Libraries documentation](http://msdn.microsoft.com/en-us/library/vstudio/gg597391%28v=vs.100%29.aspx).

The following section explains how to use the APIMATICCalculatorTestcases library in a new console project.

### 1. Starting a new project

For starting a new project, right click on the current solution from the *solution explorer* and choose  ``` Add -> New Project ```.

![Add a new project in the existing solution using Visual Studio](http://apidocs.io/illustration/cs?step=addProject&workspaceFolder=APIMATIC%20Calculator%20Testcases-CSharp&workspaceName=APIMATICCalculatorTestcases&projectName=APIMATICCalculatorTestcases.PCL)

Next, choose "Console Application", provide a ``` TestConsoleProject ``` as the project name and click ``` OK ```.

![Create a new console project using Visual Studio](http://apidocs.io/illustration/cs?step=createProject&workspaceFolder=APIMATIC%20Calculator%20Testcases-CSharp&workspaceName=APIMATICCalculatorTestcases&projectName=APIMATICCalculatorTestcases.PCL)

### 2. Set as startup project

The new console project is the entry point for the eventual execution. This requires us to set the ``` TestConsoleProject ``` as the start-up project. To do this, right-click on the  ``` TestConsoleProject ``` and choose  ``` Set as StartUp Project ``` form the context menu.

![Set the new cosole project as the start up project](http://apidocs.io/illustration/cs?step=setStartup&workspaceFolder=APIMATIC%20Calculator%20Testcases-CSharp&workspaceName=APIMATICCalculatorTestcases&projectName=APIMATICCalculatorTestcases.PCL)

### 3. Add reference of the library project

In order to use the APIMATICCalculatorTestcases library in the new project, first we must add a projet reference to the ``` TestConsoleProject ```. First, right click on the ``` References ``` node in the *solution explorer* and click ``` Add Reference... ```.

![Open references of the TestConsoleProject](http://apidocs.io/illustration/cs?step=addReference&workspaceFolder=APIMATIC%20Calculator%20Testcases-CSharp&workspaceName=APIMATICCalculatorTestcases&projectName=APIMATICCalculatorTestcases.PCL)

Next, a window will be displayed where we must set the ``` checkbox ``` on ``` APIMATICCalculatorTestcases.PCL ``` and click ``` OK ```. By doing this, we have added a reference of the ```APIMATICCalculatorTestcases.PCL``` project into the new ``` TestConsoleProject ```.

![Add a reference to the TestConsoleProject](http://apidocs.io/illustration/cs?step=createReference&workspaceFolder=APIMATIC%20Calculator%20Testcases-CSharp&workspaceName=APIMATICCalculatorTestcases&projectName=APIMATICCalculatorTestcases.PCL)

### 4. Write sample code

Once the ``` TestConsoleProject ``` is created, a file named ``` Program.cs ``` will be visible in the *solution explorer* with an empty ``` Main ``` method. This is the entry point for the execution of the entire solution.
Here, you can add code to initialize the client library and acquire the instance of a *Controller* class. Sample code to initialize the client library and using controller methods is given in the subsequent sections.

![Add a reference to the TestConsoleProject](http://apidocs.io/illustration/cs?step=addCode&workspaceFolder=APIMATIC%20Calculator%20Testcases-CSharp&workspaceName=APIMATICCalculatorTestcases&projectName=APIMATICCalculatorTestcases.PCL)

## How to Test

The generated SDK also contain one or more Tests, which are contained in the Tests project.
In order to invoke these test cases, you will need *NUnit 3.0 Test Adapter Extension for Visual Studio*.
Once the SDK is complied, the test cases should appear in the Test Explorer window.
Here, you can click *Run All* to execute these test cases.

## Initialization

### Authentication and 
In order to setup authentication and initialization of the API client, you need the following information.

| Parameter | Description |
|-----------|-------------|
| basicAuthUserName | The username to use with basic authentication |
| basicAuthPassword | The password to use with basic authentication |



API client can be initialized as following.

```csharp
// Configuration parameters and credentials
string basicAuthUserName = "basicAuthUserName"; // The username to use with basic authentication
string basicAuthPassword = "basicAuthPassword"; // The password to use with basic authentication

APIMATICCalculatorTestcasesClient client = new APIMATICCalculatorTestcasesClient(basicAuthUserName, basicAuthPassword);
```

## Class Reference

### <a name="list_of_controllers"></a>List of Controllers

* [SimpleCalculatorController](#simple_calculator_controller)

### <a name="simple_calculator_controller"></a>![Class: ](http://apidocs.io/img/class.png "APIMATICCalculatorTestcases.PCL.Controllers.SimpleCalculatorController") SimpleCalculatorController

#### Get singleton instance

The singleton instance of the ``` SimpleCalculatorController ``` class can be accessed from the API Client.

```csharp
SimpleCalculatorController simpleCalculator = client.SimpleCalculator;
```

#### <a name="get_calculate"></a>![Method: ](http://apidocs.io/img/method.png "APIMATICCalculatorTestcases.PCL.Controllers.SimpleCalculatorController.GetCalculate") GetCalculate

> Calculates the expression using the specified operation.


```csharp
Task<string> GetCalculate(GetCalculateInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| operation |  ``` Required ```  | The operator to apply on the variables |
| x |  ``` Required ```  | The LHS value |
| y |  ``` Required ```  | The RHS value |


#### Example Usage

```csharp
GetCalculateInput collect = new GetCalculateInput();

string operation = "SUM";
collect.Operation = operation;

double x = 5;
collect.X = x;

double y = 5;
collect.Y = y;


string result = await simpleCalculator.GetCalculate(collect);

```


[Back to List of Controllers](#list_of_controllers)



