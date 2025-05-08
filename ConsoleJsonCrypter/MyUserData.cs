namespace ConsoleJsonCrypter
{
    public class MyUserData
    {
        // Свойства
        public string UserName { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }

        // Конструктор
        public MyUserData(string userName, string email, int age)
        {
            UserName = userName;
            Email = email;
            Age = age;
        }

        // Метод для отображения информации о пользователе
        public void DisplayUserInfo()
        {
            Console.WriteLine($"User Name: {UserName}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"Age: {Age}");
        }

        // Метод для проверки совершеннолетия
        public bool IsAdult()
        {
            return Age >= 18;
        }
    }
}
