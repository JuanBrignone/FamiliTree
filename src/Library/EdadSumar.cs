using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class EdadSumar: INodeVisitor
    {
        public int edadsuma;

        public int obtenersum()
        {
            return edadsuma;
        }

        public void Visit(Node node)
        {
            foreach (var child in node.Children)
            {
                child.Accept(this);
            }
        }

        public void Visit (Persona persona)
        {
            edadsuma += persona.Edad;
        }
    }
}