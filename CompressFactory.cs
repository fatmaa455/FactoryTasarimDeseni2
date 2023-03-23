using System;
using System.Collections.Generic;
using System.Text;

namespace Factory2
{
    abstract class CompressFactory
    {
        public abstract Compressing getType(string ct);
    }
}
