using System;
using System.Collections.Generic;
using System.Text;

namespace Factory2
{
    class Tar : Compressing
    {
        public void CompressThis()
        {
            Console.WriteLine("Olusturulan dosya tipi \".tar\"");
        }
    }
}
