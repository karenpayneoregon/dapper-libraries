using Dapper;
using Microsoft.Data.SqlClient;
using System.Data;
using kp.Dapper.Handlers;
using sqlserverApp.Models;

namespace sqlserverApp.Classes;
internal class Operations
{
    private IDbConnection _cn;
    /// <summary>
    /// Setup connection and DateOnly and TimeOnly handlers from Dapper.Handlers class project or NuGet package
    /// </summary>
    public Operations()
    {
        _cn = new SqlConnection(ConnectionString());
        SqlMapper.AddTypeHandler(new SqlDateOnlyTypeHandler());
        SqlMapper.AddTypeHandler(new SqlTimeOnlyTypeHandler());
    }

    public List<Test1> GetAll()
        => _cn.Query<Test1>("SELECT Id, DateOnly, TimeOnly FROM dbo.Test1;").ToList();
}