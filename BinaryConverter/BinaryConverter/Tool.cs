using BinaryConverter.Classes;
using BinaryConverter.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryConverter
{
    class Tool
    {
       static public ILocalMethods LMethods { get; } = new LocalMethods();
    }
}
