using System.Text.Json;

namespace _2048Game.Common
{
    public static class TheBestScoreFile
    {
        public static void Add(int score)
        {
            string json = JsonSerializer.Serialize(score);
            File.WriteAllText(FilePath.GetScorePath(), json);
        }
        public static int GetScore()
        {
            string json = File.ReadAllText(FilePath.GetScorePath());
            return JsonSerializer.Deserialize<int>(json);
        } 
    }
}
