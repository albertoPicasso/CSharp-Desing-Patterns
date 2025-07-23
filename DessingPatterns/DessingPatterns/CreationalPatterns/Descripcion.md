# Factory method
Definition and Purpose of the Factory Method
The Factory Method is a creational design pattern that provides an interface for creating objects in a superclass, but allows subclasses to alter the type of objects that will be created.

Instead of calling a constructor directly to create an object, the Factory Method defers this instantiation to subclasses. This promotes loose coupling by eliminating the need to bind application-specific classes into the code. As a result, the code can work with newly introduced classes without requiring changes to the core logic.

Purpose and Use
The Factory Method is used to:

Encapsulate object creation logic, particularly when the exact type of the object may vary.

Promote extensibility by allowing new product types to be introduced with minimal code changes.

Support the Open/Closed Principle, where software entities are open for extension but closed for modification.

Improve maintainability and reduce code duplication by centralizing instantiation logic.