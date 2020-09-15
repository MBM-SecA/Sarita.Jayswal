//Creates a function that takes a two word string separated by space and returns the concatenated first characters of both the words.

using System;

public class StringInitials
{
    internal string Initials(string name)
    {
        string initials = "";
        int length = name.Length;
        int n = 0;
        initials += name[0];
        for(n = 0; n < length; n++)
        {
            if (name[n] == ' ')
            {
                initials += name[++n];
                break;
            }
        }
        return initials;
    }
}