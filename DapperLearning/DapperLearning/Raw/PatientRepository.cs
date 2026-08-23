using DapperLearning.Models;
using Microsoft.Data.SqlClient;
using DapperLearning.Dapper;

namespace DapperLearning.Raw;

public class PatientRepository(string connectionString)
{
    private readonly string _connectionString = connectionString;

    private async Task<SqlConnection> Connection()
    {
        var connection = new SqlConnection(_connectionString);
        await connection.OpenAsync();
        return connection;
    }

    public async Task<IEnumerable<Patient>> GetAllAsync()
    {
        await using var connection = await Connection();

        await using var command = new SqlCommand(
            "SELECT Id, FirstName, LastName FROM Patients",
            connection);

        await using var reader = await command.ExecuteReaderAsync();

        var patients = new List<Patient>();

        while (await reader.ReadAsync())
        {
            patients.Add(new Patient
            {
                Id = reader.GetGuid(0),
                FirstName = reader.GetString(1),
                LastName = reader.GetString(2)
            });
        }

        return patients;
    }

    public async Task<Patient?> GetByIdAsync(Guid id)
    {
        await using var connection = await Connection();

        await using var command = new SqlCommand(
            "SELECT Id, FirstName, LastName FROM Patients WHERE Id = @Id",
            connection);

        command.Parameters.AddWithValue("@Id", id);

        await using var reader = await command.ExecuteReaderAsync();

        if (!await reader.ReadAsync())
            return null;

        return new Patient
        {
            Id = reader.GetGuid(0),
            FirstName = reader.GetString(1),
            LastName = reader.GetString(2)
        };
    }

    public async Task AddAsync(Patient patient)
    {
        await using var connection = await Connection();

        await using var command = new SqlCommand(
            "INSERT INTO Patients VALUES (@Id, @FirstName, @LastName)",
            connection);

        command.Parameters.AddWithValue("@Id", patient.Id);
        command.Parameters.AddWithValue("@FirstName", patient.FirstName);
        command.Parameters.AddWithValue("@LastName", patient.LastName);

        await command.ExecuteNonQueryAsync();
    }

    public async Task UpdateAsync(Patient patient)
    {
        await using var connection = await Connection();

        await using var command = new SqlCommand(
            """UPDATE Patients SET FirstName = @FirstName, LastName = @LastName WHERE Id = @Id """,
            connection);

        command.Parameters.AddWithValue("@Id", patient.Id);
        command.Parameters.AddWithValue("@FirstName", patient.FirstName);
        command.Parameters.AddWithValue("@LastName", patient.LastName);

        await command.ExecuteNonQueryAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        await using var connection = await Connection();

        await using var command = new SqlCommand(
            "DELETE FROM Patients WHERE Id = @Id",
            connection);

        command.Parameters.AddWithValue("@Id", id);

        await command.ExecuteNonQueryAsync();
    }
}