using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class StudentList
    {
        //Create a delegate linked to Student
        public delegate void StudentDelegate();

        //Create an event for anything to change when called
        public event StudentDelegate ListChanged;

        //this class simply contains a custom list of Inventory items
        private List<Student> items = new List<Student>();

        //create a variable for the items count
        public int Count => items.Count;
        public StudentList()
        {//default constructor

        }


        //indexers for the listBox for when someone selects something
        public Student this[int index]
        {
            get
            {
                if (index < 0 || index >= items.Count)
                {
                    throw new ArgumentOutOfRangeException("Please enter a valid index");
                }
                return this.items[index];
            }
            set
            {
                items[index] = value;
                OnDataChanged();
            }
        }

        //Created method for when something has changed in the forms
        public virtual void OnDataChanged()
        {
            ListChanged.Invoke();
        }

        //adding a new student to the list and also refreshing the list box
        public void addStudent(Student add)
        {
            items.Add(add);
            OnDataChanged();
        }

        //removing a new student to the list and also refreshing the list box
        public void removeStudent(Student remove)
        {
            items.Remove(remove);
            OnDataChanged();
        }
    }
}
