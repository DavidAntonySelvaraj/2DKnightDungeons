using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ONE : MonoBehaviour
{

    private void Awake()
    {
        Hi();
        Hii();
    }
    public class Book
    {
        public string title;
        public int pages;
    }

    void Hi()
    {
        Book b1 = new Book();
        b1.title = "Harry";
        b1.pages = 1;
        Debug.Log(b1.title + " "+b1.pages);
    }

    void Hii()
    {
        Book b2 = new Book();
        b2.title = "Hry";
        b2.pages = 12;
        Debug.Log(b2.title + " " + b2.pages);
    }
}
