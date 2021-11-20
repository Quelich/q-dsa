using System;
namespace DataStructures
{
    public class lsfr
    {

        private static int _state = 1001;
        public int Epochs { get; private set; }
        public int Coefficient { get; set; }
        private int Feed{ get; set; }
        private int Output;
        public lsfr(int epochs, int coefficient, int feed)
        {
            Epochs = epochs;
            Coefficient = coefficient;
            Feed = feed;
        }
        public int GenerateRandom()
        {
            for (var i = 0; i < Epochs; i++)
            {
                if(i == Feed)
                {
                    Output = _state;
                    return Output;
                }
                    
                var newBit = (_state ^ (_state >> 1)) & 1;
                _state = (_state >> 1) | (newBit << Coefficient); // arbitrary shift
            }
            return -1;
        }
    }
}