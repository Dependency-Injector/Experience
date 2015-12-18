using System;

namespace Model.Enums
{
    public class DifficultyLevel
    {
        public DifficultyLevel(Difficulty difficulty, String name)
        {
            Difficulty = difficulty;
            Name = name;
        }

        public string Name { get; }
        public Difficulty Difficulty { get; }
    }
}
