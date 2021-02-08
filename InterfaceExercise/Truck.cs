using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class Truck : IVehicle, ICompany
    {
        public string HasBed { get; set; } = "true";
        public string IsLifted { get; set; } = "true";
        public double EngineSize { get; set; } = 6.6;
        public string Make { get; set; } = "GMC";
        public string Model { get; set; } = "Duramax 2500 HD";
        public int SeatCount { get; set; } = 5;
        public string CompanyName { get; set; } = "General Motors";
        public string Motto { get; set; } = "Find new roads";
        public bool HasChangedGears { get; set; }
        public bool HasFourWheelDrive { get; set; } = true;
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Drive()
        {
            if (HasFourWheelDrive == true)
            {
                Console.WriteLine($"4 wheel drive {GetType().Name} now driving forward...");
            }
            else
            {
                Console.WriteLine($"{GetType().Name} now driving forward...");
            }

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


