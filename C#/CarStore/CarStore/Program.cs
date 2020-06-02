using CarStore.model;
using System;
using System.Drawing;

namespace CarStore
{

    class Program
    {
        static void Main(string[] args)
        {
           
            Person shopOwner = new Person("Fred", 35, 10000);
            Person customer1 = new Person("Sabine", 32, 200000);
            Person customer2 = new Person("Herwig", 56, 15000);
            Store fredsGarage = new Store("Freds Garage", shopOwner, shopOwner.MoneyPouch);
            Car AudiA6 = new Car(model.Type.Coupee, "Audi A6",Producer.VW,2015,180,Color.Black,50_000,shopOwner);
            fredsGarage.ShowCars.Add(AudiA6);
            Car BmwM6 = new Car(model.Type.Cabrio, "BMW M6", Producer.BMW, 2013, 560, Color.Orange, 47_990, shopOwner);
            fredsGarage.ShowCars.Add(BmwM6);
            Car California = new Car(model.Type.Sport, "Ferrari California", Producer.Ferrari, 2010, 460, Color.Red, 119_000, shopOwner);
            fredsGarage.ShowCars.Add(California);
            Car Ghibli = new Car(model.Type.Coupee, "Maserati Ghibli", Producer.Maserati, 2020, 430, Color.Blue, 83_377, shopOwner);
            fredsGarage.ShowCars.Add(Ghibli);
            Car Panamera = new Car(model.Type.Sport, "Porsche Panamera", Producer.Porsche, 2020, 330, Color.Black, 124_000, shopOwner);
            fredsGarage.ShowCars.Add(Panamera);
            Car AMG = new Car(model.Type.Sport, "Mercedes-Benz C 63 AMG", Producer.MercedesBenz, 2020, 517, Color.AliceBlue, 179_000, shopOwner);
            fredsGarage.ShowCars.Add(AMG);


            foreach (Car car in fredsGarage.ShowCars)
            {
                Console.WriteLine(car.Brand + " , " + car.HP + " , " + car.Price + "€");
            }


        }
    }
}

