using System;
using System.Collections.Generic;
using System.Text;

namespace CarStore.model
{

     class SportCar : Car
    {
        public SportCar(Type type, string brand, Producer producer, int year, int hp, System.Drawing.Color color, decimal price, Person owner) : base(type,brand,producer,year,hp,color,price,owner)
        {
          
        }

    }
}
