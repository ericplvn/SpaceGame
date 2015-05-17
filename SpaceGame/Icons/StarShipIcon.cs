using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceGame.Icons
{
    public partial class StarShipIcon : GenericIcon
    {
        public event EventHandler ShipDestroyed;
        private int _shields;
        public int Shields {
            get
            {
                return _shields;
            }
            set
            {
                _shields = value;
                if (_shields == 0)
                {
                    ShipDestroyed(this, EventArgs.Empty);
                }
            }
        }
        public int Energy { get; private set; }

        public StarShipIcon()
        {
            InitializeComponent();

            Shields = 100;
            Energy = 100;
        }

        public ProjectileIcon FireCannon()
        {
            
            if (Energy >= 5)
            {
                Energy -= 5;
                return new ProjectileIcon();
            }
            else
            {
                return null;
            }
        }

        
    }
}
