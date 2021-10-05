using System;

namespace C__Version
{
    class Program
    {
        static void Main(string[] args){
            OptionsMenu1();
        }


        static void OptionsMenu1(){
            short curItem = 0, c;

            ConsoleKeyInfo key;

            string[] menuItems = { "One", "Two", "Three", "Four" };
            do {
                Console.Clear();

                Console.WriteLine("Pick an option . . .");

                for (c = 0; c < menuItems.Length; c++) {
        
                    if (curItem == c){
                        Console.Write(">>");
                        Console.WriteLine(menuItems[c]);
                    }
                    else{
                    Console.WriteLine(menuItems[c]);
                    }
                }

 
            Console.WriteLine("Select your choice with the arrow keys.");
            key = Console.ReadKey(true);
            if (key.Key.ToString() == "DownArrow"){
                curItem++;
                if (curItem > menuItems.Length - 1) curItem = 0;
            }
            else if (key.Key.ToString() == "UpArrow"){
                curItem--;
                if (curItem < 0) curItem = Convert.ToInt16(menuItems.Length - 1);
            }
            } while (key.KeyChar != 13);
            String keyEquiv = key.Key.ToString();

            if (keyEquiv.CompareTo("Enter") == 0){
                Console.WriteLine("maybe it work?");
            }
        }


        static void LockScreen(){

            string pswd = "Password";

            string divider1 = "============================";
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (divider1.Length / 2)) + "}", divider1));
            string title = "PASSWORD VAULT";
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (title.Length / 2)) + "}", title));
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (divider1.Length / 2)) + "}", divider1));
            Console.WriteLine("Enter your password");
            string ReadPassword = (Console.ReadLine());
            if (ReadPassword == pswd) {
                HomeScreen();

            }
            
            else {
                Console.WriteLine("You got the password wrong you fake, get outta here.");
            }
        
        }

        static void HomeScreen(){
            Console.WriteLine("WELCOME TO YO PASSWORDS BIG DOG");
        }
    }
}
