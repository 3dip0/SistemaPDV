using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;

namespace Sistema
{
    public class IniFile
    {
        string path = Assembly.GetExecutingAssembly().GetName().Name;

        // Importação da biblioteca do Windows
        [DllImport("kernel32", CharSet = CharSet.Unicode)]
        static extern int GetPrivateProfileString(string Section, string Key, string Default, StringBuilder RetVal, int Size, string FilePath);

        // Declaração do arquivo INI
        public IniFile(string IniPath = null)
        {
            path = new FileInfo(IniPath).FullName;
        }

        // Função que faz a leitura das chaves arquivo INI
        public string Read(string Key, string Section = null)
        {
            var RetVal = new StringBuilder(255);
            GetPrivateProfileString(Section, Key, "", RetVal, 255, path);
            return RetVal.ToString();
        }
    }
}
