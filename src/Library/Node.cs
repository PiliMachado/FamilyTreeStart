﻿using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class Node
    {
        private Persona person;

        private List<Node> children = new List<Node>();

        public Persona Number
         {
            get
            {
                return this.person;
            }
        }

        public ReadOnlyCollection<Node> Children { 
            get
            {
                return this.children.AsReadOnly();
            }
        }

        public Node(string nombre, int edad)
        {
            Persona person = new Persona (nombre, edad);
            this.person = person; 
        }

        public void AddChildren(Node n)
        {
            this.children.Add(n);
        }
        public void Accept (Visitor visitor)
        {
            visitor.Visit(this);
        }
        
    }
}
