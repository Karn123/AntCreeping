using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntCreeping
{
    public struct Neighbours
    {
        Ant leftNeighbour;
        Ant rightNeighbour;

        internal Ant LeftNeighbour
        {
            get
            {
                return leftNeighbour;
            }

            set
            {
                leftNeighbour = value;
            }
        }

        internal Ant RightNeighbour
        {
            get
            {
                return rightNeighbour;
            }

            set
            {
                rightNeighbour = value;
            }
        }
    }
    class Ant
    {
        private float position;
        private Toward toward;
        private float velocity;
        public Neighbours antNeighbours; 
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

        public Neighbours MyNeighbours
        {
            get
            {
                return antNeighbours;
            }

            set
            {
                antNeighbours = value;
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

        #endregion

        #region constructors
        public Ant()
        {
            antNeighbours.LeftNeighbour = null;
            antNeighbours.RightNeighbour = null;
            Position = 30f;
            Velocity = 5f; 
            toward = Toward.right;
        }

        public Ant(Toward toward, float velocity)
        {
            this.toward = toward;
            this.Velocity = velocity;
        }

        public Ant(float position, Toward toward, float velocity)
        {
            this.Position = position;
            this.toward = toward;
            this.Velocity = velocity;
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
        /// judge whether the ant has collision with another ant,note that if two ants collide in the 
        /// same direction,the one with higher speed needs to change direction while the other needn't
        /// </summary>
        /// <param name="anotherAnt">another Ant</param>
        /// <returns>true represents having collision</returns>
        //public bool isHavingCollisionWith(Ant anotherAnt)
        //{
        //    if (position == anotherAnt.Position)
        //    {
        //        if (anotherAnt.CreepingToward != toward)
        //            return true;
        //        else
        //        {
        //            if ((toward == Toward.left && myNeighbours.LeftNeighbour == anotherAnt)
        //               || (toward == Toward.right && myNeighbours.RightNeighbour == anotherAnt))
        //            {
        //                return true;
        //            }
        //            if (this.Velocity > anotherAnt.Velocity)
        //                return true;
        //            else
        //                return false;
        //        }
        //    }
        //    else
        //        return false;
        //}

        /// <summary>
        /// creeping for incTime Time
        /// </summary>
        /// <param name="incTime">creeping time</param>
        public void creeping(int incTime)
        {
            if (toward == Toward.left)
                Position -= incTime * Velocity;
            else Position += incTime * Velocity;
        }
    }
}
