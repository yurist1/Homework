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
        public ButtonFactory() 
        {
            _btnWeights = new Dictionary<int, IButton>();
        }
        public IButton GetButtonWeight() 
        {
            IButton btnWeight;
            int key = getRandom() % 2;
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
            Random r = new Random();
            int random_number = r.Next(0, 10000);
            return random_number;
        }
    }
}
