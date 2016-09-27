using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntCreeping
{
    class Stick
    {
        /// <summary>
        /// minimum distance to the left end of the stick
        /// </summary>
        public int minPos;
        /// <summary>
        /// maximum distance to the left end of the stick 
        /// </summary>
        public int maxPos;
        #region getters and setters
        public int MinPos
        {
            get
            {
                return minPos;
            }

            set
            {
                minPos = value;
            }
        }

        public int MaxPos
        {
            get
            {
                return maxPos;
            }

            set
            {
                maxPos = value;
            }
        }
        #endregion

        public Stick(int length)
        {
            maxPos = length;
        }

        public bool isOutOfRange(int pos)
        {
            return (pos <= minPos || pos >= maxPos);
            }
    }
}
