# Getting started

## How to Build

The generated code uses a few NuGet Packages e.g., Newtonsoft.Json, UniRest,
and Microsoft Base Class Library. The reference to these packages is already
added as in the packages.config file. If the automatic NuGet package restore
is enabled, these dependencies will be installed automatically. Therefore,
you will need internet access for build.

1. Open the solution (HealthOS.sln) file.
2. Invoke the build process using `Ctrl+Shift+B` shortcut key or using the `Build` menu as shown below.

![Building SDK using Visual Studio](https://apidocs.io/illustration/cs?step=buildSDK&workspaceFolder=HealthOS-CSharp&workspaceName=HealthOS&projectName=HealthOS.PCL)

## How to Use

The build process generates a portable class library, which can be used like a normal class library. The generated library is compatible with Windows Forms, Windows RT, Windows Phone 8,
Silverlight 5, Xamarin iOS, Xamarin Android and Mono. More information on how to use can be found at the [MSDN Portable Class Libraries documentation](http://msdn.microsoft.com/en-us/library/vstudio/gg597391%28v=vs.100%29.aspx).

The following section explains how to use the HealthOS library in a new console project.

### 1. Starting a new project

For starting a new project, right click on the current solution from the *solution explorer* and choose  ``` Add -> New Project ```.

![Add a new project in the existing solution using Visual Studio](https://apidocs.io/illustration/cs?step=addProject&workspaceFolder=HealthOS-CSharp&workspaceName=HealthOS&projectName=HealthOS.PCL)

Next, choose "Console Application", provide a ``` TestConsoleProject ``` as the project name and click ``` OK ```.

![Create a new console project using Visual Studio](https://apidocs.io/illustration/cs?step=createProject&workspaceFolder=HealthOS-CSharp&workspaceName=HealthOS&projectName=HealthOS.PCL)

### 2. Set as startup project

The new console project is the entry point for the eventual execution. This requires us to set the ``` TestConsoleProject ``` as the start-up project. To do this, right-click on the  ``` TestConsoleProject ``` and choose  ``` Set as StartUp Project ``` form the context menu.

![Set the new cosole project as the start up project](https://apidocs.io/illustration/cs?step=setStartup&workspaceFolder=HealthOS-CSharp&workspaceName=HealthOS&projectName=HealthOS.PCL)

### 3. Add reference of the library project

In order to use the HealthOS library in the new project, first we must add a projet reference to the ``` TestConsoleProject ```. First, right click on the ``` References ``` node in the *solution explorer* and click ``` Add Reference... ```.

![Open references of the TestConsoleProject](https://apidocs.io/illustration/cs?step=addReference&workspaceFolder=HealthOS-CSharp&workspaceName=HealthOS&projectName=HealthOS.PCL)

Next, a window will be displayed where we must set the ``` checkbox ``` on ``` HealthOS.PCL ``` and click ``` OK ```. By doing this, we have added a reference of the ```HealthOS.PCL``` project into the new ``` TestConsoleProject ```.

![Add a reference to the TestConsoleProject](https://apidocs.io/illustration/cs?step=createReference&workspaceFolder=HealthOS-CSharp&workspaceName=HealthOS&projectName=HealthOS.PCL)

### 4. Write sample code

Once the ``` TestConsoleProject ``` is created, a file named ``` Program.cs ``` will be visible in the *solution explorer* with an empty ``` Main ``` method. This is the entry point for the execution of the entire solution.
Here, you can add code to initialize the client library and acquire the instance of a *Controller* class. Sample code to initialize the client library and using controller methods is given in the subsequent sections.

![Add a reference to the TestConsoleProject](https://apidocs.io/illustration/cs?step=addCode&workspaceFolder=HealthOS-CSharp&workspaceName=HealthOS&projectName=HealthOS.PCL)

## How to Test

The generated SDK also contain one or more Tests, which are contained in the Tests project.
In order to invoke these test cases, you will need *NUnit 3.0 Test Adapter Extension for Visual Studio*.
Once the SDK is complied, the test cases should appear in the Test Explorer window.
Here, you can click *Run All* to execute these test cases.

## Initialization

### Authentication
In order to setup authentication and initialization of the API client, you need the following information.

| Parameter | Description |
|-----------|-------------|
| host | TODO: add a description |
| oAuthAccessToken | The OAuth 2.0 access token to be set before API calls |



API client can be initialized as following.

```csharp
// Configuration parameters and credentials
string host = "host";
string oAuthAccessToken = "oAuthAccessToken"; // The OAuth 2.0 access token to be set before API calls

HealthOSClient client = new HealthOSClient(host, oAuthAccessToken);
```

## Class Reference

### <a name="list_of_controllers"></a>List of Controllers

* [MedicinesController](#medicines_controller)
* [LabTestsController](#lab_tests_controller)
* [GenericsController](#generics_controller)
* [FoodController](#food_controller)
* [ExercisesController](#exercises_controller)
* [DrugInteractionsController](#drug_interactions_controller)
* [DiseasesController](#diseases_controller)
* [ChatController](#chat_controller)
* [AutocompleteController](#autocomplete_controller)
* [AuthenticationController](#authentication_controller)

### <a name="medicines_controller"></a>![Class: ](https://apidocs.io/img/class.png "HealthOS.PCL.Controllers.MedicinesController") MedicinesController

#### Get singleton instance

The singleton instance of the ``` MedicinesController ``` class can be accessed from the API Client.

```csharp
MedicinesController medicines = client.Medicines;
```

#### <a name="get_manufacturer"></a>![Method: ](https://apidocs.io/img/method.png "HealthOS.PCL.Controllers.MedicinesController.GetManufacturer") GetManufacturer

> Get a manufacturer by its id


```csharp
Task<dynamic> GetManufacturer(string manufacturerId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| manufacturerId |  ``` Required ```  | Id of the manufacturer |


#### Example Usage

```csharp
string manufacturerId = "manufacturer_id";

dynamic result = await medicines.GetManufacturer(manufacturerId);

```


#### <a name="search_manufacturers"></a>![Method: ](https://apidocs.io/img/method.png "HealthOS.PCL.Controllers.MedicinesController.SearchManufacturers") SearchManufacturers

> Search a manufacturer by its name


```csharp
Task<dynamic> SearchManufacturers(string manufacturerQuery)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| manufacturerQuery |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string manufacturerQuery = "manufacturer_query";

dynamic result = await medicines.SearchManufacturers(manufacturerQuery);

```


#### <a name="get_common_side_effects"></a>![Method: ](https://apidocs.io/img/method.png "HealthOS.PCL.Controllers.MedicinesController.GetCommonSideEffects") GetCommonSideEffects

> Get common side effects of a medicine


```csharp
Task<dynamic> GetCommonSideEffects(string medicineId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| medicineId |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string medicineId = "medicine_id";

dynamic result = await medicines.GetCommonSideEffects(medicineId);

```


#### <a name="get_popular_usage"></a>![Method: ](https://apidocs.io/img/method.png "HealthOS.PCL.Controllers.MedicinesController.GetPopularUsage") GetPopularUsage

> Get popular usages of a medicine


```csharp
Task<dynamic> GetPopularUsage(string medicineId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| medicineId |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string medicineId = "medicine_id";

dynamic result = await medicines.GetPopularUsage(medicineId);

```


#### <a name="get_medicines_by_manufacturer"></a>![Method: ](https://apidocs.io/img/method.png "HealthOS.PCL.Controllers.MedicinesController.GetMedicinesByManufacturer") GetMedicinesByManufacturer

> Get medicines by a manufacturer


```csharp
Task<dynamic> GetMedicinesByManufacturer(int page, int size, string manufacturerId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| page |  ``` Required ```  | TODO: Add a parameter description |
| size |  ``` Required ```  | TODO: Add a parameter description |
| manufacturerId |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
int page = 0;
int size = 0;
string manufacturerId = "manufacturer_id";

dynamic result = await medicines.GetMedicinesByManufacturer(page, size, manufacturerId);

```


#### <a name="get_similar_medicines"></a>![Method: ](https://apidocs.io/img/method.png "HealthOS.PCL.Controllers.MedicinesController.GetSimilarMedicines") GetSimilarMedicines

> Get similar medicines


```csharp
Task<dynamic> GetSimilarMedicines(string medicineId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| medicineId |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string medicineId = "medicine_id";

dynamic result = await medicines.GetSimilarMedicines(medicineId);

```


#### <a name="get_medicine"></a>![Method: ](https://apidocs.io/img/method.png "HealthOS.PCL.Controllers.MedicinesController.GetMedicine") GetMedicine

> Get a medicine


```csharp
Task<dynamic> GetMedicine(string medicineId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| medicineId |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string medicineId = "medicine_id";

dynamic result = await medicines.GetMedicine(medicineId);

```


#### <a name="get_all_medicines"></a>![Method: ](https://apidocs.io/img/method.png "HealthOS.PCL.Controllers.MedicinesController.GetAllMedicines") GetAllMedicines

> Get all medicines


```csharp
Task<dynamic> GetAllMedicines(int page, int size)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| page |  ``` Required ```  | TODO: Add a parameter description |
| size |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
int page = 1;
int size = 10;

dynamic result = await medicines.GetAllMedicines(page, size);

```


#### <a name="search_medicines"></a>![Method: ](https://apidocs.io/img/method.png "HealthOS.PCL.Controllers.MedicinesController.SearchMedicines") SearchMedicines

> Search a medicine by name


```csharp
Task<dynamic> SearchMedicines(string medicineQuery)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| medicineQuery |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string medicineQuery = "medicine_query";

dynamic result = await medicines.SearchMedicines(medicineQuery);

```


#### <a name="get_all_manufacturers"></a>![Method: ](https://apidocs.io/img/method.png "HealthOS.PCL.Controllers.MedicinesController.GetAllManufacturers") GetAllManufacturers

> Get all manufacturers


```csharp
Task<dynamic> GetAllManufacturers(int page, int size)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| page |  ``` Required ```  | TODO: Add a parameter description |
| size |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
int page = 1;
int size = 10;

dynamic result = await medicines.GetAllManufacturers(page, size);

```


#### <a name="get_alternative_medicines"></a>![Method: ](https://apidocs.io/img/method.png "HealthOS.PCL.Controllers.MedicinesController.GetAlternativeMedicines") GetAlternativeMedicines

> Get substitutes of a medicine


```csharp
Task<dynamic> GetAlternativeMedicines(int page, int size, string medicineId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| page |  ``` Required ```  | TODO: Add a parameter description |
| size |  ``` Required ```  | TODO: Add a parameter description |
| medicineId |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
int page = 0;
int size = 0;
string medicineId = "medicine_id";

dynamic result = await medicines.GetAlternativeMedicines(page, size, medicineId);

```


[Back to List of Controllers](#list_of_controllers)

### <a name="lab_tests_controller"></a>![Class: ](https://apidocs.io/img/class.png "HealthOS.PCL.Controllers.LabTestsController") LabTestsController

#### Get singleton instance

The singleton instance of the ``` LabTestsController ``` class can be accessed from the API Client.

```csharp
LabTestsController labTests = client.LabTests;
```

#### <a name="get_lab_test"></a>![Method: ](https://apidocs.io/img/method.png "HealthOS.PCL.Controllers.LabTestsController.GetLabTest") GetLabTest

> Get labtest by id


```csharp
Task<dynamic> GetLabTest(string labTestId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| labTestId |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string labTestId = "lab_test_id";

dynamic result = await labTests.GetLabTest(labTestId);

```


#### <a name="get_all_lab_tests"></a>![Method: ](https://apidocs.io/img/method.png "HealthOS.PCL.Controllers.LabTestsController.GetAllLabTests") GetAllLabTests

> All Lab tests


```csharp
Task<dynamic> GetAllLabTests(int page, int size)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| page |  ``` Required ```  | TODO: Add a parameter description |
| size |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
int page = 0;
int size = 0;

dynamic result = await labTests.GetAllLabTests(page, size);

```


#### <a name="search_lab_tests"></a>![Method: ](https://apidocs.io/img/method.png "HealthOS.PCL.Controllers.LabTestsController.SearchLabTests") SearchLabTests

> Search a lab test by name


```csharp
Task<dynamic> SearchLabTests(string labTestQuery)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| labTestQuery |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string labTestQuery = "lab_test_query";

dynamic result = await labTests.SearchLabTests(labTestQuery);

```


[Back to List of Controllers](#list_of_controllers)

### <a name="generics_controller"></a>![Class: ](https://apidocs.io/img/class.png "HealthOS.PCL.Controllers.GenericsController") GenericsController

#### Get singleton instance

The singleton instance of the ``` GenericsController ``` class can be accessed from the API Client.

```csharp
GenericsController generics = client.Generics;
```

#### <a name="get_generic"></a>![Method: ](https://apidocs.io/img/method.png "HealthOS.PCL.Controllers.GenericsController.GetGeneric") GetGeneric

> Get a generic by id


```csharp
Task<dynamic> GetGeneric(string genericId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| genericId |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string genericId = "generic_id";

dynamic result = await generics.GetGeneric(genericId);

```


#### <a name="get_medicines_by_generic"></a>![Method: ](https://apidocs.io/img/method.png "HealthOS.PCL.Controllers.GenericsController.GetMedicinesByGeneric") GetMedicinesByGeneric

> Get medicines containing the generic


```csharp
Task<dynamic> GetMedicinesByGeneric(
        int page,
        int size,
        bool exclusive,
        string genericId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| page |  ``` Required ```  | TODO: Add a parameter description |
| size |  ``` Required ```  | TODO: Add a parameter description |
| exclusive |  ``` Required ```  | TODO: Add a parameter description |
| genericId |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
int page = 213;
int size = 213;
bool exclusive = true;
string genericId = "generic_id";

dynamic result = await generics.GetMedicinesByGeneric(page, size, exclusive, genericId);

```


#### <a name="get_all_generics"></a>![Method: ](https://apidocs.io/img/method.png "HealthOS.PCL.Controllers.GenericsController.GetAllGenerics") GetAllGenerics

> All generics


```csharp
Task<dynamic> GetAllGenerics(int page, int size)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| page |  ``` Required ```  | TODO: Add a parameter description |
| size |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
int page = 213;
int size = 213;

dynamic result = await generics.GetAllGenerics(page, size);

```


#### <a name="search_generics"></a>![Method: ](https://apidocs.io/img/method.png "HealthOS.PCL.Controllers.GenericsController.SearchGenerics") SearchGenerics

> Search a generic by name


```csharp
Task<dynamic> SearchGenerics(string genericQuery)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| genericQuery |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string genericQuery = "generic_query";

dynamic result = await generics.SearchGenerics(genericQuery);

```


[Back to List of Controllers](#list_of_controllers)

### <a name="food_controller"></a>![Class: ](https://apidocs.io/img/class.png "HealthOS.PCL.Controllers.FoodController") FoodController

#### Get singleton instance

The singleton instance of the ``` FoodController ``` class can be accessed from the API Client.

```csharp
FoodController food = client.Food;
```

#### <a name="search_food_restaurants"></a>![Method: ](https://apidocs.io/img/method.png "HealthOS.PCL.Controllers.FoodController.SearchFoodRestaurants") SearchFoodRestaurants

> TODO: Add Description


```csharp
Task<dynamic> SearchFoodRestaurants(string foodRestaurantQuery)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| foodRestaurantQuery |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string foodRestaurantQuery = "food_restaurant_query";

dynamic result = await food.SearchFoodRestaurants(foodRestaurantQuery);

```


#### <a name="get_all_food_brands"></a>![Method: ](https://apidocs.io/img/method.png "HealthOS.PCL.Controllers.FoodController.GetAllFoodBrands") GetAllFoodBrands

> TODO: Add Description


```csharp
Task<dynamic> GetAllFoodBrands(int page, int size)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| page |  ``` Required ```  | TODO: Add a parameter description |
| size |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
int page = 1;
int size = 10;

dynamic result = await food.GetAllFoodBrands(page, size);

```


#### <a name="get_food_items_by_restaurant"></a>![Method: ](https://apidocs.io/img/method.png "HealthOS.PCL.Controllers.FoodController.GetFoodItemsByRestaurant") GetFoodItemsByRestaurant

> TODO: Add Description


```csharp
Task<dynamic> GetFoodItemsByRestaurant(int page, int size, string foodRestaurantId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| page |  ``` Required ```  | TODO: Add a parameter description |
| size |  ``` Required ```  | TODO: Add a parameter description |
| foodRestaurantId |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
int page = 213;
int size = 213;
string foodRestaurantId = "food_restaurant_id";

dynamic result = await food.GetFoodItemsByRestaurant(page, size, foodRestaurantId);

```


#### <a name="search_food_brands"></a>![Method: ](https://apidocs.io/img/method.png "HealthOS.PCL.Controllers.FoodController.SearchFoodBrands") SearchFoodBrands

> TODO: Add Description


```csharp
Task<dynamic> SearchFoodBrands(string foodBrandQuery)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| foodBrandQuery |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string foodBrandQuery = "food_brand_query";

dynamic result = await food.SearchFoodBrands(foodBrandQuery);

```


#### <a name="get_food_item"></a>![Method: ](https://apidocs.io/img/method.png "HealthOS.PCL.Controllers.FoodController.GetFoodItem") GetFoodItem

> TODO: Add Description


```csharp
Task<dynamic> GetFoodItem(string foodItemId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| foodItemId |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string foodItemId = "food_item_id";

dynamic result = await food.GetFoodItem(foodItemId);

```


#### <a name="get_all_food_items"></a>![Method: ](https://apidocs.io/img/method.png "HealthOS.PCL.Controllers.FoodController.GetAllFoodItems") GetAllFoodItems

> TODO: Add Description


```csharp
Task<dynamic> GetAllFoodItems(int page, int size)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| page |  ``` Required ```  | TODO: Add a parameter description |
| size |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
int page = 213;
int size = 213;

dynamic result = await food.GetAllFoodItems(page, size);

```


#### <a name="search_food_items"></a>![Method: ](https://apidocs.io/img/method.png "HealthOS.PCL.Controllers.FoodController.SearchFoodItems") SearchFoodItems

> TODO: Add Description


```csharp
Task<dynamic> SearchFoodItems(string foodItemQuery)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| foodItemQuery |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string foodItemQuery = "food_item_query";

dynamic result = await food.SearchFoodItems(foodItemQuery);

```


#### <a name="get_all_food_restaurants"></a>![Method: ](https://apidocs.io/img/method.png "HealthOS.PCL.Controllers.FoodController.GetAllFoodRestaurants") GetAllFoodRestaurants

> TODO: Add Description


```csharp
Task<dynamic> GetAllFoodRestaurants(int page, int size)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| page |  ``` Required ```  | TODO: Add a parameter description |
| size |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
int page = 1;
int size = 10;

dynamic result = await food.GetAllFoodRestaurants(page, size);

```


#### <a name="get_food_items_by_brand"></a>![Method: ](https://apidocs.io/img/method.png "HealthOS.PCL.Controllers.FoodController.GetFoodItemsByBrand") GetFoodItemsByBrand

> TODO: Add Description


```csharp
Task<dynamic> GetFoodItemsByBrand(int page, int size, string foodBrandId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| page |  ``` Required ```  | TODO: Add a parameter description |
| size |  ``` Required ```  | TODO: Add a parameter description |
| foodBrandId |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
int page = 213;
int size = 213;
string foodBrandId = "food_brand_id";

dynamic result = await food.GetFoodItemsByBrand(page, size, foodBrandId);

```


[Back to List of Controllers](#list_of_controllers)

### <a name="exercises_controller"></a>![Class: ](https://apidocs.io/img/class.png "HealthOS.PCL.Controllers.ExercisesController") ExercisesController

#### Get singleton instance

The singleton instance of the ``` ExercisesController ``` class can be accessed from the API Client.

```csharp
ExercisesController exercises = client.Exercises;
```

#### <a name="get_exercise"></a>![Method: ](https://apidocs.io/img/method.png "HealthOS.PCL.Controllers.ExercisesController.GetExercise") GetExercise

> TODO: Add Description


```csharp
Task<dynamic> GetExercise(string exerciseId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| exerciseId |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string exerciseId = "exercise_id";

dynamic result = await exercises.GetExercise(exerciseId);

```


#### <a name="get_all_exercises"></a>![Method: ](https://apidocs.io/img/method.png "HealthOS.PCL.Controllers.ExercisesController.GetAllExercises") GetAllExercises

> TODO: Add Description


```csharp
Task<dynamic> GetAllExercises(int page, int size)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| page |  ``` Required ```  | TODO: Add a parameter description |
| size |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
int page = 1;
int size = 10;

dynamic result = await exercises.GetAllExercises(page, size);

```


#### <a name="search_exercises"></a>![Method: ](https://apidocs.io/img/method.png "HealthOS.PCL.Controllers.ExercisesController.SearchExercises") SearchExercises

> TODO: Add Description


```csharp
Task<dynamic> SearchExercises(string exerciseQuery)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| exerciseQuery |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string exerciseQuery = "exercise_query";

dynamic result = await exercises.SearchExercises(exerciseQuery);

```


[Back to List of Controllers](#list_of_controllers)

### <a name="drug_interactions_controller"></a>![Class: ](https://apidocs.io/img/class.png "HealthOS.PCL.Controllers.DrugInteractionsController") DrugInteractionsController

#### Get singleton instance

The singleton instance of the ``` DrugInteractionsController ``` class can be accessed from the API Client.

```csharp
DrugInteractionsController drugInteractions = client.DrugInteractions;
```

#### <a name="get_generics_interactions"></a>![Method: ](https://apidocs.io/img/method.png "HealthOS.PCL.Controllers.DrugInteractionsController.GetGenericsInteractions") GetGenericsInteractions

> TODO: Add Description


```csharp
Task<dynamic> GetGenericsInteractions(string genericId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| genericId |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string genericId = "generic_id";

dynamic result = await drugInteractions.GetGenericsInteractions(genericId);

```


#### <a name="get_medicine_interactions"></a>![Method: ](https://apidocs.io/img/method.png "HealthOS.PCL.Controllers.DrugInteractionsController.GetMedicineInteractions") GetMedicineInteractions

> TODO: Add Description


```csharp
Task<dynamic> GetMedicineInteractions(string medicineId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| medicineId |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string medicineId = "medicine_id";

dynamic result = await drugInteractions.GetMedicineInteractions(medicineId);

```


[Back to List of Controllers](#list_of_controllers)

### <a name="diseases_controller"></a>![Class: ](https://apidocs.io/img/class.png "HealthOS.PCL.Controllers.DiseasesController") DiseasesController

#### Get singleton instance

The singleton instance of the ``` DiseasesController ``` class can be accessed from the API Client.

```csharp
DiseasesController diseases = client.Diseases;
```

#### <a name="get_disease"></a>![Method: ](https://apidocs.io/img/method.png "HealthOS.PCL.Controllers.DiseasesController.GetDisease") GetDisease

> TODO: Add Description


```csharp
Task<dynamic> GetDisease(string diseaseId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| diseaseId |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string diseaseId = "disease_id";

dynamic result = await diseases.GetDisease(diseaseId);

```


#### <a name="get_all_diseases"></a>![Method: ](https://apidocs.io/img/method.png "HealthOS.PCL.Controllers.DiseasesController.GetAllDiseases") GetAllDiseases

> TODO: Add Description


```csharp
Task<dynamic> GetAllDiseases(int page, int size)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| page |  ``` Required ```  | TODO: Add a parameter description |
| size |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
int page = 1;
int size = 10;

dynamic result = await diseases.GetAllDiseases(page, size);

```


#### <a name="search_diseases"></a>![Method: ](https://apidocs.io/img/method.png "HealthOS.PCL.Controllers.DiseasesController.SearchDiseases") SearchDiseases

> TODO: Add Description


```csharp
Task<dynamic> SearchDiseases(string diseaseQuery)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| diseaseQuery |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string diseaseQuery = "disease_query";

dynamic result = await diseases.SearchDiseases(diseaseQuery);

```


[Back to List of Controllers](#list_of_controllers)

### <a name="chat_controller"></a>![Class: ](https://apidocs.io/img/class.png "HealthOS.PCL.Controllers.ChatController") ChatController

#### Get singleton instance

The singleton instance of the ``` ChatController ``` class can be accessed from the API Client.

```csharp
ChatController chat = client.Chat;
```

#### <a name="get_excercises_chat"></a>![Method: ](https://apidocs.io/img/method.png "HealthOS.PCL.Controllers.ChatController.GetExcercisesChat") GetExcercisesChat

> TODO: Add Description


```csharp
Task<dynamic> GetExcercisesChat()
```

#### Example Usage

```csharp

dynamic result = await chat.GetExcercisesChat();

```


#### <a name="get_food_items_chat"></a>![Method: ](https://apidocs.io/img/method.png "HealthOS.PCL.Controllers.ChatController.GetFoodItemsChat") GetFoodItemsChat

> TODO: Add Description


```csharp
Task<dynamic> GetFoodItemsChat()
```

#### Example Usage

```csharp

dynamic result = await chat.GetFoodItemsChat();

```


#### <a name="get_medicine_chat"></a>![Method: ](https://apidocs.io/img/method.png "HealthOS.PCL.Controllers.ChatController.GetMedicineChat") GetMedicineChat

> TODO: Add Description


```csharp
Task<dynamic> GetMedicineChat()
```

#### Example Usage

```csharp

dynamic result = await chat.GetMedicineChat();

```


[Back to List of Controllers](#list_of_controllers)

### <a name="autocomplete_controller"></a>![Class: ](https://apidocs.io/img/class.png "HealthOS.PCL.Controllers.AutocompleteController") AutocompleteController

#### Get singleton instance

The singleton instance of the ``` AutocompleteController ``` class can be accessed from the API Client.

```csharp
AutocompleteController autocomplete = client.Autocomplete;
```

#### <a name="get_exercises"></a>![Method: ](https://apidocs.io/img/method.png "HealthOS.PCL.Controllers.AutocompleteController.GetExercises") GetExercises

> TODO: Add Description


```csharp
Task<dynamic> GetExercises(string exerciseQuery)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| exerciseQuery |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string exerciseQuery = "exercise_query";

dynamic result = await autocomplete.GetExercises(exerciseQuery);

```


#### <a name="get_diseases"></a>![Method: ](https://apidocs.io/img/method.png "HealthOS.PCL.Controllers.AutocompleteController.GetDiseases") GetDiseases

> TODO: Add Description


```csharp
Task<dynamic> GetDiseases(string diseaseQuery)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| diseaseQuery |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string diseaseQuery = "disease_query";

dynamic result = await autocomplete.GetDiseases(diseaseQuery);

```


#### <a name="get_lab_tests"></a>![Method: ](https://apidocs.io/img/method.png "HealthOS.PCL.Controllers.AutocompleteController.GetLabTests") GetLabTests

> TODO: Add Description


```csharp
Task<dynamic> GetLabTests(string labTestQuery)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| labTestQuery |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string labTestQuery = "lab_test_query";

dynamic result = await autocomplete.GetLabTests(labTestQuery);

```


#### <a name="get_food_items"></a>![Method: ](https://apidocs.io/img/method.png "HealthOS.PCL.Controllers.AutocompleteController.GetFoodItems") GetFoodItems

> TODO: Add Description


```csharp
Task<dynamic> GetFoodItems(string foodItemQuery)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| foodItemQuery |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string foodItemQuery = "food_item_query";

dynamic result = await autocomplete.GetFoodItems(foodItemQuery);

```


#### <a name="get_generics"></a>![Method: ](https://apidocs.io/img/method.png "HealthOS.PCL.Controllers.AutocompleteController.GetGenerics") GetGenerics

> TODO: Add Description


```csharp
Task<dynamic> GetGenerics(string genericQuery)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| genericQuery |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string genericQuery = "generic_query";

dynamic result = await autocomplete.GetGenerics(genericQuery);

```


#### <a name="get_medicines"></a>![Method: ](https://apidocs.io/img/method.png "HealthOS.PCL.Controllers.AutocompleteController.GetMedicines") GetMedicines

> TODO: Add Description


```csharp
Task<dynamic> GetMedicines(string medicineQuery)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| medicineQuery |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string medicineQuery = "medicine_query";

dynamic result = await autocomplete.GetMedicines(medicineQuery);

```


[Back to List of Controllers](#list_of_controllers)

### <a name="authentication_controller"></a>![Class: ](https://apidocs.io/img/class.png "HealthOS.PCL.Controllers.AuthenticationController") AuthenticationController

#### Get singleton instance

The singleton instance of the ``` AuthenticationController ``` class can be accessed from the API Client.

```csharp
AuthenticationController authentication = client.Authentication;
```

#### <a name="create_request_access_token"></a>![Method: ](https://apidocs.io/img/method.png "HealthOS.PCL.Controllers.AuthenticationController.CreateRequestAccessToken") CreateRequestAccessToken

> *Tags:*  ``` Skips Authentication ``` 

> TODO: Add Description


```csharp
Task<dynamic> CreateRequestAccessToken(RequestAccessTokenRequest body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| body |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string bodyValue = "{\n  \"grant_type\": \"client_credentials\",\n  \"client_id\": \"{{client_id}}\",\n  \"client_secret\": \"{{client_secret}}\",\n  \"scope\": \"public read write\"\n}";
var body = Newtonsoft.Json.JsonConvert.DeserializeObject<RequestAccessTokenRequest>(bodyValue);

dynamic result = await authentication.CreateRequestAccessToken(body);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 401 | Unauthorized |


[Back to List of Controllers](#list_of_controllers)



