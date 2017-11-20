using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedBallTracker
{
    class BlueTeamFigures
    {
        
        public delegate int arrayDelegate<T>();
        arrayDelegate<int> size;
        //TODO Karolis Indexed properties for demo purposes, not really useful
        private string[] figuresNames = new string[5]
        {
        "John", "Bob", "Josh", "Johnny", "Roberto"
        };

        public string this[int index]
        {
            get
            {
                return figuresNames[index];
            }

            set
            {
                figuresNames[index] = value;
            }
        }

        public int arraySize()
        {
            size = () => { return figuresNames.Length; };
            int x = size();
            return x;
        }
    }




}
