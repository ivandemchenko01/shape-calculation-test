# ShapeCalculation

Приветствую вас в проекте **ShapeCalculation** – библиотеке классов на C# для вычисления площади различных геометрических фигур, таких как круг и треугольник. Эта библиотека разработана с учетом расширяемости для легкого добавления новых фигур и включает в себя набор юнит-тестов для обеспечения корректности вычислений.

## Содержание

1. [Как использовать](#как-использовать)
2. [Добавление новых фигур](#добавление-новых-фигур)
3. [Unit-тестирование](#unit-тестирование)

## Как использовать

1. **Установка:**
   Скачайте или клонируйте репозиторий и добавьте **ShapeCalculation** в ваш проект.

2. **Пример использования:**

   ```csharp
   using ShapeCalculation.Interfaces;
   using ShapeCalculation.Shapes;
   
   // Вычисление площади круга
   var circle = new CircleShape(5);
   var circleArea = circle.CalculateArea();
   Console.WriteLine($"Площадь круга : {circleArea}");

   // Вычисление площади треугольника
   var triangle = new TriangleShape(3, 4, 5);
   Console.WriteLine($"Площадь треугольника : {triangle.CalculateArea()}");
   ```

## Добавление новых фигур

Вы можете легко добавить поддержку новых фигур, следуя этим шагам:
1. Создайте новый класс для фигуры в папке Shapes.
2. Реализуйте метод для вычисления площади внутри класса.

Пример :
```csharp
public class CustomShape : IShape
{
    public double CalculateArea()
    {
        throw new NotImplementedException();
    }
}
```

## Unit тестирование

Тестирование было сделано с использованием nUnit.
Проект с тестами называется **ShapeCalculation.Tests**
