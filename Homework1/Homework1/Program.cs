using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
             * nu am cum sa fac poze cu telefonul deoarece nu imi merge camera asa ca o sa scriu justificarea aici:
             * m-am gandit cum pot sa aflu de cate ori s-a dublat puterea pentru un anumit numar n si
             * am ajuns la concluzia ca daca impart numarul pana cand acesta este mai mic sau egal cu 2
             * imi da aproximativ numarul de "dublari" (counter) a puterii
             * ca sa afisez rezultatul corect in ani am folosit float deoarece imi aproximeaza rezultatul mai bine
             * si l-am inmultit cu 18(numarul de luni la care se dubleaza puterea) si apoi l-am impartit la 12 (ca sa aflu numarul de ani)
             */

            int n; //initializare n ca si integer.
            
            Console.Write("Introduceti n: "); //scriem un mesaj la consola.
            n = int.Parse(Console.ReadLine()); //introducem numarul in consola de la tastatura ca fiind de tip int.
            
            int counter = 0; //initializare counter ca si integer.
            float aux = n; //initializare aux ca si float.
            
            /* 
             * while este folosit pentru a vedea de cate ori se poate imparti n la 2
             * am limitat aux sa fie mai mare sau egal decat 2 pentru ca while sa se opreasca.
             */ 
            while (aux >= 2)  
            {
                aux = aux / 2; 
                counter++;
            }
            float result = (float)counter * 18/12; //am folosit ca si timp de dublare a puterei de calcul 18 luni si am calculat result ca fiind in ani
            
            Console.Write("dupa aproximativ " + result + " ani puterea de calcul se va imbunatati de " + n + " ori"); //afisarea la consola a rezultatului
            Console.ReadKey();

        }
    }
}
