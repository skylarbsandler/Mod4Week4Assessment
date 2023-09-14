# Week 4 Assessment

### Setup
* Fork and clone this repository
* Open your forked repo in Visual Studio.
* Complete the two exercises and the questions

## Exercise 1: Inheritance and Dependency Injection (8 points)

Open up `Program.cs` and run your program. It should run with no errors, if you get an error reach out to your instructor.

This exercise involves some refactoring and some new features.

**Step 1:** Currently there are two classess `Student` and `Teacher` that have a lot of repeated code between them. Create a new class `Person` that will be the base class. Then update `Student` and `Teacher` to be derived from `Person`. Include as much in your `Person` class as you can to keep your code DRY (Don't Repeat Yourself). 

**Testing Step 1:** Uncomment the code under "Step 1:" in the Main method. That code should now run without error.

**Step 2:** Implement a new class called `School` that uses dependency injection and takes in a list of people as a dependency. Implement a method called `ListBirthdays` in your school class that calls the `GetBirthday` method and prints to the console each student and teacher's birthday.

**Testing Step 2:** Uncomment the code under "Step 2:" in the Main method. That code should now run without error and output a bunch of names and birthdays.

Ungraded extra challenge: If you have time, improve the way the birthdays are output. Can you group them by month or by Student/Teacher?

### Exercise 2: Interfaces (4 points)
Open up `InterfacePractice.cs`. You should not need to run this file, you will just edit it.

**Step 1:** Take a look at the two classes `Car` and `Bicycle`. They both implement an interface called `InterfaceNameHere`. Replace all three uses of `InterfaceNameHere` with a fitting name for this interface.

**Step 2:** The interface has already been created for you on line 5. Fill in the details for any methods and/or properties that make sense based on the two classes implementing this interface.

## Questions (8 points)

Edit this file with your answers.

1. What are some of the benefits of using inheritance? (1 point)
    * Code reusability, easier to maintain as changes to the base class are automatically reflected in derived classes, 
	and improved organization by groupings related classes together in hierachical structure.
2. What might be some of the disadvantages of using inheritance? (1 point)
    * Tight coupling of base class and derived classes, increased complexity due to additional levels of abstraction, and 
	adds some challenges when it comes to testing

3. How would you describe the difference between the base class and the derived class when working with inheritance? (1 point)
	* The base class is the original class that is inherited from. The Derived class is the new class that inherits properties and methods from the base class.

4.  What happens if you define the same method in the parent class and the child class? (1 point)
	* When you define the same method in the child class as the parent class method, it will override the method. When you call the method on an instnace of the 
	child case, it will run the method defined in that child class. This is called method overriding.

5. In your own words, how would you define an Interface? (1 point)
    * An interface contains declarations of properties and methods. However, properties and methods in an interface are fully abstract, or do not contain a body. The properties and methods are assigned values 
	when a class implements an interface. Each class that implements the same interface can set its own values for the properties and build the methods as necessary for each class.

6. Does a class implementing an interface need to implement all of the methods in that interface? Why or why not? (1 point)
    * Yes. When a class implements an interface, it is required to fully adhere to the contract defined by that interface and provide implementations for all the methods declared in the interface.

7. Both Inheritance and Interfaces use the `:` symbol after a class name. If you're looking at a class, what's one thing that can help you determine if the class is implementing an interface of extending a base class? (1 point)
	* The convention is to start interface names with 'I' to easily identify what is an Interface.  

8. If asked in an interview, how would you describe the purpose of the IOC container in a .NET application? (1 point)
	* The IOC (Inversion of Control) container is responsibile for creating instances of classes and injecting dependency objects at run time, and then disposing of it.
	This is so classes do not have be concerned with creating or obtaining objects themselves. The IOC helps code have more flexiblity and maintainability.


## Rubric

This assessment has a total of 20 points.  A score of 15 or higher is a pass.

As a reminder, this assessment is for students and instructors to determine if there are any areas that need additional reinforcement!
