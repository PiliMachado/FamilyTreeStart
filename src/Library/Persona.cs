using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class Persona
    {
        public string nombre;
        public int edad; 
     
        public Persona (string nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }
        public void Accept (Visitor visitor)
        {
            visitor.Visit(this);
        }
    }
}