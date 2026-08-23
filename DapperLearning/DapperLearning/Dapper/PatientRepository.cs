using Dapper;
using DapperLearning.Models;
using Microsoft.Data.SqlClient;

namespace DapperLearning.Dapper;

public class PatientRepository(string connectionString)
{
    private readonly string _connectionString = connectionString;

    private SqlConnection Connection()
        => new(_connectionString);

    public async Task<IEnumerable<Patient>> GetAllAsync()
    {
        await using var connection = Connection();

        const string sql = """ SELECT Id, FirstName, LastName FROM Patients; """;

        return await connection.QueryAsync<Patient>(sql);
    }

    public async Task<Patient?> GetByIdAsync(Guid id)
    {
        await using var connection = Connection();

        const string sql = """ SELECT Id, FirstName, LastName FROM Patients WHERE Id = @Id; """;

        return await connection.QuerySingleOrDefaultAsync<Patient>(
            sql,
            new { Id = id });
    }

    public async Task AddAsync(Patient patient)
    {
        await using var connection = Connection();

        const string sql = """ INSERT INTO Patients (Id, FirstName, LastName) VALUES (@Id, @FirstName, @LastName); """;

        await connection.ExecuteAsync(sql, patient);
    }

    public async Task UpdateAsync(Patient patient)
    {
        await using var connection = Connection();

        const string sql = """ UPDATE Patients SET FirstName = @FirstName, LastName = @LastName WHERE Id = @Id; """;

        await connection.ExecuteAsync(sql, patient);
    }

    public async Task DeleteAsync(Guid id)
    {
        await using var connection = Connection();

        const string sql = """ DELETE FROM Patients WHERE Id = @Id; """;

        await connection.ExecuteAsync(sql, new { Id = id });
    }
}