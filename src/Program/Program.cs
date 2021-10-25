using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Node Maria = new Node(1);
            Node Mata = new Node(2);
            Node Jose = new Node(3);
            Node Pia = new Node(4);
            Node Juan = new Node(5);
            Node Thai = new Node(6);
            Node Fla = new Node(7);
            Node 

            Maria.AddChildren(Mata);
            Maria.AddChildren(Jose);

            Mata.AddChildren(Pia);
            Mata.AddChildren(Juan);

            Jose.AddChildren(Thai);
            Jose.AddChildren(Fla);

            // visitar el árbol aquí
            Persona Pilar = new Persona ("Pilar Machado", 20);
            Persona Sofia = new Persona ("Sofia Casalas", 35);
            Persona Santiago = new Persona ("Santiago Luque", 20);

        }
    }
}
