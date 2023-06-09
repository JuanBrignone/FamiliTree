﻿using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class Node
    {
        private int number;

        private Persona persona;

        private List<Node> children = new List<Node>();

        public Persona Persona
        {
            get {return persona;}
        }

        public int Number {
            get
            {
                return this.number;
            }
        }

        public ReadOnlyCollection<Node> Children { 
            get
            {
                return this.children.AsReadOnly();
            }
        }

        public Node(Persona persona)
        {
            this.persona = Persona;
        }

        public Node(int number)
        {
            this.number = number;
        }

        public void AddChildren(Node n)
        {
            this.children.Add(n);
        }

        public void Accept(INodeVisitor visitor)
        {
            visitor.Visit(this);
        }
        
    }
}
