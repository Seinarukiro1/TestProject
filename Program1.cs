using System;

namespace khm
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int a = 0;
            string pass;
            bool conf = false;
            string passt;
            string name;

            Console.WriteLine("Создайте аккаунт");
            Console.WriteLine("Ваше имя: ");
            name = Console.ReadLine();
            Console.WriteLine("Придумайте пароль " + name + ": ");
            pass = Console.ReadLine();
            Console.WriteLine("Отлично, аккаунт успешно создан");
            Console.WriteLine("Введите ваш пароль что бы войти в личный кабинет: ");


            do
            {
                passt = Console.ReadLine();

                if (pass != passt)
                {
                    a++;
                    Console.WriteLine("Пароль не верный. Попыток -  " + a + "/3");


                }
                else
                {
                    conf = true;
                    break;
                }
            } while (a < 3);



            if (!conf)
            {
                Console.WriteLine("Возможность входа заблокирована.");
            }
            else
            {
                Console.WriteLine("Добро пожаловать  " + name + "! ");
            }
            // Console.Clear();

            string point;




            Console.WriteLine("Выберите услугу: \n 1. Калькулятор \n 2. Депозит");


            string lol = 0;
            do
            {


                point = Console.ReadLine();

                if (point == "1")
                {
                    Console.WriteLine("Калькулятор запущен");
                    Calculator();


                }
                else if (point == "2")
                {
                    Console.WriteLine("Вы можете положить свои деньги на депозит. Для рассчета воспользуйтесь формой ниже");
                }
                else
                {
                    Console.WriteLine("Вы допустили ошибку либо такой услуги не существует. ");
                    lol++;

                }
            } while (point == 10);
        }
             void Calculator()
            {

                double num1;
                double num2;
                double result;

                Console.WriteLine("Enter first number ");
                num1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter second number ");
                num2 = Convert.ToDouble(Console.ReadLine());

                result = num1 + num2;
                Console.WriteLine(num1 + " + " + num2 + " = " + result);
            }
        

        
    }
}