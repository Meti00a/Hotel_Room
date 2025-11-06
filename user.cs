namespace App;

class Secretary              //Inloggning för Sekreteraren.
{
    public string Username;
    string _password;

    public Secretary(string u, string p)
    {
        Username = u;
        _password = p;
        
    }

    public bool TryLogin(string username, string password)
    {
        return username == Username && password == _password;
    }
}