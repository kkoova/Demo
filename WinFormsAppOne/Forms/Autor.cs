using WinFormsAppOne.Logic;
using System.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
namespace WinFormsAppOne.Forms;

public partial class Autor : Form
{
    public Autor()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        var login = textBox1.Text;
        var password = textBox2.Text;

        if (string.IsNullOrEmpty(login) && string.IsNullOrEmpty(password)) return;
        var userId = AuthenticateUser(login, password);
        
    }
    
    public int AuthenticateUser(string username, string password)
    {
        using var connection = new SqlConnection(Connectont.connectionString);
        connection.Open();
        
        string query = "SELECT UserRole FROM [User] WHERE UserLogin = @UserLogin AND UserPassword = @UserPassword";
        var command = new SqlCommand(query, connection);
            
        command.Parameters.AddWithValue("@UserLogin", username);
        command.Parameters.AddWithValue("@UserPassword", password);
        
        using var reader = command.ExecuteReader();

        if (reader.Read())
        {
            return reader.GetInt32(0);
        }

        throw new InvalidOperationException("Пользователь не найден или неверный пароль");
    }
}