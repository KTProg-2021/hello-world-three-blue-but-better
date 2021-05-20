using System;
using System.Collections.Generic;
using System.Text;

namespace textBasedGame
{
    class Item
    {
        //Constructor
        private String _name, _takeText;
        private int _fixed = -1, _on = -1, 
            _clean = -1, _cooked = -1;
        public Item(string name, int inFixed, int inOn, int inClean, int inCooked)
        {
            _name = name;
            _fixed = inFixed;
            _on = inOn;
            _clean = inClean;
            _cooked = inCooked;
            _takeText = "";
        }


        //Get/set methods
        //Name
        public String name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public String TakeText
        {
            get
            {
                return _takeText;
            }
            set
            {
                _takeText = value + "\n";
            }
        }

        public String printConditions()
        {
            String output = "";
            if (_fixed == 1)
            {
                output += "It is in good condition.\n";
            }
            else if (_fixed == 0)
            {
                output += "It is broken.\n";
            }
            if (_on == 1)
            {
                output += "It is on.\n";
            }
            else if (_on == 0)
            {
                output += "It is off.\n";
            }
            if (_clean == 1)
            {
                output += "It is clean.\n";
            }
            else if (_clean == 0)
            {
                output += "It is dirty.\n";
            }
            if (_cooked == 1)
            {
                output += "It is cooked.\n";
            }
            else if (_fixed == 0)
            {
                output += "It is uncooked.\n";
            }
            return output;
        }

        public int Cooked
        {
            get
            {
                return _cooked;
            }
            set
            {
                _cooked = value;
            }
        }

        public String Cook()
        {
            String output;
            if (_cooked == 0)
            {
                output = "You have turned on the " + _name + ".";

                _cooked = 1;
            }
            else if (_cooked == 1)
            {
                output = "The " + _name + " is alrerady on.";
            }
            else
            {
                output = "You cannot turn on the " + _name + ".";
            }
            return output;
        }

        public int Clean
        {
            get
            {
                return _clean;
            }
            set
            {
                _clean = value;
            }
        }

        public String makeClean()
        {
            String output;
            if (_clean == 0)
            {
                output = "You have turned on the " + _name + ".";

                _clean = 1;
            }
            else if (_clean == 1)
            {
                output = "The " + _name + " is alrerady on.";
            }
            else
            {
                output = "You cannot turn on the " + _name + ".";
            }
            return output;
        }

        public String makeDirty()
        {
            String output;
            if (_clean == 1)
            {
                output = "You have turn off the " + _name + ".";
                _clean = 0;
            }
            else if (_clean == 0)
            {
                output = "The " + _name + " is already off..";
            }
            else
            {
                output = "You cannot turn off the " + _name + ".";
            }
            return output;
        }

        public int On
        {
            get
            {
                return _on;
            }
            set
            {
                _on = value;
            }
        }

        public String TurnOn()
        {
            String output;
            if (_on == 0)
            {
                output = "You have turned on the " + _name + ".";

                _on = 1;
            }
            else if (_on == 1)
            {
                output = "The " + _name + " is alrerady on.";
            }
            else
            {
                output = "You cannot turn on the " + _name + ".";
            }
            return output;
        }

        public String TurnOff()
        {
            String output;
            if (_on == 1)
            {
                output = "You have turn off the " + _name + ".";
                _on = 0;
            }
            else if (_on == 0)
            {
                output = "The " + _name + " is already off..";
            }
            else
            {
                output = "You cannot turn off the " + _name + ".";
            }
            return output;
        }

        public int Fixed
        {
            get
            {
                return _fixed;
            }
            set
            {
                _fixed = value;
            }
        }

        public String Fix()
        {
            String output;
            if (_fixed == 0)
            {
                output = "You have fixed the " + _name + ".";

                _fixed = 1;
            }
            else if(_fixed == 1)
            {
                output = "The " + _name + " does not need fixing.";
            }
            else
            {
                output = "You cannot fix the " + _name + ".";
            }
            return output;
        }

        public String Punch()
        {
            String output;
            if (_fixed == 1)
            {
                output = "Great job.  You have broken the " + _name + ".";
                _fixed = 0;
            }
            else if(_fixed == 0)
            {
                output = "The " + _name + " is already broken. You break it some more.";
            }
            else
            {
                output = "You cannot punch the " + _name + ".";
            }
            return output;
        }
    }
}
