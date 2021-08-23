using System;
using System.Collections.Generic;
using System.Linq;

namespace CheckinApp
{
    class PinModel
    {
        public List<int> Pin { get; set; } = new List<int>();

        public List<int> ValidPin { get; } = new List<int>() { 3, 2, 2, 3 };

        public static int PIN_LENGTH = 4;

        public bool MaxPinCount()
        {
            return Pin.Count >= PIN_LENGTH;
        }

        public bool IsValidPin()
        {
            return Pin.SequenceEqual(ValidPin);
        }

    }
}
