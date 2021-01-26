using System;
using System.Collections.Generic;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Pages myPage = new Pages();

            myPage.Facebook("First page was Photos");
            myPage.Facebook("Second page was Timeline");
            myPage.Facebook("Third page was Story");


            
            
            myPage.GoBack();
            myPage.OpenFirstPage();



        }
    }
}
public class Pages
{
    private Stack<string> facebookStack = new Stack<string>();
    private Stack<string> LastPage = new Stack<string>();


    public void Facebook(string FirstPage)
    {
        facebookStack.Push(FirstPage);

        foreach (var item in facebookStack)
        {
            Console.WriteLine("The page I visited are the following:"
                          + item);
        }
    }

    public void GoBack()
    {
        string MyLastPage = facebookStack.Pop();
        LastPage.Push(MyLastPage);
    }
    public void OpenFirstPage()
    {
        foreach(var item in facebookStack)
        {
            Console.WriteLine("The page I visited are the following:"
                          + item);
        }

    }
}
