using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntCreeping
{
    class Ant
    {
        private int position;
        private Toward toward;
        private int velocity;

        #region getter&setter
        public int Position
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

        public int Velocity
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

        #endregion

        #region constructors
        public Ant()
        {
            position = 30;
            velocity = 5;
            toward = Toward.right;
        }

        public Ant(Toward toward, int velocity)
        {
            this.toward = toward;
            this.velocity = velocity;
        }

        public Ant(int position, Toward toward, int velocity)
        {
            this.position = position;
            this.toward = toward;
            this.velocity = velocity;
        }
        #endregion
        /// <summary>
        /// change ant's creeping direction
        /// </summary>
        private void changeCreepDirection()
        {
            if (toward == Toward.left)
                toward = Toward.right;
            else toward = Toward.left;
        }
        
        /// <summary>
        /// judge whether the ant has collision with another ant
        /// </summary>
        /// <param name="anotherAnt">another Ant</param>
        /// <returns>true represents having collision</returns>
        public bool isHavingCollisionWith(Ant anotherAnt)
        {
            return (position == anotherAnt.Position);
        }
        /// <summary>
        /// creeping for incTime Time
        /// </summary>
        /// <param name="incTime">creeping time</param>
        private void creeping(int incTime)
        {
            if (toward == Toward.left)
                position -= incTime * velocity;
            else position += incTime * velocity;
        }
    }
}
