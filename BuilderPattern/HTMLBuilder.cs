using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    internal class HTMLBuilder
    {
        public HtmlElement root;
        public string rootName;

        public HTMLBuilder(string rootName)
        {
            this.root = new HtmlElement();
            this.root.Name = this.rootName = rootName;
        }

        public HTMLBuilder Addchild(string name, string text)
        {
            this.root.Elements.Add(new HtmlElement(name, text));
            return this;
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
