using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1063778_Prasetyo_HuntTheWumpus
{
    class HighScore
    {
        

        List<HighScore> TopScores = new List<HighScore>();
        
        internal class Score
        {
            public string name { get; set; }
            public string turns { get; set; }
            public string coins { get; set; }
            public string arrows { get; set; }
            public int score { get; set; }
        }

        
        //make array for data
        public HighScore()
        {
            
        }

        //public HighScore(String n, String t, String c, String a, int s)
        //{
        //    Name = n;            
        //    turns = t;
        //    coins = c;
        //    arrows = a;
        //    Score = s;
        //}

        //public void AddNewScore()
        //{
        //    HighScore addScore = new HighScore(name, turns, coins, arrows, Score);
        //    TopScores.Add(addScore);

        //    TopScores = TopScores.OrderByDescending(x => x.Score).ToList(); // check this later

        //    if (TopScores.Count > 10) 
        //    {
        //        TopScores.RemoveAt(10);

        //    }
        //    WriteToFile();
        //}

            //reads data from file, orders data from top 10, going down
        public (IReadOnlyList<Score> topTen, int? thisGameIndex) RecordGame(Score score)
        {
            List<Score> topTen = ReadFromFile().ToList();
            topTen.Add(score);
            topTen = topTen.OrderByDescending((x) => x.score).Take(10).ToList();
            int gameIndex = topTen.IndexOf(score);
            SaveScoresToDisk(topTen);
            return (topTen, gameIndex);
        }

        //saves data, writes data, adds coins, arrows, score, etc.
        private void SaveScoresToDisk(List<Score> scoresToSave)
        {
            List<string> scores = new List<string>();
            foreach (Score score in scoresToSave)
            {
                scores.Add($"{score.name}\t{score.turns}\t{score.coins}\t{score.arrows}\t{score.score}");
            }
            File.WriteAllLines(@"HighScoreData.txt", scores);
        }
        

        private String[] highScoreData;

        
        public List<Score> ReadFromFile()
        {
        
            highScoreData = File.ReadAllLines(@"HighScores.txt");

            List<Score> scores = new List<Score>();
            foreach (string row in highScoreData)
            {
                string[] splitRow = row.Split('\t');
                scores.Add(
                    new Score()
                    {
                        name = splitRow[0],
                        turns = splitRow[1],
                        coins = splitRow[2],
                        arrows = splitRow[3],
                        score = int.Parse(splitRow[4]),
                    });
            }
            return scores;
        }
        
        public List<Score> TopScore
        {
            get => ReadFromFile(); 

        }


        // while (record != null)
        //            {

        //                String[] data = record.Split('t');
        //                TopScores.Add(new Score(data[0], int.Parse(data[1]),
        //                record = sr.ReadLine()
        //            }

        //public void WriteToFile()
        //{
        //    List<String> stringHighscores = new List<String>();

        //    StreamWriter sw = new StreamWriter("TopScores.txt");          
        //}

        ////TopScores = TopScores.OrderByDescending(x => x.); 


        //        //Scores score = new Scores [10];
        //public void Leaderboard() { }

        //public List<Scores> GetTopTen()
        //{
        //    return scores;
        //}

        //public Scores GetScores(int index)
        //{
        //    if (index >= 10 && index < scores.Count)
        //    {
        //        return scores[index];
        //    }
        //    else return null;
        //}
        //public void AddNewScore(Scores sc)
        //{

        //    foreach (Scores sc in scores)
        //    scores.Add(sc);
        //    {
        //    //write score out to file
        //    WriteToFile();
        //    }

        //}

        //public void ReadFromFile()
        //{
        //    StreamReader sr = new StreamReader("highscoreInfo");

        //    //record

        //}

        //dont use internal, make class public
        //make highscore seperate for each map, or use array
        //2d array, y1 is name, y2 score, or write to file, probably doing write to file, use an array to hold info

        //public int GetName { get; set; }
        //public int GetScore { get; set; }
        //public int GetTurns { get; set; }
        //public int GetCoins { get; set; }
        //public int GetArrows { get; set; }


    }

}

