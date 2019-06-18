using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Xamarin.Forms;

namespace ListViewColors
{
    public class Lesson
    {
        // Instance members.
        private Lesson()
        {
        }

        public string Name { private set; get; }

        public string FriendlyName { private set; get; }
        public string Text { private set; get; }

        public string RgbDisplay { private set; get; }

        // Static members.
        static Lesson()
        {
            List<Lesson> all = new List<Lesson>();

            {
                Lesson named = new Lesson
                    {
                        Name = "Выш.мат.",
                        FriendlyName = "Рубан А. С.",
                        Text = "Лабораторные",
                        RgbDisplay = String.Format("C {0:X2} до {1:X2} к.1, ауд 201", "8.30","10.05")
                    };
                all.Add(named);

                named = new Lesson
                {
                    Name = "Информатика",
                    FriendlyName = "Иванов А. А.",
                    Text = "Практика",
                    RgbDisplay = String.Format("C {0:X2} до {1:X2} к.16, ауд 105", "10.25", "12.35")
                };
                all.Add(named);

                named = new Lesson
                {
                    Name = "Философия",
                    FriendlyName = "Макенова Н. А.",
                    Text = "Лекция",
                    RgbDisplay = String.Format("C {0:X2} до {1:X2} к.2, ауд 21", "13.30", "15.05")
                };
                // Add it to the collection.
                all.Add(named);

                named = new Lesson
                {
                    Name = "Учет и аудит",
                    FriendlyName = "Степаненко С. Е.",
                    Text = "Лекция",
                    RgbDisplay = String.Format("C {0:X2} до {1:X2}  к.3, ауд 37", "15.30", "16.45")
                };
                // Add it to the collection.
                all.Add(named);
            }
            all.TrimExcess();
            All = all;
        }

        public static IList<Lesson> All { private set; get; }
    }
}