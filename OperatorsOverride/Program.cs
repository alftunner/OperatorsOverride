using OperatorsOverride;

Rectangle rectangle = new Rectangle{Width = 5, Height = 10};
Square square = new Square {Length = 7};

Rectangle rectSquare = square;
Console.WriteLine($"Неявное преобразование квадрата в прямоугольник {rectSquare}");

Square squareRect = (Square) rectangle;
Console.WriteLine($"Явное преобразование прямоугольника в квадрат {squareRect}");

int number = 5;
Square squareInt = number;
Console.WriteLine($"Неявное преобразование целого числа в квадрат {squareInt}");

number = (int) square;
Console.WriteLine($"Явное преобразование квадрата в целое число {number}");

