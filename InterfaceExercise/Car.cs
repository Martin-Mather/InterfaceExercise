using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class Car : IVehicle, ICompany
    {
        public string HasTrunk { get; set; } = "true";
        public string IsLowToGround { get; set; } = "true";
        public double EngineSize { get; set; } = 2.6;
        public string Make { get; set; } = "Nissan";
        public string Model { get; set; } = "Skyline R34";
        public int SeatCount { get; set; } = 4;
        public string CompanyName { get; set; } = "Nissan Motor Company Ltd";
        public string Motto { get; set; } = "It's your turn to drive.";
        public bool HasChangedGears { get; set; }
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Drive()
        {
            Console.WriteLine($"{GetType().Name} now driving forward...");
        }

        public void Park()
        {
            if (HasChangedGears == true)
            {
                Console.WriteLine($"{GetType().Name} Now in park...");
                HasChangedGears = false;
            }
            else
            {
                Console.WriteLine("Can't park until we change gears");
            }

        }

        public void Reverse()
        {
            if (HasChangedGears == true)
            {
                Console.WriteLine($"{GetType().Name} now reversing...");
                HasChangedGears = false;
            }
            else
            {
                Console.WriteLine("Can't reverse until we change gears");
            }
        }



        public void ChangeGears(bool isChanged)
        {
            HasChangedGears = isChanged;
        }
    }
}






