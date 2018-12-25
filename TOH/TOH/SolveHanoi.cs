
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TOH
{
    class SolveHanoi
    {
        int numberOfRods;
        Step step;

        //set the rod numbers
        public SolveHanoi(int NumberOfRods)
        {
            numberOfRods = NumberOfRods;
        }

        //solve teh problem and fill the gude list with the steps 
        public void Tower(int numberOfDisks, int src, int dest, int aux, List<Step> steps)
        {
            if (numberOfDisks == 1)
            {
                step.rod_num = numberOfDisks;
                //step.rod_num += 1;
                step.dest = dest;
                step.src = src;
                steps.Add(step);
            }

            else
            {
                Tower(numberOfDisks - 1, src, aux, dest, steps);
                step.rod_num = numberOfDisks;
                //step.rod_num += 1;
                step.dest = dest;
                step.src = src;
                steps.Add(step);
                Tower(numberOfDisks - 1, aux, dest, src, steps);
            }
      }
    }
}
