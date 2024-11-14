﻿/*(1) Una tienda quiere controlar las compras de sus clientes.
Por cada 3 productos que se compren, quiere regalar el de precio inferior.
La aplicación debe preguntar el número de productos a comprar.
Para cada producto, preguntar su nombre y su precio.
Por cada 3 productos, se regala un producto, comenzando por los que tengan menor precio del todos los productos.
Mostrar al final cada uno de los productos, el precio que tenía y el precio que se aplica.
También dar el precio final a pagar por todos los productos.*/

using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Ingrese el número de productos a comprar: ");
        int numProductos = Convert.ToInt32(Console.ReadLine());

        string[] nombres = new string[numProductos];
        double[] precios = new double[numProductos];

        for (int i = 0; i < numProductos; i++)
        {
            Console.Write("Ingrese el nombre del producto: ");
            nombres[i] = Console.ReadLine();
            Console.Write("Ingrese el precio del producto: ");
            precios[i] = Convert.ToDouble(Console.ReadLine());
        }

        double total = 0;
        for (int i = 0; i < numProductos; i++)
        {
            total += precios[i];
        }

        Array.Sort(precios);

        int productosGratis = numProductos / 3;
        for (int i = 0; i < productosGratis; i++)
        {
            total -= precios[i];
        }

        Console.WriteLine("\nProductos comprados:");
        for (int i = 0; i < numProductos; i++)
        {
            Console.WriteLine($"Producto: {nombres[i]}, Precio original: {precios[i]}, Precio aplicado: {(i < productosGratis ? 0 : precios[i])}");
        }

        Console.WriteLine($"\nPrecio final a pagar: {total}");
    }
}