string[] snacks = { "sushi", "pizza", "burger", "chicken wings", "asian takeaway" };

Random rnd = new Random();

int RandomIndex = rnd.Next(0, snacks.Length);

Console.WriteLine($"Eat {snacks [RandomIndex]}");