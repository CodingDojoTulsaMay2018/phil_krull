using DapperTest.Models;
using System.Collections.Generic;
namespace DapperTest.Factory
{
    public interface IFactory<T> where T : BaseEntity
    {
    }
}
