using System;
using Homework4.Models.Interfaces;

namespace Homework4.Models
{
    public class DbUserInfoEntity : IDbEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
    }
}
