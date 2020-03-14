using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._03
{
    class Program
    {
        static void Main(string[] args)
        {
            Copy work = new Copy();
            double tmp;
            var list = new List<Storage>();

            Console.WriteLine("-------------------------------------------");
            Storage flash = new Flash("Flash", "ZD213", 1600);
            flash.Show_info();
            flash.Copy_fails(300);
            tmp = flash.Get_info_free_memory();
            Console.WriteLine(" Free memory  => {0} Mb", tmp);
            Console.WriteLine("-------------------------------------------");

            Storage dvd = new DVD("DVD", "FFF", 3.5, 4.5, 2);
            dvd.Show_info();
            dvd.Copy_fails(500);
            tmp = dvd.Get_info_free_memory();
            Console.WriteLine(" Free memory  => {0} Mb", tmp);
            Console.WriteLine("-------------------------------------------");

            Storage hdd = new HDD("HDD", "Toshiba", 2, 3000);
            hdd.Show_info();
            hdd.Copy_fails(100);
            tmp = hdd.Get_info_free_memory();
            Console.WriteLine(" Free memory  => {0} Mb", tmp);
            Console.WriteLine("-------------------------------------------");
        
            list.Add(flash);
            list.Add(dvd);
            list.Add(hdd);

            work.Calculation_of_the_total_amount_of_memory_of_all_devices(list);
            work.Calculation_of_the_time_required_for_copying(16000);
            work.Calculation_of_the_required_number_of_information_carriers_of_the_presented_types_for_information_transfer(5000, 16000);
        }
    }
}

