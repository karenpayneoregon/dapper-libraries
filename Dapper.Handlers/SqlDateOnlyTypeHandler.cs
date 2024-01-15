using System.Data;
using Dapper;

namespace kp.Dapper.Handlers;

public class SqlDateOnlyTypeHandler : SqlMapper.TypeHandler<DateOnly>
{
    private static readonly TimeOnly _midnight = new(0, 0);
    public override void SetValue(IDbDataParameter parameter, DateOnly date) => parameter.Value = date.ToDateTime(_midnight);
    public override DateOnly Parse(object value) => DateOnly.FromDateTime((DateTime)value);
}