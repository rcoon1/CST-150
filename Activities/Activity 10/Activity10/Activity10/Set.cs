using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Lydia's code - find the errors!
namespace CST117_IC08_console
{
    class Set
    {

        private List<int> elements;


        public Set()
        {
            elements = new List<int>();
        }

        public bool addElement(int val)
        {
            if (containsElement(val))
                return false;
            else
            {
                elements.Add(val);
                return true;
            }
        }


        private bool containsElement(int val)
        {
            for (int i = 0; i < elements.Count; i++)
            {
                if (val == elements[i])

                    return true;
                //else                    would need to move the return false value outside of the bracket
                //return false;      being inside with the true would cause it to return false after and stop searching once false was found 
            }                        // instead of checking all numbers first to locate a match could also use else continue;
            return false;
        }

        public override string ToString()
        {
            string str = "";
            foreach (int i in elements)
            {
                str += i + " ";
            }
            return str;
        }

        public void clearSet()
        {
            elements.Clear();
        }


        public Set union(Set rhs)
        {
            Set unSet = new Set();                    //needed to create a temp set just to hold values to allow original set to be untouched 
                                                         
            for (int x = 0; x < this.elements.Count; x++) //add elements from original set to unSet
            {
                unSet.addElement(this.elements[x]);
            }
            for (int i = 0; i < rhs.elements.Count; i++) //add elements from rhs to unSet
            {
                unSet.addElement(rhs.elements[i]);
            }

            /*
            for (int i = 0; i < rhs.elements.Count; i++)    These next lines wouls alter the original set including the union
            {                                               for rhs. With this only rhs will be returned and not the "unified" set.
                this.addElement(rhs.elements[i]);           
            }
            //return rhs;   */

            return unSet;    //this will return the set that has been "unified"
        }
    }
}