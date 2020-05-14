using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lv6_Ralasic
{
    class Program
    {
        static void Main(string[] args)
        {
            //prvi
            Notebook notebook = new Notebook();
            notebook.AddNote(new Note("Error", "Important"));
            notebook.AddNote(new Note("Info", "Important"));
            notebook.AddNote(new Note("Signal", "Important"));
            notebook.AddNote(new Note("Thing", "Important"));

            IAbstractIterator iterator = notebook.GetIterator();

            while (!iterator.IsDone)
            {
                iterator.Current.Show();
                iterator.Next();
            }
            //drugi
            Box box = new Box();
            box.AddProduct(new Product("Fish", 10.99));
            box.AddProduct(new Product("Chips", 10.99));
            box.AddProduct(new Product("Meat", 10.99));
            box.AddProduct(new Product("Soda", 10.99));

            IAbstractIteratorBox iteratorBox = box.GetIterator();

            while (!iteratorBox.IsDone)
            {
                Console.WriteLine(iteratorBox.Current.ToString());
                iteratorBox.Next();
            }

            //treci
            CareTaker history = new CareTaker();

            ToDoItem item = new ToDoItem("Mission", "Important", DateTime.Now);
            Console.WriteLine(item.ToString());
            history.Store(item.StoreState());
            item.Rename("Task");
            Console.WriteLine(item.ToString());
            item.RestoreState(history.PreviousState());
            Console.WriteLine(item.ToString());

            //cetvrti

            BankAccount account = new BankAccount("Me", "Here", 500.0m);
            MementoBank previosState = account.StoreState();
            Console.WriteLine(account.ToString());
            account.UpdateBalance(1000.0m);
            Console.WriteLine(account.ToString());
            account.RestoreState(previosState);
            Console.WriteLine(account.ToString());

        }
    }
}
