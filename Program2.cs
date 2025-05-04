namespace Chap9Test2_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cart cart = new Cart();
            cart.Name = "Zoe";
            cart.Occupation = "Software Engineer";
            cart.Age = 18;
            cart.Email = "a123@gmail.com";

            cart.Phone = new PhoneList();
            cart.Phone.HomePhone = "0700-777-777";
            cart.Phone.BusinessPhone = "0800-888-888";
            cart.Phone.CellPhone = "0999-999-999";

            cart.GetCard();
        }
    }

    class Cart
    {
        public string Name, Occupation, Email;
        public int Age;
        public PhoneList Phone;
        public void GetCard()
        {
            string str;
            str = "Name：" + Name.ToString();
            str += "\nOccupation：" + Occupation.ToString();
            str += "\nAge：" + Age.ToString();
            str += "\nPhone" ;
            str += "\nHomePhone：" + Phone.HomePhone;
            str += "\nBusinessPhone：" + Phone.BusinessPhone;
            str += "\nCellPhone：" + Phone.CellPhone;
            str += "\nEmail：" + Email.ToString();

            Console.WriteLine(str);
        }
    }

    class PhoneList
    {
        public string HomePhone;
        public string BusinessPhone;
        public string CellPhone;
    }
}
