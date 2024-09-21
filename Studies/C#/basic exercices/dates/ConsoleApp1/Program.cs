using System;
using System.Globalization;

namespace datas {
    class Program {
        static void Main(string[] args) {
            DateTime data = DateTime.UtcNow;

            DateTime novadata = data.AddMinutes(3200);
            novadata = data.AddHours(320);
            novadata = data.AddDays(32);

            Console.WriteLine(data);
            Console.WriteLine(novadata);

        }
    }
}

