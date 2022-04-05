namespace Flights
{
    public static class CheapestFlights
    {
        public static int FindCheapestPrice(int n, int[][] flights, int src, int dst, int k)
        {
            Dictionary<int, Dictionary<int, int>> prices = new Dictionary<int, Dictionary<int, int>>();

            foreach (int[] f in flights)
            {
                if (!prices.ContainsKey(f[0]))
                {
                    prices[f[0]] = new Dictionary<int, int>();
                }

                prices[f[0]].Add(f[1], f[2]);
            }

            if (prices.Count() == 0)
                return -1;

            SortedSet<Tuple<int, int, int>> lowestPrice = new SortedSet<Tuple<int, int, int>>();
            lowestPrice.Add(new Tuple<int, int, int>(0, src, k + 1));

            while (lowestPrice.Count > 0)
            {
                Tuple<int, int, int> min = lowestPrice.Min;
                lowestPrice.Remove(min);

                int current_price = min.Item1;
                int current_dst = min.Item2;
                int current_stop = min.Item3;

                if (current_dst == dst)
                {
                    return current_price;
                }

                if (prices.ContainsKey(current_dst) && current_stop > 0)
                {
                    Dictionary<int, int> next_dst = prices[current_dst];

                    foreach (KeyValuePair<int, int> ndst in next_dst)
                    {
                        lowestPrice.Add(new Tuple<int, int, int>(current_price + ndst.Value, ndst.Key, current_stop - 1));
                    }
                }
            }

            return -1;
        }
    }
}
