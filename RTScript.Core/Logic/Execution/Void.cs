using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RTScript.Core.Logic.Execution
{
    public sealed class RTVoid
    {
        static RTVoid()
        {
            Singleton = new RTVoid();
        }

        private RTVoid()
        { }

        /// <summary>
        /// Return this object when a value is not found or returned.
        /// </summary>
        public static readonly RTVoid Singleton;
    }
}
