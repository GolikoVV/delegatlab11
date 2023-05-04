using System;

class MathExpressions
{
    public static double Add(double x) => x + 5.0;
    public static double Subtract(double x) => x - 2.5;
    public static double Multiply(double x) => x * 2.0;
    public static double Divide(double x) => x / 3.0;
    public static double Power(double x) => Math.Pow(x, 2.0);

    public delegate double MathDelegate(double x);

    public MathDelegate[] Methods { get; } = new MathDelegate[]
    {
        Add,
        Subtract,
        Multiply,
        Divide,
        Power
    };
}
/*
 В данном примере класс MathExpressions содержит методы для вычисления математических выражений 
и массив делегатов Methods, в котором хранятся ссылки на эти методы. В классе определен делегат MathDelegate, 
который принимает один параметр типа double и возвращает значение типа double.
 */