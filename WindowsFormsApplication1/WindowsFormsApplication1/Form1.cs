using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        CancellationTokenSource _cts;
        public Form1()
        {
            InitializeComponent();
        }

        private async void btn_Laden_Click(object sender, EventArgs e)
        {
            var manager = new BastaManager();
            var watch = new Stopwatch();
            _cts = new CancellationTokenSource();
            watch.Start();

            //int __state = 0;
            //TaskAwaiter<List<string>> __speakerAwaiter;
            //TaskAwaiter __logAwaiter;
            //Action doIt = default(Action);
            //doIt = () =>
            //{
            //    switch (__state)
            //    {
            //        case 0:
            //            __speakerAwaiter = manager.loadSpeakersAsync().GetAwaiter();
            //            if (__speakerAwaiter.IsCompleted)
            //            {
            //                goto case 1;
            //            }
            //            else
            //            {
            //                __state = 1;
            //                __speakerAwaiter.OnCompleted(doIt);
            //            }
            //            break;
            //        case 1:
            //            List<string> speakerList = __speakerAwaiter.GetResult();
            //            txt_left.Text = String.Join(String.Empty, speakerList);
            //            watch.Stop();

            //            __logAwaiter = manager.LogStuff((watch.ElapsedMilliseconds / 1000.0 + " s")).GetAwaiter();

            //            if (__logAwaiter.IsCompleted)
            //            {
            //                goto case 2;
            //            }
            //            else
            //            {
            //                __state = 2;
            //                __logAwaiter.OnCompleted(doIt);
            //            }
            //            break;
            //        case 2:
            //            Process.Start("logfile.txt");
            //            break;
            //        default:
            //            break;
            //    }
            //};

            //doIt();

            List<string> spkrlist = await manager.loadSpeakersAsync(_cts.Token, new Progress<int>(result => progressBar1.Value = result));
            txt_left.Text = String.Join(String.Empty, spkrlist);


            watch.Stop();

            await manager.LogStuff((watch.ElapsedMilliseconds / 1000.0) + "s");
            Process.Start("logfile.txt");

            //Task<List<string>> speakerList = manager.loadSpeakersAsync();

            //List<string> lista = await speakerList;






            //foreach (var item in lista)
            //{
            //    txt_left.Text += item.ToString() + " \n";
            //}


            //watch.Stop();

            //await manager.LogStuff(watch.ElapsedMilliseconds / 1000.0 + "s");
            //Process.Start("logfile.txt");
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            if (_cts != null && !_cts.IsCancellationRequested)
            {
                _cts.Cancel();

            }
        }
    }
}
