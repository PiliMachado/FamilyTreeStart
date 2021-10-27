using Library;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Library
{
    public class PersonaVistitor : Visitor
    {
        public override void Visit(Node nodo)
        {
            foreach (var hijo in nodo.Children)
            {
                if (hijo.Children != null)
                {
                    hijo.Accept(this);
                    hijo.Persona.Accept(this);
                }
            }
        }
        public override void Visit(Persona person)
        {
            ContentBuilder += person.edad; 
        }
    }
}