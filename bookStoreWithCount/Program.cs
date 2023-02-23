namespace bookStore
{
    class book
    {
        private static int _transactions = 0;
        private int _Id;
        private string _Title;
        private string _Author;

        public void SetTrans()
        {
            _transactions++;
        }
        public int GetTrans()
        {
            return _transactions;
        }
        public book()
        {
            _Id = 0;
            _Title = "";
            _Author = "";
        }
        public book(int i, string title, string author)
        {
            _Id = i;
            _Title = title;
            _Author = author;
        }
        public string GetFullTitle()
        {
            return _Title + _Author;
        }
        public int GetFullId()
        {
            return _Id;
        }
        public void SetId(int identification)
        {
            _Id = identification;
        }
        public void SetTitle(string title)
        {
            _Title = title;
        }
        public void SetName(string name)
        {
            _Author = name;
        }
    }
    class myStore
    {
        internal class Program
        {
            static void Main(string[] args)
            {

                book Bname = new book();
                Bname.SetId(10);
                Bname.SetTitle("Velma Winnie");
                Bname.SetName("Where The Wild Things Are");
                Console.WriteLine($"ID = {Bname.GetFullTitle()}, Name = {Bname.GetFullId()}");
                Bname.SetTrans();

                book Bname10 = new book(10, "Velma Winniw", "Where The Wild Things Are");
                Bname10.SetTrans();


                book Bname20 = new book();
                Console.WriteLine("Please enter the member ID: ");
                Bname20.SetId(int.Parse(Console.ReadLine()));
                Console.WriteLine("Please enter the book Title: ");
                Bname20.SetTitle(Console.ReadLine());
                Console.WriteLine("Please enter the Authors Name: ");
                Bname20.SetName(Console.ReadLine());
                Bname20.SetTrans();


                Console.WriteLine("Please enter the member ID: ");
                int tempID = int.Parse(Console.ReadLine());
                Console.WriteLine("Please enter the first name: ");
                string tempFirstName = Console.ReadLine();
                Console.WriteLine("Please enter the last name: ");
                string tempLastName = Console.ReadLine();
                book member30 = new book(tempID, tempFirstName, tempLastName);
                member30.SetTrans();


                Console.WriteLine($"The club has {Bname.GetTrans()} new members");
                displayMembers(Bname);
                displayMembers(Bname10);
                displayMembers(Bname20);
                displayMembers(member30);

            }
            static void displayMembers(book Bname)
            {
                Console.WriteLine("Here is your book information");
                Console.WriteLine($"Member ID: {Bname.GetFullId()}");
                Console.WriteLine($"Member Name: {Bname.GetFullTitle()}");
            }


        }
    }
}
