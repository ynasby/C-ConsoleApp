using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstMeeting
{
    class Variables
    {
        /*
    Переменная доступна (грубо) внутри тех фигурных скобок, где она определена. Область кода, из которой допустимо 
 обращение к переменной, называется "областью видимости"
    Локальная переменная "перекрывает" глобальную с тем же именем.
    Однако локальная переменная не может перекрыть другую локальную переменную с тем же именем — возникнет ошибка компиляции.       
        */
        static string globalVariable = "Global variable";

        static void MethodA()
        {
            if (globalVariable == "")
            {
                string temporalVariable = "Temporal variable";
                Console.WriteLine(temporalVariable);
            }

            string localVariable = "Local variable";

            // Так можно — эта переменная используется в той же области, где и объявлена:
            Console.WriteLine(localVariable);

            // Так нельзя — temporalVariable определена только внутри блока if:
            // Console.WriteLine(temporalVariable); 
        }

        static void MethodB()
        {
            // Console.WriteLine(localVariable); //Нельзя — переменная определена в другом методе.
            Console.WriteLine(globalVariable); //Можно — это глобальная переменная

        }
    }
}
