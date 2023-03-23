using System;

namespace Factory2
{
    class Program
    {
        static void Main(string[] args)
        {
            // factory örnek 
            SomutCompressFactory cFactory = new SomutCompressFactory();

            Compressing comp1 = cFactory.getType("RAR");
            comp1.CompressThis();

            Compressing comp2 = cFactory.getType("ZIP");
            comp2.CompressThis();

            Compressing comp3 = cFactory.getType("TAR");
            comp3.CompressThis();
        }
    }
}
