using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.BrowserHistory
{
    public class Halaman
    {
        public string URL { get; }

        public Halaman(string url)
        {
            URL = url;
        }
    }

    
    public class HistoryManager
    {
        private LinkedList<Halaman> history;
        private LinkedListNode<Halaman> current;

        public HistoryManager()
        {
            history = new LinkedList<Halaman>();
            current = null;
        }

       
        public void KunjungiHalaman(string url)
        {
            var halamanBaru = new Halaman(url);
            if (current != null)
            {
                while (current.Next != null)
                {
                    history.RemoveLast();
                }
            }
            history.AddLast(halamanBaru);
            current = history.Last;
        }


        public string Kembali()
        {
            if (current == null || current.Previous == null)
            {
                return "Tidak ada halaman sebelumnya.";
            }

            current = current.Previous;
            return current.Value.URL;
        }


        public string LihatHalamanSaatIni()
        {
            return current != null ? current.Value.URL : "Tidak ada halaman saat ini.";
        }


        public void TampilkanHistory()
        {
            foreach (var halaman in history)
            {
                Console.WriteLine(halaman.URL);
            }
        }
    }
}
