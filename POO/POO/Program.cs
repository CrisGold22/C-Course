using System;
using POO;

//In this example, we will create a class called "Person" with properties for name and age.
// This class will have its own .cs file

Person person = new Person("John", 30, "123 Main St", "555-555-5555");
person.presentation(); // Call the presentation method to display the person's information

// Applying paradigm of POO
// 1. Inheritance
// Inheritance is a mechanism in OOP that allows a class to inherit properties and methods from another class.

// Creating a class called "Animal" and then creating a class called "Dog" that inherits from "Animal"
// There are 3 ways to do inheritance in C#: 

/*
1. Animal animal = new Animal();        
->  This creates an instance of the Animal class and then you can assing with a Dog object:
        animal = dogObject;
    The principal problem with this is that you can only use the methods of the Animal class, not the Dog class.
    
2. Animal dog = new Dog();
->  This creates an instance of the Dog class and then you can use the methods of the Dog class.
    With the previeus example, you can only use the methods of the Animal class, except you cast it to the Dog class
    if you want to use Dog's methods:
        ((Dog)dog).bark();

3. Dog dog = new Dog();
-> This creates an instace of the Dog class with all Animal's atributes and methods. 
   You can use the methods of the Animal class and the Dog class. This methods is the most used and recommended.
 */

//Using Animal class methods
Dog dog = new Dog(); // Create an instance of the Dog class

dog.Name = "Doki";
dog.Gender = "Male";
dog.greating(); // Call the greating method to display the dog's information   

//Now, using Dog class methods
dog.Age = 5;
dog.Race = "Labrador";

dog.bark(); // Call the bark method to make the dog bark

//2. Polymorphism
// Polymorphism is the ability of an object to take on many forms. In C#, this is achieved through method overriding.
Circle circle= new Circle("Red", 5); // Create an instance of the Square class
circle.printingColor(); // Call the printingColor method to display the square's color

Console.WriteLine("The perimeter and area of square are: {0} and {1} respectivily", circle.Perimeter(), circle.Area()); //Finally, using Cicle methods to calculate the perimeter and area of the circle