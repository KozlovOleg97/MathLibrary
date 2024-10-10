# Документация по библиотеке MathLibrary

## Оглавление
- [Описание библиотеки](#описание-библиотеки)
- [Установка](#установка)
- [Использование](#использование)
  - [Создание фигур](#создание-фигур)
  - [Вычисление площади](#вычисление-площади)
  - [Проверка треугольника на прямоугольность](#проверка-треугольника-на-прямоугольность)
  - [Добавление фигуры](#добавление-фигуры)
- [Логгирование](#логгирование)
- [Примеры](#примеры)
- [Обработка исключений](#обработка-исключений)
- [Контакты](#контакты)

## Описание библиотеки
MathLibrary — это библиотека, предназначенная для вычисления площади геометрических фигур, таких как круги и треугольники. Библиотека поддерживает создание фигур с использованием различных параметров и предоставляет методы для расчета их площади.

## Установка
Для использования библиотеки MathLibrary добавьте ссылку на неё в ваш проект. Вы можете установить её через NuGet Package Manager:

```bash 
Install-Package MathLibrary
``` 

Или добавив следующую строку в ваш .csproj файл:

```
<PackageReference Include="MathLibrary" Version="1.0.0" />
```

## Использование

### Создание фигур
Для создания фигур используйте класс MathLibrary, который предоставляет методы для создания объектов Circle и Triangle.

Пример создания круга:
```csharp
using MathLibrary;

// Создание круга с радиусом 5
var circle = ShapeFactory.CreateShape("Circle", 5); // Радиус = 5
Console.WriteLine($"Площадь круга: {circle.CalculateArea()}");
```

Пример создания треугольника:
```csharp
var triangle = ShapeFactory.CreateShape("Triangle", 3, 4, 5); // Стороны = 3, 4, 5
```

### Вычисление площади
Каждая фигура имеет метод CalculateArea(), который возвращает площадь фигуры.

Пример вычисления площади круга:
```csharp
double circleArea = circle.CalculateArea(); // Площадь круга
Console.WriteLine($"Площадь круга: {circleArea}");
```

Пример вычисления площади треугольника:
```csharp
double triangleArea = triangle.CalculateArea(); // Площадь треугольника
Console.WriteLine($"Площадь треугольника: {triangleArea}");
```

### Проверка треугольника на прямоугольность
Для проверки, является ли треугольник прямоугольным, используйте метод IsRightTriangle():

```csharp
bool isRightTriangle = triangle.IsRightTriangle();
Console.WriteLine($"Треугольник прямоугольный: {isRightTriangle}");
```

### Добавление фигуры
Пример: Добавление новой фигуры (например, прямоугольника) потребует только 2 шага:

1) Реализацию нового класса в папке Models;
```csharp
public class Rectangle : IShape
{
    public double Width { get; }
    public double Height { get; }

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public double CalculateArea()
    {
        return Width * Height;
    }
}
```

2) Добавление метода в фабрику.
```csharp
public static IShape CreateRectangle(double width, double height)
{
    return new Rectangle(width, height);
}
```

## Логгирование
Логгирование в библиотеке осуществляется через класс Logger, который записывает сообщения об ошибках и других важных событиях. Убедитесь, что в вашей среде настроен вывод логов, чтобы иметь возможность отслеживать возможные проблемы.

## Примеры

Пример использования всей библиотеки:
```csharp
using MathLibrary;

class Program
{
    static void Main(string[] args)
    {
        // Создание круга
        var circle = ShapeFactory.CreateShape("Circle", 5);
        Console.WriteLine($"Площадь круга: {circle.CalculateArea()}");

        // Создание треугольника
        var triangle = ShapeFactory.CreateShape("Triangle", 3, 4, 5);
        Console.WriteLine($"Площадь треугольника: {triangle.CalculateArea()}");
        Console.WriteLine($"Треугольник прямоугольный: {triangle.IsRightTriangle()}");
    }
}
```

## Обработка исключений
При создании фигур и вычислении площади могут возникнуть исключения, например:
ArgumentException при некорректных параметрах для создания фигур (например, отрицательные значения сторон).

Убедитесь, что вы обрабатываете эти исключения в своем коде:
```csharp
try
{
    var invalidTriangle = ShapeFactory.CreateShape("Triangle", 1, 1, 10);
}
catch (ArgumentException ex)
{
    Console.WriteLine($"Ошибка: {ex.Message}");
}
```

## Контакты
Email: kozlovoleg2021@gmail.com
Telegram: https://t.me/Kozlov_Olezha












