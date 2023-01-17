using Letter.Shared.Models;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace Letter.WebAPI.Models
{
    public class Aula
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }
        public String nome { get; set; }
        public Conteudo conteudo { get; set; }
    }
}
