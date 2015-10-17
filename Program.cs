using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using GUI;

namespace tank_game
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //GameManager manager = GameManager.GetInstance();
                
                
                Console.Title = "Mustank Console";
                Console.WriteLine("Server started...");
                util.Communicator com = util.Communicator.GetInstance();
                com.StartListening();
                Gui gui = new Gui();
                Application.Run(gui);


                /*Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
              //GUI.GUI gui = new GUINormal();
                GUI.GUII gui = new GUINormal();
                
                manager.SetGUI(gui);
                Application.Run((Form)gui);
                while (!GameEngine.GetInstance().GameFinished) //To keep the thread alive
                {
                    Thread.Sleep(500);
                }
                Console.ReadLine();
                 */
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }
    }
}
