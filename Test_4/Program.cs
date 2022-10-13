namespace Test_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            str1();
            //у меня на клаве нет стрелок по этому управление будет через w,a,s,d




            static void str1()
            {
                yanv2000();

                static void poest1()
                {
                    Console.Clear();
                    Console.WriteLine("первое января 2000 года");
                    Console.WriteLine("->Поесть");
                    Console.WriteLine("Прийти на пары");
                    ConsoleKeyInfo key = Console.ReadKey();

                    if (key.Key == ConsoleKey.S)
                    {
                        para1();
                    }
                    if (key.Key == ConsoleKey.Enter)
                    {
                        podrobnopoest1();
                    }
                    if (key.Key == ConsoleKey.D)
                    {
                        str2();
                    }
                    if (key.Key == ConsoleKey.A)
                    {
                        str01();
                    }
                }

                //нач
                static void para1()
                {
                    Console.Clear();
                    Console.WriteLine("первое января 2000 года");
                    Console.WriteLine("Поесть");
                    Console.WriteLine("->Прийти на пары");
                    ConsoleKeyInfo key = Console.ReadKey();

                    if (key.Key == ConsoleKey.W)
                    {
                        poest1();
                    }
                    if (key.Key == ConsoleKey.Enter)
                    {
                        podrobnopara1();
                    }
                    if (key.Key == ConsoleKey.D)
                    {
                        str2();
                    }
                    if (key.Key == ConsoleKey.A)
                    {
                        str01();
                    }
                }
                //кон


                //нач
                static void podrobnopoest1()
                {
                    Console.Clear();
                    Console.WriteLine("Завтнрак в 9:00, обед в 12:00, ужин в 18:00");
                    ConsoleKeyInfo key = Console.ReadKey();
                    if (key.Key == ConsoleKey.Escape)
                    {
                        poest1();
                    }
                }
                //кон


                //нач
                static void podrobnopara1()
                {
                    Console.Clear();
                    Console.WriteLine("Первая в 8:30, вторая в 10:10, третья в 12:00, четвертая в 14:00, пятая в 15:40");
                    ConsoleKeyInfo key = Console.ReadKey();
                    if (key.Key == ConsoleKey.Escape)
                    {
                        para1();
                    }
                }
                //кон


                static void yanv2000()
                {
                    Console.Clear();
                    Console.WriteLine("первое января 2000 года");
                    Console.WriteLine("Поесть");
                    Console.WriteLine("Прийти на пары");
                    ConsoleKeyInfo key = Console.ReadKey();
                    //у меня на клаве нет стрелок по этому управление будет через w,a,s,d
                    if (key.Key == ConsoleKey.W)
                    {
                        poest1();
                    }
                    if (key.Key == ConsoleKey.S)
                    {
                        para1();
                    }
                    if (key.Key == ConsoleKey.D)
                    {
                        str2();
                    }
                    if (key.Key == ConsoleKey.A)
                    {
                        str01();
                    }
                }
            }//конец первой даты
            static void str2()
            {
                yanv2001();

                static void yanv2001()
                {
                    Console.Clear();
                    Console.WriteLine("второе января 2000 года");
                    Console.WriteLine("Поесть");
                    Console.WriteLine("Наконец-то праздновать новый год");
                    ConsoleKeyInfo key = Console.ReadKey();
                    if (key.Key == ConsoleKey.A)
                    {
                        str1();
                    }
                    if (key.Key == ConsoleKey.W)
                    {
                        poest2();
                    }
                    if (key.Key == ConsoleKey.W)
                    {
                        ng();
                    }
                    if (key.Key == ConsoleKey.D)
                    {
                        str3();
                    }
                }
                static void poest2()
                {
                    Console.Clear();
                    Console.WriteLine("второе января 2000 года");
                    Console.WriteLine("->Поесть");
                    Console.WriteLine("Наконец-то праздновать новый год");
                    ConsoleKeyInfo key = Console.ReadKey();

                    if (key.Key == ConsoleKey.S)
                    {
                        ng();
                    }
                    if (key.Key == ConsoleKey.Enter)
                    {
                        podrobnopoest2();
                    }
                    if (key.Key == ConsoleKey.D)
                    {
                        str3();
                    }
                    if (key.Key == ConsoleKey.A)
                    {
                        str1();
                    }
                }
                static void podrobnopoest2()
                {
                    Console.Clear();
                    Console.WriteLine("Объедаться салатами");
                    ConsoleKeyInfo key = Console.ReadKey();
                    if (key.Key == ConsoleKey.Escape)
                    {
                        poest2();
                    }
                }
                static void ng()
                {
                    Console.Clear();
                    Console.WriteLine("второе января 2000 года");
                    Console.WriteLine("Поесть");
                    Console.WriteLine("->Наконец-то праздновать новый год");
                    ConsoleKeyInfo key = Console.ReadKey();
                    if (key.Key == ConsoleKey.W)
                    {
                        poest2();
                    }
                    if (key.Key == ConsoleKey.Enter)
                    {
                        podrobnong();
                    }
                    if (key.Key == ConsoleKey.D)
                    {
                        str3();
                    }
                    if (key.Key == ConsoleKey.A)
                    {
                        str1();
                    }
                }
                static void podrobnong()
                {
                    Console.Clear();
                    Console.WriteLine("Празднуй и не забудь поспать сегодня");
                    ConsoleKeyInfo key = Console.ReadKey();
                    if (key.Key == ConsoleKey.Escape)
                    {
                        ng();
                    }
                }
            }//конец второй даты
            static void str3()
            {
                yanv2002();
                static void yanv2002()
                {
                    Console.Clear();
                    Console.WriteLine("третье января 2000 года");
                    Console.WriteLine("лечь спать");
                    Console.WriteLine("Проверить телефон");
                    ConsoleKeyInfo key = Console.ReadKey();
                    if (key.Key == ConsoleKey.A)
                    {
                        str2();
                    }
                    if (key.Key == ConsoleKey.W)
                    {
                        spat();
                    }
                    if (key.Key == ConsoleKey.S)
                    {
                        nng();
                    }
                    if (key.Key == ConsoleKey.D)
                    {
                        polzovatelskayazametka();
                    }
                }
                static void spat()
                {
                    Console.Clear();
                    Console.WriteLine("третье января 2000 года");
                    Console.WriteLine("->лечь спать");
                    Console.WriteLine("Проверить телефон");
                    ConsoleKeyInfo key = Console.ReadKey();

                    if (key.Key == ConsoleKey.S)
                    {
                        nng();
                    }
                    if (key.Key == ConsoleKey.Enter)
                    {
                        podrobnospat();
                    }
                    if (key.Key == ConsoleKey.A)
                    {
                        str2();
                    }
                    if (key.Key == ConsoleKey.D)
                    {
                        polzovatelskayazametka();
                    }
                }
                static void podrobnospat()
                {
                    Console.Clear();
                    Console.WriteLine("ЛОЖИСЬ СПАТЬ!");
                    ConsoleKeyInfo key = Console.ReadKey();
                    if (key.Key == ConsoleKey.Escape)
                    {
                        spat();
                    }
                }
                static void nng()
                {
                    Console.Clear();
                    Console.WriteLine("третье января 2000 года");
                    Console.WriteLine("лечь спать");
                    Console.WriteLine("->Проверить телефон");
                    ConsoleKeyInfo key = Console.ReadKey();
                    if (key.Key == ConsoleKey.W)
                    {
                        spat();
                    }
                    if (key.Key == ConsoleKey.Enter)
                    {
                        podrobnong();
                    }
                    if (key.Key == ConsoleKey.A)
                    {
                        str2();
                    }
                    if (key.Key == ConsoleKey.D)
                    {
                        polzovatelskayazametka();
                    }
                }
                static void podrobnong()
                {
                    Console.Clear();
                    Console.WriteLine("Может тебе мама звонила?");
                    ConsoleKeyInfo key = Console.ReadKey();
                    if (key.Key == ConsoleKey.Escape)
                    {
                        nng();
                    }
                }
            }//конец третей даты
            static void str01()
            {
                yanv1992();
                static void yanv1992()
                {
                    Console.Clear();
                    Console.WriteLine("тридцать первое декабря 1999 года");
                    Console.WriteLine("Подготовить праздничный ужин");
                    Console.WriteLine("Подготовиться к перездаче");
                    ConsoleKeyInfo key = Console.ReadKey();
                    if (key.Key == ConsoleKey.A)
                    {
                        str02();
                    }
                    if (key.Key == ConsoleKey.W)
                    {
                        ugin();
                    }
                    if (key.Key == ConsoleKey.S)
                    {
                        pere();
                    }
                    if (key.Key == ConsoleKey.D)
                    {
                        str1();
                    }
                }
                static void ugin()
                {
                    Console.Clear();
                    Console.WriteLine("тридцать первое декабря 1999 года");
                    Console.WriteLine("->Подготовить праздничный ужин");
                    Console.WriteLine("Подготовиться к перездаче");
                    ConsoleKeyInfo key = Console.ReadKey();

                    if (key.Key == ConsoleKey.S)
                    {
                        pere();
                    }
                    if (key.Key == ConsoleKey.Enter)
                    {
                        podrobnougin();
                    }
                    if (key.Key == ConsoleKey.A)
                    {
                        str02();
                    }
                    if (key.Key == ConsoleKey.D)
                    {
                        str1();
                    }
                }
                static void podrobnougin()
                {
                    Console.Clear();
                    Console.WriteLine("Крабовый салат, оливье, печенье");
                    ConsoleKeyInfo key = Console.ReadKey();
                    if (key.Key == ConsoleKey.Escape)
                    {
                        ugin();
                    }
                }
                static void pere()
                {
                    Console.Clear();
                    Console.WriteLine("тридцать первое декабря 1999 года");
                    Console.WriteLine("Подготовить праздничный ужин");
                    Console.WriteLine("->Подготовиться к перездаче");
                    ConsoleKeyInfo key = Console.ReadKey();
                    if (key.Key == ConsoleKey.W)
                    {
                        ugin();
                    }
                    if (key.Key == ConsoleKey.Enter)
                    {
                        podrobnopere();
                    }
                    if (key.Key == ConsoleKey.A)
                    {
                        str02();
                    }
                    if (key.Key == ConsoleKey.D)
                    {
                        str1();
                    }
                }
                static void podrobnopere()
                {
                    Console.Clear();
                    Console.WriteLine("УЧИ!");
                    ConsoleKeyInfo key = Console.ReadKey();
                    if (key.Key == ConsoleKey.Escape)
                    {
                        pere();
                    }
                }
            }//конец минус первой даты
            static void str02()
            {
                yanv1982();
                static void yanv1982()
                {
                    Console.Clear();
                    Console.WriteLine("тридцатое декабря 1999 года");
                    Console.WriteLine("Подготовить ингердеенты к праздничному ужину");
                    Console.WriteLine("Подготовиться к перездаче");
                    ConsoleKeyInfo key = Console.ReadKey();
                    if (key.Key == ConsoleKey.W)
                    {
                        pugin();
                    }
                    if (key.Key == ConsoleKey.S)
                    {
                        perez();
                    }
                    if (key.Key == ConsoleKey.D)
                    {
                        str01();
                    }
                }
                static void pugin()
                {
                    Console.Clear();
                    Console.WriteLine("тридцатое декабря 1999 года");
                    Console.WriteLine("->Подготовить ингердеенты к праздничному ужину");
                    Console.WriteLine("Подготовиться к перездаче");
                    ConsoleKeyInfo key = Console.ReadKey();

                    if (key.Key == ConsoleKey.S)
                    {
                        perez();
                    }
                    if (key.Key == ConsoleKey.Enter)
                    {
                        podrobnopugin();
                    }
                    if (key.Key == ConsoleKey.D)
                    {
                        str01();
                    }
                }
                static void podrobnopugin()
                {
                    Console.Clear();
                    Console.WriteLine("Крабовые палочки, горох, майонез, остальное вроде есть в холодильнике, но нужно проверить");
                    ConsoleKeyInfo key = Console.ReadKey();
                    if (key.Key == ConsoleKey.Escape)
                    {
                        pugin();
                    }
                }
                static void perez()
                {
                    Console.Clear();
                    Console.WriteLine("тридцатое декабря 1999 года");
                    Console.WriteLine("Подготовить ингердеенты к праздничному ужину");
                    Console.WriteLine("->Подготовиться к перездаче");
                    ConsoleKeyInfo key = Console.ReadKey();
                    if (key.Key == ConsoleKey.W)
                    {
                        pugin();
                    }
                    if (key.Key == ConsoleKey.Enter)
                    {
                        podrobnoperez();
                    }
                    if (key.Key == ConsoleKey.D)
                    {
                        str01();
                    }
                }
                static void podrobnoperez()
                {
                    Console.Clear();
                    Console.WriteLine("УЧИ!");
                    ConsoleKeyInfo key = Console.ReadKey();
                    if (key.Key == ConsoleKey.Escape)
                    {
                        perez();
                    }
                }
            }//конец минус второй даты
            static void polzovatelskayazametka()
            {

                privetstvie();
                static void privetstvie()
                {
                    Console.Clear();
                    Console.WriteLine("четвертое января 2000 года");
                    Console.WriteLine("На данную дату заметок нет, если вы хотите ее добавить, нажмите Enter");
                    ConsoleKeyInfo key = Console.ReadKey();
                    if (key.Key == ConsoleKey.A)
                    {
                        str3();
                    }
                    if (key.Key == ConsoleKey.Enter)
                    {
                        string a = (Console.ReadLine());
                        Console.WriteLine("заметка успешно создана, нажмите E");
                        ConsoleKeyInfo keyy = Console.ReadKey();
                        if (keyy.Key == ConsoleKey.E)
                        {
                            Console.Clear();
                            Console.WriteLine("четвертое января 2000 года");
                            Console.WriteLine(a);
                            ConsoleKeyInfo keyq = Console.ReadKey();
                            if (keyq.Key == ConsoleKey.W)
                            {
                                Console.Clear();
                                Console.WriteLine("четвертое января 2000 года");
                                Console.WriteLine($"->{a}");
                                ConsoleKeyInfo keyw = Console.ReadKey();
                                if (keyw.Key == ConsoleKey.Enter)
                                {
                                    Console.Clear();
                                    Console.WriteLine("четвертое января 2000 года");
                                    Console.WriteLine("для данной заметки пока нет подробной инфонрмации, если вы хотите ее добавить, нажмите Enter");
                                    ConsoleKeyInfo keye = Console.ReadKey();
                                    if (keye.Key == ConsoleKey.Enter)
                                    {
                                        string b = (Console.ReadLine());
                                        Console.WriteLine("подробная информация для заметки успешно создана, нажмите Enter");
                                        ConsoleKeyInfo keyr = Console.ReadKey();
                                        if (keyr.Key == ConsoleKey.Enter)
                                        {
                                            Console.Clear();
                                            Console.WriteLine("четвертое января 2000 года");
                                            Console.WriteLine(b);
                                        }

                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}