using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public interface INodeVisitor
    {
        void Visit(Node node);
        void Visit (Persona persona);

    }
}