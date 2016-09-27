using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntCreeping
{
    class Ant
    {
        private int left;
        private int right;
        private int creepingDirection;
        private int velocity;
        private int position;

        #region getter&setter
        public int Left
        {
            get
            {
                return left;
            }

            set
            {
                left = value;
            }
        }

        public int Right
        {
            get
            {
                return right;
            }

            set
            {
                right = value;
            }
        }

        public int CreepingDirection
        {
            get
            {
                return creepingDirection;
            }

            set
            {
                creepingDirection = value;
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
        #endregion


        public Ant(int creepingDirection, int velocity, int position)
        {
            this.creepingDirection = creepingDirection;
            this.velocity = velocity;
            this.position = position;
        }

        public Ant(int left, int right, int creepingDirection, int velocity, int position)
        {
            this.left = left;
            this.right = right;
            this.creepingDirection = creepingDirection;
            this.velocity = velocity;
            this.position = position;
        }
        

        /// <summary>
        /// change ant's creeping direction
        /// </summary>
        private void changeCreepDirection()
        {

        }
        
        /// <summary>
        /// judge whether the ant has collision with another ant
        /// </summary>
        /// <param name="anotherAnt">another Ant</param>
        /// <returns>true represents having collision</returns>
        public bool isHavingCollisionWith(Ant anotherAnt)
        {
            return true;
        }

        private void creeping(int incTime)
        {

        }
    }
}
