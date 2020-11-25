using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPattern_HW
{
    public class ButtonFactory
    {
        private Dictionary<int, IButton> _btnWeights;
        private Random r;
        public ButtonFactory() 
        {
            _btnWeights = new Dictionary<int, IButton>();
            r = new Random();
        }
        public IButton GetButtonWeight() 
        {
            IButton btnWeight;
            int key = getRandom() > 50? 0:1;
            _btnWeights.TryGetValue(key, out btnWeight);
            if (btnWeight == null)
            {
                btnWeight = new DecorateButton().Operation(key);
                _btnWeights.Add(key, btnWeight);
            }
            return btnWeight;
        }

        private int getRandom() 
        {
            int random_number = r.Next(0, 100);
            return random_number;
        }
    }
}
