using Flights;

Console.WriteLine(CheapestFlights.FindCheapestPrice(3, new int[][] { new int[] { 0, 1, 100 }, new int[] { 1, 2, 100 }, new int[] { 0, 2, 500 } }, 0, 2, 1));
Console.WriteLine(CheapestFlights.FindCheapestPrice(3, new int[][] { new int[] { 0, 1, 100 }, new int[] { 1, 2, 100 }, new int[] { 0, 2, 500 } }, 0, 2, 0));
Console.WriteLine(CheapestFlights.FindCheapestPrice(4, new int[][] { new int[] { 0, 1, 100 }, new int[] { 1, 2, 100 }, new int[] { 2, 0, 100 }, new int[] { 1, 3, 600 }, new int[] { 2, 3, 200 } }, 0, 3, 1));

