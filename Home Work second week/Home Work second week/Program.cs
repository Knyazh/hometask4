namespace Home_Work_second_week
{

    internal class Program
    {
        public class Register
        {
            public string _firstName;
            public string _lastName;
            public string _email;
            public string _password;

            public Register(string firstName, string lastName, string email, string password)
            {
                _firstName = firstName;
                _lastName = lastName;
                _email = email;
                _password = password;
            }
        }

        public class LogIn
        {
            public string _email;
            public string _password;
            public List<Register> _assignedTo;

            public LogIn(string email, string password, List<Register> assignedTo)
            {
                _email = email;
                _password = password;
                _assignedTo = assignedTo;
            }
        }


        public class AddCommand
        {

            public void HandLe(List<Register> argRegisters)
            {
                string firstName = GetAndValidateFirstName();
                string lastName = GetAndValidateLastName();
                string email = GetAndValidateEmail();
                string password = GetAndValidatePassword();

                argRegisters.Add(new Register(firstName, lastName, email, password));

                Console.WriteLine();
                Console.WriteLine($"First Name : {firstName}");
                Console.WriteLine($"Last Name : {lastName}");
                Console.WriteLine($"Email: {email}");





            }

            public void HandLe2(List<LogIn> argLogIn)
            {
                List<Register> argRegisters = new List<Register>();

                List<LogIn> list = new List<LogIn>();
                string email = GetAndValidateEmail();
                string password = GetAndValidatePassword();
                string emal1 = Console.ReadLine();
                Register assignedTo = null;

                foreach (var argreg in argRegisters)
                {
                    if (emal1 == email)
                    {
                        assignedTo = argreg;
                    }
                }
                //argLogIn.Add(new LogIn(email, password, assignedTo._email);
            }
            #region First Name
            static string GetAndValidateFirstName()
            {
                int MIN_LENGTH = 3;
                int MAX_LENGTH = 30;

                while (true)
                {
                    Console.WriteLine("Pls enter first name : ");
                    string firstName = Console.ReadLine();

                    if (IsValidName(firstName, MIN_LENGTH, MAX_LENGTH))
                    {

                        return firstName;
                    }

                    Console.WriteLine("Some information is not correct");
                }
            }
            static bool IsValidName(string text, int min, int max)
            {

                if (text.Length < min || text.Length > max)
                {
                    return false;

                }
                return true;

            }
            #endregion

            #region Last Name
            static string GetAndValidateLastName()
            {
                int MIN_LENGTH = 5;
                int MAX_LENGTH = 20;

                while (true)
                {
                    Console.WriteLine("Please enter last name : ");
                    string lastName = Console.ReadLine()!;

                    if (IsValidLastName(lastName, MIN_LENGTH, MAX_LENGTH))
                    {

                        return lastName;
                    }

                    Console.WriteLine("Some information is not correnct");
                }

                static bool IsValidLastName(string text, int min, int max)
                {

                    if (text.Length < min || text.Length > max)
                    {
                        return false;
                    }
                    return true;
                }
            }
            #endregion

            #region Email

            static string GetAndValidateEmail()
            {
                while (true)
                {
                    Console.WriteLine("Please enter an email : ");
                    string email = Console.ReadLine()!;

                    if (IsValidEmail(email))
                    {
                        return email;
                    }

                    Console.WriteLine("Some information is not correct");
                }
                static bool IsValidEmail(string text)
                {
                    bool isValid = false;

                    for (int i = 0; i < text.Length; i++)
                    {
                        if (text[i] == '@' && text[i] == '.')
                        {
                            isValid = true;
                        }
                        else if (text[i] == '.')
                        {
                            isValid = true;
                        }
                    }

                    return isValid;

                }
            }
            #endregion

            #region Password
            static string GetAndValidatePassword()
            {
                while (true)
                {
                    Console.WriteLine("Pls enter password :");
                    string password = Console.ReadLine();

                    Console.WriteLine("Pls enter password again :");
                    string confirmPassword = Console.ReadLine();

                    if (IsValidPassword(password, confirmPassword))
                    {

                        return password;
                    }

                    Console.WriteLine("Some information is not correct");
                }
            }
            static bool IsValidPassword(string password, string confirmPassword)
            {
                if (password == confirmPassword)
                {
                    return true;
                }

                return false;
            }
            #endregion
        }


        static void Main(string[] args)
        {
            List<Register> argRegisters = new List<Register>();
            List<LogIn> login = new List<LogIn>();
            Console.WriteLine("Available Commands :");
            Console.WriteLine("/register");
            Console.WriteLine("/login");
            Console.WriteLine("/exit");

            while (true)
            {

                Console.WriteLine("Please enter command : ");
                string command = Console.ReadLine();

                switch (command)
                {
                    case "/register":

                        AddCommand addcommand = new AddCommand();
                        addcommand.HandLe(argRegisters);

                        break;

                    case "/login":

                        AddCommand addcommand2 = new AddCommand();
                        addcommand2.HandLe2(login);

                        break;

                        //case "/login":

                        //    LogIn logIn = new LogIn();

                        //    break;


                }
                if (command == "/exit")
                {
                    Console.WriteLine("Thanks for using");
                    break;
                }

            }


        }



        public class Utility
        {
            public void IsValidName(string text, int min, int max)
            {
                int MIN_LENGTH = 3;
                int MAX_LENGTH = 30;

                if (text.Length < min || text.Length > max)
                {
                    Console.WriteLine("Name is wrong");

                }


            }

            public void IsValidLastName(string text, int min, int max)
            {
                int MIN_LENGTH = 5;
                int MAX_LENGTH = 20;

                if (text.Length < min || text.Length > max)
                {
                    Console.WriteLine("Name is wrong");

                }
            }


            static bool IsValidEmail(string text)
            {
                bool isValid = false;

                for (int i = 0; i < text.Length; i++)
                {
                    if (text[i] == '@' && text[i] == '.')
                    {
                        isValid = true;
                    }
                    else if (text[i] == '.')
                    {
                        isValid = true;
                    }
                }

                return isValid;

            }


            public void IsValidPassword(string password, string passwordCheck)
            {
                if (password == passwordCheck)
                {
                    Console.WriteLine("Success");
                }
                else
                {
                    Console.WriteLine("Please try again");

                }
            }

        }





    }
}