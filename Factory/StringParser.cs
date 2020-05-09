using System;
using System.Xml;

namespace Factory
{
    public class StringParser
    {
        public Node find()
        {
            StringBuffer textBuffer = new StringBuffer();
            int textBegin = 0;
            int textEnd = 0;
            Parser parser = new Parser();

            return parser.getStringNodeParsingOption().createStringNode(
                textBuffer, textBegin, textEnd);
        }
    }
    public class Parser
    {
        private NodeFactory _nodeFactory = new NodeFactory();

        public NodeFactory getStringNodeParsingOption()
        {
            return _nodeFactory;
        }

        public void setNodeFactory(NodeFactory factory)
        {
            _nodeFactory = factory;
        }
    }

    public class NodeFactory
    {
        private bool decodeStringNodes;

        public Node createStringNode(StringBuffer textBuffer, int textBegin, int textEnd)
        {
            if (decodeStringNodes)
            {
                return new DecondingStringNode(new StringNode(textBuffer, textBegin, textEnd));
            }

            return new StringNode(textBuffer, textBegin, textEnd);
        }

        public bool shouldDecodeStringNodes()
        {
            return decodeStringNodes;
        }

        public void setNodeDecoding(Boolean decodeStringNodes)
        {
            this.decodeStringNodes = decodeStringNodes;
        }
    }


    public class StringNode : Node
    {
        public StringNode(StringBuffer textBuffer, int textBegin, int textEnd)
        {
            throw new System.NotImplementedException();
        }
    }

    public class DecondingStringNode : Node
    {
        public DecondingStringNode(StringNode stringNode)
        {
            throw new System.NotImplementedException();
        }
    }

  
    public class StringBuffer
    {
    }


    public class Node
    {
    }
}