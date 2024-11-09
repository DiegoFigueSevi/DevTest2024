using Back.Domain.models;

namespace Back.AuxDataBase;

public class AuxDb
{
    public static List<Poll> Polls = new List<Poll>
    {
        new Poll
        {
            Id = 1,
            Name = "Favorite programming language",
            Options =
            [
                new PollItem
                {
                    Id = 1,
                    Name = "C#",
                    Votes = 150,
                },
                new PollItem
                {
                    Id = 2,
                    Name = "Java",
                    Votes = 200
                }
            ]
        },
        new Poll
        {
            Id = 2,
            Name = "Best Framworks",
            Options =
            [
                new PollItem
                {
                    Id = 1,
                    Name = "ASP.NET",
                    Votes = 120
                },
                new PollItem
                {
                    Id = 3,
                    Name = "Angular",
                    Votes = 200
                }
            ]
        }
    };
}