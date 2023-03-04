using System;
using System.Threading;

namespace project_frog_caglar
{
    class Program
    {
        static void Main(string[] args)
        {
            int posx = 55, posy = 14;
            ConsoleKeyInfo keyInfo;
            Console.CursorVisible = false;

            int carPosition = 0;
            int carLength = 0;
            int carSpeed = 0;
            int carLane = 0;

            Random rnd = new Random();
            DateTime date1 = DateTime.Now;
            DateTime date2 = DateTime.Now;
            int timer = 0;

            char[] lane1 = new char[50];
            char[] lane2 = new char[50];   //70 li olursa daha iyi ?
            char[] lane3 = new char[50];
            char[] lane4 = new char[50];

            for (int i = 0; i < 50; i++)
            {
                lane1[i] = '-';   //i sıralı indexine - koy
                lane2[i] = '-';
                lane3[i] = '-';
                lane4[i] = '-';
            }
            for (int i = 0; i < 12; i++)
            {
                carLane = rnd.Next(1, 3);
                if (carLane == 1)
                {
                    carSpeed = rnd.Next(1, 3);
                    carPosition = rnd.Next(1, 46);
                    carLength = rnd.Next(2, 5);
                    if (carLength == 2 && lane1[carPosition] == '-' && lane1[carPosition + 1] == '-' && lane1[carPosition + 2] == '-' && lane1[carPosition - 1] == '-' && carPosition <= 47)  //position kontrolü ekle
                    {
                        lane1[carPosition] = Convert.ToChar(carSpeed.ToString());
                        lane1[carPosition + 1] = Convert.ToChar(carSpeed.ToString());
                        lane1[carPosition + 2] = Convert.ToChar(carSpeed.ToString());
                        lane1[carPosition + 3] = Convert.ToChar(carSpeed.ToString());

                    }
                    else if (carLength == 3 && lane1[carPosition] == '-' && lane1[carPosition + 1] == '-' && lane1[carPosition + 2] == '-' && lane1[carPosition + 3] == '-' && lane1[carPosition - 1] == '-' && carPosition <= 46)
                    {
                        lane1[carPosition] = Convert.ToChar(carSpeed.ToString());
                        lane1[carPosition + 1] = Convert.ToChar(carSpeed.ToString());
                        lane1[carPosition + 2] = Convert.ToChar(carSpeed.ToString());
                    }
                    else if (carLength == 4 && lane1[carPosition] == '-' && lane1[carPosition + 1] == '-' && lane1[carPosition + 2] == '-' && lane1[carPosition + 3] == '-' && lane1[carPosition - 1] == '-' && lane1[carPosition + 4] == '-' && carPosition <= 45)
                    {
                        lane1[carPosition] = Convert.ToChar(carSpeed.ToString());
                        lane1[carPosition + 1] = Convert.ToChar(carSpeed.ToString());
                        lane1[carPosition + 2] = Convert.ToChar(carSpeed.ToString());
                        lane1[carPosition + 3] = Convert.ToChar(carSpeed.ToString());
                    }
                    else
                        i--;
                }
                //if (carLane == 2)
                //{
                //	carSpeed = rnd.Next(1, 3);
                //	carPosition = rnd.Next(1, 46);
                //	carLength = rnd.Next(2, 5);
                //	if (carLength == 2 && lane2[carPosition] == '-' && lane2[carPosition + 1] == '-' && lane2[carPosition + 2] == '-' && lane2[carPosition - 1] == '-' && carPosition <= 47)  //position kontrolü ekle
                //	{
                //		lane2[carPosition] = Convert.ToChar(carSpeed.ToString());
                //		lane2[carPosition + 1] = Convert.ToChar(carSpeed.ToString());
                //	}
                //	else if (carLength == 3 && lane2[carPosition] == '-' && lane2[carPosition + 1] == '-' && lane2[carPosition + 2] == '-' && lane2[carPosition + 3] == '-' && lane2[carPosition - 1] == '-' && carPosition <= 46)
                //	{
                //		lane2[carPosition] = Convert.ToChar(carSpeed.ToString());
                //		lane2[carPosition + 1] = Convert.ToChar(carSpeed.ToString());
                //		lane2[carPosition + 2] = Convert.ToChar(carSpeed.ToString());
                //	}
                //	else if (carLength == 4 && lane2[carPosition] == '-' && lane2[carPosition + 1] == '-' && lane2[carPosition + 2] == '-' && lane2[carPosition + 3] == '-' && lane2[carPosition + 4] == '-' && carPosition <= 45)
                //	{
                //		lane2[carPosition] = Convert.ToChar(carSpeed.ToString());
                //		lane2[carPosition + 1] = Convert.ToChar(carSpeed.ToString());
                //		lane2[carPosition + 2] = Convert.ToChar(carSpeed.ToString());
                //		lane2[carPosition + 3] = Convert.ToChar(carSpeed.ToString());
                //	}
                //	else
                //		i--;
                //}
            }
            for (int i = 0; i < 12; i++)
            {
                carLane = rnd.Next(3, 5);
                if (carLane == 3)
                {
                    carSpeed = rnd.Next(1, 3);
                    carPosition = rnd.Next(1, 46);
                    carLength = rnd.Next(2, 5);
                    if (carLength == 2 && lane3[carPosition] == '-' && lane3[carPosition + 1] == '-' && lane3[carPosition + 2] == '-' && lane3[carPosition - 1] == '-' && carPosition <= 47)  //position kontrolü ekle
                    {
                        lane3[carPosition] = Convert.ToChar(carSpeed.ToString());
                        lane3[carPosition + 1] = Convert.ToChar(carSpeed.ToString());

                    }
                    else if (carLength == 3 && lane3[carPosition] == '-' && lane3[carPosition + 1] == '-' && lane3[carPosition + 2] == '-' && lane3[carPosition + 3] == '-' && lane3[carPosition - 1] == '-' && carPosition <= 46)
                    {
                        lane3[carPosition] = Convert.ToChar(carSpeed.ToString());
                        lane3[carPosition + 1] = Convert.ToChar(carSpeed.ToString());
                        lane3[carPosition + 2] = Convert.ToChar(carSpeed.ToString());
                    }
                    else if (carLength == 4 && lane1[carPosition] == '-' && lane1[carPosition + 1] == '-' && lane1[carPosition + 2] == '-' && lane1[carPosition + 3] == '-' && lane3[carPosition + 4] == '-' && lane3[carPosition - 1] == '-' && carPosition <= 45)
                    {
                        lane3[carPosition] = Convert.ToChar(carSpeed.ToString());
                        lane3[carPosition + 1] = Convert.ToChar(carSpeed.ToString());
                        lane3[carPosition + 2] = Convert.ToChar(carSpeed.ToString());
                        lane3[carPosition + 3] = Convert.ToChar(carSpeed.ToString());
                    }
                    else
                        i--;
                }
                if (carLane == 4)
                {
                    carSpeed = rnd.Next(1, 3);
                    carPosition = rnd.Next(1, 46);
                    carLength = rnd.Next(2, 5);
                    if (carLength == 2 && lane4[carPosition] == '-' && lane4[carPosition + 1] == '-' && lane4[carPosition + 2] == '-' && lane4[carPosition - 1] == '-' && carPosition <= 47)  //position kontrolü ekle
                    {
                        lane4[carPosition] = Convert.ToChar(carSpeed.ToString());
                        lane4[carPosition + 1] = Convert.ToChar(carSpeed.ToString());
                    }
                    else if (carLength == 3 && lane4[carPosition] == '-' && lane4[carPosition + 1] == '-' && lane4[carPosition + 2] == '-' && lane4[carPosition + 3] == '-' && lane4[carPosition - 1] == '-' && carPosition <= 46)
                    {
                        lane4[carPosition] = Convert.ToChar(carSpeed.ToString());
                        lane4[carPosition + 1] = Convert.ToChar(carSpeed.ToString());
                        lane4[carPosition + 2] = Convert.ToChar(carSpeed.ToString());
                    }
                    else if (carLength == 4 && lane4[carPosition] == '-' && lane4[carPosition + 1] == '-' && lane4[carPosition + 2] == '-' && lane4[carPosition + 3] == '-' && lane4[carPosition + 4] == '-' && lane4[carPosition - 1] == '-' && carPosition <= 45)
                    {
                        lane4[carPosition] = Convert.ToChar(carSpeed.ToString());
                        lane4[carPosition + 1] = Convert.ToChar(carSpeed.ToString());
                        lane4[carPosition + 2] = Convert.ToChar(carSpeed.ToString());
                        lane4[carPosition + 3] = Convert.ToChar(carSpeed.ToString());
                    }
                    else
                        i--;
                }

            }
            Console.SetCursorPosition(30, 9);
            for (int o = 0; o < 50; o++)
            {
                Console.Write("=");
            }
            Console.SetCursorPosition(30, 10);
            for (int i = 0; i < 50; i++)
            {
                Console.Write(lane1[i]);       //i sıralı indextekini yazdır
            }
            Console.SetCursorPosition(30, 11);
            for (int j = 0; j < 50; j++)
            {
                Console.Write(lane2[j]);
            }
            Console.SetCursorPosition(30, 12);
            for (int k = 0; k < 50; k++)
            {
                Console.Write(lane3[k]);
            }
            Console.SetCursorPosition(30, 13);
            for (int l = 0; l < 50; l++)
            {
                Console.Write(lane4[l]);
            }
            Console.SetCursorPosition(30, 14);
            for (int p = 0; p < 50; p++)
            {
                Console.Write("=");
            }
            while (true)   //frog movement
            {
                if (Console.KeyAvailable)
                {
                    keyInfo = Console.ReadKey(true);
                    if (keyInfo.Key == ConsoleKey.RightArrow && posx < 79)  //Boundaries 
                    {
                        Console.SetCursorPosition(posx, posy);
                        if (posy == 9 || posy == 14)              //şeklin bozulmaması için
                            Console.Write("=");
                        else
                            Console.Write("-");
                        posx++;
                    }
                    else if (keyInfo.Key == ConsoleKey.LeftArrow && posx > 30)
                    {
                        Console.SetCursorPosition(posx, posy);
                        if (posy == 9 || posy == 14)
                            Console.Write("=");
                        else
                            Console.Write("-");
                        posx--;
                    }
                    else if (keyInfo.Key == ConsoleKey.UpArrow && posy > 9)
                    {
                        Console.SetCursorPosition(posx, posy);
                        if (posy == 9 || posy == 14)
                            Console.Write("=");
                        else
                            Console.Write("-");
                        posy--;
                    }
                    else if (keyInfo.Key == ConsoleKey.DownArrow && posy < 14)
                    {
                        Console.SetCursorPosition(posx, posy);
                        if (posy == 9 || posy == 14)
                            Console.Write("=");
                        else
                            Console.Write("-");
                        posy++;
                    }

                }
                date2 = DateTime.Now;
                TimeSpan ts = date2 - date1;
                if (ts.TotalMilliseconds / 1000 >= 1)
                {
                    timer++;
                    date1 = date2;
                    Console.SetCursorPosition(30, 8);
                    Console.WriteLine("Time :" + timer);


                    //shift
                    //for (int i = 1; i < 50; i++)
                    //{

                    //}
                    for (int i = 5; i < 50; i++)
                    {
                            if (lane1[i] == '2')
                            {
                            
                            if (lane1[i - 1] == '-' && lane1[i - 2] == '1' && lane1[i + 1] == '2')
                            {
                                
                                
                                    Console.SetCursorPosition(posy, 10);
                                    
                                    Console.Beep(50, 50);
                                
                                    lane1[i - 1] = lane1[i]; 
                                    lane1[i] = '2';
                                

                                }
                            else
                            {
                                lane1[i - 2] = lane1[i];
                                lane1[i] = '-';

                                //  if (!(lane2[i - 1] == '-' && lane1[i - 2] == '-' && lane1[i - 3] == '-')) ;

                            }
                        }
                        else
                        {
                            lane1[i - 1] = lane1[i];
                            lane1[i] = '-';
                        }

                        lane2[i - 1] = lane2[i];
                        lane2[i] = '-';

                        //if (lane1[i - 1] == '2' && lane1[i - 2] == '-' && lane1[i - 3] == '1')
                        //{
                        //	if (lane2[i - 1] == '-' && lane1[i - 2] == '-' && lane1[i - 3] == '-')
                        //		Console.SetCursorPosition(11, posy);
                        //	//if (!(lane2[i - 1] == '-' && lane1[i - 2] == '-' && lane1[i - 3] == '-'))
                        //}

                        //if (lane1[i] == '2')
                        //{
                        //	lane1[i - 2] = lane1[i];
                        //	lane1[i] = '-';
                        //	if (lane1[i - 3] == '-' & lane1[i - 4] == '1')
                        //	{
                        //		lane1[i - 3] = lane1[i - 2];
                        //	}
                        //}
                        //else
                        //{
                        //	lane1[i - 1] = lane1[i];
                        //	lane1[i] = '-';
                        //}



                        //}  





                    }



                    //print
                    for (int i = 0; i < 50; i++)
                    {
                        Console.SetCursorPosition(30, 10);
                        Console.Write(lane1);       //i sıralı indextekini yazdır
                        Console.SetCursorPosition(30, 11);
                        Console.Write(lane2);       //i sıralı indextekini yazdır
                        Console.SetCursorPosition(30, 12);
                        Console.Write(lane3);       //i sıralı indextekini yazdır
                        Console.SetCursorPosition(30, 13);
                        Console.Write(lane4);       //i sıralı indextekini yazdır
                    }
                    Console.SetCursorPosition(posx, posy);
                    Console.Write("F");
                }



            }
        }
    }
}