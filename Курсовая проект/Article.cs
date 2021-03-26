using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсовая_проект
{
    class Article
    {
        public string authors;
        public int nauthors;
        public string title;
        public string journal;
        public string year;
        public string volume;
        public string pages;


        public Article()
        {
            authors = "";
            nauthors = 0;
            title = "";
            journal = "";
            year = "";
            volume = "";
            pages = "";
        }

        // Конструктор в который я передаю массив строк а он сам распределяет по полям значения.

        public Article(string[] strmas)
        {
            authors = "";
            nauthors = 1;
            title = "";
            journal = "";
            year = "";
            volume = "";
            pages = "";

            for (int i = 0; i < strmas.Length; i++)
            {
                // Если элемент не пустой.
                if (strmas[i] != null)
                {
                    // Если строка "автор". 
                    if (strmas[i].Substring(0, 7) == "author=")
                    {
                        // Заполнить поле "nauthors".
                        nauthors += strmas[i].Split(new string[] { " and " }, StringSplitOptions.None).Count();


                        // Заполнить поле "authors".
                        if (nauthors <= 4)
                        {
                            string[] aga = strmas[i].Substring(8, (strmas[i].Length - 10)).Split(new string[] { " and " }, StringSplitOptions.None);
                            foreach (string string1 in aga)
                            {
                                if (string1.Contains(", "))               // Строка содержит ", " то есть у автора есть инициалы помимо фамилии.
                                {
                                    string[] aut = string1.Split(new string[] { ", " }, StringSplitOptions.None);
                                    authors += aut[0] + " " + aut[1] + ", ";
                                }
                                else
                                {
                                    authors += string1 + ", ";
                                }
                            }
                        }
                        else
                        {
                            string[] aga = strmas[i].Substring(8, (strmas[i].Length - 10)).Split(new string[] { " and " }, StringSplitOptions.None);

                            if (aga[1].Contains(", "))               // Строка содержит ", " то есть у автора есть инициалы помимо фамилии.
                            {
                                string[] aut = aga[1].Split(new string[] { ", " }, StringSplitOptions.None);
                                authors += aut[0] + " " + aut[1] + " и др.   ";
                            }
                            else
                            {
                                authors += aga[1] + " и др.   ";
                            }

                        }
                        // Обрезаем с конца лишние запятую с пробелом.
                        authors = authors.Substring(0, authors.Length - 3);

                    }   // Если строка "author".

                    // Заполнить поле "title".
                    if (strmas[i].Substring(0, 6) == "title=")
                    {
                        title = strmas[i].Substring(7, (strmas[i].Length - 9));
                    }

                    // Заполнить поле "journal".
                    if (strmas[i].Substring(0, 8) == "journal=")
                    {
                        journal = strmas[i].Substring(9, (strmas[i].Length - 11));
                    }

                    // Заполнить поле "year".
                    if (strmas[i].Substring(0, 5) == "year=")
                    {
                        year = strmas[i].Substring(6, (strmas[i].Length - 8));
                    }

                    // Заполнить поле "volume".
                    if (strmas[i].Substring(0, 7) == "volume=")
                    {
                        volume = strmas[i].Substring(8, (strmas[i].Length - 10));
                    }

                    // Заполнить поле "pages".
                    if (strmas[i].Substring(0, 6) == "pages=")
                    {
                        pages = strmas[i].Substring(7, (strmas[i].Length - 9));
                    }

                }   // Если элемент не пустой.

            }   // Цикл проходящий через подающийся на вход массив.
        }
        
    }
}