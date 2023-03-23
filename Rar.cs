using System;
using System.Collections.Generic;
using System.Text;

namespace Factory2
{
    class Rar : Compressing
    {
        public void CompressThis()
        {
            Console.WriteLine("Olusturulan dosya tipi \".rar\"");
        }
    }
}
