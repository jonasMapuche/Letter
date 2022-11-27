using Letter.Models;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Letter.Services
{
    public class LetterService
    {
        private static string ConnectionName { get; set; }
        private static string DatabaseName { get; set; }
        private static string CollectionLetter { get; set; }

        private readonly IMongoCollection<Aula> _lettersCollection;

        public LetterService()
        {
            ConnectionName = "mongodb://jonas:freedown@cluster0-shard-00-00.28oko.azure.mongodb.net:27017,cluster0-shard-00-01.28oko.azure.mongodb.net:27017,cluster0-shard-00-02.28oko.azure.mongodb.net:27017/?ssl=true&replicaSet=Cluster0-shard-0&authSource=admin&retryWrites=true&w=majority";
            DatabaseName = "letterDB";
            CollectionLetter = "letter";

            var mongoClient = new MongoClient(ConnectionName);
            var mongoDatabase = mongoClient.GetDatabase(DatabaseName);
            IMongoCollection<Aula> ConfigurationValue = mongoDatabase.GetCollection<Aula>(CollectionLetter);

            _lettersCollection = ConfigurationValue;
        }

        public List<Aula> GetAll() => _lettersCollection.Find(_ => true).ToList();

        public async Task<List<Aula>> GetAsync() =>
            await _lettersCollection.Find(_ => true).ToListAsync();

        public Aula Get(string id) => _lettersCollection.Find(index => index.Id == id).FirstOrDefault();

        public async Task<Aula> GetAsync(string id) =>
            await _lettersCollection.Find(index => index.Id == id).FirstOrDefaultAsync();

        public Aula GetSentenceSimple(string lesson) => _lettersCollection.Find(index => index.nome == lesson).FirstOrDefault();

        public async Task<Aula> GetSentenceSimpleAsync(string lesson) =>
            await _lettersCollection.Find(index => index.nome == lesson).FirstOrDefaultAsync();

        public void Create(Aula aula) => _lettersCollection.InsertOne(aula);

        public async Task CreateAsync(Aula aula) =>
            await _lettersCollection.InsertOneAsync(aula);

        public void Update(Aula aula) => _lettersCollection.ReplaceOne(index => index.Id == aula.Id, aula);

        public async Task UpdateAsync(Aula aula) =>
            await _lettersCollection.ReplaceOneAsync(index => index.Id == aula.Id, aula);

        public void Remove(string id) => _lettersCollection.DeleteOne(index => index.Id == id);

        public async Task RemoveAsync(string id) =>
            await _lettersCollection.DeleteOneAsync(index => index.Id == id);

    }
}
