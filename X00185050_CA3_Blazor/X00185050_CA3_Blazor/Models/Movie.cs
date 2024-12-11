namespace X00185050_CA3_Blazor.Models;

public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Poster_Path { get; set; } = string.Empty;
        public double vote_Average;
        public string Overview { get; set; } = string.Empty;
        public DateOnly Release_Date { get; set; }
        public List<int> Genre_Ids { get; set; } = new();
        public List<Genre> Genres { get; set; } = new();
        public string Tagline { get; set; } = string.Empty;
        public int Runtime { get; set; }
        public long Budget { get; set; }
        public long Revenue { get; set; }
        public string Homepage { get; set; } = string.Empty;

        public double Vote_Average
        {
            get => Math.Round(vote_Average, 1);
            set => vote_Average = value;
        }

        public string FormatDate()
        {
            var date = Release_Date.ToDateTime(TimeOnly.MinValue);
            int day = date.Day;
            string suffix = day switch
            {
                1 or 21 or 31 => "st",
                2 or 22 => "nd",
                3 or 23 => "rd",
                _ => "th"
            };
            return $"{day}{suffix} {date:MMMM yyyy}";
        }
    }

    public class Genre
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
    }
