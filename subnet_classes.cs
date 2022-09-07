using System;
using System.Collections;

// CLASSES

namespace SubnetCalculator
{
    public class Subnet
    {
        public Subnet(int NetworkIP, int SubMask, int DefaultGateway, int FirstHostIP, int LastHostIP, int BroadcastIP, int subNetwork, int IPRequested, int subBuffer, int IPRange)
        {
            this.NetworkIP = NetworkIP;
            this.SubMask = SubMask;
            this.DefaultGateway = DefaultGateway;
            this.FirstHostIP = FirstHostIP;
            this.LastHostIP = LastHostIP;
            this.BroadcastIP = BroadcastIP;
            this.subNetwork = subNetwork;
            this.IPRequested = IPRequested;
            this.subBuffer = subBuffer;
            this.IPRange = IPRange;
        }
        public int NetworkIP { get; set; }
        public int SubMask { get; set; }
        public int DefaultGateway { get; set; }
        public int FirstHostIP { get; set; }
        public int LastHostIP { get; set; }
        public int BroadcastIP { get; set; }
        public int subNetwork { get; set; }

        // Request Info
        public int IPRequested { get; set; }
        public int subBuffer { get; set; }
        public int IPRange { get; set; }
    }

    public class Subnets : IEnumerable
    {
        private Subnet[] _subnet;
        public Subnets(Subnet[] uArray)
        {
            _subnet = new Subnet[uArray.Length];
            for (int i = 0; i < uArray.Length; i++)
            {
                _subnet[i] = uArray[i];
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }
        public SubnetsEnum GetEnumerator()
        {
            return new SubnetsEnum(_subnet);
        }
    }

    public class SubnetsEnum : IEnumerator
    {
        public Subnet[] _subnet;
        int currentIndex = -1;
        public SubnetsEnum(Subnet[] list)
        {
            _subnet = list;
        }
        public bool MoveNext()
        {
            currentIndex++;
            return (currentIndex < _subnet.Length);
        }
        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }
        public Subnet Current
        {
            get
            {
                try
                {
                    return _subnet[currentIndex];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }
        public void Reset()
        {
            currentIndex = -1;
        }
    }
}