using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }


    public class BastaManager
    {

        public async Task<List<string>> loadSpeakersAsync(CancellationToken token = default(CancellationToken), IProgress<int> progress = null)
        {
            var task = Task.Factory.StartNew(() =>
            {
                var list = new List<string>();
                for (int i = 0; i <= 10; i++)
                {
                    if (progress != null)
                        progress.Report(i * 10);
                    if (token.IsCancellationRequested)
                        return list;

                    token.ThrowIfCancellationRequested();

                    Thread.Sleep(500);
                    list.Add("Thomas der " + i + "\n\r");
                }
                return list;
            });

            List<string> result = await task;
            result.Add("Ingo");
            return result;
        }
        public async Task<List<string>> loadSessionAsync()
        {
            var task = Task.Factory.StartNew(() =>
             {
                 var list = new List<string>();
                 Thread.Sleep(3000);
                 for (int i = 0; i <= 10; i++)
                 {
                     list.Add("Session " + i + "\n\r");
                 }

                 return list;
             });

            List<string> result = await task;
            result.Add("Session bla");
            return result;
        }


        public async Task LogStuff(string log)
        {

            using (var sw = new StreamWriter("logfile.txt"))
            {
                await sw.WriteAsync(log);
            }
        }

    }
}
