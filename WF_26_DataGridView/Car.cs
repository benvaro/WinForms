using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_26_DataGridView
{
    public class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public float Capacity { get; set; }
    }

    public class Garage : IEnumerable
    {
        List<Car> cars = null;
        public Garage()
        {
            cars = new List<Car>()
            {
                new Car{Brand="Audi", Model="R8", Capacity=3.5f},
                new Car{Brand="BMW", Model="X5", Capacity=4.0f},
                new Car{Brand="KIA", Model="Ceed", Capacity=1.6f},
                new Car{Brand="Skoda", Model="SuperB", Capacity=1.9f}
            };
        }
        public IEnumerator GetEnumerator()
        {
            return cars.GetEnumerator();
        }
    }
}
