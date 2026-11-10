namespace StudentRentalAndMushroomApp
{
    /// <summary>
    /// Represents a mushroom and its botanical characteristics according to the assignment requirements.
    /// </summary>
    public class Mushroom
    {
        public string Name { get; set; } = string.Empty;
        public bool HasGills { get; set; }
        public bool GrowsInForest { get; set; }
        public bool HasRing { get; set; }
        public bool HasConvexCup { get; set; }

        public Mushroom(string name, bool hasGills, bool growsInForest, bool hasRing, bool hasConvexCup)
        {
            Name = name;
            HasGills = hasGills;
            GrowsInForest = growsInForest;
            HasRing = hasRing;
            HasConvexCup = hasConvexCup;
        }

        /// <summary>
        /// Returns the value of a characteristic based on question ID (1 to 4).
        /// Question 1: Does your mushroom grow in a forest?
        /// Question 2: Does your mushroom have gills?
        /// Question 3: Does your mushroom have a ring?
        /// Question 4: Does your mushroom have a convex cup?
        /// </summary>
        public bool GetCharacteristic(int questionId)
        {
            switch (questionId)
            {
                case 1:
                    return GrowsInForest;
                case 2:
                    return HasGills;
                case 3:
                    return HasRing;
                case 4:
                    return HasConvexCup;
                default:
                    throw new System.ArgumentOutOfRangeException(nameof(questionId), "Invalid question identifier.");
            }
        }

        public override string ToString()
        {
            return Name;
        }
    }

    /// <summary>
    /// Represents one of the four identification questions.
    /// </summary>
    public class Question
    {
        public int Id { get; set; }
        public string Text { get; set; } = string.Empty;

        public Question(int id, string text)
        {
            Id = id;
            Text = text;
        }
    }
}