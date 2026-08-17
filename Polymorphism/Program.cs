using Polymorphism;

MethodOverload obj = new MethodOverload();
obj.dis(25);
obj.dis("Abhishek", 23);
obj.dis(20 , 30);

// method overriding is allow to make multiple method with same parameter but different implementation in child class
child obj1 =new child();
obj1.dis();