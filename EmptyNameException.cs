using System;


namespace RedBallTracker
{
    //ToDo Karolis: custom exception
    public class EmptyNameException : Exception
    {
        public EmptyNameException() : base("You must enter players name")
        {

        } 
    }
}
