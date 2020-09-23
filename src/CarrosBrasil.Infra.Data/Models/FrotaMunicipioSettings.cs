using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace CarrosBrasil.Infra.Data.Models
{
    public class FrotaMinicipioSettings : IFrotaMinicipioSettings
    {
        public string FrotaCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }

    public interface IFrotaMinicipioSettings
    {
        string FrotaCollectionName { get; }
        string ConnectionString { get; }
        string DatabaseName { get; }
    }
}