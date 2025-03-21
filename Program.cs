using Engine.Renderer;



namespace meet_21._03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Human human = new Human("Вася", "Петров", "Александрович");
            //Console.WriteLine(human.FIO());

            //Cat cat = new Cat("Пушок", 15.0, true);
            //cat.Name = null;
            //Console.WriteLine(cat.Name);
            //cat.Color = "серый";
            //Console.WriteLine(cat.Color);

            //Cat catic = new Cat("Пушок", 15.0, true );
            //Console.WriteLine(catic.GetInfo());

            //int a = 1;
            //ClassA classA = new ClassA();
            //classA.Add(ref a);
            //Console.WriteLine(a);

            //Engine.Phisics.Vector3D vector3D1 = new Engine.Phisics.Vector3D();
            //Vector3D vector3D = new Vector3D();

            //Laptop laptop = new Laptop("vaaaai", 12.9, 34.5, 22.4, 56.9);
            //Console.WriteLine(laptop.Info());

            Car car = new Car("dg", "sdgfjk", "dksjfo", 13, "белый");
            Console.WriteLine(car.Info);

            car.Compare("dg");
            car.Compare("dfpvk[pkdfv");


        }
    }
    //[модификатор доступа] struct [название] {} - нужны для того что бы хранить малое количество данных
    //конструктор по умолчаниею - конструктор без параметра в структуре есть всегда
    //инкапсуляция - разграничение данных
    //ref - ссылка
    //internal - доступно только в этом проекте

}
