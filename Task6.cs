using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SubjectObserver
{
    class Program
    {
        static DataTrnsferHandler thandler; 
        static GUIWindow form;                
        static TransferDataNotification DataRecieved;  
        static FileLogger logger;        

        static void Main(string[] args)
        {
            startOUI();
        }

        public static void startOUI()
        {
            thandler = new DataTrnsferHandler();
            thandler.InitializationComplete();
            DataRecieved = new TransferDataNotification(thandler);
            logger = new FileLogger(thandler);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new GUIWindow(thandler));
        }
    }
}
