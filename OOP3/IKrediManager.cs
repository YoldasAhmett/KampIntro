using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    //Interface olduğunu belli etmek için KrediManager'ın başına I koymalıyız.
    interface IKrediManager
    {
        void Hesapla();
        void BiseyYap();
    }
}
