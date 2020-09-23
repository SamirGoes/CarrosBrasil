using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace CarrosBrasil.Infra.Data.Models
{
    public class FrotaMunicipio
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public Guid Id { get; set; }
        public string UF { get; set; }

        public string Municipio { get; set; }

        public string Marca { get; set; }

        public string Modelo { get; set; }

        public int AnoFabricacao { get; set; }

        public int QuantidadeVeiculo { get; set; }
    }
}