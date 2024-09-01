// using System;


// class Time
// {
//     int hours, minutes, seconds;

//     public Time(int hours, int minutes, int seconds)
//     {
//         this.hours = hours;
//         this.minutes = minutes;
//         this.seconds = seconds;
//     }

//     public void display()
//     {
//         Console.WriteLine($"Time: {hours}:{minutes}:{seconds}");
//     }

//     public static Time operator +(Time t1, Time t2)
//     {
//         return new Time(t1.hours + t2.hours, t1.minutes + t2.minutes, t1.seconds + t2.seconds);
//     }
// }

// class Demo
// {
//     public static void Main(string[] args)
//     {
//         Time t1 = new Time(1,1,1);
//         Time t2 = new Time(1,1,1);

//         Time t3 = t1 + t2;

//         t3.display();
//     }
// }