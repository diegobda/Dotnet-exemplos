using System;
using System.Collections.Generic;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Criar uma lista de strings
            List<string> list = new List<string>();

            // Adicionar itens à lista
            list.Add("Name 1");
            list.Add("Name 2");
            list.Add("Name 3");

            // // Exibir itens da lista
            foreach (var name in list)
            {
                Console.WriteLine("Invitation");
            }


            // resolvendo pelo while condiçao
            var count = 0;
            while (count < list.Count)
            {
                Console.WriteLine("Invitation to the Parthy" + list[count]);
                count++;
                
            }

            /* Criar instância de Notifications e enviar notificações
            Notifications notifications = new Notifications();
            notifications.SendNotifications(list);

            Console.ReadLine();
            */
        }
    }

    public class Notifications
    {
        public void SendNotifications(List<string> messages)
        {
            foreach (var message in messages)
            {
                Console.WriteLine($"Notification sent: {message}");
            }
        }
    }
}
