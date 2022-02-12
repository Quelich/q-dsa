namespace DataStructures
{

    class QHashMap<T1, T2>
    {
        private T1[] keys;
        private T2[] values;
        private bool[] isOccupied;
        private int size;

        private int count;
        QHashTable(int size)
        {
            this.size = size;
            hashTable = new int[size];
            isOccupied = new bool[size];
            count = 0;
        }

        void Insert(T1 key, T2 value)
        {

            // increment count
        }

        void Remove(T2 value)
        {
            // decrement count
        }

        void Read(T1 key)
        {

        }

        void Update(T item, int idx)
        {

        }

        // Find nearest prime number
        // key % nearest prime number
        void HashCode()
        {

        }

        void Print()
        {

        }

        //Helper functions
        private int FindNearestPrime()
        {
            if (size == 1 || size == 2)
                return 2;
            var isPrime = false;
            var num = size;
            while (!isPrime)
            {
                int nearestPrime;
                for (var i = 2; i < num / 2; ++i)
                {
                    if (num % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                    else
                    {
                        isPrime = true;
                        nearestPrime = num;
                        return nearestPrime;
                    }
                }
                num++;
            }
            return 0;
        }
    }
}