using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfPaint2
{
    public class PaintUtils
    {
        Random random = new Random();
        public byte NewValue(byte value, byte maxDif)
        {
            var dif = random.Next(-maxDif, maxDif);
            var result = value + dif;
            if (result > 255)
                result = 255;
            if (result < 0)
                result = 0;
            return (byte)result;
        }
        public byte GetAlpha(int value)
        {
            //Если значение, возведённое в квадрат чётное, то функция должна возвращать остаток от деления на 64
            // Если нечётное, то функция должна возвращать 255 - остаток от деления на 64
            var q = value * value;
                if (q%2==0)
            {
                return (byte)(q % 64);
            }
                else
            {
                return (byte)(255 - (q % 64));
            }
            return 255;
        }
    }
}
