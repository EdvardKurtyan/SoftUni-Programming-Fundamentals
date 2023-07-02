//Change the program in such a way, that you will be able to store a list of articles.
//You will not need to use the previous methods anymore (except the "ToString()").
//On the first line, you will receive the number of articles.
//On the next lines, you will receive the articles in the same format as in the previous problem:
//"{title}, {content}, {author}".Finally, you will receive a string: "title", "content" or an "author".
//Print the articles. 

using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Article> allArticles = new List<Article>();
            int inputCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < inputCount; i++)
            {
                string[] input = Console.ReadLine().Split(", ");
                Article articles = new Article(input[0], input[1], input[2]);

                allArticles.Add(articles);
            }

            foreach (var curentArticle in allArticles)
            {
                Console.WriteLine(curentArticle);
            }

        }
        class Article
        {
            public Article(string title, string content, string author)
            {
                Title = title;
                Content = content;
                Author = author;
            }
            public string Title { get; set; }
            public string Content { get; set; }
            public string Author { get; set; }

            public void Rename(string title) => Title = title;
            public void Edit(string content) => Content = content;
            public void ChangedAuthor(string author) => Author = author;

            public override string ToString() => $"{Title} - {Content}: {Author}";
        }
    }
}
