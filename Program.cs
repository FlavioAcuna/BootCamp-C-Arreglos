//Arreglos
/*
primero definir el tipo luego agregar corchetes , nombre del arreglo = definirlo como new y
el tipo de dato y dentro de los corchetes insertar el numero de elementos en el arreglo

*/
string[] nombres = new string[5];

nombres[0] = "Alex";
nombres[1] = "Martha";
nombres[2] = "Julieta";
nombres[3] = "Roger";
nombres[4] = "Alan";

for (int i = 0; i < nombres.Length; i++)
{
    Console.WriteLine(nombres[i]);
}

double[] calificaciones = new double[] { 9.8, 8.7, 6.9, 10.0 };

for (int j = 0; j < calificaciones.Length; j++)
{
    Console.WriteLine(calificaciones[j]);
}
Console.WriteLine("--------------");

foreach (double num in calificaciones)
{
    Console.WriteLine(num);
}