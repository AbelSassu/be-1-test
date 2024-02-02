namespace be_1_test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to your Tax Calculator!");
            string name;
            while (true)
            {
                Console.WriteLine("Enter your name ");
                name = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(name))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Enter a valid name");
                }
            }

            string surname;
            while (true)
            {
                Console.WriteLine("Enter your surname ");
                surname = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(surname))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Enter a valid surname");
                }
            }

            Console.Write("Enter your birth date; (GG/MM/AAAA):");
            DateTime birthDate;
            while (true)
            {
                try
                {
                    birthDate = DateTime.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Enter a valid birth date (GG/MM/AAAA):");
                }
            }

            // Console.WriteLine("Enter your Codice Fiscale:");
            // string codiceFiscale = Console.ReadLine();
            string codiceFiscale;
            while (true)
            {
                Console.WriteLine("Enter your Codice Fiscale ");
                codiceFiscale = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(codiceFiscale) && codiceFiscale.Length == 16)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Retry entering your Codice Fiscale (16 characters): ");
                }
            }



            string gender;
            while (true)
            {
                Console.WriteLine("Select your gender, type M for Male, F for Female, O for Other. ");
                gender = Console.ReadLine();

                if (gender.ToUpper() == "M" || gender.ToUpper() == "F" || gender.ToUpper() == "O")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Insert a valid gender (M/F/O):");
                }
            }

            string residency;
            while (true)
            {
                Console.WriteLine("Enter your residency ");
                residency = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(residency))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Enter a valid residency");
                }
            }

            double income;
            while (true)
            {
                Console.WriteLine("Enter your annual income");

                if (double.TryParse(Console.ReadLine(), out income) && income >= 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Enter a valid number for income");
                }
            }

            User user1 = new User(name, surname, birthDate, codiceFiscale, gender, residency, income);

            if (user1.Income > 0 && user1.Income <= 15000)
            {
                user1.TaxCalculator(0, 23, 0);
            }
            else if (user1.Income >= 15001 && user1.Income <= 28000)
            {
                user1.TaxCalculator(15001, 27, 3450);
            }
            else if (user1.Income >= 28001 && user1.Income <= 55000)
            {
                user1.TaxCalculator(28001, 38, 6960);
            }
            else if (user1.Income >= 55001 && user1.Income <= 75000)
            {
                user1.TaxCalculator(55001, 41, 17220);
            }
            else {
                user1.TaxCalculator(75000, 43, 25420);
            }
            user1.ShowInfo();
        }
    }

    class User
    {
        string _name;
        string _surname;
        DateTime _birthDate;
        string _codiceFiscale;
        string _gender;
        string _residency;
        double _income;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Surname
        {
            get { return _surname; }
            set { _surname = value; }
        }
        public DateTime BirthDate
        {
            get { return _birthDate; }
            set { _birthDate = value; }
        }
        public string CodiceFiscale
        {
            get { return _codiceFiscale; }
            set { _codiceFiscale = value.ToUpper(); }
        }
        public string Gender
        {
            get { return _gender; }
            set { _residency = value; }
        }
        public string Residency
        {
            get { return _residency; }
            set { _residency = value; }
        }
        public double Income
        {
            get { return _income; }
            set 
            { if (value > 0)
                {
                    _income = value;
                }
                else { 
                    Console.WriteLine("You must have an income to calculate taxes");
                }
            }
        }
        public double TotalTaxes { get; set; }
        public User(string name, string surname, DateTime birthDate, string codiceFiscale, string gender, string residency, double income)
        {
            Name = name;
            Surname = surname;
            BirthDate = birthDate;
            CodiceFiscale = codiceFiscale;
            Gender = gender;
            Residency = residency;
            Income = income;
        }
        public void TaxCalculator(int Range, int share, int fixedFee) 
        {
            double surplus = Income - Range;
            double taxes = surplus * share / 100;
            TotalTaxes = taxes + fixedFee;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Welcome: {Name} {Surname}");
            Console.WriteLine($"Birth date: {BirthDate}");
            Console.WriteLine($"Codice Fiscale: {CodiceFiscale}");
            Console.WriteLine($"Gender: {Gender}");
            Console.WriteLine($"Residency: {Residency}");
            Console.WriteLine($"Income: {Income}");
            Console.WriteLine($"Total Taxes: {TotalTaxes}");
        }
    }   
}
