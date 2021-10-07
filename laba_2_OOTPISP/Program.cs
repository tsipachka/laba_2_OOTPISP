using System;
using System.Collections.Generic;
namespace laba_2_OOTPISP
{
   public class Kont
    {
       static string name = "";
        static int number;
        public Kont()
        {
            Console.WriteLine($"имя класса {name+number}, номер объекта {number++}");
        }
    }
    class Program
    {
        public class Abonent
        {
            public void add()
            {
                new Kont();
                
                Console.WriteLine("Вы выбрали метод добавления абонентов");
            }
            public void delete()
            {
                new Kont();

                Console.WriteLine("Вы выбрали метод удланеия абонентов");
            }
            public void edit()
            {
                new Kont();

                Console.WriteLine("Вы выбрали метод реадктирования абонентов");
            }
            public void chek()
            {
                new Kont();

                Console.WriteLine("Вы выбрали просмотр абонентов ");
            }
        }

        public class allcheck
        {
            public void checkBD()
            {
                new Kont();

                Console.WriteLine("Вы выбрали метод для проверки всего ");
            }
            public void chekNal()
            {
                new Kont();

                Console.WriteLine("Вы выбрали просмотр услуг при оплате налом  ");
            }
            public void chekBez()
            {
                new Kont();

                Console.WriteLine("Вы выбрали просмотр услуг при оплате безналом ");
            }
        }

        public class NalOrBez
        {

            public void addNal()
            {
                new Kont();

                Console.WriteLine("Вы вырали метод добавления услуги налом");
            }
            public void addBez()
            {
                new Kont();

                Console.WriteLine("Вы вырали метод добавления услуги безналом");
            }

        }
        static void Main(string[] args)
        {
            List<string> InfoForAdmin = new List<string>();
            Abonent abonent = new Abonent();
            allcheck allcheck = new allcheck();
            NalOrBez nalOrBez = new NalOrBez();
        menu:
            Console.WriteLine("Выберите действие");
            Console.WriteLine("1.Добавление и взаимодествие с абонентом \n" +
                "2.Добавить и посмотреть записи услуг \n" +
                "3.Посмотреть всё");

            string selection = Console.ReadLine();

            switch (selection)
            {
                case "1":
                    Console.Clear();
                suda:
                    Console.WriteLine("Выберите действие");
                    Console.WriteLine("1.Добавление абонента \n" +
                        "2.Удаление абонента \n" +
                        "3.Редактирование абонента \n" +
                        "4.Посмотреть абонентов \n" +
                        "5.вернуться в меню");
                    string selection2 = Console.ReadLine();
                    switch (selection2)
                    {
                        case "1":
                            abonent.add();
                            Console.ReadKey();
                            Console.Clear();
                            goto suda;
                        case "2":
                            abonent.delete();
                            Console.ReadKey();
                            Console.Clear();
                            goto suda;
                        case "3":
                            abonent.edit();
                            Console.ReadKey();
                            Console.Clear();
                            goto suda;
                        case "4":
                            abonent.chek();
                            Console.ReadKey();
                            Console.Clear();
                            goto suda;
                        case "5":
                            Console.Clear();
                            goto menu;
                        default:
                            Console.WriteLine("Вы нажали что-то не так ,проверьте");
                            break;
                    }
                    break;
                case "2":
                    Console.Clear();
                tyda:
                    Console.WriteLine("Выберите действие");
                    Console.WriteLine("1.Добавление услугу налом \n" +
                    "2.Добавить услугу безналомм \n" +
                    "3.Меню");
                    string selection3 = Console.ReadLine();
                    switch (selection3)
                    {
                        case "1":
                            nalOrBez.addNal();
                            Console.ReadKey();
                            Console.Clear();
                            goto tyda;

                        case "2":
                            nalOrBez.addBez();
                            Console.ReadKey();
                            Console.Clear();
                            goto tyda;
                        case "3":
                            Console.Clear();
                            goto menu;
                        default:
                            Console.WriteLine("Вы нажали что-то не так ,проверьте");
                            goto tyda;
                    }
                case "3":
                    Console.Clear();
                tudim:
                    Console.WriteLine("Выберите действие\n" +
                        "1.Посмотреть всё\n" +
                        "2.просмотр услуги налом \n" +
                        "3.просмотр услуг безнало \n" +
                        "4.Меню ");
                    string selection4 = Console.ReadLine();
                    switch (selection4)
                    {
                        case "1":
                            allcheck.checkBD();
                            Console.ReadKey();
                            Console.Clear();
                            goto tudim;
                        case "2":
                            allcheck.chekNal();
                            Console.ReadKey();
                            Console.Clear();
                            goto tudim;
                        case "3":
                            allcheck.chekBez();
                            Console.ReadKey();
                            Console.Clear();
                            goto tudim;
                        case "4":
                            Console.Clear();
                            goto menu;
                        default:
                            Console.WriteLine("Вы нажали что-то не так ,проверьте");
                            Console.Clear();
                            goto tudim;
                    }
                    
                default:
                    Console.WriteLine("Вы нажали что-то не так ,проверьте");
                    break;
            }
        }
    }
}