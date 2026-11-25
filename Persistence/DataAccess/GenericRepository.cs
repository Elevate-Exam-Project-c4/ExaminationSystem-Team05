using exam_system.Domain.Common;

namespace exam_system.Persistence.DataAccess;

public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
{
}
