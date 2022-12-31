using Drawing;
using System.Collections.Generic;

Point pt1=new Point(12,13);
Point pt2=new Point(45,34);
Shape shape1=new line(pt1,pt2);

Point pt3=new Point(39,28);
Point pt4=new Point(65,38);
Shape shape2=new Rectangle(pt3,pt4);

Point center=new Point(34,34);
int radius=29;
Shape shape3=new Circle(center,radius);

List<Shape> shapes=new List<Shape>();
shapes.Add(shape1);
shapes.Add(shape2);
shapes.Add(shape3);

Console.WriteLine("Drawing All Shapes");
Console.WriteLine("---------------------------");

foreach(Shape s in shapes){
    s.Draw();
}