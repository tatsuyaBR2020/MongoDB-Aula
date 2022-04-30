using MongoDB.Driver;

public class MongoDBContext
{
    public bool TemAnime(string name)
    {
        var client = new MongoClient("mongodb+srv://Teste:Salve2022@animes.mho5n.mongodb.net/myFirstDatabase?retryWrites=true&w=majority");
        var database = client.GetDatabase("Animes");
        var collection = database.GetCollection<Anime>("_animes");
        return collection.Find<Anime>(g => g.Name == name).Count() > 0;
    }
}
