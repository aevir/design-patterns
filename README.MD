# DESIGN PATTERNS

## Behavioural Patterns
Behavioral Patterns are concerned with algorithms and the assignment of responsibilities between objects. 
Behavioral patterns describe not just patterns of objects or classes but also the patterns of communication between them.
___
### Chain Of Responsibility
The Chain of Responsibility pattern allows an object to pass a request along a chain of handlers. 
Upon receiving a request, each handler decides either to process the request or to pass it to the next handler in the chain. 
This pattern is useful for decoupling request senders and receivers.
>Example: Imagine a [customer support system](/Behavioural/ChainOfResponsibility.cs) where a customer's request is passed through multiple departments (like Technical, Billing, General) until it finds the right department that can handle it. 
Each department checks if it can handle the request. If it can, it does so; if it can't, it passes the request to the next department.
___
### Command
The Command design pattern turns a request into a stand-alone object containing all information about the request. 
This transformation allows you to parameterize methods with different requests, delay or queue a request's execution, and support undoable operations.
>Example: Imagine you have a [remote control](/Behavioural/Command.cs) (the invoker) that can be programmed to perform different actions (commands) on a TV (the receiver). 
Each button on the remote control is programmed with a command that encapsulates an action and its target (like turning the TV on or off). 
The remote control just needs to trigger the command without needing to know the implementation details of the action.
___
### Interpreter
The Interpreter design pattern is used to define a grammatical representation for a language and provide an interpreter to deal with this grammar. 
In simpler terms, it's used for understanding and executing commands given in a specific language, typically by converting them into a programmable form.
>Example: Imagine you're creating a [basic calculator](/Behavioural/Interpreter.cs) that can understand and perform simple mathematical expressions like addition. You input an expression, say "5 + 10", and the calculator interprets this expression and calculates the result. The Interpreter pattern in this scenario involves breaking down the expression into manageable parts (like numbers and the plus sign), understanding their individual meanings, and then processing them to produce the result. Each part of the expression and the process to interpret it fits into the structure provided by the Interpreter pattern.
___
### Iterator
The Iterator Pattern provides a way to access the elements of an aggregate object sequentially without exposing its underlying representation. It allows traversal of elements in a collection without understanding the low-level workings of the collection.
>Imagine a [bookshelf filled with books](/Behavioural/Iterator.cs). You want to read through the titles of all the books one by one. The Iterator pattern is like having a bookmark that keeps track of your place. As you move the bookmark, it takes you to the next book, allowing you to go through the entire bookshelf in an orderly manner. This pattern lets you go through the books without needing to know how they are stored on the bookshelf.
___
### Mediator
The Mediator Pattern reduces the direct communication between objects and forces them to collaborate only through a mediator object. 
This pattern is useful for reducing the coupling between classes and handling complex communication scenarios.
>Example: Imagine an [air traffic control system](/Behavioural/Mediator.cs) as the mediator. Each airplane (a colleague) communicates with the air traffic control tower (the mediator) rather than directly with other airplanes. 
The control tower manages how and when airplanes take off or land, reducing the complexity of communication among airplanes.
___
### Memento
The Memento Pattern allows capturing and externalizing an object's internal state so that the object can be restored to this state later. 
It's useful for implementing features like undo mechanisms in applications.
>Think of a [text editor](/Behavioural/Memento.cs) where you can write text and save its state. At any point, you can undo your changes and restore the text to a saved state. 
Here, each saved state is a 'memento', and the text editor is the 'originator' of the state.
___
### Observer
The Observer pattern defines a one-to-many dependency between objects so that when one object changes state, all its dependents are notified and updated automatically. 
This pattern is widely used for implementing distributed event handling systems, in "listener" scenarios.
>Imagine a [weather station](/Behavioural/Observer.cs) (the subject) that measures weather data and several display elements (observers), like a current condition display, a statistics display, etc. 
Whenever the weather station updates its measurements, all the display elements automatically update their content to reflect the latest data.
___
### State
The State Pattern is a behavioral design pattern that allows an object to alter its behavior when its internal state changes. 
This pattern encapsulates the state-based behaviors within state-specific classes, thus localizing state-specific behavior and separating responsibilities among different classes.
>Imagine a [traffic light at an intersection](/Behavioural/State.cs), which can be in one of several states: green, yellow, or red. The traffic light behaves differently depending on its state. 
For example, when it's green, cars can go; when it's yellow, cars should slow down; and when it's red, cars must stop. 
The State pattern encapsulates the behavior of the traffic light for each state in separate classes, allowing the traffic light to change its behavior based on its current state.
___
### Strategy
The Strategy pattern enables selecting an algorithm's behavior at runtime. 
By defining a family of algorithms, encapsulating each one, and making them interchangeable, the Strategy pattern lets the algorithm vary independently from the clients that use it. This pattern closely aligns with Dependency Injection.
>Imagine a [navigation app](/Behavioural/Strategy.cs) that can calculate the route between two points. The app can use different strategies for calculating the route, such as the shortest path, the fastest path, or the least traffic path. 
Depending on the user's preference or current traffic conditions, the app can switch between these strategies at runtime.
___
### Template Method
The Template Method pattern defines the skeleton of an algorithm in an operation, deferring some steps to subclasses. 
It lets one redefine certain steps of an algorithm without changing the algorithm's structure.
>Consider a [data processing system](/Behavioural/TemplateMethod.cs) where the steps to process data are generally the same (like reading data, processing it, and then writing it back), 
but the way these steps are carried out can differ based on the format of the data (such as XML or JSON). 
The Template Method pattern is like the blueprint for this process: it outlines the steps for processing data and allows different formats to implement these steps in their own specific way.
___
### Visitor
The Visitor pattern lets you separate algorithms from the objects on which they operate. 
It allows adding new operations to existing object structures without modifying those structures.
>Consider a [computer system composed of various parts](/Behavioural/Visitor.cs) like a mouse, keyboard, monitor, and the computer itself. 
If you need to perform a specific operation on each part, such as displaying information about the part, the Visitor pattern allows you to create a "visitor" object that can perform this operation. 
Each part of the computer system accepts this visitor, which then executes the operation based on the part's type, all without altering the classes of the computer parts themselves.
---
## Creational Patterns
Creational design patterns abstract the instantiation process. They help make a system independent of how its objects are created, composed, and represented. A class creational pattern uses inheritance to vary the class that’s instantiated, whereas an object creational pattern will delegate instantiation to another object.
___
### Abstract
The Abstract pattern provides an interface for creating families of related or dependent objects without specifying their concrete classes. 
It allows a client to use abstract interfaces to create a set of related objects without knowing (or being dependent on) the actual classes that implement these objects.
>Imagine a [furniture factory](/Creational/Abstract.cs) that produces products like chairs, sofas, and tables. There are different styles of furniture, like Modern, Victorian, or Art Deco. 
The Abstract Factory pattern is like having a separate factory for each style, where each factory creates all types of furniture in that particular style. 
A Modern furniture factory would produce Modern chairs, Modern sofas, and Modern tables, and so on for other styles, without mixing styles.
___
### Builder
The Builder pattern allows for the step-by-step construction of a complex object. 
It separates the construction of an object from its representation, allowing for different representations to be constructed using the same process.
>Consider the [process of assembling a custom computer](/Creational/Builder.cs). You have choices for various components like the CPU, GPU, and RAM. 
The Builder pattern is like this computer assembly process: it provides a framework for constructing a computer step by step. 
You can choose different components (like a high-end CPU for gaming or a mid-range CPU for office work), but the overall process of assembling the computer remains the same.
___
### Factory Method
The Factory Method pattern provides an interface for creating objects in a superclass but allows subclasses to alter the type of objects that will be created. 
It's a way to delegate the instantiation process to child classes.
>Imagine a [logistics management system](/Creational/FactoryMethod.cs) where different types of transport are used, such as trucks and ships. 
The system needs to create vehicles for transportation, but the type of vehicle depends on the nature of the cargo or the route. 
The Factory Method pattern is like having a central logistics office that decides whether to dispatch a truck or a ship, 
but the decision-making process (factory method) can be different depending on the specific logistic branch (subclass).
___
### Prototype
The Prototype pattern involves creating objects by copying a prototypical instance. 
It allows for the creation of duplicate objects while keeping performance in mind, as cloning can be more efficient than creating an object from scratch, especially if the object creation is resource-intensive.
>Imagine a [document editor](/Creational/Prototype.cs) where you can create shapes like circles, rectangles, or lines. Instead of defining each shape from scratch, 
you can draw one shape (say, a circle), and then create duplicates (prototypes) of this circle to place elsewhere in the document. 
Each duplicate can then be modified independently if needed. The Prototype pattern in this scenario allows you to clone existing shapes to create new ones quickly.
___
### Singleton
The Singleton pattern ensures a class has only one instance and provides a global point of access to it. 
This pattern is useful when exactly one object is needed to coordinate actions across the system.
>Imagine a [government](/Creational/Singleton.cs) that has exactly one president at any given time. 
Regardless of where or how you inquire about the current president, you always get information about the same person. 
The Singleton pattern is like having one and only one president for the entire government. 
It ensures that there's a single instance of a class (the president) throughout your application, with a global access point to that instance.
---
## Structural Patterns
Structural Design Patterns are concerned with how classes and objects are composed to form larger structures. Structural class patterns use inheritance to compose interfaces or implementations.
___
### Adapter
The Adapter pattern allows objects with incompatible interfaces to work together. 
It acts as a bridge between two otherwise incompatible interfaces. This pattern involves a single class, the adapter, which joins functionalities of independent or incompatible interfaces.
>Imagine you have a [legacy system](/Structural/Adapter.cs) that provides data in XML format, but your new system is designed to work with JSON format. 
The two systems cannot communicate directly due to their incompatible data formats. 
The Adapter pattern is like a translator that converts XML data from the legacy system into JSON data for the new system. 
It allows these two systems to work together without requiring changes to their existing interfaces.
___
### Bridge
The Bridge pattern separates an abstraction from its implementation, allowing the two to vary independently. 
It 'bridges' the gap between the abstraction and its implementation. This separation allows for more modular code that is easier to understand, maintain, and extend.
>Consider a scenario where you have [different types of devices](/Structural/Bridge.cs) like TVs and radios, and you need to control them using remote controls. 
Instead of creating a combined class for each pair of device and remote (like TV with Basic Remote, Radio with Advanced Remote), 
the Bridge pattern separates the devices (TV, Radio) from the remotes (Basic, Advanced). 
This separation allows you to independently develop functionalities for devices and remotes without intertwining their code.
___
### Composite
The Composite pattern allows you to compose objects into tree structures to represent part-whole hierarchies. 
This pattern lets clients treat individual objects and compositions of objects uniformly.
>Imagine a [graphic design application](/Structural/Composite.cs) where the user can create complex diagrams. 
The diagram could consist of various elements like circles, rectangles, and lines. 
The Composite pattern allows you to treat both single elements (like a circle) and groups of elements (a group of circles and rectangles) in the same way. 
You can apply operations like move or draw to both individual elements and to the group as a whole.
___
### Decorator
The Decorator pattern allows behavior to be added to individual objects, either statically or dynamically, 
without affecting the behavior of other objects from the same class. The pattern is designed to provide a flexible alternative to subclassing for extending functionality.
>Consider a [simple text messaging system](/Structural/Decorator.cs) where you send plain text messages. Now, imagine you want to enhance these messages by adding HTML formatting or encryption. 
The Decorator pattern allows you to "decorate" your plain text message with additional behaviors (like HTML formatting or encryption) without changing the original text message class. 
Each decorator wraps the original message and adds its own functionality, like wrapping a gift with decorative paper.
___
### Facade
The Facade pattern provides a simplified interface to a complex system of classes, libraries, or frameworks. This pattern makes a complex system easier to use by offering a single, unified interface that hides the underlying complexity.
>Imagine setting up a [home theater system](/Structural/Facade.cs) to watch a movie. The system involves multiple components like an amplifier, a DVD player, and a projector. Individually, these components can be complex to manage. The Facade pattern is like having a simple remote control (the facade) that encapsulates all these complexities. With a single action, like pressing a "watch movie" button, the remote ensures that the amplifier is set to the right volume, the DVD player is playing the movie, and the projector is turned on with the correct input settings.
___
### Flyweight
The Flyweight pattern minimizes memory usage by sharing as much data as possible with similar objects. It's particularly useful when dealing with a large number of objects that have some shared component.
>Imagine you are creating a [text editor](/Structural/Flyweight.cs) that displays characters on the screen. Each character has properties like its symbol and size. Instead of creating a separate object for each appearance of a character, the Flyweight pattern allows you to create a single object for each character and size combination and reuse it wherever needed. This way, if your text contains multiple instances of the letter 'A' with the same size, all these instances share the same flyweight object, saving memory.
___
### Proxy
The Proxy pattern provides a surrogate or placeholder for another object to control access to it. This pattern is used to create a representative object that can manage the interaction with the actual object, which might be complex or resource-intensive to use directly.
>Consider a scenario where you need to [print documents](/Structural/Proxy.cs). Directly using a printer every time you want to print something might be inefficient, especially if initializing the printer or sending the document to the printer is a resource-intensive operation. Instead, you use a proxy printer. This proxy manages interactions with the real printer. It can perform actions before or after sending the document to the printer, like logging the print request or initializing the printer only when it's really needed. The real printer does the actual printing, but the proxy controls when and how this printing happens.
___
## Sources:
- [https://www.geeksforgeeks.org/types-of-design-patterns](https://www.geeksforgeeks.org/types-of-design-patterns)
- [https://refactoring.guru/design-patterns](https://refactoring.guru/design-patterns)