using Letter.WebAPI.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Letter.WebAPI.Services
{
    public class LetterService
    {
        public static string ConnectionName { get; set; }
        public static string DatabaseName { get; set; }
        public static string CollectionLetter { get; set; }

        private readonly IMongoCollection<Aula> _lettersCollection;

        public LetterService()
        {
            var mongoClient = new MongoClient(ConnectionName);
            var mongoDatabase = mongoClient.GetDatabase(DatabaseName);
            IMongoCollection<Aula> ConfigurationValue = mongoDatabase.GetCollection<Aula>(CollectionLetter);

            _lettersCollection = ConfigurationValue;
        }

        public async Task<List<Aula>> GetAsync() =>
            await _lettersCollection.Find(_ => true).ToListAsync();

        public async Task<Aula> GetAsync(string id) =>
            await _lettersCollection.Find(index => index.Id == id).FirstOrDefaultAsync();

        public async Task<Aula> GetSentenceSimpleAsync(string lesson) =>
            await _lettersCollection.Find(index => index.nome == lesson).FirstOrDefaultAsync();

        public async Task CreateAsync(Aula aula) =>
            await _lettersCollection.InsertOneAsync(aula);

        public async Task UpdateAsync(Aula aula) =>
            await _lettersCollection.ReplaceOneAsync(index => index.Id == aula.Id, aula);

        public async Task RemoveAsync(string id) =>
            await _lettersCollection.DeleteOneAsync(index => index.Id == id);

    }
}
