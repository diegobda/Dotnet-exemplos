namespace HelloWorld

List<string> list = new List<string>();
/*list.Add("Name 1");
Console.WriteLine(list[0];

list.Add("name 2");
Console.WriteLine(list[1];

list.Add("name 3");
Console.WriteLine(list[2];
*/

list.Add("Name 1");
list.Add("name 2");
list.Add("name 3");


Notifications notifications= new Notifications();
notifications.SendNotifications(list);
Console.ReadLine();