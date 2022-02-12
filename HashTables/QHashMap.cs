namespace DataStructures
{
    public class QHashMap<T1, T2>
    {
        private T1[] keys;
        private T2[] values;
        private bool[] isOccupied;
        private int size;

        private int count;
        public QHashMap(int size)
        {
            this.size = size;
            keys = new T1[size];
            values = new T2[size];
            isOccupied = new bool[size];
            count = 0;
        }

        public int Insert(T1 key, T2 value)
        {
            var isFree = false;
            while (!isFree)
            {
                var hash = GetHashCode();
                if (!isOccupied[hash])
                {
                    isFree = true;
                    keys[hash] = key;
                    values[hash] = value;
                    isOccupied[hash] = true;
                    count++;
                    return 0;
                }
            }
            Console.Error.Write("Something went wrong :/");
            return -1;
        }

        public int Remove(T1 key)
        {
            var idx = Search(key);
            if (idx != -1)
            {
                keys[idx] = default(T1)!;
                values[idx] = default(T2)!;
                isOccupied[idx] = false;
                count--;
                return 0;
            }
            Console.Error.Write("Could not find key");
            return -1;
        }

        public string ReadByKey(T1 key)
        {
            var idx = Search(key);
            if (idx != -1)
            {   
                return values[idx] == null ? "null" : values[idx].ToString();
            }
            Console.Error.Write("Could not find key");
            return "";
        }

        public string ReadAll()
        {
            var result = string.Empty;
            for (var i = 0; i < size; i++)
            {
                if (isOccupied[i])
                {
                    result += $"{keys[i]} -> {values[i]}\n";
                }
            }
            return result;
        }

        public int Update(T1 key, T2 Value)
        {
            var idx = Search(key);
            if (idx != -1)
            {
                values[idx] = Value;
                return 0;
            }
            Console.Error.Write("Could not find key");
            return -1;
        }

        //O(n)
        //todo - make it O(lgn)
        private int Search(T1 key)
        {
            for (var i = 0; i < keys.Length; i++)
            {
                if (keys[i]!.Equals(key))
                {
                    return i;
                }
            }
            return -1;
        }
        // Find nearest prime number
        // key % nearest prime number
        private new int GetHashCode()
        {
            var prime = GetFloorPrime();
            var num = GetRandomNumber();
            return prime % num;
        }

        //Helper functions
        private int GetRandomNumber()
        {
            return new Random().Next(1, size);
        }
        private int GetFloorPrime()
        {
            if (size == 1 || size == 2)
                return 2;
            var isPrime = false;
            var nearestPrime = size;
            var result = 0;
            while (!isPrime)
            {
                for (var i = 2; i < nearestPrime / 2; i++)
                {
                    if (nearestPrime % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                    isPrime = true;
                    result = nearestPrime;
                }
                nearestPrime++;
            }
            return result;
        }
    }
}