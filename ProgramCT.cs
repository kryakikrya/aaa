using ConsoleApp4;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main()
        {
            Square a = new Square(10, 0, 0, 0, 0, 0, 0);
            Console.WriteLine(a.CountArea());
            ConvexQuadrilateral b = new ConvexQuadrilateral(10, 10, 10, 10, 90, 10, 10);
            Console.WriteLine(b.CountArea());
            Parallelogram c = new Parallelogram(10, 10, 10, 10, 10, 10, 10);
            Console.WriteLine(c.CountArea());
            Rhombus d = new Rhombus(10, 10, 10, 10, 10, 10, 10);
            Console.WriteLine(d.CountArea());
            Rectangle e = new Rectangle(10, 10, 10, 10, 10, 10, 10);
            Console.WriteLine(e.CountArea());
            RandomTetragon m = new RandomTetragon(10, 10, 10, 10, 10, 10, 10);
            Console.WriteLine(m.CountArea());
        }
    }
    abstract class Tetragon
    {
        protected float a;
        protected float b;
        protected float c;
        protected float d;
        protected float angle;
        protected float d1;
        protected float d2;

        protected Tetragon(float a, float b, float c, float d, float angle, float d1, float d2)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
            this.angle = angle;
            this.d1 = d1;
            this.d2 = d2;
        }

        public abstract float CountPerimeter();
        public abstract float CountArea();
    }
    internal class Square : Tetragon
    {

        public Square(float a, float b, float c, float d, float angle, float d1, float d2) : base(a, b, c, d, angle, d1, d2)
        {

        }
    public override float CountPerimeter()
    {
        return a * 4;
    }
    public override float CountArea()
    {
        return a * a;
    }
}
internal class ConvexQuadrilateral : Tetragon
{
    public ConvexQuadrilateral(float a, float b, float c, float d, float angle, float d1, float d2) : base(a, b, c, d, angle, d1, d2)
    {
    }

    public override float CountPerimeter()
    {
        return a + b + c + d;
    }
    public override float CountArea()
    {
            return d1 * d2 * MathF.Sin(angle * MathF.PI / 180) / 2;
    }
}
internal class Parallelogram : Tetragon
{
    public Parallelogram(float a, float b, float c, float d, float angle, float d1, float d2) : base(a, b, c, d, angle, d1, d2)
    {
    }
    public override float CountPerimeter()
    {
        return a + b + c + d;
    }
    public override float CountArea()
    {
        return d1 * d2 * MathF.Sin(angle * MathF.PI / 180) / 2;
    }
}
internal class Rhombus : Tetragon
{
    public Rhombus(float a, float b, float c, float d, float angle, float d1, float d2) : base(a, b, c, d, angle, d1, d2)
        {
    }
    public override float CountPerimeter()
    {
        return (a * 2) + (b * 2);
    }
    public override float CountArea()
    {
        return d1 * d2 / 2;
    }
}
internal class Rectangle : Tetragon
{
    public Rectangle(float a, float b, float c, float d, float angle, float d1, float d2) : base(a, b, c, d, angle, d1, d2)
    {
    }
    public override float CountPerimeter()
    {
        return (a * 2) + (b * 2);
    }
    public override float CountArea()
    {
        return a * b;
    }
}
internal class RandomTetragon : Tetragon
{
    public RandomTetragon(float a, float b, float c, float d, float angle, float d1, float d2) : base(a, b, c, d, angle, d1, d2)
    {
    }
    public override float CountPerimeter()
    {
        return a + b + c + d;
    }
    public override float CountArea()
    {
        return d1 * d2 * MathF.Sin(angle * MathF.PI / 180) / 2;
    }
}

}
//Задание на сегодня:

//Создайте базовый класс Tetragon (Четырехугольник), в котором есть:
//переменные:
//-сторона а
//- сторона b
//- угол между этими сторонами — angle

//Методы, доступные для переопределения:
//+float CountPerimeter()
//+ float CountArea()

//Реализуйте наследований для следующих сущностей:
//-Четырехугольник
//- Выпуклый четырехугольник
//- Параллелограмм
//- Ромб
//- Прямоугольник
//- Квадрат

//Минимум одна из сущностей в списке является наследником базового класса (класса Tetragon), другие могут наследоваться друг от друга по цепочке.
 
//Для каждой сущности переопределяйте методы расчета периметра и площади соответственно там, где это необходимо, или используйте реализацию базового класса этой сущности. 
 
//Для проверки работоспособности можете использовать посторонний класс, где проинициализируете по 1 экземпляру каждого класса и выведете логи с периметром и площадью каждой фигуры. При желании работу можно выполнить вне Unity.