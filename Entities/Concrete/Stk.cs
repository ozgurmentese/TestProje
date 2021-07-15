using Core.Entities;

namespace Entities.Concrete
{
    public class Stk : IEntity
    {
        public int Id { get; set; }
        public string MalKodu { get; set; }
        public string MalAdi { get; set; }
    }
}
