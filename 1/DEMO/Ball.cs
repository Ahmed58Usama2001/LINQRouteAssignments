using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO
{
	public class Ball
	{
		public int Id { get; set; }

		private Location ballLocation;

		public Location BallLocation
		{
			get { return ballLocation; }
			set
			{

				if (value != ballLocation)
				{
					ballLocation = value;
					OnLocationChanged.Invoke(value);
				}

			}

		}

        public override string ToString()
        {
			return $"Ball{Id} , {BallLocation}";
        }

        public event Action<Location> OnLocationChanged;








	}
}
