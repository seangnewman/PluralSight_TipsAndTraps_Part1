using Demos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PluralSight_TricksAndTraps
{
    class Program
    {
        static void Main(string[] args)
        {
            //DebuggerDisplayAttributeExample();
            //DebuggerBrowsableAttributeExample();
            //NullCoalescingOperatorExample();

        }

        private static void NullCoalescingOperatorExample()
        {
            NullCoalescingOperatorExample nullCoalescingOperatorExample = new NullCoalescingOperatorExample();
            //nullCoalescingOperatorExample.ReferenceTypes();
            nullCoalescingOperatorExample.NullableTypes();
        }

        private static void DebuggerBrowsableAttributeExample()
        {
            DebuggerBrowsableAttributeExample debuggerBrowsableAttributeExample = new DebuggerBrowsableAttributeExample();

            //debuggerBrowsableAttributeExample.Without();
            debuggerBrowsableAttributeExample.With();
        }

        private static void DebuggerDisplayAttributeExample()
        {
            DebuggerDisplayAttributeExample debuggerDisplayAttributeExample = new DebuggerDisplayAttributeExample();
            //debuggerDisplayAttributeExample.Without();
            debuggerDisplayAttributeExample.With();
        }
    }
}
