using MySql.Data.MySqlClient;

namespace Sistema
{
    public class MySql
    {
        public MySqlConnection GetConnection()
        {
            var arquivoIni = new IniFile("my.ini");
            var server = arquivoIni.Read("Server", "SERVIDOR");
            var database = arquivoIni.Read("Database", "SERVIDOR");
            var uid = arquivoIni.Read("Uid", "SERVIDOR");
            var pass = arquivoIni.Read("Password", "SERVIDOR");
            var port = arquivoIni.Read("Port", "SERVIDOR");

            string con = $"server={server};database={database};uid={uid};password={pass};port={port}";
            return new MySqlConnection(con);
        }
    }
}
