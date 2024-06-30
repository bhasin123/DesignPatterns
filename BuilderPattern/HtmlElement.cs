using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    internal class HtmlElement
    {
        public string Name, Text;
        public List<HtmlElement> Elements = new List<HtmlElement>();
        public const int indentSize = 2;

        public HtmlElement() { }
        public HtmlElement(string name, string text)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Text = text ?? throw new ArgumentNullException(nameof(text));
        }

        public string ToStringImpl(int indent)
        {
            var sb = new StringBuilder();
            var i = new String(' ', indentSize * indent);
            sb.AppendLine($"{i}<{Name}>");
            //sb.Append($"<{Name}>");

            if (!string.IsNullOrWhiteSpace(Text))
            {
                sb.Append(new String(' ', indentSize * (indent + 1)));
                sb.AppendLine(Text);
            }

            foreach (var e in Elements)
            {
                sb.Append(e.ToStringImpl(indent + 1));
            }

            sb.AppendLine($"{i}</{Name}>");

            return sb.ToString();
        }

        public override string ToString()
        {
            return ToStringImpl(0);
        }


    }

    internal class HTMLBuilder
    {
        public HtmlElement root;
        public string rootName; 

        public HTMLBuilder(string rootName)
        {
            this.root = new HtmlElement();
            this.root.Name = this.rootName = rootName;
        }

        public void Addchild(string name, string text)
        {
            this.root.Elements.Add(new HtmlElement(name, text));
        }

        public override string ToString()
        {
            return this.root.ToString();
        }


        public void Clear()
        {
            this.root = new HtmlElement(); 
            this.root.Name = rootName;
        }
    }
}
