using System;
using System.Collections.Generic;
using System.Text;

namespace Factory2
{
    class SomutCompressFactory:CompressFactory
    {
        public override Compressing getType(string compressType)
        {
            if(compressType == null)
            {
                return null;
            }
            if(compressType.Equals("ZIP"))
            {
                return new Zip();
            }
            else if(compressType.Equals("RAR"))
            {
                return new Rar();
            }
            else if(compressType.Equals("TAR"))
            {
                return new Tar();
            }
            return null;
        }
    }
}
