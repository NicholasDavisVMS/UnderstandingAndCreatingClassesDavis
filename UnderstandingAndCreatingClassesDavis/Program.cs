using System;

namespace UnderstandingAndCreatingClassesDavis
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //classes are a container of related methods
            //He oversimplified his explanation of classes in a previous video!
            //this lesson gives the 'full treatment'
            //THIS IS ONE OF THE MOST CHALLENGING CONCEPTS FOR A BEGINNER
            //everything in .net framework is a class or part of a class

            //We shall start with a application that works with cars, and keeping
            //inventory with them all

            //'myNewCar' is now an object, objects are not classes nor vice versa
            //The class is the blueprint, the object is createc from that blueprint
            //and you can create a number of objects all based on the same class
            //class = cookiecutter, object = cookie
            //Note: each object is distrinct from other objects based on the same class
            Car myNewCar = new Car();

            //the period is vital!!! It helps set the properties!!
            myNewCar.Make = "Oldsmobile";
            myNewCar.Model = "Cutlas Supreme";
            myNewCar.Year = 1986;
            myNewCar.Color = "Silver";
            //you can now retreive these values or reset them, and the object
            //can now use any of these values

            //how to get a value out of an object
            Console.WriteLine("{0} - {1} - {2}",
                              myNewCar.Make, myNewCar.Model, myNewCar.Color);

            //To use private helper method:
            //double marketValueOfCar = determineMarketValue(myNewCar);

            //This will print the car's value with a dollar amount with the ':C'
            Console.WriteLine("Car's value: {0:C}", myNewCar.DetermineMarketValue());

            Console.ReadLine();
            //Code that can set and get values of a property are calles "setters & getters"
            //Whenever you crate a custom class, you've created a custom data type
            //Therefore you can define method input parameters or return values from methods
            //using that new custom data type

            //Currently, your major experience with classes will be those that were
            //created by microsoft in the .net framework class library
            //And most of those will be more conceptual in nature, like a stream of data
            //or a span of time. Not like a tangible car, but something more conceptual in 
            //nature. "Object oriented analysis and design"-another lesson

            //A class is a data type similar to those we've been using at his point(string, int, datetime, etc)
            //Define the properites of the class and then create an instance of that class
            //and you can access the properties with the dot operator

            //MAILY UNDERSTAND HOW TO CREATE AND ACCESS PROPERTIES FROM A CLASS LIKE
            // IN THIS LESSON
        }

        private static double determineMarketValue (Car car) 
        {
            //The first Car is the data type we've defined, the second is the input parameter name

            double carValue = 100.00;

            //Someday i'll come to go online and look up the car's value
            //and retrieve its value into the carValue variable
            return carValue;

            //You can use your new class as a datatype ANYWHERE you typically use
            //data types in your code such as input parameters
            //ANOTHER WAY TO DETERMINE VALUE IS AT END OF CAR CLASS
        }

    }

    class Car
    {
        //tell it first what type of codeblock we're attempting to create
        //then a name.
        //What is defined here is the methods of this class, including properties and
        //other things
        //A property defines an attribute of a class
        //a method is a main body of code that typically represents something that
        // the class can do
        //a blue/gray highlight means you can replace something with own code
        // the tab switching does not work here on mac
        public string  Make
        {
            get;
            set;
        }
        public string Model
        {
            get;
            set;
        }
        public int Year
        {
            get;
            set;
        }   
        public string Color
        {
            get;
            set;
        }

        public double DetermineMarketValue()
        {
			double carValue = 100.00;

            if (this.Year > 1990)
            {
                carValue = 10000.0;
            }
            else
                carValue = 2000.0;
			return carValue;
            //the 'this.' helps get/set values of the current instance of the car class
            //don't have to use the 'this' key word, but it helps greatly
        }

    }


}
