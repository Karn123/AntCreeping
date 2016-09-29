using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntCreeping
{
    class CreepingGame
    {
        private int currentTime;
        private bool isGameOver;
        #region setters&getters
        public int CurrentTime
        {
            get
            {
                return currentTime;
            }

            set
            {
                currentTime = value;
            }
        }

        public bool IsGameOver
        {
            get
            {
                return isGameOver;
            }

            set
            {
                isGameOver = value;
            }
        }
        #endregion

        public void setStick()
        {

        }

        public void addAntOnTheStick()
        {

        }

        public void removeAnt()
        { }

        public void applyCollisionRule()
        { }

        public void drivingGame()
        { }

        public void playGame()
        { }
        
    }
} 