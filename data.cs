using System;

using MediCal;

namespace DataStructures
{
    partial class LinkedList
    {
        private class Node
        {
            public Node Next { get; set; }
            public Telement Data { get; private set; }

            public Node(Telement newData ) { Next = null; Data = newData; }
        }

        private Node Tail { get; set; }
        private Node Head { get; set; }
        public int Count { get; private set; }

        public LinkedList( ) { Tail = null; Head = null; Count = 0; }

        public void AddFirst( Drug newData )
        {
            if( newData == null ) throw new ArgumentNullException( );

            Node newNode = new Node( newData );
            Node oldHead = Head;

            if( Tail == null ) Tail = newNode;
            else newNode.Next = oldHead;
            Head = newNode;

            Count ++;
        }

        public void AddLast( Telement newData )
        {
            if( newData == null ) throw new ArgumentNullException( );

            Node newNode = new Node( newData );
            Node oldTail = Tail;

            if( Head == null ) Head = newNode;
            else oldTail.Next = newNode;
            Tail = newNode;

            Count ++;
        }

        public Telement ToArray( )
        {
            Telement[ ] result = new Telement[ Count ] ;

            int i = 0;
            Node currentNode = Head;
            while( currentNode != null )
            {
                result[ i ] = currentNode.Data;
                i ++;
                currentNode = currentNode.Next;
            }

            return result;
        }
    }
}
