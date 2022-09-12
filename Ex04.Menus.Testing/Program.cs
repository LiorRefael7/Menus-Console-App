using Ex04.Menus.Delegates;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Testing
{
    public class Program
    {
        static void Main(string[] args)
        {
            MenuUsingDelegates();
            MenuUsingInterface();
        }

        public static void MenuUsingDelegates()
        {
            //main menu
            Delegates.MenuItem mainMenu = new Delegates.MenuItem("Delegates Main Menu");
            Delegates.MainMenu main = new Delegates.MainMenu(mainMenu);

            //first Item
            Delegates.MenuItem firstItem = new Delegates.MenuItem("Show Date/Time");
            Delegates.MenuItem showTime = new Delegates.MenuItem("Show Time");
            Delegates.MenuItem showDate = new Delegates.MenuItem("Show Date");

            showTime.InvokeFunction += ShowTime.ShowCurrentTime;
            showDate.InvokeFunction += ShowDate.ShowCurrentDate;

            firstItem.AddItemToMenu(showTime);
            firstItem.AddItemToMenu(showDate);

            //Second Item
            Delegates.MenuItem secondItem = new Delegates.MenuItem("Version and Spaces");
            Delegates.MenuItem countSpace = new Delegates.MenuItem("Count Spaces");
            Delegates.MenuItem showVersion = new Delegates.MenuItem("Show Version");

            countSpace.InvokeFunction += CountSpaces.FunctionCountSpaces;
            showVersion.InvokeFunction += ShowVersion.ShowCurrentVersion;

            secondItem.AddItemToMenu(countSpace);
            secondItem.AddItemToMenu(showVersion);

            mainMenu.AddItemToMenu(firstItem);
            mainMenu.AddItemToMenu(secondItem);

            main.Show();
        }       
        public static void MenuUsingInterface()
        {

            //main menu
            Interfaces.MenuItem mainMenu = new Interfaces.MenuItem("Interface Main Menu", null);
            Interfaces.MainMenu main = new Interfaces.MainMenu(mainMenu);


        //first parit
            Interfaces.MenuItem firstItem = new Interfaces.MenuItem("Show Date/Time", null);

            IInvoker showTimeFunction = new ShowTime();
            Interfaces.MenuItem showTime = new Interfaces.MenuItem("Show Time", showTimeFunction);

            IInvoker showDateFunction = new ShowDate();
            Interfaces.MenuItem ShowDate = new Interfaces.MenuItem("Show Date", showDateFunction);

            firstItem.AddItemToMenu(showTime);
            firstItem.AddItemToMenu(showTime);

        //second Item
            Interfaces.MenuItem secondItem = new Interfaces.MenuItem("Version and Spaces", null);

            IInvoker countSpacesFunction = new CountSpaces();
            Interfaces.MenuItem CountSpaces = new Interfaces.MenuItem("Count Spaces", countSpacesFunction);

            IInvoker showVersionFunction = new ShowVersion();
            Interfaces.MenuItem ShowVersion = new Interfaces.MenuItem("Show Version", showVersionFunction);

            secondItem.AddItemToMenu(CountSpaces);
            secondItem.AddItemToMenu(ShowVersion);



            mainMenu.AddItemToMenu(firstItem);
            mainMenu.AddItemToMenu(secondItem);

            main.Show();
        }
    }

}
