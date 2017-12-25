using System;


namespace CarShowroom
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //TODO гибкий выбор модели
            //TODO если нет машин марки- выводить сообщение с пердложением предзаказа 
            // д/н, да - идем в предзаказ, нет - идем в начало
            //TODO вынести выбор модели, оплаты в отдельную функцию
            //TODO добавление команды
            //TODO добавление 1 шага купить/предзаказать
            //TODO проработать предазаказ(декоратор)
            string buyOrPreorder = "";

            Client client = new Client();
            CarShowroom carShowroom = new CarShowroom("Mamashova cars");
            Audi audiMark = new Audi();
            BMW bmwMark = new BMW();
            Mercedes mercedesMark = new Mercedes();

            AudiA8 audiA8 = new AudiA8();
            AudiR8 audiR8 = new AudiR8();
            var audiTT = new AudiTT();

        
            BMWM5 bmwM5 = new BMWM5();
            BMWX2 bmwX2 = new BMWX2();
            BMW750 bmw750 = new BMW750();

            var mercedesC63 = new MercedesC63();
            MercedesS600 mercedesS600 = new MercedesS600();
            MercedesSLS63 mercedesSLS63 = new MercedesSLS63();

            audiMark.Add(audiA8);
            audiMark.Add(audiR8);
            audiMark.Add(audiTT);

            bmwMark.Add(bmwM5);
            bmwMark.Add(bmwX2);
            bmwMark.Add(bmw750);

            mercedesMark.Add(mercedesC63);
            mercedesMark.Add(mercedesS600);
            mercedesMark.Add(mercedesSLS63);

            carShowroom.Add(audiMark);
            carShowroom.Add(bmwMark);
            carShowroom.Add(mercedesMark);

            client.SetCommand(new CarShowroomOnCommand(carShowroom));
            Console.WriteLine("Добро пожаловать в {0}", carShowroom.GetName());
            Console.WriteLine("1) Купить\t2) Предзаказать");
            Console.Write("Ваш выбор: ");
            do
            {
                buyOrPreorder = Console.ReadLine();
            } while (buyOrPreorder != "1" && buyOrPreorder != "2"); 

                if (buyOrPreorder == "1")
                {
                client.Buy();
                }
                else
                {
                client.PreOrder();
                }

            //Console.WriteLine(carShowroom.clientChoice);
            if (carShowroom.clientChoice == "Покупка")
            {
            start:
                string chosenMark = "";
                string chosenModel = "";
                string payForCar = "";
                Console.WriteLine("Выберите марку:");
                carShowroom.PrintMarks();
                do
                {
                    Console.Write("Ваш выбор: ");
                    chosenMark = Console.ReadLine();
                } while (chosenMark != "1" && chosenMark != "2" && chosenMark != "3");
                switch (chosenMark)
                {
                    case "1":
                        Console.WriteLine("Выберите модель ряда Ауди: ");
                        audiMark.Print();
                        do
                        {
                            Console.Write("Ваш выбор: ");
                            chosenModel = Console.ReadLine();
                        } while (chosenModel != "1" && chosenModel != "2" && chosenModel != "3");
                        if (chosenModel == "1")
                        {
                            Console.WriteLine("Ваш автомобиль: {0}", audiMark.components[0].GetName());
                            Console.WriteLine("Цена авто: {0}", audiMark.components[0].GetCost());
                            do
                            {
                                Console.WriteLine("Купить? д/н");
                                payForCar = Console.ReadLine();
                            } while (payForCar != "д" && payForCar != "н");
                            if (payForCar == "д")
                            {
                                Console.WriteLine("Спасибо!\nНаслаждайтесь вашим новым авто!\nХорошей дороги!");
                                audiMark.Remove(audiMark.components[0]);
                            }
                            else
                            {
                                Console.WriteLine("Очень жаль! Заходите еще!");
                            }
                            goto start;
                        }
                        else if (chosenModel == "2")
                        {
                            Console.WriteLine("Ваш автомобиль: {0}", audiMark.components[1].GetName());
                            Console.WriteLine("Цена авто: {0}", audiMark.components[1].GetCost());
                            do
                            {
                                Console.WriteLine("Купить? д/н");
                                payForCar = Console.ReadLine();
                            } while (payForCar != "д" && payForCar != "н");
                            if (payForCar == "д")
                            {
                                Console.WriteLine("Спасибо!\nНаслаждайтесь вашим новым авто!\nХорошей дороги!");
                                audiMark.Remove(audiMark.components[1]);
                            }
                            else
                            {
                                Console.WriteLine("Очень жаль! Заходите еще!");
                            }
                            goto start;
                        }
                        else if (chosenModel == "3")
                        {
                            Console.WriteLine("Ваш автомобиль: {0}", audiMark.components[2].GetName());
                            Console.WriteLine("Цена авто: {0}", audiMark.components[2].GetCost());
                            do
                            {
                                Console.WriteLine("Купить? д/н");
                                payForCar = Console.ReadLine();
                            } while (payForCar != "д" && payForCar != "н");
                            if (payForCar == "д")
                            {
                                Console.WriteLine("Спасибо!\nНаслаждайтесь вашим новым авто!\nХорошей дороги!");
                                audiMark.Remove(audiMark.components[2]);
                            }
                            else
                            {
                                Console.WriteLine("Очень жаль! Заходите еще!");
                            }
                            goto start;
                        }
                        break;
                    case "2":
                        Console.WriteLine("Выберите модель ряда БМВ: ");
                        bmwMark.Print();
                        do
                        {
                            Console.Write("Ваш выбор: ");
                            chosenModel = Console.ReadLine();
                        } while (chosenModel != "1" && chosenModel != "2" && chosenModel != "3");
                        if (chosenModel == "1")
                        {
                            Console.WriteLine("Ваш автомобиль: {0}", bmwM5.GetName());
                            Console.WriteLine("Цена авто: {0}", bmwM5.GetCost());
                            do
                            {
                                Console.WriteLine("Купить? д/н");
                                payForCar = Console.ReadLine();
                            } while (payForCar != "д" && payForCar != "н");
                            if (payForCar == "д")
                            {
                                Console.WriteLine("Спасибо!\nНаслаждайтесь вашим новым авто!\nХорошей дороги!");
                            }
                            else
                            {
                                Console.WriteLine("Очень жаль! Заходите еще!");
                            }
                            goto start;
                        }
                        else if (chosenModel == "2")
                        {
                            Console.WriteLine("Ваш автомобиль: {0}", bmwX2.GetName());
                            Console.WriteLine("Цена авто: {0}", bmwX2.GetCost());
                            do
                            {
                                Console.WriteLine("Купить? д/н");
                                payForCar = Console.ReadLine();
                            } while (payForCar != "д" && payForCar != "н");
                            if (payForCar == "д")
                            {
                                Console.WriteLine("Спасибо!\nНаслаждайтесь вашим новым авто!\nХорошей дороги!");
                            }
                            else
                            {
                                Console.WriteLine("Очень жаль! Заходите еще!");
                            }
                            goto start;
                        }
                        else if (chosenModel == "3")
                        {
                            Console.WriteLine("Ваш автомобиль: {0}", bmw750.GetName());
                            Console.WriteLine("Цена авто: {0}", bmw750.GetCost());
                            do
                            {
                                Console.WriteLine("Купить? д/н");
                                payForCar = Console.ReadLine();
                            } while (payForCar != "д" && payForCar != "н");
                            if (payForCar == "д")
                            {
                                Console.WriteLine("Спасибо!\nНаслаждайтесь вашим новым авто!\nХорошей дороги!");
                            }
                            else
                            {
                                Console.WriteLine("Очень жаль! Заходите еще!");
                            }
                            goto start;
                        }

                        break;
                    case "3":
                        Console.WriteLine("Выберите модель ряда Мерседес: ");
                        mercedesMark.Print();
                        do
                        {
                            Console.Write("Ваш выбор: ");
                            chosenModel = Console.ReadLine();
                        } while (chosenModel != "1" && chosenModel != "2" && chosenModel != "3");
                        if (chosenModel == "1")
                        {
                            Console.WriteLine("Ваш автомобиль: {0}", mercedesC63.GetName());
                            Console.WriteLine("Цена авто: {0}", mercedesC63.GetCost());
                            do
                            {
                                Console.WriteLine("Купить? д/н");
                                payForCar = Console.ReadLine();
                            } while (payForCar != "д" && payForCar != "н");
                            if (payForCar == "д")
                            {
                                Console.WriteLine("Спасибо!\nНаслаждайтесь вашим новым авто!\nХорошей дороги!");
                            }
                            else
                            {
                                Console.WriteLine("Очень жаль! Заходите еще!");
                            }
                            goto start;
                        }
                        else if (chosenModel == "2")
                        {
                            Console.WriteLine("Ваш автомобиль: {0}", mercedesS600.GetName());
                            Console.WriteLine("Цена авто: {0}", mercedesS600.GetCost());
                            do
                            {
                                Console.WriteLine("Купить? д/н");
                                payForCar = Console.ReadLine();
                            } while (payForCar != "д" && payForCar != "н");
                            if (payForCar == "д")
                            {
                                Console.WriteLine("Спасибо!\nНаслаждайтесь вашим новым авто!\nХорошей дороги!");
                            }
                            else
                            {
                                Console.WriteLine("Очень жаль! Заходите еще!");
                            }
                            goto start;
                        }
                        else if (chosenModel == "3")
                        {
                            Console.WriteLine("Ваш автомобиль: {0}", mercedesSLS63.GetName());
                            Console.WriteLine("Цена авто: {0}", mercedesSLS63.GetCost());
                            do
                            {
                                Console.WriteLine("Купить? д/н");
                                payForCar = Console.ReadLine();
                            } while (payForCar != "д" && payForCar != "н");
                            if (payForCar == "д")
                            {
                                Console.WriteLine("Спасибо!\nНаслаждайтесь вашим новым авто!\nХорошей дороги!");
                            }
                            else
                            {
                                Console.WriteLine("Очень жаль! Заходите еще!");
                            }
                            goto start;
                        }
                        break;
                    default:
                        break;
                }
            }
            //PREORDER
            else
            {
                string chosenMark = "";
                string chosenModel = "";
                string chosenOption = "";


                var newAudiA8 = new AudiA8();
                AudiR8 newAudiR8 = new AudiR8();
                var newAudiTT = new AudiTT();


                BMWM5 newBmwM5 = new BMWM5();
                BMWX2 newBmwX2 = new BMWX2();
                BMW750 newBmw750 = new BMW750();

                var newMercedesC63 = new MercedesC63();
                MercedesS600 newMercedesS600 = new MercedesS600();
                MercedesSLS63 newMercedesSLS63 = new MercedesSLS63();

                Console.WriteLine("Выберите Марку: ");
                Console.WriteLine("1) Audi 2) BMW 3) Mercedes");
                do
                {
                    chosenMark = Console.ReadLine();
                } while (chosenMark != "1" && chosenMark != "2" && chosenMark != "3");
                //AUDI
                if(chosenMark == "1") {
                    Console.WriteLine("Выберите модель");
                    Console.WriteLine("1) Audi A8\n2) Audi R8\n3) Audi TT");
                    do
                    {
                        chosenModel = Console.ReadLine();
                    } while (chosenModel != "1" && chosenModel != "2" && chosenModel != "3");
                    if (chosenModel == "1")
                    {
                        Console.WriteLine("Выбранное авто: {0}", audiA8.GetName());
                        Console.WriteLine("Цена: {0}", audiA8.GetCost());
                        Console.WriteLine("Выберите дополнительную опцию:");
                        Console.WriteLine("1)Кондиционер(+500$)" +
                                          "\n2)Двигатель(+15000$)" +
                                          "\n3)Роспись(+2000$)" +
                                          "\n4)Покрышки(+900$)");
                        do
                        {
                            chosenOption = Console.ReadLine();
                        } while (chosenOption != "1" && chosenOption != "2" && chosenOption != "3" && chosenOption != "4");
                        switch (chosenOption)
                        {
                            case "1":
                                var nwAudiA8Cond = new Conditioner(new AudiA8());
                                Console.WriteLine("Ваш авто {0} ждет вас через месяц", nwAudiA8Cond.GetName());
                                Console.WriteLine("Стоимость: {0}", nwAudiA8Cond.GetCost());
                                break;
                            case "2":
                                var newAudiA8Eng = new Engine(new AudiA8());
                                Console.WriteLine("Ваш авто {0} ждет вас через месяц", newAudiA8Eng.GetName());
                                Console.WriteLine("Стоимость: {0}", newAudiA8Eng.GetCost());
                                break;
                            case "3":
                                var newAudiA8Meh = new Mehendi(new AudiA8());
                                Console.WriteLine("Ваш авто {0} ждет вас через месяц", newAudiA8Meh.GetName());
                                Console.WriteLine("Стоимость: {0}", newAudiA8Meh.GetCost());
                                break;
                            case "4":
                                var newAudiA8Tires = new Tires(new AudiA8());
                                Console.WriteLine("Ваш авто {0} ждет вас через месяц", newAudiA8Tires.GetName());
                                Console.WriteLine("Стоимость: {0}", newAudiA8Tires.GetCost());
                                break;
                        }
                    }
                    if (chosenModel == "2")
                    {
                        Console.WriteLine("Выбранное авто: {0}", audiR8.GetName());
                        Console.WriteLine("Цена: {0}", audiR8.GetCost());
                        Console.WriteLine("Выберите дополнительную опцию:");
                        Console.WriteLine("1)Кондиционер(+500$)" +
                                          "\n2)Двигатель(+15000$)" +
                                          "\n3)Роспись(+2000$)" +
                                          "\n4)Покрышки(+900$)");
                        do
                        {
                            chosenOption = Console.ReadLine();
                        } while (chosenOption != "1" && chosenOption != "2" && chosenOption != "3" && chosenOption != "4");
                        switch (chosenOption)
                        {
                            case "1":
                                var nwAudiR8Cond = new Conditioner(new AudiR8());
                                Console.WriteLine("Ваш авто {0} ждет вас через месяц", nwAudiR8Cond.GetName());
                                Console.WriteLine("Стоимость: {0}", nwAudiR8Cond.GetCost());
                                break;
                            case "2":
                                var newAudiR8Eng = new Engine(new AudiR8());
                                Console.WriteLine("Ваш авто {0} ждет вас через месяц", newAudiR8Eng.GetName());
                                Console.WriteLine("Стоимость: {0}", newAudiR8Eng.GetCost());
                                break;
                            case "3":
                                var newAudiR8Meh = new Mehendi(new AudiR8());
                                Console.WriteLine("Ваш авто {0} ждет вас через месяц", newAudiR8Meh.GetName());
                                Console.WriteLine("Стоимость: {0}", newAudiR8Meh.GetCost());
                                break;
                            case "4":
                                var newAudiR8Tires = new Tires(new AudiR8());
                                Console.WriteLine("Ваш авто {0} ждет вас через месяц", newAudiR8Tires.GetName());
                                Console.WriteLine("Стоимость: {0}", newAudiR8Tires.GetCost());
                                break;
                        }
                    }
                            if (chosenModel == "3")
                            {
                                Console.WriteLine("Выбранное авто: {0}", audiTT.GetName());
                                Console.WriteLine("Цена: {0}", audiTT.GetCost());
                                Console.WriteLine("Выберите дополнительную опцию:");
                                Console.WriteLine("1)Кондиционер(+500$)" +
                                                  "\n2)Двигатель(+15000$)" +
                                                  "\n3)Роспись(+2000$)" +
                                                  "\n4)Покрышки(+900$)");
                                do
                                {
                                    chosenOption = Console.ReadLine();
                                } while (chosenOption != "1" && chosenOption != "2" && chosenOption != "3" && chosenOption != "4");
                                switch (chosenOption)
                                {
                                    case "1":
                                        var nwAudiTTCond = new Conditioner(new AudiTT());
                                        Console.WriteLine("Ваш авто {0} ждет вас через месяц", nwAudiTTCond.GetName());
                                        Console.WriteLine("Стоимость: {0}", nwAudiTTCond.GetCost());
                                        break;
                                    case "2":
                                        var nwAudiTTEng = new Engine(new AudiTT());
                                        Console.WriteLine("Ваш авто {0} ждет вас через месяц", nwAudiTTEng.GetName());
                                        Console.WriteLine("Стоимость: {0}", nwAudiTTEng.GetCost());
                                        break;
                                    case "3":
                                        var newAudiTTMeh = new Mehendi(new AudiTT());
                                        Console.WriteLine("Ваш авто {0} ждет вас через месяц", newAudiTTMeh.GetName());
                                        Console.WriteLine("Стоимость: {0}", newAudiTTMeh.GetCost());
                                        break;
                                    case "4":
                                        var newAudiTTTires = new Tires(new AudiTT());
                                        Console.WriteLine("Ваш авто {0} ждет вас через месяц", newAudiTTTires.GetName());
                                        Console.WriteLine("Стоимость: {0}", newAudiTTTires.GetCost());
                                        break;
                                }
                       // Console.WriteLine("Ваш авто {0} ждет вас через месяц", );

                    }
                }
            }
        }
    }
}
        
