// See https://aka.ms/new-console-template for more information
using LiskovSubstitution;

Console.WriteLine("Hello, World!");





//Shape shape= new Shape();
//shape.draw();

//Circle circle= new Circle();
//circle.draw();

//Client client= new Client();
//client.draw(shape);

//client.draw(circle);


//With Liscov Substitution
Client client = new Client();
Shape shape = new Circle();
client.draw(shape);



//Without Liscov Substitution
