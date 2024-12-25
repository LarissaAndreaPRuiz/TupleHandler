using System;
namespace UserDataProcessing.Models;

class Program
{
    static void Main()
    {
        var handler = new TupleHandler();
        
        var userData = handler.GetUserData();
        
        handler.DisplayUserInfo(userData);
    }
}