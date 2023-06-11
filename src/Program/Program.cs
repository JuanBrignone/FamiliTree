using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
           Persona abuelo = new Persona("Abuelo", 75);
           Persona abuela = new Persona("Abuela", 70);
           Persona padre = new Persona("Padre", 45);
           Persona madre = new Persona ("Madre", 40);
           Persona hijo = new Persona ("Hijo", 17);

           Node abueloNode = new Node(abuelo);
           Node abuelaNode = new Node (abuela);
           Node padreNode = new Node (padre);
           Node madreNode = new Node (madre);
           Node hijoNode = new Node (hijo);

           abueloNode.AddChildren(madreNode);
           abuelaNode.AddChildren(madreNode);
           madreNode.AddChildren(hijoNode);
           padreNode.AddChildren(hijoNode);


            EdadSumar edadSumarVisitor = new EdadSumar();

            abueloNode.Accept(edadSumarVisitor);
            abuelaNode.Accept(edadSumarVisitor);

            int sumaedades = edadSumarVisitor.obtenersum();

            Console.WriteLine("La suma de las edades es:" + sumaedades);
           
            
           

            // visitar el árbol aquí
        }
    }
}
