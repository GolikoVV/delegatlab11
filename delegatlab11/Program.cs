class Program
{
    static void Main(string[] args)
    {
        MathExpressions expr = new MathExpressions();
        double result = 10.0;

        for (int i = 0; i < 3; i++)
        {
            foreach (var method in expr.Methods)
            {
                result = method(result);
                Console.WriteLine($"Result after {method.Method.Name}: {result}");
            }
        }
    }
}

/* В методе Main создается экземпляр класса MathExpressions и переменная result с начальным значением 10. 
 * Затем происходит последовательный вызов методов из массива делегатов, используя значение result в качестве параметра ввода. 
 * Результат каждого вычисления выводится в консоль. 
 * В данном примере это происходит три раза, чтобы продемонстрировать повторное использование делегатов.
 * 
 */