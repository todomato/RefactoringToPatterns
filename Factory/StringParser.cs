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

            var nodeFactory = new NodeFactory();
            return nodeFactory.createStringNode(
                textBuffer, textBegin, textEnd,
                parser.shouldDecodeNodes());
        }
    }

    public class NodeFactory
    {
        public Node createStringNode(StringBuffer textBuffer, int textBegin, int textEnd, bool shouldDecodeNodes)
        {
            if (shouldDecodeNodes)
            {
                return new DecondingStringNode(new StringNode(textBuffer, textBegin, textEnd));
            }
            return new StringNode(textBuffer, textBegin, textEnd);
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

    public class Parser
    {
        private bool _shouldDecodeNodes = false;

        public bool shouldDecodeNodes()
        {
            return _shouldDecodeNodes;
        }

        public void setNodeDecoding(Boolean shouldDecodeNodes)
        {
            _shouldDecodeNodes = shouldDecodeNodes;
        }
    } 
    public class StringNodeParingOption
    {
        private bool decodeStringNodes;

        public bool shouldDecodeStringNodes()
        {
            return decodeStringNodes;
        }

        public void setNodeDecoding(Boolean shouldDecodeNodes)
        {
            decodeStringNodes = shouldDecodeNodes;
        }
    } 
    public class StringBuffer
    {
    }


    public class Node
    {
    }
}