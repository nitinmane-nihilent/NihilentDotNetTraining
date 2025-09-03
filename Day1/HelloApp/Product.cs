//Define a package, in Java we called it a package, in C# we call it a namespace, in angular it is module
//namespace represents something like module
//logical collection of .net types
//namespace is a container for classes and other types

namespace Catalog
{
    //Define a class
    public class Product
    {
        //Define properties
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        // private int stock;
        
        public void setName(string name)
        {
            this.Name = name;
        }

        public string getName()
        {
            return this.Name;
        }

//it is like constructor in angular, classname and method name should be same
//it is like __init__ in python

//constructor overloading : i.e. you can write more than one constructor in a class
// here we have two constructors,  

        //one is default constructor
        public Product()
        {
            this.Id = 0;
            this.Name = "Nitin";
            this.Price = 0.0;
        }
        //and another is parameterized constructor
        public Product(int id, string name, double price)
        {
            this.Id = id;
            this.Name = name;
            this.Price = price;
        }
    }
}

// you can import this namespace in other files using 'using' keyword
//i.e. using Catalog; in main file (Program.cs)
