using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Node Maria = new Node("Maria Estevez", 55);
            Node Mata = new Node("Mata Lamadrid", 30);
            Node Jose = new Node("Jose Lamadrid", 35);
            Node Pia = new Node("Pia Lamadrid", 10);
            Node Juan = new Node("Juan Lamadrid", 12);
            Node Thai = new Node("Thai Rau", 9);
            Node Fla = new Node("Fla Rau", 6);
            Node Paula = new Node ("Paula Machado", 5);
            Node Aldana = new Node ("Aldana Casalas", 2);
  
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
            Persona Manuel = new Persona ("Manuel Luque", 20);

        }
    }
}
