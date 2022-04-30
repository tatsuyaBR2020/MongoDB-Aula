using MongoDB.Driver;
using MongoDB;
using System;

public class ConnectMongoDB
{
    IMongoCollection<Anime> collection;
    public ConnectMongoDB()
    {
        var client = new MongoClient("mongodb+srv://Teste:Salve2022@anime.mho5n.mongodb.net/myFirstDatabase?retryWrites=true&w=majority");
        var datanase = client.GetDatabase("Animes");
        collection = datanase.GetCollection<Anime>("_animes");
    }

    public void AddAnime()
    {
        Console.WriteLine("Digite o nome do anime!");
        var nome = Console.ReadLine();
        Console.WriteLine("Digite uma descrição desse anime!");
        var description = Console.ReadLine();

        var _anime = new Anime()
        {
            Name = nome,
            Description = description
        };

        collection.InsertOne(_anime);
    }

    public Anime FindAnime(string name)
    {
        if(collection.Find(g => g.Name == name).Any())
        {
            return collection.Find(g => g.Name == name).First();
        }

        return new Anime();
    }

    public void ReplaceAnime(string old, Anime newAnime)
    {
        var _anime = collection.Find(g => g.Name == old).First();
        if (newAnime.Description != _anime.Description && newAnime.Description != "")
            _anime.Description = newAnime.Description;
        if (newAnime.Name != _anime.Name && newAnime.Name != "")
            _anime.Name = newAnime.Name;

        collection.ReplaceOne(g => g.Name == old, _anime);
    }
}