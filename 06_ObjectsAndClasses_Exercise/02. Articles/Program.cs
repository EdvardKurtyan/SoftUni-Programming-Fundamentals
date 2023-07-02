//Create a class Article with the following properties:
//•	Title – a string
//•	Content – a string
//•	Author – a string
//The class should have a constructor and the following methods:
//•	Edit(new content) – change the old content with the new one
//•	ChangeAuthor(new author) – change the author
//•	Rename (new title) – change the title of the article
//•	Override the ToString method – print the article in the following format: 
//"{title} - {content}: {author}"
//Create a program that reads an article in the following format "{title}, {content}, {author}".
//On the next line, you will receive a number n, representing the number of commands, which will follow after it. On the next n lines,
//you will be receiving the following commands: 
//•	"Edit: {new content}"
//•	"ChangeAuthor: {new author}"
//•	"Rename: {new title}"
//In the end, print the final state of the article.

using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] givenArticle = Console.ReadLine().Split(", ");
            Article article = new Article(givenArticle[0], givenArticle[1], givenArticle[2]);
            int changesCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < changesCount; i++)
            {
                string[] action = Console.ReadLine().Split(": ");
                string command = action[0];
                string argument = action[1];
                switch (command)
                {
                    case "Edit":
                        article.Edit(argument);
                        break;
                    case "ChangeAuthor":
                        article.ChangedAuthor(argument);
                        break;
                    case "Rename":
                        article.Rename(argument);
                        break;
                }
            }
            Console.WriteLine(article);

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
