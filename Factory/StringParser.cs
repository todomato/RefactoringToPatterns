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

            return NodeFactory.createStringNode(
                textBuffer, textBegin, textEnd,
                parser.shouldDecodeNodes());
        }
    }

    public class NodeFactory
    {
        public static Node createStringNode(StringBuffer textBuffer, int textBegin, int textEnd, bool shouldDecodeNodes)
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
        public bool shouldDecodeNodes()
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