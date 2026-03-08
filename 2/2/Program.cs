using System;
using System.Collections.Generic;
using System.Text;
namespace CanDriver
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Random randomNum = new Random();
            var alice = new Person()
            {
                FullName = "Аліса Доу",
                Age = 17,
                NumberOfMistakes = randomNum.Next(15, 20),
                CanSeeBlueColor = true,
                CanSeeGreeColor = true,
                CanSeeRedColor = true
            };
            var bob = new Person()
            {
                FullName = "Боб Сміт",
                Age = 17,
                NumberOfMistakes = randomNum.Next(17, 20),
                CanSeeBlueColor = false,
                CanSeeGreeColor = true,
                CanSeeRedColor = true
            };
            var john = new Person
            {
                FullName = "Роб Ален",
                Age = 19,
                NumberOfMistakes = randomNum.Next(16, 20),
                CanSeeRedColor = true,
                CanSeeGreeColor
            = true,
                CanSeeBlueColor = true
            };
            var jack = new Person
            {
                FullName = "Джон Сноу",
                Age = 21,
                NumberOfMistakes = randomNum.Next(10, 20),

                CanSeeRedColor = false,
                CanSeeGreeColor
            = true,
                CanSeeBlueColor = false
            };
            var taylor = new Person
            {
                FullName = "Тейлор Бері",
                Age = 20,
                NumberOfMistakes = randomNum.Next(17, 20),
                CanSeeRedColor = true,
                CanSeeGreeColor
            = true,
                CanSeeBlueColor = true
            };
            var alex = new Person
            {
                FullName = "Алекс Вайкс",
                Age = 16,
                NumberOfMistakes = randomNum.Next(17, 20),
                CanSeeRedColor = true,
                CanSeeGreeColor
            = true,
                CanSeeBlueColor = true
            };
            var people = new Person[] { alice, bob, john, jack, taylor, alex };
            var motorcycleTest = new MotorcycleDriverLicenceTest();
            var carTest = new CarDriverLicenceTest();
            var BTRTest = new BTRDriverLicenceTest();
            var tests = new DriverLicenceTest[] { motorcycleTest, carTest, BTRTest };
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
                        Console.WriteLine($"\"{person.FullName}\" не може водити \"{test.transportName}\" тому, що \"{ex.Message}\".");
                    }
                    if (canDrive)
                    {
                        Console.WriteLine($"\"{person.FullName}\" може водити \"{test.transportName}\".");
                        if (person.NumberOfMistakes < 18)
                        {
                            Console.WriteLine($"Кількість помилок: {20 - person.NumberOfMistakes}\nЕкзамен не скланено");
                        }
                        else { Console.WriteLine($"Кількість помилок: {20 - person.NumberOfMistakes}\nЕкзамен скланено"); }
                    }
                }
                Console.WriteLine();
            }
        }
    }
    class Person
    {
        public string FullName { get; set; }
        public int Age { get; set; }
        public int NumberOfMistakes { get; set; }
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
        public MotorcycleDriverLicenceTest() : base("Мотоцикл")
        {
            this.tests.Add(new AgeFeatureTest(16));
        }
    }
    class CarDriverLicenceTest : DriverLicenceTest
    {
        public CarDriverLicenceTest() : base("Автомобіль")
        {
            this.tests.Add(new AgeFeatureTest(18));
        }
    }
    class BTRDriverLicenceTest : DriverLicenceTest
    {
        public BTRDriverLicenceTest() : base("БТР")
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
        public AgeException(int age) : base($"Людина повинна бути старша {age}") { }
    }
    public class DeuteranopiaColorblindnessException : Exception
    {
        public DeuteranopiaColorblindnessException() : base("Людина має дейтеранопію (червоно-зелений дальтонізм)") { }
    }
    public class TritanopiaColorblindnessException : Exception
    {
        public TritanopiaColorblindnessException() : base("Людина має тританопічний дальтонізм") { }
    }
}
