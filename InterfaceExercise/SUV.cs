using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise 
{
    public class SUV : IVehicle, ICompany
    {
        public string HasCargoSpace { get; set; } = "true";
        public string HasLiftGate { get; set; } = "true";
        public double EngineSize { get; set; } = 5.3;
        public string Make { get; set; } = "Chevy";
        public string Model { get; set; } = "Suburban";
        public int SeatCount { get; set; } = 6;
        public string CompanyName { get; set; } = "General Motors";
        public string Motto { get; set; } = "Finding new roads";
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


