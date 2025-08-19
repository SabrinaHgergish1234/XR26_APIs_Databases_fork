using SQLite; // Needed for [PrimaryKey] and [AutoIncrement]

public class HighScore
{
    [PrimaryKey, AutoIncrement]
    public int Id { get; set; }
    public string PlayerName { get; set; }
    public int Score { get; set; }
    public string LevelName { get; set; }
}
