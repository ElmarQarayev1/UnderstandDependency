using System;

namespace CityLibrary
{
    public class ChinaCity : City
    {

        public override int Population
        {
            get
            {
                return _population;
            }
            set
            {
                if (value >= 100000)
                {
                    _population = value;
                }
            }
        }
    }
}

