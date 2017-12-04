using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadingBevolkerung
{
    class Population
    {
        public Population() { }

        private int updateInterval = 1000;

        private decimal count = 0.0M;
        private decimal deceased = 0.0M;
        private decimal born = 0.0M;

        private decimal deathRate = 1.8M;
        private decimal warAddedDeathRate = 2.7M;
        private bool isWar = false;

        private decimal birthRate = 4.3M;

        private decimal warThreshold = 500.0M;
        private decimal warOffset = 500.0M;
        private decimal warStarter = 500.0M;
        private bool manualWar = false;

        #region Properties
        public decimal Count { get => count; set => count = value; }
        public decimal Deceased { get => deceased; set => deceased = value; }
        public decimal Born { get => born; set => born = value; }
        public decimal DeathRate { get => deathRate; set => deathRate = value; }
        public decimal BirthRate { get => birthRate; set => birthRate = value; }
        public bool IsWar { get => isWar; set => isWar = value; }
        public decimal WarAddedDeathRate { get => warAddedDeathRate; set => warAddedDeathRate = value; }
        public decimal WarThreshold { get => warThreshold; set => warThreshold = value; }
        public bool ManualWar { get => manualWar; set => manualWar = value; }
        public int UpdateInterval { get => updateInterval; set => updateInterval = value; }
        #endregion

        private Thread birthThread;
        private Thread deathThread;
        private Thread warThread;

        public void StartThreads()
        {
            birthThread = new Thread(DeathLoop);
            deathThread = new Thread(BirthLoop);
            warThread = new Thread(WarLoop);
            birthThread.Start();
            deathThread.Start();
            warThread.Start();
        }

        public void StopThreads()
        {
            if (birthThread != null)
                birthThread.Abort();
            if (deathThread != null)
                deathThread.Abort();
            if (warThread != null)
                warThread.Abort();
        }
        private void DeathLoop()
        {
            while (true)
            {
                if (count > 2)
                {
                    var diff = deathRate + ((IsWar) ? WarAddedDeathRate : 0.0M);
                    Count -= diff;
                    Deceased += diff;
                }
                Thread.Sleep(UpdateInterval);
            }
        }
        private void BirthLoop()
        {
            while (true)
            {
                count += BirthRate;
                Born += BirthRate;
                Thread.Sleep(UpdateInterval);
            }
        }
        private void WarLoop()
        {
            while (true)
            {
                if (IsWar)
                {
                    if (this.Count < (this.warStarter * 0.8M))
                    {
                        IsWar = false;
                    }
                    else
                    {
                        IsWar = true;
                    }
                }
                else if (this.Count>this.WarThreshold)
                {

                    IsWar = true;
                    this.warStarter = this.Count;
                    this.WarThreshold = (this.Count + this.warOffset) * 0.8M;
                }
                else
                {
                    IsWar = false;
                }
                Thread.Sleep(UpdateInterval);
            }
        }
    }
}
