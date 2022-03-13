using System;


namespace Task.Model
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("bmw", "md5", 6, 20);
            car.ShowInfo();

            car.Drive(6,3, 20); 



        }
    }
}
