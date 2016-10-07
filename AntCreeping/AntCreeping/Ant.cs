using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntCreeping
{
    class Ant
    {
        private float position;
        private Toward toward;
        private float velocity;
        private int number;
        #region getter&setter

        public Toward CreepingToward
        {
            get
            {
                return toward;
            }

            set
            {
                toward = value;
            }
        }

        public float Velocity
        {
            get
            {
                return velocity;
            }

            set
            {
                velocity = value;
            }
        }

        public float Position
        {
            get
            {
                return position;
            }

            set
            {
                position = value;
            }
        }

        public int Number
        {
            get
            {
                return number;
            }

            set
            {
                number = value;
            }
        }

        #endregion

        #region constructors
        public Ant()
        {
            Position = 30f;
            Velocity = 5f; 
            toward = Toward.right;
        }

        public Ant(Toward toward, float velocity)
        {
            this.toward = toward;
            this.Velocity = velocity;
        }

        public Ant(float position, Toward toward, float velocity,int number)
        {
            this.Position = position;
            this.toward = toward;
            this.Velocity = velocity;
            this.number = number;
        }
        #endregion
        /// <summary>
        /// change ant's creeping direction
        /// </summary>
        public void changeCreepDirection()
        {
            if (toward == Toward.left)
                toward = Toward.right;
            else toward = Toward.left;
        }
    
        /// <summary>
        /// creeping for incTime Time
        /// </summary>
        /// <param name="incTime">creeping time</param>
        public void creeping(int incTime)
        {
            float distance = (float)Math.Round(Convert.ToDecimal((incTime * Velocity)), 2);
            if (toward == Toward.left)
                Position -=  distance;
            else Position += distance;
        }
    }
}