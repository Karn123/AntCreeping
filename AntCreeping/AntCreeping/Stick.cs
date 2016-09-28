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
        /// maximum distance to the left end of the stick 
        /// </summary>
        public int length;
        #region getters and setters
        public int Length
        {
            get
            {
                return length;
            }

            set
            {
                length = value;
            }
        }
       
        #endregion

        public Stick()
        {
            length = 300;
        }
        public Stick(int length)
        {
            this.length = length;
        }
        /// <summary>
        /// judge whether any of the ants is out of the stick
        /// </summary>
        /// <param name="pos"></param>
        /// <returns></returns>
        public bool isOutOfRange(int pos)
        {
            return (pos <= 0 || pos >= length);
        }   
    }
}