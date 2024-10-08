namespace Library
{
    class Member
    {
        // Variables
        private int memberId;
        private string name;
        private string address;
        private int phone;

        // Public Properties
        public int MemberId
        {
            get { return memberId; }
            private set { memberId = value; } // private setter makes it read-only
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public int Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        public Member(int memberId, string name, string address, int phone)
        {
            this.memberId = memberId;
            this.name = name;
            this.address = address;
            this.phone = phone;
        }
        // Method to display information about the member
        public void DisplayInfo()
        {
            Console.WriteLine("Member information");
            Console.WriteLine("----------------");
            Console.WriteLine($"Member ID: {MemberId}");
            Console.WriteLine($"Member name: {Name}");
            Console.WriteLine($"Member address: {Address}");
            Console.WriteLine($"Member mobile number: {Phone}");
            Console.WriteLine();
        }
    }
}
