var videoGames = new List<string>() {"Dragon Age: Inquisition", "Destiny", "Apex: Legends", "Call of Duty", "Halo", "Assassin's Creed" };
videoGames.OrderBy(x => x.Length).ToList().ForEach(x => Console.WriteLine(x));
