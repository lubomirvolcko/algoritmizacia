using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerovanieTiketov
{
    class Program
    {
       

        static void Main(string[] args)
        {
            ArrayList tickets = new ArrayList();
            
            int[] temp, checkTemp;
            int i = 0, checkEquals = 0;

            while(i < 30)
            {
                Console.WriteLine("size of tickets is: " + i);
                temp = generateTicket();

                if (i == 0)
                {
                    tickets.Add(temp);
                    i++;
                }else
                {
                    int count = tickets.Count;

                    for (int x = 0; x < count; x++)
                    {
                        checkTemp = (int[])tickets[x];
                        for (int z = 0; z < 5; z++)
                        {
                            for (int y = 0; y < 5; y++)
                            {
                                if (temp[z] == checkTemp[y])
                                    checkEquals++;
                            }
                        }
                    }
                    if (checkEquals < 4)
                    {
                        tickets.Add(temp);
                        checkEquals = 0;
                        i++;
                    }
                }
                
                

                if (i > 0)
                {
                    int p = 0;
                    foreach (int[] item in tickets)
                    {
                        p++;
                        Console.WriteLine("");
                        Console.WriteLine(" #########    Ticket "+p+" :");
                        for (int z = 0; z < 5; z++)
                        {
                            Console.Write(item[z] + " | ");
                        }

                    }
                }
                checkEquals = 0;

                Console.WriteLine("");
                Console.WriteLine(" ------------------------------------------------------ ");
                Console.WriteLine("");
                Console.WriteLine("");
            }

            

            

            Console.ReadKey();
        }

        static int[] generateTicket()
        {
            Random rnd = new Random();
            int[] ticket = new int[5];
            int i = 0;

            while (i < 5)
            {
                int num = rnd.Next(1, 11);
                //Console.WriteLine(num);

                if (!ticket.Contains(num))
                {
                    ticket[i] = num;
                    i++;
                }
            }
            Console.WriteLine("");
            Console.WriteLine("Generated: ");
            for (int x = 0; x < ticket.Length; x++)
            {
                Console.Write(ticket[x] + " | ");
            }

            Console.WriteLine("");
            return ticket;
        }

        
    }
}
