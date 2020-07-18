using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSPUtility
{
    interface ACOInterface
    {
        void InitializePheromone();
        void updatePheromone();
        void generateRoute();
    }

    class AntSystem: ACOInterface
    {
        public int agentNum;
        public double[,] pheromoneArray;

        public AntSystem(int agentNum)
        {
            this.agentNum = agentNum;
        }

        public void InitializePheromone()
        {

        }
        public void updatePheromone()
        {

        }

        public void generateRoute()
        {

        }
    }
}