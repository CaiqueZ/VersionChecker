using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net; // Lembre-se de adicionar o "System.Net;" para que o WebClient funcione corretamente!
using System.Windows.Forms;

namespace VersionChecker
{
    public partial class Base : Form
    {
        public Base()
        {
            InitializeComponent();
        }

        private void Base_Load(object sender, EventArgs e)
        {
            //Versão Local do programa
            string appVersion = "v0.0.1";  // Recomendo verificar a versão com base em um arquivo separado, onde vai conter demais informações importantes! (Você pode criar sua própria extensão, e lá criptografar os dados, quando o programa puxar as informações o mesmo já realiza a leitura e descriptografa)
            lblLocalVersion.Text = "Version: " + appVersion;
            
            //WebClient, puxa a referente informação da Web, nesse caso faço um request na referente URL e consigo obter uma string (A string é a última versão dispinibilizada no servidor).
            WebClient client = new WebClient();
            string getUpdate = client.DownloadString("https://pastebin.com/raw/T1QJeVm3");

            //Versão Online do programa após ser coletada é informada visualmente
            lblNewerVersion.Text = "Last Update: " + getUpdate;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
