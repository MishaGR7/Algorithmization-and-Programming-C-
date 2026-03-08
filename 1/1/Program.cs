using System;
using System.Collections.Generic;
namespace CanDriver
{
    class Program
    {
        static void Main(string[] args)
        {
            var alice = new Person()
            {
                FullName = "Alice Doe",
                Age = 17,
                CanSeeBlueColor = true,
                CanSeeGreeColor = true,
                CanSeeRedColor = true
            };
            var bob = new Person()
            {
                FullName = "Bob Smith",
                Age = 17,
                CanSeeBlueColor = false,
                CanSeeGreeColor = true,
                CanSeeRedColor = true
            };
            var john = new Person
            {
                FullName = "John Doe",
                Age = 19,
                CanSeeRedColor = true,
                CanSeeGreeColor
            = true,
                CanSeeBlueColor = true
            };
            var people = new Person[] { alice, bob, john };
            var motorcycleTest = new MotorcycleDriverLicenceTest();
            var carTest = new CarDriverLicenceTest();
            var tests = new DriverLicenceTest[] { motorcycleTest, carTest };
            foreach (var person in people)
            {
                foreach (var test in tests)
                {
                    var canDrive = false;
                    try
                    {
                        test.Test(person);
                        canDrive = true;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"\"{person.FullName}\" can not drive \"{test.transportName}\" because of\"{ex.Message}\".");
                    }
                    if (canDrive)
                    {
                        Console.WriteLine($"\"{person.FullName}\" can drive \"{test.transportName}\".");
                    }
                }
            }
        }
    }
    class Person
    {
        public string FullName { get; set; }
        public int Age { get; set; }
        public bool CanSeeRedColor { get; set; }
        public bool CanSeeGreeColor { get; set; }
        public bool CanSeeBlueColor { get; set; }
    }
    abstract class DriverLicenceTest
    {
        public string transportName;
        protected List<FeatureTest> tests;
        protected DriverLicenceTest(string transportName)
        {
            this.transportName = transportName;
            this.tests = new List<FeatureTest>();
            this.tests.Add(new SightTest());
        }
        public void Test(Person person)
        {
            foreach (var test in this.tests)
            {
                test.Test(person);
            }
        }
    }
    class MotorcycleDriverLicenceTest : DriverLicenceTest
    {
        public MotorcycleDriverLicenceTest() : base("Motorcycle")
        {
            this.tests.Add(new AgeFeatureTest(16));
        }
    }
    class CarDriverLicenceTest : DriverLicenceTest
    {
        public CarDriverLicenceTest() : base("Car")
        {
            this.tests.Add(new AgeFeatureTest(18));
        }
    }
    abstract class FeatureTest
    {
        public abstract void Test(Person person);
    }
    class AgeFeatureTest : FeatureTest
    {
        private readonly int minimumAge;
        public AgeFeatureTest(int minimumAge)
        {
            this.minimumAge = minimumAge;
        }
        public override void Test(Person person)
        {
            if (person.Age < this.minimumAge)
            {
                throw new AgeException(this.minimumAge);
            }
        }
    }
    class SightTest : FeatureTest
    {
        public override void Test(Person person)
        {
            if (!person.CanSeeRedColor || !person.CanSeeGreeColor)
            {
                throw new DeuteranopiaColorblindnessException();
            }
            if (!person.CanSeeBlueColor)
            {
                throw new TritanopiaColorblindnessException();
            }
        }
    }
    public class AgeException : Exception
    {
        public AgeException(int age) : base($"Person must be older than {age}") { }
    }
    public class DeuteranopiaColorblindnessException : Exception
    {
        public DeuteranopiaColorblindnessException() : base("Person has Deuteranopia (Red-Greencolorblindness)") { }
}
    public class TritanopiaColorblindnessException : Exception
    {
        public TritanopiaColorblindnessException() : base("Person has Tritanopia colorblindness") { }
    }
}
