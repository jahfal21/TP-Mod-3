using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul3_1302204034
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Jahfal Mudrik Ramadhan_1302204034");
            KodePos table_Kodepos = new KodePos();
            Console.Write("Kelurahan: ");
            table_Kodepos.getKodepos(Console.ReadLine());
            Console.WriteLine("       Kode Pos Kelurahan       ");
            table_Kodepos.getAllkodepos();

            Console.WriteLine("           Door Machine           ");
            DoorMachine pintu = new DoorMachine();
            pintu.kunci();


        }

    }
    class KodePos
    {

        Dictionary<string, string> dic = new Dictionary<string, string>() {
            {"Kelurahan", "Kode Pos"},
            {"Batununggal", "40266"},
            {"Kujangsari", "40287"},
            {"Mengger", "40267"},
            {"Wates",   "40256"},
            {"Cijaura", "40287"},
            {"Jatisari", "40286"},
            {"Margasari", "40286"},
            {"Sekejati", "40286"},
            {"Kebonwaru", "40272"},
            {"Maleer", "40274"},
            {"Samoja", "40273"} };

        public void getKodepos(string kel)
        {
            if (dic.ContainsKey(kel))
            {
                Console.WriteLine(kel + " : " + dic[kel]);
            }
            else
            {
                Console.WriteLine(kel + " tidak ditemukan");
            }
        }

        public void getAllkodepos()
        {
            foreach (KeyValuePair<string, string> ele1 in dic)
            {
                Console.WriteLine("{0} \t\t {1}", ele1.Key, ele1.Value);
            }
        }
    }


    class DoorMachine
    {
        enum State { TERKUNCI, TERBUKA };
        public void kunci()
        {
            State state = State.TERKUNCI;

            String[] screenName = { "Terkunci", "Tidak Terkunci"};
            do
            {
                Console.WriteLine("Pintu " + screenName[(int)state]);
                Console.Write("Buka Pintu atau Kunci Pintu? ");
                String command = Console.ReadLine();
                switch (state)
                {
                    case State.TERKUNCI:
                        if (command == "Buka Pintu")
                        {
                            state = State.TERBUKA;
                        }
                        break;
                    case State.TERBUKA:
                        if (command == "Kunci Pintu")
                        {
                            state = State.TERKUNCI;
                        }
                        break;
                }
            } while (state != State.TERKUNCI);
        }
    }
}
