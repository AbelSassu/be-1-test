namespace be_1_test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" /$$      /$$           /$$                                                     /$$              \r\n| $$  /$ | $$          | $$                                                    | $$              \r\n| $$ /$$$| $$  /$$$$$$ | $$  /$$$$$$$  /$$$$$$  /$$$$$$/$$$$   /$$$$$$        /$$$$$$    /$$$$$$ \r\n| $$/$$ $$ $$ /$$__  $$| $$ /$$_____/ /$$__  $$| $$_  $$_  $$ /$$__  $$      |_  $$_/   /$$__  $$\r\n| $$$$_  $$$$| $$$$$$$$| $$| $$      | $$  \\ $$| $$ \\ $$ \\ $$| $$$$$$$$        | $$    | $$  \\ $$\r\n| $$$/ \\  $$$| $$_____/| $$| $$      | $$  | $$| $$ | $$ | $$| $$_____/        | $$ /$$| $$  | $$\r\n| $$/   \\  $$|  $$$$$$$| $$|  $$$$$$$|  $$$$$$/| $$ | $$ | $$|  $$$$$$$        |  $$$$/|  $$$$$$/\r\n|__/     \\__/ \\_______/|__/ \\_______/ \\______/ |__/ |__/ |__/ \\_______/         \\___/   \\______/ \r\n                                                                                                ");
            Console.WriteLine("                                                 /$$                        \r\n                                                | $$                        \r\n /$$   /$$  /$$$$$$  /$$   /$$  /$$$$$$        /$$$$$$    /$$$$$$  /$$   /$$\r\n| $$  | $$ /$$__  $$| $$  | $$ /$$__  $$      |_  $$_/   |____  $$|  $$ /$$/\r\n| $$  | $$| $$  \\ $$| $$  | $$| $$  \\__/        | $$      /$$$$$$$ \\  $$$$/ \r\n| $$  | $$| $$  | $$| $$  | $$| $$              | $$ /$$ /$$__  $$  >$$  $$ \r\n|  $$$$$$$|  $$$$$$/|  $$$$$$/| $$              |  $$$$/|  $$$$$$$ /$$/\\  $$\r\n \\____  $$ \\______/  \\______/ |__/               \\___/   \\_______/|__/  \\__/\r\n /$$  | $$                                                                  \r\n|  $$$$$$/                                                                  \r\n \\______/ ");
            Console.WriteLine("                     /$$                     /$$             /$$                        \r\n                    | $$                    | $$            | $$                        \r\n  /$$$$$$$  /$$$$$$ | $$  /$$$$$$$ /$$   /$$| $$  /$$$$$$  /$$$$$$    /$$$$$$   /$$$$$$ \r\n /$$_____/ |____  $$| $$ /$$_____/| $$  | $$| $$ |____  $$|_  $$_/   /$$__  $$ /$$__  $$\r\n| $$        /$$$$$$$| $$| $$      | $$  | $$| $$  /$$$$$$$  | $$    | $$  \\ $$| $$  \\__/\r\n| $$       /$$__  $$| $$| $$      | $$  | $$| $$ /$$__  $$  | $$ /$$| $$  | $$| $$      \r\n|  $$$$$$$|  $$$$$$$| $$|  $$$$$$$|  $$$$$$/| $$|  $$$$$$$  |  $$$$/|  $$$$$$/| $$      \r\n \\_______/ \\_______/|__/ \\_______/ \\______/ |__/ \\_______/   \\___/   \\______/ |__/      \r\n                                                                                        ");
            Console.WriteLine("          /$$             /$$             /$$             /$$             /$$             /$$             /$$   \r\n        /$$$$$$         /$$$$$$         /$$$$$$         /$$$$$$         /$$$$$$         /$$$$$$         /$$$$$$ \r\n       /$$__  $$       /$$__  $$       /$$__  $$       /$$__  $$       /$$__  $$       /$$__  $$       /$$__  $$\r\n      | $$  \\__/      | $$  \\__/      | $$  \\__/      | $$  \\__/      | $$  \\__/      | $$  \\__/      | $$  \\__/\r\n      |  $$$$$$       |  $$$$$$       |  $$$$$$       |  $$$$$$       |  $$$$$$       |  $$$$$$       |  $$$$$$ \r\n       \\____  $$       \\____  $$       \\____  $$       \\____  $$       \\____  $$       \\____  $$       \\____  $$\r\n       /$$  \\ $$       /$$  \\ $$       /$$  \\ $$       /$$  \\ $$       /$$  \\ $$       /$$  \\ $$       /$$  \\ $$\r\n      |  $$$$$$/      |  $$$$$$/      |  $$$$$$/      |  $$$$$$/      |  $$$$$$/      |  $$$$$$/      |  $$$$$$/\r\n       \\_  $$_/        \\_  $$_/        \\_  $$_/        \\_  $$_/        \\_  $$_/        \\_  $$_/        \\_  $$_/ \r\n         \\__/            \\__/            \\__/            \\__/            \\__/            \\__/            \\__/   \r\n                                                                                                                ");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Green;
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
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Enter a valid name");
                    Console.ForegroundColor = ConsoleColor.Green;
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
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Enter a valid surname");
                    Console.ForegroundColor = ConsoleColor.Green;
                }
            }

            Console.Write("Enter your birth date (DD/MM/YYYY): ");
            DateTime birthDate;

            while (true)
            {
                try
                {
                    birthDate = DateTime.Parse(Console.ReadLine());

                    if (birthDate.Date < DateTime.Now.Date)
                    {
                        break;
                    }
                    else if (DateTime.Now.AddYears(-18).Date >= birthDate.Date)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("You must be of legal age to access the tax calculation.");
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Enter a valid birth date (are you born in the future!?): ");
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                }
                catch (FormatException)
                {   
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Enter a valid birth date (DD/MM/YYYY): ");
                    Console.ForegroundColor = ConsoleColor.Green;
                }
            }


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
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Retry entering your Codice Fiscale (16 characters): ");
                    Console.ForegroundColor = ConsoleColor.Green;
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
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Insert a valid gender (M/F/O):");
                    Console.ForegroundColor = ConsoleColor.Green;
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
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Enter a valid residency");
                    Console.ForegroundColor = ConsoleColor.Green;
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
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Enter a valid number for income");
                    Console.ForegroundColor = ConsoleColor.Green;
                }
            }

            User user1 = new User(name, surname, birthDate, codiceFiscale, gender, residency, income);

            if (user1.Income >= 0 && user1.Income <= 15000)
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
            set { _name = char.ToUpper(value[0]) + value.Substring(1); }
        }
        public string Surname
        {
            get { return _surname; }
            set { _surname = char.ToUpper(value[0]) + value.Substring(1); }
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
            set { _gender = value.ToUpper(); }
        }
        public string Residency
        {
            get { return _residency; }
            set { _residency = char.ToUpper(value[0]) + value.Substring(1); ; }
        }
        public double Income
        {
            get { return _income; }
            set { _income = value; }

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
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Welcome: {Name} {Surname}");
            Console.WriteLine($"Birth date: {BirthDate}");
            Console.WriteLine($"Codice Fiscale: {CodiceFiscale}");
            Console.WriteLine($"Gender: {Gender}");
            Console.WriteLine($"Residency: {Residency}");
            Console.WriteLine($"Income: {Income}");
            Console.WriteLine($"Total Taxes: {TotalTaxes}");
            Console.ForegroundColor = ConsoleColor.Green;
        }
    }   
}
