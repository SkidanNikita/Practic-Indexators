using System;
using System.Collections.Generic;
using System.Text;

namespace Practic___indexators
{
    public class RangeOfArray
    {
        public static int upRange;
        public static int downRange;

        private int[] array = new int[upRange - downRange];
        public int this[int index]
        {
            get
            {
                return array[index];
            }
            set
            {
                Check(value,index);
            }
        }
        public void Check(int value,int index)
        {
            if(downRange < 0)
            {
                array[index - (downRange)] = value;
            }
        }
        public static void Meaning(int rangeStart,int rangeEnd)
        {
            downRange = rangeStart;
            upRange = rangeEnd;
        }
    }
}
