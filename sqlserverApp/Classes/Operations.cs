﻿using Dapper;
using Microsoft.Data.SqlClient;
using System.Data;
using kp.Dapper.Handlers;
using sqlserverApp.Models;
using static System.DateTime;

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

    public async Task<List<Test1>> GetAllAsync()
        => (await _cn.QueryAsync<Test1>("SELECT id, GenderType FROM Genders")).AsList();

    public bool Update()
    {
        var statement = "UPDATE dbo.Test1 SET DateOnly = @dataonly,TimeOnly = @timeonly  WHERE Id = @id";
        var affected = _cn.Execute(statement, new
        {
            dataonly = DateOnly.FromDateTime(Now),
            timeonly = TimeOnly.FromDateTime(Now),
            id = 10
        });

        return affected == 1;
    }
}