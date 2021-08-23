using System;
using System.Collections.Generic;
using System.Text;

namespace CheckinApp
{
    class PinModel
    {
        public List<int> pin { get; set; } = new List<int>();

        public static int PIN_LENGTH = 4;

        public bool maxPinCount()
        {
            return this.pin.Count >= PIN_LENGTH ? true : false;
        }
    }
}
