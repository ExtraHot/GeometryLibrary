# GeometryLibrary

Это библиотека для работы с геометрическими фигурами. Она включает в себя классы для круга и треугольника с методами для вычисления площади и других свойств. В проекте также реализованы тесты с использованием NUnit.

## Установка

1. Клонируйте репозиторий на свой локальный компьютер:

    ```bash
    git clone https://your-repository-url.git
    ```

2. Перейдите в каталог проекта:

    ```bash
    cd GeometryLibrary
    ```

3. Для установки всех зависимостей используйте команду:

    ```bash
    dotnet restore
    ```

## Использование

### Работа с кругом

Чтобы создать объект круга и вычислить его площадь, используйте следующий код:

```csharp
using GeometryLibrary.Figures;

var circle = new Circle(5.0);
double area = circle.CalculateArea();
Console.WriteLine($"Площадь круга: {area}");

```

### Работа с треугольником

Для создания треугольника и вычисления его площади, а также проверки, является ли он прямоугольным, используйте следующий код:

```csharp
using GeometryLibrary.Figures;

var triangle = new Triangle(3.0, 4.0, 5.0);
double area = triangle.CalculateArea();
bool isRightAngled = triangle.IsRightAngled();

Console.WriteLine($"Площадь треугольника: {area}");
Console.WriteLine($"Треугольник прямоугольный: {isRightAngled}");

```

### Тесты

В проекте используются тесты с NUnit. Для их запуска выполните команду:

```bash
dotnet test
```

Тесты для кругов и треугольников проверяют правильность вычислений площади и проверки на прямоугольность треугольников.
Состав проекта

    GeometryLibrary — основной проект с классами для геометрических фигур.
    GeometryLibrary.Tests — проект с юнит-тестами, использующий NUnit для тестирования функциональности.

Зависимости

    .NET 8.0
    NUnit 3.13.3
    NUnit3TestAdapter 4.0.0
    Microsoft.NET.Test.Sdk 17.0.0


  ## Задачка на SQL 
  
```Sql
SELECT Products.ProductName, Categories.CategoryName
FROM Products
LEFT JOIN ProductCategories ON Products.ProductId = ProductCategories.ProductId
LEFT JOIN Categories ON ProductCategories.CategoryId = Categories.CategoryId
ORDER BY Products.ProductName, Categories.CategoryName;
```
