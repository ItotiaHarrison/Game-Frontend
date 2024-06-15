using Gamestore.Frontend.Models;

namespace Gamestore.Frontend.Clients;

public class GamesClient
{
     private readonly List<GameSummary> games = [
    new(){
        Id = 1,
        Name = "Street Fighter II",
        Genre = "Action",
        Price = 10.0M,
        ReleaseDate = new DateOnly(2001, 1, 1)
    },
    new(){
        Id = 2,
        Name = "Super Mario Bros",
        Genre = "Platform",
        Price = 5.0M,
        ReleaseDate = new DateOnly(1995, 1, 1)
    },
    new(){
        Id = 3,
        Name = "The Legend of Zelda",
        Genre = "Adventure",
        Price = 15.0M,
        ReleaseDate = new DateOnly(1998, 1, 1)
    }
    ];

    public GameSummary[] GetGames() => [.. games];
}
