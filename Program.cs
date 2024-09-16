// See https://aka.ms/new-console-template for more information
using school1;
using System.Text;


Rainbarrel r = new Rainbarrel(100, 20);
Oilbarrel o = new Oilbarrel(50);

Console.WriteLine(r.Content);
r.Fill(10);
Console.WriteLine(r.Content);
r.ContainerInfo();

o.ContainerInfo();
o.Fill(10); 
o.ContainerInfo();

Console.ReadKey();

