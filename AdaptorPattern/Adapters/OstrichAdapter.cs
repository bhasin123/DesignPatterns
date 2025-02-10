using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaptorPattern.Adapters
{
    internal class OstrichAdapter : IDuck
    {
        private IOstrich ostrich;
        public OstrichAdapter(IOstrich ostrich)
        {
            this.ostrich = ostrich;
        }
        public void Fly()
        {
            ostrich.Run();
        }

        public void Quack()
        {
            ostrich.MakeNoise();
        }
    }
}
