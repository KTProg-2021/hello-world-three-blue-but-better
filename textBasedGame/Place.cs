using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace textBasedGame
{
    class Place
    {
        private Place[] _north, _south, _east, _west;
        private ArrayList _objects;
        private string _name, _enterText;
        
        //Constructor
        public Place(string name)
        {
            _north = new Place[0];
            _south = new Place[0];
            _east = new Place[0];
            _west = new Place[0];
            _objects = new ArrayList();
            _name = name;
            _enterText = "";
        }

        public String EnterText
        {
            get
            {
                return _enterText;
            }
            set
            {
                _enterText = value + "\n";
            }
        }

        //TO DO
        //Get list of objects
        //Copy code from directions? Unless?
        public void setObject (Object value)
        {
            _objects.Add(value);
        }

        public ArrayList getObject()
        {
            return _objects;
        }

        //TO DO
        //print out list of objects
        //come up with a way to test this
        public void printObjects()
        {
            for (int i = 0 ;i<_objects.Count; i++)
            {
                Console.WriteLine(_objects);
            }
        }


        //get/set - north/south/east/west
        public void setPlace (Place value, char direction)
        {
            if (direction == 'n')
            {
                Place[] save = _north;
                _north = new Place[save.Length + 1];
                for (int i = 0; i < save.Length; i++)
                {
                    _north[i] = save[i];
                }
                _north[save.Length] = value;
            }
            else if (direction == 's')
            {
                Place[] save = _south;
                _south = new Place[save.Length + 1];
                for (int i = 0; i < save.Length; i++)
                {
                    _south[i] = save[i];
                }
                _south[save.Length] = value;

            }
            else if (direction == 'w')
            {
                Place[] save = _west;
                _west = new Place[save.Length + 1];
                for (int i = 0; i < save.Length; i++)
                {
                    _west[i] = save[i];
                }
                _west[save.Length] = value;

            }
            else if (direction == 'e')
            {
                Place[] save = _east;
                _east = new Place[save.Length + 1];
                for (int i = 0; i < save.Length; i++)
                {
                    _east[i] = save[i];
                }
                _east[save.Length] = value;

            }
        }

        public Place[] getPlace (char direction)
        {
            if(direction == 'n')
            {
                return _north;
            }
            else if(direction == 's')
            {
                return _south;
            }
            else if(direction == 'w')
            {
                return _west;
            }
            else if(direction == 'e')
            {
                return _east;
            }
            else
            {
                return null;
            }
        }

        //get name
        public string getName()
        {
            return _name;
        }
    }
}
