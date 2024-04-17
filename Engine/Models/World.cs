using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class World
    {
        private List<Location> _locations = new List<Location>();
        internal void CreateLocation(int x, int y, string name, string description, string imageName)
        {
            Location location = new Location();
            location.XCoordinate = x;
            location.YCoordinate = y;
            location.Name = name;
            location.Description = description;
            location.ImageName = imageName;

            _locations.Add(location); // add  the created location to the list
        }

        public Location LocationAt(int x, int y)
        {
            foreach(Location location in _locations)
            {
                if(location.XCoordinate == x && location.YCoordinate == y)
                {
                    return location;
                }
            }

            return null; // if the coordinate of the specified location is not in the list
        }
    }
}
