﻿using Barricades;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;

Course c = new Course("PI");
c["Pero"] = 2;
c["Ana"] = 5;
c["Ivan"] = 5;
c["Marko"] = 1;
c["Luka"] = 3;
//p["Marija"] = -7; //should throw an exception
Console.WriteLine("Average grade: " + c.AverageGrade());
Console.WriteLine("Šime ima ocjenu: " + c["Šime"]); //prints -1
