using Encapsulation;

Capsule en = new Capsule();
en.setvalue(101, "Abhishek", "learning c#");
var (getId, getName, getDescription) = en.getvalue();
Console.WriteLine($"My id is :{getId} and name is :{getName} and description is :{getDescription}");


SimpleWay sw =new SimpleWay();
sw.id = 102;
sw.name = "Rahul";
sw.description = "learning Python";
Console.WriteLine($"My id is :{sw.id} and name is :{sw.name} and description is :{sw.description}");